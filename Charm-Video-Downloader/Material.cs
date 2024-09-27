using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System.Text.RegularExpressions;
using System.Windows;
using Toastr.Winforms;
using YoutubeDLSharp;
using YoutubeDLSharp.Options;


namespace form_summon
{
    public partial class Material : MaterialForm
    {
        public Material()
        {
            InitializeComponent();
            DownloadListBox.Items.Clear();
            progress = new Progress<DownloadProgress>((p) => showProgress(p));
        }

        public YoutubeDL YoutubeDL { get; }
        private IProgress<DownloadProgress> progress;
        private IProgress<string> output;
        string DownloadFolder = @"downloads";
        bool isNotDownloading = true;
        private async Task CheckReqs()
        {
            if (!File.Exists("ffmpeg.exe") && !File.Exists("yt-dlp.exe"))
            {
                DialogResult mresult = MaterialMessageBox.Show("Would you like me to download ffmpeg and yt-dlp?", "Missing Files", MessageBoxButtons.YesNo, MaterialFlexibleForm.ButtonsPosition.Center);
                if (mresult == DialogResult.Yes)
                {
                    await YoutubeDLSharp.Utils.DownloadYtDlp();
                    await YoutubeDLSharp.Utils.DownloadFFmpeg();
                    MaterialMessageBox.Show(this, "The Files were downloaded!", "Ready to use", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (mresult == DialogResult.No)
                {
                    MaterialMessageBox.Show(this, "Without ffmpeg and yt-dlp, this program don't work!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!File.Exists("ffmpeg.exe"))
            {
                var Result = System.Windows.MessageBox.Show("Would you like me to download ffmpeg?", "Missing File", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (Result == MessageBoxResult.Yes)
                {
                    await YoutubeDLSharp.Utils.DownloadFFmpeg();
                    MaterialMessageBox.Show(this, "The File were downloaded!", "Ready to use", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Result == MessageBoxResult.No)
                {
                    MaterialMessageBox.Show(this, "Without ffmpeg, this program don't work!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!File.Exists("yt-dlp.exe"))
            {
                var Result = System.Windows.MessageBox.Show("Would you like me to download yt-dlp?", "Missing File", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (Result == MessageBoxResult.Yes)
                {
                    await YoutubeDLSharp.Utils.DownloadYtDlp();
                    MaterialMessageBox.Show(this, "The File were downloaded!", "Ready to use", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Result == MessageBoxResult.No)
                {
                    MaterialMessageBox.Show(this, "Without yt-dlp, this program don't work!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void Material_Load(object sender, EventArgs e)
        {
            await CheckReqs();
        }

        private void showProgress(DownloadProgress p)
        {
            MainProgressbar.Value = (int)(p.Progress * 100);
            labelDownloadSpeed.Text = $"Downloadspeed: {p.DownloadSpeed} | left: {p.ETA}";
        }

        bool IsValidURL(string URL)
        {
            string Pattern = @"^(?:http(s)?:\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\(\)\*\+,;=.]+$";
            Regex Rgx = new Regex(Pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            return Rgx.IsMatch(URL);
        }

        private void AddUrlButton_Click(object sender, EventArgs e)
        {
            var toast = new Toast(ToastrPosition.BottomRight, duration: 3000, enableSoundEffect: true);
            if (IsValidURL(LinkAdderBox.Text))
            {
                _snackbar(LinkAdderBox.Text + " added!");
                DownloadListBox.Items.Add(LinkAdderBox.Text);
                LinkAdderBox.Clear();
            }
            else
            {
                MaterialMessageBox.Show(this, "Paste a valid URL!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LinkAdderBox.Clear();
            }
        }

        public void _snackbar(string msg)
        {
            MaterialSnackBar SnackBarMessage = new(msg);
            SnackBarMessage.Show(this);
        }

        private CancellationTokenSource cts = new CancellationTokenSource();
        public async Task DownloadVideos()
        {
            cts.Dispose(); // Clean up old token source....
            cts = new CancellationTokenSource(); // "Reset" the cancellation token source...
            var ytdl = new YoutubeDL();
            ytdl.OutputFolder = DownloadFolder;
            var options = new OptionSet()
            {
                ForceOverwrites = true,
                RestrictFilenames = true,
                //Format = "best",
                RemuxVideo = "mp4"
            };
            isNotDownloading = false;
            foreach (var listBoxItem in DownloadListBox.Items)
            {
                _snackbar(listBoxItem.ToString() + " download started!");
                

                // a cancellation token source used for cancelling the download
                // use `cts.Cancel();` to perform cancellation

                RunResult<string> result;
                
                
                result = await ytdl.RunVideoDownload(listBoxItem.ToString(),
                                progress: progress, ct: cts.Token, overrideOptions: options);
                if (result.Success)
                {
                    var toast = new Toast(ToastrPosition.TopRight, duration: 3000, enableSoundEffect: true);
                    toast.ShowSuccess(listBoxItem.ToString() + " download finished!");

                }
                else
                {
                    var toast = new Toast(ToastrPosition.TopRight, duration: 3000, enableSoundEffect: true);
                    toast.ShowError(listBoxItem.ToString() + " download failed!");
                }
                

            }
            isNotDownloading = true;
            DownloadListBox.Items.Clear();
            MaterialMessageBox.Show(this, "All Downloads Completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void StartDownloadButton_Click(object sender, EventArgs e)
        {
            if (DownloadListBox.Items.Count > 0)
            {
                try
                {
                    await DownloadVideos();
                }
                catch (Exception ex)
                {
                    MaterialMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                MaterialMessageBox.Show(this, "Please add links first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (!isNotDownloading)
            {
                cts.Cancel();
                
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (DownloadListBox.Items.Count > 1)
            {
                if (DownloadListBox.SelectedIndex == -1)
                {

                    MaterialMessageBox.Show(this, "Please select the link to delete first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DownloadListBox.Items.RemoveAt(DownloadListBox.SelectedIndex);
                }

            }
            else
            {
                DownloadListBox.Items.Clear();
            }
        }

        private void ClearListButton_Click(object sender, EventArgs e)
        {
            DownloadListBox.Items.Clear();
        }

        private void LinkAdderBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddUrlButton_Click(this, new EventArgs());
            }
        }

        private void parrotGauge1_Click(object sender, EventArgs e)
        {

        }
    }
}