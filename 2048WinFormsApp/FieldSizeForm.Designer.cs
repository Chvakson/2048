namespace _2048WinFormsApp
{
    partial class FieldSizeForm
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
            this.fieldSize4x4RadioButton = new System.Windows.Forms.RadioButton();
            this.fieldSize5x5RadioButton = new System.Windows.Forms.RadioButton();
            this.fieldSize6x6RadioButton = new System.Windows.Forms.RadioButton();
            this.getChoiceLabel = new System.Windows.Forms.Label();
            this.fieldSize7x7RadioButton = new System.Windows.Forms.RadioButton();
            this.acceptSizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fieldSize4x4RadioButton
            // 
            this.fieldSize4x4RadioButton.AutoSize = true;
            this.fieldSize4x4RadioButton.Location = new System.Drawing.Point(50, 80);
            this.fieldSize4x4RadioButton.Name = "fieldSize4x4RadioButton";
            this.fieldSize4x4RadioButton.Size = new System.Drawing.Size(43, 19);
            this.fieldSize4x4RadioButton.TabIndex = 1;
            this.fieldSize4x4RadioButton.TabStop = true;
            this.fieldSize4x4RadioButton.Text = "4x4";
            this.fieldSize4x4RadioButton.UseVisualStyleBackColor = true;
            // 
            // fieldSize5x5RadioButton
            // 
            this.fieldSize5x5RadioButton.AutoSize = true;
            this.fieldSize5x5RadioButton.Location = new System.Drawing.Point(133, 80);
            this.fieldSize5x5RadioButton.Name = "fieldSize5x5RadioButton";
            this.fieldSize5x5RadioButton.Size = new System.Drawing.Size(43, 19);
            this.fieldSize5x5RadioButton.TabIndex = 2;
            this.fieldSize5x5RadioButton.TabStop = true;
            this.fieldSize5x5RadioButton.Text = "5x5";
            this.fieldSize5x5RadioButton.UseVisualStyleBackColor = true;
            // 
            // fieldSize6x6RadioButton
            // 
            this.fieldSize6x6RadioButton.AutoSize = true;
            this.fieldSize6x6RadioButton.Location = new System.Drawing.Point(50, 131);
            this.fieldSize6x6RadioButton.Name = "fieldSize6x6RadioButton";
            this.fieldSize6x6RadioButton.Size = new System.Drawing.Size(43, 19);
            this.fieldSize6x6RadioButton.TabIndex = 3;
            this.fieldSize6x6RadioButton.TabStop = true;
            this.fieldSize6x6RadioButton.Text = "6x6";
            this.fieldSize6x6RadioButton.UseVisualStyleBackColor = true;
            // 
            // getChoiceLabel
            // 
            this.getChoiceLabel.AutoSize = true;
            this.getChoiceLabel.Location = new System.Drawing.Point(50, 35);
            this.getChoiceLabel.Name = "getChoiceLabel";
            this.getChoiceLabel.Size = new System.Drawing.Size(134, 15);
            this.getChoiceLabel.TabIndex = 4;
            this.getChoiceLabel.Text = "Выберите размер поля";
            // 
            // fieldSize7x7RadioButton
            // 
            this.fieldSize7x7RadioButton.AutoSize = true;
            this.fieldSize7x7RadioButton.Location = new System.Drawing.Point(133, 131);
            this.fieldSize7x7RadioButton.Name = "fieldSize7x7RadioButton";
            this.fieldSize7x7RadioButton.Size = new System.Drawing.Size(43, 19);
            this.fieldSize7x7RadioButton.TabIndex = 5;
            this.fieldSize7x7RadioButton.TabStop = true;
            this.fieldSize7x7RadioButton.Text = "7x7";
            this.fieldSize7x7RadioButton.UseVisualStyleBackColor = true;
            // 
            // acceptSizeButton
            // 
            this.acceptSizeButton.Location = new System.Drawing.Point(75, 185);
            this.acceptSizeButton.Name = "acceptSizeButton";
            this.acceptSizeButton.Size = new System.Drawing.Size(75, 23);
            this.acceptSizeButton.TabIndex = 6;
            this.acceptSizeButton.Text = "Принять";
            this.acceptSizeButton.UseVisualStyleBackColor = true;
            this.acceptSizeButton.Click += new System.EventHandler(this.acceptSizeButton_Click);
            // 
            // FieldSizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 233);
            this.Controls.Add(this.acceptSizeButton);
            this.Controls.Add(this.fieldSize7x7RadioButton);
            this.Controls.Add(this.getChoiceLabel);
            this.Controls.Add(this.fieldSize6x6RadioButton);
            this.Controls.Add(this.fieldSize5x5RadioButton);
            this.Controls.Add(this.fieldSize4x4RadioButton);
            this.Name = "FieldSizeForm";
            this.Text = "FieldSizeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton fieldSize4x4RadioButton;
        private RadioButton fieldSize5x5RadioButton;
        private RadioButton fieldSize6x6RadioButton;
        private Label getChoiceLabel;
        private RadioButton fieldSize7x7RadioButton;
        private Button acceptSizeButton;
    }
}