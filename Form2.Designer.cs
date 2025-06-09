using System;
using System.Windows.Forms;

namespace mayıntarlası
{
    public partial class Form2 : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxName = new TextBox();
            label2 = new Label();
            numericUpDownGridSize = new NumericUpDown();
            label3 = new Label();
            numericUpDownMines = new NumericUpDown();
            buttonStartGame = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGridSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMines).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(221, 181);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.Red;
            textBoxName.Location = new Point(338, 178);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(140, 27);
            textBoxName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(170, 236);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 2;
            label2.Text = "Grid Boyutu (10-30): ";
            // 
            // numericUpDownGridSize
            // 
            numericUpDownGridSize.BackColor = Color.Red;
            numericUpDownGridSize.Location = new Point(338, 234);
            numericUpDownGridSize.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownGridSize.Name = "numericUpDownGridSize";
            numericUpDownGridSize.Size = new Size(94, 27);
            numericUpDownGridSize.TabIndex = 3;
            numericUpDownGridSize.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Ivory;
            label3.Location = new Point(219, 290);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 4;
            label3.Text = "Mayın Sayısı: ";
            // 
            // numericUpDownMines
            // 
            numericUpDownMines.BackColor = Color.Red;
            numericUpDownMines.Location = new Point(338, 283);
            numericUpDownMines.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownMines.Name = "numericUpDownMines";
            numericUpDownMines.Size = new Size(94, 27);
            numericUpDownMines.TabIndex = 5;
            numericUpDownMines.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // buttonStartGame
            // 
            buttonStartGame.BackColor = Color.White;
            buttonStartGame.Location = new Point(535, 245);
            buttonStartGame.Name = "buttonStartGame";
            buttonStartGame.Size = new Size(140, 30);
            buttonStartGame.TabIndex = 6;
            buttonStartGame.Text = "Oyuna Başla";
            buttonStartGame.UseVisualStyleBackColor = false;
            buttonStartGame.Click += buttonStartGame_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(248, 47);
            label4.Name = "label4";
            label4.Size = new Size(206, 20);
            label4.TabIndex = 7;
            label4.Text = "Yemliha Gedikbaşı 210229010";
            // 
            // Form2
            // 
            BackColor = Color.DimGray;
            ClientSize = new Size(720, 491);
            Controls.Add(label4);
            Controls.Add(buttonStartGame);
            Controls.Add(numericUpDownMines);
            Controls.Add(label3);
            Controls.Add(numericUpDownGridSize);
            Controls.Add(label2);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mayın Tarlası - Başlangıç";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownGridSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMines).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownGridSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownMines;
        private System.Windows.Forms.Button buttonStartGame;
        private Label label4;
    }
}
