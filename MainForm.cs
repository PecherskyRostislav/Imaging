using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imaging
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            blackAndWhite.Image = Properties.Resources.BlackWhite;
            Previous.Image = Properties.Resources.Arrow;
            Next.Image = Properties.Resources.Arrow;
            Next.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            RealUnrealSize.Image = Properties.Resources.OneToOne;


            turn_left.Image = Properties.Resources.Turn;
            turn_right.Image = Properties.Resources.Turn;
            turn_right.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);

            lef_right_reflection.Image = Properties.Resources.Reflection;
            top_down_reflection.Image = Properties.Resources.Reflection;
            top_down_reflection.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);

            image.Size = PanelForImg.Size;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool first = false, size = false;
        MassSomeImage tempObj;
        System.Windows.Forms.ToolTip ToolTip1;

        private void openImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                    tempObj.Add(openFileDialog1.FileNames[i]);
            }
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            tempObj = new MassSomeImage(image, thumbnail_images);
            first = true;

            ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.Next, "Следующее изображение");
            ToolTip1.SetToolTip(this.Previous, "Предыдущее изображение");
            ToolTip1.SetToolTip(this.turn_right, "Повернуть изображение вправо на 90 градусов");
            ToolTip1.SetToolTip(this.turn_left, "Повернуть изображение влево на 90 градусов");
            ToolTip1.SetToolTip(this.lef_right_reflection, "Отразить изображение слева направо");
            ToolTip1.SetToolTip(this.top_down_reflection, "Отразить изображение сверху вниз");
            ToolTip1.SetToolTip(this.blackAndWhite, "Сделать изображение черно белым");
            ToolTip1.SetToolTip(this.RealUnrealSize, "Отобразить в реальном размере");
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            tempObj.Previous();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            tempObj.Next();
        }

        private void turn_right_Click(object sender, EventArgs e)
        {
            tempObj.TurnRight();
        }

        private void turn_left_Click(object sender, EventArgs e)
        {
            tempObj.TurnLeft();
        }

        private void lef_right_reflection_Click(object sender, EventArgs e)
        {
            tempObj.ReflectionLeftToRight();
        }

        private void blackAndWhite_Click(object sender, EventArgs e)
        {
            tempObj.BlackAndWhite();
        }

        private void top_down_reflection_Click(object sender, EventArgs e)
        {
            tempObj.ReflectionTopDown();
        }

        private void image_SizeChanged(object sender, EventArgs e)
        {
            image.Size = PanelForImg.Size;
            if (first) tempObj.resizeImageInBox();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    tempObj.Next();
                    break;
                case Keys.Left:
                    tempObj.Next();
                    break;
            }
        }

        private void saveMenu_Click(object sender, EventArgs e)
        {
            tempObj.Save();
            MessageBox.Show("OK");
        }

        private void image_Click(object sender, EventArgs e)
        {
            MessageBox.Show(image.Size.ToString());
        }
       
        private void RealUnrealSize_Click(object sender, EventArgs e)
        {
            if (tempObj.CountImage() > 0)
            {
                if (size)
                {
                    RealUnrealSize.Image = Properties.Resources.OneToOne;
                    ToolTip1.SetToolTip(this.RealUnrealSize, "Отобразить в реальном размере");
                }
                else
                {
                    RealUnrealSize.Image = Properties.Resources.InSizeScreen;
                    ToolTip1.SetToolTip(this.RealUnrealSize, "Вписать в размеры экрана");
                }
                size = !size;
            }
            tempObj.ShowRealSize();
        }
    }
}
