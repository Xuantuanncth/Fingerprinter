using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;



namespace FingerPrinter
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        OpenFileDialog openfile = new OpenFileDialog();

        private string path_file = "H:/Resource/listdata.txt";
        private string data_recv;
        private int c_time;
        private int id_st = 1;

        public Form1()
        {
            InitializeComponent();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceive);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] COM = SerialPort.GetPortNames();
            _CB_COM.Items.AddRange(COM);
            timer1.Enabled = true;
            timer1.Start();
            timer2.Start();
            load_file();
           // check_id();
        }

        private void DataReceive(object sender, SerialDataReceivedEventArgs e)
        {
            data_recv = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }
        private void ShowData(object sender, EventArgs e)
        {
            _rtb_text.Text += data_recv;

        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int begin_time = 0;
            int count = 1;
            var data_in = new Data
            {
                Name = _Tb_name.Text,
                MSV = _Tb_MSV.Text,
                ID = Convert.ToString(id_st)
            };
            Console.WriteLine(data_recv);
            _processBar.Maximum = 60;
            _processBar.Step = 1;
            if (_Tb_name.Text != "" && _Tb_MSV.Text != "" && _tb_ID.Text != "" && IsNumber(_tb_ID.Text) && serialPort1.IsOpen)
            {
                serialPort1.WriteLine(data_in.ID);
                Console.WriteLine(data_recv);
                while (begin_time < 60)
                {
                    if (data_recv == "ok")
                    {
                        File.AppendAllText(path_file, data_in.ID + ":" + data_in.Name + ":" + data_in.MSV + "\r\n");
                        MessageBox.Show("Dang ki thanh cong");
                        count = 2;
                        id_st++;
                        _tb_ID.Clear();
                        _Tb_name.Clear();
                        _Tb_MSV.Clear();
                        break;
                    }
                    _processBar.PerformStep();
                    begin_time++;
                    Thread.Sleep(1000);
                }

                _processBar.Value = 0;
                data_recv = "";
                if (count == 1)
                {
                    MessageBox.Show("Khong the dang ki");
                }

            }
            else
            {
                if (!serialPort1.IsOpen)
                {
                    MessageBox.Show("Ket noi thiet bi");
                }
                 if (_Tb_name.Text == "")
                {
                    MessageBox.Show("Nhap ho ten sinh vien");
                }
                if (_Tb_MSV.Text == "")
                {
                    MessageBox.Show("Nhap ma sinh vien");
                }
                if (_tb_ID.Text == "")
                {
                    MessageBox.Show("Nhap ID sinh vien");
                }
                if (!IsNumber(_tb_ID.Text))
                {
                    MessageBox.Show("Nhap ID sinh vien sai ! 1 < ID < 127");
                }

            }
        }
        private void _Tab_Check_In_Click(object sender, EventArgs e)
        {

        }
        private bool seach_id_for_drgv(string id)
        {
            _dgv_list.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in _dgv_list.Rows)
                {
                    if (row.Cells["ID"].Value.ToString().Equals(id))
                    {
                        row.Selected = true;                       
                        break;
                    }
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
                return false;
            }
            return true;
        }
        private void load_file()
        {
            char[] spearator = { ':' };
            Console.WriteLine(File.Exists(path_file) ? "File exists." : "File does not exist.");
            if (File.Exists(path_file))
            {
                long length = new System.IO.FileInfo(path_file).Length;
                if (length > 0)
                {
                    var fileStream = new FileStream(path_file, FileMode.Open, FileAccess.Read);
                    using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                    {
                        string line;

                        while ((line = streamReader.ReadLine()) != null)
                        {
                            String[] strlist = line.Split(spearator, 3, StringSplitOptions.None);
                            _dgv_list.Rows.Add(strlist);
                        }                                        
                        Console.WriteLine("Row count: " + id_st);
                    }
                }
            }
        }
        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                _Bt_Connect.Text = "Connect";
                _Bt_Connect.ForeColor = Color.Red;
                _lb_status.Text = "Disconnect";
                _lb_status.ForeColor = Color.Red;
            }
            else
            {
                serialPort1.PortName = _CB_COM.Text;
                serialPort1.BaudRate = Convert.ToInt32(_Cb_baud.Text);
                serialPort1.Open();
                _Bt_Connect.Text = "Disconnect";
                _Bt_Connect.ForeColor = Color.Green;
                _rtb_text.Text += "Serial Port: " + _CB_COM.Text + " connect\r\n";
                _lb_status.Text = "Connect";
                _lb_status.ForeColor = Color.Green;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            _lb_time.Text = time.ToString("HH:mm:ss");
        }
        private void check_time(int id)
        {
            string seach_value = Convert.ToString(id);
            DateTime lastTime = Convert.ToDateTime("9:00:00");
            _dgv_list.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach(DataGridViewRow row in _dgv_list.Rows)
                {
                    string value = row.Cells["ID"].Value.ToString();
                    Console.WriteLine("ID: " + value);
                    if (row.Cells["ID"].Value.ToString().Equals(seach_value))
                    {
                        _dgv_list.Rows[id-1].Cells["TIME"].Value = _lb_time.Text;
                        _lb_1_id.Text = seach_value;
                        _lb_1_name.Text = _dgv_list.Rows[id - 1].Cells["NAME"].Value.ToString();
                        _lb_1_msv.Text = _dgv_list.Rows[id - 1].Cells["MSV"].Value.ToString();
                        _lb_1_time.Text = _lb_time.Text;
                        int check = DateTime.Compare(DateTime.Now, lastTime);
                        if (check <= 0)
                        {
                            _dgv_list.Rows[id-1].Cells["CHECK"].Value = "OKE";
                            _lb_1_sts.Text = "OKE";
                        }
                        else
                        {
                            _dgv_list.Rows[id-1].Cells["CHECK"].Value = "LATE";
                            _lb_1_sts.Text = "LATE";
                        }
                    }
                }
            }
            catch
            {

            }
        }
        private void _bt_add_Click(object sender, EventArgs e)
        {
            //_dgv_list.Rows[index].Cells["_RTB_time"].Value = "yes";
            //_dgv_list.Rows[0].Cells["CHECK"].Value = "no";
            //check_time(2);
            
        }
        public bool IsNumber (string data)
        {
            foreach(char c in data)
            {
                if(!Char.IsDigit(c))
                {
                    Console.WriteLine("Char c: "+c);
                    return false;
                }
            }
            return true;
        }
        private void Timer2_Tick(object sender, EventArgs e)
        {
            if(data_recv != null && data_recv != "")
            {
                Console.WriteLine(data_recv);
                if (IsNumber(data_recv))
                {
                    Console.WriteLine("Data: " + data_recv);
                    check_time(Convert.ToInt32(data_recv));                  
                }
                data_recv = null;
            }
          
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            string id_delete = _tb_id_delet.Text;
            serialPort1.WriteLine(id_delete);
        }
    }
}
