﻿namespace wordle_clone
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
            this.alertPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.alertLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shapeTopPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCenterPictureBox)).BeginInit();
            this.alertPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.Color.Transparent;
            this.checkButton.BorderColor = System.Drawing.Color.Beige;
            this.checkButton.BorderRadius = 5;
            this.checkButton.BorderThickness = 1;
            this.checkButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.checkButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.checkButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.checkButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.checkButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(65)))), ((int)(((byte)(113)))));
            this.checkButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkButton.ForeColor = System.Drawing.Color.White;
            this.checkButton.Location = new System.Drawing.Point(70, 391);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(242, 42);
            this.checkButton.TabIndex = 10;
            this.checkButton.Text = "Check Word";
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.resetButton.BorderRadius = 5;
            this.resetButton.BorderThickness = 1;
            this.resetButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.resetButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.resetButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resetButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resetButton.FillColor = System.Drawing.Color.Crimson;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(70, 439);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(242, 42);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Reset";
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // rowOneLetterOne
            // 
            this.rowOneLetterOne.BackColor = System.Drawing.SystemColors.Window;
            this.rowOneLetterOne.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowOneLetterOne.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rowOneLetterOne.Location = new System.Drawing.Point(84, 133);
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
            this.rowOneLetterTwo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowOneLetterTwo.Location = new System.Drawing.Point(128, 133);
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
            this.rowOneLetterThree.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowOneLetterThree.Location = new System.Drawing.Point(172, 133);
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
            this.rowOneLetterFour.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowOneLetterFour.Location = new System.Drawing.Point(216, 133);
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
            this.rowOneLetterFive.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowOneLetterFive.Location = new System.Drawing.Point(260, 133);
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
            this.rowTwoLetterFive.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowTwoLetterFive.Location = new System.Drawing.Point(260, 177);
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
            this.rowTwoLetterFour.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowTwoLetterFour.Location = new System.Drawing.Point(216, 177);
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
            this.rowTwoLetterThree.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowTwoLetterThree.Location = new System.Drawing.Point(172, 177);
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
            this.rowTwoLetterTwo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowTwoLetterTwo.Location = new System.Drawing.Point(128, 177);
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
            this.rowTwoLetterOne.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowTwoLetterOne.Location = new System.Drawing.Point(84, 177);
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
            this.rowThreeLetterFive.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowThreeLetterFive.Location = new System.Drawing.Point(260, 221);
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
            this.rowThreeLetterFour.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowThreeLetterFour.Location = new System.Drawing.Point(216, 221);
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
            this.rowThreeLetterThree.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowThreeLetterThree.Location = new System.Drawing.Point(172, 221);
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
            this.rowThreeLetterTwo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowThreeLetterTwo.Location = new System.Drawing.Point(128, 221);
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
            this.rowThreeLetterOne.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowThreeLetterOne.Location = new System.Drawing.Point(84, 221);
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
            this.rowFourLetterFive.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowFourLetterFive.Location = new System.Drawing.Point(260, 265);
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
            this.rowFourLetterFour.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowFourLetterFour.Location = new System.Drawing.Point(216, 265);
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
            this.rowFourLetterThree.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowFourLetterThree.Location = new System.Drawing.Point(172, 265);
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
            this.rowFourLetterTwo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowFourLetterTwo.Location = new System.Drawing.Point(128, 265);
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
            this.rowFourLetterOne.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowFourLetterOne.Location = new System.Drawing.Point(84, 265);
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
            this.rowFiveLetterFive.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowFiveLetterFive.Location = new System.Drawing.Point(260, 309);
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
            this.rowFiveLetterFour.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowFiveLetterFour.Location = new System.Drawing.Point(216, 309);
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
            this.rowFiveLetterThree.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowFiveLetterThree.Location = new System.Drawing.Point(172, 309);
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
            this.rowFiveLetterTwo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowFiveLetterTwo.Location = new System.Drawing.Point(128, 309);
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
            this.rowFiveLetterOne.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowFiveLetterOne.Location = new System.Drawing.Point(84, 309);
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
            this.shapeTopPictureBox.Location = new System.Drawing.Point(-198, -128);
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
            this.mainCenterPictureBox.Location = new System.Drawing.Point(70, 102);
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
            this.alertPanel.Location = new System.Drawing.Point(49, 31);
            this.alertPanel.Name = "alertPanel";
            this.alertPanel.Size = new System.Drawing.Size(263, 49);
            this.alertPanel.TabIndex = 43;
            // 
            // alertPictureBox
            // 
            this.alertPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.alertPictureBox.BorderRadius = 5;
            this.alertPictureBox.FillColor = System.Drawing.Color.Crimson;
            this.alertPictureBox.ImageRotate = 0F;
            this.alertPictureBox.Location = new System.Drawing.Point(21, 10);
            this.alertPictureBox.Name = "alertPictureBox";
            this.alertPictureBox.Size = new System.Drawing.Size(242, 36);
            this.alertPictureBox.TabIndex = 0;
            this.alertPictureBox.TabStop = false;
            this.alertPictureBox.UseTransparentBackground = true;
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
            // Wordle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(385, 563);
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
    }
}

