
namespace DrawingApp
{
    partial class DrawingForm
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
            this.panelDraw = new System.Windows.Forms.Panel();
            this.panelColor = new System.Windows.Forms.Panel();
            this.pictureBoxBlue = new System.Windows.Forms.PictureBox();
            this.pictureBoxGreen = new System.Windows.Forms.PictureBox();
            this.pictureBoxOrange = new System.Windows.Forms.PictureBox();
            this.pictureBoxRed = new System.Windows.Forms.PictureBox();
            this.panelDraw.SuspendLayout();
            this.panelColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDraw
            // 
            this.panelDraw.BackColor = System.Drawing.Color.White;
            this.panelDraw.Controls.Add(this.panelColor);
            this.panelDraw.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDraw.Location = new System.Drawing.Point(0, 0);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(986, 523);
            this.panelDraw.TabIndex = 0;
            this.panelDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseDown);
            this.panelDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseMove);
            this.panelDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseUp);
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.Color.Gray;
            this.panelColor.Controls.Add(this.pictureBoxBlue);
            this.panelColor.Controls.Add(this.pictureBoxGreen);
            this.panelColor.Controls.Add(this.pictureBoxOrange);
            this.panelColor.Controls.Add(this.pictureBoxRed);
            this.panelColor.Location = new System.Drawing.Point(779, 12);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(195, 52);
            this.panelColor.TabIndex = 0;
            // 
            // pictureBoxBlue
            // 
            this.pictureBoxBlue.BackColor = System.Drawing.Color.Blue;
            this.pictureBoxBlue.Location = new System.Drawing.Point(144, 3);
            this.pictureBoxBlue.Name = "pictureBoxBlue";
            this.pictureBoxBlue.Size = new System.Drawing.Size(41, 46);
            this.pictureBoxBlue.TabIndex = 3;
            this.pictureBoxBlue.TabStop = false;
            this.pictureBoxBlue.Click += new System.EventHandler(this.pictureBoxBlue_Click);
            // 
            // pictureBoxGreen
            // 
            this.pictureBoxGreen.BackColor = System.Drawing.Color.Green;
            this.pictureBoxGreen.Location = new System.Drawing.Point(97, 3);
            this.pictureBoxGreen.Name = "pictureBoxGreen";
            this.pictureBoxGreen.Size = new System.Drawing.Size(41, 46);
            this.pictureBoxGreen.TabIndex = 2;
            this.pictureBoxGreen.TabStop = false;
            this.pictureBoxGreen.Click += new System.EventHandler(this.pictureBoxGreen_Click);
            // 
            // pictureBoxOrange
            // 
            this.pictureBoxOrange.BackColor = System.Drawing.Color.Orange;
            this.pictureBoxOrange.Location = new System.Drawing.Point(50, 3);
            this.pictureBoxOrange.Name = "pictureBoxOrange";
            this.pictureBoxOrange.Size = new System.Drawing.Size(41, 46);
            this.pictureBoxOrange.TabIndex = 1;
            this.pictureBoxOrange.TabStop = false;
            this.pictureBoxOrange.Click += new System.EventHandler(this.pictureBoxOrange_Click);
            // 
            // pictureBoxRed
            // 
            this.pictureBoxRed.BackColor = System.Drawing.Color.Red;
            this.pictureBoxRed.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxRed.Name = "pictureBoxRed";
            this.pictureBoxRed.Size = new System.Drawing.Size(41, 46);
            this.pictureBoxRed.TabIndex = 0;
            this.pictureBoxRed.TabStop = false;
            this.pictureBoxRed.Click += new System.EventHandler(this.pictureBoxRed_Click);
            // 
            // DrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 523);
            this.Controls.Add(this.panelDraw);
            this.Name = "DrawingForm";
            this.Text = "Drawing App";
            this.panelDraw.ResumeLayout(false);
            this.panelColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDraw;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.PictureBox pictureBoxBlue;
        private System.Windows.Forms.PictureBox pictureBoxGreen;
        private System.Windows.Forms.PictureBox pictureBoxOrange;
        private System.Windows.Forms.PictureBox pictureBoxRed;
    }
}

