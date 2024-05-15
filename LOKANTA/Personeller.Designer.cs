namespace LOKANTA
{
    partial class Personeller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personeller));
            groupBox1 = new GroupBox();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            listView1 = new ListView();
            isim = new ColumnHeader();
            soyisim = new ColumnHeader();
            maas = new ColumnHeader();
            empId = new ColumnHeader();
            grvId = new ColumnHeader();
            groupBox2 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            listView2 = new ListView();
            gorevNo = new ColumnHeader();
            gorevAd = new ColumnHeader();
            button6 = new Button();
            groupBox3 = new GroupBox();
            salary = new TextBox();
            label4 = new Label();
            l_name = new TextBox();
            label3 = new Label();
            f_name = new TextBox();
            label2 = new Label();
            gorev = new TextBox();
            label1 = new Label();
            groupBox4 = new GroupBox();
            grvName = new TextBox();
            label7 = new Label();
            grvNO = new TextBox();
            label8 = new Label();
            button3 = new Button();
            panel1 = new Panel();
            label5 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gray;
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(listView1);
            groupBox1.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(391, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(675, 693);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Bilgileri";
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Transparent;
            btnGuncelle.BackgroundImage = (Image)resources.GetObject("btnGuncelle.BackgroundImage");
            btnGuncelle.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuncelle.Location = new Point(563, 17);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(67, 55);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Transparent;
            btnSil.BackgroundImage = (Image)resources.GetObject("btnSil.BackgroundImage");
            btnSil.BackgroundImageLayout = ImageLayout.Stretch;
            btnSil.Location = new Point(470, 17);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(67, 55);
            btnSil.TabIndex = 4;
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Transparent;
            btnEkle.BackgroundImage = Properties.Resources.plus_icon_plus_svg_png_icon_download_1;
            btnEkle.BackgroundImageLayout = ImageLayout.Stretch;
            btnEkle.Location = new Point(374, 17);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(67, 55);
            btnEkle.TabIndex = 1;
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { isim, soyisim, maas, empId, grvId });
            listView1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(18, 91);
            listView1.Name = "listView1";
            listView1.Size = new Size(603, 562);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // isim
            // 
            isim.Text = "İD";
            isim.Width = 0;
            // 
            // soyisim
            // 
            soyisim.Text = "GÖREV ID";
            soyisim.Width = 180;
            // 
            // maas
            // 
            maas.Text = "İSİM";
            maas.Width = 160;
            // 
            // empId
            // 
            empId.Text = "SOY İSİM";
            empId.Width = 130;
            // 
            // grvId
            // 
            grvId.Text = "MAAŞ";
            grvId.Width = 130;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Gray;
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(listView2);
            groupBox2.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic);
            groupBox2.ForeColor = SystemColors.ButtonFace;
            groupBox2.Location = new Point(1119, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(554, 684);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Görevler";
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(471, 17);
            button2.Name = "button2";
            button2.Size = new Size(67, 55);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.plus_icon_plus_svg_png_icon_download_1;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(384, 17);
            button1.Name = "button1";
            button1.Size = new Size(67, 55);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { gorevNo, gorevAd });
            listView2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic);
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Location = new Point(68, 104);
            listView2.Name = "listView2";
            listView2.Size = new Size(383, 490);
            listView2.TabIndex = 0;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // gorevNo
            // 
            gorevNo.Text = "GÖREV NO";
            gorevNo.Width = 180;
            // 
            // gorevAd
            // 
            gorevAd.Text = "GÖREV ADI";
            gorevAd.Width = 200;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button6.ForeColor = Color.Crimson;
            button6.Location = new Point(40, 930);
            button6.Name = "button6";
            button6.Size = new Size(170, 54);
            button6.TabIndex = 16;
            button6.Text = "Çıkış";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Gray;
            groupBox3.Controls.Add(salary);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(l_name);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(f_name);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(gorev);
            groupBox3.Controls.Add(label1);
            groupBox3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(391, 711);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(363, 318);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Yeni Personel Bilgileri";
            // 
            // salary
            // 
            salary.Location = new Point(139, 219);
            salary.Name = "salary";
            salary.Size = new Size(161, 36);
            salary.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label4.Location = new Point(53, 219);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 6;
            label4.Text = "Maaş :";
            // 
            // l_name
            // 
            l_name.Location = new Point(139, 163);
            l_name.Name = "l_name";
            l_name.Size = new Size(161, 36);
            l_name.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label3.Location = new Point(22, 163);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 4;
            label3.Text = "Soy İsimi :";
            // 
            // f_name
            // 
            f_name.Location = new Point(139, 106);
            f_name.Name = "f_name";
            f_name.Size = new Size(161, 36);
            f_name.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label2.Location = new Point(62, 106);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 2;
            label2.Text = "İsim :";
            // 
            // gorev
            // 
            gorev.Location = new Point(139, 54);
            gorev.Name = "gorev";
            gorev.Size = new Size(161, 36);
            gorev.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label1.Location = new Point(16, 54);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 0;
            label1.Text = "Görev No :";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Gray;
            groupBox4.Controls.Add(grvName);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(grvNO);
            groupBox4.Controls.Add(label8);
            groupBox4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(1119, 720);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(363, 165);
            groupBox4.TabIndex = 18;
            groupBox4.TabStop = false;
            groupBox4.Text = "Yeni Görev Bilgileri";
            // 
            // grvName
            // 
            grvName.Location = new Point(131, 106);
            grvName.Name = "grvName";
            grvName.Size = new Size(161, 36);
            grvName.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label7.Location = new Point(7, 106);
            label7.Name = "label7";
            label7.Size = new Size(104, 25);
            label7.TabIndex = 2;
            label7.Text = "Görev Adi :";
            // 
            // grvNO
            // 
            grvNO.Location = new Point(131, 54);
            grvNO.Name = "grvNO";
            grvNO.Size = new Size(161, 36);
            grvNO.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label8.Location = new Point(7, 54);
            label8.Name = "label8";
            label8.Size = new Size(101, 25);
            label8.TabIndex = 0;
            label8.Text = "Görev No :";
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button3.ForeColor = Color.Crimson;
            button3.Location = new Point(40, 62);
            button3.Name = "button3";
            button3.Size = new Size(205, 54);
            button3.TabIndex = 19;
            button3.Text = "Kasiyer Kontrol";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button6);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(283, 1041);
            panel1.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(3, 24);
            label5.Name = "label5";
            label5.Size = new Size(266, 15);
            label5.TabIndex = 27;
            label5.Text = "- - - - - - - - - - - - - - - - - - -  - - - - - - - - -  - - - -\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(3, 137);
            label6.Name = "label6";
            label6.Size = new Size(266, 15);
            label6.TabIndex = 25;
            label6.Text = "- - - - - - - - - - - - - - - - - - -  - - - - - - - - -  - - - -\r\n";
            // 
            // Personeller
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Personeller";
            Text = "Personeller";
            WindowState = FormWindowState.Maximized;
            Load += Personeller_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listView1;
        private ColumnHeader isim;
        private ColumnHeader soyisim;
        private ColumnHeader maas;
        private ColumnHeader empId;
        private ColumnHeader grvId;
        private GroupBox groupBox2;
        private ListView listView2;
        private ColumnHeader gorevNo;
        private ColumnHeader gorevAd;
        private Button button6;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private Button button2;
        private Button button1;
        private GroupBox groupBox3;
        private Label label1;
        private TextBox gorev;
        private TextBox salary;
        private Label label4;
        private TextBox l_name;
        private Label label3;
        private TextBox f_name;
        private Label label2;
        private GroupBox groupBox4;
        private TextBox grvName;
        private Label label7;
        private TextBox grvNO;
        private Label label8;
        private Button button3;
        private Panel panel1;
        private Label label5;
        private Label label6;
    }
}