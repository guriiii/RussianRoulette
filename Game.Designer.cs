namespace RussianRoulette
{
    partial class Game
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
            this.btnFire = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSpin = new System.Windows.Forms.Button();
            this.rbHead = new System.Windows.Forms.RadioButton();
            this.rbAway = new System.Windows.Forms.RadioButton();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pbMan = new System.Windows.Forms.PictureBox();
            this.pbPistol = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPistol)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFire
            // 
            this.btnFire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnFire.Font = new System.Drawing.Font("Lucida Sans Unicode", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFire.ForeColor = System.Drawing.Color.Coral;
            this.btnFire.Location = new System.Drawing.Point(259, 475);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(320, 86);
            this.btnFire.TabIndex = 3;
            this.btnFire.Text = "Fire";
            this.btnFire.UseVisualStyleBackColor = false;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Blue;
            this.btnLoad.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.Snow;
            this.btnLoad.Location = new System.Drawing.Point(12, 475);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(215, 42);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSpin
            // 
            this.btnSpin.BackColor = System.Drawing.Color.Blue;
            this.btnSpin.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin.ForeColor = System.Drawing.Color.Snow;
            this.btnSpin.Location = new System.Drawing.Point(12, 523);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(215, 38);
            this.btnSpin.TabIndex = 8;
            this.btnSpin.Text = "Spin";
            this.btnSpin.UseVisualStyleBackColor = false;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // rbHead
            // 
            this.rbHead.AutoSize = true;
            this.rbHead.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHead.Location = new System.Drawing.Point(12, 441);
            this.rbHead.Name = "rbHead";
            this.rbHead.Size = new System.Drawing.Size(167, 27);
            this.rbHead.TabIndex = 12;
            this.rbHead.TabStop = true;
            this.rbHead.Text = "Point at Head";
            this.rbHead.UseVisualStyleBackColor = true;
            this.rbHead.CheckedChanged += new System.EventHandler(this.rbHead_CheckedChanged);
            // 
            // rbAway
            // 
            this.rbAway.AutoSize = true;
            this.rbAway.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAway.Location = new System.Drawing.Point(12, 418);
            this.rbAway.Name = "rbAway";
            this.rbAway.Size = new System.Drawing.Size(141, 27);
            this.rbAway.TabIndex = 12;
            this.rbAway.TabStop = true;
            this.rbAway.Text = "Point Away";
            this.rbAway.UseVisualStyleBackColor = true;
            this.rbAway.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // pb6
            // 
            this.pb6.Image = global::RussianRoulette.Properties.Resources.bullet;
            this.pb6.Location = new System.Drawing.Point(389, 288);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(77, 49);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb6.TabIndex = 11;
            this.pb6.TabStop = false;
            // 
            // pb5
            // 
            this.pb5.Image = global::RussianRoulette.Properties.Resources.bullet;
            this.pb5.Location = new System.Drawing.Point(389, 349);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(77, 49);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb5.TabIndex = 10;
            this.pb5.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.Image = global::RussianRoulette.Properties.Resources.bullet;
            this.pb4.Location = new System.Drawing.Point(389, 410);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(77, 49);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 9;
            this.pb4.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Image = global::RussianRoulette.Properties.Resources.bullet;
            this.pb3.Location = new System.Drawing.Point(502, 288);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(77, 49);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 8;
            this.pb3.TabStop = false;
            this.pb3.Click += new System.EventHandler(this.Pb3_Click);
            // 
            // pb2
            // 
            this.pb2.Image = global::RussianRoulette.Properties.Resources.bullet;
            this.pb2.Location = new System.Drawing.Point(502, 349);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(77, 49);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 7;
            this.pb2.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb1.Image = global::RussianRoulette.Properties.Resources.bullet;
            this.pb1.Location = new System.Drawing.Point(502, 410);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(77, 49);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 6;
            this.pb1.TabStop = false;
            // 
            // pbMan
            // 
            this.pbMan.BackColor = System.Drawing.Color.Transparent;
            this.pbMan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMan.Image = global::RussianRoulette.Properties.Resources.target;
            this.pbMan.Location = new System.Drawing.Point(12, 1);
            this.pbMan.Name = "pbMan";
            this.pbMan.Size = new System.Drawing.Size(202, 384);
            this.pbMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMan.TabIndex = 5;
            this.pbMan.TabStop = false;
            // 
            // pbPistol
            // 
            this.pbPistol.Image = global::RussianRoulette.Properties.Resources.pistol;
            this.pbPistol.Location = new System.Drawing.Point(289, -9);
            this.pbPistol.Name = "pbPistol";
            this.pbPistol.Size = new System.Drawing.Size(357, 220);
            this.pbPistol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPistol.TabIndex = 4;
            this.pbPistol.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 35);
            this.label1.TabIndex = 13;
            this.label1.Text = "CHAMBER";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(591, 571);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbHead);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.rbAway);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pbMan);
            this.Controls.Add(this.pbPistol);
            this.Controls.Add(this.btnFire);
            this.Name = "Game";
            this.Text = " Russian Roulette";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPistol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.PictureBox pbPistol;
        private System.Windows.Forms.PictureBox pbMan;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.RadioButton rbHead;
        private System.Windows.Forms.RadioButton rbAway;
        private System.Windows.Forms.Label label1;
    }
}

