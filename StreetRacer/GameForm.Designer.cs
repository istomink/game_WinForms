
namespace StreetRacer
{
    partial class GameForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.SpawnTimer = new System.Windows.Forms.Timer(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.PausePanel = new System.Windows.Forms.Panel();
            this.FromPauseToMenuButton = new System.Windows.Forms.Button();
            this.ContinueGameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GameOverPanel = new System.Windows.Forms.Panel();
            this.FromGameOverToMenu = new System.Windows.Forms.Button();
            this.GameOverLabel2 = new System.Windows.Forms.Label();
            this.GameOverLabel1 = new System.Windows.Forms.Label();
            this.ShopPanel = new System.Windows.Forms.Panel();
            this.CarPriceLabel = new System.Windows.Forms.Label();
            this.MoneyIcoPictureBox = new System.Windows.Forms.PictureBox();
            this.MoneyCountLabel = new System.Windows.Forms.Label();
            this.ShopMainButtton = new System.Windows.Forms.Button();
            this.CarPictureBox = new System.Windows.Forms.PictureBox();
            this.PrevCarButton = new System.Windows.Forms.Button();
            this.NextCarButton = new System.Windows.Forms.Button();
            this.CarNameLabel = new System.Windows.Forms.Label();
            this.FromShopToMenuButton = new System.Windows.Forms.Button();
            this.RecordPanel = new System.Windows.Forms.Panel();
            this.RecordsLabel9 = new System.Windows.Forms.Label();
            this.RecordsLabel8 = new System.Windows.Forms.Label();
            this.RecordsLabel7 = new System.Windows.Forms.Label();
            this.RecordsLabel6 = new System.Windows.Forms.Label();
            this.RecordsLabel5 = new System.Windows.Forms.Label();
            this.RecordsLabel4 = new System.Windows.Forms.Label();
            this.RecordsLabel3 = new System.Windows.Forms.Label();
            this.RecordsLabel2 = new System.Windows.Forms.Label();
            this.RecordsLabel1 = new System.Windows.Forms.Label();
            this.RecordsLabel0 = new System.Windows.Forms.Label();
            this.FromRecordsToMenuButton = new System.Windows.Forms.Button();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.RecordsButton = new System.Windows.Forms.Button();
            this.ShopButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.GameLabel2 = new System.Windows.Forms.Label();
            this.GameLabel1 = new System.Windows.Forms.Label();
            this.MoneyLabel = new System.Windows.Forms.Label();
            this.PausePanel.SuspendLayout();
            this.GameOverPanel.SuspendLayout();
            this.ShopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyIcoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarPictureBox)).BeginInit();
            this.RecordPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SpawnTimer
            // 
            this.SpawnTimer.Tick += new System.EventHandler(this.spawnTimer_Tick);
            // 
            // Timer
            // 
            this.Timer.Interval = 16;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // PausePanel
            // 
            this.PausePanel.BackgroundImage = global::StreetRacer.Properties.Resources.PauseBack1;
            this.PausePanel.Controls.Add(this.FromPauseToMenuButton);
            this.PausePanel.Controls.Add(this.ContinueGameButton);
            this.PausePanel.Controls.Add(this.label1);
            this.PausePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PausePanel.Location = new System.Drawing.Point(0, 0);
            this.PausePanel.Name = "PausePanel";
            this.PausePanel.Size = new System.Drawing.Size(712, 613);
            this.PausePanel.TabIndex = 8;
            // 
            // FromPauseToMenuButton
            // 
            this.FromPauseToMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.FromPauseToMenuButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FromPauseToMenuButton.BackgroundImage")));
            this.FromPauseToMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FromPauseToMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FromPauseToMenuButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.FromPauseToMenuButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.FromPauseToMenuButton.Location = new System.Drawing.Point(241, 352);
            this.FromPauseToMenuButton.Name = "FromPauseToMenuButton";
            this.FromPauseToMenuButton.Size = new System.Drawing.Size(230, 70);
            this.FromPauseToMenuButton.TabIndex = 6;
            this.FromPauseToMenuButton.Text = "В меню";
            this.FromPauseToMenuButton.UseVisualStyleBackColor = false;
            this.FromPauseToMenuButton.Click += new System.EventHandler(this.FromPauseToMenuButton_Click);
            // 
            // ContinueGameButton
            // 
            this.ContinueGameButton.BackColor = System.Drawing.Color.Transparent;
            this.ContinueGameButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ContinueGameButton.BackgroundImage")));
            this.ContinueGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContinueGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ContinueGameButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.ContinueGameButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.ContinueGameButton.Location = new System.Drawing.Point(241, 258);
            this.ContinueGameButton.Name = "ContinueGameButton";
            this.ContinueGameButton.Size = new System.Drawing.Size(230, 70);
            this.ContinueGameButton.TabIndex = 5;
            this.ContinueGameButton.Text = "Продолжить";
            this.ContinueGameButton.UseVisualStyleBackColor = false;
            this.ContinueGameButton.Click += new System.EventHandler(this.ContinueGameButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(0, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(712, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "Пауза";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameOverPanel
            // 
            this.GameOverPanel.BackgroundImage = global::StreetRacer.Properties.Resources.GameOverBack;
            this.GameOverPanel.Controls.Add(this.MoneyLabel);
            this.GameOverPanel.Controls.Add(this.FromGameOverToMenu);
            this.GameOverPanel.Controls.Add(this.GameOverLabel2);
            this.GameOverPanel.Controls.Add(this.GameOverLabel1);
            this.GameOverPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameOverPanel.Location = new System.Drawing.Point(0, 0);
            this.GameOverPanel.Name = "GameOverPanel";
            this.GameOverPanel.Size = new System.Drawing.Size(712, 613);
            this.GameOverPanel.TabIndex = 10;
            // 
            // FromGameOverToMenu
            // 
            this.FromGameOverToMenu.BackColor = System.Drawing.Color.Transparent;
            this.FromGameOverToMenu.BackgroundImage = global::StreetRacer.Properties.Resources.ToMenuBack;
            this.FromGameOverToMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FromGameOverToMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FromGameOverToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FromGameOverToMenu.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.FromGameOverToMenu.ForeColor = System.Drawing.Color.Chartreuse;
            this.FromGameOverToMenu.Location = new System.Drawing.Point(0, 543);
            this.FromGameOverToMenu.Name = "FromGameOverToMenu";
            this.FromGameOverToMenu.Size = new System.Drawing.Size(712, 70);
            this.FromGameOverToMenu.TabIndex = 7;
            this.FromGameOverToMenu.Text = "Вернуться в меню...";
            this.FromGameOverToMenu.UseVisualStyleBackColor = false;
            this.FromGameOverToMenu.Click += new System.EventHandler(this.FromGameOverToMenu_Click);
            // 
            // GameOverLabel2
            // 
            this.GameOverLabel2.BackColor = System.Drawing.Color.Transparent;
            this.GameOverLabel2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameOverLabel2.ForeColor = System.Drawing.Color.DeepPink;
            this.GameOverLabel2.Location = new System.Drawing.Point(0, 198);
            this.GameOverLabel2.Name = "GameOverLabel2";
            this.GameOverLabel2.Size = new System.Drawing.Size(712, 57);
            this.GameOverLabel2.TabIndex = 1;
            this.GameOverLabel2.Text = "Ваше время:";
            this.GameOverLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameOverLabel1
            // 
            this.GameOverLabel1.BackColor = System.Drawing.Color.Transparent;
            this.GameOverLabel1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameOverLabel1.ForeColor = System.Drawing.Color.DeepPink;
            this.GameOverLabel1.Location = new System.Drawing.Point(0, 136);
            this.GameOverLabel1.Name = "GameOverLabel1";
            this.GameOverLabel1.Size = new System.Drawing.Size(712, 57);
            this.GameOverLabel1.TabIndex = 0;
            this.GameOverLabel1.Text = "Игра окончена";
            this.GameOverLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShopPanel
            // 
            this.ShopPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShopPanel.BackgroundImage")));
            this.ShopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShopPanel.Controls.Add(this.CarPriceLabel);
            this.ShopPanel.Controls.Add(this.MoneyIcoPictureBox);
            this.ShopPanel.Controls.Add(this.MoneyCountLabel);
            this.ShopPanel.Controls.Add(this.ShopMainButtton);
            this.ShopPanel.Controls.Add(this.CarPictureBox);
            this.ShopPanel.Controls.Add(this.PrevCarButton);
            this.ShopPanel.Controls.Add(this.NextCarButton);
            this.ShopPanel.Controls.Add(this.CarNameLabel);
            this.ShopPanel.Controls.Add(this.FromShopToMenuButton);
            this.ShopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShopPanel.Location = new System.Drawing.Point(0, 0);
            this.ShopPanel.Name = "ShopPanel";
            this.ShopPanel.Size = new System.Drawing.Size(712, 613);
            this.ShopPanel.TabIndex = 11;
            // 
            // CarPriceLabel
            // 
            this.CarPriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.CarPriceLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.CarPriceLabel.ForeColor = System.Drawing.Color.Gold;
            this.CarPriceLabel.Location = new System.Drawing.Point(12, 403);
            this.CarPriceLabel.Name = "CarPriceLabel";
            this.CarPriceLabel.Size = new System.Drawing.Size(688, 40);
            this.CarPriceLabel.TabIndex = 9;
            this.CarPriceLabel.Text = "label1";
            this.CarPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MoneyIcoPictureBox
            // 
            this.MoneyIcoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.MoneyIcoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MoneyIcoPictureBox.Image")));
            this.MoneyIcoPictureBox.Location = new System.Drawing.Point(633, 16);
            this.MoneyIcoPictureBox.Name = "MoneyIcoPictureBox";
            this.MoneyIcoPictureBox.Size = new System.Drawing.Size(60, 60);
            this.MoneyIcoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MoneyIcoPictureBox.TabIndex = 8;
            this.MoneyIcoPictureBox.TabStop = false;
            // 
            // MoneyCountLabel
            // 
            this.MoneyCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.MoneyCountLabel.CausesValidation = false;
            this.MoneyCountLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.MoneyCountLabel.ForeColor = System.Drawing.Color.Gold;
            this.MoneyCountLabel.Location = new System.Drawing.Point(439, 27);
            this.MoneyCountLabel.Name = "MoneyCountLabel";
            this.MoneyCountLabel.Size = new System.Drawing.Size(188, 35);
            this.MoneyCountLabel.TabIndex = 7;
            this.MoneyCountLabel.Text = "label1";
            this.MoneyCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ShopMainButtton
            // 
            this.ShopMainButtton.BackColor = System.Drawing.Color.Transparent;
            this.ShopMainButtton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShopMainButtton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShopMainButtton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.ShopMainButtton.ForeColor = System.Drawing.Color.Chartreuse;
            this.ShopMainButtton.Image = ((System.Drawing.Image)(resources.GetObject("ShopMainButtton.Image")));
            this.ShopMainButtton.Location = new System.Drawing.Point(241, 455);
            this.ShopMainButtton.Name = "ShopMainButtton";
            this.ShopMainButtton.Size = new System.Drawing.Size(230, 70);
            this.ShopMainButtton.TabIndex = 6;
            this.ShopMainButtton.UseVisualStyleBackColor = false;
            this.ShopMainButtton.Click += new System.EventHandler(this.ShopMainButtton_Click);
            // 
            // CarPictureBox
            // 
            this.CarPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.CarPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CarPictureBox.InitialImage = null;
            this.CarPictureBox.Location = new System.Drawing.Point(98, 98);
            this.CarPictureBox.Name = "CarPictureBox";
            this.CarPictureBox.Size = new System.Drawing.Size(516, 288);
            this.CarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CarPictureBox.TabIndex = 5;
            this.CarPictureBox.TabStop = false;
            // 
            // PrevCarButton
            // 
            this.PrevCarButton.AutoEllipsis = true;
            this.PrevCarButton.BackColor = System.Drawing.Color.Transparent;
            this.PrevCarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PrevCarButton.BackgroundImage")));
            this.PrevCarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PrevCarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PrevCarButton.Location = new System.Drawing.Point(12, 262);
            this.PrevCarButton.Name = "PrevCarButton";
            this.PrevCarButton.Size = new System.Drawing.Size(80, 80);
            this.PrevCarButton.TabIndex = 4;
            this.PrevCarButton.UseVisualStyleBackColor = false;
            this.PrevCarButton.Click += new System.EventHandler(this.PrevCarButton_Click);
            // 
            // NextCarButton
            // 
            this.NextCarButton.AutoEllipsis = true;
            this.NextCarButton.BackColor = System.Drawing.Color.Transparent;
            this.NextCarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NextCarButton.BackgroundImage")));
            this.NextCarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NextCarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextCarButton.Location = new System.Drawing.Point(620, 262);
            this.NextCarButton.Name = "NextCarButton";
            this.NextCarButton.Size = new System.Drawing.Size(80, 80);
            this.NextCarButton.TabIndex = 3;
            this.NextCarButton.UseVisualStyleBackColor = false;
            this.NextCarButton.Click += new System.EventHandler(this.NextCarButton_Click);
            // 
            // CarNameLabel
            // 
            this.CarNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.CarNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CarNameLabel.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarNameLabel.ForeColor = System.Drawing.Color.Red;
            this.CarNameLabel.Location = new System.Drawing.Point(0, 0);
            this.CarNameLabel.Name = "CarNameLabel";
            this.CarNameLabel.Size = new System.Drawing.Size(712, 74);
            this.CarNameLabel.TabIndex = 2;
            this.CarNameLabel.Text = "Жигули";
            this.CarNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FromShopToMenuButton
            // 
            this.FromShopToMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.FromShopToMenuButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FromShopToMenuButton.BackgroundImage")));
            this.FromShopToMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FromShopToMenuButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FromShopToMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FromShopToMenuButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.FromShopToMenuButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.FromShopToMenuButton.Location = new System.Drawing.Point(0, 543);
            this.FromShopToMenuButton.Name = "FromShopToMenuButton";
            this.FromShopToMenuButton.Size = new System.Drawing.Size(712, 70);
            this.FromShopToMenuButton.TabIndex = 1;
            this.FromShopToMenuButton.Text = "Вернуться в главное меню...";
            this.FromShopToMenuButton.UseVisualStyleBackColor = false;
            this.FromShopToMenuButton.Click += new System.EventHandler(this.FromShopToMenuButton_Click);
            // 
            // RecordPanel
            // 
            this.RecordPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RecordPanel.BackgroundImage")));
            this.RecordPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RecordPanel.Controls.Add(this.RecordsLabel9);
            this.RecordPanel.Controls.Add(this.RecordsLabel8);
            this.RecordPanel.Controls.Add(this.RecordsLabel7);
            this.RecordPanel.Controls.Add(this.RecordsLabel6);
            this.RecordPanel.Controls.Add(this.RecordsLabel5);
            this.RecordPanel.Controls.Add(this.RecordsLabel4);
            this.RecordPanel.Controls.Add(this.RecordsLabel3);
            this.RecordPanel.Controls.Add(this.RecordsLabel2);
            this.RecordPanel.Controls.Add(this.RecordsLabel1);
            this.RecordPanel.Controls.Add(this.RecordsLabel0);
            this.RecordPanel.Controls.Add(this.FromRecordsToMenuButton);
            this.RecordPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecordPanel.Location = new System.Drawing.Point(0, 0);
            this.RecordPanel.Name = "RecordPanel";
            this.RecordPanel.Size = new System.Drawing.Size(712, 613);
            this.RecordPanel.TabIndex = 6;
            // 
            // RecordsLabel9
            // 
            this.RecordsLabel9.BackColor = System.Drawing.Color.Transparent;
            this.RecordsLabel9.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.RecordsLabel9.ForeColor = System.Drawing.Color.DeepPink;
            this.RecordsLabel9.Location = new System.Drawing.Point(156, 450);
            this.RecordsLabel9.Name = "RecordsLabel9";
            this.RecordsLabel9.Size = new System.Drawing.Size(400, 40);
            this.RecordsLabel9.TabIndex = 10;
            this.RecordsLabel9.Text = "9";
            this.RecordsLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecordsLabel8
            // 
            this.RecordsLabel8.BackColor = System.Drawing.Color.Transparent;
            this.RecordsLabel8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.RecordsLabel8.ForeColor = System.Drawing.Color.DeepPink;
            this.RecordsLabel8.Location = new System.Drawing.Point(156, 403);
            this.RecordsLabel8.Name = "RecordsLabel8";
            this.RecordsLabel8.Size = new System.Drawing.Size(400, 40);
            this.RecordsLabel8.TabIndex = 9;
            this.RecordsLabel8.Text = "8";
            this.RecordsLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecordsLabel7
            // 
            this.RecordsLabel7.BackColor = System.Drawing.Color.Transparent;
            this.RecordsLabel7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.RecordsLabel7.ForeColor = System.Drawing.Color.DeepPink;
            this.RecordsLabel7.Location = new System.Drawing.Point(156, 356);
            this.RecordsLabel7.Name = "RecordsLabel7";
            this.RecordsLabel7.Size = new System.Drawing.Size(400, 40);
            this.RecordsLabel7.TabIndex = 8;
            this.RecordsLabel7.Text = "7";
            this.RecordsLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecordsLabel6
            // 
            this.RecordsLabel6.BackColor = System.Drawing.Color.Transparent;
            this.RecordsLabel6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.RecordsLabel6.ForeColor = System.Drawing.Color.DeepPink;
            this.RecordsLabel6.Location = new System.Drawing.Point(156, 309);
            this.RecordsLabel6.Name = "RecordsLabel6";
            this.RecordsLabel6.Size = new System.Drawing.Size(400, 40);
            this.RecordsLabel6.TabIndex = 7;
            this.RecordsLabel6.Text = "6";
            this.RecordsLabel6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RecordsLabel5
            // 
            this.RecordsLabel5.BackColor = System.Drawing.Color.Transparent;
            this.RecordsLabel5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.RecordsLabel5.ForeColor = System.Drawing.Color.DeepPink;
            this.RecordsLabel5.Location = new System.Drawing.Point(156, 262);
            this.RecordsLabel5.Name = "RecordsLabel5";
            this.RecordsLabel5.Size = new System.Drawing.Size(400, 40);
            this.RecordsLabel5.TabIndex = 6;
            this.RecordsLabel5.Text = "5";
            this.RecordsLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecordsLabel4
            // 
            this.RecordsLabel4.BackColor = System.Drawing.Color.Transparent;
            this.RecordsLabel4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.RecordsLabel4.ForeColor = System.Drawing.Color.DeepPink;
            this.RecordsLabel4.Location = new System.Drawing.Point(156, 215);
            this.RecordsLabel4.Name = "RecordsLabel4";
            this.RecordsLabel4.Size = new System.Drawing.Size(400, 40);
            this.RecordsLabel4.TabIndex = 5;
            this.RecordsLabel4.Text = "4";
            this.RecordsLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecordsLabel3
            // 
            this.RecordsLabel3.BackColor = System.Drawing.Color.Transparent;
            this.RecordsLabel3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.RecordsLabel3.ForeColor = System.Drawing.Color.DeepPink;
            this.RecordsLabel3.Location = new System.Drawing.Point(156, 168);
            this.RecordsLabel3.Name = "RecordsLabel3";
            this.RecordsLabel3.Size = new System.Drawing.Size(400, 40);
            this.RecordsLabel3.TabIndex = 4;
            this.RecordsLabel3.Text = "3";
            this.RecordsLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecordsLabel2
            // 
            this.RecordsLabel2.BackColor = System.Drawing.Color.Transparent;
            this.RecordsLabel2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.RecordsLabel2.ForeColor = System.Drawing.Color.Red;
            this.RecordsLabel2.Image = ((System.Drawing.Image)(resources.GetObject("RecordsLabel2.Image")));
            this.RecordsLabel2.Location = new System.Drawing.Point(156, 121);
            this.RecordsLabel2.Name = "RecordsLabel2";
            this.RecordsLabel2.Size = new System.Drawing.Size(400, 40);
            this.RecordsLabel2.TabIndex = 3;
            this.RecordsLabel2.Text = "2";
            this.RecordsLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecordsLabel1
            // 
            this.RecordsLabel1.BackColor = System.Drawing.Color.Transparent;
            this.RecordsLabel1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.RecordsLabel1.ForeColor = System.Drawing.Color.Red;
            this.RecordsLabel1.Image = ((System.Drawing.Image)(resources.GetObject("RecordsLabel1.Image")));
            this.RecordsLabel1.Location = new System.Drawing.Point(156, 74);
            this.RecordsLabel1.Name = "RecordsLabel1";
            this.RecordsLabel1.Size = new System.Drawing.Size(400, 40);
            this.RecordsLabel1.TabIndex = 2;
            this.RecordsLabel1.Text = "1";
            this.RecordsLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecordsLabel0
            // 
            this.RecordsLabel0.BackColor = System.Drawing.Color.Transparent;
            this.RecordsLabel0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RecordsLabel0.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.RecordsLabel0.ForeColor = System.Drawing.Color.Red;
            this.RecordsLabel0.Image = ((System.Drawing.Image)(resources.GetObject("RecordsLabel0.Image")));
            this.RecordsLabel0.Location = new System.Drawing.Point(156, 27);
            this.RecordsLabel0.Name = "RecordsLabel0";
            this.RecordsLabel0.Size = new System.Drawing.Size(400, 40);
            this.RecordsLabel0.TabIndex = 1;
            this.RecordsLabel0.Text = "0";
            this.RecordsLabel0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FromRecordsToMenuButton
            // 
            this.FromRecordsToMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.FromRecordsToMenuButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FromRecordsToMenuButton.BackgroundImage")));
            this.FromRecordsToMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FromRecordsToMenuButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FromRecordsToMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FromRecordsToMenuButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.FromRecordsToMenuButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.FromRecordsToMenuButton.Location = new System.Drawing.Point(0, 543);
            this.FromRecordsToMenuButton.Name = "FromRecordsToMenuButton";
            this.FromRecordsToMenuButton.Size = new System.Drawing.Size(712, 70);
            this.FromRecordsToMenuButton.TabIndex = 0;
            this.FromRecordsToMenuButton.Text = "Вернуться в главное меню...";
            this.FromRecordsToMenuButton.UseVisualStyleBackColor = false;
            this.FromRecordsToMenuButton.Click += new System.EventHandler(this.FromRecordsToMenuButton_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuPanel.BackgroundImage")));
            this.MenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuPanel.Controls.Add(this.ExitButton);
            this.MenuPanel.Controls.Add(this.RecordsButton);
            this.MenuPanel.Controls.Add(this.ShopButton);
            this.MenuPanel.Controls.Add(this.PlayButton);
            this.MenuPanel.Controls.Add(this.GameLabel2);
            this.MenuPanel.Controls.Add(this.GameLabel1);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(712, 613);
            this.MenuPanel.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.ExitButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.ExitButton.Location = new System.Drawing.Point(241, 437);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(230, 70);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // RecordsButton
            // 
            this.RecordsButton.BackColor = System.Drawing.Color.Transparent;
            this.RecordsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RecordsButton.BackgroundImage")));
            this.RecordsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RecordsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RecordsButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.RecordsButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.RecordsButton.Location = new System.Drawing.Point(241, 361);
            this.RecordsButton.Name = "RecordsButton";
            this.RecordsButton.Size = new System.Drawing.Size(230, 70);
            this.RecordsButton.TabIndex = 4;
            this.RecordsButton.Text = "Рекорды";
            this.RecordsButton.UseVisualStyleBackColor = false;
            this.RecordsButton.Click += new System.EventHandler(this.RecordsButton_Click);
            // 
            // ShopButton
            // 
            this.ShopButton.BackColor = System.Drawing.Color.Transparent;
            this.ShopButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShopButton.BackgroundImage")));
            this.ShopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShopButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShopButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.ShopButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.ShopButton.Location = new System.Drawing.Point(241, 285);
            this.ShopButton.Name = "ShopButton";
            this.ShopButton.Size = new System.Drawing.Size(230, 70);
            this.ShopButton.TabIndex = 3;
            this.ShopButton.Text = "Магазин";
            this.ShopButton.UseVisualStyleBackColor = false;
            this.ShopButton.Click += new System.EventHandler(this.ShopButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Transparent;
            this.PlayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayButton.BackgroundImage")));
            this.PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlayButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.PlayButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.PlayButton.Location = new System.Drawing.Point(241, 209);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(230, 70);
            this.PlayButton.TabIndex = 2;
            this.PlayButton.Text = "Играть";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // GameLabel2
            // 
            this.GameLabel2.AutoSize = true;
            this.GameLabel2.BackColor = System.Drawing.Color.Transparent;
            this.GameLabel2.Font = new System.Drawing.Font("Mistral", 20.25F);
            this.GameLabel2.ForeColor = System.Drawing.Color.DeepPink;
            this.GameLabel2.Location = new System.Drawing.Point(249, 142);
            this.GameLabel2.Name = "GameLabel2";
            this.GameLabel2.Size = new System.Drawing.Size(215, 41);
            this.GameLabel2.TabIndex = 1;
            this.GameLabel2.Text = "Нет пути домой";
            // 
            // GameLabel1
            // 
            this.GameLabel1.AutoSize = true;
            this.GameLabel1.BackColor = System.Drawing.Color.Transparent;
            this.GameLabel1.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.GameLabel1.ForeColor = System.Drawing.Color.Lime;
            this.GameLabel1.Location = new System.Drawing.Point(120, 86);
            this.GameLabel1.Name = "GameLabel1";
            this.GameLabel1.Size = new System.Drawing.Size(471, 56);
            this.GameLabel1.TabIndex = 0;
            this.GameLabel1.Text = "Streer Racer Pro 2022";
            this.GameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MoneyLabel
            // 
            this.MoneyLabel.BackColor = System.Drawing.Color.Transparent;
            this.MoneyLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoneyLabel.ForeColor = System.Drawing.Color.Gold;
            this.MoneyLabel.Location = new System.Drawing.Point(0, 38);
            this.MoneyLabel.Name = "MoneyLabel";
            this.MoneyLabel.Size = new System.Drawing.Size(712, 57);
            this.MoneyLabel.TabIndex = 8;
            this.MoneyLabel.Text = "Получено монет: ";
            this.MoneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(712, 613);
            this.Controls.Add(this.GameOverPanel);
            this.Controls.Add(this.PausePanel);
            this.Controls.Add(this.ShopPanel);
            this.Controls.Add(this.RecordPanel);
            this.Controls.Add(this.MenuPanel);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Street Racer Pro 2022";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyUp);
            this.PausePanel.ResumeLayout(false);
            this.GameOverPanel.ResumeLayout(false);
            this.ShopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MoneyIcoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarPictureBox)).EndInit();
            this.RecordPanel.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button RecordsButton;
        private System.Windows.Forms.Button ShopButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Label GameLabel2;
        private System.Windows.Forms.Label GameLabel1;
        private System.Windows.Forms.Panel RecordPanel;
        private System.Windows.Forms.Button FromRecordsToMenuButton;
        private System.Windows.Forms.Label RecordsLabel8;
        private System.Windows.Forms.Label RecordsLabel7;
        private System.Windows.Forms.Label RecordsLabel6;
        private System.Windows.Forms.Label RecordsLabel5;
        private System.Windows.Forms.Label RecordsLabel4;
        private System.Windows.Forms.Label RecordsLabel3;
        private System.Windows.Forms.Label RecordsLabel2;
        private System.Windows.Forms.Label RecordsLabel1;
        private System.Windows.Forms.Label RecordsLabel0;
        private System.Windows.Forms.Label RecordsLabel9;
        private System.Windows.Forms.Panel ShopPanel;
        private System.Windows.Forms.Button FromShopToMenuButton;
        private System.Windows.Forms.Label CarNameLabel;
        private System.Windows.Forms.Button NextCarButton;
        private System.Windows.Forms.Button PrevCarButton;
        private System.Windows.Forms.PictureBox CarPictureBox;
        private System.Windows.Forms.Button ShopMainButtton;
        private System.Windows.Forms.PictureBox MoneyIcoPictureBox;
        private System.Windows.Forms.Label MoneyCountLabel;
        private System.Windows.Forms.Label CarPriceLabel;
        public System.Windows.Forms.Timer SpawnTimer;
        public System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Panel GameOverPanel;
        private System.Windows.Forms.Button FromGameOverToMenu;
        private System.Windows.Forms.Label GameOverLabel2;
        private System.Windows.Forms.Label GameOverLabel1;
        private System.Windows.Forms.Panel PausePanel;
        private System.Windows.Forms.Button FromPauseToMenuButton;
        private System.Windows.Forms.Button ContinueGameButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MoneyLabel;
    }
}

