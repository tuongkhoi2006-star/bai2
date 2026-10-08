namespace bai2810
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTicketId;
        private System.Windows.Forms.TextBox txtTicketId;
        private System.Windows.Forms.Label lblRequester;
        private System.Windows.Forms.TextBox txtRequester;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.GroupBox grpPriority;
        private System.Windows.Forms.RadioButton rbLow;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbHigh;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.GroupBox grpDevices;
        private System.Windows.Forms.CheckBox chkPhone;
        private System.Windows.Forms.CheckBox chkPrinter;
        private System.Windows.Forms.CheckBox chkLaptop;
        private System.Windows.Forms.CheckBox chkDesktop;
        private System.Windows.Forms.PictureBox picError;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

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
            components = new System.ComponentModel.Container();
            this.lblTicketId = new System.Windows.Forms.Label();
            this.txtTicketId = new System.Windows.Forms.TextBox();
            this.lblRequester = new System.Windows.Forms.Label();
            this.txtRequester = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.grpPriority = new System.Windows.Forms.GroupBox();
            this.rbLow = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbHigh = new System.Windows.Forms.RadioButton();
            this.lblType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.grpDevices = new System.Windows.Forms.GroupBox();
            this.chkPhone = new System.Windows.Forms.CheckBox();
            this.chkPrinter = new System.Windows.Forms.CheckBox();
            this.chkLaptop = new System.Windows.Forms.CheckBox();
            this.chkDesktop = new System.Windows.Forms.CheckBox();
            this.picError = new System.Windows.Forms.PictureBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            // 
            // Form settings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Tiếp nhận & Phân loại sự cố IT";

            // lblTicketId
            this.lblTicketId.AutoSize = true;
            this.lblTicketId.Location = new System.Drawing.Point(20, 20);
            this.lblTicketId.Name = "lblTicketId";
            this.lblTicketId.Size = new System.Drawing.Size(60, 15);
            this.lblTicketId.Text = "Mã phiếu";
            // txtTicketId
            this.txtTicketId.Location = new System.Drawing.Point(130, 17);
            this.txtTicketId.Name = "txtTicketId";
            this.txtTicketId.Size = new System.Drawing.Size(200, 23);

            // lblRequester
            this.lblRequester.AutoSize = true;
            this.lblRequester.Location = new System.Drawing.Point(20, 55);
            this.lblRequester.Name = "lblRequester";
            this.lblRequester.Size = new System.Drawing.Size(86, 15);
            this.lblRequester.Text = "Người yêu cầu";
            // txtRequester
            this.txtRequester.Location = new System.Drawing.Point(130, 52);
            this.txtRequester.Name = "txtRequester";
            this.txtRequester.Size = new System.Drawing.Size(200, 23);

            // lblDate
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(20, 90);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(93, 15);
            this.lblDate.Text = "Ngày ghi nhận";
            // dtpDate
            this.dtpDate.Location = new System.Drawing.Point(130, 86);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 23);

            // grpPriority
            this.grpPriority.Location = new System.Drawing.Point(20, 125);
            this.grpPriority.Name = "grpPriority";
            this.grpPriority.Size = new System.Drawing.Size(310, 60);
            this.grpPriority.Text = "Mức độ ưu tiên";
            this.grpPriority.Controls.Add(this.rbLow);
            this.grpPriority.Controls.Add(this.rbMedium);
            this.grpPriority.Controls.Add(this.rbHigh);

            // rbLow
            this.rbLow.AutoSize = true;
            this.rbLow.Location = new System.Drawing.Point(10, 25);
            this.rbLow.Name = "rbLow";
            this.rbLow.Size = new System.Drawing.Size(45, 19);
            this.rbLow.Text = "Thấp";
            this.rbLow.Checked = true;
            // rbMedium
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(110, 25);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(80, 19);
            this.rbMedium.Text = "Trung bình";
            // rbHigh
            this.rbHigh.AutoSize = true;
            this.rbHigh.Location = new System.Drawing.Point(220, 25);
            this.rbHigh.Name = "rbHigh";
            this.rbHigh.Size = new System.Drawing.Size(63, 19);
            this.rbHigh.Text = "Khẩn cấp";

            // lblType
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(20, 200);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(84, 15);
            this.lblType.Text = "Loại sự cố";
            // cbType
            this.cbType.Location = new System.Drawing.Point(130, 197);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(200, 23);
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Items.AddRange(new object[] { "Phần cứng", "Phần mềm", "Mạng", "Tài khoản" });
            this.cbType.SelectedIndex = 0;

            // grpDevices
            this.grpDevices.Location = new System.Drawing.Point(20, 235);
            this.grpDevices.Name = "grpDevices";
            this.grpDevices.Size = new System.Drawing.Size(310, 90);
            this.grpDevices.Text = "Thiết bị ảnh hưởng";
            this.grpDevices.Controls.Add(this.chkDesktop);
            this.grpDevices.Controls.Add(this.chkLaptop);
            this.grpDevices.Controls.Add(this.chkPrinter);
            this.grpDevices.Controls.Add(this.chkPhone);

            // chkDesktop
            this.chkDesktop.AutoSize = true;
            this.chkDesktop.Location = new System.Drawing.Point(10, 22);
            this.chkDesktop.Name = "chkDesktop";
            this.chkDesktop.Size = new System.Drawing.Size(92, 19);
            this.chkDesktop.Text = "Máy tính bàn";
            // chkLaptop
            this.chkLaptop.AutoSize = true;
            this.chkLaptop.Location = new System.Drawing.Point(150, 22);
            this.chkLaptop.Name = "chkLaptop";
            this.chkLaptop.Size = new System.Drawing.Size(61, 19);
            this.chkLaptop.Text = "Laptop";
            // chkPrinter
            this.chkPrinter.AutoSize = true;
            this.chkPrinter.Location = new System.Drawing.Point(10, 52);
            this.chkPrinter.Name = "chkPrinter";
            this.chkPrinter.Size = new System.Drawing.Size(60, 19);
            this.chkPrinter.Text = "Máy in";
            // chkPhone
            this.chkPhone.AutoSize = true;
            this.chkPhone.Location = new System.Drawing.Point(150, 52);
            this.chkPhone.Name = "chkPhone";
            this.chkPhone.Size = new System.Drawing.Size(78, 19);
            this.chkPhone.Text = "Điện thoại";

            // picError
            this.picError.Location = new System.Drawing.Point(360, 20);
            this.picError.Name = "picError";
            this.picError.Size = new System.Drawing.Size(400, 300);
            this.picError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            // btnLoadImage
            this.btnLoadImage.Location = new System.Drawing.Point(360, 330);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(120, 30);
            this.btnLoadImage.Text = "Tải ảnh lỗi";
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);

            // btnSend
            this.btnSend.Location = new System.Drawing.Point(600, 360);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(120, 40);
            this.btnSend.Text = "Gửi yêu cầu";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);

            // btnReset
            this.btnReset.Location = new System.Drawing.Point(360, 370);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 30);
            this.btnReset.Text = "Nhập lại";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            // openFileDialog1
            this.openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            // Add controls to form
            this.Controls.Add(this.lblTicketId);
            this.Controls.Add(this.txtTicketId);
            this.Controls.Add(this.lblRequester);
            this.Controls.Add(this.txtRequester);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.grpPriority);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.grpDevices);
            this.Controls.Add(this.picError);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnReset);
        }

        #endregion
    }
}
