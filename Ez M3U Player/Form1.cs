using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace Ez_M3U_Player
{
    public partial class Form1 : Form
    {
        delegate void UpdateListDelegate();
        public Form1()
        {
            InitializeComponent();
            vlcPathBox.Text = vlcPath;
            LoadState();
            vlcPathBox.TextChanged += vlcPathBox_TextChanged;
            maxItemBox.TextChanged += maxItemBox_TextChanged;
            foreach (ToolStripMenuItem menuItem in menuStrip1.Items)
            {
                menuItem.MouseEnter += menuItem_MouseEnter;
                menuItem.MouseLeave += menuItem_MouseLeave;
            }
        }

        String vlcPath = @"C:\Program Files\VideoLAN\VLC\vlc.exe";
        private string[,] channelData;
        string m3uPath = "";
        int maxItemNumber;

        private void LoadState()
        {
            string configFilePath = "config.txt";
            if (File.Exists(configFilePath))
            {
                string[] configLines = File.ReadAllLines(configFilePath);
                foreach (string line in configLines)
                {
                    if (line.StartsWith("vlcPath="))
                    {
                        vlcPath = line.Substring("vlcPath=".Length);
                        vlcPathBox.Text = vlcPath;
                    }
                    else if (line.StartsWith("m3uPath="))
                    {
                        m3uPath = line.Substring("m3uPath=".Length);
                        if (File.Exists(m3uPath))
                        {
                            LoadM3UFile(m3uPath);
                        }
                    }
                    else if (line.StartsWith("maxItemNumber="))
                    {
                        if (int.TryParse(line.Substring("maxItemNumber=".Length), out int maxItems))
                        {
                            maxItemNumber = maxItems;
                            maxItemBox.Text = maxItems.ToString();
                        }
                    }
                    else if (line.StartsWith("lastSearch="))
                    {
                        searchBox.Text = line.Substring("lastSearch=".Length);
                    }
                }
                updateList();
            }
        }


        private void LoadM3UFile(string path)
        {
            string[] m3ULines;
            try
            {
                m3ULines = File.ReadAllLines(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}", "File Read Error");
                return;
            }

            if (m3ULines.Length == 0)
            {
                MessageBox.Show("File is empty.", "File Read Error");
                return;
            }

            if (!m3ULines[0].Contains("#EXTM3U"))
            {
                infoLabel.Text = "Unable to understand file structure";
                return;
            }

            channelData = new string[m3ULines.Length / 2, 2];

            int channelIndex = 0;
            for (int i = 1; i < m3ULines.Length - 1; i += 2)
            {
                string channelName = m3ULines[i].Split(',')[1];
                string channelLink = m3ULines[i + 1];

                channelData[channelIndex, 0] = channelName;
                channelData[channelIndex, 1] = channelLink;

                channelIndex++;
            }

            infoLabel.Text = $"File {Path.GetFileName(m3uPath)}:  {channelIndex} channels";
            updateList();
        }


        private void SaveState()
        {
            string configFilePath = "config.txt";
            StringBuilder configContent = new StringBuilder();
            configContent.AppendLine("vlcPath=" + vlcPath);
            if (!string.IsNullOrEmpty(m3uPath))
            {
                configContent.AppendLine("m3uPath=" + m3uPath);
            }
            configContent.AppendLine("maxItemNumber=" + maxItemNumber);
            configContent.AppendLine("lastSearch=" + searchBox.Text);
            File.WriteAllText(configFilePath, configContent.ToString());
        }


        public void updateList()
        {
            if (!int.TryParse(maxItemBox.Text, out maxItemNumber))
            {
                maxItemNumber = 0;
            }

            listView.Items.Clear();
            if (channelData == null) return;

            int listCount = 0;
            for (int i = 0; i < channelData.GetLength(0); i++)
            {
                string channelName = channelData[i, 0];
                string channelLink = channelData[i, 1];

                if (!string.IsNullOrEmpty(searchBox.Text) && !channelName.ToUpper().Contains(searchBox.Text.ToUpper())) continue;

                ListViewItem listViewItem = new ListViewItem(channelName);
                listViewItem.SubItems.Add(channelLink);
                listView.Items.Add(listViewItem);

                listCount++;
                if (listCount >= maxItemNumber) break;
            }
        }



        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoLabel.Text = "Just wait";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                m3uPath = fileDialog.FileName;
                LoadM3UFile(m3uPath);
                SaveState();
            }
            else
            {
                infoLabel.Text = "No list loaded";
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (m3uPath.Equals("")) return;
            if (listView.SelectedItems.Count == 1)
            {
                try
                {
                    Process VLC = new Process();
                    VLC.StartInfo.FileName = vlcPath;
                    VLC.StartInfo.Arguments = "-vvv " + listView.SelectedItems[0].SubItems[1].Text;
                    VLC.Start();
                }
                catch (Exception)
                {
                    infoLabel.Text = "Unable to run VLC";
                    MessageBox.Show("Try to check VLC path on settings", "Error");
                }
            }
            else infoLabel.Text = "No Channel selected! Click on a Channel Name and then Play";
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            updateList();
        }

        private void vlcPathBox_TextChanged(object sender, EventArgs e)
        {
            vlcPath = vlcPathBox.Text;
            SaveState();
        }

        private void maxItemBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(maxItemBox.Text, out int maxItems))
            {
                maxItemNumber = maxItems;
                updateList();
                SaveState();
            }
        }

        public class MyRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
            {
                e.TextColor = e.Item.Selected ? Color.White : Color.Black;
                base.OnRenderItemText(e);
            }
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you find any errors or bugs (there are plenty :) ), please contact me.\nEmail: aletinti12@gmail.com\nhttps://github.com/aletinti", "oOo");
        }

        private void menuItem_MouseEnter(object sender, EventArgs e)
        {
            var menuItem = (ToolStripMenuItem)sender;
            menuItem.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void menuItem_MouseLeave(object sender, EventArgs e)
        {
            var menuItem = (ToolStripMenuItem)sender;
            menuItem.ForeColor = SystemColors.ControlText;
        }

        private void formClosed(object sender, FormClosedEventArgs e) { SaveState(); }
    }
}

