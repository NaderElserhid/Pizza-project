namespace pizza_project
{
    partial class placeOreder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(placeOreder));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdLarg = new System.Windows.Forms.RadioButton();
            this.rdMeduim = new System.Windows.Forms.RadioButton();
            this.rdSmall = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckGreenPeppers = new System.Windows.Forms.CheckBox();
            this.ckOlives = new System.Windows.Forms.CheckBox();
            this.ckOnion = new System.Windows.Forms.CheckBox();
            this.ckTomatoes = new System.Windows.Forms.CheckBox();
            this.ckMushrooms = new System.Windows.Forms.CheckBox();
            this.ckExtriaChaees = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdthik = new System.Windows.Forms.RadioButton();
            this.rdThin = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdTakeout = new System.Windows.Forms.RadioButton();
            this.rdeatIn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lpSize = new System.Windows.Forms.Label();
            this.lpTopping = new System.Windows.Forms.Label();
            this.lpCoust = new System.Windows.Forms.Label();
            this.lporderStatus = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(903, 539);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(697, 446);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 48);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "MAKE YOUR PIZZA ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox1.Controls.Add(this.rdLarg);
            this.groupBox1.Controls.Add(this.rdMeduim);
            this.groupBox1.Controls.Add(this.rdSmall);
            this.groupBox1.Location = new System.Drawing.Point(42, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 130);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size ";
            // 
            // rdLarg
            // 
            this.rdLarg.AutoSize = true;
            this.rdLarg.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLarg.Location = new System.Drawing.Point(6, 85);
            this.rdLarg.Name = "rdLarg";
            this.rdLarg.Size = new System.Drawing.Size(50, 20);
            this.rdLarg.TabIndex = 2;
            this.rdLarg.TabStop = true;
            this.rdLarg.Tag = "60";
            this.rdLarg.Text = "Larg";
            this.rdLarg.UseVisualStyleBackColor = true;
            this.rdLarg.CheckedChanged += new System.EventHandler(this.rdLarg_CheckedChanged);
            // 
            // rdMeduim
            // 
            this.rdMeduim.AutoSize = true;
            this.rdMeduim.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMeduim.Location = new System.Drawing.Point(6, 53);
            this.rdMeduim.Name = "rdMeduim";
            this.rdMeduim.Size = new System.Drawing.Size(70, 20);
            this.rdMeduim.TabIndex = 1;
            this.rdMeduim.TabStop = true;
            this.rdMeduim.Tag = "40";
            this.rdMeduim.Text = "Meduim";
            this.rdMeduim.UseVisualStyleBackColor = true;
            this.rdMeduim.CheckedChanged += new System.EventHandler(this.rdMeduim_CheckedChanged);
            // 
            // rdSmall
            // 
            this.rdSmall.AutoSize = true;
            this.rdSmall.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSmall.Location = new System.Drawing.Point(6, 19);
            this.rdSmall.Name = "rdSmall";
            this.rdSmall.Size = new System.Drawing.Size(57, 20);
            this.rdSmall.TabIndex = 0;
            this.rdSmall.TabStop = true;
            this.rdSmall.Tag = "20";
            this.rdSmall.Text = "Small";
            this.rdSmall.UseVisualStyleBackColor = true;
            this.rdSmall.CheckedChanged += new System.EventHandler(this.rdSmall_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox2.Controls.Add(this.ckGreenPeppers);
            this.groupBox2.Controls.Add(this.ckOlives);
            this.groupBox2.Controls.Add(this.ckOnion);
            this.groupBox2.Controls.Add(this.ckTomatoes);
            this.groupBox2.Controls.Add(this.ckMushrooms);
            this.groupBox2.Controls.Add(this.ckExtriaChaees);
            this.groupBox2.Location = new System.Drawing.Point(248, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 130);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toppings";
            // 
            // ckGreenPeppers
            // 
            this.ckGreenPeppers.AutoSize = true;
            this.ckGreenPeppers.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckGreenPeppers.Location = new System.Drawing.Point(109, 97);
            this.ckGreenPeppers.Name = "ckGreenPeppers";
            this.ckGreenPeppers.Size = new System.Drawing.Size(110, 20);
            this.ckGreenPeppers.TabIndex = 5;
            this.ckGreenPeppers.Tag = "5";
            this.ckGreenPeppers.Text = "Green Peppers";
            this.ckGreenPeppers.UseVisualStyleBackColor = true;
            this.ckGreenPeppers.CheckedChanged += new System.EventHandler(this.ckGreenPeppers_CheckedChanged);
            // 
            // ckOlives
            // 
            this.ckOlives.AutoSize = true;
            this.ckOlives.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckOlives.Location = new System.Drawing.Point(109, 65);
            this.ckOlives.Name = "ckOlives";
            this.ckOlives.Size = new System.Drawing.Size(60, 20);
            this.ckOlives.TabIndex = 4;
            this.ckOlives.Tag = "5";
            this.ckOlives.Text = "Olives";
            this.ckOlives.UseVisualStyleBackColor = true;
            this.ckOlives.CheckedChanged += new System.EventHandler(this.ckOlives_CheckedChanged);
            // 
            // ckOnion
            // 
            this.ckOnion.AutoSize = true;
            this.ckOnion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckOnion.Location = new System.Drawing.Point(109, 31);
            this.ckOnion.Name = "ckOnion";
            this.ckOnion.Size = new System.Drawing.Size(59, 20);
            this.ckOnion.TabIndex = 3;
            this.ckOnion.Tag = "5";
            this.ckOnion.Text = "Onion";
            this.ckOnion.UseVisualStyleBackColor = true;
            this.ckOnion.CheckedChanged += new System.EventHandler(this.ckOnion_CheckedChanged);
            // 
            // ckTomatoes
            // 
            this.ckTomatoes.AutoSize = true;
            this.ckTomatoes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckTomatoes.Location = new System.Drawing.Point(6, 97);
            this.ckTomatoes.Name = "ckTomatoes";
            this.ckTomatoes.Size = new System.Drawing.Size(83, 20);
            this.ckTomatoes.TabIndex = 2;
            this.ckTomatoes.Tag = "5";
            this.ckTomatoes.Text = "Tomatoes";
            this.ckTomatoes.UseVisualStyleBackColor = true;
            this.ckTomatoes.CheckedChanged += new System.EventHandler(this.ckTomatoes_CheckedChanged);
            // 
            // ckMushrooms
            // 
            this.ckMushrooms.AutoSize = true;
            this.ckMushrooms.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckMushrooms.Location = new System.Drawing.Point(6, 65);
            this.ckMushrooms.Name = "ckMushrooms";
            this.ckMushrooms.Size = new System.Drawing.Size(97, 20);
            this.ckMushrooms.TabIndex = 1;
            this.ckMushrooms.Tag = "5";
            this.ckMushrooms.Text = "mushrooms ";
            this.ckMushrooms.UseVisualStyleBackColor = true;
            this.ckMushrooms.CheckedChanged += new System.EventHandler(this.ckMushrooms_CheckedChanged);
            // 
            // ckExtriaChaees
            // 
            this.ckExtriaChaees.AutoSize = true;
            this.ckExtriaChaees.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckExtriaChaees.Location = new System.Drawing.Point(6, 31);
            this.ckExtriaChaees.Name = "ckExtriaChaees";
            this.ckExtriaChaees.Size = new System.Drawing.Size(93, 20);
            this.ckExtriaChaees.TabIndex = 0;
            this.ckExtriaChaees.Tag = "5";
            this.ckExtriaChaees.Text = "Extra Chess";
            this.ckExtriaChaees.UseVisualStyleBackColor = true;
            this.ckExtriaChaees.CheckedChanged += new System.EventHandler(this.ckExtriaChaees_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox3.Controls.Add(this.rdthik);
            this.groupBox3.Controls.Add(this.rdThin);
            this.groupBox3.Location = new System.Drawing.Point(49, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(127, 115);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Coust Type";
            // 
            // rdthik
            // 
            this.rdthik.AutoSize = true;
            this.rdthik.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdthik.Location = new System.Drawing.Point(25, 67);
            this.rdthik.Name = "rdthik";
            this.rdthik.Size = new System.Drawing.Size(81, 20);
            this.rdthik.TabIndex = 1;
            this.rdthik.TabStop = true;
            this.rdthik.Tag = "10";
            this.rdthik.Text = "Thik crust";
            this.rdthik.UseVisualStyleBackColor = true;
            this.rdthik.CheckedChanged += new System.EventHandler(this.rdthik_CheckedChanged);
            // 
            // rdThin
            // 
            this.rdThin.AutoSize = true;
            this.rdThin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdThin.Location = new System.Drawing.Point(25, 29);
            this.rdThin.Name = "rdThin";
            this.rdThin.Size = new System.Drawing.Size(84, 20);
            this.rdThin.TabIndex = 0;
            this.rdThin.TabStop = true;
            this.rdThin.Tag = "0";
            this.rdThin.Text = "Thin Crust";
            this.rdThin.UseVisualStyleBackColor = true;
            this.rdThin.CheckedChanged += new System.EventHandler(this.rdThin_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox4.Controls.Add(this.rdTakeout);
            this.groupBox4.Controls.Add(this.rdeatIn);
            this.groupBox4.Location = new System.Drawing.Point(278, 294);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(154, 115);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Coust Type";
            // 
            // rdTakeout
            // 
            this.rdTakeout.AutoSize = true;
            this.rdTakeout.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTakeout.Location = new System.Drawing.Point(24, 67);
            this.rdTakeout.Name = "rdTakeout";
            this.rdTakeout.Size = new System.Drawing.Size(77, 20);
            this.rdTakeout.TabIndex = 1;
            this.rdTakeout.TabStop = true;
            this.rdTakeout.Text = "Take Out";
            this.rdTakeout.UseVisualStyleBackColor = true;
            this.rdTakeout.CheckedChanged += new System.EventHandler(this.rdTakeout_CheckedChanged);
            // 
            // rdeatIn
            // 
            this.rdeatIn.AutoSize = true;
            this.rdeatIn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdeatIn.Location = new System.Drawing.Point(24, 29);
            this.rdeatIn.Name = "rdeatIn";
            this.rdeatIn.Size = new System.Drawing.Size(62, 20);
            this.rdeatIn.TabIndex = 0;
            this.rdeatIn.TabStop = true;
            this.rdeatIn.Text = "Eat In ";
            this.rdeatIn.UseVisualStyleBackColor = true;
            this.rdeatIn.CheckedChanged += new System.EventHandler(this.rdeatIn_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(648, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Orde Summary";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOrderPizza.Location = new System.Drawing.Point(169, 471);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(104, 39);
            this.btnOrderPizza.TabIndex = 10;
            this.btnOrderPizza.Text = "order pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(606, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Size";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(606, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Toppings";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // lp
            // 
            this.lp.AutoSize = true;
            this.lp.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lp.Location = new System.Drawing.Point(606, 210);
            this.lp.Name = "lp";
            this.lp.Size = new System.Drawing.Size(67, 15);
            this.lp.TabIndex = 11;
            this.lp.Text = "Coust Type";
            this.lp.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(606, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Order status";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // lpSize
            // 
            this.lpSize.AutoSize = true;
            this.lpSize.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpSize.Location = new System.Drawing.Point(706, 125);
            this.lpSize.Name = "lpSize";
            this.lpSize.Size = new System.Drawing.Size(0, 15);
            this.lpSize.TabIndex = 12;
            // 
            // lpTopping
            // 
            this.lpTopping.AutoSize = true;
            this.lpTopping.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpTopping.Location = new System.Drawing.Point(706, 163);
            this.lpTopping.Name = "lpTopping";
            this.lpTopping.Size = new System.Drawing.Size(0, 15);
            this.lpTopping.TabIndex = 12;
            // 
            // lpCoust
            // 
            this.lpCoust.AutoSize = true;
            this.lpCoust.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpCoust.Location = new System.Drawing.Point(706, 210);
            this.lpCoust.Name = "lpCoust";
            this.lpCoust.Size = new System.Drawing.Size(0, 15);
            this.lpCoust.TabIndex = 12;
            // 
            // lporderStatus
            // 
            this.lporderStatus.AutoSize = true;
            this.lporderStatus.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lporderStatus.Location = new System.Drawing.Point(706, 256);
            this.lporderStatus.Name = "lporderStatus";
            this.lporderStatus.Size = new System.Drawing.Size(0, 15);
            this.lporderStatus.TabIndex = 12;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(683, 156);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(208, 51);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // placeOreder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 539);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lporderStatus);
            this.Controls.Add(this.lpCoust);
            this.Controls.Add(this.lpTopping);
            this.Controls.Add(this.lpSize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Name = "placeOreder";
            this.Text = "Place Order";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdLarg;
        private System.Windows.Forms.RadioButton rdMeduim;
        private System.Windows.Forms.RadioButton rdSmall;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ckGreenPeppers;
        private System.Windows.Forms.CheckBox ckOlives;
        private System.Windows.Forms.CheckBox ckOnion;
        private System.Windows.Forms.CheckBox ckTomatoes;
        private System.Windows.Forms.CheckBox ckMushrooms;
        private System.Windows.Forms.CheckBox ckExtriaChaees;
        private System.Windows.Forms.RadioButton rdthik;
        private System.Windows.Forms.RadioButton rdThin;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdTakeout;
        private System.Windows.Forms.RadioButton rdeatIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lpSize;
        private System.Windows.Forms.Label lpTopping;
        private System.Windows.Forms.Label lpCoust;
        private System.Windows.Forms.Label lporderStatus;
        private System.Windows.Forms.ListView listView1;
    }
}