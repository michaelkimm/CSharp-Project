
namespace AdventureGame
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnAtkDown = new System.Windows.Forms.Button();
            this.btnAtkRight = new System.Windows.Forms.Button();
            this.btnAtkLeft = new System.Windows.Forms.Button();
            this.btnAtkUp = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbGhoul = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbGhost = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lbPlayer = new System.Windows.Forms.Label();
            this.lbBat = new System.Windows.Forms.Label();
            this.pbSwordEquipped = new System.Windows.Forms.PictureBox();
            this.pbPotionRedEquipped = new System.Windows.Forms.PictureBox();
            this.pbPotionBlueEquipped = new System.Windows.Forms.PictureBox();
            this.pbBowEquipped = new System.Windows.Forms.PictureBox();
            this.pbMaceEquipped = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbSwordItem = new System.Windows.Forms.PictureBox();
            this.pbBat = new System.Windows.Forms.PictureBox();
            this.pbGhoul = new System.Windows.Forms.PictureBox();
            this.pbGhost = new System.Windows.Forms.PictureBox();
            this.pbBowItem = new System.Windows.Forms.PictureBox();
            this.pbPotionRedItem = new System.Windows.Forms.PictureBox();
            this.pbPotionBlueItem = new System.Windows.Forms.PictureBox();
            this.pbMazeItem = new System.Windows.Forms.PictureBox();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSwordEquipped)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPotionRedEquipped)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPotionBlueEquipped)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBowEquipped)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaceEquipped)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSwordItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGhoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBowItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPotionRedItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPotionBlueItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMazeItem)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(608, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 14);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Move";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(608, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(43, 14);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Attack";
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(689, 61);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(75, 23);
            this.btnMoveRight.TabIndex = 11;
            this.btnMoveRight.Text = "Right";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(608, 61);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(75, 23);
            this.btnMoveLeft.TabIndex = 12;
            this.btnMoveLeft.Text = "Left";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(647, 90);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(75, 23);
            this.btnMoveDown.TabIndex = 13;
            this.btnMoveDown.Text = "Down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnAtkDown
            // 
            this.btnAtkDown.Location = new System.Drawing.Point(647, 210);
            this.btnAtkDown.Name = "btnAtkDown";
            this.btnAtkDown.Size = new System.Drawing.Size(75, 23);
            this.btnAtkDown.TabIndex = 17;
            this.btnAtkDown.Text = "Down";
            this.btnAtkDown.UseVisualStyleBackColor = true;
            // 
            // btnAtkRight
            // 
            this.btnAtkRight.Location = new System.Drawing.Point(689, 181);
            this.btnAtkRight.Name = "btnAtkRight";
            this.btnAtkRight.Size = new System.Drawing.Size(75, 23);
            this.btnAtkRight.TabIndex = 16;
            this.btnAtkRight.Text = "Right";
            this.btnAtkRight.UseVisualStyleBackColor = true;
            // 
            // btnAtkLeft
            // 
            this.btnAtkLeft.Location = new System.Drawing.Point(608, 181);
            this.btnAtkLeft.Name = "btnAtkLeft";
            this.btnAtkLeft.Size = new System.Drawing.Size(75, 23);
            this.btnAtkLeft.TabIndex = 15;
            this.btnAtkLeft.Text = "Left";
            this.btnAtkLeft.UseVisualStyleBackColor = true;
            // 
            // btnAtkUp
            // 
            this.btnAtkUp.Location = new System.Drawing.Point(647, 152);
            this.btnAtkUp.Name = "btnAtkUp";
            this.btnAtkUp.Size = new System.Drawing.Size(75, 23);
            this.btnAtkUp.TabIndex = 14;
            this.btnAtkUp.Text = "Up";
            this.btnAtkUp.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.Controls.Add(this.lbGhoul, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbGhost, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox7, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbPlayer, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbBat, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(608, 272);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(164, 100);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // lbGhoul
            // 
            this.lbGhoul.AutoSize = true;
            this.lbGhoul.Location = new System.Drawing.Point(56, 75);
            this.lbGhoul.Name = "lbGhoul";
            this.lbGhoul.Size = new System.Drawing.Size(78, 12);
            this.lbGhoul.TabIndex = 32;
            this.lbGhoul.Text = "ghoulHitPoint";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1, 12);
            this.label3.TabIndex = 31;
            this.label3.Text = "label1";
            // 
            // lbGhost
            // 
            this.lbGhost.AutoSize = true;
            this.lbGhost.Location = new System.Drawing.Point(56, 50);
            this.lbGhost.Name = "lbGhost";
            this.lbGhost.Size = new System.Drawing.Size(78, 12);
            this.lbGhost.TabIndex = 30;
            this.lbGhost.Text = "ghostHitPoint";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 12);
            this.label2.TabIndex = 29;
            this.label2.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 12);
            this.label1.TabIndex = 27;
            this.label1.Text = "label1";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(7, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(43, 14);
            this.textBox5.TabIndex = 25;
            this.textBox5.Text = "Player";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(3, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(1, 14);
            this.textBox3.TabIndex = 20;
            this.textBox3.Text = "Attack";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(7, 28);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(43, 14);
            this.textBox4.TabIndex = 21;
            this.textBox4.Text = "Bat";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(7, 53);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(43, 14);
            this.textBox6.TabIndex = 23;
            this.textBox6.Text = "Ghost";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(7, 78);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(43, 14);
            this.textBox7.TabIndex = 24;
            this.textBox7.Text = "Ghoul";
            // 
            // lbPlayer
            // 
            this.lbPlayer.AutoSize = true;
            this.lbPlayer.Location = new System.Drawing.Point(56, 0);
            this.lbPlayer.Name = "lbPlayer";
            this.lbPlayer.Size = new System.Drawing.Size(82, 12);
            this.lbPlayer.TabIndex = 26;
            this.lbPlayer.Text = "playerHitPoint";
            this.lbPlayer.Click += new System.EventHandler(this.lbPlayer_Click);
            // 
            // lbBat
            // 
            this.lbBat.AutoSize = true;
            this.lbBat.Location = new System.Drawing.Point(56, 25);
            this.lbBat.Name = "lbBat";
            this.lbBat.Size = new System.Drawing.Size(64, 12);
            this.lbBat.TabIndex = 28;
            this.lbBat.Text = "batHitPoint";
            // 
            // pbSwordEquipped
            // 
            this.pbSwordEquipped.BackColor = System.Drawing.Color.Transparent;
            this.pbSwordEquipped.Image = global::AdventureGame.Properties.Resources.sword;
            this.pbSwordEquipped.Location = new System.Drawing.Point(80, 322);
            this.pbSwordEquipped.Name = "pbSwordEquipped";
            this.pbSwordEquipped.Size = new System.Drawing.Size(50, 50);
            this.pbSwordEquipped.TabIndex = 20;
            this.pbSwordEquipped.TabStop = false;
            // 
            // pbPotionRedEquipped
            // 
            this.pbPotionRedEquipped.BackColor = System.Drawing.Color.Transparent;
            this.pbPotionRedEquipped.Image = global::AdventureGame.Properties.Resources.potion_red;
            this.pbPotionRedEquipped.Location = new System.Drawing.Point(136, 322);
            this.pbPotionRedEquipped.Name = "pbPotionRedEquipped";
            this.pbPotionRedEquipped.Size = new System.Drawing.Size(50, 50);
            this.pbPotionRedEquipped.TabIndex = 21;
            this.pbPotionRedEquipped.TabStop = false;
            // 
            // pbPotionBlueEquipped
            // 
            this.pbPotionBlueEquipped.BackColor = System.Drawing.Color.Transparent;
            this.pbPotionBlueEquipped.Image = global::AdventureGame.Properties.Resources.potion_blue;
            this.pbPotionBlueEquipped.Location = new System.Drawing.Point(192, 322);
            this.pbPotionBlueEquipped.Name = "pbPotionBlueEquipped";
            this.pbPotionBlueEquipped.Size = new System.Drawing.Size(50, 50);
            this.pbPotionBlueEquipped.TabIndex = 22;
            this.pbPotionBlueEquipped.TabStop = false;
            // 
            // pbBowEquipped
            // 
            this.pbBowEquipped.BackColor = System.Drawing.Color.Transparent;
            this.pbBowEquipped.Image = global::AdventureGame.Properties.Resources.bow;
            this.pbBowEquipped.Location = new System.Drawing.Point(248, 322);
            this.pbBowEquipped.Name = "pbBowEquipped";
            this.pbBowEquipped.Size = new System.Drawing.Size(50, 50);
            this.pbBowEquipped.TabIndex = 23;
            this.pbBowEquipped.TabStop = false;
            // 
            // pbMaceEquipped
            // 
            this.pbMaceEquipped.BackColor = System.Drawing.Color.Transparent;
            this.pbMaceEquipped.Image = global::AdventureGame.Properties.Resources.mace;
            this.pbMaceEquipped.Location = new System.Drawing.Point(304, 322);
            this.pbMaceEquipped.Name = "pbMaceEquipped";
            this.pbMaceEquipped.Size = new System.Drawing.Size(50, 50);
            this.pbMaceEquipped.TabIndex = 24;
            this.pbMaceEquipped.TabStop = false;
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbPlayer.Image = global::AdventureGame.Properties.Resources.player30;
            this.pbPlayer.Location = new System.Drawing.Point(96, 63);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(30, 30);
            this.pbPlayer.TabIndex = 25;
            this.pbPlayer.TabStop = false;
            // 
            // pbSwordItem
            // 
            this.pbSwordItem.BackColor = System.Drawing.Color.Transparent;
            this.pbSwordItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbSwordItem.Image = global::AdventureGame.Properties.Resources.sword30;
            this.pbSwordItem.Location = new System.Drawing.Point(132, 63);
            this.pbSwordItem.Name = "pbSwordItem";
            this.pbSwordItem.Size = new System.Drawing.Size(30, 30);
            this.pbSwordItem.TabIndex = 26;
            this.pbSwordItem.TabStop = false;
            // 
            // pbBat
            // 
            this.pbBat.BackColor = System.Drawing.Color.Transparent;
            this.pbBat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbBat.Image = global::AdventureGame.Properties.Resources.bat30;
            this.pbBat.Location = new System.Drawing.Point(168, 63);
            this.pbBat.Name = "pbBat";
            this.pbBat.Size = new System.Drawing.Size(30, 30);
            this.pbBat.TabIndex = 27;
            this.pbBat.TabStop = false;
            // 
            // pbGhoul
            // 
            this.pbGhoul.BackColor = System.Drawing.Color.Transparent;
            this.pbGhoul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbGhoul.Image = global::AdventureGame.Properties.Resources.ghoul30;
            this.pbGhoul.Location = new System.Drawing.Point(204, 63);
            this.pbGhoul.Name = "pbGhoul";
            this.pbGhoul.Size = new System.Drawing.Size(30, 30);
            this.pbGhoul.TabIndex = 28;
            this.pbGhoul.TabStop = false;
            // 
            // pbGhost
            // 
            this.pbGhost.BackColor = System.Drawing.Color.Transparent;
            this.pbGhost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbGhost.Image = global::AdventureGame.Properties.Resources.ghost30;
            this.pbGhost.Location = new System.Drawing.Point(240, 63);
            this.pbGhost.Name = "pbGhost";
            this.pbGhost.Size = new System.Drawing.Size(30, 30);
            this.pbGhost.TabIndex = 29;
            this.pbGhost.TabStop = false;
            // 
            // pbBowItem
            // 
            this.pbBowItem.BackColor = System.Drawing.Color.Transparent;
            this.pbBowItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbBowItem.Image = global::AdventureGame.Properties.Resources.bow30;
            this.pbBowItem.Location = new System.Drawing.Point(276, 63);
            this.pbBowItem.Name = "pbBowItem";
            this.pbBowItem.Size = new System.Drawing.Size(30, 30);
            this.pbBowItem.TabIndex = 30;
            this.pbBowItem.TabStop = false;
            // 
            // pbPotionRedItem
            // 
            this.pbPotionRedItem.BackColor = System.Drawing.Color.Transparent;
            this.pbPotionRedItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbPotionRedItem.Image = global::AdventureGame.Properties.Resources.potion_red30;
            this.pbPotionRedItem.Location = new System.Drawing.Point(312, 63);
            this.pbPotionRedItem.Name = "pbPotionRedItem";
            this.pbPotionRedItem.Size = new System.Drawing.Size(30, 30);
            this.pbPotionRedItem.TabIndex = 31;
            this.pbPotionRedItem.TabStop = false;
            // 
            // pbPotionBlueItem
            // 
            this.pbPotionBlueItem.BackColor = System.Drawing.Color.Transparent;
            this.pbPotionBlueItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbPotionBlueItem.Image = global::AdventureGame.Properties.Resources.potion_blue30;
            this.pbPotionBlueItem.Location = new System.Drawing.Point(348, 63);
            this.pbPotionBlueItem.Name = "pbPotionBlueItem";
            this.pbPotionBlueItem.Size = new System.Drawing.Size(30, 30);
            this.pbPotionBlueItem.TabIndex = 32;
            this.pbPotionBlueItem.TabStop = false;
            // 
            // pbMazeItem
            // 
            this.pbMazeItem.BackColor = System.Drawing.Color.Transparent;
            this.pbMazeItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbMazeItem.Image = global::AdventureGame.Properties.Resources.mace30;
            this.pbMazeItem.Location = new System.Drawing.Point(384, 63);
            this.pbMazeItem.Name = "pbMazeItem";
            this.pbMazeItem.Size = new System.Drawing.Size(30, 30);
            this.pbMazeItem.TabIndex = 33;
            this.pbMazeItem.TabStop = false;
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(647, 32);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(75, 23);
            this.btnMoveUp.TabIndex = 34;
            this.btnMoveUp.Text = "Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 399);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.pbMazeItem);
            this.Controls.Add(this.pbPotionBlueItem);
            this.Controls.Add(this.pbPotionRedItem);
            this.Controls.Add(this.pbBowItem);
            this.Controls.Add(this.pbGhost);
            this.Controls.Add(this.pbGhoul);
            this.Controls.Add(this.pbBat);
            this.Controls.Add(this.pbSwordItem);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.pbMaceEquipped);
            this.Controls.Add(this.pbBowEquipped);
            this.Controls.Add(this.pbPotionBlueEquipped);
            this.Controls.Add(this.pbPotionRedEquipped);
            this.Controls.Add(this.pbSwordEquipped);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnAtkDown);
            this.Controls.Add(this.btnAtkRight);
            this.Controls.Add(this.btnAtkLeft);
            this.Controls.Add(this.btnAtkUp);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSwordEquipped)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPotionRedEquipped)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPotionBlueEquipped)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBowEquipped)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaceEquipped)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSwordItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGhoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBowItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPotionRedItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPotionBlueItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMazeItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnAtkDown;
        private System.Windows.Forms.Button btnAtkRight;
        private System.Windows.Forms.Button btnAtkLeft;
        private System.Windows.Forms.Button btnAtkUp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label lbGhoul;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbGhost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lbPlayer;
        private System.Windows.Forms.Label lbBat;
        private System.Windows.Forms.PictureBox pbSwordEquipped;
        private System.Windows.Forms.PictureBox pbPotionRedEquipped;
        private System.Windows.Forms.PictureBox pbPotionBlueEquipped;
        private System.Windows.Forms.PictureBox pbBowEquipped;
        private System.Windows.Forms.PictureBox pbMaceEquipped;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbSwordItem;
        private System.Windows.Forms.PictureBox pbBat;
        private System.Windows.Forms.PictureBox pbGhoul;
        private System.Windows.Forms.PictureBox pbGhost;
        private System.Windows.Forms.PictureBox pbBowItem;
        private System.Windows.Forms.PictureBox pbPotionRedItem;
        private System.Windows.Forms.PictureBox pbPotionBlueItem;
        private System.Windows.Forms.PictureBox pbMazeItem;
        private System.Windows.Forms.Button btnMoveUp;
    }
}

