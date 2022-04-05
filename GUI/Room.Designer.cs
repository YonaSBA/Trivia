
namespace GUI
{
    partial class Room
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
            this.name_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.max_players_label = new System.Windows.Forms.Label();
            this.questions_num_label = new System.Windows.Forms.Label();
            this.answer_time_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_button
            // 
            this.name_button.BackColor = System.Drawing.Color.Black;
            this.name_button.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_button.ForeColor = System.Drawing.Color.Firebrick;
            this.name_button.Location = new System.Drawing.Point(0, 0);
            this.name_button.Name = "name_button";
            this.name_button.Size = new System.Drawing.Size(158, 101);
            this.name_button.TabIndex = 0;
            this.name_button.Text = "Name";
            this.name_button.UseVisualStyleBackColor = false;
            this.name_button.Click += new System.EventHandler(this.JoinRoom);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Max Players: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Question:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Max Time Per Answer:";
            // 
            // max_players_label
            // 
            this.max_players_label.AutoSize = true;
            this.max_players_label.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_players_label.Location = new System.Drawing.Point(268, 15);
            this.max_players_label.Name = "max_players_label";
            this.max_players_label.Size = new System.Drawing.Size(24, 23);
            this.max_players_label.TabIndex = 4;
            this.max_players_label.Text = "{}";
            // 
            // questions_num_label
            // 
            this.questions_num_label.AutoSize = true;
            this.questions_num_label.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questions_num_label.Location = new System.Drawing.Point(328, 41);
            this.questions_num_label.Name = "questions_num_label";
            this.questions_num_label.Size = new System.Drawing.Size(24, 23);
            this.questions_num_label.TabIndex = 5;
            this.questions_num_label.Text = "{}";
            // 
            // answer_time_label
            // 
            this.answer_time_label.AutoSize = true;
            this.answer_time_label.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer_time_label.Location = new System.Drawing.Point(339, 67);
            this.answer_time_label.Name = "answer_time_label";
            this.answer_time_label.Size = new System.Drawing.Size(24, 23);
            this.answer_time_label.TabIndex = 6;
            this.answer_time_label.Text = "{}";
            // 
            // Room
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.answer_time_label);
            this.Controls.Add(this.questions_num_label);
            this.Controls.Add(this.max_players_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_button);
            this.Name = "Room";
            this.Size = new System.Drawing.Size(365, 101);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button name_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label max_players_label;
        private System.Windows.Forms.Label questions_num_label;
        private System.Windows.Forms.Label answer_time_label;
    }
}
