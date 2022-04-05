namespace GUI
{
    partial class HighScores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighScores));
            this.back_button = new System.Windows.Forms.Button();
            this.scores_pannel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back_button.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.Firebrick;
            this.back_button.Location = new System.Drawing.Point(357, 387);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(84, 33);
            this.back_button.TabIndex = 1;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.Back);
            // 
            // scores_pannel
            // 
            this.scores_pannel.BackColor = System.Drawing.Color.Transparent;
            this.scores_pannel.ForeColor = System.Drawing.Color.Transparent;
            this.scores_pannel.Location = new System.Drawing.Point(181, 197);
            this.scores_pannel.Name = "scores_pannel";
            this.scores_pannel.Size = new System.Drawing.Size(454, 184);
            this.scores_pannel.TabIndex = 2;
            // 
            // HighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scores_pannel);
            this.Controls.Add(this.back_button);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "HighScores";
            this.Text = "HighScore";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.FlowLayoutPanel scores_pannel;
    }
}