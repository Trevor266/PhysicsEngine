namespace BallisticsEngine
{
    partial class BallisticsWindow
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.FpsLbl = new System.Windows.Forms.Label();
            this.MortarSource = new System.Windows.Forms.Button();
            this.BulletLazerSource = new System.Windows.Forms.Button();
            this.Instructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FpsLbl
            // 
            this.FpsLbl.AutoSize = true;
            this.FpsLbl.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FpsLbl.ForeColor = System.Drawing.Color.Snow;
            this.FpsLbl.Location = new System.Drawing.Point(12, 9);
            this.FpsLbl.Name = "FpsLbl";
            this.FpsLbl.Size = new System.Drawing.Size(43, 22);
            this.FpsLbl.TabIndex = 13;
            this.FpsLbl.Text = "FPS: ";
            // 
            // MortarSource
            // 
            this.MortarSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MortarSource.Location = new System.Drawing.Point(12, 386);
            this.MortarSource.Name = "MortarSource";
            this.MortarSource.Size = new System.Drawing.Size(10, 23);
            this.MortarSource.TabIndex = 17;
            this.MortarSource.Text = "button1";
            this.MortarSource.UseVisualStyleBackColor = true;
            this.MortarSource.Visible = false;
            // 
            // BulletLazerSource
            // 
            this.BulletLazerSource.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BulletLazerSource.Location = new System.Drawing.Point(12, 201);
            this.BulletLazerSource.Name = "BulletLazerSource";
            this.BulletLazerSource.Size = new System.Drawing.Size(10, 23);
            this.BulletLazerSource.TabIndex = 18;
            this.BulletLazerSource.Text = "button1";
            this.BulletLazerSource.UseVisualStyleBackColor = true;
            this.BulletLazerSource.Visible = false;
            // 
            // Instructions
            // 
            this.Instructions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Instructions.AutoSize = true;
            this.Instructions.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructions.ForeColor = System.Drawing.Color.Snow;
            this.Instructions.Location = new System.Drawing.Point(636, 9);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(453, 22);
            this.Instructions.TabIndex = 19;
            this.Instructions.Text = "Press 1 for bullets, two for lazers, 3 for arrows, and 4 for mortars";
            // 
            // BallisticsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1101, 421);
            this.Controls.Add(this.Instructions);
            this.Controls.Add(this.BulletLazerSource);
            this.Controls.Add(this.MortarSource);
            this.Controls.Add(this.FpsLbl);
            this.Name = "BallisticsWindow";
            this.Text = "Ballistics Engine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label FpsLbl;
        private System.Windows.Forms.Button MortarSource;
        private System.Windows.Forms.Button BulletLazerSource;
        private System.Windows.Forms.Label Instructions;
    }
}

