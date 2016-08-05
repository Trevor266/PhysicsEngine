namespace ParticleEngine
{
    partial class ParticleWindow
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
            this.EmitterOne = new System.Windows.Forms.Label();
            this.EmitterTwo = new System.Windows.Forms.Label();
            this.EmitterBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AutoGenerateBtn = new System.Windows.Forms.Button();
            this.EmitterThree = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PauseButton = new System.Windows.Forms.Button();
            this.ParticleCntLbl = new System.Windows.Forms.Label();
            this.ParticleMax = new System.Windows.Forms.TrackBar();
            this.MaxParticlesLbl = new System.Windows.Forms.Label();
            this.FpsLbl = new System.Windows.Forms.Label();
            this.ParticleMultiplierLbl = new System.Windows.Forms.Label();
            this.ParticleMultiplierCB = new System.Windows.Forms.ComboBox();
            this.ParticleSizeLbl = new System.Windows.Forms.Label();
            this.ParticleSizeTrack = new System.Windows.Forms.TrackBar();
            this.ParticleReset = new System.Windows.Forms.Button();
            this.RotationSlider = new System.Windows.Forms.TrackBar();
            this.RotationSpeedLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ParticleMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParticleSizeTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotationSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // EmitterOne
            // 
            this.EmitterOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmitterOne.AutoSize = true;
            this.EmitterOne.Location = new System.Drawing.Point(289, 288);
            this.EmitterOne.Name = "EmitterOne";
            this.EmitterOne.Size = new System.Drawing.Size(0, 13);
            this.EmitterOne.TabIndex = 0;
            // 
            // EmitterTwo
            // 
            this.EmitterTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmitterTwo.AutoSize = true;
            this.EmitterTwo.Location = new System.Drawing.Point(502, 288);
            this.EmitterTwo.Name = "EmitterTwo";
            this.EmitterTwo.Size = new System.Drawing.Size(0, 13);
            this.EmitterTwo.TabIndex = 1;
            // 
            // EmitterBtn
            // 
            this.EmitterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EmitterBtn.Location = new System.Drawing.Point(2, 401);
            this.EmitterBtn.Name = "EmitterBtn";
            this.EmitterBtn.Size = new System.Drawing.Size(290, 23);
            this.EmitterBtn.TabIndex = 2;
            this.EmitterBtn.Text = "Click me!";
            this.EmitterBtn.UseVisualStyleBackColor = true;
            this.EmitterBtn.Click += new System.EventHandler(this.EmitterBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AutoGenerateBtn
            // 
            this.AutoGenerateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AutoGenerateBtn.Location = new System.Drawing.Point(0, 372);
            this.AutoGenerateBtn.Name = "AutoGenerateBtn";
            this.AutoGenerateBtn.Size = new System.Drawing.Size(292, 23);
            this.AutoGenerateBtn.TabIndex = 3;
            this.AutoGenerateBtn.Text = "Auto-Generate Particles: OFF";
            this.AutoGenerateBtn.UseVisualStyleBackColor = true;
            this.AutoGenerateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmitterThree
            // 
            this.EmitterThree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmitterThree.AutoSize = true;
            this.EmitterThree.Location = new System.Drawing.Point(745, 288);
            this.EmitterThree.Name = "EmitterThree";
            this.EmitterThree.Size = new System.Drawing.Size(0, 13);
            this.EmitterThree.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(240, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Emitter 1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(479, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Emitter 2";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(715, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Emitter 3";
            // 
            // PauseButton
            // 
            this.PauseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PauseButton.Location = new System.Drawing.Point(777, 372);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(292, 23);
            this.PauseButton.TabIndex = 8;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // ParticleCntLbl
            // 
            this.ParticleCntLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ParticleCntLbl.AutoSize = true;
            this.ParticleCntLbl.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParticleCntLbl.ForeColor = System.Drawing.Color.Snow;
            this.ParticleCntLbl.Location = new System.Drawing.Point(869, 9);
            this.ParticleCntLbl.Name = "ParticleCntLbl";
            this.ParticleCntLbl.Size = new System.Drawing.Size(114, 22);
            this.ParticleCntLbl.TabIndex = 9;
            this.ParticleCntLbl.Text = "Particle Count: ";
            // 
            // ParticleMax
            // 
            this.ParticleMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ParticleMax.LargeChange = 1;
            this.ParticleMax.Location = new System.Drawing.Point(873, 92);
            this.ParticleMax.Maximum = 2000;
            this.ParticleMax.Minimum = 1;
            this.ParticleMax.Name = "ParticleMax";
            this.ParticleMax.Size = new System.Drawing.Size(185, 45);
            this.ParticleMax.SmallChange = 0;
            this.ParticleMax.TabIndex = 10;
            this.ParticleMax.Value = 1;
            this.ParticleMax.Scroll += new System.EventHandler(this.ParticleMax_Scroll);
            // 
            // MaxParticlesLbl
            // 
            this.MaxParticlesLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxParticlesLbl.AutoSize = true;
            this.MaxParticlesLbl.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxParticlesLbl.ForeColor = System.Drawing.Color.Snow;
            this.MaxParticlesLbl.Location = new System.Drawing.Point(900, 67);
            this.MaxParticlesLbl.Name = "MaxParticlesLbl";
            this.MaxParticlesLbl.Size = new System.Drawing.Size(121, 22);
            this.MaxParticlesLbl.TabIndex = 11;
            this.MaxParticlesLbl.Text = "Max Particles:  1";
            // 
            // FpsLbl
            // 
            this.FpsLbl.AutoSize = true;
            this.FpsLbl.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FpsLbl.ForeColor = System.Drawing.Color.Snow;
            this.FpsLbl.Location = new System.Drawing.Point(12, 9);
            this.FpsLbl.Name = "FpsLbl";
            this.FpsLbl.Size = new System.Drawing.Size(43, 22);
            this.FpsLbl.TabIndex = 12;
            this.FpsLbl.Text = "FPS: ";
            // 
            // ParticleMultiplierLbl
            // 
            this.ParticleMultiplierLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ParticleMultiplierLbl.AutoSize = true;
            this.ParticleMultiplierLbl.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParticleMultiplierLbl.ForeColor = System.Drawing.Color.Snow;
            this.ParticleMultiplierLbl.Location = new System.Drawing.Point(900, 140);
            this.ParticleMultiplierLbl.Name = "ParticleMultiplierLbl";
            this.ParticleMultiplierLbl.Size = new System.Drawing.Size(132, 22);
            this.ParticleMultiplierLbl.TabIndex = 14;
            this.ParticleMultiplierLbl.Text = "Particle Multiplier";
            // 
            // ParticleMultiplierCB
            // 
            this.ParticleMultiplierCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ParticleMultiplierCB.FormattingEnabled = true;
            this.ParticleMultiplierCB.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.ParticleMultiplierCB.Location = new System.Drawing.Point(904, 172);
            this.ParticleMultiplierCB.Name = "ParticleMultiplierCB";
            this.ParticleMultiplierCB.Size = new System.Drawing.Size(121, 21);
            this.ParticleMultiplierCB.TabIndex = 15;
            this.ParticleMultiplierCB.Text = "1";
            this.ParticleMultiplierCB.SelectedIndexChanged += new System.EventHandler(this.ParticleMultiplierCB_SelectedIndexChanged);
            // 
            // ParticleSizeLbl
            // 
            this.ParticleSizeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ParticleSizeLbl.AutoSize = true;
            this.ParticleSizeLbl.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParticleSizeLbl.ForeColor = System.Drawing.Color.Snow;
            this.ParticleSizeLbl.Location = new System.Drawing.Point(900, 212);
            this.ParticleSizeLbl.Name = "ParticleSizeLbl";
            this.ParticleSizeLbl.Size = new System.Drawing.Size(92, 22);
            this.ParticleSizeLbl.TabIndex = 16;
            this.ParticleSizeLbl.Text = "Particle Size";
            // 
            // ParticleSizeTrack
            // 
            this.ParticleSizeTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ParticleSizeTrack.Location = new System.Drawing.Point(873, 237);
            this.ParticleSizeTrack.Maximum = 40;
            this.ParticleSizeTrack.Minimum = 1;
            this.ParticleSizeTrack.Name = "ParticleSizeTrack";
            this.ParticleSizeTrack.Size = new System.Drawing.Size(185, 45);
            this.ParticleSizeTrack.TabIndex = 20;
            this.ParticleSizeTrack.Value = 5;
            this.ParticleSizeTrack.Scroll += new System.EventHandler(this.ParticleSizeTrack_Scroll);
            // 
            // ParticleReset
            // 
            this.ParticleReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ParticleReset.Location = new System.Drawing.Point(777, 401);
            this.ParticleReset.Name = "ParticleReset";
            this.ParticleReset.Size = new System.Drawing.Size(292, 23);
            this.ParticleReset.TabIndex = 21;
            this.ParticleReset.Text = "Reset Particles";
            this.ParticleReset.UseVisualStyleBackColor = true;
            this.ParticleReset.Click += new System.EventHandler(this.ParticleReset_Click);
            // 
            // RotationSlider
            // 
            this.RotationSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RotationSlider.LargeChange = 1;
            this.RotationSlider.Location = new System.Drawing.Point(873, 320);
            this.RotationSlider.Maximum = 5;
            this.RotationSlider.Minimum = 1;
            this.RotationSlider.Name = "RotationSlider";
            this.RotationSlider.Size = new System.Drawing.Size(185, 45);
            this.RotationSlider.TabIndex = 22;
            this.RotationSlider.Value = 1;
            this.RotationSlider.Scroll += new System.EventHandler(this.RotationSlider_Scroll);
            // 
            // RotationSpeedLbl
            // 
            this.RotationSpeedLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RotationSpeedLbl.AutoSize = true;
            this.RotationSpeedLbl.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RotationSpeedLbl.ForeColor = System.Drawing.Color.Snow;
            this.RotationSpeedLbl.Location = new System.Drawing.Point(900, 281);
            this.RotationSpeedLbl.Name = "RotationSpeedLbl";
            this.RotationSpeedLbl.Size = new System.Drawing.Size(126, 22);
            this.RotationSpeedLbl.TabIndex = 23;
            this.RotationSpeedLbl.Text = "Rotational Speed";
            // 
            // ParticleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1070, 424);
            this.Controls.Add(this.RotationSpeedLbl);
            this.Controls.Add(this.RotationSlider);
            this.Controls.Add(this.ParticleReset);
            this.Controls.Add(this.ParticleSizeTrack);
            this.Controls.Add(this.ParticleSizeLbl);
            this.Controls.Add(this.ParticleMultiplierCB);
            this.Controls.Add(this.ParticleMultiplierLbl);
            this.Controls.Add(this.FpsLbl);
            this.Controls.Add(this.MaxParticlesLbl);
            this.Controls.Add(this.ParticleMax);
            this.Controls.Add(this.ParticleCntLbl);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmitterThree);
            this.Controls.Add(this.AutoGenerateBtn);
            this.Controls.Add(this.EmitterBtn);
            this.Controls.Add(this.EmitterTwo);
            this.Controls.Add(this.EmitterOne);
            this.KeyPreview = true;
            this.Name = "ParticleWindow";
            this.Text = "Particle Engine";
            ((System.ComponentModel.ISupportInitialize)(this.ParticleMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParticleSizeTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotationSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmitterOne;
        private System.Windows.Forms.Label EmitterTwo;
        private System.Windows.Forms.Button EmitterBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button AutoGenerateBtn;
        private System.Windows.Forms.Label EmitterThree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Label ParticleCntLbl;
        private System.Windows.Forms.TrackBar ParticleMax;
        private System.Windows.Forms.Label MaxParticlesLbl;
        private System.Windows.Forms.Label FpsLbl;
        private System.Windows.Forms.Label ParticleMultiplierLbl;
        private System.Windows.Forms.ComboBox ParticleMultiplierCB;
        private System.Windows.Forms.Label ParticleSizeLbl;
        private System.Windows.Forms.TrackBar ParticleSizeTrack;
        private System.Windows.Forms.Button ParticleReset;
        private System.Windows.Forms.TrackBar RotationSlider;
        private System.Windows.Forms.Label RotationSpeedLbl;
    }
}

