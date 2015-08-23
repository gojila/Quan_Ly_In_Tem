namespace Phan_Mem_Quan_Ly_In_Tem
{
    partial class frmThongTin
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTin));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenTiem = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtCongCOM = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.txtDuongDanDuLieu = new DevExpress.XtraEditors.ButtonEdit();
            this.txtTenMayIn = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.img = new DevExpress.Utils.ImageCollection();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCongCOM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuongDanDuLieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMayIn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên Tiệm:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(8, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Địa Chỉ:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(8, 95);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Cổng COM:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(8, 167);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(134, 13);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Đường Dẫn Dữ Liệu (Excel):";
            // 
            // txtTenTiem
            // 
            this.txtTenTiem.Location = new System.Drawing.Point(148, 12);
            this.txtTenTiem.Name = "txtTenTiem";
            this.txtTenTiem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtTenTiem.Properties.Appearance.Options.UseFont = true;
            this.txtTenTiem.Size = new System.Drawing.Size(464, 30);
            this.txtTenTiem.TabIndex = 4;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(148, 48);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txtDiaChi.Size = new System.Drawing.Size(464, 30);
            this.txtDiaChi.TabIndex = 5;
            // 
            // txtCongCOM
            // 
            this.txtCongCOM.Location = new System.Drawing.Point(148, 84);
            this.txtCongCOM.Name = "txtCongCOM";
            this.txtCongCOM.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtCongCOM.Properties.Appearance.Options.UseFont = true;
            this.txtCongCOM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCongCOM.Size = new System.Drawing.Size(464, 30);
            this.txtCongCOM.TabIndex = 7;
            // 
            // btnLuu
            // 
            this.btnLuu.ImageIndex = 40;
            this.btnLuu.ImageList = this.img;
            this.btnLuu.Location = new System.Drawing.Point(244, 192);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.ImageIndex = 16;
            this.btnDong.ImageList = this.img;
            this.btnDong.Location = new System.Drawing.Point(326, 192);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 9;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // txtDuongDanDuLieu
            // 
            this.txtDuongDanDuLieu.Location = new System.Drawing.Point(148, 156);
            this.txtDuongDanDuLieu.Name = "txtDuongDanDuLieu";
            this.txtDuongDanDuLieu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtDuongDanDuLieu.Properties.Appearance.Options.UseFont = true;
            this.txtDuongDanDuLieu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", "Chon", null, true)});
            this.txtDuongDanDuLieu.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtDuongDanDuLieu_Properties_ButtonClick);
            this.txtDuongDanDuLieu.Size = new System.Drawing.Size(464, 30);
            this.txtDuongDanDuLieu.TabIndex = 10;
            // 
            // txtTenMayIn
            // 
            this.txtTenMayIn.Location = new System.Drawing.Point(148, 120);
            this.txtTenMayIn.Name = "txtTenMayIn";
            this.txtTenMayIn.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtTenMayIn.Properties.Appearance.Options.UseFont = true;
            this.txtTenMayIn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTenMayIn.Size = new System.Drawing.Size(464, 30);
            this.txtTenMayIn.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(8, 131);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Máy In:";
            // 
            // img
            // 
            this.img.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("img.ImageStream")));
            this.img.Images.SetKeyName(0, "abort.png");
            this.img.Images.SetKeyName(1, "about.png");
            this.img.Images.SetKeyName(2, "accept.png");
            this.img.Images.SetKeyName(3, "add.png");
            this.img.Images.SetKeyName(4, "application.png");
            this.img.Images.SetKeyName(5, "apply.png");
            this.img.Images.SetKeyName(6, "attention.png");
            this.img.Images.SetKeyName(7, "back.png");
            this.img.Images.SetKeyName(8, "cancel.png");
            this.img.Images.SetKeyName(9, "circulation.png");
            this.img.Images.SetKeyName(10, "close.png");
            this.img.Images.SetKeyName(11, "create.png");
            this.img.Images.SetKeyName(12, "cut.png");
            this.img.Images.SetKeyName(13, "danger.png");
            this.img.Images.SetKeyName(14, "delete.png");
            this.img.Images.SetKeyName(15, "down.png");
            this.img.Images.SetKeyName(16, "erase.png");
            this.img.Images.SetKeyName(17, "error.png");
            this.img.Images.SetKeyName(18, "forward.png");
            this.img.Images.SetKeyName(19, "help.png");
            this.img.Images.SetKeyName(20, "info.png");
            this.img.Images.SetKeyName(21, "information.png");
            this.img.Images.SetKeyName(22, "logout.png");
            this.img.Images.SetKeyName(23, "minus.png");
            this.img.Images.SetKeyName(24, "move.png");
            this.img.Images.SetKeyName(25, "next.png");
            this.img.Images.SetKeyName(26, "no entry.png");
            this.img.Images.SetKeyName(27, "no.png");
            this.img.Images.SetKeyName(28, "OK.png");
            this.img.Images.SetKeyName(29, "options.png");
            this.img.Images.SetKeyName(30, "plus.png");
            this.img.Images.SetKeyName(31, "previous.png");
            this.img.Images.SetKeyName(32, "problem.png");
            this.img.Images.SetKeyName(33, "question.png");
            this.img.Images.SetKeyName(34, "redo.png");
            this.img.Images.SetKeyName(35, "refresh.png");
            this.img.Images.SetKeyName(36, "remove.png");
            this.img.Images.SetKeyName(37, "renew.png");
            this.img.Images.SetKeyName(38, "repeat.png");
            this.img.Images.SetKeyName(39, "run.png");
            this.img.Images.SetKeyName(40, "save.png");
            this.img.Images.SetKeyName(41, "search.png");
            this.img.Images.SetKeyName(42, "settings.png");
            this.img.Images.SetKeyName(43, "stop.png");
            this.img.Images.SetKeyName(44, "switch.png");
            this.img.Images.SetKeyName(45, "sync.png");
            this.img.Images.SetKeyName(46, "system.png");
            this.img.Images.SetKeyName(47, "turn off.png");
            this.img.Images.SetKeyName(48, "undo.png");
            this.img.Images.SetKeyName(49, "up.png");
            this.img.Images.SetKeyName(50, "update.png");
            this.img.Images.SetKeyName(51, "view.png");
            this.img.Images.SetKeyName(52, "warning.png");
            this.img.Images.SetKeyName(53, "yes.png");
            this.img.Images.SetKeyName(54, "Excel-icon.png");
            this.img.Images.SetKeyName(55, "20-512.png");
            this.img.Images.SetKeyName(56, "Address_Book.png");
            this.img.Images.SetKeyName(57, "default_logo.png");
            this.img.Images.SetKeyName(58, "Dust_factory_gas_industry_oil_plant_pollution_building_company_production_smoke-5" +
        "12.png");
            this.img.Images.SetKeyName(59, "icon_company.png");
            this.img.Images.SetKeyName(60, "icon-companies.png");
            this.img.Images.SetKeyName(61, "icon-company-incorporation.png");
            this.img.Images.SetKeyName(62, "Icon-Printer.png");
            this.img.Images.SetKeyName(63, "Icon-Printer02-Black.png");
            this.img.Images.SetKeyName(64, "location-icon-map-map-pin-icon.png");
            this.img.Images.SetKeyName(65, "map.png");
            this.img.Images.SetKeyName(66, "Multimedia_communication_flat_mobile_Technology-08-31-512.png");
            this.img.Images.SetKeyName(67, "point-512.png");
            this.img.Images.SetKeyName(68, "printer (1).png");
            this.img.Images.SetKeyName(69, "printer.png");
            this.img.Images.SetKeyName(70, "printer-icon-clip-art.jpg");
            this.img.Images.SetKeyName(71, "usb_port_2-512.png");
            this.img.Images.SetKeyName(72, "vector-printer-icon-14574274.jpg");
            this.img.Images.SetKeyName(73, "vspc-icon-256.png");
            // 
            // frmThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 224);
            this.Controls.Add(this.txtDuongDanDuLieu);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTenMayIn);
            this.Controls.Add(this.txtCongCOM);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenTiem);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThongTin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin";
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCongCOM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuongDanDuLieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMayIn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtTenTiem;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.ComboBoxEdit txtCongCOM;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.ButtonEdit txtDuongDanDuLieu;
        private DevExpress.XtraEditors.ComboBoxEdit txtTenMayIn;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.Utils.ImageCollection img;
    }
}