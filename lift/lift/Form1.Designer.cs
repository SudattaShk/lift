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
            this.UpButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.TimerUp = new System.Windows.Forms.Timer(this.components);
            this.TimerDown = new System.Windows.Forms.Timer(this.components);
            this.First_Right_Door = new System.Windows.Forms.PictureBox();
            this.First_Left_Door = new System.Windows.Forms.PictureBox();
            this.first_inside = new System.Windows.Forms.PictureBox();
            this.first_frame = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Ground_Right_Door = new System.Windows.Forms.PictureBox();
            this.Ground_Left_Door = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OpenButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.TimerOpen = new System.Windows.Forms.Timer(this.components);
            this.TimerClose = new System.Windows.Forms.Timer(this.components);
            this.RequestGroundButton = new System.Windows.Forms.Button();
            this.databaseTable = new System.Windows.Forms.DataGridView();
            this.log = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DisplayMain = new System.Windows.Forms.PictureBox();
            this.SmallDisplay2 = new System.Windows.Forms.PictureBox();
            this.SmallDisplay1 = new System.Windows.Forms.PictureBox();
            this.RequestFirst = new System.Windows.Forms.Button();
            this.TimerGroundRequest = new System.Windows.Forms.Timer(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.databaseTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmallDisplay2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmallDisplay1)).BeginInit();
            this.SuspendLayout();
            // 
            // lift
            // 
            this.lift.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lift.Image = global::lift.Properties.Resources.inside_lift;
            this.lift.Location = new System.Drawing.Point(272, 75);
            this.lift.Name = "lift";
            this.lift.Size = new System.Drawing.Size(174, 351);
            this.lift.TabIndex = 0;
            this.lift.TabStop = false;
            // 
            // UpButton
            // 
            this.UpButton.Image = ((System.Drawing.Image)(resources.GetObject("UpButton.Image")));
            this.UpButton.Location = new System.Drawing.Point(824, 463);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(106, 106);
            this.UpButton.TabIndex = 1;
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.buttonup_Click);
            // 
            // DownButton
            // 
            this.DownButton.Image = ((System.Drawing.Image)(resources.GetObject("DownButton.Image")));
            this.DownButton.Location = new System.Drawing.Point(824, 621);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(106, 106);
            this.DownButton.TabIndex = 2;
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.buttondown_Click);
            // 
            // TimerUp
            // 
            this.TimerUp.Interval = 20;
            this.TimerUp.Tick += new System.EventHandler(this.TimerUp_Tick);
            // 
            // TimerDown
            // 
            this.TimerDown.Interval = 20;
            this.TimerDown.Tick += new System.EventHandler(this.timerdown_Tick);
            // 
            // First_Right_Door
            // 
            this.First_Right_Door.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.First_Right_Door.Image = global::lift.Properties.Resources.right_door;
            this.First_Right_Door.Location = new System.Drawing.Point(357, 72);
            this.First_Right_Door.Name = "First_Right_Door";
            this.First_Right_Door.Size = new System.Drawing.Size(80, 420);
            this.First_Right_Door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.First_Right_Door.TabIndex = 9;
            this.First_Right_Door.TabStop = false;
            // 
            // First_Left_Door
            // 
            this.First_Left_Door.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.First_Left_Door.Image = global::lift.Properties.Resources.left_door;
            this.First_Left_Door.Location = new System.Drawing.Point(280, 72);
            this.First_Left_Door.Name = "First_Left_Door";
            this.First_Left_Door.Size = new System.Drawing.Size(80, 420);
            this.First_Left_Door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.First_Left_Door.TabIndex = 10;
            this.First_Left_Door.TabStop = false;
            // 
            // first_inside
            // 
            this.first_inside.Image = ((System.Drawing.Image)(resources.GetObject("first_inside.Image")));
            this.first_inside.Location = new System.Drawing.Point(272, 585);
            this.first_inside.Name = "first_inside";
            this.first_inside.Size = new System.Drawing.Size(174, 437);
            this.first_inside.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.first_inside.TabIndex = 7;
            this.first_inside.TabStop = false;
            // 
            // first_frame
            // 
            this.first_frame.Image = global::lift.Properties.Resources.closed_door_frame;
            this.first_frame.Location = new System.Drawing.Point(234, 11);
            this.first_frame.Name = "first_frame";
            this.first_frame.Size = new System.Drawing.Size(250, 481);
            this.first_frame.TabIndex = 8;
            this.first_frame.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(281, 601);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(156, 421);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::lift.Properties.Resources.closed_door_frame;
            this.pictureBox4.Location = new System.Drawing.Point(234, 540);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(250, 481);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // Ground_Right_Door
            // 
            this.Ground_Right_Door.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ground_Right_Door.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ground_Right_Door.Image = global::lift.Properties.Resources.right_door;
            this.Ground_Right_Door.Location = new System.Drawing.Point(357, 602);
            this.Ground_Right_Door.Name = "Ground_Right_Door";
            this.Ground_Right_Door.Size = new System.Drawing.Size(80, 420);
            this.Ground_Right_Door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground_Right_Door.TabIndex = 15;
            this.Ground_Right_Door.TabStop = false;
            // 
            // Ground_Left_Door
            // 
            this.Ground_Left_Door.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ground_Left_Door.Image = global::lift.Properties.Resources.left_door;
            this.Ground_Left_Door.Location = new System.Drawing.Point(280, 602);
            this.Ground_Left_Door.Name = "Ground_Left_Door";
            this.Ground_Left_Door.Size = new System.Drawing.Size(80, 420);
            this.Ground_Left_Door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground_Left_Door.TabIndex = 16;
            this.Ground_Left_Door.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::lift.Properties.Resources.inside_door;
            this.pictureBox1.Location = new System.Drawing.Point(280, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 421);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // OpenButton
            // 
            this.OpenButton.Image = global::lift.Properties.Resources.open;
            this.OpenButton.Location = new System.Drawing.Point(721, 794);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(106, 106);
            this.OpenButton.TabIndex = 18;
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Image = global::lift.Properties.Resources.close;
            this.CloseButton.Location = new System.Drawing.Point(923, 794);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(106, 106);
            this.CloseButton.TabIndex = 19;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TimerOpen
            // 
            this.TimerOpen.Interval = 1;
            this.TimerOpen.Tick += new System.EventHandler(this.timeropen_Tick);
            // 
            // TimerClose
            // 
            this.TimerClose.Interval = 1;
            this.TimerClose.Tick += new System.EventHandler(this.timerclose_Tick);
            // 
            // RequestGroundButton
            // 
            this.RequestGroundButton.BackgroundImage = global::lift.Properties.Resources.unlitlit_call_down;
            this.RequestGroundButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RequestGroundButton.Location = new System.Drawing.Point(490, 752);
            this.RequestGroundButton.Name = "RequestGroundButton";
            this.RequestGroundButton.Size = new System.Drawing.Size(60, 60);
            this.RequestGroundButton.TabIndex = 20;
            this.RequestGroundButton.UseVisualStyleBackColor = true;

            // 
            // databaseTable
            // 
            this.databaseTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.databaseTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.databaseTable.Location = new System.Drawing.Point(1158, 72);
            this.databaseTable.Name = "databaseTable";
            this.databaseTable.RowHeadersWidth = 51;
            this.databaseTable.RowTemplate.Height = 29;
            this.databaseTable.Size = new System.Drawing.Size(694, 474);
            this.databaseTable.TabIndex = 22;
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.SystemColors.Highlight;
            this.log.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.log.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.log.Location = new System.Drawing.Point(1158, 585);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(196, 49);
            this.log.TabIndex = 24;
            this.log.Text = "Show Log";
            this.log.UseVisualStyleBackColor = false;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(490, 658);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 27);
            this.label1.TabIndex = 25;
            this.label1.Text = "GROUND FLOOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(490, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 27);
            this.label2.TabIndex = 26;
            this.label2.Text = "FIRST FLOOR";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::lift.Properties.Resources.metallic_textured_background;
            this.pictureBox2.Location = new System.Drawing.Point(699, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(354, 786);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // DisplayMain
            // 
            this.DisplayMain.Image = global::lift.Properties.Resources.display1;
            this.DisplayMain.Location = new System.Drawing.Point(721, 177);
            this.DisplayMain.Name = "DisplayMain";
            this.DisplayMain.Size = new System.Drawing.Size(308, 231);
            this.DisplayMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DisplayMain.TabIndex = 28;
            this.DisplayMain.TabStop = false;
            // 
            // SmallDisplay2
            // 
            this.SmallDisplay2.Image = global::lift.Properties.Resources.display1;
            this.SmallDisplay2.Location = new System.Drawing.Point(490, 585);
            this.SmallDisplay2.Name = "SmallDisplay2";
            this.SmallDisplay2.Size = new System.Drawing.Size(106, 73);
            this.SmallDisplay2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SmallDisplay2.TabIndex = 29;
            this.SmallDisplay2.TabStop = false;
            // 
            // SmallDisplay1
            // 
            this.SmallDisplay1.Image = global::lift.Properties.Resources.display1;
            this.SmallDisplay1.Location = new System.Drawing.Point(490, 52);
            this.SmallDisplay1.Name = "SmallDisplay1";
            this.SmallDisplay1.Size = new System.Drawing.Size(106, 73);
            this.SmallDisplay1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SmallDisplay1.TabIndex = 30;
            this.SmallDisplay1.TabStop = false;
            // 
            // RequestFirst
            // 
            this.RequestFirst.BackgroundImage = global::lift.Properties.Resources.unlitlit_call_up;
            this.RequestFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RequestFirst.Location = new System.Drawing.Point(490, 226);
            this.RequestFirst.Name = "RequestFirst";
            this.RequestFirst.Size = new System.Drawing.Size(60, 60);
            this.RequestFirst.TabIndex = 21;
            this.RequestFirst.UseVisualStyleBackColor = true;
            // 
            // TimerGroundRequest
            // 
            this.TimerGroundRequest.Interval = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::lift.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.SmallDisplay1);
            this.Controls.Add(this.SmallDisplay2);
            this.Controls.Add(this.DisplayMain);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.UpButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.log);
            this.Controls.Add(this.databaseTable);
            this.Controls.Add(this.RequestFirst);
            this.Controls.Add(this.RequestGroundButton);
            this.Controls.Add(this.First_Left_Door);
            this.Controls.Add(this.First_Right_Door);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Ground_Left_Door);
            this.Controls.Add(this.Ground_Right_Door);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.first_inside);
            this.Controls.Add(this.first_frame);
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
            ((System.ComponentModel.ISupportInitialize)(this.databaseTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmallDisplay2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmallDisplay1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox lift;
        private Button UpButton;
        private Button DownButton;
        private System.Windows.Forms.Timer TimerUp;
        private System.Windows.Forms.Timer TimerDown;
        private PictureBox First_Right_Door;
        private PictureBox First_Left_Door;
        private PictureBox first_inside;
        private PictureBox first_frame;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox Ground_Right_Door;
        private PictureBox Ground_Left_Door;
        private PictureBox pictureBox1;
        private Button OpenButton;
        private Button CloseButton;
        private System.Windows.Forms.Timer TimerOpen;
        private System.Windows.Forms.Timer TimerClose;
        private Button RequestGroundButton;
        private DataGridView databaseTable;
        private Button log;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox DisplayMain;
        private PictureBox SmallDisplay2;
        private PictureBox SmallDisplay1;
        private Button RequestFirst;
        private System.Windows.Forms.Timer TimerGroundRequest;
    }
}