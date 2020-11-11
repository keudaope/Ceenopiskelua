namespace KaksiLukuaYhteen
{
    partial class Yhteenlaskulomake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yhteenlaskulomake));
            this.Luku1Label = new System.Windows.Forms.Label();
            this.Luku2Label = new System.Windows.Forms.Label();
            this.Luku1_Tekstilaatikko = new System.Windows.Forms.TextBox();
            this.Luku2_Tekstilaatikko = new System.Windows.Forms.TextBox();
            this.LaskeYhteenPainike = new System.Windows.Forms.Button();
            this.VastausLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Luku1Label
            // 
            this.Luku1Label.AutoSize = true;
            this.Luku1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Luku1Label.Location = new System.Drawing.Point(126, 65);
            this.Luku1Label.Name = "Luku1Label";
            this.Luku1Label.Size = new System.Drawing.Size(121, 37);
            this.Luku1Label.TabIndex = 0;
            this.Luku1Label.Text = "Luku 1:";
            this.Luku1Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Luku2Label
            // 
            this.Luku2Label.AutoSize = true;
            this.Luku2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Luku2Label.Location = new System.Drawing.Point(126, 143);
            this.Luku2Label.Name = "Luku2Label";
            this.Luku2Label.Size = new System.Drawing.Size(123, 37);
            this.Luku2Label.TabIndex = 1;
            this.Luku2Label.Text = "Luku 2:";
            // 
            // Luku1_Tekstilaatikko
            // 
            this.Luku1_Tekstilaatikko.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Luku1_Tekstilaatikko.Location = new System.Drawing.Point(253, 65);
            this.Luku1_Tekstilaatikko.Name = "Luku1_Tekstilaatikko";
            this.Luku1_Tekstilaatikko.Size = new System.Drawing.Size(100, 44);
            this.Luku1_Tekstilaatikko.TabIndex = 2;
            // 
            // Luku2_Tekstilaatikko
            // 
            this.Luku2_Tekstilaatikko.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Luku2_Tekstilaatikko.Location = new System.Drawing.Point(253, 143);
            this.Luku2_Tekstilaatikko.Name = "Luku2_Tekstilaatikko";
            this.Luku2_Tekstilaatikko.Size = new System.Drawing.Size(100, 44);
            this.Luku2_Tekstilaatikko.TabIndex = 3;
            // 
            // LaskeYhteenPainike
            // 
            this.LaskeYhteenPainike.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaskeYhteenPainike.Location = new System.Drawing.Point(133, 213);
            this.LaskeYhteenPainike.Name = "LaskeYhteenPainike";
            this.LaskeYhteenPainike.Size = new System.Drawing.Size(220, 79);
            this.LaskeYhteenPainike.TabIndex = 4;
            this.LaskeYhteenPainike.Text = "Laske yhteen";
            this.LaskeYhteenPainike.UseVisualStyleBackColor = true;
            this.LaskeYhteenPainike.Click += new System.EventHandler(this.LaskeYhteenPainike_Click);
            // 
            // VastausLabel
            // 
            this.VastausLabel.AutoSize = true;
            this.VastausLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VastausLabel.Location = new System.Drawing.Point(133, 328);
            this.VastausLabel.Name = "VastausLabel";
            this.VastausLabel.Size = new System.Drawing.Size(305, 37);
            this.VastausLabel.TabIndex = 5;
            this.VastausLabel.Text = "Tähän tulee vastaus";
            this.VastausLabel.Visible = false;
            // 
            // Yhteenlaskulomake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VastausLabel);
            this.Controls.Add(this.LaskeYhteenPainike);
            this.Controls.Add(this.Luku2_Tekstilaatikko);
            this.Controls.Add(this.Luku1_Tekstilaatikko);
            this.Controls.Add(this.Luku2Label);
            this.Controls.Add(this.Luku1Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Yhteenlaskulomake";
            this.Text = "Yhteenlaskulomake";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Luku1Label;
        private System.Windows.Forms.Label Luku2Label;
        private System.Windows.Forms.TextBox Luku1_Tekstilaatikko;
        private System.Windows.Forms.TextBox Luku2_Tekstilaatikko;
        private System.Windows.Forms.Button LaskeYhteenPainike;
        private System.Windows.Forms.Label VastausLabel;
    }
}

