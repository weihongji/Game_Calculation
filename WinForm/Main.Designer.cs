namespace Calculation
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbRange = new System.Windows.Forms.ComboBox();
            this.groupType = new System.Windows.Forms.GroupBox();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.rdoSubtract = new System.Windows.Forms.RadioButton();
            this.rdoAdd = new System.Windows.Forms.RadioButton();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUserAnswers = new System.Windows.Forms.TextBox();
            this.txtCalculations = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnSeeAnswers = new System.Windows.Forms.Button();
            this.txtAnswers = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupType.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 79);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbRange);
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(320, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.groupBox1.Size = new System.Drawing.Size(140, 64);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数字范围";
            // 
            // cmbRange
            // 
            this.cmbRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbRange.FormattingEnabled = true;
            this.cmbRange.Items.AddRange(new object[] {
            "10",
            "20"});
            this.cmbRange.Location = new System.Drawing.Point(20, 26);
            this.cmbRange.Name = "cmbRange";
            this.cmbRange.Size = new System.Drawing.Size(100, 28);
            this.cmbRange.TabIndex = 0;
            this.cmbRange.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbRange_KeyUp);
            // 
            // groupType
            // 
            this.groupType.Controls.Add(this.rdoAll);
            this.groupType.Controls.Add(this.rdoSubtract);
            this.groupType.Controls.Add(this.rdoAdd);
            this.groupType.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupType.Location = new System.Drawing.Point(12, 9);
            this.groupType.Name = "groupType";
            this.groupType.Size = new System.Drawing.Size(302, 64);
            this.groupType.TabIndex = 0;
            this.groupType.TabStop = false;
            this.groupType.Text = "计算类型";
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Location = new System.Drawing.Point(209, 29);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(67, 24);
            this.rdoAll.TabIndex = 2;
            this.rdoAll.Text = "全部";
            this.rdoAll.UseVisualStyleBackColor = true;
            // 
            // rdoSubtract
            // 
            this.rdoSubtract.AutoSize = true;
            this.rdoSubtract.Location = new System.Drawing.Point(118, 29);
            this.rdoSubtract.Name = "rdoSubtract";
            this.rdoSubtract.Size = new System.Drawing.Size(67, 24);
            this.rdoSubtract.TabIndex = 1;
            this.rdoSubtract.Text = "减法";
            this.rdoSubtract.UseVisualStyleBackColor = true;
            // 
            // rdoAdd
            // 
            this.rdoAdd.AutoSize = true;
            this.rdoAdd.Checked = true;
            this.rdoAdd.Location = new System.Drawing.Point(27, 29);
            this.rdoAdd.Name = "rdoAdd";
            this.rdoAdd.Size = new System.Drawing.Size(67, 24);
            this.rdoAdd.TabIndex = 0;
            this.rdoAdd.TabStop = true;
            this.rdoAdd.Text = "加法";
            this.rdoAdd.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("SimSun", 20F);
            this.btnGenerate.Location = new System.Drawing.Point(77, 12);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(151, 46);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "出题";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtUserAnswers);
            this.panel2.Controls.Add(this.txtCalculations);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 356);
            this.panel2.TabIndex = 1;
            // 
            // txtUserAnswers
            // 
            this.txtUserAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserAnswers.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUserAnswers.Location = new System.Drawing.Point(149, 0);
            this.txtUserAnswers.Multiline = true;
            this.txtUserAnswers.Name = "txtUserAnswers";
            this.txtUserAnswers.Size = new System.Drawing.Size(69, 356);
            this.txtUserAnswers.TabIndex = 1;
            this.txtUserAnswers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserAnswers_KeyPress);
            this.txtUserAnswers.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUserAnswers_KeyUp);
            // 
            // txtCalculations
            // 
            this.txtCalculations.BackColor = System.Drawing.SystemColors.Window;
            this.txtCalculations.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtCalculations.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCalculations.Location = new System.Drawing.Point(0, 0);
            this.txtCalculations.Multiline = true;
            this.txtCalculations.Name = "txtCalculations";
            this.txtCalculations.ReadOnly = true;
            this.txtCalculations.Size = new System.Drawing.Size(149, 356);
            this.txtCalculations.TabIndex = 0;
            this.txtCalculations.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblScore);
            this.panel3.Controls.Add(this.btnGenerate);
            this.panel3.Controls.Add(this.btnSeeAnswers);
            this.panel3.Controls.Add(this.txtAnswers);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(218, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(254, 356);
            this.panel3.TabIndex = 2;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblScore.Location = new System.Drawing.Point(73, 213);
            this.lblScore.MaximumSize = new System.Drawing.Size(180, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(169, 60);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "你得了{0}分，\r\n错的有点多，需要努力啊！";
            // 
            // btnSeeAnswers
            // 
            this.btnSeeAnswers.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSeeAnswers.Location = new System.Drawing.Point(77, 100);
            this.btnSeeAnswers.Name = "btnSeeAnswers";
            this.btnSeeAnswers.Size = new System.Drawing.Size(151, 82);
            this.btnSeeAnswers.TabIndex = 1;
            this.btnSeeAnswers.Text = "看结果";
            this.btnSeeAnswers.UseVisualStyleBackColor = true;
            this.btnSeeAnswers.Click += new System.EventHandler(this.btnSeeAnswers_Click);
            // 
            // txtAnswers
            // 
            this.txtAnswers.BackColor = System.Drawing.SystemColors.Control;
            this.txtAnswers.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtAnswers.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAnswers.Location = new System.Drawing.Point(0, 0);
            this.txtAnswers.Multiline = true;
            this.txtAnswers.Name = "txtAnswers";
            this.txtAnswers.ReadOnly = true;
            this.txtAnswers.Size = new System.Drawing.Size(57, 356);
            this.txtAnswers.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 435);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "出题计算";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupType.ResumeLayout(false);
            this.groupType.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupType;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.RadioButton rdoSubtract;
        private System.Windows.Forms.RadioButton rdoAdd;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCalculations;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSeeAnswers;
        private System.Windows.Forms.TextBox txtUserAnswers;
        private System.Windows.Forms.TextBox txtAnswers;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbRange;
    }
}

