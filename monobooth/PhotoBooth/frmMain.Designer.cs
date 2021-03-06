﻿namespace PhotoBooth
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.cmdStart = new System.Windows.Forms.Button();
            this.imgStrip4 = new System.Windows.Forms.PictureBox();
            this.imgStrip3 = new System.Windows.Forms.PictureBox();
            this.imgStrip2 = new System.Windows.Forms.PictureBox();
            this.imgStrip1 = new System.Windows.Forms.PictureBox();
            this.imgPreview = new Emgu.CV.UI.ImageBox();
            this.tmrCommon = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgStrip4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStrip3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStrip2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(386, 547);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(75, 43);
            this.cmdStart.TabIndex = 5;
            this.cmdStart.Text = "Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            this.cmdStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmdStart_KeyPress);
            this.cmdStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdStart_MouseDown);
            this.cmdStart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmdStart_MouseMove);
            // 
            // imgStrip4
            // 
            this.imgStrip4.BackColor = System.Drawing.Color.Black;
            this.imgStrip4.Location = new System.Drawing.Point(123, 421);
            this.imgStrip4.Name = "imgStrip4";
            this.imgStrip4.Size = new System.Drawing.Size(110, 110);
            this.imgStrip4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgStrip4.TabIndex = 3;
            this.imgStrip4.TabStop = false;
            this.imgStrip4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgStrip4_MouseDown);
            this.imgStrip4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgStrip4_MouseMove);
            // 
            // imgStrip3
            // 
            this.imgStrip3.BackColor = System.Drawing.Color.Black;
            this.imgStrip3.Location = new System.Drawing.Point(123, 305);
            this.imgStrip3.Name = "imgStrip3";
            this.imgStrip3.Size = new System.Drawing.Size(110, 110);
            this.imgStrip3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgStrip3.TabIndex = 2;
            this.imgStrip3.TabStop = false;
            this.imgStrip3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgStrip3_MouseDown);
            this.imgStrip3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgStrip3_MouseMove);
            // 
            // imgStrip2
            // 
            this.imgStrip2.BackColor = System.Drawing.Color.Black;
            this.imgStrip2.Location = new System.Drawing.Point(123, 189);
            this.imgStrip2.Name = "imgStrip2";
            this.imgStrip2.Size = new System.Drawing.Size(110, 110);
            this.imgStrip2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgStrip2.TabIndex = 1;
            this.imgStrip2.TabStop = false;
            this.imgStrip2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgStrip2_MouseDown);
            this.imgStrip2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgStrip2_MouseMove);
            // 
            // imgStrip1
            // 
            this.imgStrip1.BackColor = System.Drawing.Color.Black;
            this.imgStrip1.Location = new System.Drawing.Point(123, 73);
            this.imgStrip1.Name = "imgStrip1";
            this.imgStrip1.Size = new System.Drawing.Size(110, 110);
            this.imgStrip1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgStrip1.TabIndex = 0;
            this.imgStrip1.TabStop = false;
            this.imgStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgStrip1_MouseDown);
            this.imgStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgStrip1_MouseMove);
            // 
            // imgPreview
            // 
            this.imgPreview.BackColor = System.Drawing.Color.Black;
            this.imgPreview.Location = new System.Drawing.Point(302, 189);
            this.imgPreview.Name = "imgPreview";
            this.imgPreview.Size = new System.Drawing.Size(442, 352);
            this.imgPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPreview.TabIndex = 2;
            this.imgPreview.TabStop = false;
            this.imgPreview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgPreview_MouseDown);
            this.imgPreview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgPreview_MouseMove);
            // 
            // tmrCommon
            // 
            this.tmrCommon.Tick += new System.EventHandler(this.tmrCommon_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.imgPreview);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.imgStrip4);
            this.Controls.Add(this.imgStrip3);
            this.Controls.Add(this.imgStrip2);
            this.Controls.Add(this.imgStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "PhotoBooth";
            this.MaximumSizeChanged += new System.EventHandler(this.frmMain_MaximumSizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmMain_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.imgStrip4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStrip3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStrip2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgStrip1;
        private System.Windows.Forms.PictureBox imgStrip2;
        private System.Windows.Forms.PictureBox imgStrip3;
        private System.Windows.Forms.PictureBox imgStrip4;
        private System.Windows.Forms.Button cmdStart;
        private Emgu.CV.UI.ImageBox imgPreview;
        private System.Windows.Forms.Timer tmrCommon;
    }
}

