using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Imaging
{
    class MassSomeImage
    {
        List<SomeImage> listImg;
        int countImg = 0, position = -1, widthDinamCompon;
        PictureBox picBox;
        Panel panel;
        private bool RealSize = false;

        private void createThumbnailBox()
        {
            PictureBox thumbnailBox = new PictureBox();
            thumbnailBox.Name = "thumbnailBox" + countImg.ToString();
            thumbnailBox.Size = new Size(widthDinamCompon, widthDinamCompon);
            thumbnailBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            thumbnailBox.Image = listImg[position].Image(thumbnailBox.Size);
            thumbnailBox.BackColor = Color.White;
            if (countImg == 0)
            {
                thumbnailBox.Location = new Point(3, 3);
            }
            else
            {
                Label temp = panel.Controls["thumbnailLabel" + (countImg - 1).ToString()] as Label;
                thumbnailBox.Location = new Point(temp.Location.X, temp.Location.Y + temp.Height + 3);
            }
            thumbnailBox.MouseDown += new MouseEventHandler(change_img);
            panel.Controls.Add(thumbnailBox);
        }

        private void createThumbnailLabel()
        {
            Label thumbnailLabel = new Label();
            thumbnailLabel.BackColor = Color.Transparent;
            thumbnailLabel.AutoSize = true;
            thumbnailLabel.MinimumSize = new Size(widthDinamCompon, 0);
            thumbnailLabel.MaximumSize = new Size(widthDinamCompon, 0);
            thumbnailLabel.TextAlign = ContentAlignment.MiddleCenter;
            thumbnailLabel.Text = listImg[position].Name;
            thumbnailLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            thumbnailLabel.Name = "thumbnailLabel" + countImg.ToString();
            thumbnailLabel.Width = widthDinamCompon;
            if (countImg == 0)
            {
                thumbnailLabel.Location = new Point(3, widthDinamCompon + 3);
            }
            else
            {
                PictureBox temp = panel.Controls["thumbnailBox" + countImg.ToString()] as PictureBox;
                thumbnailLabel.Location = new Point(temp.Location.X, temp.Height + temp.Location.Y);
            }
            thumbnailLabel.MouseDown += new MouseEventHandler(change_img);
            panel.Controls.Add(thumbnailLabel); 
        }

        private void selected_change()
        {
            foreach (PictureBox pB in panel.Controls.OfType<PictureBox>())
                pB.BackColor = Color.White;

            foreach (Label lbl in panel.Controls.OfType<Label>())                
            {
                lbl.ForeColor = Color.White;
                lbl.BackColor = Color.DarkTurquoise;
            }
            PictureBox temppb = panel.Controls["thumbnailBox" + position.ToString()] as PictureBox;
            Label templb = panel.Controls["thumbnailLabel" + position.ToString()] as Label;

            if (RealSize)
            {
                Image tempImg = listImg[position].Image();
                Panel pnParent = (picBox.Parent as Panel);
                if (!(pnParent.Height > tempImg.Height && pnParent.Width > tempImg.Width))
                    picBox.Size = tempImg.Size;
                picBox.Image = tempImg;
            }
            else
            {
                picBox.Size = picBox.Parent.Size;
                picBox.Image = listImg[position].Image(picBox.Size);
            }

            templb.BackColor = Color.LightCoral;
            temppb.BackColor = Color.LightCoral;

            temppb.Focus();
            templb.Focus();
        }

        private void change_img(object sender, MouseEventArgs e)
        {   
            String number_item = new string(((Control)sender).Name.Where(x => x > 47 & x < 58).ToArray());
            position = Convert.ToInt32(number_item);
            if (e.Button == MouseButtons.Left)
            {  
                selected_change();
            }
            else if (e.Button == MouseButtons.Right)
            {
                Chenge_location();
                listImg.RemoveAt(position);
                countImg--;
                if (position - 1 >= 0) position--;
                if (countImg != 0) selected_change();
                else picBox.Image = null;                
            }
        }

        private void Chenge_location()
        {
            panel.Controls.Remove(panel.Controls["thumbnailBox" + position.ToString()] as PictureBox);
            panel.Controls.Remove(panel.Controls["thumbnailLabel" + position.ToString()] as Label);

            if (position != countImg - 1)
            {
                for (int i = position + 1; i < countImg; i++)
                {
                    (panel.Controls["thumbnailBox" + i.ToString()] as PictureBox).Name = "thumbnailBox" + (i - 1).ToString();
                    (panel.Controls["thumbnailLabel" + i.ToString()] as Label).Name = "thumbnailLabel" + (i - 1).ToString();
                }

                (panel.Controls["thumbnailBox0"] as PictureBox).Location = new Point(3, 3);
                (panel.Controls["thumbnailLabel0"] as Label).Location = new Point(3, widthDinamCompon + 3);

                for (int i = 1; i < countImg - 1; i++)
                {
                    PictureBox temppbinfor = panel.Controls["thumbnailBox" + i.ToString()] as PictureBox;
                    Label templbinfor = panel.Controls["thumbnailLabel" + i.ToString()] as Label;
                    Label templbPrevious = panel.Controls["thumbnailLabel" + (i - 1).ToString()] as Label;

                    temppbinfor.Location = new Point(templbPrevious.Location.X, templbPrevious.Location.Y + templbPrevious.Height + 3);
                    templbinfor.Location = new Point(temppbinfor.Location.X, temppbinfor.Height + temppbinfor.Location.Y);
                }
            }
        }               

        public void resizeImageInBox()
        {
            if (countImg > 0)  picBox.Image = listImg[position].Image(picBox.Size);
        }

        public void Add(string path)
        {
            listImg.Add(new SomeImage(path));
            position++;
            createThumbnailBox();
            createThumbnailLabel();
            countImg++;
            selected_change();
        }

        public void Next()
        {
            if (countImg > 0)
                if (position + 1< countImg)
                {
                    position += 1;
                    selected_change();
                }
                else
                {
                    position = 0;
                    selected_change();
                }
        }

        public void Previous()
        {
            if (countImg > 0)
                if (position - 1 > -1)
                {
                    position -= 1;
                    selected_change();
                }
                else
                {
                    position = countImg - 1;
                    selected_change();
                }
        }

        public void TurnRight()
        {
            if (countImg > 0)
            {
                listImg[position].TurnPosition++;
                picBox.Image = listImg[position].Image(picBox.Size);
            }
        }

        public void TurnLeft()
        {
            if (countImg > 0)
            {
                listImg[position].TurnPosition--;
                picBox.Image = listImg[position].Image(picBox.Size);
            }
        }

        public void ReflectionLeftToRight()
        {
            if (countImg > 0)
            {
                listImg[position].flipX = !listImg[position].flipX;
                picBox.Image = listImg[position].Image(picBox.Size);
            }
        }
        
        public void ReflectionTopDown()
        {
            if (countImg > 0)
            {
                listImg[position].flipY = !listImg[position].flipY;
                picBox.Image = listImg[position].Image(picBox.Size);
            }
        }

        public void BlackAndWhite()
        {
            if (countImg > 0)
            {
                listImg[position].BlackAndWhite = !listImg[position].BlackAndWhite;
                picBox.Image = listImg[position].Image(picBox.Size);
            }
        }        

        public void Save()
        {
            if (countImg > 0)
            {
                listImg[position].SaveImage();
            }
        }

        public void ShowRealSize()
        {
            if (countImg > 0)
            {
                RealSize = !RealSize;
                selected_change();
            }
        }

        public int CountImage()
        {
            return countImg;
        }

        public MassSomeImage(PictureBox pb, Panel pn)
        {
            picBox = pb;
            panel = pn;
            listImg = new List<SomeImage>();
            widthDinamCompon = pn.Width - 6 - 17; // 6 - отступы границ; 17 - ширина скролла
        }       
    }
}
