namespace circles
{
    partial class Circles
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Circles));
            this.panelTools = new System.Windows.Forms.Panel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.numericUpDownIncrement = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRadius = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownInterval = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelScale = new System.Windows.Forms.Label();
            this.numericUpDownScale = new System.Windows.Forms.NumericUpDown();
            this.panelWorkSpace = new System.Windows.Forms.Panel();
            this.panelDrawBox = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncrement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScale)).BeginInit();
            this.panelWorkSpace.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTools
            // 
            this.panelTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTools.Controls.Add(this.button1);
            this.panelTools.Controls.Add(this.buttonRefresh);
            this.panelTools.Controls.Add(this.numericUpDownIncrement);
            this.panelTools.Controls.Add(this.numericUpDownRadius);
            this.panelTools.Controls.Add(this.numericUpDownInterval);
            this.panelTools.Controls.Add(this.numericUpDownHeight);
            this.panelTools.Controls.Add(this.numericUpDownWidth);
            this.panelTools.Controls.Add(this.label5);
            this.panelTools.Controls.Add(this.label4);
            this.panelTools.Controls.Add(this.label3);
            this.panelTools.Controls.Add(this.label2);
            this.panelTools.Controls.Add(this.label1);
            this.panelTools.Location = new System.Drawing.Point(1, 0);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(682, 29);
            this.panelTools.TabIndex = 0;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(555, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 6;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // numericUpDownIncrement
            // 
            this.numericUpDownIncrement.DecimalPlaces = 2;
            this.numericUpDownIncrement.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownIncrement.Location = new System.Drawing.Point(502, 3);
            this.numericUpDownIncrement.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownIncrement.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.numericUpDownIncrement.Name = "numericUpDownIncrement";
            this.numericUpDownIncrement.Size = new System.Drawing.Size(47, 20);
            this.numericUpDownIncrement.TabIndex = 5;
            this.numericUpDownIncrement.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // numericUpDownRadius
            // 
            this.numericUpDownRadius.Location = new System.Drawing.Point(373, 3);
            this.numericUpDownRadius.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownRadius.Name = "numericUpDownRadius";
            this.numericUpDownRadius.Size = new System.Drawing.Size(47, 20);
            this.numericUpDownRadius.TabIndex = 5;
            this.numericUpDownRadius.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // numericUpDownInterval
            // 
            this.numericUpDownInterval.Location = new System.Drawing.Point(273, 3);
            this.numericUpDownInterval.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownInterval.Name = "numericUpDownInterval";
            this.numericUpDownInterval.Size = new System.Drawing.Size(47, 20);
            this.numericUpDownInterval.TabIndex = 5;
            this.numericUpDownInterval.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Location = new System.Drawing.Point(158, 3);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(47, 20);
            this.numericUpDownHeight.TabIndex = 5;
            this.numericUpDownHeight.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(52, 3);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(47, 20);
            this.numericUpDownWidth.TabIndex = 5;
            this.numericUpDownWidth.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Приращение:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Радиус:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Интервал:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Высота:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ширина:";
            // 
            // labelScale
            // 
            this.labelScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScale.AutoSize = true;
            this.labelScale.Location = new System.Drawing.Point(567, 468);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(56, 13);
            this.labelScale.TabIndex = 2;
            this.labelScale.Text = "Масштаб:";
            // 
            // numericUpDownScale
            // 
            this.numericUpDownScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownScale.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownScale.Location = new System.Drawing.Point(625, 465);
            this.numericUpDownScale.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numericUpDownScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownScale.Name = "numericUpDownScale";
            this.numericUpDownScale.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownScale.TabIndex = 3;
            this.numericUpDownScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownScale.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // panelWorkSpace
            // 
            this.panelWorkSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWorkSpace.AutoScroll = true;
            this.panelWorkSpace.BackColor = System.Drawing.Color.Black;
            this.panelWorkSpace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelWorkSpace.Controls.Add(this.panelDrawBox);
            this.panelWorkSpace.Location = new System.Drawing.Point(1, 29);
            this.panelWorkSpace.Name = "panelWorkSpace";
            this.panelWorkSpace.Size = new System.Drawing.Size(682, 434);
            this.panelWorkSpace.TabIndex = 1;
            // 
            // panelDrawBox
            // 
            this.panelDrawBox.BackColor = System.Drawing.Color.Transparent;
            this.panelDrawBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelDrawBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDrawBox.Location = new System.Drawing.Point(0, 0);
            this.panelDrawBox.Name = "panelDrawBox";
            this.panelDrawBox.Size = new System.Drawing.Size(626, 390);
            this.panelDrawBox.TabIndex = 0;
            this.panelDrawBox.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDrawBox_Paint);
            // 
            // button1
            // 
            this.button1.Image = global::circles.Properties.Resources.save;
            this.button1.Location = new System.Drawing.Point(637, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 23);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Circles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 487);
            this.Controls.Add(this.numericUpDownScale);
            this.Controls.Add(this.labelScale);
            this.Controls.Add(this.panelWorkSpace);
            this.Controls.Add(this.panelTools);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Circles";
            this.Text = "Circles";
            this.panelTools.ResumeLayout(false);
            this.panelTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncrement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScale)).EndInit();
            this.panelWorkSpace.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.Panel panelWorkSpace;
        private System.Windows.Forms.Panel panelDrawBox;
        private System.Windows.Forms.NumericUpDown numericUpDownIncrement;
        private System.Windows.Forms.NumericUpDown numericUpDownRadius;
        private System.Windows.Forms.NumericUpDown numericUpDownInterval;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.NumericUpDown numericUpDownScale;
    }
}

