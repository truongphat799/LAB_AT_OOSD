using System;
using System.Windows.Forms;
namespace QuanLyKhachSan.Forms
{
    public
partial class QuanLyKhachSan : Form
    {
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
        private Button button7;

        public QuanLyKhachSan() { InitializeComponent(); }
        private void
btnDanhMuc_Click(object s, EventArgs e)
        {
            using (var f = new
FrmDanhMuc()) f.ShowDialog(this);
        }
        private void btnPhong_Click(object s, EventArgs
e)
        { using (var f = new FrmPhongTienNghi()) f.ShowDialog(this); }
        private void
btnDatPhong_Click(object s, EventArgs e)
        {
            using (var f = new
FrmDatPhong()) f.ShowDialog(this);
        }
        private void btnDichVu_Click(object s, EventArgs
e)
        { using (var f = new FrmDichVu()) f.ShowDialog(this); }
        private void
btnTraPhong_Click(object s, EventArgs e)
        {
            using (var f = new
FrmTraPhong()) f.ShowDialog(this);
        }
        private void btnThongKe_Click(object s, EventArgs
e)
        { using (var f = new FrmThongKe()) f.ShowDialog(this); }
        private void btnThoat_Click(object
s, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát?", "Xác
nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)Close();}
}

        private void InitializeComponent()
        {
            System.Windows.Forms.Button button3;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(57, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 86);
            this.button1.TabIndex = 0;
            this.button1.Text = "Danh mục";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            button3.Location = new System.Drawing.Point(57, 197);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(192, 86);
            button3.TabIndex = 2;
            button3.Text = "Sử dụng dịch vụ";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(330, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 86);
            this.button2.TabIndex = 3;
            this.button2.Text = "Trả phòng - Thanh toán";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(330, 81);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 86);
            this.button4.TabIndex = 4;
            this.button4.Text = "Phòng - Tiện nghi";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(604, 197);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(192, 86);
            this.button5.TabIndex = 5;
            this.button5.Text = "Thống kê";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(604, 81);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(192, 86);
            this.button6.TabIndex = 6;
            this.button6.Text = "Đặt / Nhận phòng";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(330, 314);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(192, 86);
            this.button7.TabIndex = 7;
            this.button7.Text = "Thoát";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(146, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ KHÁCH SẠN";
            // 
            // QuanLyKhachSan
            // 
            this.ClientSize = new System.Drawing.Size(870, 433);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(button3);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "QuanLyKhachSan";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }