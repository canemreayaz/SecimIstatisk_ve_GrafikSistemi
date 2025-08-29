namespace _2_Seçimİstatistik_ve_GrafikSistemi
{
    partial class FrmGrafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrafikler));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_kisiSayısı = new System.Windows.Forms.Label();
            this.lbl_kullanılanOy = new System.Windows.Forms.Label();
            this.lbl_gecerliOy = new System.Windows.Forms.Label();
            this.lbl_gecersizOy = new System.Windows.Forms.Label();
            this.lbl_nufus = new System.Windows.Forms.Label();
            this.lbl_b = new System.Windows.Forms.Label();
            this.lbl_c = new System.Windows.Forms.Label();
            this.lbl_d = new System.Windows.Forms.Label();
            this.lbl_e = new System.Windows.Forms.Label();
            this.lbl_a = new System.Windows.Forms.Label();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cikisYap = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1068, 282);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İL GENEL DURUM";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 24);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Partiler";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1062, 255);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.lbl_kisiSayısı);
            this.groupBox2.Controls.Add(this.lbl_kullanılanOy);
            this.groupBox2.Controls.Add(this.lbl_gecerliOy);
            this.groupBox2.Controls.Add(this.lbl_gecersizOy);
            this.groupBox2.Controls.Add(this.lbl_nufus);
            this.groupBox2.Controls.Add(this.lbl_b);
            this.groupBox2.Controls.Add(this.lbl_c);
            this.groupBox2.Controls.Add(this.lbl_d);
            this.groupBox2.Controls.Add(this.lbl_e);
            this.groupBox2.Controls.Add(this.lbl_a);
            this.groupBox2.Controls.Add(this.progressBar5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.progressBar4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.progressBar3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.progressBar2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1068, 353);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İlçe Değerleri";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(656, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(270, 21);
            this.label12.TabIndex = 26;
            this.label12.Text = "OY KULLANACAK KİŞİ SAYISI:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(763, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(163, 21);
            this.label13.TabIndex = 25;
            this.label13.Text = "KULLANILAN OY:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(802, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 21);
            this.label14.TabIndex = 24;
            this.label14.Text = "GEÇERLİ OY:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(792, 232);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 21);
            this.label15.TabIndex = 23;
            this.label15.Text = "GEÇERSİZ OY:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(847, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 21);
            this.label16.TabIndex = 22;
            this.label16.Text = "NÜFUS:";
            // 
            // lbl_kisiSayısı
            // 
            this.lbl_kisiSayısı.AutoSize = true;
            this.lbl_kisiSayısı.Location = new System.Drawing.Point(932, 94);
            this.lbl_kisiSayısı.Name = "lbl_kisiSayısı";
            this.lbl_kisiSayısı.Size = new System.Drawing.Size(21, 21);
            this.lbl_kisiSayısı.TabIndex = 21;
            this.lbl_kisiSayısı.Text = "0";
            // 
            // lbl_kullanılanOy
            // 
            this.lbl_kullanılanOy.AutoSize = true;
            this.lbl_kullanılanOy.Location = new System.Drawing.Point(932, 140);
            this.lbl_kullanılanOy.Name = "lbl_kullanılanOy";
            this.lbl_kullanılanOy.Size = new System.Drawing.Size(21, 21);
            this.lbl_kullanılanOy.TabIndex = 20;
            this.lbl_kullanılanOy.Text = "0";
            // 
            // lbl_gecerliOy
            // 
            this.lbl_gecerliOy.AutoSize = true;
            this.lbl_gecerliOy.Location = new System.Drawing.Point(932, 187);
            this.lbl_gecerliOy.Name = "lbl_gecerliOy";
            this.lbl_gecerliOy.Size = new System.Drawing.Size(21, 21);
            this.lbl_gecerliOy.TabIndex = 19;
            this.lbl_gecerliOy.Text = "0";
            // 
            // lbl_gecersizOy
            // 
            this.lbl_gecersizOy.AutoSize = true;
            this.lbl_gecersizOy.Location = new System.Drawing.Point(932, 232);
            this.lbl_gecersizOy.Name = "lbl_gecersizOy";
            this.lbl_gecersizOy.Size = new System.Drawing.Size(21, 21);
            this.lbl_gecersizOy.TabIndex = 18;
            this.lbl_gecersizOy.Text = "0";
            // 
            // lbl_nufus
            // 
            this.lbl_nufus.AutoSize = true;
            this.lbl_nufus.Location = new System.Drawing.Point(932, 46);
            this.lbl_nufus.Name = "lbl_nufus";
            this.lbl_nufus.Size = new System.Drawing.Size(21, 21);
            this.lbl_nufus.TabIndex = 17;
            this.lbl_nufus.Text = "0";
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Location = new System.Drawing.Point(517, 152);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(21, 21);
            this.lbl_b.TabIndex = 16;
            this.lbl_b.Text = "0";
            this.lbl_b.Click += new System.EventHandler(this.label11_Click);
            // 
            // lbl_c
            // 
            this.lbl_c.AutoSize = true;
            this.lbl_c.Location = new System.Drawing.Point(517, 198);
            this.lbl_c.Name = "lbl_c";
            this.lbl_c.Size = new System.Drawing.Size(21, 21);
            this.lbl_c.TabIndex = 15;
            this.lbl_c.Text = "0";
            // 
            // lbl_d
            // 
            this.lbl_d.AutoSize = true;
            this.lbl_d.Location = new System.Drawing.Point(517, 245);
            this.lbl_d.Name = "lbl_d";
            this.lbl_d.Size = new System.Drawing.Size(21, 21);
            this.lbl_d.TabIndex = 14;
            this.lbl_d.Text = "0";
            // 
            // lbl_e
            // 
            this.lbl_e.AutoSize = true;
            this.lbl_e.Location = new System.Drawing.Point(517, 290);
            this.lbl_e.Name = "lbl_e";
            this.lbl_e.Size = new System.Drawing.Size(21, 21);
            this.lbl_e.TabIndex = 13;
            this.lbl_e.Text = "0";
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Location = new System.Drawing.Point(517, 104);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(21, 21);
            this.lbl_a.TabIndex = 12;
            this.lbl_a.Text = "0";
            this.lbl_a.Click += new System.EventHandler(this.lbl_a_Click);
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(134, 290);
            this.progressBar5.Maximum = 5000;
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(313, 30);
            this.progressBar5.TabIndex = 11;
            this.progressBar5.Click += new System.EventHandler(this.progressBar5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "E PARTİ:";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(134, 245);
            this.progressBar4.Maximum = 5000;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(313, 30);
            this.progressBar4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "B PARTİ:";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(134, 198);
            this.progressBar3.Maximum = 5000;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(313, 30);
            this.progressBar3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "C PARTİ:";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(134, 152);
            this.progressBar2.Maximum = 5000;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(313, 30);
            this.progressBar2.TabIndex = 5;
            this.progressBar2.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "D PARTİ:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(134, 104);
            this.progressBar1.Maximum = 5000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(313, 30);
            this.progressBar1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "A PARTİ:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(134, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 29);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlçe Seçin:";
            // 
            // btn_cikisYap
            // 
            this.btn_cikisYap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cikisYap.ImageIndex = 0;
            this.btn_cikisYap.ImageList = this.ımageList1;
            this.btn_cikisYap.Location = new System.Drawing.Point(12, 677);
            this.btn_cikisYap.Name = "btn_cikisYap";
            this.btn_cikisYap.Size = new System.Drawing.Size(154, 42);
            this.btn_cikisYap.TabIndex = 2;
            this.btn_cikisYap.Text = "Çıkış Yap";
            this.btn_cikisYap.UseVisualStyleBackColor = true;
            this.btn_cikisYap.Click += new System.EventHandler(this.btn_cikisYap_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "cıkıs.png");
            // 
            // FrmGrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1092, 731);
            this.Controls.Add(this.btn_cikisYap);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGrafikler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VTGS";
            this.Load += new System.EventHandler(this.FrmGrafikler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_b;
        private System.Windows.Forms.Label lbl_c;
        private System.Windows.Forms.Label lbl_d;
        private System.Windows.Forms.Label lbl_e;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.Button btn_cikisYap;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_kisiSayısı;
        private System.Windows.Forms.Label lbl_kullanılanOy;
        private System.Windows.Forms.Label lbl_gecerliOy;
        private System.Windows.Forms.Label lbl_gecersizOy;
        private System.Windows.Forms.Label lbl_nufus;
    }
}