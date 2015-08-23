using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly_In_Tem
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();

            calcEdit1.EditValue = 10.123456789;
            textEdit1.Text = "0.014785TT";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            decimal canNang = calcEdit1.Value;

            decimal phanNguyen = (int)canNang;
            decimal phanLe_PhanLy = (decimal)((int)((canNang - (int)canNang) * 100)) / 100;
            decimal phanLe_TieuLy = Math.Round((canNang - (phanNguyen + phanLe_PhanLy)), 4);


            //MessageBox.Show(Math.Truncate(calcEdit1.Value).ToString());
            //MessageBox.Show((calcEdit1.Value - Math.Truncate(calcEdit1.Value)).ToString());

            MessageBox.Show(phanNguyen.ToString());
            MessageBox.Show(phanLe_PhanLy.ToString());
            MessageBox.Show(phanLe_TieuLy.ToString());

            if (phanLe_TieuLy >= 0 && phanLe_TieuLy < 0.0030m)
            {
                phanLe_TieuLy = 0;
            }
            else if (phanLe_TieuLy >= 0.0030m && phanLe_TieuLy < 0.0080m)
            {
                phanLe_TieuLy = 0.005m;
            }
            else if (phanLe_TieuLy >= 0.0080m && phanLe_TieuLy < 0.01m)
            {
                phanLe_TieuLy = 0.01m;
            }

            MessageBox.Show(phanLe_TieuLy.ToString());

            MessageBox.Show((phanNguyen + phanLe_PhanLy + phanLe_TieuLy).ToString());

            //MessageBox.Show(chuyenGiaTriSangNoiDung(canNang));
            //MessageBox.Show(Math.Ceiling(canNang).ToString());
            //MessageBox.Show(Math.Round(canNang, 5).ToString());
        }

        public string chuyenGiaTriSangNoiDung(decimal canNang)
        {
            string[] tachChuoi = String.Format("{0:##,##0.#####}", (canNang * 10)).ToString().Split(',');

            string phanNguyen = tachChuoi[0];
            string phanLe = tachChuoi[1];

            string chi = phanNguyen;
            string phan = phanLe.Substring(0, 1);
            string ly = phanLe.Substring(1, 1);
            string dem = phanLe.Substring(2, 1);
            string tieudem = phanLe.Substring(3, 1);

            //MessageBox.Show(phanNguyen);
            //MessageBox.Show(phanLe);

            //MessageBox.Show(phanLe.Substring(0, 1));
            //MessageBox.Show(phanLe.Substring(1, 1));
            //MessageBox.Show(phanLe.Substring(2, 1));
            //MessageBox.Show(phanLe.Substring(3, 1));
            //MessageBox.Show(phanLe.Substring(4, 1));

            if (Convert.ToInt32(chi) != 0)
            {
                return chi + "C" + phanLe;
            }
            else if (Convert.ToInt32(phan) != 0)
            {
                return phan + "P" + phanLe.Substring(1,3);
            }
            else if (Convert.ToInt32(ly) != 0)
            {
                return ly + "ly" + phanLe.Substring(2, 2);
            }
            else
            {
                return "0,0000";
            }


            //decimal phanNguyen = (int)canNang;
            //decimal phanLe = canNang - (int)canNang;
            ////decimal tam = phanLe;

            //int luong = (int)canNang;
            //int chi = (int)(phanLe * 10);
            ////tam = (phanLe * 10);
            //int phan = ((int)(phanLe * 100)) % 10;
            //int ly = ((int)(phanLe * 1000)) % 10;
            //int tieuly = ((int)(phanLe * 10000)) % 10;

            //if (luong != 0)
            //{
            //    return ((luong * 10) + chi).ToString() + "C" + phan.ToString() + ly.ToString() + tieuly.ToString();
            //}
            //else if(chi != 0)
            //{
            //    return chi.ToString() + "C" + phan.ToString() + ly.ToString() + tieuly.ToString();
            //}
            //else if (phan != 0)
            //{
            //    return phan.ToString() + "P" + ly.ToString() + tieuly.ToString() + "0";
            //}
            //else if (ly != 0)
            //{
            //    return ly.ToString() + "ly" + tieuly.ToString() + "0";
            //}
            //else if (tieuly != 0)
            //{
            //    return "0ly" + tieuly.ToString() + "00";
            //}
            //else
            //{
            //    return "0,0000";
            //}

            return "";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //string chuoi = textEdit1.Text;
            //var laySo = (from t in chuoi
            //                  where char.IsDigit(t) || t.Equals('.')
            //                  select t).ToArray();

            //decimal phanNguyen = 0;
            //decimal phanThapPhan = 0;

            //string[] mangChuSo = (new string(laySo)).Split('.');

            //MessageBox.Show(mangChuSo[0]);
            //MessageBox.Show(mangChuSo[1]);

            //phanNguyen = Convert.ToDecimal(mangChuSo[0]);
            //phanThapPhan = Convert.ToDecimal(mangChuSo[1]) / Convert.ToDecimal(Math.Pow(10, mangChuSo[1].ToString().Length));

            //MessageBox.Show((phanNguyen + phanThapPhan).ToString());

            //MessageBox.Show(chuoiGiaTri);
            string chuoiGiaTri = textEdit1.Text.Replace("TT", "").Trim();
            //chuoiGiaTri = chuoiGiaTri.Replace(".", ",");
            chuoiGiaTri = chuoiGiaTri.Replace(" ", "");
            decimal giaTri = 0;
            if (!decimal.TryParse(chuoiGiaTri, out giaTri))
            {
                MessageBox.Show("Giá trị cân không hợp lệ. " + textEdit1.Text + " ... " + chuoiGiaTri);
            }

            MessageBox.Show((giaTri * 10).ToString());
            //return (giaTri * 10);
            
        }
    }
}
