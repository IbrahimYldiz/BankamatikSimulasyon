
namespace BankamatikSimülasyon
{
    partial class FrmUserPanel
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.TxtMoney = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBuyAccountNo = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.LblTcNo = new System.Windows.Forms.Label();
            this.LblNameSurname = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnAccountStatement = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(533, 171);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 171);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(533, 369);
            this.panel4.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnAccountStatement);
            this.groupBox2.Controls.Add(this.panel17);
            this.groupBox2.Controls.Add(this.panel15);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 349);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hesap Bilgileri";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 540);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(533, 272);
            this.panel5.TabIndex = 4;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnExit);
            this.groupBox1.Controls.Add(this.panel10);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EFT/Havale İşlemleri";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.button1);
            this.panel10.Controls.Add(this.TxtMoney);
            this.panel10.Controls.Add(this.panel14);
            this.panel10.Controls.Add(this.TxtBuyAccountNo);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(3, 26);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(269, 240);
            this.panel10.TabIndex = 0;
            // 
            // TxtMoney
            // 
            this.TxtMoney.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtMoney.Location = new System.Drawing.Point(0, 136);
            this.TxtMoney.Name = "TxtMoney";
            this.TxtMoney.Size = new System.Drawing.Size(269, 30);
            this.TxtMoney.TabIndex = 5;
            this.TxtMoney.TextChanged += new System.EventHandler(this.TxtMoney_TextChanged);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.label5);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 83);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(269, 53);
            this.panel14.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 53);
            this.label5.TabIndex = 1;
            this.label5.Text = "Gönderim Miktarı";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtBuyAccountNo
            // 
            this.TxtBuyAccountNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBuyAccountNo.Location = new System.Drawing.Point(0, 53);
            this.TxtBuyAccountNo.Name = "TxtBuyAccountNo";
            this.TxtBuyAccountNo.Size = new System.Drawing.Size(269, 30);
            this.TxtBuyAccountNo.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label3);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(269, 53);
            this.panel12.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 53);
            this.label3.TabIndex = 1;
            this.label3.Text = "TC Kimlik/ Hesap Numarası";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 85);
            this.label6.TabIndex = 3;
            this.label6.Text = "Hesap No";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.linkLabel1);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel20.Location = new System.Drawing.Point(0, 85);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(271, 36);
            this.panel20.TabIndex = 7;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.panel20);
            this.panel17.Controls.Add(this.label6);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(3, 26);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(271, 161);
            this.panel17.TabIndex = 2;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.panel1);
            this.panel15.Controls.Add(this.LblTcNo);
            this.panel15.Controls.Add(this.LblNameSurname);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel15.Location = new System.Drawing.Point(274, 26);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(256, 320);
            this.panel15.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "EFT/Havale Yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblTcNo
            // 
            this.LblTcNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTcNo.ForeColor = System.Drawing.Color.White;
            this.LblTcNo.Location = new System.Drawing.Point(0, 49);
            this.LblTcNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTcNo.Name = "LblTcNo";
            this.LblTcNo.Size = new System.Drawing.Size(256, 52);
            this.LblTcNo.TabIndex = 10;
            this.LblTcNo.Text = "Null";
            this.LblTcNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblNameSurname
            // 
            this.LblNameSurname.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblNameSurname.ForeColor = System.Drawing.Color.White;
            this.LblNameSurname.Location = new System.Drawing.Point(0, 0);
            this.LblNameSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNameSurname.Name = "LblNameSurname";
            this.LblNameSurname.Size = new System.Drawing.Size(256, 49);
            this.LblNameSurname.TabIndex = 11;
            this.LblNameSurname.Text = "Null";
            this.LblNameSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnExit.Location = new System.Drawing.Point(272, 209);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(258, 57);
            this.BtnExit.TabIndex = 11;
            this.BtnExit.Text = "Çıkış";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnAccountStatement
            // 
            this.BtnAccountStatement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.BtnAccountStatement.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnAccountStatement.Location = new System.Drawing.Point(3, 283);
            this.BtnAccountStatement.Name = "BtnAccountStatement";
            this.BtnAccountStatement.Size = new System.Drawing.Size(271, 63);
            this.BtnAccountStatement.TabIndex = 14;
            this.BtnAccountStatement.Text = "Hesap Dökümü";
            this.BtnAccountStatement.UseVisualStyleBackColor = false;
            this.BtnAccountStatement.Click += new System.EventHandler(this.BtnAccountStatement_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 208);
            this.panel1.TabIndex = 12;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Bakiye";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(256, 208);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Bakiye";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(0, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(271, 36);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Null";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.TextChanged += new System.EventHandler(this.linkLabel1_TextChanged);
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BankamatikSimülasyon.Properties.Resources.nasilbasarirsin_com_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(533, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmUserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(533, 826);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmUserPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUserPanel";
            this.Load += new System.EventHandler(this.FrmUserPanel_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox TxtMoney;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtBuyAccountNo;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblTcNo;
        private System.Windows.Forms.Label LblNameSurname;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnAccountStatement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}