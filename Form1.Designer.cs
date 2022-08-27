namespace PaintByAxit
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
            this.panel1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ColorGreen = new System.Windows.Forms.PictureBox();
            this.ColorViolet = new System.Windows.Forms.PictureBox();
            this.ColorPurple = new System.Windows.Forms.PictureBox();
            this.ColorBlue = new System.Windows.Forms.PictureBox();
            this.ColorWhite = new System.Windows.Forms.PictureBox();
            this.ColorRed = new System.Windows.Forms.PictureBox();
            this.ColorSilver = new System.Windows.Forms.PictureBox();
            this.ColorBrown = new System.Windows.Forms.PictureBox();
            this.ColorGray = new System.Windows.Forms.PictureBox();
            this.ColorYellow = new System.Windows.Forms.PictureBox();
            this.ColorBlack = new System.Windows.Forms.PictureBox();
            this.ColorOrange = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorViolet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPurple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorWhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorSilver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBrown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorGray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorOrange)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.CausesValidation = false;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 450);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = false;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 95);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(349, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::PaintByAxit.Properties.Resources.eraser1;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(29, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::PaintByAxit.Properties.Resources.pencil;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(29, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.ColorGreen);
            this.panel3.Controls.Add(this.ColorViolet);
            this.panel3.Controls.Add(this.ColorPurple);
            this.panel3.Controls.Add(this.ColorBlue);
            this.panel3.Controls.Add(this.ColorWhite);
            this.panel3.Controls.Add(this.ColorRed);
            this.panel3.Controls.Add(this.ColorSilver);
            this.panel3.Controls.Add(this.ColorBrown);
            this.panel3.Controls.Add(this.ColorGray);
            this.panel3.Controls.Add(this.ColorYellow);
            this.panel3.Controls.Add(this.ColorBlack);
            this.panel3.Controls.Add(this.ColorOrange);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(487, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 95);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "More Color";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PaintByAxit.Properties.Resources.quangpho1;
            this.pictureBox1.Location = new System.Drawing.Point(249, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ColorGreen
            // 
            this.ColorGreen.BackColor = System.Drawing.Color.Green;
            this.ColorGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorGreen.Location = new System.Drawing.Point(193, 48);
            this.ColorGreen.Name = "ColorGreen";
            this.ColorGreen.Size = new System.Drawing.Size(30, 30);
            this.ColorGreen.TabIndex = 11;
            this.ColorGreen.TabStop = false;
            this.ColorGreen.Click += new System.EventHandler(this.ColorGreen_Click);
            // 
            // ColorViolet
            // 
            this.ColorViolet.BackColor = System.Drawing.Color.Violet;
            this.ColorViolet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorViolet.Location = new System.Drawing.Point(49, 48);
            this.ColorViolet.Name = "ColorViolet";
            this.ColorViolet.Size = new System.Drawing.Size(30, 30);
            this.ColorViolet.TabIndex = 8;
            this.ColorViolet.TabStop = false;
            this.ColorViolet.Click += new System.EventHandler(this.ColorViolet_Click);
            // 
            // ColorPurple
            // 
            this.ColorPurple.BackColor = System.Drawing.Color.Purple;
            this.ColorPurple.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorPurple.Location = new System.Drawing.Point(121, 48);
            this.ColorPurple.Name = "ColorPurple";
            this.ColorPurple.Size = new System.Drawing.Size(30, 30);
            this.ColorPurple.TabIndex = 9;
            this.ColorPurple.TabStop = false;
            this.ColorPurple.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // ColorBlue
            // 
            this.ColorBlue.BackColor = System.Drawing.Color.Blue;
            this.ColorBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorBlue.Location = new System.Drawing.Point(85, 48);
            this.ColorBlue.Name = "ColorBlue";
            this.ColorBlue.Size = new System.Drawing.Size(30, 30);
            this.ColorBlue.TabIndex = 10;
            this.ColorBlue.TabStop = false;
            this.ColorBlue.Click += new System.EventHandler(this.ColorBlue_Click);
            // 
            // ColorWhite
            // 
            this.ColorWhite.BackColor = System.Drawing.Color.White;
            this.ColorWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorWhite.Location = new System.Drawing.Point(13, 12);
            this.ColorWhite.Name = "ColorWhite";
            this.ColorWhite.Size = new System.Drawing.Size(30, 30);
            this.ColorWhite.TabIndex = 0;
            this.ColorWhite.TabStop = false;
            this.ColorWhite.Click += new System.EventHandler(this.ColorWhite_Click);
            // 
            // ColorRed
            // 
            this.ColorRed.BackColor = System.Drawing.Color.Red;
            this.ColorRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorRed.Location = new System.Drawing.Point(157, 12);
            this.ColorRed.Name = "ColorRed";
            this.ColorRed.Size = new System.Drawing.Size(30, 30);
            this.ColorRed.TabIndex = 1;
            this.ColorRed.TabStop = false;
            this.ColorRed.Click += new System.EventHandler(this.ColorRed_Click);
            // 
            // ColorSilver
            // 
            this.ColorSilver.BackColor = System.Drawing.Color.Silver;
            this.ColorSilver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorSilver.Location = new System.Drawing.Point(121, 12);
            this.ColorSilver.Name = "ColorSilver";
            this.ColorSilver.Size = new System.Drawing.Size(30, 30);
            this.ColorSilver.TabIndex = 2;
            this.ColorSilver.TabStop = false;
            this.ColorSilver.Click += new System.EventHandler(this.ColorSilver_Click);
            // 
            // ColorBrown
            // 
            this.ColorBrown.BackColor = System.Drawing.Color.Brown;
            this.ColorBrown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorBrown.Location = new System.Drawing.Point(157, 48);
            this.ColorBrown.Name = "ColorBrown";
            this.ColorBrown.Size = new System.Drawing.Size(30, 30);
            this.ColorBrown.TabIndex = 7;
            this.ColorBrown.TabStop = false;
            this.ColorBrown.Click += new System.EventHandler(this.ColorBrown_Click);
            // 
            // ColorGray
            // 
            this.ColorGray.BackColor = System.Drawing.Color.Gray;
            this.ColorGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorGray.Location = new System.Drawing.Point(85, 12);
            this.ColorGray.Name = "ColorGray";
            this.ColorGray.Size = new System.Drawing.Size(30, 30);
            this.ColorGray.TabIndex = 3;
            this.ColorGray.TabStop = false;
            this.ColorGray.Click += new System.EventHandler(this.ColorGray_Click);
            // 
            // ColorYellow
            // 
            this.ColorYellow.BackColor = System.Drawing.Color.Yellow;
            this.ColorYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorYellow.Location = new System.Drawing.Point(13, 48);
            this.ColorYellow.Name = "ColorYellow";
            this.ColorYellow.Size = new System.Drawing.Size(30, 30);
            this.ColorYellow.TabIndex = 6;
            this.ColorYellow.TabStop = false;
            this.ColorYellow.Click += new System.EventHandler(this.ColorYellow_Click);
            // 
            // ColorBlack
            // 
            this.ColorBlack.BackColor = System.Drawing.Color.Black;
            this.ColorBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorBlack.Location = new System.Drawing.Point(49, 12);
            this.ColorBlack.Name = "ColorBlack";
            this.ColorBlack.Size = new System.Drawing.Size(30, 30);
            this.ColorBlack.TabIndex = 4;
            this.ColorBlack.TabStop = false;
            this.ColorBlack.Click += new System.EventHandler(this.ColorBlack_Click);
            // 
            // ColorOrange
            // 
            this.ColorOrange.BackColor = System.Drawing.Color.Orange;
            this.ColorOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorOrange.Location = new System.Drawing.Point(193, 12);
            this.ColorOrange.Name = "ColorOrange";
            this.ColorOrange.Size = new System.Drawing.Size(30, 30);
            this.ColorOrange.TabIndex = 5;
            this.ColorOrange.TabStop = false;
            this.ColorOrange.Click += new System.EventHandler(this.ColorOrange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorViolet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPurple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorWhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorSilver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBrown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorGray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorOrange)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox ColorBlack;
        private PictureBox ColorGray;
        private PictureBox ColorSilver;
        private PictureBox ColorRed;
        private PictureBox ColorWhite;
        private PictureBox ColorGreen;
        private PictureBox ColorPurple;
        private PictureBox ColorBlue;
        private PictureBox ColorViolet;
        private PictureBox ColorBrown;
        private PictureBox ColorYellow;
        private PictureBox ColorOrange;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button2;
    }
}