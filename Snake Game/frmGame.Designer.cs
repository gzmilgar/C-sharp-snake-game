namespace Snake_Game
{
    partial class frmGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniOyunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.duraklatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrGoSnake = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.baslabutton = new System.Windows.Forms.Button();
            this.highschorebutton = new System.Windows.Forms.Button();
            this.ayarbutton = new System.Windows.Forms.Button();
            this.hakkındabutton = new System.Windows.Forms.Button();
            this.pbGame = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sesAyarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGame)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(479, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniOyunToolStripMenuItem,
            this.spToolStripMenuItem,
            this.duraklatToolStripMenuItem,
            this.spToolStripMenuItem1,
            this.hakkındaToolStripMenuItem,
            this.sesAyarıToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.dosyaToolStripMenuItem.Text = "Oyun";
            // 
            // yeniOyunToolStripMenuItem
            // 
            this.yeniOyunToolStripMenuItem.Image = global::Snake_Game.Properties.Resources.yenile;
            this.yeniOyunToolStripMenuItem.Name = "yeniOyunToolStripMenuItem";
            this.yeniOyunToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.yeniOyunToolStripMenuItem.Text = "Yeni Oyun      Y";
            this.yeniOyunToolStripMenuItem.Click += new System.EventHandler(this.yeniOyunToolStripMenuItem_Click);
            // 
            // spToolStripMenuItem
            // 
            this.spToolStripMenuItem.Name = "spToolStripMenuItem";
            this.spToolStripMenuItem.Size = new System.Drawing.Size(151, 6);
            // 
            // duraklatToolStripMenuItem
            // 
            this.duraklatToolStripMenuItem.Image = global::Snake_Game.Properties.Resources.başlat_durdur;
            this.duraklatToolStripMenuItem.Name = "duraklatToolStripMenuItem";
            this.duraklatToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.duraklatToolStripMenuItem.Text = "Duraklat         P";
            this.duraklatToolStripMenuItem.Click += new System.EventHandler(this.duraklatToolStripMenuItem_Click);
            // 
            // spToolStripMenuItem1
            // 
            this.spToolStripMenuItem1.Name = "spToolStripMenuItem1";
            this.spToolStripMenuItem1.Size = new System.Drawing.Size(151, 6);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Image = global::Snake_Game.Properties.Resources.hakkında;
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında       H";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // tmrGoSnake
            // 
            this.tmrGoSnake.Tick += new System.EventHandler(this.tmrGoSnake_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScore.Location = new System.Drawing.Point(244, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(55, 13);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score : 0";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHighScore.Location = new System.Drawing.Point(414, 9);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(17, 13);
            this.lblHighScore.TabIndex = 7;
            this.lblHighScore.Text = " 0";
            // 
            // baslabutton
            // 
            this.baslabutton.BackColor = System.Drawing.Color.Green;
            this.baslabutton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslabutton.Location = new System.Drawing.Point(30, 136);
            this.baslabutton.Name = "baslabutton";
            this.baslabutton.Size = new System.Drawing.Size(423, 49);
            this.baslabutton.TabIndex = 8;
            this.baslabutton.Text = "Yeni Oyuna Başla";
            this.baslabutton.UseVisualStyleBackColor = false;
            this.baslabutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // highschorebutton
            // 
            this.highschorebutton.BackColor = System.Drawing.Color.Green;
            this.highschorebutton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.highschorebutton.Location = new System.Drawing.Point(30, 200);
            this.highschorebutton.Name = "highschorebutton";
            this.highschorebutton.Size = new System.Drawing.Size(423, 50);
            this.highschorebutton.TabIndex = 9;
            this.highschorebutton.Text = "Score Tablosu";
            this.highschorebutton.UseVisualStyleBackColor = false;
            this.highschorebutton.Click += new System.EventHandler(this.highschorebutton_Click);
            // 
            // ayarbutton
            // 
            this.ayarbutton.BackColor = System.Drawing.Color.Green;
            this.ayarbutton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ayarbutton.Location = new System.Drawing.Point(30, 269);
            this.ayarbutton.Name = "ayarbutton";
            this.ayarbutton.Size = new System.Drawing.Size(423, 47);
            this.ayarbutton.TabIndex = 10;
            this.ayarbutton.Text = "Ayarlar";
            this.ayarbutton.UseVisualStyleBackColor = false;
            this.ayarbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // hakkındabutton
            // 
            this.hakkındabutton.BackColor = System.Drawing.Color.Green;
            this.hakkındabutton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hakkındabutton.Location = new System.Drawing.Point(30, 337);
            this.hakkındabutton.Name = "hakkındabutton";
            this.hakkındabutton.Size = new System.Drawing.Size(423, 47);
            this.hakkındabutton.TabIndex = 11;
            this.hakkındabutton.Text = "Hakkında";
            this.hakkındabutton.UseVisualStyleBackColor = false;
            this.hakkındabutton.Click += new System.EventHandler(this.hakkındabutton_Click);
            // 
            // pbGame
            // 
            this.pbGame.BackColor = System.Drawing.Color.Black;
            this.pbGame.Location = new System.Drawing.Point(-4, 27);
            this.pbGame.Name = "pbGame";
            this.pbGame.Size = new System.Drawing.Size(484, 489);
            this.pbGame.TabIndex = 1;
            this.pbGame.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "HighScore : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sesAyarıToolStripMenuItem
            // 
            this.sesAyarıToolStripMenuItem.Image = global::Snake_Game.Properties.Resources.müzik__4_1;
            this.sesAyarıToolStripMenuItem.Name = "sesAyarıToolStripMenuItem";
            this.sesAyarıToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.sesAyarıToolStripMenuItem.Text = "Ses Ayarı";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 515);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hakkındabutton);
            this.Controls.Add(this.ayarbutton);
            this.Controls.Add(this.highschorebutton);
            this.Controls.Add(this.baslabutton);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbGame);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake Game";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGame_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniOyunToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator spToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duraklatToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator spToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbGame;
        private System.Windows.Forms.Timer tmrGoSnake;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Button baslabutton;
        private System.Windows.Forms.Button highschorebutton;
        private System.Windows.Forms.Button ayarbutton;
        private System.Windows.Forms.Button hakkındabutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem sesAyarıToolStripMenuItem;
    }
}

