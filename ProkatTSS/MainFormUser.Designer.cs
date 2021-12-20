namespace ProkatTSS
{
    partial class MainFormUser
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Label();
            this.Giros = new System.Windows.Forms.Button();
            this.Moto = new System.Windows.Forms.Button();
            this.Velo = new System.Windows.Forms.Button();
            this.Cars = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.LeaveButton = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Yellow;
            this.MainPanel.Controls.Add(this.button2);
            this.MainPanel.Controls.Add(this.BackButton);
            this.MainPanel.Controls.Add(this.Giros);
            this.MainPanel.Controls.Add(this.Moto);
            this.MainPanel.Controls.Add(this.Velo);
            this.MainPanel.Controls.Add(this.Cars);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(881, 506);
            this.MainPanel.TabIndex = 2;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 58);
            this.button2.TabIndex = 7;
            this.button2.Text = "Арендовать ТС";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BackButton
            // 
            this.BackButton.AutoSize = true;
            this.BackButton.Location = new System.Drawing.Point(888, 482);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(39, 13);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Назад";
            // 
            // Giros
            // 
            this.Giros.Location = new System.Drawing.Point(663, 130);
            this.Giros.Name = "Giros";
            this.Giros.Size = new System.Drawing.Size(188, 67);
            this.Giros.TabIndex = 4;
            this.Giros.Text = "Гироскутеры";
            this.Giros.UseVisualStyleBackColor = true;
            this.Giros.Click += new System.EventHandler(this.Giros_Click_1);
            // 
            // Moto
            // 
            this.Moto.Location = new System.Drawing.Point(451, 130);
            this.Moto.Name = "Moto";
            this.Moto.Size = new System.Drawing.Size(188, 67);
            this.Moto.TabIndex = 3;
            this.Moto.Text = "Мотоциклы";
            this.Moto.UseVisualStyleBackColor = true;
            this.Moto.Click += new System.EventHandler(this.Moto_Click_1);
            // 
            // Velo
            // 
            this.Velo.Location = new System.Drawing.Point(235, 130);
            this.Velo.Name = "Velo";
            this.Velo.Size = new System.Drawing.Size(199, 67);
            this.Velo.TabIndex = 2;
            this.Velo.Text = "Велосипеды";
            this.Velo.UseVisualStyleBackColor = true;
            this.Velo.Click += new System.EventHandler(this.Velo_Click_1);
            // 
            // Cars
            // 
            this.Cars.Location = new System.Drawing.Point(30, 130);
            this.Cars.Name = "Cars";
            this.Cars.Size = new System.Drawing.Size(182, 67);
            this.Cars.TabIndex = 1;
            this.Cars.Text = "Автомобили";
            this.Cars.UseVisualStyleBackColor = true;
            this.Cars.Click += new System.EventHandler(this.Cars_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.LeaveButton);
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 124);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(861, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LeaveButton
            // 
            this.LeaveButton.AutoSize = true;
            this.LeaveButton.Location = new System.Drawing.Point(0, 0);
            this.LeaveButton.Name = "LeaveButton";
            this.LeaveButton.Size = new System.Drawing.Size(39, 13);
            this.LeaveButton.TabIndex = 2;
            this.LeaveButton.Text = "Выйти";
            this.LeaveButton.Click += new System.EventHandler(this.LeaveButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(929, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(319, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Главная страница";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainFormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 506);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainFormUser";
            this.Text = "MainFormUser";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label BackButton;
        private System.Windows.Forms.Button Giros;
        private System.Windows.Forms.Button Moto;
        private System.Windows.Forms.Button Velo;
        private System.Windows.Forms.Button Cars;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LeaveButton;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}