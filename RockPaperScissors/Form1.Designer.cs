
namespace RockPaperScissors
{
    partial class RockPaperScissors
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
            this.rockButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.scissorsButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.computerChoiceRevealLabel = new System.Windows.Forms.Label();
            this.outcomeLabel = new System.Windows.Forms.Label();
            this.computerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rockButton
            // 
            this.rockButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.rockButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rockButton.Font = new System.Drawing.Font("Wide Latin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rockButton.Location = new System.Drawing.Point(85, 110);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(153, 65);
            this.rockButton.TabIndex = 0;
            this.rockButton.Text = "ROCK";
            this.rockButton.UseVisualStyleBackColor = false;
            this.rockButton.Click += new System.EventHandler(this.rockButton_Click);
            // 
            // paperButton
            // 
            this.paperButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.paperButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paperButton.Font = new System.Drawing.Font("Wide Latin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paperButton.Location = new System.Drawing.Point(85, 180);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(153, 65);
            this.paperButton.TabIndex = 1;
            this.paperButton.Text = "PAPER";
            this.paperButton.UseVisualStyleBackColor = false;
            this.paperButton.Click += new System.EventHandler(this.paperButton_Click);
            // 
            // scissorsButton
            // 
            this.scissorsButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.scissorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.scissorsButton.Font = new System.Drawing.Font("Wide Latin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scissorsButton.Location = new System.Drawing.Point(85, 250);
            this.scissorsButton.Name = "scissorsButton";
            this.scissorsButton.Size = new System.Drawing.Size(153, 65);
            this.scissorsButton.TabIndex = 2;
            this.scissorsButton.Text = "SCISSORS";
            this.scissorsButton.UseVisualStyleBackColor = false;
            this.scissorsButton.Click += new System.EventHandler(this.scissorsButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe Print", 21.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.welcomeLabel.Location = new System.Drawing.Point(134, 22);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(544, 63);
            this.welcomeLabel.TabIndex = 3;
            this.welcomeLabel.Text = "Welcome to Rock, Paper, Scissors!";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Turquoise;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playButton.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(364, 211);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(89, 48);
            this.playButton.TabIndex = 4;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // computerChoiceRevealLabel
            // 
            this.computerChoiceRevealLabel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.computerChoiceRevealLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.computerChoiceRevealLabel.Font = new System.Drawing.Font("Wide Latin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerChoiceRevealLabel.Location = new System.Drawing.Point(559, 235);
            this.computerChoiceRevealLabel.Name = "computerChoiceRevealLabel";
            this.computerChoiceRevealLabel.Size = new System.Drawing.Size(153, 65);
            this.computerChoiceRevealLabel.TabIndex = 6;
            this.computerChoiceRevealLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.computerChoiceRevealLabel.Visible = false;
            // 
            // outcomeLabel
            // 
            this.outcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.outcomeLabel.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outcomeLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.outcomeLabel.Location = new System.Drawing.Point(220, 355);
            this.outcomeLabel.Name = "outcomeLabel";
            this.outcomeLabel.Size = new System.Drawing.Size(366, 55);
            this.outcomeLabel.TabIndex = 7;
            this.outcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // computerLabel
            // 
            this.computerLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerLabel.Location = new System.Drawing.Point(559, 124);
            this.computerLabel.Name = "computerLabel";
            this.computerLabel.Size = new System.Drawing.Size(153, 57);
            this.computerLabel.TabIndex = 8;
            this.computerLabel.Text = "The computer chooses...";
            this.computerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::RockPaperScissors.Properties.Resources.rock_paper_scissors;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.computerLabel);
            this.Controls.Add(this.outcomeLabel);
            this.Controls.Add(this.computerChoiceRevealLabel);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.scissorsButton);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.rockButton);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "RockPaperScissors";
            this.Text = "Rock, Paper, Scissors";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rockButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button scissorsButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label computerChoiceRevealLabel;
        private System.Windows.Forms.Label outcomeLabel;
        private System.Windows.Forms.Label computerLabel;
    }
}

