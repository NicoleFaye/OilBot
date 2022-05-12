
namespace Oil_Bot
{
    partial class OilQueen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OilQueen));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DistanceBetweenUpDown = new System.Windows.Forms.NumericUpDown();
            this.LengthOfPressUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.WaitTimeUpDown = new System.Windows.Forms.NumericUpDown();
            this.LengthOfPressUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.XValueLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.YValueLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.WalkIntervalUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceBetweenUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthOfPressUpDown2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaitTimeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthOfPressUpDown1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WalkIntervalUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Afk",
            "Oil",
            "Mining"});
            this.comboBox1.Location = new System.Drawing.Point(65, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "X:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 300);
            this.panel1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(0, 300);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(0, 300);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(267, 300);
            this.tableLayoutPanel1.TabIndex = 9;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DistanceBetweenUpDown);
            this.groupBox3.Controls.Add(this.LengthOfPressUpDown2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(3, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 74);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Oil";
            // 
            // DistanceBetweenUpDown
            // 
            this.DistanceBetweenUpDown.Location = new System.Drawing.Point(112, 44);
            this.DistanceBetweenUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.DistanceBetweenUpDown.Name = "DistanceBetweenUpDown";
            this.DistanceBetweenUpDown.Size = new System.Drawing.Size(111, 20);
            this.DistanceBetweenUpDown.TabIndex = 8;
            this.DistanceBetweenUpDown.ValueChanged += new System.EventHandler(this.DistanceBetweenUpDown_ValueChanged);
            // 
            // LengthOfPressUpDown2
            // 
            this.LengthOfPressUpDown2.Location = new System.Drawing.Point(112, 18);
            this.LengthOfPressUpDown2.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.LengthOfPressUpDown2.Name = "LengthOfPressUpDown2";
            this.LengthOfPressUpDown2.Size = new System.Drawing.Size(111, 20);
            this.LengthOfPressUpDown2.TabIndex = 7;
            this.LengthOfPressUpDown2.ValueChanged += new System.EventHandler(this.LengthOfPressUpDown2_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Distance Between:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Length of Press:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.WaitTimeUpDown);
            this.groupBox2.Controls.Add(this.LengthOfPressUpDown1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(3, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 72);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mining";
            // 
            // WaitTimeUpDown
            // 
            this.WaitTimeUpDown.Location = new System.Drawing.Point(112, 46);
            this.WaitTimeUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.WaitTimeUpDown.Name = "WaitTimeUpDown";
            this.WaitTimeUpDown.Size = new System.Drawing.Size(111, 20);
            this.WaitTimeUpDown.TabIndex = 8;
            this.WaitTimeUpDown.ValueChanged += new System.EventHandler(this.WaitTimeUpDown_ValueChanged);
            // 
            // LengthOfPressUpDown1
            // 
            this.LengthOfPressUpDown1.Location = new System.Drawing.Point(112, 20);
            this.LengthOfPressUpDown1.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.LengthOfPressUpDown1.Name = "LengthOfPressUpDown1";
            this.LengthOfPressUpDown1.Size = new System.Drawing.Size(111, 20);
            this.LengthOfPressUpDown1.TabIndex = 7;
            this.LengthOfPressUpDown1.ValueChanged += new System.EventHandler(this.LengthOfPressUpDown1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Wait Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Length of Press:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.XValueLabel);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.YValueLabel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 274);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(261, 23);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // XValueLabel
            // 
            this.XValueLabel.AutoSize = true;
            this.XValueLabel.Location = new System.Drawing.Point(26, 0);
            this.XValueLabel.Name = "XValueLabel";
            this.XValueLabel.Size = new System.Drawing.Size(0, 13);
            this.XValueLabel.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Y:";
            // 
            // YValueLabel
            // 
            this.YValueLabel.AutoSize = true;
            this.YValueLabel.Location = new System.Drawing.Point(55, 0);
            this.YValueLabel.Name = "YValueLabel";
            this.YValueLabel.Size = new System.Drawing.Size(0, 13);
            this.YValueLabel.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 54);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.WalkIntervalUpDown);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(3, 221);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(252, 47);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Afk";
            // 
            // WalkIntervalUpDown
            // 
            this.WalkIntervalUpDown.Location = new System.Drawing.Point(112, 18);
            this.WalkIntervalUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.WalkIntervalUpDown.Name = "WalkIntervalUpDown";
            this.WalkIntervalUpDown.Size = new System.Drawing.Size(111, 20);
            this.WalkIntervalUpDown.TabIndex = 8;
            this.WalkIntervalUpDown.ValueChanged += new System.EventHandler(this.WalkIntervalUpDown_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Walk Interval (min):";
            // 
            // OilQueen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 300);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OilQueen";
            this.Text = "Oil Queen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OilQueen_FormClosing);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceBetweenUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthOfPressUpDown2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaitTimeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthOfPressUpDown1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WalkIntervalUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label XValueLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label YValueLabel;
        private System.Windows.Forms.NumericUpDown DistanceBetweenUpDown;
        private System.Windows.Forms.NumericUpDown LengthOfPressUpDown2;
        private System.Windows.Forms.NumericUpDown WaitTimeUpDown;
        private System.Windows.Forms.NumericUpDown LengthOfPressUpDown1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown WalkIntervalUpDown;
        private System.Windows.Forms.Label label7;
    }
}

