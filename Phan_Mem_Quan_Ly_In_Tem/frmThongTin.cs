using DevExpress.XtraEditors;
using Phan_Mem_Quan_Ly_In_Tem.XuLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly_In_Tem
{
    public partial class frmThongTin : Form
    {
        public delegate void NapLaiEventHander();

        public event NapLaiEventHander NapLai;
        private void RaiseNapLaiEventHander()
        {
            if (NapLai != null)
            {
                NapLai();
            }
        }

        public frmThongTin()
        {
            InitializeComponent();

            napDanhSachCongCom();
            napDanhSachMayIn();

            var dt = new DataTable("ThongTinTiem");

            dt.Columns.Add("TenTiem");
            dt.Columns.Add("DiaChi");
            dt.Columns.Add("CongCOM");
            dt.Columns.Add("FileExcel");
            dt.Columns.Add("MayIn");

            var fi = new FileInfo(Application.StartupPath + "\\ThongTinTiem.xml");
            if (!fi.Exists) 
            {
                txtDuongDanDuLieu.Text = Application.StartupPath + "\\" + "InMaVach.xlsx";
                return; 
            }
            else
            {
                dt.ReadXml(Application.StartupPath + "\\ThongTinTiem.xml");
                try
                {
                    if (dt.Rows.Count > 0)
                    {
                        //txtUserName.Text = MyEncryption.Decrypt(dt.Rows[0]["user"].ToString(), "963147", true);
                        //txtPassword.Text = MyEncryption.Decrypt(dt.Rows[0]["pass"].ToString(), "963147", true);

                        txtTenTiem.Text = dt.Rows[0]["TenTiem"] == DBNull.Value ? "" : dt.Rows[0]["TenTiem"].ToString();
                        txtDiaChi.Text = dt.Rows[0]["DiaChi"] == DBNull.Value ? "" : dt.Rows[0]["DiaChi"].ToString();
                        txtCongCOM.Text = dt.Rows[0]["CongCOM"] == DBNull.Value ? "" : dt.Rows[0]["CongCOM"].ToString();
                        txtTenMayIn.Text = dt.Rows[0]["MayIn"] == DBNull.Value ? "" : dt.Rows[0]["MayIn"].ToString();
                        txtDuongDanDuLieu.Text = dt.Rows[0]["FileExcel"] == DBNull.Value ? "" : dt.Rows[0]["FileExcel"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void napDanhSachMayIn()
        {
            txtTenMayIn.Properties.Items.Clear();
            foreach (string tenMayIn in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {

                txtTenMayIn.Properties.Items.Add(tenMayIn);
            }
        }

        private void napDanhSachCongCom()
        {
            txtCongCOM.Properties.Items.Clear();
            string[] port = SerialPort.GetPortNames();
            foreach (string item in port)
            {
                txtCongCOM.Properties.Items.Add(item);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var ds = new DataSet();
            //    var dt = new DataTable("ThongTinTiem");

            //    dt.Columns.Add("TenTiem");
            //    dt.Columns.Add("DiaChi");
            //    dt.Columns.Add("CongCOM");
            //    dt.Columns.Add("FileExcel");

            //    dt.Rows.Clear();
            //    dt.Rows.Add(
            //        new object[] 
            //        { 
            //            txtTenTiem.Text,
            //            txtDiaChi.Text,
            //            txtCongCOM.Text,
            //            txtDuongDanDuLieu.Text
            //        }
            //        );

            //    ds.Tables.Add(dt);
            //    ds.WriteXml("ThongTinTiem.xml");

            //    RaiseNapLaiEventHander();
            //    this.Close();

            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            clsXuLyDuLieu _clsXuLyDuLieu = new clsXuLyDuLieu();
            if(_clsXuLyDuLieu.luuThongTin(txtTenTiem.Text, txtDiaChi.Text, txtCongCOM.Text, txtDuongDanDuLieu.Text, txtTenMayIn.Text))
            {
                RaiseNapLaiEventHander();
                this.Close();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDuongDanDuLieu_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() == "Chon")
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "(*.xls, *.xlsx)|*.xls;*.xlsx|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 1;

                openFileDialog1.Multiselect = false;

                // Call the ShowDialog method to show the dialog box.
                if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;

                string path = openFileDialog1.FileName;
                txtDuongDanDuLieu.Text = path;
            }
        }
    }
}
