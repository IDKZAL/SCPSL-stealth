namespace SCPstealth
{
    partial class infoBoxMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(infoBoxMenu));
            this.ExitButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.LogoDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.LogoStealth = new Guna.UI2.WinForms.Guna2PictureBox();
            this.MainMenuDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.LineDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.TopSeperator = new Guna.UI2.WinForms.Guna2Separator();
            ((System.ComponentModel.ISupportInitialize)(this.LogoStealth)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(2)))));
            this.ExitButton.HoverState.Parent = this.ExitButton;
            this.ExitButton.IconColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(295, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.ShadowDecoration.Parent = this.ExitButton;
            this.ExitButton.Size = new System.Drawing.Size(31, 23);
            this.ExitButton.TabIndex = 1;
            // 
            // LogoDragControl
            // 
            this.LogoDragControl.TargetControl = this.LogoStealth;
            // 
            // LogoStealth
            // 
            this.LogoStealth.Image = global::SCPstealth.Properties.Resources.stealthmeme;
            this.LogoStealth.Location = new System.Drawing.Point(5, 0);
            this.LogoStealth.Name = "LogoStealth";
            this.LogoStealth.ShadowDecoration.Parent = this.LogoStealth;
            this.LogoStealth.Size = new System.Drawing.Size(275, 60);
            this.LogoStealth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoStealth.TabIndex = 5;
            this.LogoStealth.TabStop = false;
            // 
            // MainMenuDragControl
            // 
            this.MainMenuDragControl.TargetControl = this;
            // 
            // LineDragControl
            // 
            this.LineDragControl.TargetControl = null;
            // 
            // TopSeperator
            // 
            this.TopSeperator.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.TopSeperator.FillThickness = 3;
            this.TopSeperator.Location = new System.Drawing.Point(0, 60);
            this.TopSeperator.Name = "TopSeperator";
            this.TopSeperator.Size = new System.Drawing.Size(325, 5);
            this.TopSeperator.TabIndex = 10;
            this.TopSeperator.TabStop = false;
            // 
            // infoBoxMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(325, 300);
            this.Controls.Add(this.TopSeperator);
            this.Controls.Add(this.LogoStealth);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "infoBoxMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCP:SL stealth";
            ((System.ComponentModel.ISupportInitialize)(this.LogoStealth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ControlBox ExitButton;
        private Guna.UI2.WinForms.Guna2PictureBox LogoStealth;
        private Guna.UI2.WinForms.Guna2DragControl LogoDragControl;
        private Guna.UI2.WinForms.Guna2DragControl MainMenuDragControl;
        private Guna.UI2.WinForms.Guna2DragControl LineDragControl;
        private Guna.UI2.WinForms.Guna2Separator TopSeperator;
    }
}

