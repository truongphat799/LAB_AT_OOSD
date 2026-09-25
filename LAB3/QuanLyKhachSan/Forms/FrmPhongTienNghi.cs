using System;
using System.Windows.Forms;
using QuanLyKhachSan.Services;
namespace
QuanLyKhachSan.Forms
{
    public partial class FrmPhongTienNghi : Form
    {
        readonly
PhongTienNghiService s = new PhongTienNghiService();
        private Button button3;
        private Label label8;
        private Button button2;
        private Label label7;
        private Button button1;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label1;
        private Button button4;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button button5;
        private Label label4;
        private Button button6;
        private Label label9;
        private Button button7;
        private Label label10;
        private Button button8;
        private Label label11;
        private Button button9;
        readonly DanhMucService dm = new
DanhMucService(); public FrmPhongTienNghi() { InitializeComponent(); }
        private void
Frm_Load(object a, EventArgs
e)
        {
            cboKhu.DataSource = dm.LayKhuVuc(); cboKhu.DisplayMember = "TenKhuVuc"; cboKhu.Val
ueMember = "MaKhuVuc"; cboLoai.DataSource = dm.LayLoaiTienNghi(); cboLoai.DisplayMemb
er = "TenLoaiTN"; cboLoai.ValueMember = "MaLoaiTN"; cboTN.DataSource = s.LayTienNghi(); cb
oTN.DisplayMember = "MaTienNghi"; cboTN.ValueMember = "MaTienNghi"; cboPhong.DataSou
rce = s.LayPhong(); cboPhong.DisplayMember = "SoPhong"; cboPhong.ValueMember = "SoPhong"
; cboNV.DataSource = dm.LayNhanVien(); cboNV.DisplayMember = "HoTen"; cboNV.ValueMem
ber = "MaNV"; Tai();
        }
        void
Tai()
        {
            dgvPhong.DataSource = s.LayPhong(); dgvTN.DataSource = s.LayTienNghi(); dgvLD.DataS
ource = s.LayLapDat();
        }
        void H(KetQuaXuLy
k)
        { MessageBox.Show(k.ThongBao); if (k.ThanhCong) Tai(); }
        private void
btnThemPhong_Click(object a, EventArgs
e)
        { H(s.ThemPhong(txtPhong.Text.Trim(), V(cboKhu), (int)numMax.Value, numGia.Value)); }
        private void btnThemTN_Click(object a, EventArgs
        e)
        {
            H(s.ThemTienNghi(txtMaTN.Text.Trim(), V(cboLoai), (int)numSTT.Value, txtTinhTrang.Tex
        t.Trim()));
        }
        private void btnLapDat_Click(object a, EventArgs
        e)
        {
            H(s.LapDat(txtSoLD.Text.Trim(), V(cboTN), V(cboPhong), dtNgay.Value, txtTTLD.Text.Tri
        m(), V(cboNV), txtGhiChu.Text.Trim()));
        }
        string V(ComboBox c)
        {
            return
        c.SelectedValue == null ? "" : c.SelectedValue.ToString();
        }
        private void btnDong_Click(object
        a, EventArgs e)
        { Close(); }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(543, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 26);
            this.button3.TabIndex = 22;
            this.button3.Text = "2";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(441, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Số người tối đa :";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(289, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 26);
            this.button2.TabIndex = 20;
            this.button2.Text = "Khu A";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Khu vực :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 26);
            this.button1.TabIndex = 18;
            this.button1.Text = "A101";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Số phòng :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "[ Lắp đặt / luân chuyển ]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "[ Tiện nghi ]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "[ Phòng ]";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(771, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 26);
            this.button4.TabIndex = 24;
            this.button4.Text = "600000";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(672, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Đơn giá/ngày :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(20, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(873, 310);
            this.dataGridView1.TabIndex = 25;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Phòng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Khu";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Sức chứa";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Đơn giá";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Trạng thái";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(729, 415);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 26);
            this.button5.TabIndex = 33;
            this.button5.Text = "Tốt";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(639, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Tình trạng :";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(520, 415);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 26);
            this.button6.TabIndex = 31;
            this.button6.Text = "A101";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(462, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Phòng :";
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button7.Location = new System.Drawing.Point(323, 415);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(124, 26);
            this.button7.TabIndex = 29;
            this.button7.Text = "TV01";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(258, 420);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "Tiện nghi :";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(120, 415);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(126, 26);
            this.button8.TabIndex = 27;
            this.button8.Text = "LD001";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 420);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Phiếu lắp đặt :";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(729, 447);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(112, 24);
            this.button9.TabIndex = 34;
            this.button9.Text = "Lập phiếu";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // FrmPhongTienNghi
            // 
            this.ClientSize = new System.Drawing.Size(912, 493);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPhongTienNghi";
            this.Load += new System.EventHandler(this.FrmPhongTienNghi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void FrmPhongTienNghi_Load(object sender, EventArgs e)
        {

        }
    }
}