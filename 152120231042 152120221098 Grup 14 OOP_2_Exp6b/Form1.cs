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

namespace _152120231042_152120221098_Grup_14_OOP_2_Exp6b
{

    public partial class Form1 : Form
    {
        

        public static bool isOpen = true;
        public Form1()
        {
            InitializeComponent();

            this.BackgroundImage = Image.FromFile("hangman/cover2.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            buttonBasla.FlatStyle = FlatStyle.Flat;
            buttonBasla.FlatAppearance.BorderSize = 0;
            buttonBasla.BackColor = Color.FromArgb(0, 100, 0);
            buttonBasla.ForeColor = Color.White;
            buttonBasla.Font = new Font("Comic Sans MS", 20, FontStyle.Bold);
            buttonBasla.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 139, 34);

            buttonAyarlar.FlatStyle = FlatStyle.Flat;
            buttonAyarlar.FlatAppearance.BorderSize = 0;
            buttonAyarlar.BackColor = Color.FromArgb(0, 100, 0);
            buttonAyarlar.ForeColor = Color.White;
            buttonAyarlar.Font = new Font("Comic Sans MS", 20, FontStyle.Bold);
            buttonAyarlar.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 139, 34);

            buttonCikis.FlatStyle = FlatStyle.Flat;
            buttonCikis.FlatAppearance.BorderSize = 0;
            buttonCikis.BackColor = Color.FromArgb(0, 100, 0);
            buttonCikis.ForeColor = Color.White;
            buttonCikis.Font = new Font("Comic Sans MS", 20, FontStyle.Bold);
            buttonCikis.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 139, 34);
            /*
            comboBoxSubject.FlatStyle = FlatStyle.Flat;
            comboBoxSubject.BackColor = Color.FromArgb(100, 100, 100);
            comboBoxSubject.ForeColor = Color.White;
            comboBoxSubject.Font = new Font("Comic Sans MS", 20, FontStyle.Bold);
            comboBoxSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            */
            labelHangman.BackColor = Color.Transparent;

            comboBoxSubject.Items.Add("Maths");
            comboBoxSubject.Items.Add("History");
            comboBoxSubject.Items.Add("Geography");
            comboBoxSubject.Items.Add("General Culture");
            comboBoxSubject.Items.Add("Sports");  
        }

      
        private void buttonBasla_Click(object sender, EventArgs e)
        {
            string fileName = "Options.csv";
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                if (lines.Length >= 2)
                {
                    isOpen = false;
                    this.Hide();
                    string[] data = lines[1].Split(',');
                    Form2 form2 = new Form2(data[0], int.Parse(data[1]), data[2], int.Parse(data[3]));
                    form2.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(fileName + " adlı dosyada yetersiz satır sayısı!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(fileName + " adlı bir dosya bulunamadı!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            

            if (isOpen)
            {
                DialogResult isQuit = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Oyundan Ayrılıyorsunuz", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (isQuit == DialogResult.No)
                {
                    e.Cancel = true;
                    isOpen = true;
                }
                else
                {
                    isOpen = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult isQuit = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Oyundan Ayrılıyorsunuz", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (isQuit == DialogResult.No)
            {
                
                isOpen = true;
            }
            else
            {
                isOpen = false;
                this.Hide();
                this.Close();
            }
        }

        private void buttonAyarlar_Click(object sender, EventArgs e)
        {
            isOpen = false;
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
            this.Close();
        }

        private void comboBoxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {


            string fileName = "Options.csv";
            string selectedSubject = comboBoxSubject.SelectedItem.ToString();

            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                if (lines.Length >= 2)
                {
                    string[] data = lines[1].Split(',');

                    
                    data[0] = selectedSubject;

                    
                    lines[1] = string.Join(",", data);

                    File.WriteAllLines(fileName, lines); 
                }
            }
            else
            {
                
                string header = "Subject,Time,Difficulty,PictureIndex";

                string defaultTime = "50";
                string defaultDifficulty = "Easy";
                string defaultPictureIndex = "0";

                string newLine = $"{selectedSubject},{defaultTime},{defaultDifficulty},{defaultPictureIndex}";

                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine(header);
                    writer.WriteLine(newLine);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string fileName = "Options.csv";
           

            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                if (lines.Length >= 2)
                {
                    string[] data = lines[1].Split(',');


                    comboBoxSubject.SelectedItem = data[0];


                    lines[1] = string.Join(",", data);

                    File.WriteAllLines(fileName, lines);
                }
            }

           
            Panel panel = new Panel
            {
                Size = new Size(comboBoxSubject.Width, comboBoxSubject.Height),
                Location = comboBoxSubject.Location,
                BackColor = Color.FromArgb(100, 100, 100)  
            };
            this.Controls.Add(panel);
            panel.BringToFront();

          
            comboBoxSubject.Parent = panel;
            comboBoxSubject.Location = new Point(0, 0);
            comboBoxSubject.FlatStyle = FlatStyle.Flat;
            comboBoxSubject.ForeColor = Color.White;
            comboBoxSubject.Font = new Font("Comic Sans MS", 20, FontStyle.Bold);
            comboBoxSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSubject.BackColor = Color.FromArgb(100, 100, 100);

            
            comboBoxSubject.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxSubject.DrawItem += (s, ev) =>
            {
                ev.DrawBackground();

                
                Color bgColor = (ev.State & DrawItemState.Selected) == DrawItemState.Selected ?
                                Color.FromArgb(34, 139, 34) :
                                Color.FromArgb(100, 100, 100);

                using (SolidBrush brush = new SolidBrush(bgColor))
                {
                    ev.Graphics.FillRectangle(brush, ev.Bounds);
                }

               
                using (SolidBrush textBrush = new SolidBrush(Color.White))
                {
                    ev.Graphics.DrawString(comboBoxSubject.Items[ev.Index].ToString(),
                                          comboBoxSubject.Font,
                                          textBrush,
                                          ev.Bounds);
                }

                ev.DrawFocusRectangle();
            };

           
            panel.MouseEnter += (s, ev) => panel.BackColor = Color.FromArgb(34, 139, 34);
            panel.MouseLeave += (s, ev) => panel.BackColor = Color.FromArgb(100, 100, 100);
        }
    }
}
