
namespace GUI
{
    partial class Create
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create));
            this.answer_time = new System.Windows.Forms.TextBox();
            this.max_players = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.question_count = new System.Windows.Forms.TextBox();
            this.create_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // answer_time
            // 
            this.answer_time.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.answer_time.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer_time.ForeColor = System.Drawing.Color.Firebrick;
            this.answer_time.Location = new System.Drawing.Point(392, 255);
            this.answer_time.Name = "answer_time";
            this.answer_time.Size = new System.Drawing.Size(100, 28);
            this.answer_time.TabIndex = 0;
            // 
            // max_players
            // 
            this.max_players.BackColor = System.Drawing.Color.Black;
            this.max_players.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_players.ForeColor = System.Drawing.Color.Firebrick;
            this.max_players.Location = new System.Drawing.Point(392, 217);
            this.max_players.Name = "max_players";
            this.max_players.Size = new System.Drawing.Size(100, 28);
            this.max_players.TabIndex = 1;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Black;
            this.name.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Firebrick;
            this.name.Location = new System.Drawing.Point(392, 180);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 28);
            this.name.TabIndex = 2;
            // 
            // question_count
            // 
            this.question_count.BackColor = System.Drawing.Color.Black;
            this.question_count.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question_count.ForeColor = System.Drawing.Color.Firebrick;
            this.question_count.Location = new System.Drawing.Point(392, 293);
            this.question_count.Name = "question_count";
            this.question_count.Size = new System.Drawing.Size(100, 28);
            this.question_count.TabIndex = 3;
            // 
            // create_button
            // 
            this.create_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.create_button.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_button.ForeColor = System.Drawing.Color.Firebrick;
            this.create_button.Location = new System.Drawing.Point(343, 348);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(75, 34);
            this.create_button.TabIndex = 4;
            this.create_button.Text = "Create";
            this.create_button.UseVisualStyleBackColor = false;
            this.create_button.Click += new System.EventHandler(this.CreateRoom);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Black;
            this.back_button.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.Firebrick;
            this.back_button.Location = new System.Drawing.Point(672, 375);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 36);
            this.back_button.TabIndex = 5;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.Back);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(279, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "RoomName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(279, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Max players:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(279, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Answer time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(279, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Question count:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(829, 380);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(781, 423);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.question_count);
            this.Controls.Add(this.name);
            this.Controls.Add(this.max_players);
            this.Controls.Add(this.answer_time);
            this.Name = "Create";
            this.Text = "Create";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox answer_time;
        private System.Windows.Forms.TextBox max_players;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox question_count;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}