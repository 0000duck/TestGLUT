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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ValueAngle = new System.Windows.Forms.Label();
            this.ValueZoom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarAxisX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarAxisY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarAxisZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarZoom)).BeginInit();
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
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Вращать вдоль X",
            "Вращать вдоль Y",
            "Вращать вдоль Z"});
            this.comboBox1.Location = new System.Drawing.Point(519, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Сфера",
            "Цилиндр",
            "Куб",
            "Конус",
            "Тор"});
            this.comboBox2.Location = new System.Drawing.Point(519, 90);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(247, 21);
            this.comboBox2.TabIndex = 2;
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
            this.TrackBarAxisX.Size = new System.Drawing.Size(45, 329);
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
            this.TrackBarAxisY.Size = new System.Drawing.Size(45, 329);
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
            this.TrackBarAxisZ.Size = new System.Drawing.Size(45, 329);
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
            this.TrackBarAngle.Size = new System.Drawing.Size(45, 329);
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
            this.TrackBarZoom.Size = new System.Drawing.Size(45, 329);
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
            this.ValueAxisX.Location = new System.Drawing.Point(530, 496);
            this.ValueAxisX.Name = "ValueAxisX";
            this.ValueAxisX.Size = new System.Drawing.Size(13, 13);
            this.ValueAxisX.TabIndex = 15;
            this.ValueAxisX.Text = "0";
            // 
            // ValueAxisY
            // 
            this.ValueAxisY.AutoSize = true;
            this.ValueAxisY.Location = new System.Drawing.Point(580, 496);
            this.ValueAxisY.Name = "ValueAxisY";
            this.ValueAxisY.Size = new System.Drawing.Size(13, 13);
            this.ValueAxisY.TabIndex = 16;
            this.ValueAxisY.Text = "0";
            // 
            // ValueAxisZ
            // 
            this.ValueAxisZ.AutoSize = true;
            this.ValueAxisZ.Location = new System.Drawing.Point(632, 496);
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(519, 118);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Сеточный";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ValueAngle
            // 
            this.ValueAngle.AutoSize = true;
            this.ValueAngle.Location = new System.Drawing.Point(680, 496);
            this.ValueAngle.Name = "ValueAngle";
            this.ValueAngle.Size = new System.Drawing.Size(13, 13);
            this.ValueAngle.TabIndex = 19;
            this.ValueAngle.Text = "0";
            // 
            // ValueZoom
            // 
            this.ValueZoom.AutoSize = true;
            this.ValueZoom.Location = new System.Drawing.Point(731, 496);
            this.ValueZoom.Name = "ValueZoom";
            this.ValueZoom.Size = new System.Drawing.Size(13, 13);
            this.ValueZoom.TabIndex = 20;
            this.ValueZoom.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 516);
            this.Controls.Add(this.ValueZoom);
            this.Controls.Add(this.ValueAngle);
            this.Controls.Add(this.checkBox1);
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
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label ValueAngle;
        private System.Windows.Forms.Label ValueZoom;
    }
}

