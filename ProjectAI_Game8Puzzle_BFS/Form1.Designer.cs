
namespace ProjectAI_Game8Puzzle_BFS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblBuocDuyet = new System.Windows.Forms.Label();
            this.tmrThoiGianDem = new System.Windows.Forms.Timer(this.components);
            this.lblTimeGiai = new System.Windows.Forms.Label();
            this.lblThoiGianDem = new System.Windows.Forms.Label();
            this.lblBuocDi = new System.Windows.Forms.Label();
            this.gbKhung = new System.Windows.Forms.GroupBox();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.pbx5 = new System.Windows.Forms.PictureBox();
            this.pbx6 = new System.Windows.Forms.PictureBox();
            this.pbx7 = new System.Windows.Forms.PictureBox();
            this.pbx8 = new System.Windows.Forms.PictureBox();
            this.pbx9 = new System.Windows.Forms.PictureBox();
            this.gbAnhGoc = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnPrev = new ePOSOne.btnProduct.Button_WOC();
            this.btnNext = new ePOSOne.btnProduct.Button_WOC();
            this.btnTamDung = new ePOSOne.btnProduct.Button_WOC();
            this.btnChoiLai = new ePOSOne.btnProduct.Button_WOC();
            this.btnGiaiBFS = new ePOSOne.btnProduct.Button_WOC();
            this.btnGiaiToiUu = new ePOSOne.btnProduct.Button_WOC();
            this.btnThoat = new ePOSOne.btnProduct.Button_WOC();
            this.btnUpload = new ePOSOne.btnProduct.Button_WOC();
            this.gbKhung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuocDuyet
            // 
            this.lblBuocDuyet.AutoSize = true;
            this.lblBuocDuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuocDuyet.Location = new System.Drawing.Point(785, 516);
            this.lblBuocDuyet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuocDuyet.Name = "lblBuocDuyet";
            this.lblBuocDuyet.Size = new System.Drawing.Size(286, 25);
            this.lblBuocDuyet.TabIndex = 22;
            this.lblBuocDuyet.Text = "Number of browsing steps: 0";
            // 
            // tmrThoiGianDem
            // 
            this.tmrThoiGianDem.Enabled = true;
            this.tmrThoiGianDem.Interval = 900;
            this.tmrThoiGianDem.Tick += new System.EventHandler(this.TinhThoiGian);
            // 
            // lblTimeGiai
            // 
            this.lblTimeGiai.AutoSize = true;
            this.lblTimeGiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeGiai.Location = new System.Drawing.Point(815, 478);
            this.lblTimeGiai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeGiai.Name = "lblTimeGiai";
            this.lblTimeGiai.Size = new System.Drawing.Size(220, 25);
            this.lblTimeGiai.TabIndex = 21;
            this.lblTimeGiai.Text = "Solution time : 0.0 ms";
            // 
            // lblThoiGianDem
            // 
            this.lblThoiGianDem.AutoSize = true;
            this.lblThoiGianDem.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGianDem.Location = new System.Drawing.Point(184, -1);
            this.lblThoiGianDem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThoiGianDem.Name = "lblThoiGianDem";
            this.lblThoiGianDem.Size = new System.Drawing.Size(248, 75);
            this.lblThoiGianDem.TabIndex = 16;
            this.lblThoiGianDem.Text = "00:00:00";
            this.lblThoiGianDem.Click += new System.EventHandler(this.lblThoiGianDem_Click);
            // 
            // lblBuocDi
            // 
            this.lblBuocDi.AutoSize = true;
            this.lblBuocDi.BackColor = System.Drawing.SystemColors.Info;
            this.lblBuocDi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuocDi.ForeColor = System.Drawing.Color.Black;
            this.lblBuocDi.Location = new System.Drawing.Point(28, 602);
            this.lblBuocDi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuocDi.Name = "lblBuocDi";
            this.lblBuocDi.Size = new System.Drawing.Size(180, 24);
            this.lblBuocDi.TabIndex = 15;
            this.lblBuocDi.Text = "Number of steps: ";
            // 
            // gbKhung
            // 
            this.gbKhung.Controls.Add(this.pbx1);
            this.gbKhung.Controls.Add(this.pbx2);
            this.gbKhung.Controls.Add(this.pbx3);
            this.gbKhung.Controls.Add(this.pbx4);
            this.gbKhung.Controls.Add(this.pbx5);
            this.gbKhung.Controls.Add(this.pbx6);
            this.gbKhung.Controls.Add(this.pbx7);
            this.gbKhung.Controls.Add(this.pbx8);
            this.gbKhung.Controls.Add(this.pbx9);
            this.gbKhung.Location = new System.Drawing.Point(32, 50);
            this.gbKhung.Margin = new System.Windows.Forms.Padding(4);
            this.gbKhung.Name = "gbKhung";
            this.gbKhung.Padding = new System.Windows.Forms.Padding(4);
            this.gbKhung.Size = new System.Drawing.Size(569, 533);
            this.gbKhung.TabIndex = 11;
            this.gbKhung.TabStop = false;
            this.gbKhung.Text = "8 Puzzle";
            // 
            // pbx1
            // 
            this.pbx1.Image = ((System.Drawing.Image)(resources.GetObject("pbx1.Image")));
            this.pbx1.Location = new System.Drawing.Point(23, 28);
            this.pbx1.Margin = new System.Windows.Forms.Padding(4);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(173, 160);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx1.TabIndex = 0;
            this.pbx1.TabStop = false;
            this.pbx1.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx2
            // 
            this.pbx2.Image = ((System.Drawing.Image)(resources.GetObject("pbx2.Image")));
            this.pbx2.Location = new System.Drawing.Point(199, 28);
            this.pbx2.Margin = new System.Windows.Forms.Padding(4);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(173, 160);
            this.pbx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx2.TabIndex = 0;
            this.pbx2.TabStop = false;
            this.pbx2.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx3
            // 
            this.pbx3.Image = ((System.Drawing.Image)(resources.GetObject("pbx3.Image")));
            this.pbx3.Location = new System.Drawing.Point(375, 28);
            this.pbx3.Margin = new System.Windows.Forms.Padding(4);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(173, 160);
            this.pbx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx3.TabIndex = 0;
            this.pbx3.TabStop = false;
            this.pbx3.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx4
            // 
            this.pbx4.Image = ((System.Drawing.Image)(resources.GetObject("pbx4.Image")));
            this.pbx4.Location = new System.Drawing.Point(23, 191);
            this.pbx4.Margin = new System.Windows.Forms.Padding(4);
            this.pbx4.Name = "pbx4";
            this.pbx4.Size = new System.Drawing.Size(173, 160);
            this.pbx4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx4.TabIndex = 0;
            this.pbx4.TabStop = false;
            this.pbx4.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx5
            // 
            this.pbx5.Image = ((System.Drawing.Image)(resources.GetObject("pbx5.Image")));
            this.pbx5.Location = new System.Drawing.Point(199, 191);
            this.pbx5.Margin = new System.Windows.Forms.Padding(4);
            this.pbx5.Name = "pbx5";
            this.pbx5.Size = new System.Drawing.Size(173, 160);
            this.pbx5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx5.TabIndex = 0;
            this.pbx5.TabStop = false;
            this.pbx5.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx6
            // 
            this.pbx6.Image = ((System.Drawing.Image)(resources.GetObject("pbx6.Image")));
            this.pbx6.Location = new System.Drawing.Point(375, 191);
            this.pbx6.Margin = new System.Windows.Forms.Padding(4);
            this.pbx6.Name = "pbx6";
            this.pbx6.Size = new System.Drawing.Size(173, 160);
            this.pbx6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx6.TabIndex = 0;
            this.pbx6.TabStop = false;
            this.pbx6.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx7
            // 
            this.pbx7.Image = ((System.Drawing.Image)(resources.GetObject("pbx7.Image")));
            this.pbx7.Location = new System.Drawing.Point(23, 353);
            this.pbx7.Margin = new System.Windows.Forms.Padding(4);
            this.pbx7.Name = "pbx7";
            this.pbx7.Size = new System.Drawing.Size(173, 160);
            this.pbx7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx7.TabIndex = 0;
            this.pbx7.TabStop = false;
            this.pbx7.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx8
            // 
            this.pbx8.Image = ((System.Drawing.Image)(resources.GetObject("pbx8.Image")));
            this.pbx8.Location = new System.Drawing.Point(199, 353);
            this.pbx8.Margin = new System.Windows.Forms.Padding(4);
            this.pbx8.Name = "pbx8";
            this.pbx8.Size = new System.Drawing.Size(173, 160);
            this.pbx8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx8.TabIndex = 0;
            this.pbx8.TabStop = false;
            this.pbx8.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx9
            // 
            this.pbx9.Image = global::ProjectAI_Game8Puzzle_BFS.Properties.Resources._null;
            this.pbx9.Location = new System.Drawing.Point(375, 353);
            this.pbx9.Margin = new System.Windows.Forms.Padding(4);
            this.pbx9.Name = "pbx9";
            this.pbx9.Size = new System.Drawing.Size(173, 160);
            this.pbx9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx9.TabIndex = 0;
            this.pbx9.TabStop = false;
            this.pbx9.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // gbAnhGoc
            // 
            this.gbAnhGoc.BackgroundImage = global::ProjectAI_Game8Puzzle_BFS.Properties.Resources.hqdefault;
            this.gbAnhGoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbAnhGoc.Location = new System.Drawing.Point(720, 78);
            this.gbAnhGoc.Margin = new System.Windows.Forms.Padding(4);
            this.gbAnhGoc.Name = "gbAnhGoc";
            this.gbAnhGoc.Padding = new System.Windows.Forms.Padding(4);
            this.gbAnhGoc.Size = new System.Drawing.Size(455, 369);
            this.gbAnhGoc.TabIndex = 10;
            this.gbAnhGoc.TabStop = false;
            this.gbAnhGoc.Text = "Hình Gốc";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(916, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 15);
            this.textBox1.TabIndex = 33;
            this.textBox1.Text = "Dan Bảo Nguyên 19110036";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Cornsilk;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(1108, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 15);
            this.textBox2.TabIndex = 34;
            this.textBox2.Text = "Phùng Khánh Tâm 16110570";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Cornsilk;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(700, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(198, 15);
            this.textBox3.TabIndex = 35;
            this.textBox3.Text = "Nhóm 10";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Cornsilk;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(638, 478);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(56, 23);
            this.textBox4.TabIndex = 36;
            this.textBox4.Text = "Case";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(606, 507);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 37;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnPrev
            // 
            this.btnPrev.BorderColor = System.Drawing.Color.Olive;
            this.btnPrev.ButtonColor = System.Drawing.Color.White;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrev.Location = new System.Drawing.Point(292, 590);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.OnHoverBorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnPrev.OnHoverButtonColor = System.Drawing.Color.DarkOliveGreen;
            this.btnPrev.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrev.Size = new System.Drawing.Size(112, 48);
            this.btnPrev.TabIndex = 32;
            this.btnPrev.Text = "Prev";
            this.btnPrev.TextColor = System.Drawing.Color.Black;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnDiLui_Click);
            // 
            // btnNext
            // 
            this.btnNext.BorderColor = System.Drawing.Color.Olive;
            this.btnNext.ButtonColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNext.Location = new System.Drawing.Point(427, 590);
            this.btnNext.Name = "btnNext";
            this.btnNext.OnHoverBorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnNext.OnHoverButtonColor = System.Drawing.Color.DarkOliveGreen;
            this.btnNext.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNext.Size = new System.Drawing.Size(112, 48);
            this.btnNext.TabIndex = 31;
            this.btnNext.Text = "Next";
            this.btnNext.TextColor = System.Drawing.Color.Black;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnDiToi_Click);
            // 
            // btnTamDung
            // 
            this.btnTamDung.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnTamDung.ButtonColor = System.Drawing.Color.White;
            this.btnTamDung.FlatAppearance.BorderSize = 0;
            this.btnTamDung.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnTamDung.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnTamDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTamDung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTamDung.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTamDung.Location = new System.Drawing.Point(768, 584);
            this.btnTamDung.Name = "btnTamDung";
            this.btnTamDung.OnHoverBorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnTamDung.OnHoverButtonColor = System.Drawing.Color.DarkOliveGreen;
            this.btnTamDung.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTamDung.Size = new System.Drawing.Size(112, 48);
            this.btnTamDung.TabIndex = 30;
            this.btnTamDung.Text = "Pause";
            this.btnTamDung.TextColor = System.Drawing.Color.Black;
            this.btnTamDung.UseVisualStyleBackColor = true;
            this.btnTamDung.Click += new System.EventHandler(this.PauseOrResume);
            // 
            // btnChoiLai
            // 
            this.btnChoiLai.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnChoiLai.ButtonColor = System.Drawing.Color.White;
            this.btnChoiLai.FlatAppearance.BorderSize = 0;
            this.btnChoiLai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnChoiLai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnChoiLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoiLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoiLai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChoiLai.Location = new System.Drawing.Point(606, 584);
            this.btnChoiLai.Name = "btnChoiLai";
            this.btnChoiLai.OnHoverBorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnChoiLai.OnHoverButtonColor = System.Drawing.Color.DarkOliveGreen;
            this.btnChoiLai.OnHoverTextColor = System.Drawing.Color.White;
            this.btnChoiLai.Size = new System.Drawing.Size(128, 48);
            this.btnChoiLai.TabIndex = 29;
            this.btnChoiLai.Text = "Play again";
            this.btnChoiLai.TextColor = System.Drawing.Color.Black;
            this.btnChoiLai.UseVisualStyleBackColor = true;
            this.btnChoiLai.Click += new System.EventHandler(this.btnChoiLai_Click);
            // 
            // btnGiaiBFS
            // 
            this.btnGiaiBFS.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnGiaiBFS.ButtonColor = System.Drawing.Color.White;
            this.btnGiaiBFS.FlatAppearance.BorderSize = 0;
            this.btnGiaiBFS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGiaiBFS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGiaiBFS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaiBFS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaiBFS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGiaiBFS.Location = new System.Drawing.Point(905, 585);
            this.btnGiaiBFS.Name = "btnGiaiBFS";
            this.btnGiaiBFS.OnHoverBorderColor = System.Drawing.Color.DarkGreen;
            this.btnGiaiBFS.OnHoverButtonColor = System.Drawing.Color.DarkGreen;
            this.btnGiaiBFS.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGiaiBFS.Size = new System.Drawing.Size(135, 48);
            this.btnGiaiBFS.TabIndex = 28;
            this.btnGiaiBFS.Text = "Breadth FS";
            this.btnGiaiBFS.TextColor = System.Drawing.Color.Black;
            this.btnGiaiBFS.UseVisualStyleBackColor = true;
            this.btnGiaiBFS.Click += new System.EventHandler(this.btnGiai_Click);
            // 
            // btnGiaiToiUu
            // 
            this.btnGiaiToiUu.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnGiaiToiUu.ButtonColor = System.Drawing.Color.White;
            this.btnGiaiToiUu.FlatAppearance.BorderSize = 0;
            this.btnGiaiToiUu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGiaiToiUu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGiaiToiUu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaiToiUu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaiToiUu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGiaiToiUu.Location = new System.Drawing.Point(1063, 585);
            this.btnGiaiToiUu.Name = "btnGiaiToiUu";
            this.btnGiaiToiUu.OnHoverBorderColor = System.Drawing.Color.DarkGreen;
            this.btnGiaiToiUu.OnHoverButtonColor = System.Drawing.Color.DarkGreen;
            this.btnGiaiToiUu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGiaiToiUu.Size = new System.Drawing.Size(112, 48);
            this.btnGiaiToiUu.TabIndex = 27;
            this.btnGiaiToiUu.Text = "Best FS";
            this.btnGiaiToiUu.TextColor = System.Drawing.Color.Black;
            this.btnGiaiToiUu.UseVisualStyleBackColor = true;
            this.btnGiaiToiUu.Click += new System.EventHandler(this.btnGiaiToiUu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnThoat.ButtonColor = System.Drawing.Color.White;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThoat.Location = new System.Drawing.Point(1207, 584);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.OnHoverBorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnThoat.OnHoverButtonColor = System.Drawing.Color.DarkOliveGreen;
            this.btnThoat.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThoat.Size = new System.Drawing.Size(86, 48);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "Exit";
            this.btnThoat.TextColor = System.Drawing.Color.Black;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnUpload.ButtonColor = System.Drawing.Color.White;
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnUpload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpload.Location = new System.Drawing.Point(1181, 387);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.OnHoverBorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnUpload.OnHoverButtonColor = System.Drawing.Color.DarkOliveGreen;
            this.btnUpload.OnHoverTextColor = System.Drawing.Color.Tomato;
            this.btnUpload.Size = new System.Drawing.Size(112, 48);
            this.btnUpload.TabIndex = 25;
            this.btnUpload.Text = "Upload";
            this.btnUpload.TextColor = System.Drawing.Color.Black;
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1305, 687);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnTamDung);
            this.Controls.Add(this.btnChoiLai);
            this.Controls.Add(this.btnGiaiBFS);
            this.Controls.Add(this.btnGiaiToiUu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.lblBuocDuyet);
            this.Controls.Add(this.lblTimeGiai);
            this.Controls.Add(this.lblThoiGianDem);
            this.Controls.Add(this.lblBuocDi);
            this.Controls.Add(this.gbAnhGoc);
            this.Controls.Add(this.gbKhung);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KiemTraThoatChuongTrinh);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbKhung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuocDuyet;
        private System.Windows.Forms.Timer tmrThoiGianDem;
        private System.Windows.Forms.Label lblTimeGiai;
        private System.Windows.Forms.Label lblThoiGianDem;
        private System.Windows.Forms.Label lblBuocDi;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.PictureBox pbx4;
        private System.Windows.Forms.PictureBox pbx5;
        private System.Windows.Forms.PictureBox pbx6;
        private System.Windows.Forms.PictureBox pbx7;
        private System.Windows.Forms.PictureBox pbx8;
        private System.Windows.Forms.PictureBox pbx9;
        private System.Windows.Forms.GroupBox gbAnhGoc;
        private System.Windows.Forms.GroupBox gbKhung;
        private ePOSOne.btnProduct.Button_WOC btnUpload;
        private ePOSOne.btnProduct.Button_WOC btnThoat;
        private ePOSOne.btnProduct.Button_WOC btnGiaiToiUu;
        private ePOSOne.btnProduct.Button_WOC btnGiaiBFS;
        private ePOSOne.btnProduct.Button_WOC btnChoiLai;
        private ePOSOne.btnProduct.Button_WOC btnTamDung;
        private ePOSOne.btnProduct.Button_WOC btnNext;
        private ePOSOne.btnProduct.Button_WOC btnPrev;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

