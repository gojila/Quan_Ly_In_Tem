using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly_In_Tem
{
    public partial class frmKetNoiCanTuDong : Form
    {
        public frmKetNoiCanTuDong()
        {
            InitializeComponent();
            napDanhSachCongCom();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (Com.IsOpen)
            {
                Com.Close();
            }
            this.Close();
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                //if (!Com.IsOpen && !string.IsNullOrEmpty(cbCongCOM.Text))
                {
                    if(!Com.IsOpen)
                    {
                        Com.PortName = cbCongCOM.Text;
                        Com.BaudRate = 1200;
                        Com.DataReceived += Com_DataReceived;
                        Com.Open();
                    }

                    //Com.WriteLine("g ");
                    //Com.WriteLine("G ");
                    //Com.WriteLine("g TT ");
                    //Com.WriteLine("g tt ");
                    //Com.WriteLine("g Tl ");
                    //Com.WriteLine("g tl ");
                    //Com.WriteLine("G TT ");
                    //Com.WriteLine("G tt ");
                    //Com.WriteLine("G Tl ");
                    //Com.WriteLine("G tl ");
                    //P R I N T (C / R)
                    //Com.WriteLine("P R I N T (C / R)");
                    //byte[] _commandCode = System.Text.Encoding.UTF8.GetBytes("UW1=1.23(C/R) ");
                    //Com.Write(_commandCode, 0, _commandCode.Length);

                    //Com.Write("PRINT= ");
                    //Com.Write("g (C / R)");
                    //Com.DiscardInBuffer();
                    Com.Write(txtCommand.Text);

                    //Com.WriteLine("D01");
                    //Com.WriteLine("D05");
                    //Com.WriteLine("D05");
                    //Com.WriteLine("D06");
                    //Com.WriteLine("D07");
                    //Com.WriteLine("D08");
                    //Com.WriteLine("D09TT");


                    //byte[] _commandCode = System.Text.Encoding.UTF8.GetBytes("D01");
                    //Com.Write(_commandCode, 0, _commandCode.Length);

                    //_commandCode = System.Text.Encoding.UTF8.GetBytes("D05");
                    //Com.Write(_commandCode, 0, _commandCode.Length);

                    //_commandCode = System.Text.Encoding.UTF8.GetBytes("D06");
                    //Com.Write(_commandCode, 0, _commandCode.Length);

                    //_commandCode = System.Text.Encoding.UTF8.GetBytes("D07");
                    //Com.Write(_commandCode, 0, _commandCode.Length);

                    //_commandCode = System.Text.Encoding.UTF8.GetBytes("D08");
                    //Com.Write(_commandCode, 0, _commandCode.Length);

                    //_commandCode = System.Text.Encoding.UTF8.GetBytes("D09");
                    //Com.Write(_commandCode, 0, _commandCode.Length);

                    //Com.Close();

                    //MessageBox.Show("Thực hiện thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //if (MessageBox.Show("Thực hiện thành công.\nBạn có muốn đóng chức năng này lại không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    //{
                    //    this.Close();
                    //}
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void napDanhSachCongCom()
        {
            cbCongCOM.Properties.Items.Clear();
            string[] port = SerialPort.GetPortNames();
            foreach (string item in port)
            {

                cbCongCOM.Properties.Items.Add(item);
            }
            if (port.Length > 0)
            {
                cbCongCOM.EditValue = port[0];
            }
        }

        private void frmKetNoiCan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Com.IsOpen)
            {
                Com.Close();
            }
        }

        private void Com_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            //MessageBox.Show(indata);
            txtCanNang.Text = indata;

            //string canNang = "";
            //if (Com.IsOpen)
            //{
            //    canNang = Com.ReadExisting();
            //    txtCanNang.Text = canNang;
            //    //txtTongTrongLuong.Value = chuyenCanNang(canNang);
            //    //rdgTuyChonCanNang_SelectedIndexChanged(this, null);
            //}
        }
    }
}
