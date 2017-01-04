namespace Kanji_learner
{
    partial class Form1
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
            this.characterLabel = new System.Windows.Forms.Label();
            this.characterTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiraganaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.katakanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kanji1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kanji2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kanji3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kanji4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kanji5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kanji6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.includeRomajiCheckBox = new System.Windows.Forms.CheckBox();
            this.onyomiTextBox = new System.Windows.Forms.TextBox();
            this.onyomiLabel = new System.Windows.Forms.Label();
            this.translationLabel = new System.Windows.Forms.Label();
            this.translationTextBox = new System.Windows.Forms.TextBox();
            this.onAndKunCheckBox = new System.Windows.Forms.CheckBox();
            this.correctLabel = new System.Windows.Forms.Label();
            this.correctOnyomiDescriptLabel = new System.Windows.Forms.Label();
            this.correctTranslationDescriptLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.kunyomiLabel = new System.Windows.Forms.Label();
            this.kunyomiTextBox = new System.Windows.Forms.TextBox();
            this.correctKunyomiDescriptLabel = new System.Windows.Forms.Label();
            this.includeTranslateCheckBox = new System.Windows.Forms.CheckBox();
            this.strokesDescriptLabel = new System.Windows.Forms.Label();
            this.strokesLabel = new System.Windows.Forms.Label();
            this.messageQueue1 = new System.Messaging.MessageQueue();
            this.correctOnyomiTextBox = new System.Windows.Forms.TextBox();
            this.correctKunyomiTextBox = new System.Windows.Forms.TextBox();
            this.correctTranslationTextBox = new System.Windows.Forms.TextBox();
            this.randomizedOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // characterLabel
            // 
            this.characterLabel.AutoSize = true;
            this.characterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.characterLabel.Location = new System.Drawing.Point(581, 34);
            this.characterLabel.Name = "characterLabel";
            this.characterLabel.Size = new System.Drawing.Size(91, 24);
            this.characterLabel.TabIndex = 0;
            this.characterLabel.Text = "Character";
            // 
            // characterTextBox
            // 
            this.characterTextBox.Font = new System.Drawing.Font("MS Mincho", 200F);
            this.characterTextBox.HideSelection = false;
            this.characterTextBox.Location = new System.Drawing.Point(585, 61);
            this.characterTextBox.Name = "characterTextBox";
            this.characterTextBox.ReadOnly = true;
            this.characterTextBox.Size = new System.Drawing.Size(293, 274);
            this.characterTextBox.TabIndex = 1;
            this.characterTextBox.TabStop = false;
            this.characterTextBox.Text = "一";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiraganaToolStripMenuItem,
            this.katakanaToolStripMenuItem,
            this.kanji1ToolStripMenuItem,
            this.kanji2ToolStripMenuItem,
            this.kanji3ToolStripMenuItem,
            this.kanji4ToolStripMenuItem,
            this.kanji5ToolStripMenuItem,
            this.kanji6ToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.editToolStripMenuItem.Text = "Lesson";
            // 
            // hiraganaToolStripMenuItem
            // 
            this.hiraganaToolStripMenuItem.Name = "hiraganaToolStripMenuItem";
            this.hiraganaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.hiraganaToolStripMenuItem.Text = "Hiragana";
            this.hiraganaToolStripMenuItem.Click += new System.EventHandler(this.hiraganaToolStripMenuItem_Click);
            // 
            // katakanaToolStripMenuItem
            // 
            this.katakanaToolStripMenuItem.Name = "katakanaToolStripMenuItem";
            this.katakanaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.katakanaToolStripMenuItem.Text = "Katakana";
            this.katakanaToolStripMenuItem.Click += new System.EventHandler(this.katakanaToolStripMenuItem_Click);
            // 
            // kanji1ToolStripMenuItem
            // 
            this.kanji1ToolStripMenuItem.Name = "kanji1ToolStripMenuItem";
            this.kanji1ToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.kanji1ToolStripMenuItem.Text = "First Grade Kanji";
            this.kanji1ToolStripMenuItem.Click += new System.EventHandler(this.kanji1ToolStripMenuItem_Click);
            // 
            // kanji2ToolStripMenuItem
            // 
            this.kanji2ToolStripMenuItem.Name = "kanji2ToolStripMenuItem";
            this.kanji2ToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.kanji2ToolStripMenuItem.Text = "Second Grade Kanji";
            this.kanji2ToolStripMenuItem.Click += new System.EventHandler(this.kanji2ToolStripMenuItem_Click);
            // 
            // kanji3ToolStripMenuItem
            // 
            this.kanji3ToolStripMenuItem.Name = "kanji3ToolStripMenuItem";
            this.kanji3ToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.kanji3ToolStripMenuItem.Text = "Third Grade Kanji";
            this.kanji3ToolStripMenuItem.Click += new System.EventHandler(this.kanji3ToolStripMenuItem_Click);
            // 
            // kanji4ToolStripMenuItem
            // 
            this.kanji4ToolStripMenuItem.Name = "kanji4ToolStripMenuItem";
            this.kanji4ToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.kanji4ToolStripMenuItem.Text = "Fourth Grade Kanji";
            this.kanji4ToolStripMenuItem.Click += new System.EventHandler(this.kanji4ToolStripMenuItem_Click);
            // 
            // kanji5ToolStripMenuItem
            // 
            this.kanji5ToolStripMenuItem.Name = "kanji5ToolStripMenuItem";
            this.kanji5ToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.kanji5ToolStripMenuItem.Text = "Fifth Grade Kanji";
            this.kanji5ToolStripMenuItem.Click += new System.EventHandler(this.kanji5ToolStripMenuItem_Click);
            // 
            // kanji6ToolStripMenuItem
            // 
            this.kanji6ToolStripMenuItem.Name = "kanji6ToolStripMenuItem";
            this.kanji6ToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.kanji6ToolStripMenuItem.Text = "Sixth Grade Kanji";
            this.kanji6ToolStripMenuItem.Click += new System.EventHandler(this.kanji6ToolStripMenuItem_Click);
            // 
            // includeRomajiCheckBox
            // 
            this.includeRomajiCheckBox.AutoSize = true;
            this.includeRomajiCheckBox.Checked = true;
            this.includeRomajiCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includeRomajiCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.includeRomajiCheckBox.Location = new System.Drawing.Point(267, 102);
            this.includeRomajiCheckBox.Name = "includeRomajiCheckBox";
            this.includeRomajiCheckBox.Size = new System.Drawing.Size(147, 28);
            this.includeRomajiCheckBox.TabIndex = 3;
            this.includeRomajiCheckBox.TabStop = false;
            this.includeRomajiCheckBox.Text = "Include romaji";
            this.includeRomajiCheckBox.UseVisualStyleBackColor = true;
            this.includeRomajiCheckBox.CheckedChanged += new System.EventHandler(this.includeRomajiCheckBox_CheckedChanged);
            // 
            // onyomiTextBox
            // 
            this.onyomiTextBox.AcceptsReturn = true;
            this.onyomiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.onyomiTextBox.Location = new System.Drawing.Point(267, 194);
            this.onyomiTextBox.Name = "onyomiTextBox";
            this.onyomiTextBox.Size = new System.Drawing.Size(280, 29);
            this.onyomiTextBox.TabIndex = 4;
            this.onyomiTextBox.Visible = false;
            this.onyomiTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // onyomiLabel
            // 
            this.onyomiLabel.AutoSize = true;
            this.onyomiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.onyomiLabel.Location = new System.Drawing.Point(263, 167);
            this.onyomiLabel.Name = "onyomiLabel";
            this.onyomiLabel.Size = new System.Drawing.Size(80, 24);
            this.onyomiLabel.TabIndex = 5;
            this.onyomiLabel.Text = "On\'yomi";
            this.onyomiLabel.Visible = false;
            // 
            // translationLabel
            // 
            this.translationLabel.AutoSize = true;
            this.translationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.translationLabel.Location = new System.Drawing.Point(263, 291);
            this.translationLabel.Name = "translationLabel";
            this.translationLabel.Size = new System.Drawing.Size(102, 24);
            this.translationLabel.TabIndex = 7;
            this.translationLabel.Text = "Translation";
            // 
            // translationTextBox
            // 
            this.translationTextBox.AcceptsReturn = true;
            this.translationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.translationTextBox.Location = new System.Drawing.Point(267, 318);
            this.translationTextBox.Name = "translationTextBox";
            this.translationTextBox.Size = new System.Drawing.Size(280, 29);
            this.translationTextBox.TabIndex = 17;
            this.translationTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // onAndKunCheckBox
            // 
            this.onAndKunCheckBox.AutoSize = true;
            this.onAndKunCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.onAndKunCheckBox.Location = new System.Drawing.Point(267, 136);
            this.onAndKunCheckBox.Name = "onAndKunCheckBox";
            this.onAndKunCheckBox.Size = new System.Drawing.Size(219, 28);
            this.onAndKunCheckBox.TabIndex = 8;
            this.onAndKunCheckBox.TabStop = false;
            this.onAndKunCheckBox.Text = "On\'yomi and Kun\'yomi";
            this.onAndKunCheckBox.UseVisualStyleBackColor = true;
            this.onAndKunCheckBox.CheckedChanged += new System.EventHandler(this.onAndKunCheckBox_CheckedChanged);
            // 
            // correctLabel
            // 
            this.correctLabel.AutoSize = true;
            this.correctLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.correctLabel.ForeColor = System.Drawing.Color.LawnGreen;
            this.correctLabel.Location = new System.Drawing.Point(13, 34);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(76, 24);
            this.correctLabel.TabIndex = 9;
            this.correctLabel.Text = "Correct!";
            this.correctLabel.Visible = false;
            // 
            // correctOnyomiDescriptLabel
            // 
            this.correctOnyomiDescriptLabel.AutoSize = true;
            this.correctOnyomiDescriptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.correctOnyomiDescriptLabel.Location = new System.Drawing.Point(13, 167);
            this.correctOnyomiDescriptLabel.Name = "correctOnyomiDescriptLabel";
            this.correctOnyomiDescriptLabel.Size = new System.Drawing.Size(159, 24);
            this.correctOnyomiDescriptLabel.TabIndex = 11;
            this.correctOnyomiDescriptLabel.Text = "Previous on\'yomi:";
            // 
            // correctTranslationDescriptLabel
            // 
            this.correctTranslationDescriptLabel.AutoSize = true;
            this.correctTranslationDescriptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.correctTranslationDescriptLabel.Location = new System.Drawing.Point(13, 291);
            this.correctTranslationDescriptLabel.Name = "correctTranslationDescriptLabel";
            this.correctTranslationDescriptLabel.Size = new System.Drawing.Size(177, 24);
            this.correctTranslationDescriptLabel.TabIndex = 13;
            this.correctTranslationDescriptLabel.Text = "Previous translation:";
            // 
            // enterButton
            // 
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.enterButton.Location = new System.Drawing.Point(779, 373);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(98, 38);
            this.enterButton.TabIndex = 16;
            this.enterButton.TabStop = false;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // kunyomiLabel
            // 
            this.kunyomiLabel.AutoSize = true;
            this.kunyomiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.kunyomiLabel.Location = new System.Drawing.Point(263, 232);
            this.kunyomiLabel.Name = "kunyomiLabel";
            this.kunyomiLabel.Size = new System.Drawing.Size(68, 24);
            this.kunyomiLabel.TabIndex = 18;
            this.kunyomiLabel.Text = "Romaji";
            // 
            // kunyomiTextBox
            // 
            this.kunyomiTextBox.AcceptsReturn = true;
            this.kunyomiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.kunyomiTextBox.Location = new System.Drawing.Point(267, 259);
            this.kunyomiTextBox.Name = "kunyomiTextBox";
            this.kunyomiTextBox.Size = new System.Drawing.Size(280, 29);
            this.kunyomiTextBox.TabIndex = 6;
            this.kunyomiTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // correctKunyomiDescriptLabel
            // 
            this.correctKunyomiDescriptLabel.AutoSize = true;
            this.correctKunyomiDescriptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.correctKunyomiDescriptLabel.Location = new System.Drawing.Point(13, 232);
            this.correctKunyomiDescriptLabel.Name = "correctKunyomiDescriptLabel";
            this.correctKunyomiDescriptLabel.Size = new System.Drawing.Size(168, 24);
            this.correctKunyomiDescriptLabel.TabIndex = 19;
            this.correctKunyomiDescriptLabel.Text = "Previous kun\'yomi:";
            // 
            // includeTranslateCheckBox
            // 
            this.includeTranslateCheckBox.AutoSize = true;
            this.includeTranslateCheckBox.Checked = true;
            this.includeTranslateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includeTranslateCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.includeTranslateCheckBox.Location = new System.Drawing.Point(267, 68);
            this.includeTranslateCheckBox.Name = "includeTranslateCheckBox";
            this.includeTranslateCheckBox.Size = new System.Drawing.Size(180, 28);
            this.includeTranslateCheckBox.TabIndex = 21;
            this.includeTranslateCheckBox.TabStop = false;
            this.includeTranslateCheckBox.Text = "Include translation";
            this.includeTranslateCheckBox.UseVisualStyleBackColor = true;
            this.includeTranslateCheckBox.CheckedChanged += new System.EventHandler(this.includeTranslateCheckBox_CheckedChanged);
            // 
            // strokesDescriptLabel
            // 
            this.strokesDescriptLabel.AutoSize = true;
            this.strokesDescriptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.strokesDescriptLabel.Location = new System.Drawing.Point(581, 338);
            this.strokesDescriptLabel.Name = "strokesDescriptLabel";
            this.strokesDescriptLabel.Size = new System.Drawing.Size(77, 24);
            this.strokesDescriptLabel.TabIndex = 22;
            this.strokesDescriptLabel.Text = "Strokes:";
            // 
            // strokesLabel
            // 
            this.strokesLabel.AutoSize = true;
            this.strokesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.strokesLabel.Location = new System.Drawing.Point(652, 338);
            this.strokesLabel.Name = "strokesLabel";
            this.strokesLabel.Size = new System.Drawing.Size(20, 24);
            this.strokesLabel.TabIndex = 23;
            this.strokesLabel.Text = "1";
            // 
            // messageQueue1
            // 
            this.messageQueue1.MessageReadPropertyFilter.LookupId = true;
            this.messageQueue1.SynchronizingObject = this;
            // 
            // correctOnyomiTextBox
            // 
            this.correctOnyomiTextBox.AcceptsReturn = true;
            this.correctOnyomiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.correctOnyomiTextBox.Location = new System.Drawing.Point(17, 194);
            this.correctOnyomiTextBox.Name = "correctOnyomiTextBox";
            this.correctOnyomiTextBox.ReadOnly = true;
            this.correctOnyomiTextBox.Size = new System.Drawing.Size(218, 29);
            this.correctOnyomiTextBox.TabIndex = 24;
            this.correctOnyomiTextBox.TabStop = false;
            // 
            // correctKunyomiTextBox
            // 
            this.correctKunyomiTextBox.AcceptsReturn = true;
            this.correctKunyomiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.correctKunyomiTextBox.Location = new System.Drawing.Point(17, 259);
            this.correctKunyomiTextBox.Name = "correctKunyomiTextBox";
            this.correctKunyomiTextBox.ReadOnly = true;
            this.correctKunyomiTextBox.Size = new System.Drawing.Size(218, 29);
            this.correctKunyomiTextBox.TabIndex = 25;
            this.correctKunyomiTextBox.TabStop = false;
            // 
            // correctTranslationTextBox
            // 
            this.correctTranslationTextBox.AcceptsReturn = true;
            this.correctTranslationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.correctTranslationTextBox.Location = new System.Drawing.Point(17, 318);
            this.correctTranslationTextBox.Name = "correctTranslationTextBox";
            this.correctTranslationTextBox.ReadOnly = true;
            this.correctTranslationTextBox.Size = new System.Drawing.Size(218, 29);
            this.correctTranslationTextBox.TabIndex = 26;
            this.correctTranslationTextBox.TabStop = false;
            // 
            // randomizedOrderCheckBox
            // 
            this.randomizedOrderCheckBox.AutoSize = true;
            this.randomizedOrderCheckBox.Checked = true;
            this.randomizedOrderCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.randomizedOrderCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.randomizedOrderCheckBox.Location = new System.Drawing.Point(267, 34);
            this.randomizedOrderCheckBox.Name = "randomizedOrderCheckBox";
            this.randomizedOrderCheckBox.Size = new System.Drawing.Size(186, 28);
            this.randomizedOrderCheckBox.TabIndex = 27;
            this.randomizedOrderCheckBox.TabStop = false;
            this.randomizedOrderCheckBox.Text = "Randomized order";
            this.randomizedOrderCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.enterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 423);
            this.Controls.Add(this.randomizedOrderCheckBox);
            this.Controls.Add(this.correctTranslationTextBox);
            this.Controls.Add(this.correctKunyomiTextBox);
            this.Controls.Add(this.correctOnyomiTextBox);
            this.Controls.Add(this.strokesLabel);
            this.Controls.Add(this.strokesDescriptLabel);
            this.Controls.Add(this.includeTranslateCheckBox);
            this.Controls.Add(this.correctKunyomiDescriptLabel);
            this.Controls.Add(this.kunyomiLabel);
            this.Controls.Add(this.kunyomiTextBox);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.correctTranslationDescriptLabel);
            this.Controls.Add(this.correctOnyomiDescriptLabel);
            this.Controls.Add(this.correctLabel);
            this.Controls.Add(this.onAndKunCheckBox);
            this.Controls.Add(this.translationLabel);
            this.Controls.Add(this.translationTextBox);
            this.Controls.Add(this.onyomiLabel);
            this.Controls.Add(this.onyomiTextBox);
            this.Controls.Add(this.includeRomajiCheckBox);
            this.Controls.Add(this.characterTextBox);
            this.Controls.Add(this.characterLabel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label characterLabel;
        private System.Windows.Forms.TextBox characterTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiraganaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem katakanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kanji1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kanji2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kanji3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kanji4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kanji5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kanji6ToolStripMenuItem;
        private System.Windows.Forms.CheckBox includeRomajiCheckBox;
        private System.Windows.Forms.TextBox onyomiTextBox;
        private System.Windows.Forms.Label onyomiLabel;
        private System.Windows.Forms.Label translationLabel;
        private System.Windows.Forms.TextBox translationTextBox;
        private System.Windows.Forms.CheckBox onAndKunCheckBox;
        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Label correctOnyomiDescriptLabel;
        private System.Windows.Forms.Label correctTranslationDescriptLabel;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label kunyomiLabel;
        private System.Windows.Forms.TextBox kunyomiTextBox;
        private System.Windows.Forms.Label correctKunyomiDescriptLabel;
        private System.Windows.Forms.CheckBox includeTranslateCheckBox;
        private System.Windows.Forms.Label strokesDescriptLabel;
        private System.Windows.Forms.Label strokesLabel;
        private System.Messaging.MessageQueue messageQueue1;
        private System.Windows.Forms.TextBox correctTranslationTextBox;
        private System.Windows.Forms.TextBox correctKunyomiTextBox;
        private System.Windows.Forms.TextBox correctOnyomiTextBox;
        private System.Windows.Forms.CheckBox randomizedOrderCheckBox;
    }
}

