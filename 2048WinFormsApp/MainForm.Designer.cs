namespace _2048WinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreValueLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newGameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.gsmeRulesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.settingsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.resultsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.gameExitToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bestScoreValueLabel = new System.Windows.Forms.Label();
            this.bestScoreLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(12, 42);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(33, 15);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "Счет";
            // 
            // scoreValueLabel
            // 
            this.scoreValueLabel.AutoSize = true;
            this.scoreValueLabel.Location = new System.Drawing.Point(51, 42);
            this.scoreValueLabel.Name = "scoreValueLabel";
            this.scoreValueLabel.Size = new System.Drawing.Size(14, 15);
            this.scoreValueLabel.TabIndex = 1;
            this.scoreValueLabel.Text = "0";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripButton,
            this.gsmeRulesToolStripButton,
            this.settingsToolStripButton,
            this.resultsToolStripButton,
            this.gameExitToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(439, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newGameToolStripButton
            // 
            this.newGameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newGameToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newGameToolStripButton.Name = "newGameToolStripButton";
            this.newGameToolStripButton.Size = new System.Drawing.Size(73, 22);
            this.newGameToolStripButton.Text = "Новая игра";
            this.newGameToolStripButton.Click += new System.EventHandler(this.newGameToolStripButton_Click);
            // 
            // gsmeRulesToolStripButton
            // 
            this.gsmeRulesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.gsmeRulesToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("gsmeRulesToolStripButton.Image")));
            this.gsmeRulesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.gsmeRulesToolStripButton.Name = "gsmeRulesToolStripButton";
            this.gsmeRulesToolStripButton.Size = new System.Drawing.Size(90, 22);
            this.gsmeRulesToolStripButton.Text = "Правила игры";
            this.gsmeRulesToolStripButton.Click += new System.EventHandler(this.gsmeRulesToolStripButton_Click);
            // 
            // settingsToolStripButton
            // 
            this.settingsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.settingsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripButton.Image")));
            this.settingsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsToolStripButton.Name = "settingsToolStripButton";
            this.settingsToolStripButton.Size = new System.Drawing.Size(71, 22);
            this.settingsToolStripButton.Text = "Настройки";
            this.settingsToolStripButton.Click += new System.EventHandler(this.settingsToolStripButton_Click);
            // 
            // resultsToolStripButton
            // 
            this.resultsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.resultsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("resultsToolStripButton.Image")));
            this.resultsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resultsToolStripButton.Name = "resultsToolStripButton";
            this.resultsToolStripButton.Size = new System.Drawing.Size(104, 22);
            this.resultsToolStripButton.Text = "Результаты игры";
            this.resultsToolStripButton.Click += new System.EventHandler(this.resultsToolStripButton_Click);
            // 
            // gameExitToolStripButton
            // 
            this.gameExitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.gameExitToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("gameExitToolStripButton.Image")));
            this.gameExitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.gameExitToolStripButton.Name = "gameExitToolStripButton";
            this.gameExitToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.gameExitToolStripButton.Text = "Выход";
            this.gameExitToolStripButton.Click += new System.EventHandler(this.gameExitToolStripButton_Click);
            // 
            // bestScoreValueLabel
            // 
            this.bestScoreValueLabel.AutoSize = true;
            this.bestScoreValueLabel.Location = new System.Drawing.Point(335, 42);
            this.bestScoreValueLabel.Name = "bestScoreValueLabel";
            this.bestScoreValueLabel.Size = new System.Drawing.Size(14, 15);
            this.bestScoreValueLabel.TabIndex = 4;
            this.bestScoreValueLabel.Text = "0";
            // 
            // bestScoreLabel
            // 
            this.bestScoreLabel.AutoSize = true;
            this.bestScoreLabel.Location = new System.Drawing.Point(216, 42);
            this.bestScoreLabel.Name = "bestScoreLabel";
            this.bestScoreLabel.Size = new System.Drawing.Size(113, 15);
            this.bestScoreLabel.TabIndex = 3;
            this.bestScoreLabel.Text = "Лучший результат";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(439, 543);
            this.Controls.Add(this.bestScoreValueLabel);
            this.Controls.Add(this.bestScoreLabel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.scoreValueLabel);
            this.Controls.Add(this.scoreLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "2048";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label scoreLabel;
        private Label scoreValueLabel;
        private ToolStrip toolStrip1;
        private ToolStripButton newGameToolStripButton;
        private ToolStripButton gsmeRulesToolStripButton;
        private ToolStripButton gameExitToolStripButton;
        private ToolStripButton resultsToolStripButton;
        private Label bestScoreValueLabel;
        private Label bestScoreLabel;
        private ToolStripButton settingsToolStripButton;
    }
}