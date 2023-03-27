using Microsoft.WindowsAPICodePack.Dialogs;
using System.Diagnostics;

namespace VirtualBox_Machine_Creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Set the default values

            // OS Type
            // Add to dropbox the OS types
            combo_os_type.Items.Add("Windows");
            combo_os_type.Items.Add("Ubuntu");
            combo_os_type.Items.Add("Ubuntu Mate");

            // Set the default to windows
            combo_os_type.SelectedIndex = 0;

            // Network
            network_db.Items.Add("NAT");
            network_db.Items.Add("NAT Network");
            network_db.Items.Add("Bridged");
            network_db.Items.Add("Internal");
            network_db.Items.Add("Host-only");
            network_db.Items.Add("Not attached");
            network_db.SelectedIndex = 0;

            // VDI
            vdi_format_dropbox.Items.Add("VDI");
            vdi_format_dropbox.Items.Add("VMDK");
            vdi_format_dropbox.Items.Add("VHD");
            vdi_format_dropbox.Items.Add("HDD");
            vdi_format_dropbox.SelectedIndex = 0;

            // Graphics
            graphics_db.Items.Add("VBoxVGA");
            graphics_db.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_locate_vm_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog1.SelectedPath;
                vm_location.Text = folderPath;
            }

        }

        private void combo_os_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            var windows_versions = new List<string>();
            windows_versions.Add("Windows 10");
            windows_versions.Add("Windows 11");

            var ubuntu_versions = new List<string>();
            ubuntu_versions.Add("Ubuntu 20.04");
            ubuntu_versions.Add("Ubuntu 20.10");

            var ubuntu_mate_versions = new List<string>();
            ubuntu_mate_versions.Add("Ubuntu Mate 20.04");
            ubuntu_mate_versions.Add("Ubuntu Mate 20.10");

            // If Windows is selected change combo_os_version_SelectedIndexChanged to the windows versions...
            if (combo_os_type.SelectedItem.ToString() == "Windows")
            {
                combo_os_version.Items.Clear();
                foreach (var version in windows_versions)
                {
                    combo_os_version.Items.Add(version);
                }
                combo_os_version.SelectedIndex = 0;
            }

            // If Ubuntu is selected change combo_os_version_SelectedIndexChanged to the ubuntu versions...
            if (combo_os_type.SelectedItem.ToString() == "Ubuntu")
            {
                combo_os_version.Items.Clear();
                foreach (var version in ubuntu_versions)
                {
                    combo_os_version.Items.Add(version);
                }
                combo_os_version.SelectedIndex = 0;
            }

            // If Ubuntu Mate is selected change combo_os_version_SelectedIndexChanged to the ubuntu mate versions...
            if (combo_os_type.SelectedItem.ToString() == "Ubuntu Mate")
            {
                combo_os_version.Items.Clear();
                foreach (var version in ubuntu_mate_versions)
                {
                    combo_os_version.Items.Add(version);
                }
                combo_os_version.SelectedIndex = 0;
            }
        }

        private void combo_os_version_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vdi_format_dropbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void graphics_db_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void network_db_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void locate_vdi_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog1.SelectedPath;
                vdi_location.Text = folderPath;
            }
        }

        private void locate_existing_vdi_Click(object sender, EventArgs e)
        {
            // Select a vdi file type in the broswer dialog
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "VDI Files (*.vdi)|*.vdi";
            openFileDialog1.Title = "Select a VDI File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string folderPath = openFileDialog1.FileName;
                vdi_location.Text = folderPath;
            }
        }

        private void existing_iso_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "ISO Files (*.iso)|*.iso";
            openFileDialog1.Title = "Select a ISO File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string folderPath = openFileDialog1.FileName;
                vdi_location.Text = folderPath;
            }
        }

        private void create_vm_btn_Click(object sender, EventArgs e)
        {

            string machineName = machine_name.Text;
            if (machineName == "")
            {
                MessageBox.Show("Please enter a machine name");
                return;
            }

            string osType = "";
            string isoLocation = "D:\\CampusNET\\VDI\\"; // or your desired ISO location
            // Get the OS type
            if (combo_os_type.SelectedItem.ToString() == "Windows")
            {
                osType = "Windows10_64";
                isoLocation += "es_windows_10_multiple_editions_x64_dvd_6847131.iso";
            }
            else if (combo_os_type.SelectedItem.ToString() == "Ubuntu")
            {
                osType = "Linux_64";
                isoLocation += "ubuntu-20.04.3-desktop-amd64.iso";
            }
            else if (combo_os_type.SelectedItem.ToString() == "Ubuntu Mate")
            {
                osType = "Linux_64";
                isoLocation += "ubuntu-mate-22.04.2-desktop-amd64.iso";
            }

            if (existing_iso_cb.Checked)
            {
                isoLocation = existing_iso.Text;
            }

            string vmLocation = vm_location.Text + "\\" + machineName;
            string vdiLocation = vdi_location.Text + "\\" + machineName + ".vdi";
            string vdiSize = input_disk_size.Text;

            // Convert from GB to MB
            // See if vdiSize is a number
            if (int.TryParse(vdiSize, out int n))
            {
                if (n < 1)
                {
                    MessageBox.Show("VDI size must be at least 1GB");
                    return;
                }
            }
            else
            {
                MessageBox.Show("VDI size must be a number");
                return;
            }
            int vdiSizeMB = Convert.ToInt32(vdiSize) * 1024;

            string ram = ram_input.Text;
            if (int.TryParse(ram, out int ramInt))
            {
                if (ramInt < 512)
                {
                    MessageBox.Show("RAM must be at least 512MB");
                    return;
                }
            }
            else
            {
                MessageBox.Show("RAM must be a number");
                return;
            }

            string cpuCount = "2"; // processors_db.SelectedItem.ToString();
            string videoMemory = video_memory_input.Text; ; // or your desired video memory size in MB
            if (int.TryParse(videoMemory, out int x))
            {
                if (x < 0)
                {
                    videoMemory = "0";
                }
                else if (x > 128)
                {
                    videoMemory = "128";
                }
            }
            else
            {
                MessageBox.Show("Video memory not valid, setting to 128MB");
                videoMemory = "128";
            }
            string graphicsController = "VBoxVGA"; // or your desired graphics controller type
            string networkMode = network_db.SelectedItem.ToString().ToLower();

            // create the virtual machine
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "C:\\Program Files\\Oracle\\VirtualBox\\VBoxManage.exe";
            startInfo.Arguments = "createvm --name \"" + machineName + "\" --ostype " + osType + " --register --basefolder \"" + vmLocation + "\"";
            Process.Start(startInfo).WaitForExit();

            // configure the virtual machine
            startInfo.Arguments = "modifyvm \"" + machineName + "\" --memory " + ram + " --cpus " + cpuCount + " --vram " + videoMemory + " --graphicscontroller " + graphicsController + " --audio none --boot1 dvd --boot2 disk --boot3 none --nic1 " + networkMode;
            Process.Start(startInfo).WaitForExit();

            // create the VDI disk
            startInfo.Arguments = "createhd --filename \"" + vdiLocation + "\" --size " + vdiSizeMB; // or your desired disk size in MB
            Process.Start(startInfo).WaitForExit();

            // attach the ISO image to the virtual machine
            startInfo.Arguments = "storagectl \"" + machineName + "\" --name \"IDE Controller\" --add ide";
            Process.Start(startInfo).WaitForExit();
            startInfo.Arguments = "storageattach \"" + machineName + "\" --storagectl \"IDE Controller\" --port 0 --device 0 --type dvddrive --medium \"" + isoLocation + "\"";
            Process.Start(startInfo).WaitForExit();

            // attach the VDI disk to the virtual machine
            startInfo.Arguments = "storagectl \"" + machineName + "\" --name \"SATA Controller\" --add sata --controller IntelAhci";
            Process.Start(startInfo).WaitForExit();
            startInfo.Arguments = "storageattach \"" + machineName + "\" --storagectl \"SATA Controller\" --port 0 --device 0 --type hdd --medium \"" + vdiLocation + "\"";
            Process.Start(startInfo).WaitForExit();

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }
    }
}