
namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hitButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.dealButton = new System.Windows.Forms.Button();
            this.leaveButton = new System.Windows.Forms.Button();
            this.playerCount = new System.Windows.Forms.TextBox();
            this.dealerCount = new System.Windows.Forms.TextBox();
            this.playerHand = new System.Windows.Forms.TextBox();
            this.dealerHand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dealerC = new System.Windows.Forms.Label();
            this.playerC = new System.Windows.Forms.Label();
            this.dealerH = new System.Windows.Forms.Label();
            this.playerH = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Green;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(59, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(920, 478);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // hitButton
            // 
            this.hitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitButton.Location = new System.Drawing.Point(897, 375);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(82, 48);
            this.hitButton.TabIndex = 1;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            this.hitButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.hitButton_MouseClick);
            // 
            // standButton
            // 
            this.standButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standButton.Location = new System.Drawing.Point(897, 429);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(82, 48);
            this.standButton.TabIndex = 2;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = true;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            this.standButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.standButton_MouseClick);
            // 
            // dealButton
            // 
            this.dealButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealButton.Location = new System.Drawing.Point(59, 375);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(82, 48);
            this.dealButton.TabIndex = 3;
            this.dealButton.Text = "Deal";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // leaveButton
            // 
            this.leaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaveButton.Location = new System.Drawing.Point(59, 429);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(82, 48);
            this.leaveButton.TabIndex = 4;
            this.leaveButton.Text = "Leave";
            this.leaveButton.UseVisualStyleBackColor = true;
            this.leaveButton.Click += new System.EventHandler(this.leaveButton_Click);
            // 
            // playerCount
            // 
            this.playerCount.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.playerCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerCount.Location = new System.Drawing.Point(465, 446);
            this.playerCount.Name = "playerCount";
            this.playerCount.ReadOnly = true;
            this.playerCount.Size = new System.Drawing.Size(98, 17);
            this.playerCount.TabIndex = 6;
            this.playerCount.TextChanged += new System.EventHandler(this.playerCount_TextChanged);
            // 
            // dealerCount
            // 
            this.dealerCount.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.dealerCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dealerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerCount.Location = new System.Drawing.Point(465, 32);
            this.dealerCount.Name = "dealerCount";
            this.dealerCount.ReadOnly = true;
            this.dealerCount.Size = new System.Drawing.Size(98, 17);
            this.dealerCount.TabIndex = 7;
            this.dealerCount.TextChanged += new System.EventHandler(this.dealerCount_TextChanged);
            // 
            // playerHand
            // 
            this.playerHand.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.playerHand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerHand.Location = new System.Drawing.Point(465, 416);
            this.playerHand.Multiline = true;
            this.playerHand.Name = "playerHand";
            this.playerHand.ReadOnly = true;
            this.playerHand.Size = new System.Drawing.Size(343, 20);
            this.playerHand.TabIndex = 8;
            this.playerHand.TextChanged += new System.EventHandler(this.playerHand_TextChanged);
            // 
            // dealerHand
            // 
            this.dealerHand.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.dealerHand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dealerHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerHand.Location = new System.Drawing.Point(465, 58);
            this.dealerHand.Multiline = true;
            this.dealerHand.Name = "dealerHand";
            this.dealerHand.ReadOnly = true;
            this.dealerHand.Size = new System.Drawing.Size(343, 20);
            this.dealerHand.TabIndex = 9;
            this.dealerHand.TextChanged += new System.EventHandler(this.dealerHand_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(461, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            // 
            // dealerC
            // 
            this.dealerC.AutoSize = true;
            this.dealerC.Location = new System.Drawing.Point(388, 35);
            this.dealerC.Name = "dealerC";
            this.dealerC.Size = new System.Drawing.Size(69, 13);
            this.dealerC.TabIndex = 11;
            this.dealerC.Text = "Dealer Count";
            // 
            // playerC
            // 
            this.playerC.AutoSize = true;
            this.playerC.Location = new System.Drawing.Point(390, 449);
            this.playerC.Name = "playerC";
            this.playerC.Size = new System.Drawing.Size(67, 13);
            this.playerC.TabIndex = 12;
            this.playerC.Text = "Player Count";
            // 
            // dealerH
            // 
            this.dealerH.AutoSize = true;
            this.dealerH.Location = new System.Drawing.Point(388, 58);
            this.dealerH.Name = "dealerH";
            this.dealerH.Size = new System.Drawing.Size(67, 13);
            this.dealerH.TabIndex = 13;
            this.dealerH.Text = "Dealer Hand";
            // 
            // playerH
            // 
            this.playerH.AutoSize = true;
            this.playerH.Location = new System.Drawing.Point(390, 423);
            this.playerH.Name = "playerH";
            this.playerH.Size = new System.Drawing.Size(65, 13);
            this.playerH.TabIndex = 14;
            this.playerH.Text = "Player Hand";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 489);
            this.Controls.Add(this.playerH);
            this.Controls.Add(this.dealerH);
            this.Controls.Add(this.playerC);
            this.Controls.Add(this.dealerC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dealerHand);
            this.Controls.Add(this.playerHand);
            this.Controls.Add(this.dealerCount);
            this.Controls.Add(this.playerCount);
            this.Controls.Add(this.leaveButton);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Button leaveButton;
        private System.Windows.Forms.TextBox playerCount;
        private System.Windows.Forms.TextBox dealerCount;
        private System.Windows.Forms.TextBox playerHand;
        private System.Windows.Forms.TextBox dealerHand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dealerC;
        private System.Windows.Forms.Label playerC;
        private System.Windows.Forms.Label dealerH;
        private System.Windows.Forms.Label playerH;
    }
}

