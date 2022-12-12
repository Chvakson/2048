namespace _2048WinFormsApp
{
    partial class UserNameForm
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.inputNameTextBox = new System.Windows.Forms.TextBox();
            this.inputButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(47, 60);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(323, 15);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Игрок, добро пожаловать в игру 2048! Введите ваше имя!";
            // 
            // inputNameTextBox
            // 
            this.inputNameTextBox.Location = new System.Drawing.Point(31, 156);
            this.inputNameTextBox.Name = "inputNameTextBox";
            this.inputNameTextBox.Size = new System.Drawing.Size(356, 23);
            this.inputNameTextBox.TabIndex = 1;
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(172, 208);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(75, 23);
            this.inputButton.TabIndex = 2;
            this.inputButton.Text = "Ввод";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // UserNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 266);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.inputNameTextBox);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "UserNameForm";
            this.Text = "UserNameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label welcomeLabel;
        private TextBox inputNameTextBox;
        private Button inputButton;
    }
}