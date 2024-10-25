namespace runningroad
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBar_Yadjust = new System.Windows.Forms.TrackBar();
            this.checkBox_Array = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_Func4 = new System.Windows.Forms.RadioButton();
            this.radioButton_Func3 = new System.Windows.Forms.RadioButton();
            this.radioButton_Func2 = new System.Windows.Forms.RadioButton();
            this.radioButton_Func1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Ghost = new System.Windows.Forms.RadioButton();
            this.radioButton_Solid = new System.Windows.Forms.RadioButton();
            this.trackBarDY = new System.Windows.Forms.TrackBar();
            this.trackBarDZ = new System.Windows.Forms.TrackBar();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.trackBarOpacity = new System.Windows.Forms.TrackBar();
            this.trackBarSize = new System.Windows.Forms.TrackBar();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Yadjust)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.AutoSize = true;
            this.ControlPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ControlPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ControlPanel.Controls.Add(this.label7);
            this.ControlPanel.Controls.Add(this.trackBar_Yadjust);
            this.ControlPanel.Controls.Add(this.checkBox_Array);
            this.ControlPanel.Controls.Add(this.label6);
            this.ControlPanel.Controls.Add(this.progressBar1);
            this.ControlPanel.Controls.Add(this.label5);
            this.ControlPanel.Controls.Add(this.label4);
            this.ControlPanel.Controls.Add(this.label3);
            this.ControlPanel.Controls.Add(this.label2);
            this.ControlPanel.Controls.Add(this.label1);
            this.ControlPanel.Controls.Add(this.groupBox2);
            this.ControlPanel.Controls.Add(this.groupBox1);
            this.ControlPanel.Controls.Add(this.trackBarDY);
            this.ControlPanel.Controls.Add(this.trackBarDZ);
            this.ControlPanel.Controls.Add(this.buttonStartStop);
            this.ControlPanel.Controls.Add(this.trackBarOpacity);
            this.ControlPanel.Controls.Add(this.trackBarSize);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.MaximumSize = new System.Drawing.Size(1920, 85);
            this.ControlPanel.MinimumSize = new System.Drawing.Size(624, 110);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(624, 110);
            this.ControlPanel.TabIndex = 96;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(185, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 100;
            this.label7.Text = "Y adjust";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar_Yadjust
            // 
            this.trackBar_Yadjust.LargeChange = 2;
            this.trackBar_Yadjust.Location = new System.Drawing.Point(78, 65);
            this.trackBar_Yadjust.Maximum = 4;
            this.trackBar_Yadjust.Name = "trackBar_Yadjust";
            this.trackBar_Yadjust.Size = new System.Drawing.Size(104, 45);
            this.trackBar_Yadjust.TabIndex = 12;
            this.trackBar_Yadjust.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_Yadjust.Value = 2;
            this.trackBar_Yadjust.ValueChanged += new System.EventHandler(this.trackBar_Yadjust_ValueChanged);
            this.trackBar_Yadjust.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_Yadjust_MouseUp);
            // 
            // checkBox_Array
            // 
            this.checkBox_Array.AutoSize = true;
            this.checkBox_Array.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox_Array.Location = new System.Drawing.Point(3, 65);
            this.checkBox_Array.Name = "checkBox_Array";
            this.checkBox_Array.Size = new System.Drawing.Size(71, 17);
            this.checkBox_Array.TabIndex = 11;
            this.checkBox_Array.Text = "Use array";
            this.checkBox_Array.UseVisualStyleBackColor = true;
            this.checkBox_Array.CheckedChanged += new System.EventHandler(this.checkBox_Array_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(451, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 24);
            this.label6.TabIndex = 98;
            this.label6.Text = "of points";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Gold;
            this.progressBar1.Location = new System.Drawing.Point(454, 52);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(99, 13);
            this.progressBar1.TabIndex = 97;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(194, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Multiply";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(451, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 99;
            this.label4.Text = "COUNT";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Size";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(129, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Density";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(66, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Opacity";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_Func4);
            this.groupBox2.Controls.Add(this.radioButton_Func3);
            this.groupBox2.Controls.Add(this.radioButton_Func2);
            this.groupBox2.Controls.Add(this.radioButton_Func1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(321, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 65);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // radioButton_Func4
            // 
            this.radioButton_Func4.AutoSize = true;
            this.radioButton_Func4.Location = new System.Drawing.Point(69, 36);
            this.radioButton_Func4.Name = "radioButton_Func4";
            this.radioButton_Func4.Size = new System.Drawing.Size(55, 17);
            this.radioButton_Func4.TabIndex = 10;
            this.radioButton_Func4.TabStop = true;
            this.radioButton_Func4.Text = "Func4";
            this.radioButton_Func4.UseVisualStyleBackColor = true;
            this.radioButton_Func4.CheckedChanged += new System.EventHandler(this.radioButton_Func4_CheckedChanged);
            // 
            // radioButton_Func3
            // 
            this.radioButton_Func3.AutoSize = true;
            this.radioButton_Func3.Location = new System.Drawing.Point(69, 13);
            this.radioButton_Func3.Name = "radioButton_Func3";
            this.radioButton_Func3.Size = new System.Drawing.Size(55, 17);
            this.radioButton_Func3.TabIndex = 9;
            this.radioButton_Func3.TabStop = true;
            this.radioButton_Func3.Text = "Func3";
            this.radioButton_Func3.UseVisualStyleBackColor = true;
            this.radioButton_Func3.CheckedChanged += new System.EventHandler(this.radioButton_Func3_CheckedChanged);
            // 
            // radioButton_Func2
            // 
            this.radioButton_Func2.AutoSize = true;
            this.radioButton_Func2.Location = new System.Drawing.Point(7, 36);
            this.radioButton_Func2.Name = "radioButton_Func2";
            this.radioButton_Func2.Size = new System.Drawing.Size(55, 17);
            this.radioButton_Func2.TabIndex = 8;
            this.radioButton_Func2.Text = "Func2";
            this.radioButton_Func2.UseVisualStyleBackColor = true;
            this.radioButton_Func2.CheckedChanged += new System.EventHandler(this.radioButton_Func2_CheckedChanged);
            // 
            // radioButton_Func1
            // 
            this.radioButton_Func1.AutoSize = true;
            this.radioButton_Func1.Checked = true;
            this.radioButton_Func1.Location = new System.Drawing.Point(7, 13);
            this.radioButton_Func1.Name = "radioButton_Func1";
            this.radioButton_Func1.Size = new System.Drawing.Size(55, 17);
            this.radioButton_Func1.TabIndex = 7;
            this.radioButton_Func1.TabStop = true;
            this.radioButton_Func1.Text = "Func1";
            this.radioButton_Func1.UseVisualStyleBackColor = true;
            this.radioButton_Func1.CheckedChanged += new System.EventHandler(this.radioButton_Func1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Ghost);
            this.groupBox1.Controls.Add(this.radioButton_Solid);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(255, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(65, 65);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // radioButton_Ghost
            // 
            this.radioButton_Ghost.AutoSize = true;
            this.radioButton_Ghost.Location = new System.Drawing.Point(7, 36);
            this.radioButton_Ghost.Name = "radioButton_Ghost";
            this.radioButton_Ghost.Size = new System.Drawing.Size(53, 17);
            this.radioButton_Ghost.TabIndex = 6;
            this.radioButton_Ghost.Text = "Ghost";
            this.radioButton_Ghost.UseVisualStyleBackColor = true;
            this.radioButton_Ghost.CheckedChanged += new System.EventHandler(this.radioButton_Ghost_CheckedChanged);
            // 
            // radioButton_Solid
            // 
            this.radioButton_Solid.AutoSize = true;
            this.radioButton_Solid.Checked = true;
            this.radioButton_Solid.Location = new System.Drawing.Point(7, 13);
            this.radioButton_Solid.Name = "radioButton_Solid";
            this.radioButton_Solid.Size = new System.Drawing.Size(48, 17);
            this.radioButton_Solid.TabIndex = 5;
            this.radioButton_Solid.TabStop = true;
            this.radioButton_Solid.Text = "Solid";
            this.radioButton_Solid.UseVisualStyleBackColor = true;
            this.radioButton_Solid.CheckedChanged += new System.EventHandler(this.radioButton_Solid_CheckedChanged);
            // 
            // trackBarDY
            // 
            this.trackBarDY.AccessibleDescription = "";
            this.trackBarDY.LargeChange = 1;
            this.trackBarDY.Location = new System.Drawing.Point(188, 0);
            this.trackBarDY.Maximum = 8;
            this.trackBarDY.Minimum = 1;
            this.trackBarDY.MinimumSize = new System.Drawing.Size(60, 50);
            this.trackBarDY.Name = "trackBarDY";
            this.trackBarDY.Size = new System.Drawing.Size(60, 45);
            this.trackBarDY.TabIndex = 3;
            this.trackBarDY.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarDY.Value = 3;
            this.trackBarDY.ValueChanged += new System.EventHandler(this.trackBarDY_ValueChanged);
            this.trackBarDY.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarDY_MouseUp);
            // 
            // trackBarDZ
            // 
            this.trackBarDZ.AccessibleDescription = "";
            this.trackBarDZ.LargeChange = 1;
            this.trackBarDZ.Location = new System.Drawing.Point(122, 0);
            this.trackBarDZ.Minimum = 1;
            this.trackBarDZ.MinimumSize = new System.Drawing.Size(60, 50);
            this.trackBarDZ.Name = "trackBarDZ";
            this.trackBarDZ.Size = new System.Drawing.Size(60, 45);
            this.trackBarDZ.TabIndex = 2;
            this.trackBarDZ.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarDZ.Value = 5;
            this.trackBarDZ.ValueChanged += new System.EventHandler(this.trackBarDZ_ValueChanged);
            this.trackBarDZ.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarDZ_MouseUp);
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonStartStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonStartStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonStartStop.Location = new System.Drawing.Point(559, 0);
            this.buttonStartStop.MaximumSize = new System.Drawing.Size(65, 65);
            this.buttonStartStop.MinimumSize = new System.Drawing.Size(65, 65);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(65, 65);
            this.buttonStartStop.TabIndex = 13;
            this.buttonStartStop.Text = "Let It Run!";
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.KeyUp += new System.Windows.Forms.KeyEventHandler(this.buttonStartStop_KeyUp);
            this.buttonStartStop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonStartStop_MouseClick);
            // 
            // trackBarOpacity
            // 
            this.trackBarOpacity.AccessibleDescription = "";
            this.trackBarOpacity.LargeChange = 1;
            this.trackBarOpacity.Location = new System.Drawing.Point(61, 0);
            this.trackBarOpacity.Minimum = 1;
            this.trackBarOpacity.MinimumSize = new System.Drawing.Size(60, 50);
            this.trackBarOpacity.Name = "trackBarOpacity";
            this.trackBarOpacity.Size = new System.Drawing.Size(60, 45);
            this.trackBarOpacity.TabIndex = 1;
            this.trackBarOpacity.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarOpacity.Value = 10;
            this.trackBarOpacity.ValueChanged += new System.EventHandler(this.trackBarOpacity_ValueChanged);
            this.trackBarOpacity.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarOpacity_MouseUp);
            // 
            // trackBarSize
            // 
            this.trackBarSize.Dock = System.Windows.Forms.DockStyle.Left;
            this.trackBarSize.LargeChange = 1;
            this.trackBarSize.Location = new System.Drawing.Point(0, 0);
            this.trackBarSize.Maximum = 8;
            this.trackBarSize.Minimum = 4;
            this.trackBarSize.MinimumSize = new System.Drawing.Size(60, 50);
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Size = new System.Drawing.Size(60, 110);
            this.trackBarSize.TabIndex = 0;
            this.trackBarSize.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarSize.Value = 4;
            this.trackBarSize.ValueChanged += new System.EventHandler(this.trackBarSize_ValueChanged);
            this.trackBarSize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarSize_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.ControlPanel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.Text = "Demo \"The Running Road\"";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Yadjust)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ControlPanel;
        public System.Windows.Forms.TrackBar trackBarSize;
        public System.Windows.Forms.TrackBar trackBarOpacity;
        private System.Windows.Forms.Button buttonStartStop;
        public System.Windows.Forms.TrackBar trackBarDY;
        public System.Windows.Forms.TrackBar trackBarDZ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Ghost;
        private System.Windows.Forms.RadioButton radioButton_Solid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_Func2;
        private System.Windows.Forms.RadioButton radioButton_Func1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton_Func3;
        private System.Windows.Forms.RadioButton radioButton_Func4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox_Array;
        private System.Windows.Forms.TrackBar trackBar_Yadjust;
        private System.Windows.Forms.Label label7;
    }
}

