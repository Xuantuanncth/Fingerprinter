namespace FingerPrinter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._Bt_Connect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this._CB_COM = new System.Windows.Forms.ComboBox();
            this._Cb_baud = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._lb_status = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this._lb_time = new System.Windows.Forms.Label();
            this._Tab_Check_In = new System.Windows.Forms.TabPage();
            this._bt_saveData = new System.Windows.Forms.Button();
            this._bt_loaddata = new System.Windows.Forms.Button();
            this._dgv_list = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHECK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Tab_Register = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this._tb_id_delet = new System.Windows.Forms.TextBox();
            this._processBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._Tb_name = new System.Windows.Forms.TextBox();
            this._Tb_MSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._Bt_regsiter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._Tab_Wellcome = new System.Windows.Forms.TabPage();
            this._rtb_text = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._lb_1_id = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this._lb_1_sts = new System.Windows.Forms.Label();
            this._lb_1_time = new System.Windows.Forms.Label();
            this._lb_1_msv = new System.Windows.Forms.Label();
            this._lb_1_name = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this._View_tab = new System.Windows.Forms.TabControl();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this._bt_add = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this._tb_ID = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this._Tab_Check_In.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgv_list)).BeginInit();
            this._Tab_Register.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this._Tab_Wellcome.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this._View_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // _Bt_Connect
            // 
            this._Bt_Connect.Location = new System.Drawing.Point(57, 165);
            this._Bt_Connect.Name = "_Bt_Connect";
            this._Bt_Connect.Size = new System.Drawing.Size(111, 71);
            this._Bt_Connect.TabIndex = 1;
            this._Bt_Connect.Text = "Connect";
            this._Bt_Connect.UseVisualStyleBackColor = true;
            this._Bt_Connect.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "COM";
            // 
            // _CB_COM
            // 
            this._CB_COM.FormattingEnabled = true;
            this._CB_COM.Location = new System.Drawing.Point(57, 84);
            this._CB_COM.Name = "_CB_COM";
            this._CB_COM.Size = new System.Drawing.Size(121, 21);
            this._CB_COM.TabIndex = 3;
            // 
            // _Cb_baud
            // 
            this._Cb_baud.FormattingEnabled = true;
            this._Cb_baud.Location = new System.Drawing.Point(57, 125);
            this._Cb_baud.Name = "_Cb_baud";
            this._Cb_baud.Size = new System.Drawing.Size(121, 21);
            this._Cb_baud.TabIndex = 5;
            this._Cb_baud.Text = "9600";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Baud";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._lb_status);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this._Bt_Connect);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this._Cb_baud);
            this.groupBox2.Controls.Add(this._CB_COM);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(604, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 242);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connect device";
            // 
            // _lb_status
            // 
            this._lb_status.AutoSize = true;
            this._lb_status.Location = new System.Drawing.Point(90, 48);
            this._lb_status.Name = "_lb_status";
            this._lb_status.Size = new System.Drawing.Size(61, 13);
            this._lb_status.TabIndex = 7;
            this._lb_status.Text = "Disconnect";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Status: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(605, 128);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Data :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(661, 128);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 13);
            this.label19.TabIndex = 3;
            this.label19.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(604, 87);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 13);
            this.label20.TabIndex = 4;
            this.label20.Text = "Time:";
            // 
            // _lb_time
            // 
            this._lb_time.AutoSize = true;
            this._lb_time.Location = new System.Drawing.Point(658, 87);
            this._lb_time.Name = "_lb_time";
            this._lb_time.Size = new System.Drawing.Size(13, 13);
            this._lb_time.TabIndex = 5;
            this._lb_time.Text = "0";
            // 
            // _Tab_Check_In
            // 
            this._Tab_Check_In.Controls.Add(this._bt_saveData);
            this._Tab_Check_In.Controls.Add(this._bt_loaddata);
            this._Tab_Check_In.Controls.Add(this._dgv_list);
            this._Tab_Check_In.Location = new System.Drawing.Point(4, 22);
            this._Tab_Check_In.Name = "_Tab_Check_In";
            this._Tab_Check_In.Padding = new System.Windows.Forms.Padding(3);
            this._Tab_Check_In.Size = new System.Drawing.Size(586, 408);
            this._Tab_Check_In.TabIndex = 3;
            this._Tab_Check_In.Text = "Điểm danh";
            this._Tab_Check_In.UseVisualStyleBackColor = true;
            this._Tab_Check_In.Click += new System.EventHandler(this._Tab_Check_In_Click);
            // 
            // _bt_saveData
            // 
            this._bt_saveData.Location = new System.Drawing.Point(505, 6);
            this._bt_saveData.Name = "_bt_saveData";
            this._bt_saveData.Size = new System.Drawing.Size(75, 23);
            this._bt_saveData.TabIndex = 2;
            this._bt_saveData.Text = "Save";
            this._bt_saveData.UseVisualStyleBackColor = true;
            // 
            // _bt_loaddata
            // 
            this._bt_loaddata.Location = new System.Drawing.Point(424, 6);
            this._bt_loaddata.Name = "_bt_loaddata";
            this._bt_loaddata.Size = new System.Drawing.Size(75, 23);
            this._bt_loaddata.TabIndex = 1;
            this._bt_loaddata.Text = "Load";
            this._bt_loaddata.UseVisualStyleBackColor = true;
            // 
            // _dgv_list
            // 
            this._dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgv_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NAME,
            this.MSV,
            this.TIME,
            this.CHECK});
            this._dgv_list.Location = new System.Drawing.Point(6, 35);
            this._dgv_list.Name = "_dgv_list";
            this._dgv_list.Size = new System.Drawing.Size(574, 367);
            this._dgv_list.TabIndex = 0;
            this._dgv_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 80;
            // 
            // NAME
            // 
            this.NAME.HeaderText = "NAME";
            this.NAME.Name = "NAME";
            this.NAME.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NAME.Width = 150;
            // 
            // MSV
            // 
            this.MSV.HeaderText = "MSV";
            this.MSV.Name = "MSV";
            // 
            // TIME
            // 
            this.TIME.HeaderText = "TIME";
            this.TIME.Name = "TIME";
            // 
            // CHECK
            // 
            this.CHECK.HeaderText = "CHECK";
            this.CHECK.Name = "CHECK";
            // 
            // _Tab_Register
            // 
            this._Tab_Register.Controls.Add(this.groupBox4);
            this._Tab_Register.Controls.Add(this._processBar);
            this._Tab_Register.Controls.Add(this.groupBox1);
            this._Tab_Register.Location = new System.Drawing.Point(4, 22);
            this._Tab_Register.Name = "_Tab_Register";
            this._Tab_Register.Padding = new System.Windows.Forms.Padding(3);
            this._Tab_Register.Size = new System.Drawing.Size(586, 408);
            this._Tab_Register.TabIndex = 2;
            this._Tab_Register.Text = "Đăng kí";
            this._Tab_Register.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this._tb_id_delet);
            this.groupBox4.Location = new System.Drawing.Point(306, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(265, 206);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Xóa vân tay";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhập ID cần xóa";
            // 
            // _tb_id_delet
            // 
            this._tb_id_delet.Location = new System.Drawing.Point(127, 57);
            this._tb_id_delet.Name = "_tb_id_delet";
            this._tb_id_delet.Size = new System.Drawing.Size(100, 20);
            this._tb_id_delet.TabIndex = 0;
            // 
            // _processBar
            // 
            this._processBar.Location = new System.Drawing.Point(22, 249);
            this._processBar.Name = "_processBar";
            this._processBar.Size = new System.Drawing.Size(549, 23);
            this._processBar.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._tb_ID);
            this.groupBox1.Controls.Add(this._Tb_name);
            this.groupBox1.Controls.Add(this._Tb_MSV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this._Bt_regsiter);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 206);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng kí vân tay";
            // 
            // _Tb_name
            // 
            this._Tb_name.Location = new System.Drawing.Point(88, 28);
            this._Tb_name.Name = "_Tb_name";
            this._Tb_name.Size = new System.Drawing.Size(100, 20);
            this._Tb_name.TabIndex = 3;
            // 
            // _Tb_MSV
            // 
            this._Tb_MSV.Location = new System.Drawing.Point(88, 79);
            this._Tb_MSV.Name = "_Tb_MSV";
            this._Tb_MSV.Size = new System.Drawing.Size(100, 20);
            this._Tb_MSV.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID: ";
            // 
            // _Bt_regsiter
            // 
            this._Bt_regsiter.Location = new System.Drawing.Point(88, 159);
            this._Bt_regsiter.Name = "_Bt_regsiter";
            this._Bt_regsiter.Size = new System.Drawing.Size(100, 31);
            this._Bt_regsiter.TabIndex = 2;
            this._Bt_regsiter.Text = "Đăng Kí";
            this._Bt_regsiter.UseVisualStyleBackColor = true;
            this._Bt_regsiter.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MSV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Và Tên";
            // 
            // _Tab_Wellcome
            // 
            this._Tab_Wellcome.Controls.Add(this._rtb_text);
            this._Tab_Wellcome.Controls.Add(this.groupBox3);
            this._Tab_Wellcome.Location = new System.Drawing.Point(4, 22);
            this._Tab_Wellcome.Name = "_Tab_Wellcome";
            this._Tab_Wellcome.Padding = new System.Windows.Forms.Padding(3);
            this._Tab_Wellcome.Size = new System.Drawing.Size(586, 408);
            this._Tab_Wellcome.TabIndex = 1;
            this._Tab_Wellcome.Text = "Wellcome";
            this._Tab_Wellcome.UseVisualStyleBackColor = true;
            // 
            // _rtb_text
            // 
            this._rtb_text.Location = new System.Drawing.Point(6, 11);
            this._rtb_text.Name = "_rtb_text";
            this._rtb_text.Size = new System.Drawing.Size(292, 374);
            this._rtb_text.TabIndex = 2;
            this._rtb_text.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._lb_1_id);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this._lb_1_sts);
            this.groupBox3.Controls.Add(this._lb_1_time);
            this.groupBox3.Controls.Add(this._lb_1_msv);
            this.groupBox3.Controls.Add(this._lb_1_name);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(304, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 231);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Information";
            // 
            // _lb_1_id
            // 
            this._lb_1_id.AutoSize = true;
            this._lb_1_id.Location = new System.Drawing.Point(84, 31);
            this._lb_1_id.Name = "_lb_1_id";
            this._lb_1_id.Size = new System.Drawing.Size(10, 13);
            this._lb_1_id.TabIndex = 9;
            this._lb_1_id.Text = " ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "ID     :";
            // 
            // _lb_1_sts
            // 
            this._lb_1_sts.AutoSize = true;
            this._lb_1_sts.Location = new System.Drawing.Point(84, 165);
            this._lb_1_sts.Name = "_lb_1_sts";
            this._lb_1_sts.Size = new System.Drawing.Size(10, 13);
            this._lb_1_sts.TabIndex = 7;
            this._lb_1_sts.Text = " ";
            // 
            // _lb_1_time
            // 
            this._lb_1_time.AutoSize = true;
            this._lb_1_time.Location = new System.Drawing.Point(84, 130);
            this._lb_1_time.Name = "_lb_1_time";
            this._lb_1_time.Size = new System.Drawing.Size(10, 13);
            this._lb_1_time.TabIndex = 6;
            this._lb_1_time.Text = " ";
            // 
            // _lb_1_msv
            // 
            this._lb_1_msv.AutoSize = true;
            this._lb_1_msv.Location = new System.Drawing.Point(81, 99);
            this._lb_1_msv.Name = "_lb_1_msv";
            this._lb_1_msv.Size = new System.Drawing.Size(10, 13);
            this._lb_1_msv.TabIndex = 5;
            this._lb_1_msv.Text = " ";
            // 
            // _lb_1_name
            // 
            this._lb_1_name.AutoSize = true;
            this._lb_1_name.Location = new System.Drawing.Point(81, 64);
            this._lb_1_name.Name = "_lb_1_name";
            this._lb_1_name.Size = new System.Drawing.Size(10, 13);
            this._lb_1_name.TabIndex = 4;
            this._lb_1_name.Text = " ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Status : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Time : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "MSV : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Name :";
            // 
            // _View_tab
            // 
            this._View_tab.Controls.Add(this._Tab_Wellcome);
            this._View_tab.Controls.Add(this._Tab_Register);
            this._View_tab.Controls.Add(this._Tab_Check_In);
            this._View_tab.Location = new System.Drawing.Point(4, 12);
            this._View_tab.Name = "_View_tab";
            this._View_tab.SelectedIndex = 0;
            this._View_tab.Size = new System.Drawing.Size(594, 434);
            this._View_tab.TabIndex = 0;
            this._View_tab.Tag = "View";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // _bt_add
            // 
            this._bt_add.Location = new System.Drawing.Point(713, 123);
            this._bt_add.Name = "_bt_add";
            this._bt_add.Size = new System.Drawing.Size(75, 23);
            this._bt_add.TabIndex = 6;
            this._bt_add.Text = "Add";
            this._bt_add.UseVisualStyleBackColor = true;
            this._bt_add.Click += new System.EventHandler(this._bt_add_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // _tb_ID
            // 
            this._tb_ID.Location = new System.Drawing.Point(88, 123);
            this._tb_ID.Name = "_tb_ID";
            this._tb_ID.Size = new System.Drawing.Size(100, 20);
            this._tb_ID.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._bt_add);
            this.Controls.Add(this._lb_time);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this._View_tab);
            this.Name = "Form1";
            this.Text = "Check In Time";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this._Tab_Check_In.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dgv_list)).EndInit();
            this._Tab_Register.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this._Tab_Wellcome.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this._View_tab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button _Bt_Connect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox _CB_COM;
        private System.Windows.Forms.ComboBox _Cb_baud;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label _lb_status;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label _lb_time;
        private System.Windows.Forms.TabPage _Tab_Check_In;
        private System.Windows.Forms.DataGridView _dgv_list;
        private System.Windows.Forms.TabPage _Tab_Register;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox _Tb_name;
        private System.Windows.Forms.TextBox _Tb_MSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _Bt_regsiter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage _Tab_Wellcome;
        private System.Windows.Forms.RichTextBox _rtb_text;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label _lb_1_id;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label _lb_1_sts;
        private System.Windows.Forms.Label _lb_1_time;
        private System.Windows.Forms.Label _lb_1_msv;
        private System.Windows.Forms.Label _lb_1_name;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl _View_tab;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button _bt_add;
        private System.Windows.Forms.ProgressBar _processBar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _tb_id_delet;
        private System.Windows.Forms.Button _bt_loaddata;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button _bt_saveData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHECK;
        private System.Windows.Forms.TextBox _tb_ID;
    }
}

