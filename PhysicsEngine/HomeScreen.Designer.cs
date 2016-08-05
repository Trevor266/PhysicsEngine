namespace PhysicsEngine
{
    partial class HomeScreen
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
            this.InstructionLbl = new System.Windows.Forms.Label();
            this.ParticleBtn = new System.Windows.Forms.Button();
            this.BallisticsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InstructionLbl
            // 
            this.InstructionLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InstructionLbl.Location = new System.Drawing.Point(278, 121);
            this.InstructionLbl.Name = "InstructionLbl";
            this.InstructionLbl.Size = new System.Drawing.Size(220, 24);
            this.InstructionLbl.TabIndex = 0;
            this.InstructionLbl.Text = "Select a physics simulation:";
            // 
            // ParticleBtn
            // 
            this.ParticleBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ParticleBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ParticleBtn.Location = new System.Drawing.Point(282, 181);
            this.ParticleBtn.MaximumSize = new System.Drawing.Size(216, 51);
            this.ParticleBtn.Name = "ParticleBtn";
            this.ParticleBtn.Size = new System.Drawing.Size(216, 51);
            this.ParticleBtn.TabIndex = 1;
            this.ParticleBtn.Text = "Particle Simulator";
            this.ParticleBtn.UseVisualStyleBackColor = false;
            this.ParticleBtn.Click += new System.EventHandler(this.ParticleBtn_Click);
            // 
            // BallisticsBtn
            // 
            this.BallisticsBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BallisticsBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BallisticsBtn.Location = new System.Drawing.Point(282, 238);
            this.BallisticsBtn.MaximumSize = new System.Drawing.Size(216, 51);
            this.BallisticsBtn.Name = "BallisticsBtn";
            this.BallisticsBtn.Size = new System.Drawing.Size(216, 51);
            this.BallisticsBtn.TabIndex = 2;
            this.BallisticsBtn.Text = "Ballistics Simulator";
            this.BallisticsBtn.UseVisualStyleBackColor = false;
            this.BallisticsBtn.Click += new System.EventHandler(this.BallisticsBtn_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(775, 423);
            this.Controls.Add(this.BallisticsBtn);
            this.Controls.Add(this.ParticleBtn);
            this.Controls.Add(this.InstructionLbl);
            this.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "HomeScreen";
            this.Text = "Trevor Hart\'s Physics Engine";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label InstructionLbl;
        private System.Windows.Forms.Button ParticleBtn;
        private System.Windows.Forms.Button BallisticsBtn;
    }
}

