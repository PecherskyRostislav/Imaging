using System;
using System.Drawing;

namespace Imaging
{
    class SomeImage
    {
        private string path;
        private int turnPs = 0;

        public bool flipX { get; set; }
        public bool flipY { get; set; }
        public bool BlackAndWhite { get; set; }
        public string PathToImage
        {
            get
            {
                return path;
            }

            private set
            {
                path = value;
            }
        }
        public string Name
        {
            get
            {
                string[] temp_name = PathToImage.Split('\\');
                return temp_name[temp_name.Length - 1];
            }
        }
        public int TurnPosition
        {
            get
            {
                return turnPs;
            }
            set
            {
                if (value > 4)
                    turnPs = 0;
                else
                    if (value < 0)
                        turnPs = 3;
                    else
                        turnPs = value;
            }
        }

        private Image ConvertingColorImageToBlackAndWhite(Image image)
        {
            if (!BlackAndWhite) return image;
            Bitmap input = new Bitmap(image);
            // создаём Bitmap для черно-белого изображения
            Bitmap output = new Bitmap(input.Width, input.Height);
            // перебираем в циклах все пиксели исходного изображения
            for (int j = 0; j < input.Height; j++)
                for (int i = 0; i < input.Width; i++)
                {

                    // получаем (i, j) пиксель
                    UInt32 pixel = (UInt32)(input.GetPixel(i, j).ToArgb());
                    // получаем компоненты цветов пикселя
                    float R = (float)((pixel & 0x00FF0000) >> 16); // красный
                    float G = (float)((pixel & 0x0000FF00) >> 8); // зеленый
                    float B = (float)(pixel & 0x000000FF); // синий
                    // делаем цвет черно-белым (оттенки серого) - находим среднее арифметическое
                    R = G = B = (R + G + B) / 3.0f;
                    // собираем новый пиксель по частям (по каналам)
                    UInt32 newPixel = 0xFF000000 | ((UInt32)R << 16) | ((UInt32)G << 8) | ((UInt32)B);
                    // добавляем его в Bitmap нового изображения
                    output.SetPixel(i, j, Color.FromArgb((int)newPixel));
                }
            // выводим черно-белый Bitmap в pictureBox2
            return output;
        }
        private Bitmap ChengeUnderSize(Image image, Size sizeBox)
        {
            if (image.Size.Width > sizeBox.Width || image.Size.Height > sizeBox.Height)
            {
                Bitmap temp_img;
                if (image.Height < image.Width)
                {
                    double per = Convert.ToDouble(sizeBox.Width - 1) / Convert.ToDouble(image.Width);
                    if (Convert.ToInt32(image.Height * per) < sizeBox.Height)
                    {
                        temp_img = new Bitmap(image, Convert.ToInt32(image.Width * per), Convert.ToInt32(image.Height * per));
                    }
                    else
                    {
                        per = Convert.ToDouble(sizeBox.Height - 1) / Convert.ToDouble(image.Height);
                        temp_img = new Bitmap(image, Convert.ToInt32(image.Width * per), Convert.ToInt32(image.Height * per));
                    }
                }
                else
                {
                    double per = Convert.ToDouble(sizeBox.Height - 1) / Convert.ToDouble(image.Height);
                    temp_img = new Bitmap(image, Convert.ToInt32(image.Width * per), Convert.ToInt32(image.Height * per));
                }
                return temp_img;
            }
            return new Bitmap(image);
        }
        private Image turn(Image temp_image)
        {   
            if(!flipY && !flipX)
                switch (turnPs)
                {
                    case 1:
                        temp_image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        break;
                    case 2:
                        temp_image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        break;
                    case 3:
                        temp_image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        break;
                }
            if (flipY && flipX)
                switch (turnPs)
                {
                    case 0:
                        temp_image.RotateFlip(RotateFlipType.RotateNoneFlipXY);
                        break;
                    case 1:
                        temp_image.RotateFlip(RotateFlipType.Rotate90FlipXY);
                        break;
                    case 2:
                        temp_image.RotateFlip(RotateFlipType.Rotate180FlipXY);
                        break;
                    case 3:
                        temp_image.RotateFlip(RotateFlipType.Rotate270FlipXY);
                        break;
                }
            if (flipY && !flipX)
                switch (turnPs)
                {
                    case 0:
                        temp_image.RotateFlip(RotateFlipType.RotateNoneFlipY);
                        break;
                    case 1:
                        temp_image.RotateFlip(RotateFlipType.Rotate90FlipY);
                        break;
                    case 2:
                        temp_image.RotateFlip(RotateFlipType.Rotate180FlipY);
                        break;
                    case 3:
                        temp_image.RotateFlip(RotateFlipType.Rotate270FlipY);
                        break;
                }
            if (!flipY && flipX)
                switch (turnPs)
                {
                    case 0:
                        temp_image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        break;
                    case 1:
                        temp_image.RotateFlip(RotateFlipType.Rotate90FlipX);
                        break;
                    case 2:
                        temp_image.RotateFlip(RotateFlipType.Rotate180FlipX);
                        break;
                    case 3:
                        temp_image.RotateFlip(RotateFlipType.Rotate270FlipX);
                        break;
                }
            return temp_image;
        }       

        public void SaveImage()
        {
            System.Drawing.Imaging.ImageFormat form = null;
            string[] ext = Name.Split('.');
            switch(ext[ext.Length - 1].ToLower())
            {
                case "bmp":
                    form = System.Drawing.Imaging.ImageFormat.Bmp;
                    break;
                case "png":
                    form = System.Drawing.Imaging.ImageFormat.Png;
                    break;
                case "jpg":
                case "jpeg":
                    form = System.Drawing.Imaging.ImageFormat.Jpeg;
                    break;
            }
            Image temp = Image();
            if (!System.IO.File.Exists(PathToImage))
            {
                temp.Save(PathToImage, form);
            }
            else
            {
                System.IO.File.Delete(PathToImage);
                temp.Save(PathToImage, form);
            }
        }
        public Image Image()
        {
            Image temp_image = null;
            System.IO.FileStream fs = new System.IO.FileStream(PathToImage, System.IO.FileMode.Open);

            temp_image = ConvertingColorImageToBlackAndWhite(turn(System.Drawing.Image.FromStream(fs)));
            fs.Close();
            return temp_image;
        }
        public Image Image(Size size_picture)
        {
            Image temp_image = null;
            System.IO.FileStream fs = new System.IO.FileStream(PathToImage, System.IO.FileMode.Open);
            temp_image = ConvertingColorImageToBlackAndWhite(ChengeUnderSize(turn(System.Drawing.Image.FromStream(fs)), size_picture));
            fs.Close();
            return temp_image;
        }        
        public void Rename(string new_name)
        {
            string[] temp_name = PathToImage.Split('\\');
            temp_name[temp_name.Length - 1] = new_name;

            string temp_new_path = temp_name[0];
            for (int i = 1; i < temp_name.Length; i++)
                temp_new_path += "\\" + temp_name[i];


            if (System.IO.File.Exists(PathToImage))
            {
                if (!System.IO.File.Exists(temp_new_path))
                {
                    System.IO.File.Move(PathToImage, temp_new_path);
                    PathToImage = temp_new_path;
                }
                else
                {
                    throw new Exception("Такой файл уже существует.");
                }
            }
            else
            {
                throw new Exception("Файл не найдено.");
            }
        }
        public SomeImage(string path_to_img)
        {
            if (System.IO.File.Exists(path_to_img))
            {
                PathToImage = path_to_img;
                flipX = false;
                flipY = false;
                BlackAndWhite = false;
            }
            else
            {
                throw new Exception("Файл " + path_to_img + " не найден!");
            }
        }
    }
}
