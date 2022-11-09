namespace lift
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lift = new System.Windows.Forms.PictureBox();
            this.buttonup = new System.Windows.Forms.Button();
            this.buttondown = new System.Windows.Forms.Button();
            this.timerup = new System.Windows.Forms.Timer(this.components);
            this.timerdown = new System.Windows.Forms.Timer(this.components);
            this.First_Right_Door = new System.Windows.Forms.PictureBox();
            this.First_Left_Door = new System.Windows.Forms.PictureBox();
            this.first_inside = new System.Windows.Forms.PictureBox();
            this.first_frame = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Ground_Right_Door = new System.Windows.Forms.PictureBox();
            this.Ground_Left_Door = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Open_Button = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.timeropen = new System.Windows.Forms.Timer(this.components);
            this.timerclose = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.First_Right_Door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.First_Left_Door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_inside)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_frame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground_Right_Door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground_Left_Door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lift
            // 
            this.lift.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lift.Image = ((System.Drawing.Image)(resources.GetObject("lift.Image")));
            this.lift.Location = new System.Drawing.Point(285, 75);
            this.lift.Name = "lift";
            this.lift.Size = new System.Drawing.Size(174, 351);
            this.lift.TabIndex = 0;
            this.lift.TabStop = false;
            // 
            // buttonup
            // 
            this.buttonup.Image = ((System.Drawing.Image)(resources.GetObject("buttonup.Image")));
            this.buttonup.Location = new System.Drawing.Point(852, 352);
            this.buttonup.Name = "buttonup";
            this.buttonup.Size = new System.Drawing.Size(106, 106);
            this.buttonup.TabIndex = 1;
            this.buttonup.UseVisualStyleBackColor = true;
            this.buttonup.Click += new System.EventHandler(this.buttonup_Click);
            // 
            // buttondown
            // 
            this.buttondown.Image = ((System.Drawing.Image)(resources.GetObject("buttondown.Image")));
            this.buttondown.Location = new System.Drawing.Point(852, 623);
            this.buttondown.Name = "buttondown";
            this.buttondown.Size = new System.Drawing.Size(106, 106);
            this.buttondown.TabIndex = 2;
            this.buttondown.UseVisualStyleBackColor = true;
            this.buttondown.Click += new System.EventHandler(this.buttondown_Click);
            // 
            // timerup
            // 
            this.timerup.Interval = 20;
            this.timerup.Tick += new System.EventHandler(this.timerup_Tick);
            // 
            // timerdown
            // 
            this.timerdown.Interval = 20;
            this.timerdown.Tick += new System.EventHandler(this.timerdown_Tick);
            // 
            // First_Right_Door
            // 
            this.First_Right_Door.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.First_Right_Door.Image = ((System.Drawing.Image)(resources.GetObject("First_Right_Door.Image")));
            this.First_Right_Door.Location = new System.Drawing.Point(370, 73);
            this.First_Right_Door.Name = "First_Right_Door";
            this.First_Right_Door.Size = new System.Drawing.Size(80, 420);
            this.First_Right_Door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.First_Right_Door.TabIndex = 9;
            this.First_Right_Door.TabStop = false;
            // 
            // First_Left_Door
            // 
            this.First_Left_Door.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.First_Left_Door.Image = ((System.Drawing.Image)(resources.GetObject("First_Left_Door.Image")));
            this.First_Left_Door.Location = new System.Drawing.Point(293, 73);
            this.First_Left_Door.Name = "First_Left_Door";
            this.First_Left_Door.Size = new System.Drawing.Size(80, 420);
            this.First_Left_Door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.First_Left_Door.TabIndex = 10;
            this.First_Left_Door.TabStop = false;
            // 
            // first_inside
            // 
            this.first_inside.Image = ((System.Drawing.Image)(resources.GetObject("first_inside.Image")));
            this.first_inside.Location = new System.Drawing.Point(285, 585);
            this.first_inside.Name = "first_inside";
            this.first_inside.Size = new System.Drawing.Size(174, 437);
            this.first_inside.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.first_inside.TabIndex = 7;
            this.first_inside.TabStop = false;
            // 
            // first_frame
            // 
            this.first_frame.Image = ((System.Drawing.Image)(resources.GetObject("first_frame.Image")));
            this.first_frame.Location = new System.Drawing.Point(247, 12);
            this.first_frame.Name = "first_frame";
            this.first_frame.Size = new System.Drawing.Size(250, 481);
            this.first_frame.TabIndex = 8;
            this.first_frame.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(294, 601);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(156, 421);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(247, 540);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(250, 481);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // Ground_Right_Door
            // 
            this.Ground_Right_Door.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ground_Right_Door.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ground_Right_Door.Image = ((System.Drawing.Image)(resources.GetObject("Ground_Right_Door.Image")));
            this.Ground_Right_Door.Location = new System.Drawing.Point(370, 601);
            this.Ground_Right_Door.Name = "Ground_Right_Door";
            this.Ground_Right_Door.Size = new System.Drawing.Size(80, 420);
            this.Ground_Right_Door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground_Right_Door.TabIndex = 15;
            this.Ground_Right_Door.TabStop = false;
            // 
            // Ground_Left_Door
            // 
            this.Ground_Left_Door.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ground_Left_Door.Image = ((System.Drawing.Image)(resources.GetObject("Ground_Left_Door.Image")));
            this.Ground_Left_Door.Location = new System.Drawing.Point(294, 601);
            this.Ground_Left_Door.Name = "Ground_Left_Door";
            this.Ground_Left_Door.Size = new System.Drawing.Size(80, 420);
            this.Ground_Left_Door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground_Left_Door.TabIndex = 16;
            this.Ground_Left_Door.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(293, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 421);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Open_Button
            // 
            this.Open_Button.Image = ((System.Drawing.Image)(resources.GetObject("Open_Button.Image")));
            this.Open_Button.Location = new System.Drawing.Point(746, 487);
            this.Open_Button.Name = "Open_Button";
            this.Open_Button.Size = new System.Drawing.Size(106, 106);
            this.Open_Button.TabIndex = 18;
            this.Open_Button.UseVisualStyleBackColor = true;
            this.Open_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(958, 487);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(106, 106);
            this.CloseButton.TabIndex = 19;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // timeropen
            // 
            this.timeropen.Interval = 1;
            this.timeropen.Tick += new System.EventHandler(this.timeropen_Tick);
            // 
            // timerclose
            // 
            this.timerclose.Interval = 1;
            this.timerclose.Tick += new System.EventHandler(this.timerclose_Tick);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(531, 753);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 106);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(556, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 106);
            this.button2.TabIndex = 21;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.Open_Button);
            this.Controls.Add(this.First_Left_Door);
            this.Controls.Add(this.First_Right_Door);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Ground_Left_Door);
            this.Controls.Add(this.Ground_Right_Door);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.first_inside);
            this.Controls.Add(this.first_frame);
            this.Controls.Add(this.buttondown);
            this.Controls.Add(this.buttonup);
            this.Controls.Add(this.lift);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.First_Right_Door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.First_Left_Door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_inside)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_frame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground_Right_Door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground_Left_Door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox lift;
        private Button buttonup;
        private Button buttondown;
        private System.Windows.Forms.Timer timerup;
        private System.Windows.Forms.Timer timerdown;
        private PictureBox First_Right_Door;
        private PictureBox First_Left_Door;
        private PictureBox first_inside;
        private PictureBox first_frame;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox Ground_Right_Door;
        private PictureBox Ground_Left_Door;
        private PictureBox pictureBox1;
        private Button Open_Button;
        private Button CloseButton;
        private System.Windows.Forms.Timer timeropen;
        private System.Windows.Forms.Timer timerclose;
        private Button button1;
        private Button button2;
    }
}