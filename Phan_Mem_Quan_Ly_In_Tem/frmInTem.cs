using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;
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
    public partial class frmInTem : Form
    {

        public delegate void ChoInEventHander(object sender, string mavach, string tenhang, decimal tongtrongluong, decimal trongluong, decimal hot, string nhacungcap, string hamluongpho, decimal tiencong, int soluongtem);

        public event ChoInEventHander ChoIn;
        private void RaiseChoInEventHander(string mavach, string tenhang, decimal tongtrongluong, decimal trongluong, decimal hot, string nhacungcap, string hamluongpho, decimal tiencong, int soluongtem)
        {
            if (ChoIn != null)
            {
                ChoIn(this, mavach, tenhang, tongtrongluong, trongluong, hot, nhacungcap, hamluongpho, tiencong, soluongtem);
            }
        }

        public delegate void XemEventHander();

        public event XemEventHander Xem;
        private void RaiseXemEventHander()
        {
            if (Xem != null)
            {
                Xem();
            }
        }

        string duongDanFileExcel = "";
        string tenMayIn = "";
        clsXuLyDuLieu _clsXuLyDuLieu = new clsXuLyDuLieu();

        public frmInTem()
        {
            InitializeComponent();
            TaoMoi();
        }

        public frmInTem(string _tenTiem, string _diaChi, string tenCongCOM, string _duongDanFileExcel, string _tenMayIn)
        {
            InitializeComponent();
            duongDanFileExcel = _duongDanFileExcel;

            txtTenTiem.Text = _tenTiem;
            txtDiaChi.Text = _diaChi;
            tenMayIn = _tenMayIn;

            TaoMoi();

            if (!Com.IsOpen && !string.IsNullOrEmpty(tenCongCOM))
            {
                try
                {
                    Com.PortName = tenCongCOM;
                    Com.Open();
                    Com.DataReceived += Com_DataReceived;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            //txtCanNang.EditValueChanged += txtCanNang_EditValueChanged;
        }

        //void txtCanNang_EditValueChanged(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
            
        //}

        public frmInTem(string _tenTiem, string _diaChi, string tenCongCOM, string _tenMayIn, string _duongDanFileExcel, string maVach, string tenHang, decimal tongTrongLuong, decimal trongLuong, decimal hot, decimal tienCong, string nhaCungCap, string hamLuongPho, int soLuongTem)
        {
            InitializeComponent();
            duongDanFileExcel = _duongDanFileExcel;
            txtTenTiem.Text = _tenTiem;
            txtDiaChi.Text = _diaChi;
            tenMayIn = _tenMayIn;

            TaoMoi();

            if (!Com.IsOpen && !string.IsNullOrEmpty(tenCongCOM))
            {
                try
                {
                    Com.PortName = tenCongCOM;
                    Com.Open();
                    Com.DataReceived += Com_DataReceived;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            txtMaVach.Text = maVach;
            txtTenHang.Text = tenHang;
            txtTongTrongLuong.Value = tongTrongLuong;
            txtTrongLuong.Value = trongLuong;
            txtHot.Value = hot;
            txtTienCong.Value = tienCong;
            txtNhaCungCap.Text = nhaCungCap;
            txtHamLuongPho.Text = hamLuongPho;
            txtSoLuongTem.Value = soLuongTem;
        }

        private void TaoMoi()
        {
            txtMaVach.Text = "M" + String.Format("{0:ddMMyyyy}", DateTime.Now);
            napDanhSachTenTiemVaDiaChi();
            var dt = new DataTable("ThongTinTiem");
            
            //dt.Columns.Add("TenTiem");
            //dt.Columns.Add("DiaChi");
            


            //var fi = new FileInfo(Application.StartupPath + "\\ThongTinTiem.xml");
            //if (!fi.Exists) return;

            //dt.ReadXml(Application.StartupPath + "\\ThongTinTiem.xml");
            //try
            //{
            //    if (dt.Rows.Count > 0)
            //    {
            //        //txtUserName.Text = MyEncryption.Decrypt(dt.Rows[0]["user"].ToString(), "963147", true);
            //        //txtPassword.Text = MyEncryption.Decrypt(dt.Rows[0]["pass"].ToString(), "963147", true);

            //        txtTenTiem.Text = dt.Rows[0]["TenTiem"].ToString();
            //        txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void napDanhSachTenTiemVaDiaChi()
        {

            if (File.Exists(duongDanFileExcel))
            {
                clsXuLyDuLieu _xuLy = new clsXuLyDuLieu();
                //bbiChonFileDuLieu.EditValue = duongDanFileExcelMacDinh;
                DataTable dtDanhSachNhaCungCap = new DataTable();
                dtDanhSachNhaCungCap = _xuLy.docDanhSachNhaCungCapFileExcel(duongDanFileExcel, Path.GetExtension(duongDanFileExcel), "Yes");
                //MessageBox.Show(dtMaVachExcel.Rows.Count.ToString());
                //napDuLieuVaoLuoiTuFileExcel(dtMaVachExcel);

                //var adapterDiaChi = new DANH_SACH_DIA_CHITableAdapter();
                //adapterDiaChi.Connection.ConnectionString = SqlHelper.ConnectionString;
                //adapterDiaChi.ClearBeforeFill = true;
                //adapterDiaChi.Fill(dtDanhSachDiaChi);

                AutoCompleteStringCollection mangDanhSachNhaCungCap = new AutoCompleteStringCollection();
                AutoCompleteStringCollection mangDanhSachDiaChi = new AutoCompleteStringCollection();
                AutoCompleteStringCollection mangDanhSachTenTiem = new AutoCompleteStringCollection();

                foreach (DataRow dr in dtDanhSachNhaCungCap.Rows)
                {
                    mangDanhSachNhaCungCap.Add(dr["Nhà Cung Cấp"].ToString());
                    mangDanhSachDiaChi.Add(dr["Địa Chỉ"].ToString());
                    mangDanhSachTenTiem.Add(dr["Tên Tiệm"].ToString());
                }

                var txtNhaCungCap_AutoComplete = txtNhaCungCap.MaskBox;
                txtNhaCungCap_AutoComplete.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtNhaCungCap_AutoComplete.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtNhaCungCap_AutoComplete.AutoCompleteCustomSource = mangDanhSachNhaCungCap;

                var txtDiaChi_AutoComplete = txtDiaChi.MaskBox;
                txtDiaChi_AutoComplete.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtDiaChi_AutoComplete.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtDiaChi_AutoComplete.AutoCompleteCustomSource = mangDanhSachDiaChi;

                var txtTenTiem_AutoComplete = txtTenTiem.MaskBox;
                txtTenTiem_AutoComplete.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtTenTiem_AutoComplete.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtTenTiem_AutoComplete.AutoCompleteCustomSource = mangDanhSachTenTiem;
            }
            
        }

        private void Com_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string canNang = "";
            if (Com.IsOpen)
            {
                canNang = Com.ReadExisting();
                txtCanNang.Text = canNang;
                txtTongTrongLuong.Value = chuyenCanNang(canNang);
                //rdgTuyChonCanNang_SelectedIndexChanged(this, null);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if(Com.IsOpen)
            {
                Com.Close();
            }
            this.Close();
        }

        private void frmKetNoiCan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Com.IsOpen)
            {
                Com.Close();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (!kiemTraTruocKhiIn())
            {
                return;
            }
            var rptMaVach = new rptInTemNuTrang(txtTenTiem.Text, txtDiaChi.Text, txtMaVach.Text, txtTenHang.Text, txtTongTrongLuong.Value, txtTongTrongLuong.Value, txtTienCong.Value, txtHot.Value, "", txtNhaCungCap.Text, txtHamLuongPho.Text, Convert.ToInt32(txtSoLuongTem.Value), txtTongTrongLuongChu.Text, txtTrongLuongChu.Text, txtHotChu.Text);
            rptMaVach.AssignPrintTool(new ReportPrintTool(rptMaVach));
            rptMaVach.CreateDocument();
            
            if(rdTuyChonIn.SelectedIndex == 0)
            {
                if(string.IsNullOrEmpty(tenMayIn))
                {
                    rptMaVach.ShowPreview();
                }
                else
                {
                    rptMaVach.Print(tenMayIn);
                }
            }
            else if (rdTuyChonIn.SelectedIndex == 1) 
            {
                rptMaVach.ShowPreview();
            }
            else if(rdTuyChonIn.SelectedIndex == 2)
            {
                rptMaVach.ShowDesigner();
            }

            try 
            {
                if (cbLuuSauKhiIn.Checked)
                {
                    _clsXuLyDuLieu.luuDuLieuExcel(duongDanFileExcel, txtMaVach.Text, txtTenHang.Text, txtTongTrongLuong.Value, txtTrongLuong.Value, txtHot.Value, txtTienCong.Value, "", txtNhaCungCap.Text, txtHamLuongPho.Text, txtTenTiem.Text, txtDiaChi.Text, Convert.ToInt32(txtSoLuongTem.Value));
                    RaiseXemEventHander();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (cbXoaTrongLuong.Checked)
            {
                txtTongTrongLuong.Value = 0;
                txtTrongLuong.Value = 0;
                txtHot.Value = 0;
            }
        }

        private void btnTuyChinh_Click(object sender, EventArgs e)
        {
            if(!kiemTraTruocKhiIn())
            {
                return;
            }

            ReportDesignTool dt = new ReportDesignTool(new rptInTemNuTrang(txtTenTiem.Text, txtDiaChi.Text, txtMaVach.Text, txtTenHang.Text, txtTongTrongLuong.Value, txtTongTrongLuong.Value, txtTienCong.Value, txtHot.Value, "", txtNhaCungCap.Text, txtHamLuongPho.Text, Convert.ToInt32(txtSoLuongTem.Value), txtTongTrongLuongChu.Text, txtTrongLuongChu.Text, txtHotChu.Text));

            // Access the report's properties.
            dt.Report.DrawGrid = false;

            // Access the Designer form's properties.
            dt.DesignForm.SetWindowVisibility(DesignDockPanelType.FieldList | DesignDockPanelType.PropertyGrid, false);

            // Show the Designer form, modally.
            dt.ShowDesignerDialog();

            //var rptMaVach = new rptInTemNuTrang(txtTenTiem.Text, txtDiaChi.Text, txtMaVach.Text, txtTenHang.Text, txtTongTrongLuong.Value, txtTongTrongLuong.Value, txtTienCong.Value, txtHot.Value, "", txtNhaCungCap.Text, txtHamLuongPho.Text, Convert.ToInt32(txtSoLuongTem.Value), txtTongTrongLuongChu.Text, txtTrongLuongChu.Text, txtHotChu.Text);
            //rptMaVach.AssignPrintTool(new ReportPrintTool(rptMaVach));
            //rptMaVach.CreateDocument();
            //rptMaVach.ShowDesigner();
            try
            {
                if (cbLuuSauKhiIn.Checked)
                {
                    _clsXuLyDuLieu.luuDuLieuExcel(duongDanFileExcel, txtMaVach.Text, txtTenHang.Text, txtTongTrongLuong.Value, txtTrongLuong.Value, txtHot.Value, txtTienCong.Value, "", txtNhaCungCap.Text, txtHamLuongPho.Text, txtTenTiem.Text, txtDiaChi.Text, Convert.ToInt32(txtSoLuongTem.Value));
                    RaiseXemEventHander();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaVach.Text = "M" + String.Format("{0:ddMMyyyy}", DateTime.Now);
            txtTenHang.Text = "";
            txtTongTrongLuong.Value = 0;
            txtTrongLuong.Value = 0;
            txtHot.Value = 0;
            txtNhaCungCap.Text = "";
            txtHamLuongPho.Text = "";
            txtTienCong.Value = 0;
            txtSoLuongTem.Value = 1;
            txtCanNang.Text = "0";
            cbLuuSauKhiIn.Checked = true;
        }

        //private void btnChoIn_Click(object sender, EventArgs e)
        //{
        //    RaiseChoInEventHander(txtMaVach.Text, txtTenHang.Text, txtTongTrongLuong.Value, txtTrongLuong.Value, txtHot.Value, txtNhaCungCap.Text, txtHamLuongPho.Text, txtTienCong.Value, Convert.ToInt32(txtSoLuongTem.Value));
        //    btnTaoMoi_Click(this, null);
        //}

        private void txtHot_EditValueChanged(object sender, EventArgs e)
        {
            txtTrongLuong.Value = txtTongTrongLuong.Value - txtHot.Value;
            docCanNangRaChu();
        }

        private void txtTongTrongLuong_EditValueChanged(object sender, EventArgs e)
        {
            txtTrongLuong.Value = txtTongTrongLuong.Value - txtHot.Value;
            docCanNangRaChu();
        }

        public decimal chuyenCanNang(string giaTriCan)
        {
            //  0.014785TT

            string chuoi = giaTriCan;
            var laySo = (from t in chuoi
                         where char.IsDigit(t) || t.Equals('.')
                         select t).ToArray();

            decimal phanNguyen = 0;
            decimal phanThapPhan = 0;

            string[] mangChuSo = (new string(laySo)).Split('.');

            phanNguyen = Convert.ToDecimal(mangChuSo[0]);
            phanThapPhan = Convert.ToDecimal(mangChuSo[1]) / Convert.ToDecimal(Math.Pow(10, mangChuSo[1].ToString().Length));

            decimal giaTri = 0;
            giaTri = phanNguyen + phanThapPhan;

            return (giaTri * 10);

            //string chuoiGiaTri = giaTriCan.Replace("TT", "").Trim();
            //chuoiGiaTri = chuoiGiaTri.Replace(".", ",");
            //chuoiGiaTri = chuoiGiaTri.Replace(" ", "");
            //MessageBox.Show(chuoiGiaTri);
            //decimal giaTri = 0;
            //if (!decimal.TryParse(chuoiGiaTri, out giaTri))
            //{
            //    MessageBox.Show("Giá trị cân không hợp lệ. " + giaTriCan + " ... " + chuoiGiaTri);
            //}

            //return (giaTri * 10);
        }

        

        private void txtTrongLuong_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            docCanNangRaChu();
        }

        private void docCanNangRaChu()
        {
            txtTongTrongLuongChu.Text = _clsXuLyDuLieu.chuyenGiaTriSangNoiDung(txtTongTrongLuong.Value);
            txtTrongLuongChu.Text = _clsXuLyDuLieu.chuyenGiaTriSangNoiDung(txtTrongLuong.Value);
            txtHotChu.Text = _clsXuLyDuLieu.chuyenGiaTriSangNoiDung(txtHot.Value);
        }

        private bool kiemTraTruocKhiIn()
        {
            if (txtTienCong.Value <= 0)
            {
                MessageBox.Show("Chưa nhập tiền công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTienCong.Focus();
                return false;
            }

            if(string.IsNullOrEmpty(txtTenHang.Text.Trim()))
            {
                MessageBox.Show("Chưa nhập tên hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenHang.Focus();
                return false;
            }

            if (txtTongTrongLuong.Value <= 0)
            {
                if (MessageBox.Show("Chưa nhập tổng trọng lượng. Bạn có muốn in hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No) 
                {
                    txtTongTrongLuong.Focus();
                    return false;
                }
            }

            if (txtTrongLuong.Value <= 0)
            {
                if (MessageBox.Show("Chưa nhập trọng lượng. Bạn có muốn in hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                {
                    txtTrongLuong.Focus();
                    return false;
                }
            }

            return true;
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(textEdit1.Text);
            ////0.014785TT
            //string canNang = "";
            //canNang = textEdit1.Text;
            //txtCanNang.Text = canNang;
            //txtTongTrongLuong.Value = chuyenCanNang(canNang);
        }

        private void txtTrongLuong_EditValueChanged(object sender, EventArgs e)
        {
            txtTrongLuongChu.Text = _clsXuLyDuLieu.chuyenGiaTriSangNoiDung(txtTrongLuong.Value);
        }

        private void txtHot_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() == "Xoa")
            {
                txtHot.Value = 0;
            }
        }

        private void txtTienCong_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() == "Xoa")
            {
                txtTienCong.Value = 0;
            }
        }

        private void txtTrongLuong_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() == "Xoa")
            {
                txtTrongLuong.Value = 0;
            }
        }

        private void txtTongTrongLuong_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() == "Xoa")
            {
                txtTongTrongLuong.Value = 0;
            }
        }

        private void btnXoaTrongLuong_Click(object sender, EventArgs e)
        {
            txtTongTrongLuong.Value = 0;
            txtTrongLuong.Value = 0;
            txtHot.Value = 0;
        }

        private void txtNhaCungCap_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() == "Chon")
            {
                var frmChonNhaCungCap = new frmDanhSachNhaCungCap(duongDanFileExcel);
                frmChonNhaCungCap.StartPosition = FormStartPosition.CenterParent;
                frmChonNhaCungCap.ChonNhaCungCap += (nhacungcap, tentiem, diachi) => 
                {
                    txtNhaCungCap.Text = nhacungcap;
                    txtTenTiem.Text = tentiem;
                    txtDiaChi.Text = diachi;
                };
                frmChonNhaCungCap.ShowDialog();   
            }
        }

        private void txtDiaChi_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() == "Chon")
            {
                var frmChonNhaCungCap = new frmDanhSachNhaCungCap(duongDanFileExcel);
                frmChonNhaCungCap.StartPosition = FormStartPosition.CenterParent;
                frmChonNhaCungCap.ChonNhaCungCap += (nhacungcap, tentiem, diachi) =>
                {
                    txtNhaCungCap.Text = nhacungcap;
                    txtTenTiem.Text = tentiem;
                    txtDiaChi.Text = diachi;
                };
                frmChonNhaCungCap.ShowDialog();
            }
        }

        private void txtTenTiem_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() == "Chon")
            {
                var frmChonNhaCungCap = new frmDanhSachNhaCungCap(duongDanFileExcel);
                frmChonNhaCungCap.StartPosition = FormStartPosition.CenterParent;
                frmChonNhaCungCap.ChonNhaCungCap += (nhacungcap, tentiem, diachi) =>
                {
                    txtNhaCungCap.Text = nhacungcap;
                    txtTenTiem.Text = tentiem;
                    txtDiaChi.Text = diachi;
                };
                frmChonNhaCungCap.ShowDialog();
            }
        }
    }
}
