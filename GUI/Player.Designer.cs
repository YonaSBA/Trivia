namespace GUI
{
    partial class Player
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.score_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_label.ForeColor = System.Drawing.Color.Firebrick;
            this.score_label.Location = new System.Drawing.Point(346, -6);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(37, 36);
            this.score_label.TabIndex = 2;
            this.score_label.Text = "{}";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.BackColor = System.Drawing.Color.Transparent;
            this.name_label.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.ForeColor = System.Drawing.Color.Firebrick;
            this.name_label.Location = new System.Drawing.Point(18, -6);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(37, 36);
            this.name_label.TabIndex = 3;
            this.name_label.Text = "{}";
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.score_label);
            this.Name = "Player";
            this.Size = new System.Drawing.Size(454, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Label name_label;
    }
}
