using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANSI
{
    public partial class Form1 : Form
    {
        // Таблица для рисования из отдельно созданного класса, там код, который её оптимизирует
        DataGridViewEx GridForDrawing = new DataGridViewEx();

        //Специальная штука для выбора цвета
        ColorDialog colorDialog = new ColorDialog();

        // Переменные цветов
        Color foreColor = Color.White;
        Color brushBackColor = Color.Black;
        Color grigBackColor = Color.Black;

        // Размер таблицы
        int width, height = 0;

        // Стандартный символ
        string symbol = "V";

        // Стандартный размер
        int fontSize = 11;

        // Строка со всеми симолами
        string symbols = "VABCDEFGHIJKLMNOPQRSTUWXYZ1234567890АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ-▁▂▃▄▅▆▇█▉▊▋▌▎▏▐▕▔ ▀░ ▒ ▓▖ ▗ ▘ ▝▚ ▞▙ ▟ ▛ ▜⦀ ⦙ ⦚ ⧘ ⧙ ⧚ ⧛.".Replace(" ", "");


        // конструктор
        public Form1()
        {
            InitializeComponent();
        }


        // срабатывает как только форма загрузилась
        private void Form1_Load(object sender, EventArgs e)
        {
            SetupGrid();
            SetupSettings();
        }


        // Настройка таблицы
        private void SetupGrid()
        {
            // помещаем её в панель
            cont.Controls.Add(GridForDrawing);
            // цвет фона
            GridForDrawing.BackgroundColor = grigBackColor;
            // выравнивание символов
            GridForDrawing.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // присвоение метода, вызывающегося при выборе какой либо ячейки
            GridForDrawing.SelectionChanged += GridForDrawing_SelectionChanged;
            // цвет сетки таблицы (такой же как и фон, чтобы не было видно) 
            GridForDrawing.GridColor = grigBackColor;
            // отключение видимости заголовков
            GridForDrawing.ColumnHeadersVisible = false;
            GridForDrawing.RowHeadersVisible = false;
            // отбираем право пользователя менять размер
            GridForDrawing.AllowUserToResizeColumns = false;
            GridForDrawing.AllowUserToResizeRows = false;
            // отбираем право пользователя изменять значение
            GridForDrawing.ReadOnly = true;
            // устанавливаем шрифт
            GridForDrawing.Font = new Font("Roboto", fontSize, FontStyle.Bold);
        }


        // настройка других элементов
        private void SetupSettings()
        {
            // устанавливаем цвет кнопок
            gridBGBtn.BackColor = grigBackColor;
            foreColorBtn.BackColor = foreColor;
            brushBGColorBtn.BackColor = brushBackColor;

            // добавляем в выпадающий список символы
            foreach (char c in symbols)
            {
                symbolCB.Items.Add(c);
            }

            // отдельно добавляем пробел как стёрку
            symbolCB.Items.Add(" ");
            // выбираем первый символ
            symbolCB.SelectedIndex = 0;
            // присваиваем первый символ переменной
            symbol = symbolCB.Items[0].ToString();

            // устанавливаем стандартные значения в текст боксы 
            wTb.Text = "70";
            hTB.Text = "55";

            // настраиваем палитру цветов
            colorDialog.FullOpen = false;
            colorDialog.Color = Color.Black;
        }


        // создание таблицы
        private void CteateBtn_Click(object sender, EventArgs e)
        {
            // проверка на заполнение полей
            if (wTb.Text != "" && hTB.Text != "")
            {
                // отлов ошибок
                try
                {
                    // заносим данные в переменные
                    width = int.Parse(wTb.Text);
                    height = int.Parse(hTB.Text);
                }
                catch (Exception ex)
                {
                    // выводим ошибку если поймали
                    MessageBox.Show(ex.Message.ToString());
                }

                UpdateGrid(width, height);
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!");
            }
        }


        // перерисовка таблицы
        public void UpdateGrid(int col, int row)
        {
            GridForDrawing.BackgroundColor = Color.Gray;
            GridForDrawing.Dock = DockStyle.Fill;

            // создаём отдельную таблицу
            DataTable table = new DataTable();

            // заполняем
            for (int i = 0; i < col; i++)
            {
                table.Columns.Add();
            }

            for (int i = 0; i < row; i++)
            {
                table.Rows.Add();
            }

            // удаляем нашу таблицу
            DeleteGrid();

            // устанавливаем первую в качестве данных
            GridForDrawing.DataSource = table;

            // пробегаемся по всем колонкам и устанавливаем им ширину
            foreach (DataGridViewColumn item in GridForDrawing.Columns)
            {
                item.Width = 13;
            }

            // очищаем таблицу
            ClearGrid();
        }


        // как только юзер выделит ячейку сработает этот метод
        private void GridForDrawing_SelectionChanged(object sender, EventArgs e)
        {
            // если количество выделенных ячеек больше нуля
            if (GridForDrawing.SelectedCells.Count > 0)
            {
                Random rnd = new Random();
                // получаем ячейку по которой произошёл клик
                DataGridViewCell c = GridForDrawing.CurrentCell;
                // шрифт
                c.Style.Font = new Font("Roboto", fontSize, FontStyle.Bold);
                // перенос текста, чтобы не было "R..."
                c.Style.WrapMode = DataGridViewTriState.True;
                // фоновый цвет
                c.Style.BackColor = brushBackColor;

                // проверка выбранных опций
                if (randomSymbol.Checked && randomColor.Checked)
                {
                    Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    c.Value = symbols[rnd.Next(symbols.Length - 1)];
                    c.Style.ForeColor = randomColor;
                }
                else if (randomSymbol.Checked)
                {
                    c.Value = symbols[rnd.Next(symbols.Length - 1)];
                    c.Style.ForeColor = foreColor;
                }
                else if (randomColor.Checked)
                {
                    Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    c.Value = symbol;
                    c.Style.ForeColor = randomColor;
                }
                else
                {
                    c.Value = symbol;
                    c.Style.ForeColor = foreColor;
                }

                // убираем выделение, чисто для визуала
                GridForDrawing.ClearSelection();
            }
        }


        // очищение таблицы
        private void ClearGrid()
        {
            // пробегаемся по всем ячейкам
            for (int i = 0; i < GridForDrawing.Columns.Count; i++)
            {
                for (int j = 0; j < GridForDrawing.Rows.Count; j++)
                {
                    // устанавливаем стандартные значения
                    GridForDrawing[i, j].Style.BackColor = grigBackColor;
                    GridForDrawing[i, j].Value = "";
                }
            }
        }


        // кнопка очистить
        private void ClearAllBtn_Click(object sender, EventArgs e)
        {
            ClearGrid();
        }


        // удаление всех колонок
        private void DeleteGrid()
        {
            GridForDrawing.Columns.Clear();
        }


        // цвет таблицы
        private void gridBG_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;

            // устанавливаем выбранные цвета
            grigBackColor = colorDialog.Color;
            gridBGBtn.BackColor = colorDialog.Color;
            // перерисовываем с новым цветом
            UpdateGrid(width, height);
            GridForDrawing.GridColor = grigBackColor;
        }


        // цвет фона кисти
        private void brushBGColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;

            brushBackColor = colorDialog.Color;
            brushBGColorBtn.BackColor = colorDialog.Color;
        }


        // цвет шрифта
        private void foreColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;

            foreColor = colorDialog.Color;
            foreColorBtn.BackColor = colorDialog.Color;
        }


        // выбор символа
        private void symbolCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            symbol = symbolCB.SelectedItem.ToString();
        }


        // выбор шрифта
        private void fontSizeTB_Scroll(object sender, EventArgs e)
        {
            fontSize = fontSizeTB.Value;
            fontSizeLB.Text = fontSizeTB.Value.ToString();
            UpdateFontSize(fontSize);
        }


        private void UpdateFontSize(int size)
        {
            for (int i = 0; i < GridForDrawing.Columns.Count; i++)
            {
                for (int j = 0; j < GridForDrawing.Rows.Count; j++)
                {
                    GridForDrawing[i, j].Style.Font = new Font("Roboto", size, FontStyle.Bold);
                }
            }
        }


        // сохранение в картинку
        private void saveBtn_Click(object sender, EventArgs e)
        {
            // путь до рабочего стола
            string DesktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            SaveFileDialog sfd = new SaveFileDialog();
            // расширение файла
            sfd.DefaultExt = ".png";
            sfd.AddExtension = true;
            // путь по умолчанию
            sfd.InitialDirectory = DesktopFolder;

            if (sfd.ShowDialog() == DialogResult.Cancel)
                return;

            // полученный от пользователя путь
            string filename = sfd.FileName;

            // хз как это работает, в инете нашёл
            // высота по факту
            int DGVOriginalHeight = GridForDrawing.Height;
            

            // в аргументах размеры будущего изображения
            using (Bitmap bitmap = new Bitmap(GridForDrawing.Width, GridForDrawing.Height))
            {
                // чудом конвертирует таблицу в изображение
                GridForDrawing.DrawToBitmap(bitmap, new Rectangle(Point.Empty, GridForDrawing.Size));

                // сохраняем изображения по пути от юзера
                bitmap.Save(Path.Combine(filename), ImageFormat.Png);
            }
            //GridForDrawing.Height = DGVOriginalHeight;
        }

        
        // удаляет все колонки и устанавливает маленький размер (типа исчезла)
        private void delBtn_Click(object sender, EventArgs e)
        {
            DeleteGrid();
            GridForDrawing.Width = 5; 
            GridForDrawing.Height = 5;
        }



        private double WIDTH_OFFSET = 1.3;
        private int maxWidth = 140;
        private Bitmap bitmap;

        private void openBtn_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog()
            {
                Filter = "Images | *.bmp; *.png; *.jpg; *.JPEG"
            };



            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bitmap = new Bitmap(openFileDialog.FileName);

                ClearGrid();
                PrintImage(bitmap);
            }
        }


        private void PrintImage(Bitmap bitmap)
        {
            bitmap = ResizeBitmap(bitmap);

            var converter = new BitmapToASCIIConverter(bitmap);
            var rows = converter.Convert().Item1;
            var colors = converter.Convert().Item2;


            for (int i = 0; i < rows.Length; i++)
            {
                for (int j = 0; j < rows[i].Length; j++)
                {
                    if (i < GridForDrawing.ColumnCount && j < GridForDrawing.RowCount)
                    {
                        try
                        {
                            GridForDrawing[j, i].Style.WrapMode = DataGridViewTriState.True;
                            GridForDrawing[j, i].Style.ForeColor = colors[i][j];
                            GridForDrawing[j, i].Value = rows[i][j];
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());
                        }
                        
                    }
                    
                }
            }
        }

        private void widthTB_Scroll(object sender, EventArgs e)
        {
            widthLB.Text = widthTB.Value.ToString();
            foreach (DataGridViewColumn item in GridForDrawing.Columns)
            {
                item.Width = widthTB.Value;
            }
        }

        private void heightTB_Scroll(object sender, EventArgs e)
        {
            GridForDrawing.RowTemplate.Height = heightTB.Value;
            heightLB.Text = heightTB.Value.ToString();
            UpdateGrid(width, height);
            
        }

        private Bitmap ResizeBitmap(Bitmap bitmap)
        {

            var newHieght = bitmap.Height / WIDTH_OFFSET * maxWidth / bitmap.Width;
            if (bitmap.Width > maxWidth || bitmap.Height > newHieght)
            {
                bitmap = new Bitmap(bitmap, new Size(maxWidth, (int)newHieght));
            }
            return bitmap;
        }
    }
}
