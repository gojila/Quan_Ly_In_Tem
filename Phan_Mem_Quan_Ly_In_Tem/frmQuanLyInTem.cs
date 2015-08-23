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
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Phan_Mem_Quan_Ly_In_Tem
{
    public partial class frmQuanLyInTem : Form
    {
        clsXuLyDuLieu _xuLy = new clsXuLyDuLieu();
        public frmQuanLyInTem()
        {
            InitializeComponent();

            napDanhSachMayIn();
            napDanhSachCongCom();
            napThongTin();

            rptChonFile.ButtonClick += rptChonFile_ButtonClick;

            var fileThongTinTiem = new FileInfo(Application.StartupPath + "\\ThongTinTiem.xml");
            if (!fileThongTinTiem.Exists)
            {
                string duongDanFileExcelMacDinh = Application.StartupPath + "\\InMaVach.xlsx";
                if (File.Exists(duongDanFileExcelMacDinh))
                {
                    bbiChonFileDuLieu.EditValue = duongDanFileExcelMacDinh;
                    DataTable dtMaVachExcel = new DataTable();
                    dtMaVachExcel = _xuLy.docFileExcel(duongDanFileExcelMacDinh, Path.GetExtension(duongDanFileExcelMacDinh), "Yes");

                    napDuLieuVaoLuoiTuFileExcel(dtMaVachExcel);
                }
            }
        }

        private void napDanhSachMayIn()
        {
            rpt_cbMayIn.Items.Clear();
            foreach (string tenMayIn in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                rpt_cbMayIn.Items.Add(tenMayIn);
            }

            if(rpt_cbMayIn.Items.Count > 0)
            {
                bbiMayIn.EditValue = rpt_cbMayIn.Items[0].ToString();
            }
        }

        private void napDanhSachCongCom()
        {
            rpt_cbCongCOM.Items.Clear();
            string[] port = SerialPort.GetPortNames();
            foreach (string item in port)
            {

                rpt_cbCongCOM.Items.Add(item);
            }
            if (port.Length > 0)
            {
                bbiCongCOM.EditValue = port[0];
            }
        }

        private void napThongTin()
        {
            var dt = new DataTable("ThongTinTiem");

            dt.Columns.Add("TenTiem");
            dt.Columns.Add("DiaChi");
            dt.Columns.Add("CongCOM");
            dt.Columns.Add("FileExcel");
            dt.Columns.Add("MayIn");

            var fi = new FileInfo(Application.StartupPath + "\\ThongTinTiem.xml");
            if (!fi.Exists)
                return;

            dt.ReadXml(Application.StartupPath + "\\ThongTinTiem.xml");
            try
            {
                if (dt.Rows.Count > 0)
                {
                    //txtTenTiem.Text = dt.Rows[0]["TenTiem"].ToString();
                    //txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();

                    string tenTiem = dt.Rows[0]["TenTiem"] == DBNull.Value ? "" : dt.Rows[0]["TenTiem"].ToString();
                    string diaChi = dt.Rows[0]["DiaChi"] == DBNull.Value ? "" : dt.Rows[0]["DiaChi"].ToString();
                    string congCOM = dt.Rows[0]["CongCOM"] == DBNull.Value ? "" : dt.Rows[0]["CongCOM"].ToString();
                    string duongDanFileExcel = dt.Rows[0]["FileExcel"] == DBNull.Value ? "" : dt.Rows[0]["FileExcel"].ToString();
                    string mayIn = dt.Rows[0]["MayIn"] == DBNull.Value ? "" : dt.Rows[0]["MayIn"].ToString();

                    bbiTenTiem.EditValue = tenTiem;
                    bbiDiaChi.EditValue = diaChi;

                    if (!string.IsNullOrEmpty(congCOM))
                    {
                        bbiCongCOM.EditValue = congCOM;
                    }

                    if(!string.IsNullOrEmpty(mayIn))
                    {
                        bbiMayIn.EditValue = mayIn;
                    }

                    if (!string.IsNullOrEmpty(duongDanFileExcel))
                    {
                        bbiChonFileDuLieu.EditValue = duongDanFileExcel;

                        if (File.Exists(duongDanFileExcel))
                        {
                            DataTable dtMaVachExcel = new DataTable();
                            dtMaVachExcel = _xuLy.docFileExcel(duongDanFileExcel, Path.GetExtension(duongDanFileExcel), "Yes");

                            napDuLieuVaoLuoiTuFileExcel(dtMaVachExcel);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rptChonFile_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Tag.ToString() == "Chon")
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "(*.xls, *.xlsx)|*.xls;*.xlsx|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 1;

                openFileDialog1.Multiselect = false;

                // Call the ShowDialog method to show the dialog box.
                if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;

                string path = openFileDialog1.FileName;
                bbiChonFileDuLieu.EditValue = path;

                if (!string.IsNullOrEmpty(path) && File.Exists(path))
                {
                    
                    var _xuLy = new clsXuLyDuLieu();

                    DataTable dtMaVachExcel = new DataTable();
                    dtMaVachExcel = _xuLy.docFileExcel(path, Path.GetExtension(path), "Yes");

                    napDuLieuVaoLuoiTuFileExcel(dtMaVachExcel);
                }
            }
        }

        private void bbiDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiInTem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string tenTiem = bbiTenTiem.EditValue == null ? "" : bbiTenTiem.EditValue.ToString();
            string diaChi = bbiDiaChi.EditValue == null ? "" : bbiDiaChi.EditValue.ToString();
            string tenCongCOM = bbiCongCOM.EditValue == null ? "" : bbiCongCOM.EditValue.ToString();
            string tenMayIn = bbiMayIn.EditValue == null ? "" : bbiMayIn.EditValue.ToString();
            string duongDanFileExcel = bbiChonFileDuLieu.EditValue == null ? "" : bbiChonFileDuLieu.EditValue.ToString();

            var _frmIntem = new frmInTem(tenTiem, diaChi, tenCongCOM, duongDanFileExcel, tenMayIn);
            _frmIntem.Xem += () => 
            {
                bbiXem_ItemClick(this, null);
            };
            _frmIntem.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmTest();
            frm.ShowDialog();
        }

        private void napDuLieuVaoLuoiTuFileExcel(DataTable dtMaVachExcel)
        {
            dsDanhSachHangHoa.InMaVach.Rows.Clear();
            foreach (DataRow dr in dtMaVachExcel.Rows)
            {
                //AddInMaVachRow(string MaVach, string TenHang, decimal TongTrongLuong, decimal TrongLuong, decimal TienCong, decimal Hot, string LoaiVang, string NhaCungCap, string HamLuongPho, int SoLuongTem, string TongTrongLuongChu, string TrongLuongChu, string HotChu)
                dsDanhSachHangHoa.InMaVach.AddInMaVachRow
                    (
                    dr["Mã Vạch"].ToString(),
                    dr["Tên Hàng"].ToString(),
                    Convert.ToDecimal(dr["Tổng Trọng Lượng"] == DBNull.Value ? 0 : dr["Tổng Trọng Lượng"]),
                    Convert.ToDecimal(dr["Trọng Lượng"] == DBNull.Value ? 0 : dr["Trọng Lượng"]),
                    Convert.ToDecimal(dr["Tiền Công"] == DBNull.Value ? 0 : dr["Tiền Công"]),
                    Convert.ToDecimal(dr["Hột"] == DBNull.Value ? 0 : dr["Hột"]),
                    dr["Nhà Cung Cấp"].ToString(),
                    dr["Hàm Lượng Phổ"].ToString(),
                    Convert.ToInt32(dr["Số Lượng Tem"] == DBNull.Value ? 0 : dr["Số Lượng Tem"]),
                    _xuLy.chuyenGiaTriSangNoiDung(Convert.ToDecimal(dr["Tổng Trọng Lượng"] == DBNull.Value ? 0 : dr["Tổng Trọng Lượng"])),
                    _xuLy.chuyenGiaTriSangNoiDung(Convert.ToDecimal(dr["Trọng Lượng"] == DBNull.Value ? 0 : dr["Trọng Lượng"])),
                    _xuLy.chuyenGiaTriSangNoiDung(Convert.ToDecimal(dr["Hột"] == DBNull.Value ? 0 : dr["Hột"])),
                    dr["Tên Tiệm"].ToString(),
                    dr["Địa Chỉ"].ToString()
                    );
            }

            gbList.BestFitColumns();
        }

        private void gbList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            int rowIndex = e.RowHandle;
            if (rowIndex >= 0)
            {
                rowIndex++;
                e.Info.DisplayText = rowIndex.ToString();
            }
        }

        private void bbiXem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string duongDanFileExcel = bbiChonFileDuLieu.EditValue.ToString();
                if (!string.IsNullOrEmpty(duongDanFileExcel))
                {
                    bbiChonFileDuLieu.EditValue = duongDanFileExcel;

                    if (File.Exists(duongDanFileExcel))
                    {
                        var _xuLy = new clsXuLyDuLieu();

                        DataTable dtMaVachExcel = new DataTable();
                        dtMaVachExcel = _xuLy.docFileExcel(duongDanFileExcel, Path.GetExtension(duongDanFileExcel), "Yes");

                        napDuLieuVaoLuoiTuFileExcel(dtMaVachExcel);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rptLinkInTem_Click(object sender, EventArgs e)
        {
            string maVach = gbList.GetFocusedRowCellValue(colMaVach).ToString();
            string tenHang = gbList.GetFocusedRowCellValue(colTenHang).ToString();
            
            decimal tongTrongLuong = 0;
            Decimal.TryParse(gbList.GetFocusedRowCellValue(colTongTrongLuong).ToString(), out tongTrongLuong);

            decimal trongLuong = 0;
            Decimal.TryParse(gbList.GetFocusedRowCellValue(colTrongLuong).ToString(), out trongLuong);
            
            decimal hot = 0;
            Decimal.TryParse(gbList.GetFocusedRowCellValue(colHot).ToString(), out hot);
            
            decimal tienCong = 0;
            Decimal.TryParse(gbList.GetFocusedRowCellValue(colTienCong).ToString(), out tienCong);

            string nhaCungCap = gbList.GetFocusedRowCellValue(colNhaCungCap).ToString(); 
            string hamLuongPho = gbList.GetFocusedRowCellValue(colHamLuongPho).ToString();
            
            int soLuongTem = 0;
            Int32.TryParse(gbList.GetFocusedRowCellValue(colSoLuongTem).ToString(), out soLuongTem);

            string tenTiem = gbList.GetFocusedRowCellValue(colTenTiem).ToString();
            string diaChi = gbList.GetFocusedRowCellValue(colDiaChi).ToString();

            //string tenTiem = bbiTenTiem.EditValue == null ? "" : bbiTenTiem.EditValue.ToString();
            //string diaChi = bbiDiaChi.EditValue == null ? "" : bbiDiaChi.EditValue.ToString();            

            string tenCongCOM = bbiCongCOM.EditValue == null ? "" : bbiCongCOM.EditValue.ToString();
            string tenMayIn = bbiMayIn.EditValue == null ? "" : bbiMayIn.EditValue.ToString();
            string duongDanFileExcel = bbiChonFileDuLieu.EditValue == null ? "" : bbiChonFileDuLieu.EditValue.ToString();

            var _frmIntem = new frmInTem(tenTiem, diaChi, tenCongCOM, tenMayIn, duongDanFileExcel, maVach, tenHang, tongTrongLuong, trongLuong, hot, tienCong, nhaCungCap, hamLuongPho, soLuongTem);
            _frmIntem.Xem += () =>
            {
                bbiXem_ItemClick(this, null);
            };
            _frmIntem.ShowDialog();
        }

        private void bbiThongTin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThongTin _frmThongTin = new frmThongTin();
            _frmThongTin.NapLai += () => 
            {
                napThongTin();
            };
            _frmThongTin.ShowDialog();
        }

        private void frmQuanLyInTem_FormClosing(object sender, FormClosingEventArgs e)
        {
            string tenTiem = bbiTenTiem.EditValue == null ? "" : bbiTenTiem.EditValue.ToString();
            string diaChi = bbiDiaChi.EditValue == null ? "" : bbiDiaChi.EditValue.ToString();
            string congCOM = bbiCongCOM.EditValue == null ? "" : bbiCongCOM.EditValue.ToString();
            string duongDanFileExcel = bbiChonFileDuLieu.EditValue == null ? "" : bbiChonFileDuLieu.EditValue.ToString();
            string mayIn = bbiMayIn.EditValue == null ? "" : bbiMayIn.EditValue.ToString();

            clsXuLyDuLieu _clsXuLyDuLieu = new clsXuLyDuLieu();
            _clsXuLyDuLieu.luuThongTin(tenTiem, diaChi, congCOM, duongDanFileExcel, mayIn);
            
        }

        private void bbiTuDongCan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var _frmKetNoiCanTuDong = new frmKetNoiCanTuDong();
            _frmKetNoiCanTuDong.ShowDialog();
        }
    }
}
