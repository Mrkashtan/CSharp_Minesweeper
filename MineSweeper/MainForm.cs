using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MineSweeper.NewGameForm newGame = new MineSweeper.NewGameForm();
            newGame.setParent(this);
            newGame.ShowDialog();
        }

        /// <summary>
        /// Раскрываем все пустые поля вокруг
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void removeBlank(int x, int y)
        {
            if (!btn_grid[x, y].Visible)
            {
                return;
            }
            btn_grid[x, y].Visible = false;
            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    if (x + dx >= 0 && y + dy >= 0 && x + dx < width && y + dy < height)
                    {
                        if (grid[x, y] == 0)
                        {
                            removeBlank(x + dx, y + dy);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Обработка нажатия на кнопку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void bttnOnclick(object sender, System.EventArgs e)
        {
            if (!tmr_ElapsedTime.Enabled)
            {
                return;
            }

            Button bttnClick = sender as Button;

            if (bttnClick == null)
            {
                return; //это не кнопка (как такое возможно?)
            }
        
            string[] split = bttnClick.Name.Split(new Char[] { ' ' });
            int x = System.Convert.ToInt32(split[0]);
            int y = System.Convert.ToInt32(split[1]);

            if (grid[x, y] == -1)
            {
                //Игра окончена
                tmr_ElapsedTime.Enabled = false;
                for (int xx = 0; xx < width; xx++)
                {
                    for (int yy = 0; yy < height; yy++)
                    {
                        if (grid[xx, yy] == -1)
                        {
                            btn_grid[xx, yy].Visible = false;
                        }
                    }
                }
            } else
            {
                removeBlank(x, y);
            }
            bttnClick.Visible = false;
        }

        /// <summary>
        /// Создаем кнопку, под которой лейбл мин
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="gridX"></param>
        /// <param name="gridY"></param>
        /// <returns></returns>
        private Button createButton(int x, int y, int gridX, int gridY)
        {
            Button bttn = new Button();

            bttn.Text = "";
            bttn.Name = gridX.ToString() + " " + gridY.ToString();
            bttn.Size = new System.Drawing.Size(24, 24);
            bttn.BackColor = Color.Cyan;
            bttn.Location = new System.Drawing.Point(x, y);
            Controls.AddRange(new System.Windows.Forms.Control[] { bttn,  });
            bttn.Click += new System.EventHandler(bttnOnclick);
            //bttn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bttnOnRightClick);
            return bttn;
        }

        /// <summary>
        /// Создаем лейбл-индикатор кол-ва мин
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private Label createLable(int x, int y)
        {
            Label lbl = new Label();
            lbl.Name = x.ToString() + " " + y.ToString();
            lbl.Text = "0";
            lbl.Size = new System.Drawing.Size(24, 24);
            lbl.Font = new Font("Microsoft Sans Serif", 15.75f, lbl.Font.Style, lbl.Font.Unit);
            lbl.Location = new System.Drawing.Point(x, y);
            Controls.AddRange(new System.Windows.Forms.Control[] { lbl, });
            return lbl;
        }


        private int[,] grid;
        private Button[,] btn_grid;
        private Label[,] lbl_grid;
        private int timer = 0;

        int mintCount, width, height, startX = 15, startY = 68;
        private bool createGrid()
        {
            this.Width = startX * 2 + (width + 1) * 24 - 5;
            this.Height = startY * 2 + (height) * 24;

            grid = new int[width, height];
            btn_grid = new Button[width, height];
            lbl_grid = new Label[width, height];

            addButtonsAndLabels();
            addMines();
            fillGridWithMinesCountAround();

            return true;
        }

        /// <summary>
        /// Заполнить массив количеством мин вокруг
        /// </summary>
        private void fillGridWithMinesCountAround()
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (grid[x, y] != -1)
                    {
                        int numMines = 0;
                        for (int dx = -1; dx <= 1; dx++)
                        {
                            for (int dy = -1; dy <= 1; dy++)
                            {
                                if (x + dx >= 0 && y + dy >= 0 && x + dx < width && y + dy < height)
                                {
                                    if (grid[x + dx, y + dy] == -1)
                                    {
                                        numMines++;
                                    }
                                }
                            }
                        }
                        grid[x, y] = numMines;

                        if (numMines == 0)
                        {
                            lbl_grid[x, y].Text = " ";
                        }
                        else
                        {
                            lbl_grid[x, y].Text = numMines.ToString();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Добавляем мины
        /// </summary>
        private void addMines()
        {
            Random rnd1 = new Random();
            int currMineCount = mintCount;
            while (currMineCount > 0)
            {
                int mineX = rnd1.Next(width);
                int mineY = rnd1.Next(height);

                if (grid[mineX, mineY] == 0)
                {
                    lbl_grid[mineX, mineY].Text = "*";
                    lbl_grid[mineX, mineY].Font = new Font("Microsoft Sans Serif", 30.75f, lbl_grid[mineX, mineY].Font.Style, lbl_grid[mineX, mineY].Font.Unit);
                    lbl_grid[mineX, mineY].Location = new System.Drawing.Point(lbl_grid[mineX, mineY].Location.X - 5, lbl_grid[mineX, mineY].Location.Y);
                    grid[mineX, mineY] = -1; //Add a mine
                    currMineCount--;
                }
            }
        }

        /// <summary>
        /// Добавление кнопок и лейблов на форму
        /// </summary>
        private void addButtonsAndLabels()
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    grid[x, y] = 0;

                    btn_grid[x, y] = createButton(startX + 24 * (x + 0), startY + 24 * (y + 0), x, y);
                    lbl_grid[x, y] = createLable(startX + 24 * (x + 0), startY + 24 * (y + 0));
                }
            }
        }

        private void clearPreviousGame()
        {
            if (btn_grid != null)
            {
                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        if (Controls.Contains(btn_grid[x, y]))
                        {
                            Controls.Remove(btn_grid[x, y]);
                        }

                        if (Controls.Contains(lbl_grid[x, y]))
                        {
                            Controls.Remove(lbl_grid[x, y]);
                        }
                    }
                }
            }
        }


        public void startGame(int difficulty)
        {
            clearPreviousGame();
            lbl_ElapsedTime.Text = "0";
            timer = 0;
            tmr_ElapsedTime.Start();
            bool error = false;
            
            switch(difficulty)
            {
                case 1:
                    mintCount = 10;
                    width = 9;
                    height = 9;
                   
                    break;
                case 2:
                    mintCount = 40;
                    width = 16;
                    height = 16;
                    break;
                case 3:
                    mintCount = 99;
                    width = 30;
                    height = 16;
                    break;
                default:
                    error = true;
                    break;
            }

            lbl_mines.Text = mintCount.ToString();

            if (!error)
            {
                createGrid();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tmr_ElapsedTime_Tick(object sender, EventArgs e)
        {
            timer++;
            lbl_ElapsedTime.Text = timer.ToString();
        }
    }
}
