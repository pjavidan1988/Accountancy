namespace Accountancy
{
    partial class FrmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplash));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBarSplash = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(497, 282);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // progressBarSplash
            // 
            this.progressBarSplash.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.progressBarSplash.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Dash;
            this.progressBarSplash.BackgroundStyle.BorderColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveBackground2;
            this.progressBarSplash.BackgroundStyle.BorderColorLightSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveBackground2;
            this.progressBarSplash.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveBackground2;
            this.progressBarSplash.BackgroundStyle.BorderLeftColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveBackground2;
            this.progressBarSplash.BackgroundStyle.BorderRightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveBackground2;
            this.progressBarSplash.BackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveBackground2;
            this.progressBarSplash.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.progressBarSplash.BackgroundStyle.CornerTypeBottomLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.progressBarSplash.BackgroundStyle.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.progressBarSplash.BackgroundStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.progressBarSplash.BackgroundStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.progressBarSplash.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarSplash.FocusCuesEnabled = false;
            this.progressBarSplash.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.progressBarSplash.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progressBarSplash.Location = new System.Drawing.Point(0, 283);
            this.progressBarSplash.Name = "progressBarSplash";
            this.progressBarSplash.Size = new System.Drawing.Size(497, 10);
            this.progressBarSplash.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.progressBarSplash.TabIndex = 1;
            this.progressBarSplash.Text = "progressBarX1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // FrmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(497, 293);
            this.Controls.Add(this.progressBarSplash);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.SystemColors.InfoText;
            this.Load += new System.EventHandler(this.FrmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarSplash;
        private System.Windows.Forms.Timer timer1;
    }
}