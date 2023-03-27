using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using SimpleWifi;
using Microsoft.VisualBasic.Devices;

namespace VirtualBox_Machine_Creator
{
    internal class GetData
    {
        #region Network data

        // IP address of the host
        public static string GetLocalIpAddress()
        {
            string value = "No Ipv4 address found";

            // Bruh, teacher doesn't like this code 💀
            /*
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                IPInterfaceProperties ip = nic.GetIPProperties();

                // If the interface is not up, skip it
                if (nic.OperationalStatus != OperationalStatus.Up)
                    continue;

                // If the interface is not Wireless or Ethernet, skip it
                if (nic.NetworkInterfaceType != NetworkInterfaceType.Wireless80211 &&
                    nic.NetworkInterfaceType != NetworkInterfaceType.Ethernet)
                    continue;

                // If the interface is virtual, skip it
                if (nic.Description.ToLower().Contains("virtual"))
                    continue;

                foreach (UnicastIPAddressInformation ipInfo in ip.UnicastAddresses)
                {
                    if (ipInfo.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        value = ipInfo.Address.ToString();
                    }
                }
            }

            if (value == string.Empty)
            {
                value = "No network adapters with an IPv4 address in the system!";
            }
            */
            // Bruh, teacher doesn't like this code 💀

            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in nics)
            {
                if (adapter.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 ||
                    adapter.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    if (adapter.OperationalStatus == OperationalStatus.Up)
                    {
                        IPInterfaceProperties properties = adapter.GetIPProperties();
                        foreach (UnicastIPAddressInformation address in properties.UnicastAddresses)
                        {
                            if (address.Address.AddressFamily == AddressFamily.InterNetwork)
                            {
                                value = address.Address.ToString();
                            }
                        }
                    }
                }
            }

            return value;
        }

        // Default gateway
        public static string GetDefaultGateway()
        {
            // Detect if the user is connected to a WiFi network
            var wifi = new Wifi();
            var currentConnection = wifi.ConnectionStatus;

            if (currentConnection != WifiStatus.Connected)
                return "Not connected to a WiFi network";

            var defaultGateway = from nics in NetworkInterface.GetAllNetworkInterfaces()
                                 from props in nics.GetIPProperties().GatewayAddresses
                                 where nics.OperationalStatus == OperationalStatus.Up
                                 select props.Address.ToString();

            return defaultGateway.First();
        }

        // SSID
        public static string GetSSID()
        {
            // Detect if the user is connected to a WiFi network
            var wifi = new Wifi();
            var currentConnection = wifi.ConnectionStatus;

            if (currentConnection != WifiStatus.Connected)
                return "Not connected to a WiFi network";

            System.Diagnostics.Process p = new Process();
            p.StartInfo.FileName = "netsh.exe";
            p.StartInfo.Arguments = "wlan show interfaces";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.Start();

            string s = p.StandardOutput.ReadToEnd();
            string s1 = s.Substring(s.IndexOf("SSID"));
            s1 = s1.Substring(s1.IndexOf(":"));
            s1 = s1.Substring(2, s1.IndexOf("\n")).Trim();

            p.WaitForExit();

            return s1;
        }

        // SSID connected or not
        public static string GetSSIDStatus()
        {
            string ssidStatus = string.Empty;
            ProcessStartInfo psi = new ProcessStartInfo("netsh", "wlan show interfaces");
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            Process p = Process.Start(psi);
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            string[] lines = output.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            foreach (string line in lines)
            {
                if (line.Contains("State"))
                {
                    int index = line.IndexOf(":");
                    ssidStatus = line.Substring(index + 1).Trim();
                }
            }

            return ssidStatus;
        }

        // MAC address of the host
        public static string GetMacAddress()
        {
            // Get mac of the GetLocalIpAddress() method
            string macAddress = string.Empty;
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                IPInterfaceProperties ip = nic.GetIPProperties();

                // If the interface is not up, skip it
                if (nic.OperationalStatus != OperationalStatus.Up)
                    continue;

                // If the interface is not Wireless or Ethernet, skip it
                if (nic.NetworkInterfaceType != NetworkInterfaceType.Wireless80211 &&
                    nic.NetworkInterfaceType != NetworkInterfaceType.Ethernet)
                    continue;

                // If the interface is virtual, skip it
                if (nic.Description.ToLower().Contains("virtual"))
                    continue;

                foreach (UnicastIPAddressInformation ipInfo in ip.UnicastAddresses)
                {
                    if (ipInfo.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        macAddress = nic.GetPhysicalAddress().ToString();
                    }
                }
            }

            if (macAddress == null) macAddress = "No network adapters with an IPv4 address in the system!";
            return macAddress;
        }

        // Ping google to check if connected to internet
        public static string GetConnection()
        {
            // Send 4 pings to 8.8.8.8, and if 4 of them are successful, then we are connected to the internet
            int success = 0;
            for (int i = 0; i < 4; i++)
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send("8.8.8.8", 1000);
                if (reply.Status == IPStatus.Success)
                {
                    success++;
                }
            }

            if (success == 4)
            {
                return "Connected";
            }
            else if (success == 0)
            {
                return "Not connected";
            }
            else
            {
                return "Partially connected";
            }
        }

        #endregion Network data

        #region System data

        // Username of the host
        public static string GetCurrentUserUsername()
        {
            return Environment.UserName;
        }

        // Name of the OS
        public static string GetOSName()
        {
            return System.Net.Dns.GetHostName();
        }

        // Is VirtualBox installed?
        public static string VirtualBoxInstalled()
        {
            // Find VBoxManage.exe in the computer
            string[] files = Directory.GetFiles(@"C:\Program Files\Oracle\VirtualBox", "VBoxManage.exe", SearchOption.AllDirectories);

            if (files.Length > 0)
            {
                return "Installed";
            }
            else
            {
                return "Not installed";
            }
        }

        // Version of VirtualBox
        public static string VirtualBoxVersion()
        {
            if (File.Exists("C:\\Program Files\\Oracle\\VirtualBox\\VBoxManage.exe"))
            {
                var f = FileVersionInfo.GetVersionInfo("C:\\Program Files\\Oracle\\VirtualBox\\VBoxManage.exe").FileVersion;

                return f == null ? "N/A" : f;
            }
            else
            {
                return "N/A";
            }
        }

        // Get the ram of the host
        public static int GetRam()
        {
            var total = new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory;
            return Convert.ToInt32(total / 1024 / 1024); // Convert to MB
        }


        // Get remaining disk space
        public static float GetRemainingDiskSpace()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                if (d.IsReady == true)
                {
                    return (float)d.AvailableFreeSpace / 1024 / 1024 / 1024; // Convert to GB
                }
            }

            return 0;
        }

        // Get ammount of cores
        public static int GetCores()
        {
            return Environment.ProcessorCount;
        }

        #endregion System data

    }
}
