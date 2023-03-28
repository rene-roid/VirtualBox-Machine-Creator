namespace VirtualBox_Machine_Creator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            vboxversion = new Label();
            vboxinstalled = new Label();
            label19 = new Label();
            label18 = new Label();
            ssidstatus = new Label();
            label16 = new Label();
            macaddress = new Label();
            label14 = new Label();
            internetconnection = new Label();
            ssid = new Label();
            label11 = new Label();
            label10 = new Label();
            hostname = new Label();
            label8 = new Label();
            username = new Label();
            label6 = new Label();
            ipgateway = new Label();
            iphost = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label27 = new Label();
            existing_iso_btn = new Button();
            existing_iso = new TextBox();
            existing_iso_cb = new CheckBox();
            create_vm_btn = new Button();
            network_db = new ComboBox();
            label26 = new Label();
            graphics_db = new ComboBox();
            label25 = new Label();
            video_memory_input = new TextBox();
            label24 = new Label();
            processors_db = new ComboBox();
            locate_existing_vdi = new Button();
            exisiting_vdi = new TextBox();
            no_vdi_cb = new CheckBox();
            existing_vdi_cb = new CheckBox();
            vdi_format_dropbox = new ComboBox();
            locate_vdi_btn = new Button();
            vdi_location = new TextBox();
            label23 = new Label();
            create_vdi_cb = new CheckBox();
            label22 = new Label();
            ram_input = new TextBox();
            label21 = new Label();
            label20 = new Label();
            input_disk_size = new TextBox();
            label17 = new Label();
            btn_locate_vm = new Button();
            vm_location = new TextBox();
            no_iso_cb = new CheckBox();
            download_iso_cb = new CheckBox();
            label15 = new Label();
            label13 = new Label();
            label12 = new Label();
            combo_os_version = new ComboBox();
            label9 = new Label();
            combo_os_type = new ComboBox();
            label7 = new Label();
            machine_name = new TextBox();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(vboxversion);
            panel1.Controls.Add(vboxinstalled);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(ssidstatus);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(macaddress);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(internetconnection);
            panel1.Controls.Add(ssid);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(hostname);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(username);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(ipgateway);
            panel1.Controls.Add(iphost);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1097, 196);
            panel1.TabIndex = 0;
            // 
            // vboxversion
            // 
            vboxversion.AutoSize = true;
            vboxversion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            vboxversion.Location = new Point(1003, 111);
            vboxversion.Name = "vboxversion";
            vboxversion.Size = new Size(43, 25);
            vboxversion.TabIndex = 22;
            vboxversion.Text = "test";
            // 
            // vboxinstalled
            // 
            vboxinstalled.AutoSize = true;
            vboxinstalled.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            vboxinstalled.Location = new Point(1003, 73);
            vboxinstalled.Name = "vboxinstalled";
            vboxinstalled.Size = new Size(43, 25);
            vboxinstalled.TabIndex = 21;
            vboxinstalled.Text = "test";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(854, 111);
            label19.Name = "label19";
            label19.Size = new Size(138, 25);
            label19.TabIndex = 20;
            label19.Text = "VBox Version:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(854, 73);
            label18.Name = "label18";
            label18.Size = new Size(143, 25);
            label18.TabIndex = 19;
            label18.Text = "VBox Installed:";
            // 
            // ssidstatus
            // 
            ssidstatus.AutoSize = true;
            ssidstatus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ssidstatus.Location = new Point(724, 111);
            ssidstatus.Name = "ssidstatus";
            ssidstatus.Size = new Size(43, 25);
            ssidstatus.TabIndex = 18;
            ssidstatus.Text = "test";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(530, 149);
            label16.Name = "label16";
            label16.Size = new Size(188, 25);
            label16.TabIndex = 17;
            label16.Text = "Internet Connection:";
            // 
            // macaddress
            // 
            macaddress.AutoSize = true;
            macaddress.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            macaddress.Location = new Point(162, 149);
            macaddress.Name = "macaddress";
            macaddress.Size = new Size(43, 25);
            macaddress.TabIndex = 16;
            macaddress.Text = "test";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(14, 149);
            label14.Name = "label14";
            label14.Size = new Size(142, 25);
            label14.TabIndex = 15;
            label14.Text = "MAC Address:";
            // 
            // internetconnection
            // 
            internetconnection.AutoSize = true;
            internetconnection.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            internetconnection.Location = new Point(724, 149);
            internetconnection.Name = "internetconnection";
            internetconnection.Size = new Size(43, 25);
            internetconnection.TabIndex = 14;
            internetconnection.Text = "test";
            // 
            // ssid
            // 
            ssid.AutoSize = true;
            ssid.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ssid.Location = new Point(724, 73);
            ssid.Name = "ssid";
            ssid.Size = new Size(43, 25);
            ssid.TabIndex = 13;
            ssid.Text = "test";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(530, 111);
            label11.Name = "label11";
            label11.Size = new Size(126, 25);
            label11.TabIndex = 12;
            label11.Text = "SSID Status:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(530, 73);
            label10.Name = "label10";
            label10.Size = new Size(65, 25);
            label10.TabIndex = 11;
            label10.Text = "SSID:";
            // 
            // hostname
            // 
            hostname.AutoSize = true;
            hostname.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hostname.Location = new Point(399, 111);
            hostname.Name = "hostname";
            hostname.Size = new Size(43, 25);
            hostname.TabIndex = 10;
            hostname.Text = "test";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(286, 111);
            label8.Name = "label8";
            label8.Size = new Size(107, 25);
            label8.TabIndex = 9;
            label8.Text = "Hostname:";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(400, 73);
            username.Name = "username";
            username.Size = new Size(43, 25);
            username.TabIndex = 8;
            username.Text = "test";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(286, 73);
            label6.Name = "label6";
            label6.Size = new Size(108, 25);
            label6.TabIndex = 7;
            label6.Text = "Username:";
            label6.Click += label6_Click;
            // 
            // ipgateway
            // 
            ipgateway.AutoSize = true;
            ipgateway.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ipgateway.Location = new Point(162, 111);
            ipgateway.Name = "ipgateway";
            ipgateway.Size = new Size(43, 25);
            ipgateway.TabIndex = 6;
            ipgateway.Text = "test";
            ipgateway.Click += label5_Click;
            // 
            // iphost
            // 
            iphost.AutoSize = true;
            iphost.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iphost.Location = new Point(162, 73);
            iphost.Name = "iphost";
            iphost.Size = new Size(43, 25);
            iphost.TabIndex = 5;
            iphost.Text = "test";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 111);
            label3.Name = "label3";
            label3.Size = new Size(118, 25);
            label3.TabIndex = 4;
            label3.Text = "IP Gateway:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 73);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 3;
            label2.Text = "IP Host:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(410, -3);
            label1.Name = "label1";
            label1.Size = new Size(355, 38);
            label1.TabIndex = 2;
            label1.Text = "VirtualBox Machine Creator";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Location = new Point(0, 220);
            panel2.Name = "panel2";
            panel2.Size = new Size(1097, 523);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(label27);
            panel3.Controls.Add(existing_iso_btn);
            panel3.Controls.Add(existing_iso);
            panel3.Controls.Add(existing_iso_cb);
            panel3.Controls.Add(create_vm_btn);
            panel3.Controls.Add(network_db);
            panel3.Controls.Add(label26);
            panel3.Controls.Add(graphics_db);
            panel3.Controls.Add(label25);
            panel3.Controls.Add(video_memory_input);
            panel3.Controls.Add(label24);
            panel3.Controls.Add(processors_db);
            panel3.Controls.Add(locate_existing_vdi);
            panel3.Controls.Add(exisiting_vdi);
            panel3.Controls.Add(no_vdi_cb);
            panel3.Controls.Add(existing_vdi_cb);
            panel3.Controls.Add(vdi_format_dropbox);
            panel3.Controls.Add(locate_vdi_btn);
            panel3.Controls.Add(vdi_location);
            panel3.Controls.Add(label23);
            panel3.Controls.Add(create_vdi_cb);
            panel3.Controls.Add(label22);
            panel3.Controls.Add(ram_input);
            panel3.Controls.Add(label21);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(input_disk_size);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(btn_locate_vm);
            panel3.Controls.Add(vm_location);
            panel3.Controls.Add(no_iso_cb);
            panel3.Controls.Add(download_iso_cb);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(combo_os_version);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(combo_os_type);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(machine_name);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(12, 232);
            panel3.Name = "panel3";
            panel3.Size = new Size(1097, 520);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(553, 184);
            label27.Name = "label27";
            label27.Size = new Size(475, 20);
            label27.TabIndex = 64;
            label27.Text = "if not selected code will autoselect (my local path it will break for u :p)";
            label27.Click += label27_Click;
            // 
            // existing_iso_btn
            // 
            existing_iso_btn.Location = new Point(858, 149);
            existing_iso_btn.Name = "existing_iso_btn";
            existing_iso_btn.Size = new Size(73, 29);
            existing_iso_btn.TabIndex = 63;
            existing_iso_btn.Text = "Locate";
            existing_iso_btn.UseVisualStyleBackColor = true;
            existing_iso_btn.Click += existing_iso_btn_Click;
            // 
            // existing_iso
            // 
            existing_iso.Location = new Point(709, 154);
            existing_iso.Name = "existing_iso";
            existing_iso.Size = new Size(143, 27);
            existing_iso.TabIndex = 62;
            // 
            // existing_iso_cb
            // 
            existing_iso_cb.AutoSize = true;
            existing_iso_cb.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            existing_iso_cb.Location = new Point(527, 152);
            existing_iso_cb.Name = "existing_iso_cb";
            existing_iso_cb.Size = new Size(176, 29);
            existing_iso_cb.TabIndex = 61;
            existing_iso_cb.Text = "Use existing iso:";
            existing_iso_cb.UseVisualStyleBackColor = true;
            // 
            // create_vm_btn
            // 
            create_vm_btn.Location = new Point(952, 423);
            create_vm_btn.Name = "create_vm_btn";
            create_vm_btn.Size = new Size(124, 54);
            create_vm_btn.TabIndex = 60;
            create_vm_btn.Text = "Create VM";
            create_vm_btn.UseVisualStyleBackColor = true;
            create_vm_btn.Click += create_vm_btn_Click;
            // 
            // network_db
            // 
            network_db.FormattingEnabled = true;
            network_db.Location = new Point(678, 449);
            network_db.Name = "network_db";
            network_db.Size = new Size(253, 28);
            network_db.TabIndex = 59;
            network_db.SelectedIndexChanged += network_db_SelectedIndexChanged;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label26.Location = new Point(530, 452);
            label26.Name = "label26";
            label26.Size = new Size(143, 25);
            label26.TabIndex = 58;
            label26.Text = "Network mode:";
            label26.TextAlign = ContentAlignment.TopCenter;
            // 
            // graphics_db
            // 
            graphics_db.FormattingEnabled = true;
            graphics_db.Location = new Point(721, 415);
            graphics_db.Name = "graphics_db";
            graphics_db.Size = new Size(210, 28);
            graphics_db.TabIndex = 57;
            graphics_db.SelectedIndexChanged += graphics_db_SelectedIndexChanged;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(530, 418);
            label25.Name = "label25";
            label25.Size = new Size(185, 25);
            label25.TabIndex = 56;
            label25.Text = "Graphics Controller:";
            // 
            // video_memory_input
            // 
            video_memory_input.Location = new Point(678, 382);
            video_memory_input.Name = "video_memory_input";
            video_memory_input.Size = new Size(253, 27);
            video_memory_input.TabIndex = 55;
            video_memory_input.Text = "128";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(527, 382);
            label24.Name = "label24";
            label24.Size = new Size(145, 25);
            label24.TabIndex = 54;
            label24.Text = "Video Memory:";
            // 
            // processors_db
            // 
            processors_db.FormattingEnabled = true;
            processors_db.Location = new Point(700, 340);
            processors_db.Name = "processors_db";
            processors_db.Size = new Size(231, 28);
            processors_db.TabIndex = 53;
            // 
            // locate_existing_vdi
            // 
            locate_existing_vdi.Enabled = false;
            locate_existing_vdi.Location = new Point(321, 428);
            locate_existing_vdi.Name = "locate_existing_vdi";
            locate_existing_vdi.Size = new Size(73, 29);
            locate_existing_vdi.TabIndex = 52;
            locate_existing_vdi.Text = "Locate";
            locate_existing_vdi.UseVisualStyleBackColor = true;
            locate_existing_vdi.Click += locate_existing_vdi_Click;
            // 
            // exisiting_vdi
            // 
            exisiting_vdi.Enabled = false;
            exisiting_vdi.Location = new Point(192, 430);
            exisiting_vdi.Name = "exisiting_vdi";
            exisiting_vdi.Size = new Size(124, 27);
            exisiting_vdi.TabIndex = 51;
            // 
            // no_vdi_cb
            // 
            no_vdi_cb.AutoSize = true;
            no_vdi_cb.Enabled = false;
            no_vdi_cb.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            no_vdi_cb.Location = new Point(11, 473);
            no_vdi_cb.Name = "no_vdi_cb";
            no_vdi_cb.Size = new Size(167, 29);
            no_vdi_cb.TabIndex = 50;
            no_vdi_cb.Text = "Do not add VDI";
            no_vdi_cb.UseVisualStyleBackColor = true;
            // 
            // existing_vdi_cb
            // 
            existing_vdi_cb.AutoSize = true;
            existing_vdi_cb.Enabled = false;
            existing_vdi_cb.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            existing_vdi_cb.Location = new Point(14, 428);
            existing_vdi_cb.Name = "existing_vdi_cb";
            existing_vdi_cb.Size = new Size(186, 29);
            existing_vdi_cb.TabIndex = 49;
            existing_vdi_cb.Text = "Use Existing VDI:";
            existing_vdi_cb.UseVisualStyleBackColor = true;
            // 
            // vdi_format_dropbox
            // 
            vdi_format_dropbox.FormattingEnabled = true;
            vdi_format_dropbox.Location = new Point(161, 379);
            vdi_format_dropbox.Name = "vdi_format_dropbox";
            vdi_format_dropbox.Size = new Size(231, 28);
            vdi_format_dropbox.TabIndex = 48;
            vdi_format_dropbox.SelectedIndexChanged += vdi_format_dropbox_SelectedIndexChanged;
            // 
            // locate_vdi_btn
            // 
            locate_vdi_btn.Location = new Point(321, 301);
            locate_vdi_btn.Name = "locate_vdi_btn";
            locate_vdi_btn.Size = new Size(73, 29);
            locate_vdi_btn.TabIndex = 47;
            locate_vdi_btn.Text = "Locate";
            locate_vdi_btn.UseVisualStyleBackColor = true;
            locate_vdi_btn.Click += locate_vdi_btn_Click;
            // 
            // vdi_location
            // 
            vdi_location.Location = new Point(163, 303);
            vdi_location.Name = "vdi_location";
            vdi_location.Size = new Size(153, 27);
            vdi_location.TabIndex = 46;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(14, 382);
            label23.Name = "label23";
            label23.Size = new Size(117, 25);
            label23.TabIndex = 45;
            label23.Text = "VDI Format:";
            // 
            // create_vdi_cb
            // 
            create_vdi_cb.AutoSize = true;
            create_vdi_cb.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            create_vdi_cb.Location = new Point(14, 303);
            create_vdi_cb.Name = "create_vdi_cb";
            create_vdi_cb.Size = new Size(137, 29);
            create_vdi_cb.TabIndex = 44;
            create_vdi_cb.Text = "Create VDI:";
            create_vdi_cb.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(530, 343);
            label22.Name = "label22";
            label22.Size = new Size(164, 25);
            label22.TabIndex = 42;
            label22.Text = "Core Processors:";
            // 
            // ram_input
            // 
            ram_input.Location = new Point(595, 304);
            ram_input.Name = "ram_input";
            ram_input.Size = new Size(336, 27);
            ram_input.TabIndex = 41;
            ram_input.Text = "4096";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(527, 304);
            label21.Name = "label21";
            label21.Size = new Size(62, 25);
            label21.TabIndex = 40;
            label21.Text = "RAM:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(527, 264);
            label20.Name = "label20";
            label20.Size = new Size(104, 25);
            label20.TabIndex = 39;
            label20.Text = "Hardware";
            // 
            // input_disk_size
            // 
            input_disk_size.Location = new Point(160, 342);
            input_disk_size.Name = "input_disk_size";
            input_disk_size.Size = new Size(232, 27);
            input_disk_size.TabIndex = 38;
            input_disk_size.Text = "20";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(12, 344);
            label17.Name = "label17";
            label17.Size = new Size(149, 25);
            label17.TabIndex = 37;
            label17.Text = "Disk size in GB:";
            // 
            // btn_locate_vm
            // 
            btn_locate_vm.Location = new Point(322, 204);
            btn_locate_vm.Name = "btn_locate_vm";
            btn_locate_vm.Size = new Size(73, 29);
            btn_locate_vm.TabIndex = 36;
            btn_locate_vm.Text = "Locate";
            btn_locate_vm.UseVisualStyleBackColor = true;
            btn_locate_vm.Click += btn_locate_vm_Click;
            // 
            // vm_location
            // 
            vm_location.Location = new Point(163, 205);
            vm_location.Name = "vm_location";
            vm_location.Size = new Size(153, 27);
            vm_location.TabIndex = 35;
            // 
            // no_iso_cb
            // 
            no_iso_cb.AutoSize = true;
            no_iso_cb.Enabled = false;
            no_iso_cb.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            no_iso_cb.Location = new Point(527, 105);
            no_iso_cb.Name = "no_iso_cb";
            no_iso_cb.Size = new Size(282, 29);
            no_iso_cb.TabIndex = 34;
            no_iso_cb.Text = "Just download specified ISO";
            no_iso_cb.UseVisualStyleBackColor = true;
            // 
            // download_iso_cb
            // 
            download_iso_cb.AutoSize = true;
            download_iso_cb.Enabled = false;
            download_iso_cb.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            download_iso_cb.Location = new Point(527, 53);
            download_iso_cb.Name = "download_iso_cb";
            download_iso_cb.Size = new Size(282, 29);
            download_iso_cb.TabIndex = 33;
            download_iso_cb.Text = "Just download specified ISO";
            download_iso_cb.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(527, 14);
            label15.Name = "label15";
            label15.Size = new Size(181, 25);
            label15.TabIndex = 31;
            label15.Text = "ISO Management";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(14, 265);
            label13.Name = "label13";
            label13.Size = new Size(174, 25);
            label13.TabIndex = 30;
            label13.Text = "Virtual Hard Disk";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(14, 205);
            label12.Name = "label12";
            label12.Size = new Size(128, 25);
            label12.TabIndex = 29;
            label12.Text = "VM Location:";
            // 
            // combo_os_version
            // 
            combo_os_version.FormattingEnabled = true;
            combo_os_version.Location = new Point(163, 154);
            combo_os_version.Name = "combo_os_version";
            combo_os_version.Size = new Size(231, 28);
            combo_os_version.TabIndex = 28;
            combo_os_version.SelectedIndexChanged += combo_os_version_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(14, 153);
            label9.Name = "label9";
            label9.Size = new Size(120, 25);
            label9.TabIndex = 27;
            label9.Text = "OS Version:";
            // 
            // combo_os_type
            // 
            combo_os_type.FormattingEnabled = true;
            combo_os_type.Location = new Point(163, 102);
            combo_os_type.Name = "combo_os_type";
            combo_os_type.Size = new Size(231, 28);
            combo_os_type.TabIndex = 26;
            combo_os_type.SelectedIndexChanged += combo_os_type_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(14, 101);
            label7.Name = "label7";
            label7.Size = new Size(98, 25);
            label7.TabIndex = 25;
            label7.Text = "OS Type:";
            // 
            // machine_name
            // 
            machine_name.Location = new Point(163, 53);
            machine_name.Name = "machine_name";
            machine_name.Size = new Size(232, 27);
            machine_name.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(14, 52);
            label5.Name = "label5";
            label5.Size = new Size(147, 25);
            label5.TabIndex = 23;
            label5.Text = "Machine name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(14, 15);
            label4.Name = "label4";
            label4.Size = new Size(422, 25);
            label4.TabIndex = 23;
            label4.Text = "Name, Operating System and VM Location";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 767);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "VBox VMachine Creator";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label iphost;
        private Label label6;
        private Label ipgateway;
        private Label username;
        private Label label8;
        private Label label10;
        private Label hostname;
        private Label label11;
        private Label internetconnection;
        private Label ssid;
        private Label label14;
        private Label macaddress;
        private Label label16;
        private Label label18;
        private Label ssidstatus;
        private Label label19;
        private Label vboxversion;
        private Label vboxinstalled;
        private Label label4;
        private Label label5;
        private TextBox machine_name;
        private Label label7;
        private ComboBox combo_os_type;
        private Label label9;
        private ComboBox combo_os_version;
        private Label label12;
        private Label label13;
        private Label label15;
        private CheckBox download_iso_cb;
        private CheckBox no_iso_cb;
        private TextBox vm_location;
        private Button btn_locate_vm;
        private Label label17;
        private TextBox input_disk_size;
        private Label label20;
        private Label label21;
        private TextBox ram_input;
        private Label label22;
        private CheckBox create_vdi_cb;
        private Button locate_vdi_btn;
        private TextBox vdi_location;
        private Label label23;
        private ComboBox vdi_format_dropbox;
        private CheckBox no_vdi_cb;
        private CheckBox existing_vdi_cb;
        private Button locate_existing_vdi;
        private TextBox exisiting_vdi;
        private TextBox video_memory_input;
        private Label label24;
        private ComboBox processors_db;
        private ComboBox graphics_db;
        private Label label25;
        private ComboBox network_db;
        private Label label26;
        private Button create_vm_btn;
        private CheckBox existing_iso_cb;
        private Button existing_iso_btn;
        private TextBox existing_iso;
        private Label label27;
    }
}