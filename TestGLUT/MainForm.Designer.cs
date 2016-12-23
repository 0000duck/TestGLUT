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
            this.AxisComboBox = new System.Windows.Forms.ComboBox();
            this.ObjectComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TitleAxisX = new System.Windows.Forms.Label();
            this.TrackBarAxisX = new System.Windows.Forms.TrackBar();
            this.TrackBarAxisY = new System.Windows.Forms.TrackBar();
            this.TitleAxisY = new System.Windows.Forms.Label();
            this.TrackBarAxisZ = new System.Windows.Forms.TrackBar();
            this.TitleAxisZ = new System.Windows.Forms.Label();
            this.TrackBarAngle = new System.Windows.Forms.TrackBar();
            this.TitleAngle = new System.Windows.Forms.Label();
            this.TrackBarZoom = new System.Windows.Forms.TrackBar();
            this.TitleZoom = new System.Windows.Forms.Label();
            this.ValueAxisX = new System.Windows.Forms.Label();
            this.ValueAxisY = new System.Windows.Forms.Label();
            this.ValueAxisZ = new System.Windows.Forms.Label();
            this.RenderTimer = new System.Windows.Forms.Timer(this.components);
            this.WireCheckBox = new System.Windows.Forms.CheckBox();
            this.ValueAngle = new System.Windows.Forms.Label();
            this.ValueZoom = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarAxisX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarAxisY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarAxisZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoRotateXTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoRotateYTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoRotateZTrackBar)).BeginInit();
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
            // AxisComboBox
            // 
            this.AxisComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AxisComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AxisComboBox.FormattingEnabled = true;
            this.AxisComboBox.Items.AddRange(new object[] {
            "Вращать вдоль X",
            "Вращать вдоль Y",
            "Вращать вдоль Z"});
            this.AxisComboBox.Location = new System.Drawing.Point(519, 36);
            this.AxisComboBox.Name = "AxisComboBox";
            this.AxisComboBox.Size = new System.Drawing.Size(247, 21);
            this.AxisComboBox.TabIndex = 1;
            this.AxisComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            "Тор"});
            this.ObjectComboBox.Location = new System.Drawing.Point(519, 90);
            this.ObjectComboBox.Name = "ObjectComboBox";
            this.ObjectComboBox.Size = new System.Drawing.Size(247, 21);
            this.ObjectComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "По оси";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Объект для визуализации";
            // 
            // TitleAxisX
            // 
            this.TitleAxisX.AutoSize = true;
            this.TitleAxisX.Location = new System.Drawing.Point(516, 148);
            this.TitleAxisX.Name = "TitleAxisX";
            this.TitleAxisX.Size = new System.Drawing.Size(14, 13);
            this.TitleAxisX.TabIndex = 5;
            this.TitleAxisX.Text = "X";
            // 
            // TrackBarAxisX
            // 
            this.TrackBarAxisX.Location = new System.Drawing.Point(519, 164);
            this.TrackBarAxisX.Maximum = 50000;
            this.TrackBarAxisX.Minimum = -50000;
            this.TrackBarAxisX.Name = "TrackBarAxisX";
            this.TrackBarAxisX.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarAxisX.Size = new System.Drawing.Size(45, 119);
            this.TrackBarAxisX.TabIndex = 6;
            this.TrackBarAxisX.Scroll += new System.EventHandler(this.TrackBarAxisX_Scroll);
            // 
            // TrackBarAxisY
            // 
            this.TrackBarAxisY.Location = new System.Drawing.Point(570, 164);
            this.TrackBarAxisY.Maximum = 50000;
            this.TrackBarAxisY.Minimum = -50000;
            this.TrackBarAxisY.Name = "TrackBarAxisY";
            this.TrackBarAxisY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarAxisY.Size = new System.Drawing.Size(45, 119);
            this.TrackBarAxisY.TabIndex = 8;
            this.TrackBarAxisY.Scroll += new System.EventHandler(this.TrackBarAxisY_Scroll);
            // 
            // TitleAxisY
            // 
            this.TitleAxisY.AutoSize = true;
            this.TitleAxisY.Location = new System.Drawing.Point(567, 148);
            this.TitleAxisY.Name = "TitleAxisY";
            this.TitleAxisY.Size = new System.Drawing.Size(14, 13);
            this.TitleAxisY.TabIndex = 7;
            this.TitleAxisY.Text = "Y";
            // 
            // TrackBarAxisZ
            // 
            this.TrackBarAxisZ.Location = new System.Drawing.Point(621, 164);
            this.TrackBarAxisZ.Maximum = 50000;
            this.TrackBarAxisZ.Minimum = -50000;
            this.TrackBarAxisZ.Name = "TrackBarAxisZ";
            this.TrackBarAxisZ.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarAxisZ.Size = new System.Drawing.Size(45, 119);
            this.TrackBarAxisZ.TabIndex = 10;
            this.TrackBarAxisZ.Scroll += new System.EventHandler(this.TrackBarAxisZ_Scroll);
            // 
            // TitleAxisZ
            // 
            this.TitleAxisZ.AutoSize = true;
            this.TitleAxisZ.Location = new System.Drawing.Point(618, 148);
            this.TitleAxisZ.Name = "TitleAxisZ";
            this.TitleAxisZ.Size = new System.Drawing.Size(14, 13);
            this.TitleAxisZ.TabIndex = 9;
            this.TitleAxisZ.Text = "Z";
            // 
            // TrackBarAngle
            // 
            this.TrackBarAngle.Location = new System.Drawing.Point(672, 164);
            this.TrackBarAngle.Maximum = 360;
            this.TrackBarAngle.Minimum = -360;
            this.TrackBarAngle.Name = "TrackBarAngle";
            this.TrackBarAngle.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarAngle.Size = new System.Drawing.Size(45, 119);
            this.TrackBarAngle.TabIndex = 12;
            this.TrackBarAngle.Scroll += new System.EventHandler(this.TrackBarAngle_Scroll);
            // 
            // TitleAngle
            // 
            this.TitleAngle.AutoSize = true;
            this.TitleAngle.Location = new System.Drawing.Point(669, 148);
            this.TitleAngle.Name = "TitleAngle";
            this.TitleAngle.Size = new System.Drawing.Size(34, 13);
            this.TitleAngle.TabIndex = 11;
            this.TitleAngle.Text = "Angle";
            // 
            // TrackBarZoom
            // 
            this.TrackBarZoom.Location = new System.Drawing.Point(723, 164);
            this.TrackBarZoom.Maximum = 5000;
            this.TrackBarZoom.Minimum = -5000;
            this.TrackBarZoom.Name = "TrackBarZoom";
            this.TrackBarZoom.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarZoom.Size = new System.Drawing.Size(45, 119);
            this.TrackBarZoom.TabIndex = 14;
            this.TrackBarZoom.Scroll += new System.EventHandler(this.TrackBarZoom_Scroll);
            // 
            // TitleZoom
            // 
            this.TitleZoom.AutoSize = true;
            this.TitleZoom.Location = new System.Drawing.Point(720, 148);
            this.TitleZoom.Name = "TitleZoom";
            this.TitleZoom.Size = new System.Drawing.Size(34, 13);
            this.TitleZoom.TabIndex = 13;
            this.TitleZoom.Text = "Zoom";
            // 
            // ValueAxisX
            // 
            this.ValueAxisX.AutoSize = true;
            this.ValueAxisX.Location = new System.Drawing.Point(531, 286);
            this.ValueAxisX.Name = "ValueAxisX";
            this.ValueAxisX.Size = new System.Drawing.Size(13, 13);
            this.ValueAxisX.TabIndex = 15;
            this.ValueAxisX.Text = "0";
            // 
            // ValueAxisY
            // 
            this.ValueAxisY.AutoSize = true;
            this.ValueAxisY.Location = new System.Drawing.Point(581, 286);
            this.ValueAxisY.Name = "ValueAxisY";
            this.ValueAxisY.Size = new System.Drawing.Size(13, 13);
            this.ValueAxisY.TabIndex = 16;
            this.ValueAxisY.Text = "0";
            // 
            // ValueAxisZ
            // 
            this.ValueAxisZ.AutoSize = true;
            this.ValueAxisZ.Location = new System.Drawing.Point(633, 286);
            this.ValueAxisZ.Name = "ValueAxisZ";
            this.ValueAxisZ.Size = new System.Drawing.Size(13, 13);
            this.ValueAxisZ.TabIndex = 17;
            this.ValueAxisZ.Text = "0";
            // 
            // RenderTimer
            // 
            this.RenderTimer.Interval = 30;
            this.RenderTimer.Tick += new System.EventHandler(this.RenderTimer_Tick);
            // 
            // WireCheckBox
            // 
            this.WireCheckBox.AutoSize = true;
            this.WireCheckBox.Location = new System.Drawing.Point(519, 118);
            this.WireCheckBox.Name = "WireCheckBox";
            this.WireCheckBox.Size = new System.Drawing.Size(75, 17);
            this.WireCheckBox.TabIndex = 18;
            this.WireCheckBox.Text = "Сеточный";
            this.WireCheckBox.UseVisualStyleBackColor = true;
            this.WireCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ValueAngle
            // 
            this.ValueAngle.AutoSize = true;
            this.ValueAngle.Location = new System.Drawing.Point(681, 286);
            this.ValueAngle.Name = "ValueAngle";
            this.ValueAngle.Size = new System.Drawing.Size(13, 13);
            this.ValueAngle.TabIndex = 19;
            this.ValueAngle.Text = "0";
            // 
            // ValueZoom
            // 
            this.ValueZoom.AutoSize = true;
            this.ValueZoom.Location = new System.Drawing.Point(732, 286);
            this.ValueZoom.Name = "ValueZoom";
            this.ValueZoom.Size = new System.Drawing.Size(13, 13);
            this.ValueZoom.TabIndex = 20;
            this.ValueZoom.Text = "0";
            // 
            // AutoRotateCheckBox
            // 
            this.AutoRotateCheckBox.AutoSize = true;
            this.AutoRotateCheckBox.Location = new System.Drawing.Point(507, 355);
            this.AutoRotateCheckBox.Name = "AutoRotateCheckBox";
            this.AutoRotateCheckBox.Size = new System.Drawing.Size(78, 17);
            this.AutoRotateCheckBox.TabIndex = 21;
            this.AutoRotateCheckBox.Text = "Вращение";
            this.AutoRotateCheckBox.UseVisualStyleBackColor = true;
            // 
            // AutoRotateXTrackBar
            // 
            this.AutoRotateXTrackBar.Location = new System.Drawing.Point(537, 378);
            this.AutoRotateXTrackBar.Maximum = 360;
            this.AutoRotateXTrackBar.Minimum = -360;
            this.AutoRotateXTrackBar.Name = "AutoRotateXTrackBar";
            this.AutoRotateXTrackBar.Size = new System.Drawing.Size(189, 45);
            this.AutoRotateXTrackBar.TabIndex = 22;
            this.AutoRotateXTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.AutoRotateXTrackBar.Scroll += new System.EventHandler(this.AutoRotateXTrackBar_Scroll);
            // 
            // AutoRotateXLabel
            // 
            this.AutoRotateXLabel.AutoSize = true;
            this.AutoRotateXLabel.Location = new System.Drawing.Point(515, 388);
            this.AutoRotateXLabel.Name = "AutoRotateXLabel";
            this.AutoRotateXLabel.Size = new System.Drawing.Size(14, 13);
            this.AutoRotateXLabel.TabIndex = 23;
            this.AutoRotateXLabel.Text = "X";
            // 
            // ValueAutoRotateXLabel
            // 
            this.ValueAutoRotateXLabel.AutoSize = true;
            this.ValueAutoRotateXLabel.Location = new System.Drawing.Point(732, 388);
            this.ValueAutoRotateXLabel.Name = "ValueAutoRotateXLabel";
            this.ValueAutoRotateXLabel.Size = new System.Drawing.Size(13, 13);
            this.ValueAutoRotateXLabel.TabIndex = 24;
            this.ValueAutoRotateXLabel.Text = "0";
            // 
            // ValueAutoRotateYLabel
            // 
            this.ValueAutoRotateYLabel.AutoSize = true;
            this.ValueAutoRotateYLabel.Location = new System.Drawing.Point(732, 428);
            this.ValueAutoRotateYLabel.Name = "ValueAutoRotateYLabel";
            this.ValueAutoRotateYLabel.Size = new System.Drawing.Size(13, 13);
            this.ValueAutoRotateYLabel.TabIndex = 27;
            this.ValueAutoRotateYLabel.Text = "0";
            // 
            // AutoRotateYLabel
            // 
            this.AutoRotateYLabel.AutoSize = true;
            this.AutoRotateYLabel.Location = new System.Drawing.Point(515, 428);
            this.AutoRotateYLabel.Name = "AutoRotateYLabel";
            this.AutoRotateYLabel.Size = new System.Drawing.Size(14, 13);
            this.AutoRotateYLabel.TabIndex = 26;
            this.AutoRotateYLabel.Text = "Y";
            // 
            // AutoRotateYTrackBar
            // 
            this.AutoRotateYTrackBar.Location = new System.Drawing.Point(537, 418);
            this.AutoRotateYTrackBar.Maximum = 360;
            this.AutoRotateYTrackBar.Minimum = -360;
            this.AutoRotateYTrackBar.Name = "AutoRotateYTrackBar";
            this.AutoRotateYTrackBar.Size = new System.Drawing.Size(189, 45);
            this.AutoRotateYTrackBar.TabIndex = 25;
            this.AutoRotateYTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.AutoRotateYTrackBar.Scroll += new System.EventHandler(this.AutoRotateYTrackBar_Scroll);
            // 
            // ValueAutoRotateZLabel
            // 
            this.ValueAutoRotateZLabel.AutoSize = true;
            this.ValueAutoRotateZLabel.Location = new System.Drawing.Point(732, 469);
            this.ValueAutoRotateZLabel.Name = "ValueAutoRotateZLabel";
            this.ValueAutoRotateZLabel.Size = new System.Drawing.Size(13, 13);
            this.ValueAutoRotateZLabel.TabIndex = 30;
            this.ValueAutoRotateZLabel.Text = "0";
            // 
            // AutoRotateZLabel
            // 
            this.AutoRotateZLabel.AutoSize = true;
            this.AutoRotateZLabel.Location = new System.Drawing.Point(515, 469);
            this.AutoRotateZLabel.Name = "AutoRotateZLabel";
            this.AutoRotateZLabel.Size = new System.Drawing.Size(14, 13);
            this.AutoRotateZLabel.TabIndex = 29;
            this.AutoRotateZLabel.Text = "Z";
            // 
            // AutoRotateZTrackBar
            // 
            this.AutoRotateZTrackBar.Location = new System.Drawing.Point(537, 459);
            this.AutoRotateZTrackBar.Maximum = 360;
            this.AutoRotateZTrackBar.Minimum = -360;
            this.AutoRotateZTrackBar.Name = "AutoRotateZTrackBar";
            this.AutoRotateZTrackBar.Size = new System.Drawing.Size(189, 45);
            this.AutoRotateZTrackBar.TabIndex = 28;
            this.AutoRotateZTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.AutoRotateZTrackBar.Scroll += new System.EventHandler(this.AutoRotateZTrackBar_Scroll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 516);
            this.Controls.Add(this.ValueAutoRotateZLabel);
            this.Controls.Add(this.AutoRotateZLabel);
            this.Controls.Add(this.AutoRotateZTrackBar);
            this.Controls.Add(this.ValueAutoRotateYLabel);
            this.Controls.Add(this.AutoRotateYLabel);
            this.Controls.Add(this.AutoRotateYTrackBar);
            this.Controls.Add(this.ValueAutoRotateXLabel);
            this.Controls.Add(this.AutoRotateXLabel);
            this.Controls.Add(this.AutoRotateXTrackBar);
            this.Controls.Add(this.AutoRotateCheckBox);
            this.Controls.Add(this.ValueZoom);
            this.Controls.Add(this.ValueAngle);
            this.Controls.Add(this.WireCheckBox);
            this.Controls.Add(this.ValueAxisZ);
            this.Controls.Add(this.ValueAxisY);
            this.Controls.Add(this.ValueAxisX);
            this.Controls.Add(this.TrackBarZoom);
            this.Controls.Add(this.TitleZoom);
            this.Controls.Add(this.TrackBarAngle);
            this.Controls.Add(this.TitleAngle);
            this.Controls.Add(this.TrackBarAxisZ);
            this.Controls.Add(this.TitleAxisZ);
            this.Controls.Add(this.TrackBarAxisY);
            this.Controls.Add(this.TitleAxisY);
            this.Controls.Add(this.TrackBarAxisX);
            this.Controls.Add(this.TitleAxisX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ObjectComboBox);
            this.Controls.Add(this.AxisComboBox);
            this.Controls.Add(this.AnT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Преобразование 3D примитивов";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarAxisX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarAxisY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarAxisZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoRotateXTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoRotateYTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoRotateZTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.ComboBox AxisComboBox;
        private System.Windows.Forms.ComboBox ObjectComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TitleAxisX;
        private System.Windows.Forms.TrackBar TrackBarAxisX;
        private System.Windows.Forms.TrackBar TrackBarAxisY;
        private System.Windows.Forms.Label TitleAxisY;
        private System.Windows.Forms.TrackBar TrackBarAxisZ;
        private System.Windows.Forms.Label TitleAxisZ;
        private System.Windows.Forms.TrackBar TrackBarAngle;
        private System.Windows.Forms.Label TitleAngle;
        private System.Windows.Forms.TrackBar TrackBarZoom;
        private System.Windows.Forms.Label TitleZoom;
        private System.Windows.Forms.Label ValueAxisX;
        private System.Windows.Forms.Label ValueAxisY;
        private System.Windows.Forms.Label ValueAxisZ;
        private System.Windows.Forms.Timer RenderTimer;
        private System.Windows.Forms.CheckBox WireCheckBox;
        private System.Windows.Forms.Label ValueAngle;
        private System.Windows.Forms.Label ValueZoom;
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
    }
}

