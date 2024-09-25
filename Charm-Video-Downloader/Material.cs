using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System.Text.RegularExpressions;
using System.Windows;
using Toastr.Winforms;
using YoutubeDLSharp;


namespace form_summon
{
    public partial class Material : MaterialForm
    {
        public Material()
        {
            InitializeComponent();
            DownloadListBox.Items.Clear();
        }

        public YoutubeDL YoutubeDL { get; }
        
        private async Task CheckReqs()
        {
            if (!File.Exists("ffmpeg.exe") && !File.Exists("yt-dlp.exe"))
            {
                string batchOperationResults;
                batchOperationResults = "Would you like me to download ffmpeg and yt-dlp?";
                DialogResult mresult = MaterialMessageBox.Show(batchOperationResults, "Missing Files", MessageBoxButtons.YesNo, MaterialFlexibleForm.ButtonsPosition.Center);
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
            
            var ytdl = new YoutubeDL();
            foreach (var listBoxItem in DownloadListBox.Items)
            {
                _snackbar(listBoxItem.ToString() + " download started!");
                //_notificationManager.Show("Start", listBoxItem.ToString() + " download started!", NotificationType.Information, "WindowArea");
                
                // a cancellation token source used for cancelling the download
                // use `cts.Cancel();` to perform cancellation
                
                RunResult<string> result;
                //isNotDownloading = false;
                var progress = new Progress<DownloadProgress>(p => MainProgressbar.Value = (int)(p.Progress*100));
                result = await ytdl.RunVideoDownload(listBoxItem.ToString(),
                                progress: progress, ct: cts.Token);
                if (result.Success)
                {
                    //_notificationManager.Show("Success", listBoxItem.ToString() + " was downloaded!", NotificationType.Success, "WindowArea");
                    var toast = new Toast(ToastrPosition.TopRight, duration: 3000, enableSoundEffect: true);
                    toast.ShowSuccess(listBoxItem.ToString() + " was downloaded!");
                    
                }
                else
                {
                    //_notificationManager.Show("Error", listBoxItem.ToString() + " wasn't downloaded!", NotificationType.Error, "WindowArea");
                    var toast = new Toast(ToastrPosition.TopRight, duration: 3000, enableSoundEffect: true);
                    toast.ShowError(listBoxItem.ToString() + " wasn't downloaded!");
                }
                //isNotDownloading = true;
                
            }
            DownloadListBox.Items.Clear();
            MaterialMessageBox.Show(this, "All Downloads Completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void StartDownloadButton_Click(object sender, EventArgs e)
        {
            if (DownloadListBox.Items.Count > 0)
            { 
                await DownloadVideos(); 
            }
            else
            {
                
                MaterialMessageBox.Show(this, "Please add links first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            cts.Cancel();
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

    }
}