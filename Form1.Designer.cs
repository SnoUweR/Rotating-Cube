namespace RotatingIsometricCube
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.playAnimBtn = new System.Windows.Forms.Button();
            this.nextStepBtn = new System.Windows.Forms.Button();
            this.forwardAnimBtn = new System.Windows.Forms.Button();
            this.backwardAnimBtn = new System.Windows.Forms.Button();
            this.previousStepBtn = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.zRadioBtn = new System.Windows.Forms.RadioButton();
            this.yRadioBtn = new System.Windows.Forms.RadioButton();
            this.xRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.depthUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.heightUpDown = new System.Windows.Forms.NumericUpDown();
            this.widthUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.speedUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 474);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 476);
            this.panel1.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(111, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Z";
            this.label10.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(111, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Y";
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(108, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "X";
            this.label8.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Угол: 90";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "X: 0 Y: 0";
            // 
            // playAnimBtn
            // 
            this.playAnimBtn.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.playAnimBtn.Location = new System.Drawing.Point(89, 29);
            this.playAnimBtn.Name = "playAnimBtn";
            this.playAnimBtn.Size = new System.Drawing.Size(36, 36);
            this.playAnimBtn.TabIndex = 3;
            this.playAnimBtn.Text = "4";
            this.playAnimBtn.UseVisualStyleBackColor = true;
            this.playAnimBtn.Click += new System.EventHandler(this.playAnimBtn_Click);
            // 
            // nextStepBtn
            // 
            this.nextStepBtn.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.nextStepBtn.Location = new System.Drawing.Point(131, 29);
            this.nextStepBtn.Name = "nextStepBtn";
            this.nextStepBtn.Size = new System.Drawing.Size(36, 36);
            this.nextStepBtn.TabIndex = 4;
            this.nextStepBtn.Text = "8";
            this.nextStepBtn.UseVisualStyleBackColor = true;
            this.nextStepBtn.Click += new System.EventHandler(this.nextStepBtn_Click);
            // 
            // forwardAnimBtn
            // 
            this.forwardAnimBtn.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.forwardAnimBtn.Location = new System.Drawing.Point(173, 29);
            this.forwardAnimBtn.Name = "forwardAnimBtn";
            this.forwardAnimBtn.Size = new System.Drawing.Size(36, 36);
            this.forwardAnimBtn.TabIndex = 5;
            this.forwardAnimBtn.Text = ":";
            this.forwardAnimBtn.UseVisualStyleBackColor = true;
            this.forwardAnimBtn.Click += new System.EventHandler(this.forwardAnimBtn_Click);
            // 
            // backwardAnimBtn
            // 
            this.backwardAnimBtn.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.backwardAnimBtn.Location = new System.Drawing.Point(6, 29);
            this.backwardAnimBtn.Name = "backwardAnimBtn";
            this.backwardAnimBtn.Size = new System.Drawing.Size(36, 36);
            this.backwardAnimBtn.TabIndex = 6;
            this.backwardAnimBtn.Text = "9";
            this.backwardAnimBtn.UseVisualStyleBackColor = true;
            this.backwardAnimBtn.Click += new System.EventHandler(this.backwardAnimBtn_Click);
            // 
            // previousStepBtn
            // 
            this.previousStepBtn.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.previousStepBtn.Location = new System.Drawing.Point(47, 29);
            this.previousStepBtn.Name = "previousStepBtn";
            this.previousStepBtn.Size = new System.Drawing.Size(36, 36);
            this.previousStepBtn.TabIndex = 7;
            this.previousStepBtn.Text = "7";
            this.previousStepBtn.UseVisualStyleBackColor = true;
            this.previousStepBtn.Click += new System.EventHandler(this.previousStepBtn_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.resetBtn);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(866, 476);
            this.splitContainer1.SplitterDistance = 642;
            this.splitContainer1.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.zRadioBtn);
            this.groupBox4.Controls.Add(this.yRadioBtn);
            this.groupBox4.Controls.Add(this.xRadioBtn);
            this.groupBox4.Location = new System.Drawing.Point(3, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(215, 60);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ось вращения";
            // 
            // zRadioBtn
            // 
            this.zRadioBtn.AutoSize = true;
            this.zRadioBtn.Checked = true;
            this.zRadioBtn.Location = new System.Drawing.Point(89, 14);
            this.zRadioBtn.Name = "zRadioBtn";
            this.zRadioBtn.Size = new System.Drawing.Size(32, 17);
            this.zRadioBtn.TabIndex = 2;
            this.zRadioBtn.TabStop = true;
            this.zRadioBtn.Text = "Z";
            this.zRadioBtn.UseVisualStyleBackColor = true;
            this.zRadioBtn.CheckedChanged += new System.EventHandler(this.zRadioBtn_CheckedChanged);
            // 
            // yRadioBtn
            // 
            this.yRadioBtn.AutoSize = true;
            this.yRadioBtn.Location = new System.Drawing.Point(47, 14);
            this.yRadioBtn.Name = "yRadioBtn";
            this.yRadioBtn.Size = new System.Drawing.Size(32, 17);
            this.yRadioBtn.TabIndex = 1;
            this.yRadioBtn.Text = "Y";
            this.yRadioBtn.UseVisualStyleBackColor = true;
            this.yRadioBtn.CheckedChanged += new System.EventHandler(this.yRadioBtn_CheckedChanged);
            // 
            // xRadioBtn
            // 
            this.xRadioBtn.AutoSize = true;
            this.xRadioBtn.Location = new System.Drawing.Point(7, 14);
            this.xRadioBtn.Name = "xRadioBtn";
            this.xRadioBtn.Size = new System.Drawing.Size(32, 17);
            this.xRadioBtn.TabIndex = 0;
            this.xRadioBtn.Text = "X";
            this.xRadioBtn.UseVisualStyleBackColor = true;
            this.xRadioBtn.CheckedChanged += new System.EventHandler(this.xRadioBtn_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(3, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(214, 152);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "О программе";
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 133);
            this.label7.TabIndex = 10;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(4, 447);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(213, 23);
            this.resetBtn.TabIndex = 8;
            this.resetBtn.Text = "Сброс";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.depthUpDown);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.heightUpDown);
            this.groupBox2.Controls.Add(this.widthUpDown);
            this.groupBox2.Location = new System.Drawing.Point(3, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 111);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление размерами";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Глубина";
            // 
            // depthUpDown
            // 
            this.depthUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.depthUpDown.Location = new System.Drawing.Point(6, 72);
            this.depthUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.depthUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.depthUpDown.Name = "depthUpDown";
            this.depthUpDown.Size = new System.Drawing.Size(120, 20);
            this.depthUpDown.TabIndex = 4;
            this.depthUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.depthUpDown.ValueChanged += new System.EventHandler(this.depthUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Высота";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ширина";
            // 
            // heightUpDown
            // 
            this.heightUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.heightUpDown.Location = new System.Drawing.Point(6, 46);
            this.heightUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.heightUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.heightUpDown.Name = "heightUpDown";
            this.heightUpDown.Size = new System.Drawing.Size(120, 20);
            this.heightUpDown.TabIndex = 1;
            this.heightUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.heightUpDown.ValueChanged += new System.EventHandler(this.heightUpDown_ValueChanged);
            // 
            // widthUpDown
            // 
            this.widthUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.widthUpDown.Location = new System.Drawing.Point(6, 20);
            this.widthUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.widthUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthUpDown.Name = "widthUpDown";
            this.widthUpDown.Size = new System.Drawing.Size(120, 20);
            this.widthUpDown.TabIndex = 0;
            this.widthUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthUpDown.ValueChanged += new System.EventHandler(this.widthUpDown_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.speedUpDown);
            this.groupBox1.Controls.Add(this.forwardAnimBtn);
            this.groupBox1.Controls.Add(this.nextStepBtn);
            this.groupBox1.Controls.Add(this.previousStepBtn);
            this.groupBox1.Controls.Add(this.backwardAnimBtn);
            this.groupBox1.Controls.Add(this.playAnimBtn);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 103);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление анимацией";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Скорость (пикс/с)";
            // 
            // speedUpDown
            // 
            this.speedUpDown.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.speedUpDown.Location = new System.Drawing.Point(6, 71);
            this.speedUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.speedUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speedUpDown.Name = "speedUpDown";
            this.speedUpDown.Size = new System.Drawing.Size(94, 20);
            this.speedUpDown.TabIndex = 6;
            this.speedUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speedUpDown.ValueChanged += new System.EventHandler(this.speedUpDown_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 476);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Невероятное вращение изометрического кубика";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button playAnimBtn;
        private System.Windows.Forms.Button nextStepBtn;
        private System.Windows.Forms.Button forwardAnimBtn;
        private System.Windows.Forms.Button backwardAnimBtn;
        private System.Windows.Forms.Button previousStepBtn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown heightUpDown;
        private System.Windows.Forms.NumericUpDown widthUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown depthUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown speedUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton zRadioBtn;
        private System.Windows.Forms.RadioButton yRadioBtn;
        private System.Windows.Forms.RadioButton xRadioBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

