
namespace GUI
{
    partial class StatisticsResponse
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
            this.best_label = new System.Windows.Forms.Label();
            this.games_label = new System.Windows.Forms.Label();
            this.corrects_label = new System.Windows.Forms.Label();
            this.wrongs_label = new System.Windows.Forms.Label();
            this.average_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // best_label
            // 
            this.best_label.AutoSize = true;
            this.best_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.best_label.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.best_label.ForeColor = System.Drawing.Color.IndianRed;
            this.best_label.Location = new System.Drawing.Point(27, 8);
            this.best_label.Name = "best_label";
            this.best_label.Size = new System.Drawing.Size(37, 36);
            this.best_label.TabIndex = 0;
            this.best_label.Text = "{}";
            // 
            // games_label
            // 
            this.games_label.AutoSize = true;
            this.games_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.games_label.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.games_label.ForeColor = System.Drawing.Color.IndianRed;
            this.games_label.Location = new System.Drawing.Point(27, 61);
            this.games_label.Name = "games_label";
            this.games_label.Size = new System.Drawing.Size(37, 36);
            this.games_label.TabIndex = 1;
            this.games_label.Text = "{}";
            // 
            // corrects_label
            // 
            this.corrects_label.AutoSize = true;
            this.corrects_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.corrects_label.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corrects_label.ForeColor = System.Drawing.Color.IndianRed;
            this.corrects_label.Location = new System.Drawing.Point(27, 114);
            this.corrects_label.Name = "corrects_label";
            this.corrects_label.Size = new System.Drawing.Size(37, 36);
            this.corrects_label.TabIndex = 2;
            this.corrects_label.Text = "{}";
            // 
            // wrongs_label
            // 
            this.wrongs_label.AutoSize = true;
            this.wrongs_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wrongs_label.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongs_label.ForeColor = System.Drawing.Color.IndianRed;
            this.wrongs_label.Location = new System.Drawing.Point(27, 174);
            this.wrongs_label.Name = "wrongs_label";
            this.wrongs_label.Size = new System.Drawing.Size(37, 36);
            this.wrongs_label.TabIndex = 3;
            this.wrongs_label.Text = "{}";
            // 
            // average_label
            // 
            this.average_label.AutoSize = true;
            this.average_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.average_label.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.average_label.ForeColor = System.Drawing.Color.IndianRed;
            this.average_label.Location = new System.Drawing.Point(27, 232);
            this.average_label.Name = "average_label";
            this.average_label.Size = new System.Drawing.Size(37, 36);
            this.average_label.TabIndex = 4;
            this.average_label.Text = "{}";
            // 
            // StatisticsResponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.average_label);
            this.Controls.Add(this.wrongs_label);
            this.Controls.Add(this.corrects_label);
            this.Controls.Add(this.games_label);
            this.Controls.Add(this.best_label);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "StatisticsResponse";
            this.Size = new System.Drawing.Size(92, 295);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label best_label;
        private System.Windows.Forms.Label games_label;
        private System.Windows.Forms.Label corrects_label;
        private System.Windows.Forms.Label wrongs_label;
        private System.Windows.Forms.Label average_label;
    }
}
