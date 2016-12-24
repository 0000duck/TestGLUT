namespace TestGLUT
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
            this.components = new System.ComponentModel.Container();
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.ObjectComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RenderTimer = new System.Windows.Forms.Timer(this.components);
            this.WireCheckBox = new System.Windows.Forms.CheckBox();
            this.AutoRotateCheckBox = new System.Windows.Forms.CheckBox();
            this.AutoRotateXTrackBar = new System.Windows.Forms.TrackBar();
            this.AutoRotateXLabel = new System.Windows.Forms.Label();
            this.ValueAutoRotateXLabel = new System.Windows.Forms.Label();
            this.ValueAutoRotateYLabel = new System.Windows.Forms.Label();
            this.AutoRotateYLabel = new System.Windows.Forms.Label();
            this.AutoRotateYTrackBar = new System.Windows.Forms.TrackBar();
            this.ValueAutoRotateZLabel = new System.Windows.Forms.Label();
            this.AutoRotateZLabel = new System.Windows.Forms.Label();
            this.AutoRotateZTrackBar = new System.Windows.Forms.TrackBar();
            this.AutoRotateGroupBox = new System.Windows.Forms.GroupBox();
            this.RotateZTrackBar = new System.Windows.Forms.TrackBar();
            this.ValueRotateZLabel = new System.Windows.Forms.Label();
            this.TitleRotateZLabel = new System.Windows.Forms.Label();
            this.RotateXTrackBar = new System.Windows.Forms.TrackBar();
            this.TitleRotateXLabel = new System.Windows.Forms.Label();
            this.ValueRotateYLabel = new System.Windows.Forms.Label();
            this.ValueRotateXLabel = new System.Windows.Forms.Label();
            this.TitleRotateYLabel = new System.Windows.Forms.Label();
            this.RotateYTrackBar = new System.Windows.Forms.TrackBar();
            this.LinkLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AutoRotateXTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoRotateYTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoRotateZTrackBar)).BeginInit();
            this.AutoRotateGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RotateZTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotateXTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotateYTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AnT
            // 
            this.AnT.AccumBits = ((byte)(0));
            this.AnT.AutoCheckErrors = false;
            this.AnT.AutoFinish = false;
            this.AnT.AutoMakeCurrent = true;
            this.AnT.AutoSwapBuffers = true;
            this.AnT.BackColor = System.Drawing.Color.Black;
            this.AnT.ColorBits = ((byte)(32));
            this.AnT.DepthBits = ((byte)(16));
            this.AnT.Location = new System.Drawing.Point(1, -1);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(500, 516);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 0;
            // 
            // ObjectComboBox
            // 
            this.ObjectComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ObjectComboBox.FormattingEnabled = true;
            this.ObjectComboBox.Items.AddRange(new object[] {
            "Сфера",
            "Цилиндр",
            "Куб",
            "Конус",
            "Тор",
            "Додекайдер",
            "Исосахедрон (Icosahedron?)",
            "Octahedron",
            "RhombicDodecahedron",
            "SierpinskiSponge (огонь вообще)",
            "Чайник",
            "Tetrahedron",
            "Трайфорс",
            "Молекулярное представление трайфорса"});
            this.ObjectComboBox.Location = new System.Drawing.Point(519, 28);
            this.ObjectComboBox.Name = "ObjectComboBox";
            this.ObjectComboBox.Size = new System.Drawing.Size(247, 21);
            this.ObjectComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Выбери, что вертеть";
            // 
            // RenderTimer
            // 
            this.RenderTimer.Interval = 30;
            this.RenderTimer.Tick += new System.EventHandler(this.RenderTimer_Tick);
            // 
            // WireCheckBox
            // 
            this.WireCheckBox.AutoSize = true;
            this.WireCheckBox.Location = new System.Drawing.Point(519, 56);
            this.WireCheckBox.Name = "WireCheckBox";
            this.WireCheckBox.Size = new System.Drawing.Size(75, 17);
            this.WireCheckBox.TabIndex = 18;
            this.WireCheckBox.Text = "Сеточный";
            this.WireCheckBox.UseVisualStyleBackColor = true;
            this.WireCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // AutoRotateCheckBox
            // 
            this.AutoRotateCheckBox.AutoSize = true;
            this.AutoRotateCheckBox.Location = new System.Drawing.Point(9, 25);
            this.AutoRotateCheckBox.Name = "AutoRotateCheckBox";
            this.AutoRotateCheckBox.Size = new System.Drawing.Size(78, 17);
            this.AutoRotateCheckBox.TabIndex = 21;
            this.AutoRotateCheckBox.Text = "Вращение";
            this.AutoRotateCheckBox.UseVisualStyleBackColor = true;
            // 
            // AutoRotateXTrackBar
            // 
            this.AutoRotateXTrackBar.LargeChange = 1;
            this.AutoRotateXTrackBar.Location = new System.Drawing.Point(39, 48);
            this.AutoRotateXTrackBar.Minimum = -10;
            this.AutoRotateXTrackBar.Name = "AutoRotateXTrackBar";
            this.AutoRotateXTrackBar.Size = new System.Drawing.Size(189, 45);
            this.AutoRotateXTrackBar.TabIndex = 22;
            this.AutoRotateXTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.AutoRotateXTrackBar.Scroll += new System.EventHandler(this.AutoRotateXTrackBar_Scroll);
            // 
            // AutoRotateXLabel
            // 
            this.AutoRotateXLabel.AutoSize = true;
            this.AutoRotateXLabel.Location = new System.Drawing.Point(17, 58);
            this.AutoRotateXLabel.Name = "AutoRotateXLabel";
            this.AutoRotateXLabel.Size = new System.Drawing.Size(14, 13);
            this.AutoRotateXLabel.TabIndex = 23;
            this.AutoRotateXLabel.Text = "X";
            // 
            // ValueAutoRotateXLabel
            // 
            this.ValueAutoRotateXLabel.AutoSize = true;
            this.ValueAutoRotateXLabel.Location = new System.Drawing.Point(234, 58);
            this.ValueAutoRotateXLabel.Name = "ValueAutoRotateXLabel";
            this.ValueAutoRotateXLabel.Size = new System.Drawing.Size(13, 13);
            this.ValueAutoRotateXLabel.TabIndex = 24;
            this.ValueAutoRotateXLabel.Text = "0";
            // 
            // ValueAutoRotateYLabel
            // 
            this.ValueAutoRotateYLabel.AutoSize = true;
            this.ValueAutoRotateYLabel.Location = new System.Drawing.Point(234, 98);
            this.ValueAutoRotateYLabel.Name = "ValueAutoRotateYLabel";
            this.ValueAutoRotateYLabel.Size = new System.Drawing.Size(13, 13);
            this.ValueAutoRotateYLabel.TabIndex = 27;
            this.ValueAutoRotateYLabel.Text = "0";
            // 
            // AutoRotateYLabel
            // 
            this.AutoRotateYLabel.AutoSize = true;
            this.AutoRotateYLabel.Location = new System.Drawing.Point(17, 98);
            this.AutoRotateYLabel.Name = "AutoRotateYLabel";
            this.AutoRotateYLabel.Size = new System.Drawing.Size(14, 13);
            this.AutoRotateYLabel.TabIndex = 26;
            this.AutoRotateYLabel.Text = "Y";
            // 
            // AutoRotateYTrackBar
            // 
            this.AutoRotateYTrackBar.LargeChange = 1;
            this.AutoRotateYTrackBar.Location = new System.Drawing.Point(39, 88);
            this.AutoRotateYTrackBar.Minimum = -10;
            this.AutoRotateYTrackBar.Name = "AutoRotateYTrackBar";
            this.AutoRotateYTrackBar.Size = new System.Drawing.Size(189, 45);
            this.AutoRotateYTrackBar.TabIndex = 25;
            this.AutoRotateYTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.AutoRotateYTrackBar.Scroll += new System.EventHandler(this.AutoRotateYTrackBar_Scroll);
            // 
            // ValueAutoRotateZLabel
            // 
            this.ValueAutoRotateZLabel.AutoSize = true;
            this.ValueAutoRotateZLabel.Location = new System.Drawing.Point(234, 139);
            this.ValueAutoRotateZLabel.Name = "ValueAutoRotateZLabel";
            this.ValueAutoRotateZLabel.Size = new System.Drawing.Size(13, 13);
            this.ValueAutoRotateZLabel.TabIndex = 30;
            this.ValueAutoRotateZLabel.Text = "0";
            // 
            // AutoRotateZLabel
            // 
            this.AutoRotateZLabel.AutoSize = true;
            this.AutoRotateZLabel.Location = new System.Drawing.Point(17, 139);
            this.AutoRotateZLabel.Name = "AutoRotateZLabel";
            this.AutoRotateZLabel.Size = new System.Drawing.Size(14, 13);
            this.AutoRotateZLabel.TabIndex = 29;
            this.AutoRotateZLabel.Text = "Z";
            // 
            // AutoRotateZTrackBar
            // 
            this.AutoRotateZTrackBar.LargeChange = 1;
            this.AutoRotateZTrackBar.Location = new System.Drawing.Point(39, 129);
            this.AutoRotateZTrackBar.Minimum = -10;
            this.AutoRotateZTrackBar.Name = "AutoRotateZTrackBar";
            this.AutoRotateZTrackBar.Size = new System.Drawing.Size(189, 45);
            this.AutoRotateZTrackBar.TabIndex = 28;
            this.AutoRotateZTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.AutoRotateZTrackBar.Scroll += new System.EventHandler(this.AutoRotateZTrackBar_Scroll);
            // 
            // AutoRotateGroupBox
            // 
            this.AutoRotateGroupBox.Controls.Add(this.AutoRotateZTrackBar);
            this.AutoRotateGroupBox.Controls.Add(this.ValueAutoRotateZLabel);
            this.AutoRotateGroupBox.Controls.Add(this.AutoRotateCheckBox);
            this.AutoRotateGroupBox.Controls.Add(this.AutoRotateZLabel);
            this.AutoRotateGroupBox.Controls.Add(this.AutoRotateXTrackBar);
            this.AutoRotateGroupBox.Controls.Add(this.AutoRotateXLabel);
            this.AutoRotateGroupBox.Controls.Add(this.ValueAutoRotateYLabel);
            this.AutoRotateGroupBox.Controls.Add(this.ValueAutoRotateXLabel);
            this.AutoRotateGroupBox.Controls.Add(this.AutoRotateYLabel);
            this.AutoRotateGroupBox.Controls.Add(this.AutoRotateYTrackBar);
            this.AutoRotateGroupBox.Location = new System.Drawing.Point(507, 293);
            this.AutoRotateGroupBox.Name = "AutoRotateGroupBox";
            this.AutoRotateGroupBox.Size = new System.Drawing.Size(259, 196);
            this.AutoRotateGroupBox.TabIndex = 31;
            this.AutoRotateGroupBox.TabStop = false;
            this.AutoRotateGroupBox.Text = "Автовращение";
            // 
            // RotateZTrackBar
            // 
            this.RotateZTrackBar.Location = new System.Drawing.Point(546, 160);
            this.RotateZTrackBar.Maximum = 360;
            this.RotateZTrackBar.Minimum = -360;
            this.RotateZTrackBar.Name = "RotateZTrackBar";
            this.RotateZTrackBar.Size = new System.Drawing.Size(189, 45);
            this.RotateZTrackBar.TabIndex = 37;
            this.RotateZTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.RotateZTrackBar.Scroll += new System.EventHandler(this.RorateZTrackBar_Scroll);
            // 
            // ValueRotateZLabel
            // 
            this.ValueRotateZLabel.AutoSize = true;
            this.ValueRotateZLabel.Location = new System.Drawing.Point(741, 170);
            this.ValueRotateZLabel.Name = "ValueRotateZLabel";
            this.ValueRotateZLabel.Size = new System.Drawing.Size(13, 13);
            this.ValueRotateZLabel.TabIndex = 39;
            this.ValueRotateZLabel.Text = "0";
            // 
            // TitleRotateZLabel
            // 
            this.TitleRotateZLabel.AutoSize = true;
            this.TitleRotateZLabel.Location = new System.Drawing.Point(524, 170);
            this.TitleRotateZLabel.Name = "TitleRotateZLabel";
            this.TitleRotateZLabel.Size = new System.Drawing.Size(14, 13);
            this.TitleRotateZLabel.TabIndex = 38;
            this.TitleRotateZLabel.Text = "Z";
            // 
            // RotateXTrackBar
            // 
            this.RotateXTrackBar.Location = new System.Drawing.Point(546, 79);
            this.RotateXTrackBar.Maximum = 360;
            this.RotateXTrackBar.Minimum = -360;
            this.RotateXTrackBar.Name = "RotateXTrackBar";
            this.RotateXTrackBar.Size = new System.Drawing.Size(189, 45);
            this.RotateXTrackBar.TabIndex = 31;
            this.RotateXTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.RotateXTrackBar.Scroll += new System.EventHandler(this.RorateXTrackBar_Scroll);
            // 
            // TitleRotateXLabel
            // 
            this.TitleRotateXLabel.AutoSize = true;
            this.TitleRotateXLabel.Location = new System.Drawing.Point(524, 89);
            this.TitleRotateXLabel.Name = "TitleRotateXLabel";
            this.TitleRotateXLabel.Size = new System.Drawing.Size(14, 13);
            this.TitleRotateXLabel.TabIndex = 32;
            this.TitleRotateXLabel.Text = "X";
            // 
            // ValueRotateYLabel
            // 
            this.ValueRotateYLabel.AutoSize = true;
            this.ValueRotateYLabel.Location = new System.Drawing.Point(741, 129);
            this.ValueRotateYLabel.Name = "ValueRotateYLabel";
            this.ValueRotateYLabel.Size = new System.Drawing.Size(13, 13);
            this.ValueRotateYLabel.TabIndex = 36;
            this.ValueRotateYLabel.Text = "0";
            // 
            // ValueRotateXLabel
            // 
            this.ValueRotateXLabel.AutoSize = true;
            this.ValueRotateXLabel.Location = new System.Drawing.Point(741, 89);
            this.ValueRotateXLabel.Name = "ValueRotateXLabel";
            this.ValueRotateXLabel.Size = new System.Drawing.Size(13, 13);
            this.ValueRotateXLabel.TabIndex = 33;
            this.ValueRotateXLabel.Text = "0";
            // 
            // TitleRotateYLabel
            // 
            this.TitleRotateYLabel.AutoSize = true;
            this.TitleRotateYLabel.Location = new System.Drawing.Point(524, 129);
            this.TitleRotateYLabel.Name = "TitleRotateYLabel";
            this.TitleRotateYLabel.Size = new System.Drawing.Size(14, 13);
            this.TitleRotateYLabel.TabIndex = 35;
            this.TitleRotateYLabel.Text = "Y";
            // 
            // RotateYTrackBar
            // 
            this.RotateYTrackBar.Location = new System.Drawing.Point(546, 119);
            this.RotateYTrackBar.Maximum = 360;
            this.RotateYTrackBar.Minimum = -360;
            this.RotateYTrackBar.Name = "RotateYTrackBar";
            this.RotateYTrackBar.Size = new System.Drawing.Size(189, 45);
            this.RotateYTrackBar.TabIndex = 34;
            this.RotateYTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.RotateYTrackBar.Scroll += new System.EventHandler(this.RorateYTrackBar_Scroll);
            // 
            // LinkLabel
            // 
            this.LinkLabel.AutoSize = true;
            this.LinkLabel.Location = new System.Drawing.Point(711, 57);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(55, 13);
            this.LinkLabel.TabIndex = 40;
            this.LinkLabel.TabStop = true;
            this.LinkLabel.Text = "Сбросить";
            this.LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(757, 495);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(20, 20);
            this.pictureBox.TabIndex = 41;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 516);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.LinkLabel);
            this.Controls.Add(this.RotateZTrackBar);
            this.Controls.Add(this.AutoRotateGroupBox);
            this.Controls.Add(this.ValueRotateZLabel);
            this.Controls.Add(this.WireCheckBox);
            this.Controls.Add(this.TitleRotateZLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RotateXTrackBar);
            this.Controls.Add(this.TitleRotateXLabel);
            this.Controls.Add(this.ObjectComboBox);
            this.Controls.Add(this.ValueRotateYLabel);
            this.Controls.Add(this.AnT);
            this.Controls.Add(this.ValueRotateXLabel);
            this.Controls.Add(this.RotateYTrackBar);
            this.Controls.Add(this.TitleRotateYLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(794, 555);
            this.Name = "MainForm";
            this.Text = "Деградация в кубе";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AutoRotateXTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoRotateYTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoRotateZTrackBar)).EndInit();
            this.AutoRotateGroupBox.ResumeLayout(false);
            this.AutoRotateGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RotateZTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotateXTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotateYTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.ComboBox ObjectComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer RenderTimer;
        private System.Windows.Forms.CheckBox WireCheckBox;
        private System.Windows.Forms.CheckBox AutoRotateCheckBox;
        private System.Windows.Forms.TrackBar AutoRotateXTrackBar;
        private System.Windows.Forms.Label AutoRotateXLabel;
        private System.Windows.Forms.Label ValueAutoRotateXLabel;
        private System.Windows.Forms.Label ValueAutoRotateYLabel;
        private System.Windows.Forms.Label AutoRotateYLabel;
        private System.Windows.Forms.TrackBar AutoRotateYTrackBar;
        private System.Windows.Forms.Label ValueAutoRotateZLabel;
        private System.Windows.Forms.Label AutoRotateZLabel;
        private System.Windows.Forms.TrackBar AutoRotateZTrackBar;
        private System.Windows.Forms.GroupBox AutoRotateGroupBox;
        private System.Windows.Forms.TrackBar RotateZTrackBar;
        private System.Windows.Forms.Label ValueRotateZLabel;
        private System.Windows.Forms.Label TitleRotateZLabel;
        private System.Windows.Forms.TrackBar RotateXTrackBar;
        private System.Windows.Forms.Label TitleRotateXLabel;
        private System.Windows.Forms.Label ValueRotateYLabel;
        private System.Windows.Forms.Label ValueRotateXLabel;
        private System.Windows.Forms.Label TitleRotateYLabel;
        private System.Windows.Forms.TrackBar RotateYTrackBar;
        private System.Windows.Forms.LinkLabel LinkLabel;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

