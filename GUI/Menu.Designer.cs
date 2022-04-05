
namespace GUI
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.create_button = new System.Windows.Forms.Button();
            this.signout_button = new System.Windows.Forms.Button();
            this.highscores_button = new System.Windows.Forms.Button();
            this.join_button = new System.Windows.Forms.Button();
            this.statistics_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // create_button
            // 
            this.create_button.BackColor = System.Drawing.Color.Black;
            this.create_button.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_button.ForeColor = System.Drawing.Color.Firebrick;
            this.create_button.Location = new System.Drawing.Point(390, 104);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(183, 39);
            this.create_button.TabIndex = 0;
            this.create_button.Text = "Create Room";
            this.create_button.UseVisualStyleBackColor = false;
            this.create_button.Click += new System.EventHandler(this.Create);
            // 
            // signout_button
            // 
            this.signout_button.BackColor = System.Drawing.Color.Black;
            this.signout_button.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signout_button.ForeColor = System.Drawing.Color.Firebrick;
            this.signout_button.Location = new System.Drawing.Point(702, 406);
            this.signout_button.Name = "signout_button";
            this.signout_button.Size = new System.Drawing.Size(74, 32);
            this.signout_button.TabIndex = 1;
            this.signout_button.Text = "Sign Out";
            this.signout_button.UseVisualStyleBackColor = false;
            this.signout_button.Click += new System.EventHandler(this.SignOut);
            // 
            // highscores_button
            // 
            this.highscores_button.BackColor = System.Drawing.Color.Black;
            this.highscores_button.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscores_button.ForeColor = System.Drawing.Color.Firebrick;
            this.highscores_button.Location = new System.Drawing.Point(390, 196);
            this.highscores_button.Name = "highscores_button";
            this.highscores_button.Size = new System.Drawing.Size(183, 42);
            this.highscores_button.TabIndex = 2;
            this.highscores_button.Text = "High Scores";
            this.highscores_button.UseVisualStyleBackColor = false;
            this.highscores_button.Click += new System.EventHandler(this.GetHighScores);
            // 
            // join_button
            // 
            this.join_button.BackColor = System.Drawing.Color.Black;
            this.join_button.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.join_button.ForeColor = System.Drawing.Color.Firebrick;
            this.join_button.Location = new System.Drawing.Point(390, 149);
            this.join_button.Name = "join_button";
            this.join_button.Size = new System.Drawing.Size(183, 41);
            this.join_button.TabIndex = 3;
            this.join_button.Text = "Join Room";
            this.join_button.UseVisualStyleBackColor = false;
            this.join_button.Click += new System.EventHandler(this.Join);
            // 
            // statistics_button
            // 
            this.statistics_button.BackColor = System.Drawing.Color.Black;
            this.statistics_button.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statistics_button.ForeColor = System.Drawing.Color.Firebrick;
            this.statistics_button.Location = new System.Drawing.Point(390, 244);
            this.statistics_button.Name = "statistics_button";
            this.statistics_button.Size = new System.Drawing.Size(183, 42);
            this.statistics_button.TabIndex = 4;
            this.statistics_button.Text = "My Statistics";
            this.statistics_button.UseVisualStyleBackColor = false;
            this.statistics_button.Click += new System.EventHandler(this.GetStatistics);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.statistics_button);
            this.Controls.Add(this.join_button);
            this.Controls.Add(this.highscores_button);
            this.Controls.Add(this.signout_button);
            this.Controls.Add(this.create_button);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.Button signout_button;
        private System.Windows.Forms.Button highscores_button;
        private System.Windows.Forms.Button join_button;
        private System.Windows.Forms.Button statistics_button;
    }
}