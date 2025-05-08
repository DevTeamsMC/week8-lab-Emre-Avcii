using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _152120231042_152120221098_Grup_14_OOP_2_Exp6b.Form2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.IO;


namespace _152120231042_152120221098_Grup_14_OOP_2_Exp6b
{
    public partial class Form2 : Form
    {
        int time = 20;
        bool isEnd = false;
        public struct Word_Struct
        {
            public string Subject;
            public string Difficulty;
            public string Word;
            public string Hint;
            public Word_Struct(string subject, string difficulty, string word, string hint)
            {
                this.Subject = subject;
                this.Difficulty = difficulty;
                this.Word = word;
                this.Hint = hint;
            }
        }
        public Word_Struct[] Words = new Word_Struct[]
        {
            // Maths - Easy
            new Word_Struct("Maths", "Easy", "Square", "A shape"),
            new Word_Struct("Maths", "Easy", "Triangle", "Three sides"),
            new Word_Struct("Maths", "Easy", "Circle", "Round shape"),
            new Word_Struct("Maths", "Easy", "Addition", "Summing numbers"),
            new Word_Struct("Maths", "Easy", "Subtraction", "Taking away"),
            new Word_Struct("Maths", "Easy", "Multiplication", "Repeated addition"),
            new Word_Struct("Maths", "Easy", "Division", "Splitting equally"),
            new Word_Struct("Maths", "Easy", "Fraction", "Part of a whole"),
            new Word_Struct("Maths", "Easy", "Percentage", "Out of 100"),
            new Word_Struct("Maths", "Easy", "Equation", "Mathematical statement"),

            // Maths - Normal
            new Word_Struct("Maths", "Normal", "Algebra", "Solving equations"),
            new Word_Struct("Maths", "Normal", "Geometry", "Study of shapes"),
            new Word_Struct("Maths", "Normal", "Trigonometry", "Study of triangles"),
            new Word_Struct("Maths", "Normal", "Calculus", "Study of change"),
            new Word_Struct("Maths", "Normal", "Matrix", "Array of numbers"),
            new Word_Struct("Maths", "Normal", "Vector", "Magnitude and direction"),
            new Word_Struct("Maths", "Normal", "Derivative", "Rate of change"),
            new Word_Struct("Maths", "Normal", "Integral", "Summing parts"),
            new Word_Struct("Maths", "Normal", "Probability", "Chance of occurrence"),
            new Word_Struct("Maths", "Normal", "Statistics", "Data analysis"),

            // Maths - Hard
            new Word_Struct("Maths", "Hard", "Cryptography", "Securing communication"),
            new Word_Struct("Maths", "Hard", "Topology", "Study of spatial properties"),
            new Word_Struct("Maths", "Hard", "Eigenvalue", "Special scalar in matrix theory"),
            new Word_Struct("Maths", "Hard", "Optimization", "Finding best solution"),
            new Word_Struct("Maths", "Hard", "Tensor", "Generalization of vectors"),
            new Word_Struct("Maths", "Hard", "Combinatorics", "Counting arrangements"),
            new Word_Struct("Maths", "Hard", "Fourier", "Transforms functions"),
            new Word_Struct("Maths", "Hard", "Differential", "Equation with derivatives"),
            new Word_Struct("Maths", "Hard", "Complex", "Number with real and imaginary parts"),

            //-------------------------------------------------------------------------

            // History - Easy
            new Word_Struct("History", "Easy", "Revolution", "Overthrow of a government"),
            new Word_Struct("History", "Easy", "Empire", "Extensive group of states ruled by a single authority"),
            new Word_Struct("History", "Easy", "Colonization", "Establishing control over foreign lands"),
            new Word_Struct("History", "Easy", "Monarchy", "Rule by a king or queen"),
            new Word_Struct("History", "Easy", "War", "Armed conflict between states"),
            new Word_Struct("History", "Easy", "Treaty", "Formal agreement between countries"),
            new Word_Struct("History", "Easy", "Civilization", "Advanced human society"),
            new Word_Struct("History", "Easy", "Renaissance", "Cultural rebirth in Europe"),
            new Word_Struct("History", "Easy", "Dynasty", "Ruling family"),
            new Word_Struct("History", "Easy", "Invention", "Creation of a new device or method"),

            // History - Normal
            new Word_Struct("History", "Normal", "Feudalism", "Medieval social system"),
            new Word_Struct("History", "Normal", "Industry", "Rise of mechanized production"),
            new Word_Struct("History", "Normal", "Charter", "Document outlining a country's laws"),
            //new Word_Struct("History", "Normal", "Revival", "European cultural revival"),
            new Word_Struct("History", "Normal", "Colonialism", "Extending power through force"),
            new Word_Struct("History", "Normal", "Patriotism", "Pride in one's nation"),
            //new Word_Struct("History", "Normal", "Discovery", "Discovering new lands"),
            new Word_Struct("History", "Normal", "Tension", "Political tension between superpowers"),
            new Word_Struct("History", "Normal", "Crusades", "Medieval religious wars"),
            new Word_Struct("History", "Normal", "Republic", "Government by the people"),

            // History - Hard
            //new Word_Struct("History", "Hard", "Magna", "1215 English legal charter"),
            new Word_Struct("History", "Hard", "Byzantine", "Eastern Roman Empire"),
            new Word_Struct("History", "Hard", "Meiji", "Modernization of Japan"),
            //new Word_Struct("History", "Hard", "Aid", "US aid to Europe post-WWII"),
            //new Word_Struct("History", "Hard", "Sparta", "Conflict between Athens and Sparta"),
            //new Word_Struct("History", "Hard", "Overthrow", "Overthrow of King James II"),
            //new Word_Struct("History", "Hard", "Division", "Division of a territory"),
            new Word_Struct("History", "Hard", "Protestantism", "Religious movement against Catholic Church"),
            new Word_Struct("History", "Hard", "Bolshevism", "Main idea of the Russian Communist Party"),
           // new Word_Struct("History", "Hard", "Segregation", "Racial segregation in South Africa"),    

            //-------------------------------------------------------------------------

            // Geography - Easy
            new Word_Struct("Geography", "Easy", "Mountain", "High natural elevation"),
            new Word_Struct("Geography", "Easy", "River", "Flowing body of water"),
            new Word_Struct("Geography", "Easy", "Desert", "Dry, arid area"),
            new Word_Struct("Geography", "Easy", "Island", "Land surrounded by water"),
            new Word_Struct("Geography", "Easy", "Ocean", "Vast body of salt water"),
            new Word_Struct("Geography", "Easy", "Valley", "Low area between hills"),
            new Word_Struct("Geography", "Easy", "Continent", "Large landmass"),
            new Word_Struct("Geography", "Easy", "Peninsula", "Land surrounded by water on three sides"),
            new Word_Struct("Geography", "Easy", "Glacier", "Large mass of moving ice"),
            new Word_Struct("Geography", "Easy", "Volcano", "Mountain with a crater"),

            // Geography - Normal
            new Word_Struct("Geography", "Normal", "Archipelago", "Group of islands"),
            new Word_Struct("Geography", "Normal", "Estuary", "Where a river meets the sea"),
            new Word_Struct("Geography", "Normal", "Plateau", "Flat elevated area"),
            new Word_Struct("Geography", "Normal", "Latitude", "Horizontal lines on a map"),
            new Word_Struct("Geography", "Normal", "Longitude", "Vertical lines on a map"),
            new Word_Struct("Geography", "Normal", "Tundra", "Cold, treeless plain"),
            new Word_Struct("Geography", "Normal", "Delta", "Landform at a river mouth"),
            new Word_Struct("Geography", "Normal", "Basin", "Depression in the earth's surface"),
            new Word_Struct("Geography", "Normal", "Biome", "Large ecosystem with similar climate"),
            new Word_Struct("Geography", "Normal", "Isthmus", "Narrow land connecting two areas"),

            // Geography - Hard
            new Word_Struct("Geography", "Hard", "Orography", "Study of mountains"),
            new Word_Struct("Geography", "Hard", "Geomorphology", "Study of landforms"),
            new Word_Struct("Geography", "Hard", "Cartography", "Map-making science"),
            new Word_Struct("Geography", "Hard", "Anthropogeography", "Study of human impact on geography"),
            new Word_Struct("Geography", "Hard", "Permafrost", "Permanently frozen ground"),
            new Word_Struct("Geography", "Hard", "Bathymetry", "Measurement of ocean depths"),
            new Word_Struct("Geography", "Hard", "Toponymy", "Study of place names"),
            new Word_Struct("Geography", "Hard", "Geomatics", "Geospatial data analysis"),
            new Word_Struct("Geography", "Hard", "Biogeography", "Distribution of species"),
            new Word_Struct("Geography", "Hard", "Pedology", "Study of soils"),

            //-------------------------------------------------------------------------

            // General Culture - Easy
            new Word_Struct("General Culture", "Easy", "Cuisine", "Style of cooking"),
            new Word_Struct("General Culture", "Easy", "Mythology", "Collection of myths"),
            new Word_Struct("General Culture", "Easy", "Festival", "Public celebration"),
            new Word_Struct("General Culture", "Easy", "Folkdance", "Traditional dance"),
            new Word_Struct("General Culture", "Easy", "Folklore", "Traditional beliefs"),
            new Word_Struct("General Culture", "Easy", "Ritual", "Ceremonial act"),
            new Word_Struct("General Culture", "Easy", "Symbol", "Representation of an idea"),
            new Word_Struct("General Culture", "Easy", "Art", "Creative expression"),
            new Word_Struct("General Culture", "Easy", "Language", "System of communication"),
            new Word_Struct("General Culture", "Easy", "Literature", "Written works"),

            // General Culture - Normal
            new Word_Struct("General Culture", "Normal", "Philosophy", "Study of fundamental questions"),
            new Word_Struct("General Culture", "Normal", "Ethics", "Moral principles"),
            new Word_Struct("General Culture", "Normal", "Myth", "Traditional story"),
            new Word_Struct("General Culture", "Normal", "Cuisine", "Traditional cooking style"),
            new Word_Struct("General Culture", "Normal", "Dialect", "Regional language variation"),
            new Word_Struct("General Culture", "Normal", "Folklore", "Traditional beliefs and customs"),
            new Word_Struct("General Culture", "Normal", "Patriotism", "Love for one's country"),
            new Word_Struct("General Culture", "Normal", "Proverb", "Short saying with a moral"),
            new Word_Struct("General Culture", "Normal", "Renaissance", "Rebirth of art and culture"),
            new Word_Struct("General Culture", "Normal", "Tradition", "Customs passed down generations"),

            // General Culture - Hard
            new Word_Struct("General Culture", "Hard", "Existentialism", "Philosophy of existence and choice"),
            new Word_Struct("General Culture", "Hard", "Semiotics", "Study of signs and symbols"),
            new Word_Struct("General Culture", "Hard", "Structuralism", "Analyzing human culture through structures"),
            new Word_Struct("General Culture", "Hard", "Neoclassicism", "Revival of classical style"),
            new Word_Struct("General Culture", "Hard", "Absurdism", "Philosophy of meaninglessness"),
            new Word_Struct("General Culture", "Hard", "Anthropology", "Study of human societies"),
            new Word_Struct("General Culture", "Hard", "Iconoclasm", "Rejection of religious images"),
            new Word_Struct("General Culture", "Hard", "Minimalism", "Art style emphasizing simplicity"),
            new Word_Struct("General Culture", "Hard", "Surrealism", "Art that merges reality and dream"),
            new Word_Struct("General Culture", "Hard", "Postmodernism", "Late 20th-century cultural movement"),

            //-------------------------------------------------------------------------

            // Sports - Easy
            new Word_Struct("Sports", "Easy", "Soccer", "Game with a ball and goals"),
            new Word_Struct("Sports", "Easy", "Basketball", "Game with hoops"),
            new Word_Struct("Sports", "Easy", "Tennis", "Game with rackets and net"),
            new Word_Struct("Sports", "Easy", "Swimming", "Water-based sport"),
            new Word_Struct("Sports", "Easy", "Cycling", "Riding a bike"),
            new Word_Struct("Sports", "Easy", "Running", "Moving quickly on foot"),
            new Word_Struct("Sports", "Easy", "Boxing", "Fighting sport with gloves"),
            new Word_Struct("Sports", "Easy", "Golf", "Sport with clubs and holes"),
            new Word_Struct("Sports", "Easy", "Volleyball", "Game with a net and ball"),
            new Word_Struct("Sports", "Easy", "Baseball", "Bat-and-ball sport"),

            // Sports - Normal
            new Word_Struct("Sports", "Normal", "Triathlon", "Three-sport race"),
            new Word_Struct("Sports", "Normal", "Decathlon", "Ten-event track competition"),
            new Word_Struct("Sports", "Normal", "Relay", "Team race with baton"),
            new Word_Struct("Sports", "Normal", "Freestyle", "Swimming stroke"),
            new Word_Struct("Sports", "Normal", "Offside", "Soccer rule violation"),
            new Word_Struct("Sports", "Normal", "Checkmate", "Winning chess move"),
            new Word_Struct("Sports", "Normal", "Scrimmage", "Practice match"),
            new Word_Struct("Sports", "Normal", "Puck", "Hockey object hit with a stick"),
            //new Word_Struct("Sports", "Normal", "Grand Slam", "Winning all major titles"),
            new Word_Struct("Sports", "Normal", "Knockout", "Boxing win by incapacitation"),

            // Sports - Hard
            new Word_Struct("Sports", "Hard", "Pentathlon", "Five-sport athletic competition"),
            new Word_Struct("Sports", "Hard", "Heptathlon", "Seven-event track competition"),
            new Word_Struct("Sports", "Hard","Decathlon", "Ten-event track and field competition"),
            new Word_Struct("Sports", "Hard", "Sabermetrics", "Advanced baseball statistics"),
            new Word_Struct("Sports", "Hard", "Curling", "Sliding stones on ice towards a target"),
            new Word_Struct("Sports", "Hard", "Bouldering", "Rock climbing without ropes"),
            new Word_Struct("Sports", "Hard", "Aikido", "Japanese martial art emphasizing fluid motion"),
            new Word_Struct("Sports", "Hard", "Snatch", "Weightlifting movement"),
            new Word_Struct("Sports", "Hard", "Decoy", "Player meant to distract opponents"),
            new Word_Struct("Sports", "Hard", "Sandbagging", "Intentionally performing poorly"),
        };
        public struct User_Info_Struct
        {
            public string Subject;
            public int Time;
            public string Difficulty;
            public int PictureIndex;

            public User_Info_Struct(string subject, int time, string difficulty, int pictureIndex)
            {
                this.Subject = subject;
                this.Time = time;
                this.Difficulty = difficulty;
                this.PictureIndex = pictureIndex;
            }
        }
        public User_Info_Struct User_Info = new User_Info_Struct("", -1, "", -1);
        public int Kelime_Index;
        public int Kelime_Uzunlugu;
        public string Dogru_Tahminler = "";
        public string Yanlis_Tahminler = "";
        public int Puan = 100;
        public System.Drawing.Image[][] Adam = new System.Drawing.Image[][]
        {
            //balon
            new System.Drawing.Image[]
            {
                System.Drawing.Image.FromFile("hangman/balon00.png"),
                System.Drawing.Image.FromFile("hangman/balon01.png"),
                System.Drawing.Image.FromFile("hangman/balon02.png"),
                System.Drawing.Image.FromFile("hangman/balon03.png"),
                System.Drawing.Image.FromFile("hangman/balon04.png"),
                System.Drawing.Image.FromFile("hangman/balon05.png"),
                System.Drawing.Image.FromFile("hangman/balon06.png"),
                System.Drawing.Image.FromFile("hangman/balon07.png"),
                System.Drawing.Image.FromFile("hangman/balon08.png"),
                System.Drawing.Image.FromFile("hangman/balon09.png"),
                System.Drawing.Image.FromFile("hangman/balon10.png"),
            },
            //adam
            new System.Drawing.Image[] 
            {
                System.Drawing.Image.FromFile("hangman/man-01.jpg"),
                System.Drawing.Image.FromFile("hangman/man-01.jpg"),
                System.Drawing.Image.FromFile("hangman/man-02.jpg"),
                System.Drawing.Image.FromFile("hangman/man-03.jpg"),
                System.Drawing.Image.FromFile("hangman/man-04.jpg"),
                System.Drawing.Image.FromFile("hangman/man-05.jpg"),
                System.Drawing.Image.FromFile("hangman/man-06.jpg"),
                System.Drawing.Image.FromFile("hangman/man-07.jpg"),
                System.Drawing.Image.FromFile("hangman/man-08.jpg"),
                System.Drawing.Image.FromFile("hangman/man-09.jpg"),
                System.Drawing.Image.FromFile("hangman/man-10.jpg"),
            },
            //Çöp adam

            new System.Drawing.Image[]
            {
                System.Drawing.Image.FromFile("hangman/0.jpg"),
                System.Drawing.Image.FromFile("hangman/1.jpg"),
                System.Drawing.Image.FromFile("hangman/2.jpg"),
                System.Drawing.Image.FromFile("hangman/3.jpg"),
                System.Drawing.Image.FromFile("hangman/4.jpg"),
                System.Drawing.Image.FromFile("hangman/5.jpg"),
                System.Drawing.Image.FromFile("hangman/6.jpg"),
                System.Drawing.Image.FromFile("hangman/7.jpg"),
                System.Drawing.Image.FromFile("hangman/8.jpg"),
                System.Drawing.Image.FromFile("hangman/9.jpg"),
                System.Drawing.Image.FromFile("hangman/10.jpg"),
            },
         
            //Çiçek

            new System.Drawing.Image[] 
            {
                System.Drawing.Image.FromFile("hangman/c11.jpg"),
                System.Drawing.Image.FromFile("hangman/c10.jpg"),
                System.Drawing.Image.FromFile("hangman/c9.jpg"),
                System.Drawing.Image.FromFile("hangman/c8.jpg"),
                System.Drawing.Image.FromFile("hangman/c7.jpg"),
                System.Drawing.Image.FromFile("hangman/c6.jpg"),
                System.Drawing.Image.FromFile("hangman/c5.jpg"),
                System.Drawing.Image.FromFile("hangman/c4.jpg"),
                System.Drawing.Image.FromFile("hangman/c3.jpg"),
                System.Drawing.Image.FromFile("hangman/c2.jpg"),
                System.Drawing.Image.FromFile("hangman/c1.jpg"),
            }

        };
        public Form2(string subject, int time, string difficulty, int pictureIndex)
        {
            InitializeComponent();
            timer1.Interval = 1000; 
            timer1.Start();
            labelZaman.Text = time.ToString();
            labelKonu.Text = $"Time : {time} seconds , Category : {subject} , Difficulty : {difficulty}";

            groupBoxGame.BackColor = Color.Transparent;
            groupBoxPicture.BackColor = Color.Transparent;
           
            groupBoxPicture.BackColor = Color.Transparent;
            labelHangman.BackColor = Color.Transparent;
            this.pictureBoxAdam.BackgroundImage = this.Adam[pictureIndex][10 - (this.Puan / 10)];
            this.pictureBoxAdam.BackgroundImageLayout = ImageLayout.Stretch;

            labelKelime.BorderStyle = BorderStyle.None;
            textBoxTahmin.BorderStyle = BorderStyle.None;

            
            buttonIpucu.FlatStyle = FlatStyle.Flat;
            buttonIpucu.FlatAppearance.BorderSize = 0;
            buttonIpucu.BackColor = Color.Gold; 
            buttonIpucu.ForeColor = Color.Black;
            buttonIpucu.FlatAppearance.MouseOverBackColor = Color.Khaki;

            
            buttonOyunuBitir.FlatStyle = FlatStyle.Flat;
            buttonOyunuBitir.FlatAppearance.BorderSize = 0;
            buttonOyunuBitir.BackColor = Color.DarkRed; 
            buttonOyunuBitir.ForeColor = Color.White;
            buttonOyunuBitir.FlatAppearance.MouseOverBackColor = Color.Maroon;

           
            buttonTahminEt.FlatStyle = FlatStyle.Flat;
            buttonTahminEt.FlatAppearance.BorderSize = 0;
            buttonTahminEt.BackColor = Color.MidnightBlue; 
            buttonTahminEt.ForeColor = Color.White;
            buttonTahminEt.FlatAppearance.MouseOverBackColor = Color.Navy;

            this.User_Info = new User_Info_Struct(subject, time, difficulty, pictureIndex);
            //MessageBox.Show(this.User_Info.Subject + " " + this.User_Info.Time.ToString() + " " + this.User_Info.Difficulty + " " + this.User_Info.PictureIndex.ToString());
            List<Word_Struct> ProperWords = new List<Word_Struct>();
            List<int> ProperWordsIndices = new List<int>();
            for (int i = 0; i < this.Words.Length; i++)
            {
                if (this.Words[i].Subject == this.User_Info.Subject && this.Words[i].Difficulty == this.User_Info.Difficulty)
                {
                    ProperWords.Add(this.Words[i]);
                    ProperWordsIndices.Add(i);
                }
            }
            //MessageBox.Show(ProperWords.Count.ToString() + " a");
            System.Random random = new System.Random();
            int temp_index = random.Next(0, ProperWords.Count);
            //MessageBox.Show(temp_index.ToString() + " b");
            this.Kelime_Index = ProperWordsIndices[temp_index];
            //MessageBox.Show(this.Kelime_Index.ToString() + " c");
            this.Kelime_Uzunlugu = this.Words[this.Kelime_Index].Word.Length;
            {
                string temp = "";
                for (int i = 0; i < this.Kelime_Uzunlugu - 1; i++)
                {
                    temp += "_ ";
                }
                temp += "_";
                this.labelKelime.Text = temp;
            }
            this.time = User_Info.Time;
            this.labelKelimeUzunluguSayi.Text = this.Kelime_Uzunlugu.ToString();
            this.labelPuanMiktar.Text = this.Puan.ToString() + "P";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        public bool IsClicked = false;
        public bool isOpen = true;
        public bool oynuyorMu = true;
        private void buttonOyunuBitir_Click(object sender, EventArgs e)
        {  
            if (!IsClicked && isOpen)
            {
               
                DialogResult isQuit = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Oyundan Ayrılıyorsunuz", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (isQuit == DialogResult.Yes)
                {
                    isOpen = false;
                    IsClicked = true;
                    DialogResult message = MessageBox.Show("Oyun kapatılıyor", "Oyundan Ayrıldınız", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                   
                }
            }
        }

        
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        { 
            if (!IsClicked && oynuyorMu && !isEnd)
            {
                DialogResult isQuit = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Oyundan Ayrılıyorsunuz", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (isQuit == DialogResult.No)
                {
                    e.Cancel = true;

                }
            }
        }

        private void buttonIpucu_Click(object sender, EventArgs e)
        {
            this.label_ipucu.Text = "İpucu : " + this.Words[this.Kelime_Index].Hint;
            //this.label_ipucu.Text = "İpucu : " + this.Kelimeler[this.Kelime_Index].Aciklama; 
        }

        private void buttonTahminEt_Click(object sender, EventArgs e)
        {
            if (this.textBoxTahmin.Text.Length != 1)
            {
                MessageBox.Show("Lütfen Bir Harf Giriniz", "Hata!", MessageBoxButtons.OK);
                return;
            }
            char tahmin = char.Parse(this.textBoxTahmin.Text.ToString());
            tahmin = char.ToLower(tahmin);
            bool is_already_used = false;
            for (int i = 0; i < this.Dogru_Tahminler.Length; i++)
            {
                if (this.Dogru_Tahminler[i] == tahmin)
                {
                    is_already_used = true;
                    break;
                }
            }
            for (int i = 0; i < this.Yanlis_Tahminler.Length; i++)
            {
                if (this.Yanlis_Tahminler[i] == tahmin)
                {
                    is_already_used = true;
                    break;
                }
            }
            if (is_already_used == true)
            {
                MessageBox.Show("Bu " + tahmin + " Harfi İle Daha Önce Tahmin Yapılmıştır. Lütfen Başka Bir Harf Seçiniz", "Hata!", MessageBoxButtons.OK);
                return;
            }
            bool is_found_in_word = false;

            //for (int i = 0; i < this.Kelimeler[this.Kelime_Index].Kelime.Length; i++)
            for (int i = 0; i < this.Words[this.Kelime_Index].Word.Length; i++)
            {
                //if (this.Kelimeler[this.Kelime_Index].Kelime[i] == tahmin)
                if (char.ToLower(this.Words[this.Kelime_Index].Word[i]) == tahmin)
                {
                    is_found_in_word = true;
                    char[] temp = new char[this.labelKelime.Text.Length];
                    temp = this.labelKelime.Text.ToCharArray();
                    temp[2 * i] = tahmin;
                    this.labelKelime.Text = new string(temp);
                }
            }
            if (is_found_in_word == true)
            {
                this.Dogru_Tahminler += tahmin;
                if (this.labelKelime.Text.Contains('_') == false)
                {
                    //win
                    this.BackColor = System.Drawing.Color.DarkGreen;
                    DialogResult message = MessageBox.Show("Oyunu Kazandınız", "Tebrikler !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (message == DialogResult.OK && oynuyorMu)
                    {
                        oynuyorMu = false;
                        this.Close();
                        Application.Restart();
                    }

                }
                else if (this.Puan == 0)
                {
                    
                    this.BackColor = System.Drawing.Color.Red;
                    
                }
            }
            else
            {
                this.Yanlis_Tahminler += tahmin;
                this.labelYanlısTahminler.Text = "";
                for (int i = 0; i < this.Yanlis_Tahminler.Length - 1; i++)
                {
                    this.labelYanlısTahminler.Text += this.Yanlis_Tahminler[i] + ", ";
                }
                this.labelYanlısTahminler.Text += this.Yanlis_Tahminler[this.Yanlis_Tahminler.Length - 1];
                this.Puan -= 10;
                this.labelPuanMiktar.Text = this.Puan.ToString() + "P";
                this.pictureBoxAdam.BackgroundImage = this.Adam[this.User_Info.PictureIndex][10 - (this.Puan / 10)];
                if (this.Puan != 0 && !isEnd)
                {
                    
                }
                else
                {
                    //lose
                    this.BackColor = System.Drawing.Color.DarkRed;
                    timer1.Stop();
                    DialogResult ok= MessageBox.Show("Kaybettiniz", "Oyun Kaybedildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (ok == DialogResult.OK && oynuyorMu )
                    {
                        oynuyorMu = false;
                        this.Close();
                        Application.Restart();
                    }
                }
            }
            this.textBoxTahmin.Text = "";
        }

        private void textBoxTahmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetter(e.KeyChar) && this.textBoxTahmin.Text.Length != 1) || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
            else if (char.IsLetter(e.KeyChar))
            { 
                e.KeyChar = char.ToLower(e.KeyChar);
            }
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            if (time >= 0)
            {
                labelZaman.Text = time.ToString();
            }
            else
            {
                isEnd = true;
                timer1.Stop();
                this.BackColor = System.Drawing.Color.DarkRed;
                DialogResult ok = MessageBox.Show("Kaybettiniz", "Oyun Kaybedildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (ok == DialogResult.OK && oynuyorMu)
                {
                    
                    oynuyorMu = false;
                    Application.Restart();
                    return;
                }

            }
        }

        private void pictureBoxAdam_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
        }

        private void labelKalanZamanYazi_Click(object sender, EventArgs e)
        {

        }
    }
}
