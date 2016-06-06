using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace сАпер
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("курсач/Z.jpg");
           

        }

        private int[,] array;
        private Button[,] bttn_array;
        private PictureBox[,] pb_array;
        private int timer = 0;
        int mintCount=0, w_str=0, h_stb=0, startX = 20, startY = 70,r=0,g=0,b=0, flagCount=0;
        private Image img1 = Image.FromFile("курсач/1.png");
        private Image img2 = Image.FromFile("курсач/2.gif");
        private Image img3 = Image.FromFile("курсач/3.jpg");
        private Image img4 = Image.FromFile("курсач/4.gif");
        private Image img5 = Image.FromFile("курсач/5.gif");
        private Image img6 = Image.FromFile("курсач/6.jpg");
        private Image img7 = Image.FromFile("курсач/7.png");
        private Image img8 = Image.FromFile("курсач/8.jpg");
        private Image img0 = Image.FromFile("курсач/P.jpg");
        private Image imgx = Image.FromFile("курсач/B.jpg");
        private Image imgf = Image.FromFile("курсач/f.jpg");
        private Image imgPB= Image.FromFile("курсач/PB.jpg");

        private void createGrid()
        {
            this.Width = startX * 2 + (w_str) * 25;
            this.Height = startY * 2 + (h_stb) * 25;

            array = new int[w_str, h_stb];
            bttn_array = new Button[w_str, h_stb];
            pb_array = new PictureBox[w_str, h_stb];

            addButtonsAndPictures();
            addMines();
            MinesAround();

            
        }


        //создаём кнопку
        private Button createButton(int x, int y, int strok, int stolb,int r,int g,int b)
        {
            Button bttn = new Button();

            bttn.Text = "";
            bttn.Name = strok.ToString() + " " + stolb.ToString();
            bttn.Size = new System.Drawing.Size(20, 20);
            bttn.BackColor = Color.FromArgb(255,r ,g ,b );
            bttn.Location = new System.Drawing.Point(x, y);
            Controls.AddRange(new System.Windows.Forms.Control[] { bttn, });
            bttn.Click += new System.EventHandler(bttnOnclick);
            bttn.MouseDown += new System.Windows.Forms.MouseEventHandler(bttnOnclick_r);
            return bttn;
        }


        //создаём PictureBox
        private PictureBox createPictureBox(int x, int y, int strok, int stolb)
        {
            PictureBox pb = new PictureBox();
            pb.Name = strok.ToString() + " " + stolb.ToString();
            pb.Size = new System.Drawing.Size(20, 20);
           pb.Location = new System.Drawing.Point(x, y);
            Controls.AddRange(new System.Windows.Forms.Control[] { pb, });
            pb.MouseDown += new System.Windows.Forms.MouseEventHandler(pbOnclick_r);
            return pb;
        }

        //Добавим кнопки и картинки)
        private void addButtonsAndPictures()
        {
            for (int i = 0; i < w_str; i++)
            {
                for (int j = 0; j < h_stb; j++)
                {
                    array[i, j] = 0;

                    bttn_array[i, j] = createButton(startX + 24 * i, startY + 24 * j, i, j,r,g,b);
                    pb_array[i, j] = createPictureBox(startX + 24 * i, startY + 24 * j,i,j);
                }
            }
        }


        //очистить поле
        private void clearPreviousGame()
        {
            if (bttn_array != null)
            {
                for (int i = 0; i < w_str; i++)
                {
                    for (int j = 0; j < h_stb; j++)
                    {
                        if (Controls.Contains(bttn_array[i, j]))
                        {
                            Controls.Remove(bttn_array[i, j]);
                        }

                        if (Controls.Contains(pb_array[i, j]))
                        {
                            Controls.Remove(pb_array[i, j]);
                        }
                    }
                }
            }
            pictureBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            

        }


        //добавляем мины
        private void addMines()
        {
            Random randomgenerator = new Random();
            int currMineCount = mintCount;
            while (currMineCount > 0)
            {
                int mineX = randomgenerator.Next(w_str);
                int mineY = randomgenerator.Next(h_stb);

                if (array[mineX, mineY] == 0)
                {
                    pb_array[mineX, mineY].SizeMode = PictureBoxSizeMode.StretchImage;
                    pb_array[mineX, mineY].Image =imgx;
                   pb_array[mineX, mineY].Location = new System.Drawing.Point(pb_array[mineX, mineY].Location.X , pb_array[mineX, mineY].Location.Y);
                    array[mineX, mineY] = -1; 
                    currMineCount--;
                }
            }
        }


        //мины вокруг
        private void MinesAround()
        {
            for (int x = 0; x < w_str; x++)
            {
                for (int y = 0; y < h_stb; y++)
                {
                    if (array[x, y] != -1)
                    {
                        int numMines = 0;
                        for (int dx = -1; dx <= 1; dx++)
                        {
                            for (int dy = -1; dy <= 1; dy++)
                            {
                                if (x + dx >= 0 && y + dy >= 0 && x + dx < w_str && y + dy < h_stb)
                                {
                                    if (array[x + dx, y + dy] == -1)
                                    {
                                        numMines++;
                                    }
                                }
                            }
                        }
                        array[x, y] = numMines;

                        switch (array[x,y])
                        {
                            case 0:
                                pb_array[x, y].SizeMode = PictureBoxSizeMode.StretchImage;
                                pb_array[x, y].Image = img0;

                                break;

                            case 1:
                                pb_array[x, y].SizeMode = PictureBoxSizeMode.StretchImage;
                                pb_array[x, y].Image = img1;

                                break;

                            case 2:
                                pb_array[x, y].SizeMode = PictureBoxSizeMode.StretchImage;
                                pb_array[x, y].Image = img2;

                                break;

                            case 3:
                                pb_array[x, y].SizeMode = PictureBoxSizeMode.StretchImage;
                                pb_array[x, y].Image =img3;

                                break;

                            case 4:
                                pb_array[x, y].SizeMode = PictureBoxSizeMode.StretchImage;
                                pb_array[x, y].Image =img4;

                                break;

                            case 5:
                                pb_array[x, y].SizeMode = PictureBoxSizeMode.StretchImage;
                                pb_array[x, y].Image =img5;

                                break;

                            case 6:
                                pb_array[x, y].SizeMode = PictureBoxSizeMode.StretchImage;
                                pb_array[x, y].Image = img6;

                                break;

                            case 7:
                                pb_array[x, y].SizeMode = PictureBoxSizeMode.StretchImage;
                                pb_array[x, y].Image = img7;

                                break;

                            case 8:
                                pb_array[x, y].SizeMode = PictureBoxSizeMode.StretchImage;
                                pb_array[x, y].Image = img8;

                                break;

                            default:
                                break;
                        }
                    }
                }
            }
        }

        private void разработчикиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void разработчикиToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
        }


        //правый клик на пиктчу
        void pbOnclick_r(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (!timer1.Enabled)
                {
                    return;
                }
                PictureBox pbclick = sender as PictureBox;


                string[] split = pbclick.Name.Split(new Char[] { ' ' });
                int x = System.Convert.ToInt32(split[0]);
                int y = System.Convert.ToInt32(split[1]);

                if (bttn_array[x,y].Visible==false && array[x,y]==100 )

                {
                    bttn_array[x, y].Visible = true;
                  
                    flagCount++;

                   
                           
                                int numMines = 0;
                                for (int dxx = -1; dxx <= 1; dxx++)
                                {
                                    for (int dyy = -1; dyy <= 1; dyy++)
                                    {
                                        if (x + dxx >= 0 && y + dyy >= 0 && x + dxx < w_str && y + dyy < h_stb)
                                        {
                                            if (array[x + dxx, y + dyy] == -1)
                                            {
                                                numMines++;
                                            }
                                        }
                                    }
                                }
                                array[x, y] = numMines;

                                switch (array[x, y])
                    {
                        
                            

                            
                        case 0:
                            pb_array[x, y].SizeMode = PictureBoxSizeMode.StretchImage;
                            pb_array[x, y].Image = img0;

                            break;

                        case 1:
                            pb_array[x, y].SizeMode = PictureBoxSizeMode.StretchImage;
                            pb_array[x, y].Image = img1;
                            
                            break;

                        case 2:
                            pb_array[x, y].SizeMode = PictureBoxSizeMode.StretchImage;
                            pb_array[x, y].Image = img2;
                           
                            break;

                        case 3:
                            pb_array[x, y].SizeMode = PictureBoxSizeMode.StretchImage;
                            pb_array[x, y].Image =img3;
                            
                            break;

                        case 4:
                            pb_array[x, y].SizeMode = PictureBoxSizeMode.StretchImage;
                            pb_array[x, y].Image = img4;
                            
                            break;

                        case 5:
                            pb_array[x, y].SizeMode = PictureBoxSizeMode.StretchImage;
                            pb_array[x, y].Image = img5;
                           
                            break;

                        case 6:
                            pb_array[x, y].SizeMode = PictureBoxSizeMode.StretchImage;
                            pb_array[x, y].Image = img6;
                           
                            break;

                        case 7:
                            pb_array[x, y].SizeMode = PictureBoxSizeMode.StretchImage;
                            pb_array[x, y].Image = img7;
                           
                            break;

                        case 8:
                            pb_array[x, y].SizeMode = PictureBoxSizeMode.StretchImage;
                            pb_array[x, y].Image = img8;
                            
                            break;

                        default:
                            break;
                    }
                }
                if (bttn_array[x, y].Visible == false && array[x, y] == 200)
                {
                    bttn_array[x, y].Visible = true;
                    array[x, y] = -1;
                    flagCount++;
                    pb_array[x, y].SizeMode = PictureBoxSizeMode.StretchImage;
                    pb_array[x, y].Image = imgx;
                }
            }
        }




        //правый клик на кнопку
        void bttnOnclick_r(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right)
            {
                if (!timer1.Enabled)
                {
                    return;
                }
                Button bttnClick = sender as Button;


                string[] split = bttnClick.Name.Split(new Char[] { ' ' });
                int x = System.Convert.ToInt32(split[0]);
                int y = System.Convert.ToInt32(split[1]);

                if (bttn_array[x, y].Visible == true && flagCount>0)

                {
                    bttn_array[x, y].Visible = false;
                    
                    pb_array[x, y].SizeMode = PictureBoxSizeMode.StretchImage;
                    pb_array[x, y].Image = imgf;
                    flagCount--;
                    if (array[x, y] == -1)
                        array[x, y]=200;
                    else
                        array[x, y] = 100;

                }
            }
           
            win(w_str, h_stb, mintCount);
        }




        //нажатие на кнопку
        void bttnOnclick(object sender, System.EventArgs e)
        {
            if (!timer1.Enabled)
            {
                return;
            }

            Button bttnClick = sender as Button;


            string[] split = bttnClick.Name.Split(new Char[] { ' ' });
            int x = System.Convert.ToInt32(split[0]);
            int y = System.Convert.ToInt32(split[1]);

            if (array[x, y] == -1)//Игра окончена
            {

                timer1.Enabled = false;
                for (int i = 0; i < w_str; i++)
                    for (int j = 0; j < h_stb; j++)
                        if (array[i, j] == -1)
                            bttn_array[i, j].Visible = false;
                for (int i = 0; i < w_str; i++)
                    for (int j = 0; j < h_stb; j++)
                        if (array[i, j] == 100)
                        {
                            pb_array[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                            pb_array[i, j].Image = imgPB;
                        }
                Form5 frm = new Form5();
                frm.ShowDialog();

            }
            else
            {
                openfield(x, y);
            }




            bttnClick.Visible = false;
            win(w_str, h_stb, mintCount);


            


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.setParent(this);
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }



        //раскрываем пустые

        void openfield(int i, int j)
        {
            if (!bttn_array[i, j].Visible)
            {
                return;
            }
            bttn_array[i, j].Visible = false;
            for (int di = -1; di <= 1; di++)
            {
                for (int dj = -1; dj <= 1; dj++)
                {
                    if (i + di >= 0 && j + dj >= 0 && i + di < w_str && j + dj < h_stb)
                    {
                        if (array[i, j] == 0)
                        {
                            openfield(i + di, j + dj);
                        }
                    }
                }
            }
        }

        //победка
        void win(int w_str, int h_stb, int mintCount)
        {
            int k = 0;
            for (int i = 0; i < w_str; i++)
            {
                for (int j = 0; j < h_stb; j++)
                {
                    if (array[i, j] >=0 && bttn_array[i,j].Visible==false)
                    {
                       
                 
                        k++;
                    }
                }
            }



            if (k == w_str * h_stb)
            {
                timer1.Enabled = false;
                Form6 frm = new Form6();
                frm.ShowDialog();
            }
        }

        public void startGame(int difficulty,int color)
        {
            clearPreviousGame();
            label2.Text = "0";
            timer = 0;
            timer1.Enabled=true;
           

            switch (difficulty)
            {
                case 1:
                    mintCount = 10;
                    w_str = 9;
                    h_stb = 9;
                    flagCount = 10;

                    break;
                case 2:
                    mintCount = 40;
                   w_str = 16;
                   h_stb = 16;
                    flagCount = 40;
                    break;
                case 3:
                    mintCount = 99;
                    w_str = 30;
                    h_stb = 16;
                    flagCount = 99;
                    break;
                    default:
                    
                    break;
            }

            label4.Text = mintCount.ToString();
          
            switch (color)
            {
                case 1:
                    b = 150;
                    g = 0;
                    r = 0;

                    break;
                case 2:
                    g = 255;
                    b = 0;
                    r = 0;
                    break;
                case 3:
                    r = 150;
                    g = 0;
                    b = 0;
                    break;

                default:
                    break;

            }

            createGrid();

        }

       

        

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.setParent(this);
            f2.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer++;
            label2.Text = timer.ToString();
        }
    }

}
