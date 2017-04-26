using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Kanji_learner
{
    public partial class Form1 : Form
    {

        private Lesson lesson = new Lesson("FirstGradeKanji.xml", true);
        private int originalWidth;
        private int characterBoxOriginalWidth;
        private int enterButtonOriginalX;
        private int misses = 0;

        public Form1()
        {
            InitializeComponent();
            originalWidth = this.Width;
            characterBoxOriginalWidth = characterTextBox.Width;
            enterButtonOriginalX = enterButton.Location.X;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (lesson.getRemainingCount() != 0)
            {
                checkAnswer();
            }
        }

        private void checkAnswer()
        {
            if (includeRomajiCheckBox.Checked && onAndKunCheckBox.Checked && lesson.isKanjiLesson())
            {
                onyomiTextBox.Focus();
                if (!lesson.correctOnyomi(onyomiTextBox.Text))
                {
                    fail();
                    return;
                }
                if (!lesson.correctKunyomi(kunyomiTextBox.Text))
                {
                    fail();
                    return;
                }
            }
            else if (includeRomajiCheckBox.Checked || !lesson.isKanjiLesson())
            {
                kunyomiTextBox.Focus();
                if (!lesson.correctRomaji(kunyomiTextBox.Text))
                {
                    fail();
                    return;
                }
            }

            if (includeTranslateCheckBox.Checked && lesson.isKanjiLesson())
            {
                if (!lesson.correctTranslation(translationTextBox.Text))
                {
                    fail();
                    return;
                }
            }
            pass();
        }

        private void updateCorrectCount()
        {
            numberCorrectLabel.Text = (lesson.getOriginalCount() - lesson.getRemainingCount()) + "/" + lesson.getOriginalCount() + " Correct.";
        }

        private void pass()
        {
            correctLabel.Visible = true;
            correctLabel.Text = "Correct!";
            correctLabel.ForeColor = Color.LawnGreen;
            if (!lesson.currentKanjiPassed())
            {
                MessageBox.Show("You have completed every character for this lesson!", "Notice", MessageBoxButtons.OK);
            }
            nextKanji(false);
            updateCorrectCount();
        }

        private void fail()
        {
            misses++;
            correctLabel.Visible = true;
            correctLabel.Text = "Miss!";
            correctLabel.ForeColor = Color.Red;
            if (misses != 1)
            {
                missLabel.Text = misses + " Misses.";
            }
            else
            {
                missLabel.Text = "1 Miss.";
            }
            nextKanji(true);
        }

        private void nextKanji(bool lastFailed)
        {
            if (lesson.isKanjiLesson())
            {
                correctOnyomiTextBox.Text = lesson.getOnyomiForCurrentKanji();
                correctKunyomiTextBox.Text = lesson.getKunyomiForCurrentKanji();
                correctTranslationTextBox.Text = lesson.getMeaningForCurrentKanji();
            }
            else
            {
                correctKunyomiTextBox.Text = lesson.getOnyomiForCurrentKanji();
            }

            if (randomizedOrderCheckBox.Checked)
            {
                lesson.selectRandomKanji();
            }
            else
            {
                lesson.selectNextKanji();
            }
            characterTextBox.Text = lesson.getKanji();
            strokesLabel.Text = lesson.getStrokesForCurrentKanji();
            translationTextBox.Text = "";
            onyomiTextBox.Text = "";
            kunyomiTextBox.Text = "";
            if (lesson.isKanjiLesson())
            {
                updateStrokeOrderBox();    
            }
        }

        private void updateStrokeOrderBox()
        {
            strokeOrderPictureBox.ImageLocation = "gifs/" + lesson.getKanji() + ".gif";
        }

        private void changeLesson(String filePath)
        {
            bool isKanji = filePath.Contains("Kanji") || filePath.Contains("LS");
            bool lastWasKanji = lesson.isKanjiLesson();
            correctLabel.Visible = false;
            lesson = new Lesson(filePath, isKanji);
            characterTextBox.Text = lesson.getKanji();
            strokesLabel.Text = lesson.getStrokesForCurrentKanji();
            translationTextBox.Text = "";
            onyomiTextBox.Text = "";
            kunyomiTextBox.Text = "";
            missLabel.Text = "0 Misses.";
            misses = 0;
            if (isKanji)
            {
                strokesDescriptLabel.Visible = true;
                strokesLabel.Visible = true;
                includeTranslateCheckBox.Visible = true;
                includeRomajiCheckBox.Visible = true;
                onAndKunCheckBox.Visible = true;
                correctOnyomiDescriptLabel.Visible = true;
                correctOnyomiTextBox.Visible = true;
                correctTranslationDescriptLabel.Visible = true;
                correctTranslationTextBox.Visible = true;
                translationLabel.Visible = true;
                translationTextBox.Visible = true;
                strokeOrderLabel.Visible = true;
                strokeOrderPictureBox.Visible = true;
                if (!lastWasKanji)
                {
                    includeRomajiCheckBox.Checked = true;
                    includeTranslateCheckBox.Checked = false;
                }
                this.Width = originalWidth;
                characterTextBox.Width = characterBoxOriginalWidth;
                enterButton.Location = new Point(enterButtonOriginalX, enterButton.Location.Y);
                correctKunyomiDescriptLabel.Text = "Previous kun'yomi:";
                setTextBoxesAccordingToCheckBoxes();
                updateStrokeOrderBox();
            }
            else
            {
                strokesDescriptLabel.Visible = false;
                strokesLabel.Visible = false;
                includeTranslateCheckBox.Visible = false;
                includeRomajiCheckBox.Visible = false;
                onAndKunCheckBox.Visible = false;
                correctOnyomiDescriptLabel.Visible = false;
                correctOnyomiTextBox.Visible = false;
                correctTranslationDescriptLabel.Visible = false;
                correctTranslationTextBox.Visible = false;
                translationLabel.Visible = false;
                translationTextBox.Visible = false;
                strokeOrderLabel.Visible = false;
                strokeOrderPictureBox.Visible = false;
                this.Width = originalWidth + characterBoxOriginalWidth / 10 * 7 - strokeOrderPictureBox.Width;
                characterTextBox.Width = characterBoxOriginalWidth + characterBoxOriginalWidth / 10 * 7;
                enterButton.Location = new Point(enterButtonOriginalX + characterBoxOriginalWidth / 10 * 7, enterButton.Location.Y);
                correctKunyomiDescriptLabel.Text = "Previous romaji:";
            }
            updateCorrectCount();
        }

        private void kanji1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeLesson("FirstGradeKanji.xml");
        }

        private void kanji2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeLesson("SecondGradeKanji.xml");
        }

        private void kanji3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeLesson("ThirdGradeKanji.xml");
        }

        private void kanji4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeLesson("FourthGradeKanji.xml");
        }

        private void kanji5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeLesson("FifthGradeKanji.xml");
        }

        private void kanji6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeLesson("SixthGradeKanji.xml");
        }

        private void hiraganaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeLesson("Hiragana.xml");
        }

        private void katakanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeLesson("Katakana.xml");
        }

        private void setTextBoxesAccordingToCheckBoxes()
        {
            kunyomiLabel.Visible = includeRomajiCheckBox.Checked;
            kunyomiTextBox.Visible = includeRomajiCheckBox.Checked;
            kunyomiLabel.Enabled = includeRomajiCheckBox.Checked;
            kunyomiTextBox.Enabled = includeRomajiCheckBox.Checked;

            onyomiLabel.Visible = onAndKunCheckBox.Checked && includeRomajiCheckBox.Checked;
            onyomiTextBox.Visible = onAndKunCheckBox.Checked && includeRomajiCheckBox.Checked;
            onyomiLabel.Enabled = onAndKunCheckBox.Checked && includeRomajiCheckBox.Checked;
            onyomiTextBox.Enabled = onAndKunCheckBox.Checked && includeRomajiCheckBox.Checked;

            kunyomiLabel.Text = onAndKunCheckBox.Checked ? "Kun'yomi" : "Romaji";
            
            translationLabel.Visible = includeTranslateCheckBox.Checked;
            translationTextBox.Visible = includeTranslateCheckBox.Checked;
            translationLabel.Enabled = includeTranslateCheckBox.Checked;
            translationTextBox.Enabled = includeTranslateCheckBox.Checked;
            onAndKunCheckBox.Enabled = includeRomajiCheckBox.Checked;
        }

        private void includeRomajiCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!includeTranslateCheckBox.Checked)
            {
                includeRomajiCheckBox.Checked = true;
            }
            setTextBoxesAccordingToCheckBoxes();
        }

        private void onAndKunCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            setTextBoxesAccordingToCheckBoxes();
        }

        private void includeTranslateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!includeRomajiCheckBox.Checked)
            {
                includeTranslateCheckBox.Checked = true;
            }
            setTextBoxesAccordingToCheckBoxes();
        }
        
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkAnswer();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Johan Ribom.\nThe stroke order gifs were taken from http://www.yamasa.org", "About", MessageBoxButtons.OK);
        }

        private void translationTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lS1480ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            changeLesson("LS1480.xml");
        }

    }
}
