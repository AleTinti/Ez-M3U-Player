using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Ez_M3U_Player
{
    public partial class Form1 : Form
    {
        public Form1() 
        { 
            InitializeComponent();
            infoLabel.Text = "No list loaded";
            vlcPathBox.Text = vlcPath;
        }

        String vlcPath = @"C:\Program Files\VideoLAN\VLC\vlc.exe";
        String csvPath = "";
        string m3uPath = "";
        int maxItemNumber;

        public void updateList()
        {
            maxItemNumber = Convert.ToInt32(maxItemBox.Text);

            listView.Items.Clear();
            if (m3uPath.Equals("") || csvPath.Equals("")) return;

            int listCount = 0;
            String[] m3uLines = File.ReadAllLines(csvPath);
            for (int i = 0; i < m3uLines.Length; i += 1)
            {
                if (searchBox.Text != "" && !m3uLines[i].Split(',')[0].ToUpper().Contains(searchBox.Text.ToUpper())) { continue; }
                ListViewItem listViewItem = new ListViewItem(m3uLines[i].Split(',')[0]);
                listViewItem.SubItems.Add(m3uLines[i].Split(',')[1]);
                listView.Items.AddRange(new ListViewItem[] { listViewItem });
                listCount++; if (listCount > maxItemNumber) return;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            firstLabel.Text = "";
            infoLabel.Text = "Just wait";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                m3uPath = fileDialog.FileName; 
                String[] m3ULines = File.ReadAllLines(m3uPath);

                if(m3ULines[0].Contains("#EXTM3U"))
                {
                    csvPath = "";

                    StringBuilder csvOutput = new StringBuilder();

                    for (int f = 0; f < m3uPath.Split("\\".ToCharArray()).Length - 1; f++) { csvPath += m3uPath.Split("\\".ToCharArray())[f] + "\\"; }
                    csvPath += m3uPath.Split("\\".ToCharArray())[m3uPath.Split("\\".ToCharArray()).Length - 1].Remove(m3uPath.Split("\\".ToCharArray())[m3uPath.Split("\\".ToCharArray()).Length - 1].Length - 1) + ".temp"; //Sorry :P
                    File.Delete(csvPath);


                    for (int i = 1; i < m3ULines.Length - 1; i = i + 2) {
                        string[] csvRow = { m3ULines[i].Split(",".ToCharArray())[1], m3ULines[i + 1] };
                        csvOutput.AppendLine(string.Join(",", csvRow));
                    }

                    try { File.AppendAllText(csvPath, csvOutput.ToString()); }
                    catch (Exception) { MessageBox.Show("Error during Saving"); return; }
                    infoLabel.Text = "Loaded " + (m3ULines.Length - 1) / 2 + " channel";
                    updateList();
                }
                else infoLabel.Text = "Unable to understand file structure";
            } else infoLabel.Text = "No list loaded";
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (m3uPath.Equals("") || csvPath.Equals("")) return;
            if (listView.SelectedItems.Count == 1)
            {
                try 
                { 
                    Process VLC = new Process();
                    VLC.StartInfo.FileName = vlcPath;
                    VLC.StartInfo.Arguments = "-vvv " + listView.SelectedItems[0].SubItems[1].Text;
                    VLC.Start();
                } catch (Exception) {
                    infoLabel.Text = "Unable to run VLC";
                    MessageBox.Show("Try to check VLC path on settings","Error"); 
                }
            } else infoLabel.Text = "No Channel selected! Click on a Channel Name and then Play";
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            updateList();
        }

        private void vlcPathBox_Click(object sender, EventArgs e)
        {
            vlcPath = vlcPathBox.Text;
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Email: aletinti12@gmail.com\nhttps://github.com/aletinti", "Contact me");
        }

        private void formClosed(object sender, FormClosedEventArgs e)
        {
            if (csvPath.Equals("")) return;
            File.Delete(csvPath);
        }
    }
}
