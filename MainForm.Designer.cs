namespace Imaging
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.thumbnail_images = new System.Windows.Forms.Panel();
            this.information_about_images = new System.Windows.Forms.Panel();
            this.actions_with_images = new System.Windows.Forms.Panel();
            this.RealUnrealSize = new System.Windows.Forms.PictureBox();
            this.blackAndWhite = new System.Windows.Forms.PictureBox();
            this.top_down_reflection = new System.Windows.Forms.PictureBox();
            this.lef_right_reflection = new System.Windows.Forms.PictureBox();
            this.turn_left = new System.Windows.Forms.PictureBox();
            this.turn_right = new System.Windows.Forms.PictureBox();
            this.Next = new System.Windows.Forms.PictureBox();
            this.Previous = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImg = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.image = new System.Windows.Forms.PictureBox();
            this.PanelForImg = new System.Windows.Forms.Panel();
            this.actions_with_images.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RealUnrealSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackAndWhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top_down_reflection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lef_right_reflection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turn_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turn_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Previous)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.PanelForImg.SuspendLayout();
            this.SuspendLayout();
            // 
            // thumbnail_images
            // 
            this.thumbnail_images.AutoScroll = true;
            this.thumbnail_images.BackColor = System.Drawing.Color.LightBlue;
            this.thumbnail_images.Dock = System.Windows.Forms.DockStyle.Right;
            this.thumbnail_images.Location = new System.Drawing.Point(876, 28);
            this.thumbnail_images.Name = "thumbnail_images";
            this.thumbnail_images.Size = new System.Drawing.Size(179, 660);
            this.thumbnail_images.TabIndex = 1;
            // 
            // information_about_images
            // 
            this.information_about_images.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.information_about_images.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.information_about_images.Location = new System.Drawing.Point(0, 661);
            this.information_about_images.Name = "information_about_images";
            this.information_about_images.Size = new System.Drawing.Size(876, 27);
            this.information_about_images.TabIndex = 2;
            this.information_about_images.Visible = false;
            // 
            // actions_with_images
            // 
            this.actions_with_images.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.actions_with_images.Controls.Add(this.RealUnrealSize);
            this.actions_with_images.Controls.Add(this.blackAndWhite);
            this.actions_with_images.Controls.Add(this.top_down_reflection);
            this.actions_with_images.Controls.Add(this.lef_right_reflection);
            this.actions_with_images.Controls.Add(this.turn_left);
            this.actions_with_images.Controls.Add(this.turn_right);
            this.actions_with_images.Controls.Add(this.Next);
            this.actions_with_images.Controls.Add(this.Previous);
            this.actions_with_images.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actions_with_images.Location = new System.Drawing.Point(0, 588);
            this.actions_with_images.Name = "actions_with_images";
            this.actions_with_images.Size = new System.Drawing.Size(876, 73);
            this.actions_with_images.TabIndex = 3;
            // 
            // RealUnrealSize
            // 
            this.RealUnrealSize.BackColor = System.Drawing.Color.Transparent;
            this.RealUnrealSize.ImageLocation = "";
            this.RealUnrealSize.Location = new System.Drawing.Point(401, 6);
            this.RealUnrealSize.Name = "RealUnrealSize";
            this.RealUnrealSize.Size = new System.Drawing.Size(72, 61);
            this.RealUnrealSize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RealUnrealSize.TabIndex = 7;
            this.RealUnrealSize.TabStop = false;
            this.RealUnrealSize.Click += new System.EventHandler(this.RealUnrealSize_Click);
            // 
            // blackAndWhite
            // 
            this.blackAndWhite.BackColor = System.Drawing.Color.Transparent;
            this.blackAndWhite.ImageLocation = "";
            this.blackAndWhite.Location = new System.Drawing.Point(324, 6);
            this.blackAndWhite.Name = "blackAndWhite";
            this.blackAndWhite.Size = new System.Drawing.Size(72, 61);
            this.blackAndWhite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blackAndWhite.TabIndex = 6;
            this.blackAndWhite.TabStop = false;
            this.blackAndWhite.Click += new System.EventHandler(this.blackAndWhite_Click);
            // 
            // top_down_reflection
            // 
            this.top_down_reflection.BackColor = System.Drawing.Color.Transparent;
            this.top_down_reflection.ImageLocation = "";
            this.top_down_reflection.Location = new System.Drawing.Point(90, 6);
            this.top_down_reflection.Name = "top_down_reflection";
            this.top_down_reflection.Size = new System.Drawing.Size(72, 61);
            this.top_down_reflection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.top_down_reflection.TabIndex = 5;
            this.top_down_reflection.TabStop = false;
            this.top_down_reflection.Click += new System.EventHandler(this.top_down_reflection_Click);
            // 
            // lef_right_reflection
            // 
            this.lef_right_reflection.BackColor = System.Drawing.Color.Transparent;
            this.lef_right_reflection.ImageLocation = "";
            this.lef_right_reflection.Location = new System.Drawing.Point(12, 6);
            this.lef_right_reflection.Name = "lef_right_reflection";
            this.lef_right_reflection.Size = new System.Drawing.Size(72, 61);
            this.lef_right_reflection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lef_right_reflection.TabIndex = 4;
            this.lef_right_reflection.TabStop = false;
            this.lef_right_reflection.Click += new System.EventHandler(this.lef_right_reflection_Click);
            // 
            // turn_left
            // 
            this.turn_left.BackColor = System.Drawing.Color.Transparent;
            this.turn_left.ImageLocation = "";
            this.turn_left.Location = new System.Drawing.Point(168, 6);
            this.turn_left.Name = "turn_left";
            this.turn_left.Size = new System.Drawing.Size(72, 61);
            this.turn_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.turn_left.TabIndex = 3;
            this.turn_left.TabStop = false;
            this.turn_left.Click += new System.EventHandler(this.turn_left_Click);
            // 
            // turn_right
            // 
            this.turn_right.BackColor = System.Drawing.Color.Transparent;
            this.turn_right.ImageLocation = "";
            this.turn_right.Location = new System.Drawing.Point(246, 6);
            this.turn_right.Name = "turn_right";
            this.turn_right.Size = new System.Drawing.Size(72, 61);
            this.turn_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.turn_right.TabIndex = 2;
            this.turn_right.TabStop = false;
            this.turn_right.Click += new System.EventHandler(this.turn_right_Click);
            // 
            // Next
            // 
            this.Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Next.BackColor = System.Drawing.Color.Transparent;
            this.Next.ImageLocation = "";
            this.Next.Location = new System.Drawing.Point(798, 6);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(72, 61);
            this.Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Next.TabIndex = 1;
            this.Next.TabStop = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Previous
            // 
            this.Previous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Previous.BackColor = System.Drawing.Color.Transparent;
            this.Previous.ImageLocation = "";
            this.Previous.Location = new System.Drawing.Point(720, 6);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(72, 61);
            this.Previous.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Previous.TabIndex = 0;
            this.Previous.TabStop = false;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exit});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1055, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImg,
            this.saveMenu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openImg
            // 
            this.openImg.Name = "openImg";
            this.openImg.Size = new System.Drawing.Size(158, 26);
            this.openImg.Text = "Открыть";
            this.openImg.Click += new System.EventHandler(this.openImg_Click);
            // 
            // saveMenu
            // 
            this.saveMenu.Name = "saveMenu";
            this.saveMenu.Size = new System.Drawing.Size(158, 26);
            this.saveMenu.Text = "Сохранить";
            this.saveMenu.Click += new System.EventHandler(this.saveMenu_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(65, 24);
            this.exit.Text = "Выход";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.Color.White;
            this.image.Location = new System.Drawing.Point(0, 0);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(875, 561);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            this.image.SizeChanged += new System.EventHandler(this.image_SizeChanged);
            // 
            // PanelForImg
            // 
            this.PanelForImg.AutoScroll = true;
            this.PanelForImg.BackColor = System.Drawing.Color.White;
            this.PanelForImg.Controls.Add(this.image);
            this.PanelForImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForImg.Location = new System.Drawing.Point(0, 28);
            this.PanelForImg.Name = "PanelForImg";
            this.PanelForImg.Size = new System.Drawing.Size(876, 560);
            this.PanelForImg.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1055, 688);
            this.Controls.Add(this.PanelForImg);
            this.Controls.Add(this.actions_with_images);
            this.Controls.Add(this.information_about_images);
            this.Controls.Add(this.thumbnail_images);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(832, 556);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.image_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.actions_with_images.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RealUnrealSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackAndWhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top_down_reflection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lef_right_reflection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turn_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turn_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Previous)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.PanelForImg.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel information_about_images;
        private System.Windows.Forms.Panel actions_with_images;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem openImg;
        private System.Windows.Forms.PictureBox Previous;
        private System.Windows.Forms.PictureBox Next;
        private System.Windows.Forms.PictureBox turn_right;
        public System.Windows.Forms.Panel thumbnail_images;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.PictureBox turn_left;
        private System.Windows.Forms.PictureBox lef_right_reflection;
        private System.Windows.Forms.PictureBox top_down_reflection;
        private System.Windows.Forms.PictureBox blackAndWhite;
        private System.Windows.Forms.ToolStripMenuItem saveMenu;
        private System.Windows.Forms.Panel PanelForImg;
        private System.Windows.Forms.PictureBox RealUnrealSize;
    }
}

