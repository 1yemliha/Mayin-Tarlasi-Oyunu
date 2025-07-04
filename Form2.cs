﻿using System;
using System.Windows.Forms;

namespace mayıntarlası
{
    public partial class Form2 : Form
    {
        public int gridSize { get; set; }
        public int mineCount { get; set; }
        public string playerName { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            numericUpDownGridSize.Value = 10;
            numericUpDownMines.Value = 10;
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            playerName = textBoxName.Text;
            gridSize = (int)numericUpDownGridSize.Value;
            mineCount = (int)numericUpDownMines.Value;

            if (string.IsNullOrWhiteSpace(playerName))
            {
                MessageBox.Show("Lütfen bir isim giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (gridSize < 10 || gridSize > 30)
            {
                MessageBox.Show("Grid boyutunu 10 ile 30 arasında bir sayı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericUpDownGridSize.Focus();
                return;
            }

            if (mineCount < 10)
            {
                MessageBox.Show("Mayın sayısı 10'dan düşük olamaz. Lütfen 10 veya daha fazla bir sayı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericUpDownMines.Focus();
                return;
            }

            Form1 form1 = new Form1(gridSize, mineCount);
            form1.Show();
            this.Hide();
        }
    }
}
