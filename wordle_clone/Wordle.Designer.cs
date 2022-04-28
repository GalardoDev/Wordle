namespace wordle_clone
{
    partial class Wordle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wordle));
            this.checkButton = new Guna.UI2.WinForms.Guna2Button();
            this.resetButton = new Guna.UI2.WinForms.Guna2Button();
            this.rowOneLetterOne = new System.Windows.Forms.TextBox();
            this.rowOneLetterTwo = new System.Windows.Forms.TextBox();
            this.rowOneLetterThree = new System.Windows.Forms.TextBox();
            this.rowOneLetterFour = new System.Windows.Forms.TextBox();
            this.rowOneLetterFive = new System.Windows.Forms.TextBox();
            this.rowTwoLetterFive = new System.Windows.Forms.TextBox();
            this.rowTwoLetterFour = new System.Windows.Forms.TextBox();
            this.rowTwoLetterThree = new System.Windows.Forms.TextBox();
            this.rowTwoLetterTwo = new System.Windows.Forms.TextBox();
            this.rowTwoLetterOne = new System.Windows.Forms.TextBox();
            this.rowThreeLetterFive = new System.Windows.Forms.TextBox();
            this.rowThreeLetterFour = new System.Windows.Forms.TextBox();
            this.rowThreeLetterThree = new System.Windows.Forms.TextBox();
            this.rowThreeLetterTwo = new System.Windows.Forms.TextBox();
            this.rowThreeLetterOne = new System.Windows.Forms.TextBox();
            this.rowFourLetterFive = new System.Windows.Forms.TextBox();
            this.rowFourLetterFour = new System.Windows.Forms.TextBox();
            this.rowFourLetterThree = new System.Windows.Forms.TextBox();
            this.rowFourLetterTwo = new System.Windows.Forms.TextBox();
            this.rowFourLetterOne = new System.Windows.Forms.TextBox();
            this.rowFiveLetterFive = new System.Windows.Forms.TextBox();
            this.rowFiveLetterFour = new System.Windows.Forms.TextBox();
            this.rowFiveLetterThree = new System.Windows.Forms.TextBox();
            this.rowFiveLetterTwo = new System.Windows.Forms.TextBox();
            this.rowFiveLetterOne = new System.Windows.Forms.TextBox();
            this.shapeTopPictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.mainCenterPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.alertPanel = new System.Windows.Forms.Panel();
            this.alertLabel = new System.Windows.Forms.Label();
            this.alertPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.newGameButton = new Guna.UI2.WinForms.Guna2Button();
            this.exitButton = new Guna.UI2.WinForms.Guna2PictureBox();
            this.correctPlaceDef = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shapeTopPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCenterPictureBox)).BeginInit();
            this.alertPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correctPlaceDef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.Color.Transparent;
            this.checkButton.BorderColor = System.Drawing.Color.Beige;
            this.checkButton.BorderRadius = 5;
            this.checkButton.BorderThickness = 1;
            this.checkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.checkButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.checkButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.checkButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.checkButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(65)))), ((int)(((byte)(113)))));
            this.checkButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkButton.ForeColor = System.Drawing.Color.White;
            this.checkButton.Location = new System.Drawing.Point(75, 391);
            this.checkButton.Name = "checkButton";
            this.checkButton.ShadowDecoration.Depth = 5;
            this.checkButton.ShadowDecoration.Enabled = true;
            this.checkButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.checkButton.Size = new System.Drawing.Size(242, 42);
            this.checkButton.TabIndex = 10;
            this.checkButton.Text = "Check Word";
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Transparent;
            this.resetButton.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.resetButton.BorderRadius = 5;
            this.resetButton.BorderThickness = 1;
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.resetButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.resetButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resetButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resetButton.FillColor = System.Drawing.Color.Crimson;
            this.resetButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(75, 439);
            this.resetButton.Name = "resetButton";
            this.resetButton.ShadowDecoration.Enabled = true;
            this.resetButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.resetButton.Size = new System.Drawing.Size(242, 42);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Reset";
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // rowOneLetterOne
            // 
            this.rowOneLetterOne.BackColor = System.Drawing.Color.White;
            this.rowOneLetterOne.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowOneLetterOne.ForeColor = System.Drawing.Color.Black;
            this.rowOneLetterOne.Location = new System.Drawing.Point(89, 133);
            this.rowOneLetterOne.MaxLength = 1;
            this.rowOneLetterOne.Multiline = true;
            this.rowOneLetterOne.Name = "rowOneLetterOne";
            this.rowOneLetterOne.Size = new System.Drawing.Size(38, 38);
            this.rowOneLetterOne.TabIndex = 12;
            this.rowOneLetterOne.Tag = "rowOne";
            this.rowOneLetterOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rowOneLetterTwo
            // 
            this.rowOneLetterTwo.BackColor = System.Drawing.Color.White;
            this.rowOneLetterTwo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowOneLetterTwo.ForeColor = System.Drawing.Color.Black;
            this.rowOneLetterTwo.Location = new System.Drawing.Point(133, 133);
            this.rowOneLetterTwo.MaxLength = 1;
            this.rowOneLetterTwo.Multiline = true;
            this.rowOneLetterTwo.Name = "rowOneLetterTwo";
            this.rowOneLetterTwo.Size = new System.Drawing.Size(38, 38);
            this.rowOneLetterTwo.TabIndex = 13;
            this.rowOneLetterTwo.Tag = "rowOne";
            this.rowOneLetterTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rowOneLetterThree
            // 
            this.rowOneLetterThree.BackColor = System.Drawing.Color.White;
            this.rowOneLetterThree.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowOneLetterThree.ForeColor = System.Drawing.Color.Black;
            this.rowOneLetterThree.Location = new System.Drawing.Point(177, 133);
            this.rowOneLetterThree.MaxLength = 1;
            this.rowOneLetterThree.Multiline = true;
            this.rowOneLetterThree.Name = "rowOneLetterThree";
            this.rowOneLetterThree.Size = new System.Drawing.Size(38, 38);
            this.rowOneLetterThree.TabIndex = 14;
            this.rowOneLetterThree.Tag = "rowOne";
            this.rowOneLetterThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rowOneLetterFour
            // 
            this.rowOneLetterFour.BackColor = System.Drawing.Color.White;
            this.rowOneLetterFour.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowOneLetterFour.ForeColor = System.Drawing.Color.Black;
            this.rowOneLetterFour.Location = new System.Drawing.Point(221, 133);
            this.rowOneLetterFour.MaxLength = 1;
            this.rowOneLetterFour.Multiline = true;
            this.rowOneLetterFour.Name = "rowOneLetterFour";
            this.rowOneLetterFour.Size = new System.Drawing.Size(38, 38);
            this.rowOneLetterFour.TabIndex = 15;
            this.rowOneLetterFour.Tag = "rowOne";
            this.rowOneLetterFour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rowOneLetterFive
            // 
            this.rowOneLetterFive.BackColor = System.Drawing.Color.White;
            this.rowOneLetterFive.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowOneLetterFive.ForeColor = System.Drawing.Color.Black;
            this.rowOneLetterFive.Location = new System.Drawing.Point(265, 133);
            this.rowOneLetterFive.MaxLength = 1;
            this.rowOneLetterFive.Multiline = true;
            this.rowOneLetterFive.Name = "rowOneLetterFive";
            this.rowOneLetterFive.Size = new System.Drawing.Size(38, 38);
            this.rowOneLetterFive.TabIndex = 16;
            this.rowOneLetterFive.Tag = "rowOne";
            this.rowOneLetterFive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rowTwoLetterFive
            // 
            this.rowTwoLetterFive.BackColor = System.Drawing.Color.White;
            this.rowTwoLetterFive.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowTwoLetterFive.ForeColor = System.Drawing.Color.Black;
            this.rowTwoLetterFive.Location = new System.Drawing.Point(265, 177);
            this.rowTwoLetterFive.MaxLength = 1;
            this.rowTwoLetterFive.Multiline = true;
            this.rowTwoLetterFive.Name = "rowTwoLetterFive";
            this.rowTwoLetterFive.Size = new System.Drawing.Size(38, 38);
            this.rowTwoLetterFive.TabIndex = 21;
            this.rowTwoLetterFive.Tag = "rowTwo";
            this.rowTwoLetterFive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rowTwoLetterFour
            // 
            this.rowTwoLetterFour.BackColor = System.Drawing.Color.White;
            this.rowTwoLetterFour.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowTwoLetterFour.ForeColor = System.Drawing.Color.Black;
            this.rowTwoLetterFour.Location = new System.Drawing.Point(221, 177);
            this.rowTwoLetterFour.MaxLength = 1;
            this.rowTwoLetterFour.Multiline = true;
            this.rowTwoLetterFour.Name = "rowTwoLetterFour";
            this.rowTwoLetterFour.Size = new System.Drawing.Size(38, 38);
            this.rowTwoLetterFour.TabIndex = 20;
            this.rowTwoLetterFour.Tag = "rowTwo";
            this.rowTwoLetterFour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rowTwoLetterThree
            // 
            this.rowTwoLetterThree.BackColor = System.Drawing.Color.White;
            this.rowTwoLetterThree.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowTwoLetterThree.ForeColor = System.Drawing.Color.Black;
            this.rowTwoLetterThree.Location = new System.Drawing.Point(177, 177);
            this.rowTwoLetterThree.MaxLength = 1;
            this.rowTwoLetterThree.Multiline = true;
            this.rowTwoLetterThree.Name = "rowTwoLetterThree";
            this.rowTwoLetterThree.Size = new System.Drawing.Size(38, 38);
            this.rowTwoLetterThree.TabIndex = 19;
            this.rowTwoLetterThree.Tag = "rowTwo";
            this.rowTwoLetterThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rowTwoLetterTwo
            // 
            this.rowTwoLetterTwo.BackColor = System.Drawing.Color.White;
            this.rowTwoLetterTwo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowTwoLetterTwo.ForeColor = System.Drawing.Color.Black;
            this.rowTwoLetterTwo.Location = new System.Drawing.Point(133, 177);
            this.rowTwoLetterTwo.MaxLength = 1;
            this.rowTwoLetterTwo.Multiline = true;
            this.rowTwoLetterTwo.Name = "rowTwoLetterTwo";
            this.rowTwoLetterTwo.Size = new System.Drawing.Size(38, 38);
            this.rowTwoLetterTwo.TabIndex = 18;
            this.rowTwoLetterTwo.Tag = "rowTwo";
            this.rowTwoLetterTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rowTwoLetterOne
            // 
            this.rowTwoLetterOne.BackColor = System.Drawing.Color.White;
            this.rowTwoLetterOne.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowTwoLetterOne.ForeColor = System.Drawing.Color.Black;
            this.rowTwoLetterOne.Location = new System.Drawing.Point(89, 177);
            this.rowTwoLetterOne.MaxLength = 1;
            this.rowTwoLetterOne.Multiline = true;
            this.rowTwoLetterOne.Name = "rowTwoLetterOne";
            this.rowTwoLetterOne.Size = new System.Drawing.Size(38, 38);
            this.rowTwoLetterOne.TabIndex = 17;
            this.rowTwoLetterOne.Tag = "rowTwo";
            this.rowTwoLetterOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rowThreeLetterFive
            // 
            this.rowThreeLetterFive.BackColor = System.Drawing.Color.White;
            this.rowThreeLetterFive.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowThreeLetterFive.ForeColor = System.Drawing.Color.Black;
            this.rowThreeLetterFive.Location = new System.Drawing.Point(265, 221);
            this.rowThreeLetterFive.MaxLength = 1;
            this.rowThreeLetterFive.Multiline = true;
            this.rowThreeLetterFive.Name = "rowThreeLetterFive";
            this.rowThreeLetterFive.Size = new System.Drawing.Size(38, 38);
            this.rowThreeLetterFive.TabIndex = 26;
            this.rowThreeLetterFive.Tag = "rowThree";
            this.rowThreeLetterFive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rowThreeLetterFour
            // 
            this.rowThreeLetterFour.BackColor = System.Drawing.Color.White;
            this.rowThreeLetterFour.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowThreeLetterFour.ForeColor = System.Drawing.Color.Black;
            this.rowThreeLetterFour.Location = new System.Drawing.Point(221, 221);
            this.rowThreeLetterFour.MaxLength = 1;
            this.rowThreeLetterFour.Multiline = true;
            this.rowThreeLetterFour.Name = "rowThreeLetterFour";
            this.rowThreeLetterFour.Size = new System.Drawing.Size(38, 38);
            this.rowThreeLetterFour.TabIndex = 25;
            this.rowThreeLetterFour.Tag = "rowThree";
            this.rowThreeLetterFour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rowThreeLetterThree
            // 
            this.rowThreeLetterThree.BackColor = System.Drawing.Color.White;
            this.rowThreeLetterThree.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowThreeLetterThree.ForeColor = System.Drawing.Color.Black;
            this.rowThreeLetterThree.Location = new System.Drawing.Point(177, 221);
            this.rowThreeLetterThree.MaxLength = 1;
            this.rowThreeLetterThree.Multiline = true;
            this.rowThreeLetterThree.Name = "rowThreeLetterThree";
            this.rowThreeLetterThree.Size = new System.Drawing.Size(38, 38);
            this.rowThreeLetterThree.TabIndex = 24;
            this.rowThreeLetterThree.Tag = "rowThree";
            this.rowThreeLetterThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rowThreeLetterTwo
            // 
            this.rowThreeLetterTwo.BackColor = System.Drawing.Color.White;
            this.rowThreeLetterTwo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowThreeLetterTwo.ForeColor = System.Drawing.Color.Black;
            this.rowThreeLetterTwo.Location = new System.Drawing.Point(133, 221);
            this.rowThreeLetterTwo.MaxLength = 1;
            this.rowThreeLetterTwo.Multiline = true;
            this.rowThreeLetterTwo.Name = "rowThreeLetterTwo";
            this.rowThreeLetterTwo.Size = new System.Drawing.Size(38, 38);
            this.rowThreeLetterTwo.TabIndex = 23;
            this.rowThreeLetterTwo.Tag = "rowThree";
            this.rowThreeLetterTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rowThreeLetterOne
            // 
            this.rowThreeLetterOne.BackColor = System.Drawing.Color.White;
            this.rowThreeLetterOne.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowThreeLetterOne.ForeColor = System.Drawing.Color.Black;
            this.rowThreeLetterOne.Location = new System.Drawing.Point(89, 221);
            this.rowThreeLetterOne.MaxLength = 1;
            this.rowThreeLetterOne.Multiline = true;
            this.rowThreeLetterOne.Name = "rowThreeLetterOne";
            this.rowThreeLetterOne.Size = new System.Drawing.Size(38, 38);
            this.rowThreeLetterOne.TabIndex = 22;
            this.rowThreeLetterOne.Tag = "rowThree";
            this.rowThreeLetterOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rowFourLetterFive
            // 
            this.rowFourLetterFive.BackColor = System.Drawing.Color.White;
            this.rowFourLetterFive.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowFourLetterFive.ForeColor = System.Drawing.Color.Black;
            this.rowFourLetterFive.Location = new System.Drawing.Point(265, 265);
            this.rowFourLetterFive.MaxLength = 1;
            this.rowFourLetterFive.Multiline = true;
            this.rowFourLetterFive.Name = "rowFourLetterFive";
            this.rowFourLetterFive.Size = new System.Drawing.Size(38, 38);
            this.rowFourLetterFive.TabIndex = 31;
            this.rowFourLetterFive.Tag = "rowFour";
            this.rowFourLetterFive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rowFourLetterFour
            // 
            this.rowFourLetterFour.BackColor = System.Drawing.Color.White;
            this.rowFourLetterFour.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowFourLetterFour.ForeColor = System.Drawing.Color.Black;
            this.rowFourLetterFour.Location = new System.Drawing.Point(221, 265);
            this.rowFourLetterFour.MaxLength = 1;
            this.rowFourLetterFour.Multiline = true;
            this.rowFourLetterFour.Name = "rowFourLetterFour";
            this.rowFourLetterFour.Size = new System.Drawing.Size(38, 38);
            this.rowFourLetterFour.TabIndex = 30;
            this.rowFourLetterFour.Tag = "rowFour";
            this.rowFourLetterFour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rowFourLetterThree
            // 
            this.rowFourLetterThree.BackColor = System.Drawing.Color.White;
            this.rowFourLetterThree.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowFourLetterThree.ForeColor = System.Drawing.Color.Black;
            this.rowFourLetterThree.Location = new System.Drawing.Point(177, 265);
            this.rowFourLetterThree.MaxLength = 1;
            this.rowFourLetterThree.Multiline = true;
            this.rowFourLetterThree.Name = "rowFourLetterThree";
            this.rowFourLetterThree.Size = new System.Drawing.Size(38, 38);
            this.rowFourLetterThree.TabIndex = 29;
            this.rowFourLetterThree.Tag = "rowFour";
            this.rowFourLetterThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rowFourLetterTwo
            // 
            this.rowFourLetterTwo.BackColor = System.Drawing.Color.White;
            this.rowFourLetterTwo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowFourLetterTwo.ForeColor = System.Drawing.Color.Black;
            this.rowFourLetterTwo.Location = new System.Drawing.Point(133, 265);
            this.rowFourLetterTwo.MaxLength = 1;
            this.rowFourLetterTwo.Multiline = true;
            this.rowFourLetterTwo.Name = "rowFourLetterTwo";
            this.rowFourLetterTwo.Size = new System.Drawing.Size(38, 38);
            this.rowFourLetterTwo.TabIndex = 28;
            this.rowFourLetterTwo.Tag = "rowFour";
            this.rowFourLetterTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rowFourLetterOne
            // 
            this.rowFourLetterOne.BackColor = System.Drawing.Color.White;
            this.rowFourLetterOne.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowFourLetterOne.ForeColor = System.Drawing.Color.Black;
            this.rowFourLetterOne.Location = new System.Drawing.Point(89, 265);
            this.rowFourLetterOne.MaxLength = 1;
            this.rowFourLetterOne.Multiline = true;
            this.rowFourLetterOne.Name = "rowFourLetterOne";
            this.rowFourLetterOne.Size = new System.Drawing.Size(38, 38);
            this.rowFourLetterOne.TabIndex = 27;
            this.rowFourLetterOne.Tag = "rowFour";
            this.rowFourLetterOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rowFiveLetterFive
            // 
            this.rowFiveLetterFive.BackColor = System.Drawing.Color.White;
            this.rowFiveLetterFive.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowFiveLetterFive.ForeColor = System.Drawing.Color.Black;
            this.rowFiveLetterFive.Location = new System.Drawing.Point(265, 309);
            this.rowFiveLetterFive.MaxLength = 1;
            this.rowFiveLetterFive.Multiline = true;
            this.rowFiveLetterFive.Name = "rowFiveLetterFive";
            this.rowFiveLetterFive.Size = new System.Drawing.Size(38, 38);
            this.rowFiveLetterFive.TabIndex = 36;
            this.rowFiveLetterFive.Tag = "rowFive";
            this.rowFiveLetterFive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rowFiveLetterFour
            // 
            this.rowFiveLetterFour.BackColor = System.Drawing.Color.White;
            this.rowFiveLetterFour.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowFiveLetterFour.ForeColor = System.Drawing.Color.Black;
            this.rowFiveLetterFour.Location = new System.Drawing.Point(221, 309);
            this.rowFiveLetterFour.MaxLength = 1;
            this.rowFiveLetterFour.Multiline = true;
            this.rowFiveLetterFour.Name = "rowFiveLetterFour";
            this.rowFiveLetterFour.Size = new System.Drawing.Size(38, 38);
            this.rowFiveLetterFour.TabIndex = 35;
            this.rowFiveLetterFour.Tag = "rowFive";
            this.rowFiveLetterFour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rowFiveLetterThree
            // 
            this.rowFiveLetterThree.BackColor = System.Drawing.Color.White;
            this.rowFiveLetterThree.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowFiveLetterThree.ForeColor = System.Drawing.Color.Black;
            this.rowFiveLetterThree.Location = new System.Drawing.Point(177, 309);
            this.rowFiveLetterThree.MaxLength = 1;
            this.rowFiveLetterThree.Multiline = true;
            this.rowFiveLetterThree.Name = "rowFiveLetterThree";
            this.rowFiveLetterThree.Size = new System.Drawing.Size(38, 38);
            this.rowFiveLetterThree.TabIndex = 34;
            this.rowFiveLetterThree.Tag = "rowFive";
            this.rowFiveLetterThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rowFiveLetterTwo
            // 
            this.rowFiveLetterTwo.BackColor = System.Drawing.Color.White;
            this.rowFiveLetterTwo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowFiveLetterTwo.ForeColor = System.Drawing.Color.Black;
            this.rowFiveLetterTwo.Location = new System.Drawing.Point(133, 309);
            this.rowFiveLetterTwo.MaxLength = 1;
            this.rowFiveLetterTwo.Multiline = true;
            this.rowFiveLetterTwo.Name = "rowFiveLetterTwo";
            this.rowFiveLetterTwo.Size = new System.Drawing.Size(38, 38);
            this.rowFiveLetterTwo.TabIndex = 33;
            this.rowFiveLetterTwo.Tag = "rowFive";
            this.rowFiveLetterTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rowFiveLetterOne
            // 
            this.rowFiveLetterOne.BackColor = System.Drawing.Color.White;
            this.rowFiveLetterOne.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowFiveLetterOne.ForeColor = System.Drawing.Color.Black;
            this.rowFiveLetterOne.Location = new System.Drawing.Point(89, 309);
            this.rowFiveLetterOne.MaxLength = 1;
            this.rowFiveLetterOne.Multiline = true;
            this.rowFiveLetterOne.Name = "rowFiveLetterOne";
            this.rowFiveLetterOne.Size = new System.Drawing.Size(38, 38);
            this.rowFiveLetterOne.TabIndex = 32;
            this.rowFiveLetterOne.Tag = "rowFive";
            this.rowFiveLetterOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // shapeTopPictureBox
            // 
            this.shapeTopPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.shapeTopPictureBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(65)))), ((int)(((byte)(113)))));
            this.shapeTopPictureBox.ImageRotate = 0F;
            this.shapeTopPictureBox.Location = new System.Drawing.Point(-193, -128);
            this.shapeTopPictureBox.Name = "shapeTopPictureBox";
            this.shapeTopPictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.shapeTopPictureBox.Size = new System.Drawing.Size(940, 371);
            this.shapeTopPictureBox.TabIndex = 41;
            this.shapeTopPictureBox.TabStop = false;
            // 
            // mainCenterPictureBox
            // 
            this.mainCenterPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.mainCenterPictureBox.BorderRadius = 7;
            this.mainCenterPictureBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.mainCenterPictureBox.ImageRotate = 0F;
            this.mainCenterPictureBox.Location = new System.Drawing.Point(75, 102);
            this.mainCenterPictureBox.Name = "mainCenterPictureBox";
            this.mainCenterPictureBox.ShadowDecoration.BorderRadius = 7;
            this.mainCenterPictureBox.ShadowDecoration.Depth = 10;
            this.mainCenterPictureBox.ShadowDecoration.Enabled = true;
            this.mainCenterPictureBox.Size = new System.Drawing.Size(242, 269);
            this.mainCenterPictureBox.TabIndex = 42;
            this.mainCenterPictureBox.TabStop = false;
            this.mainCenterPictureBox.UseTransparentBackground = true;
            // 
            // alertPanel
            // 
            this.alertPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(65)))), ((int)(((byte)(113)))));
            this.alertPanel.Controls.Add(this.alertLabel);
            this.alertPanel.Controls.Add(this.alertPictureBox);
            this.alertPanel.Location = new System.Drawing.Point(54, 42);
            this.alertPanel.Name = "alertPanel";
            this.alertPanel.Size = new System.Drawing.Size(263, 49);
            this.alertPanel.TabIndex = 43;
            // 
            // alertLabel
            // 
            this.alertLabel.AutoSize = true;
            this.alertLabel.BackColor = System.Drawing.Color.Crimson;
            this.alertLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertLabel.ForeColor = System.Drawing.Color.White;
            this.alertLabel.Location = new System.Drawing.Point(34, 20);
            this.alertLabel.Name = "alertLabel";
            this.alertLabel.Size = new System.Drawing.Size(217, 16);
            this.alertLabel.TabIndex = 1;
            this.alertLabel.Text = "Word does not exist in our database!";
            this.alertLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alertPictureBox
            // 
            this.alertPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.alertPictureBox.BorderRadius = 5;
            this.alertPictureBox.FillColor = System.Drawing.Color.Crimson;
            this.alertPictureBox.ImageRotate = 0F;
            this.alertPictureBox.Location = new System.Drawing.Point(21, 10);
            this.alertPictureBox.Name = "alertPictureBox";
            this.alertPictureBox.ShadowDecoration.Enabled = true;
            this.alertPictureBox.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.alertPictureBox.Size = new System.Drawing.Size(242, 36);
            this.alertPictureBox.TabIndex = 0;
            this.alertPictureBox.TabStop = false;
            this.alertPictureBox.UseTransparentBackground = true;
            // 
            // newGameButton
            // 
            this.newGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(65)))), ((int)(((byte)(113)))));
            this.newGameButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.newGameButton.BorderRadius = 5;
            this.newGameButton.BorderThickness = 3;
            this.newGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newGameButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.newGameButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.newGameButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.newGameButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.newGameButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(65)))), ((int)(((byte)(113)))));
            this.newGameButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.newGameButton.Location = new System.Drawing.Point(12, 12);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(61, 27);
            this.newGameButton.TabIndex = 44;
            this.newGameButton.Text = "New";
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(65)))), ((int)(((byte)(113)))));
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(65)))), ((int)(((byte)(113)))));
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageRotate = 0F;
            this.exitButton.Location = new System.Drawing.Point(344, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(29, 27);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitButton.TabIndex = 45;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // correctPlaceDef
            // 
            this.correctPlaceDef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.correctPlaceDef.BorderRadius = 2;
            this.correctPlaceDef.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(65)))), ((int)(((byte)(113)))));
            this.correctPlaceDef.ImageRotate = 0F;
            this.correctPlaceDef.Location = new System.Drawing.Point(114, 500);
            this.correctPlaceDef.Name = "correctPlaceDef";
            this.correctPlaceDef.Size = new System.Drawing.Size(10, 10);
            this.correctPlaceDef.TabIndex = 46;
            this.correctPlaceDef.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.guna2PictureBox1.BorderRadius = 2;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Crimson;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(114, 516);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(10, 10);
            this.guna2PictureBox1.TabIndex = 47;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.guna2PictureBox2.BorderRadius = 2;
            this.guna2PictureBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(64)))));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(114, 532);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(10, 10);
            this.guna2PictureBox2.TabIndex = 48;
            this.guna2PictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 49;
            this.label1.Text = "- Right letter, right place\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 30);
            this.label2.TabIndex = 50;
            this.label2.Text = "- Wrong letter, wrong place\r\n\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 528);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 30);
            this.label3.TabIndex = 51;
            this.label3.Text = "- Right letter, wrong place\r\n\r\n";
            // 
            // Wordle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(385, 563);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.correctPlaceDef);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.alertPanel);
            this.Controls.Add(this.rowFiveLetterFive);
            this.Controls.Add(this.rowFiveLetterFour);
            this.Controls.Add(this.rowFiveLetterThree);
            this.Controls.Add(this.rowFiveLetterTwo);
            this.Controls.Add(this.rowFiveLetterOne);
            this.Controls.Add(this.rowFourLetterFive);
            this.Controls.Add(this.rowFourLetterFour);
            this.Controls.Add(this.rowFourLetterThree);
            this.Controls.Add(this.rowFourLetterTwo);
            this.Controls.Add(this.rowFourLetterOne);
            this.Controls.Add(this.rowThreeLetterFive);
            this.Controls.Add(this.rowThreeLetterFour);
            this.Controls.Add(this.rowThreeLetterThree);
            this.Controls.Add(this.rowThreeLetterTwo);
            this.Controls.Add(this.rowThreeLetterOne);
            this.Controls.Add(this.rowTwoLetterFive);
            this.Controls.Add(this.rowTwoLetterFour);
            this.Controls.Add(this.rowTwoLetterThree);
            this.Controls.Add(this.rowTwoLetterTwo);
            this.Controls.Add(this.rowTwoLetterOne);
            this.Controls.Add(this.rowOneLetterFive);
            this.Controls.Add(this.rowOneLetterFour);
            this.Controls.Add(this.rowOneLetterThree);
            this.Controls.Add(this.rowOneLetterTwo);
            this.Controls.Add(this.rowOneLetterOne);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.mainCenterPictureBox);
            this.Controls.Add(this.shapeTopPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Wordle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wordle";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shapeTopPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCenterPictureBox)).EndInit();
            this.alertPanel.ResumeLayout(false);
            this.alertPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correctPlaceDef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button checkButton;
        private Guna.UI2.WinForms.Guna2Button resetButton;
        private System.Windows.Forms.TextBox rowOneLetterOne;
        private System.Windows.Forms.TextBox rowOneLetterTwo;
        private System.Windows.Forms.TextBox rowOneLetterThree;
        private System.Windows.Forms.TextBox rowOneLetterFour;
        private System.Windows.Forms.TextBox rowOneLetterFive;
        private System.Windows.Forms.TextBox rowTwoLetterFive;
        private System.Windows.Forms.TextBox rowTwoLetterFour;
        private System.Windows.Forms.TextBox rowTwoLetterThree;
        private System.Windows.Forms.TextBox rowTwoLetterTwo;
        private System.Windows.Forms.TextBox rowTwoLetterOne;
        private System.Windows.Forms.TextBox rowThreeLetterFive;
        private System.Windows.Forms.TextBox rowThreeLetterFour;
        private System.Windows.Forms.TextBox rowThreeLetterThree;
        private System.Windows.Forms.TextBox rowThreeLetterTwo;
        private System.Windows.Forms.TextBox rowThreeLetterOne;
        private System.Windows.Forms.TextBox rowFourLetterFive;
        private System.Windows.Forms.TextBox rowFourLetterFour;
        private System.Windows.Forms.TextBox rowFourLetterThree;
        private System.Windows.Forms.TextBox rowFourLetterTwo;
        private System.Windows.Forms.TextBox rowFourLetterOne;
        private System.Windows.Forms.TextBox rowFiveLetterFive;
        private System.Windows.Forms.TextBox rowFiveLetterFour;
        private System.Windows.Forms.TextBox rowFiveLetterThree;
        private System.Windows.Forms.TextBox rowFiveLetterTwo;
        private System.Windows.Forms.TextBox rowFiveLetterOne;
        private Guna.UI2.WinForms.Guna2CirclePictureBox shapeTopPictureBox;
        private Guna.UI2.WinForms.Guna2PictureBox mainCenterPictureBox;
        private System.Windows.Forms.Panel alertPanel;
        private Guna.UI2.WinForms.Guna2PictureBox alertPictureBox;
        private System.Windows.Forms.Label alertLabel;
        private Guna.UI2.WinForms.Guna2Button newGameButton;
        private Guna.UI2.WinForms.Guna2PictureBox exitButton;
        private Guna.UI2.WinForms.Guna2PictureBox correctPlaceDef;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

