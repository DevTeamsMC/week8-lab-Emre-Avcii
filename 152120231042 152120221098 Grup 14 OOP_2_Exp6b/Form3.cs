using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq.Expressions;


namespace _152120231042_152120221098_Grup_14_OOP_2_Exp6b
{
    public partial class Form3 : Form
    {
        public bool isOpen = true;

        public System.Drawing.Image[] Picture = new System.Drawing.Image[]
        {
            System.Drawing.Image.FromFile("hangman/balon00.png"),
            System.Drawing.Image.FromFile("hangman/man-10.jpg"),
            System.Drawing.Image.FromFile("hangman/10.jpg"),
            System.Drawing.Image.FromFile("hangman/c10.jpg"),
        };

        public Form3()
        {
            InitializeComponent();
            pictureBoxPicture.BackgroundImageLayout = ImageLayout.Stretch;

            comboBoxDifficult.Items.Add("Easy");
            comboBoxDifficult.Items.Add("Normal");
            comboBoxDifficult.Items.Add("Hard");

            comboBoxResimTuru.Items.Add("Balon");
            comboBoxResimTuru.Items.Add("Normal Adam");
            comboBoxResimTuru.Items.Add("Çöp Adam");
            comboBoxResimTuru.Items.Add("Çiçek");

            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.BackColor = Color.FromArgb(0, 100, 0);
            buttonBack.ForeColor = Color.White;
            buttonBack.Font = new Font("Comic Sans MS", 20, FontStyle.Bold);
            buttonBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 139, 34);

            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.BackColor = Color.FromArgb(25, 25, 112); 
            buttonSave.ForeColor = Color.White;
            buttonSave.Font = new Font("Comic Sans MS", 20, FontStyle.Bold);
            buttonSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 139); 



        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string fileName = "Options.csv";

            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                if (lines.Length >= 2)
                {
                    string[] data = lines[1].Split(',');

                    if (data.Length >= 4)
                    {
                        
                        string difficulty = data[2];
                        comboBoxDifficult.SelectedItem = difficulty;

                       
                        if (int.TryParse(data[1], out int time))
                        {
                            numericUpDownTime.Value = time;
                        }

                       
                        string pictureIndex = data[3];
                        switch (pictureIndex)
                        {
                            case "0":
                                comboBoxResimTuru.SelectedItem = "Balon";
                                break;
                            case "1":
                                comboBoxResimTuru.SelectedItem = "Normal Adam";
                                break;
                            case "2":
                                comboBoxResimTuru.SelectedItem = "Çöp Adam";
                                break;
                            case "3":
                                comboBoxResimTuru.SelectedItem = "Çiçek";
                                break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Options.csv bulunamadı. Varsayılan ayarlar yüklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBoxZorluk_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

       

        private void buttonBack_Click(object sender, EventArgs e)
        {
            isOpen = false;
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
            
        }


        string FindPictureIndex()
        {
            if (comboBoxResimTuru.SelectedItem.ToString() == "Balon")
            {
                return "0";
            }
            else if(comboBoxResimTuru.SelectedItem.ToString() == "Normal Adam") 
            {
                return "1";
            }
            else if(comboBoxResimTuru.SelectedItem.ToString() == "Çöp Adam")
            {
                return "2";
            }
            else
            {
                return "3";
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string difficulty = comboBoxDifficult.SelectedItem.ToString();
            string time = numericUpDownTime.Value.ToString();
            string pictureIndex = FindPictureIndex();

            string fileName = "Options.csv";

            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                if (lines.Length >= 2)
                {
                    string[] data = lines[1].Split(',');

                   
                    data[1] = time;
                    data[2] = difficulty;
                    data[3] = pictureIndex;

                    
                    lines[1] = string.Join(",", data);

                    
                    File.WriteAllLines(fileName, lines);
                    MessageBox.Show("Saved", "Saved", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("The File not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void comboBoxResimTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxResimTuru.SelectedIndex;
            if (index >= 0 && index < Picture.Length)
            {
                pictureBoxPicture.Image = Picture[index];
                pictureBoxPicture.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isOpen)
            {
                DialogResult isQuit = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Oyundan Ayrılıyorsunuz", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (isQuit == DialogResult.No)
                {
                    e.Cancel = true;

                }
                else
                {
                    isOpen = false;
                }
                
            }
           
        }
    }
}
