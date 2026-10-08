namespace bai2810
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var img = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                    picError.Image = img;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string ticketId = txtTicketId.Text.Trim();
            string requester = txtRequester.Text.Trim();
            string date = dtpDate.Value.ToString("yyyy-MM-dd");
            string priority = rbLow.Checked ? "Thấp" : (rbMedium.Checked ? "Trung bình" : "Khẩn cấp");
            string type = cbType.SelectedItem != null ? cbType.SelectedItem.ToString() : string.Empty;

            var devices = new System.Collections.Generic.List<string>();
            if (chkDesktop.Checked) devices.Add("Máy tính bàn");
            if (chkLaptop.Checked) devices.Add("Laptop");
            if (chkPrinter.Checked) devices.Add("Máy in");
            if (chkPhone.Checked) devices.Add("Điện thoại");

            string devicesText = devices.Count > 0 ? string.Join(", ", devices) : "(không chọn)";
            string imgLoaded = picError.Image != null ? "Có" : "Không";

            string summary =
                $"Mã phiếu: {ticketId}\n" +
                $"Người yêu cầu: {requester}\n" +
                $"Ngày ghi nhận: {date}\n" +
                $"Mức độ ưu tiên: {priority}\n" +
                $"Loại sự cố: {type}\n" +
                $"Thiết bị ảnh hưởng: {devicesText}\n" +
                $"Ảnh lỗi đính kèm: {imgLoaded}";

            MessageBox.Show(summary, "Tóm tắt yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTicketId.Text = string.Empty;
            txtRequester.Text = string.Empty;
            dtpDate.Value = DateTime.Now;
            rbLow.Checked = true;
            cbType.SelectedIndex = 0;
            chkDesktop.Checked = false;
            chkLaptop.Checked = false;
            chkPrinter.Checked = false;
            chkPhone.Checked = false;
            if (picError.Image != null)
            {
                picError.Image.Dispose();
                picError.Image = null;
            }
            openFileDialog1.FileName = string.Empty;
        }
    }
}
