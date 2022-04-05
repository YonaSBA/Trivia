namespace GUI
{
    partial class Statistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics));
            this.back__button = new System.Windows.Forms.Button();
            this.statistics_pannel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // back__button
            // 
            this.back__button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back__button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back__button.BackgroundImage")));
            this.back__button.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back__button.ForeColor = System.Drawing.Color.Firebrick;
            this.back__button.Location = new System.Drawing.Point(378, 392);
            this.back__button.Name = "back__button";
            this.back__button.Size = new System.Drawing.Size(75, 34);
            this.back__button.TabIndex = 0;
            this.back__button.Text = "Back";
            this.back__button.UseVisualStyleBackColor = false;
            this.back__button.Click += new System.EventHandler(this.Back);
            // 
            // statistics_pannel
            // 
            this.statistics_pannel.Location = new System.Drawing.Point(485, 96);
            this.statistics_pannel.Name = "statistics_pannel";
            this.statistics_pannel.Size = new System.Drawing.Size(92, 295);
            this.statistics_pannel.TabIndex = 1;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statistics_pannel);
            this.Controls.Add(this.back__button);
            this.Name = "Statistics";
            this.Text = "Statistic";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back__button;
        private System.Windows.Forms.FlowLayoutPanel statistics_pannel;
    }
}