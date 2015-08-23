namespace Phan_Mem_Quan_Ly_In_Tem
{
    partial class frmKetNoiCanTuDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKetNoiCanTuDong));
            this.cbCongCOM = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnKetNoi = new DevExpress.XtraEditors.SimpleButton();
            this.img = new DevExpress.Utils.ImageCollection(this.components);
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.Com = new System.IO.Ports.SerialPort(this.components);
            this.txtCanNang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cbCongCOM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCongCOM
            // 
            this.cbCongCOM.Location = new System.Drawing.Point(43, 9);
            this.cbCongCOM.Name = "cbCongCOM";
            this.cbCongCOM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCongCOM.Size = new System.Drawing.Size(262, 20);
            this.cbCongCOM.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Com:";
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.ImageIndex = 2;
            this.btnKetNoi.ImageList = this.img;
            this.btnKetNoi.Location = new System.Drawing.Point(80, 35);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(75, 23);
            this.btnKetNoi.TabIndex = 2;
            this.btnKetNoi.Text = "Kết Nối";
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
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
            this.img.Images.SetKeyName(74, "connect_creating.png");
            this.img.Images.SetKeyName(75, "connect_no.png");
            // 
            // btnDong
            // 
            this.btnDong.ImageIndex = 16;
            this.btnDong.ImageList = this.img;
            this.btnDong.Location = new System.Drawing.Point(161, 35);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // Com
            // 
            this.Com.BaudRate = 1200;
            this.Com.WriteBufferSize = 4096;
            // 
            // txtCanNang
            // 
            this.txtCanNang.Location = new System.Drawing.Point(73, 64);
            this.txtCanNang.Name = "txtCanNang";
            this.txtCanNang.Size = new System.Drawing.Size(232, 20);
            this.txtCanNang.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cân Nặng:";
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(73, 90);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(232, 20);
            this.txtCommand.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Command:";
            // 
            // frmKetNoiCanTuDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 120);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCanNang);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnKetNoi);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cbCongCOM);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmKetNoiCanTuDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết Nối Cân";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKetNoiCan_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.cbCongCOM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cbCongCOM;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnKetNoi;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private System.IO.Ports.SerialPort Com;
        private DevExpress.Utils.ImageCollection img;
        private System.Windows.Forms.TextBox txtCanNang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Label label2;
    }
}

