﻿namespace SW_T7
{
    partial class Form1_sygnatura_pelna
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
            this.button_Browse_Files_PB1 = new System.Windows.Forms.Button();
            this.textBox_Image_Path_PB1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_From_File_PB1 = new System.Windows.Forms.Button();
            this.button_Czysc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_Draw_example_rays = new System.Windows.Forms.Button();
            this.numericUpDown_Ray_count = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Ray_slowdown = new System.Windows.Forms.NumericUpDown();
            this.checkBox_Enable_slowdown = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton_Draw_clockwise = new System.Windows.Forms.RadioButton();
            this.radioButton_Draw_counterclockwise = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_Start_angle = new System.Windows.Forms.NumericUpDown();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.numericUpDown_Moving_Average = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBo_Binary_dont_clr = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton_Max = new System.Windows.Forms.RadioButton();
            this.radioButton_Min = new System.Windows.Forms.RadioButton();
            this.numericUpDown_Filter_width = new System.Windows.Forms.NumericUpDown();
            this.button_Filter_binary = new System.Windows.Forms.Button();
            this.button_Filter_minmax = new System.Windows.Forms.Button();
            this.button_Filter_average = new System.Windows.Forms.Button();
            this.button_Czysc3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Czysc2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_Average_C2M_weight = new System.Windows.Forms.NumericUpDown();
            this.checkBox_Mix_averages = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton_Average_minmax = new System.Windows.Forms.RadioButton();
            this.radioButton_Average_moving = new System.Windows.Forms.RadioButton();
            this.radioButton_Average_constant = new System.Windows.Forms.RadioButton();
            this.button_Raycast_average = new System.Windows.Forms.Button();
            this.button_Redraw_raycast = new System.Windows.Forms.Button();
            this.button_Diff_raycast = new System.Windows.Forms.Button();
            this.button_Count_vertices = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_LW = new System.Windows.Forms.TextBox();
            this.cameraButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ray_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ray_slowdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Start_angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Moving_Average)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Filter_width)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Average_C2M_weight)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Browse_Files_PB1
            // 
            this.button_Browse_Files_PB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Browse_Files_PB1.Location = new System.Drawing.Point(619, 6);
            this.button_Browse_Files_PB1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Browse_Files_PB1.Name = "button_Browse_Files_PB1";
            this.button_Browse_Files_PB1.Size = new System.Drawing.Size(37, 25);
            this.button_Browse_Files_PB1.TabIndex = 57;
            this.button_Browse_Files_PB1.Text = "...";
            this.button_Browse_Files_PB1.UseVisualStyleBackColor = true;
            this.button_Browse_Files_PB1.Click += new System.EventHandler(this.button_Browse_Files_PB1_Click);
            // 
            // textBox_Image_Path_PB1
            // 
            this.textBox_Image_Path_PB1.Location = new System.Drawing.Point(75, 7);
            this.textBox_Image_Path_PB1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Image_Path_PB1.Name = "textBox_Image_Path_PB1";
            this.textBox_Image_Path_PB1.Size = new System.Drawing.Size(535, 22);
            this.textBox_Image_Path_PB1.TabIndex = 56;
            this.textBox_Image_Path_PB1.Text = "C:\\Users\\Piotr Łuczak\\Desktop\\figury_foremne3.bmp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Ścieżka:";
            // 
            // button_From_File_PB1
            // 
            this.button_From_File_PB1.Location = new System.Drawing.Point(664, 6);
            this.button_From_File_PB1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_From_File_PB1.Name = "button_From_File_PB1";
            this.button_From_File_PB1.Size = new System.Drawing.Size(64, 25);
            this.button_From_File_PB1.TabIndex = 58;
            this.button_From_File_PB1.Text = "Z pliku";
            this.button_From_File_PB1.UseVisualStyleBackColor = true;
            this.button_From_File_PB1.Click += new System.EventHandler(this.button_From_File_PB1_Click);
            // 
            // button_Czysc
            // 
            this.button_Czysc.Location = new System.Drawing.Point(7, 442);
            this.button_Czysc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Czysc.Name = "button_Czysc";
            this.button_Czysc.Size = new System.Drawing.Size(81, 31);
            this.button_Czysc.TabIndex = 82;
            this.button_Czysc.Text = "Czyść ↑";
            this.button_Czysc.UseVisualStyleBackColor = true;
            this.button_Czysc.Click += new System.EventHandler(this.button_Czysc_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(7, 139);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 295);
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(441, 139);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(427, 295);
            this.pictureBox2.TabIndex = 84;
            this.pictureBox2.TabStop = false;
            // 
            // button_Draw_example_rays
            // 
            this.button_Draw_example_rays.Location = new System.Drawing.Point(8, 23);
            this.button_Draw_example_rays.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Draw_example_rays.Name = "button_Draw_example_rays";
            this.button_Draw_example_rays.Size = new System.Drawing.Size(224, 55);
            this.button_Draw_example_rays.TabIndex = 85;
            this.button_Draw_example_rays.Text = "Generuj przykładowe promienie";
            this.button_Draw_example_rays.UseVisualStyleBackColor = true;
            this.button_Draw_example_rays.Click += new System.EventHandler(this.button_Draw_example_rays_Click);
            // 
            // numericUpDown_Ray_count
            // 
            this.numericUpDown_Ray_count.Location = new System.Drawing.Point(327, 27);
            this.numericUpDown_Ray_count.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown_Ray_count.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown_Ray_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Ray_count.Name = "numericUpDown_Ray_count";
            this.numericUpDown_Ray_count.Size = new System.Drawing.Size(63, 22);
            this.numericUpDown_Ray_count.TabIndex = 86;
            this.numericUpDown_Ray_count.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.numericUpDown_Ray_count.ValueChanged += new System.EventHandler(this.numericUpDown_Ray_count_ValueChanged);
            // 
            // numericUpDown_Ray_slowdown
            // 
            this.numericUpDown_Ray_slowdown.Location = new System.Drawing.Point(372, 54);
            this.numericUpDown_Ray_slowdown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown_Ray_slowdown.Name = "numericUpDown_Ray_slowdown";
            this.numericUpDown_Ray_slowdown.Size = new System.Drawing.Size(63, 22);
            this.numericUpDown_Ray_slowdown.TabIndex = 87;
            this.numericUpDown_Ray_slowdown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Ray_slowdown.ValueChanged += new System.EventHandler(this.numericUpDown_Ray_slowdown_ValueChanged);
            // 
            // checkBox_Enable_slowdown
            // 
            this.checkBox_Enable_slowdown.AutoSize = true;
            this.checkBox_Enable_slowdown.Location = new System.Drawing.Point(253, 55);
            this.checkBox_Enable_slowdown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_Enable_slowdown.Name = "checkBox_Enable_slowdown";
            this.checkBox_Enable_slowdown.Size = new System.Drawing.Size(113, 21);
            this.checkBox_Enable_slowdown.TabIndex = 88;
            this.checkBox_Enable_slowdown.Text = "Spowolnienie";
            this.checkBox_Enable_slowdown.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 89;
            this.label2.Text = "Liczba promieni";
            // 
            // radioButton_Draw_clockwise
            // 
            this.radioButton_Draw_clockwise.AutoSize = true;
            this.radioButton_Draw_clockwise.Checked = true;
            this.radioButton_Draw_clockwise.Location = new System.Drawing.Point(8, 27);
            this.radioButton_Draw_clockwise.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_Draw_clockwise.Name = "radioButton_Draw_clockwise";
            this.radioButton_Draw_clockwise.Size = new System.Drawing.Size(151, 21);
            this.radioButton_Draw_clockwise.TabIndex = 90;
            this.radioButton_Draw_clockwise.TabStop = true;
            this.radioButton_Draw_clockwise.Text = "Zgodnie z zegarem";
            this.radioButton_Draw_clockwise.UseVisualStyleBackColor = true;
            // 
            // radioButton_Draw_counterclockwise
            // 
            this.radioButton_Draw_counterclockwise.AutoSize = true;
            this.radioButton_Draw_counterclockwise.Location = new System.Drawing.Point(8, 54);
            this.radioButton_Draw_counterclockwise.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_Draw_counterclockwise.Name = "radioButton_Draw_counterclockwise";
            this.radioButton_Draw_counterclockwise.Size = new System.Drawing.Size(161, 21);
            this.radioButton_Draw_counterclockwise.TabIndex = 91;
            this.radioButton_Draw_counterclockwise.Text = "Odwrotnie do zegara";
            this.radioButton_Draw_counterclockwise.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 93;
            this.label3.Text = "Kąt początkowy";
            // 
            // numericUpDown_Start_angle
            // 
            this.numericUpDown_Start_angle.Location = new System.Drawing.Point(327, 55);
            this.numericUpDown_Start_angle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown_Start_angle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown_Start_angle.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numericUpDown_Start_angle.Name = "numericUpDown_Start_angle";
            this.numericUpDown_Start_angle.Size = new System.Drawing.Size(63, 22);
            this.numericUpDown_Start_angle.TabIndex = 92;
            this.numericUpDown_Start_angle.ValueChanged += new System.EventHandler(this.numericUpDown_Start_angle_ValueChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(7, 480);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(861, 209);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 95;
            this.pictureBox3.TabStop = false;
            // 
            // numericUpDown_Moving_Average
            // 
            this.numericUpDown_Moving_Average.Location = new System.Drawing.Point(251, 49);
            this.numericUpDown_Moving_Average.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown_Moving_Average.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown_Moving_Average.Name = "numericUpDown_Moving_Average";
            this.numericUpDown_Moving_Average.Size = new System.Drawing.Size(89, 22);
            this.numericUpDown_Moving_Average.TabIndex = 96;
            this.numericUpDown_Moving_Average.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBo_Binary_dont_clr);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.numericUpDown_Filter_width);
            this.groupBox1.Controls.Add(this.button_Filter_binary);
            this.groupBox1.Controls.Add(this.button_Filter_minmax);
            this.groupBox1.Controls.Add(this.button_Filter_average);
            this.groupBox1.Location = new System.Drawing.Point(7, 818);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(387, 198);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrowanie danych";
            // 
            // checkBo_Binary_dont_clr
            // 
            this.checkBo_Binary_dont_clr.AutoSize = true;
            this.checkBo_Binary_dont_clr.Location = new System.Drawing.Point(120, 171);
            this.checkBo_Binary_dont_clr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBo_Binary_dont_clr.Name = "checkBo_Binary_dont_clr";
            this.checkBo_Binary_dont_clr.Size = new System.Drawing.Size(138, 21);
            this.checkBo_Binary_dont_clr.TabIndex = 106;
            this.checkBo_Binary_dont_clr.Text = "Nie czyść obrazu";
            this.checkBo_Binary_dont_clr.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(117, 139);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(240, 50);
            this.label9.TabIndex = 104;
            this.label9.Text = "Sprawdza, czy wartość sygnatury jest większa czy mniejsza od 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 17);
            this.label4.TabIndex = 103;
            this.label4.Text = "Szerokość filtru uśredniającego i minmax:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.radioButton_Max);
            this.panel1.Controls.Add(this.radioButton_Min);
            this.panel1.Location = new System.Drawing.Point(113, 81);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 50);
            this.panel1.TabIndex = 101;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 2);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 17);
            this.label5.TabIndex = 101;
            this.label5.Text = "Aktywna część dla filtru minmax";
            // 
            // radioButton_Max
            // 
            this.radioButton_Max.AutoSize = true;
            this.radioButton_Max.Checked = true;
            this.radioButton_Max.Location = new System.Drawing.Point(5, 22);
            this.radioButton_Max.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_Max.Name = "radioButton_Max";
            this.radioButton_Max.Size = new System.Drawing.Size(54, 21);
            this.radioButton_Max.TabIndex = 99;
            this.radioButton_Max.TabStop = true;
            this.radioButton_Max.Text = "Max";
            this.radioButton_Max.UseVisualStyleBackColor = true;
            // 
            // radioButton_Min
            // 
            this.radioButton_Min.AutoSize = true;
            this.radioButton_Min.Location = new System.Drawing.Point(91, 22);
            this.radioButton_Min.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_Min.Name = "radioButton_Min";
            this.radioButton_Min.Size = new System.Drawing.Size(51, 21);
            this.radioButton_Min.TabIndex = 100;
            this.radioButton_Min.Text = "Min";
            this.radioButton_Min.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_Filter_width
            // 
            this.numericUpDown_Filter_width.Location = new System.Drawing.Point(121, 49);
            this.numericUpDown_Filter_width.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown_Filter_width.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown_Filter_width.Name = "numericUpDown_Filter_width";
            this.numericUpDown_Filter_width.Size = new System.Drawing.Size(85, 22);
            this.numericUpDown_Filter_width.TabIndex = 98;
            this.numericUpDown_Filter_width.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // button_Filter_binary
            // 
            this.button_Filter_binary.Location = new System.Drawing.Point(8, 139);
            this.button_Filter_binary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Filter_binary.Name = "button_Filter_binary";
            this.button_Filter_binary.Size = new System.Drawing.Size(101, 50);
            this.button_Filter_binary.TabIndex = 61;
            this.button_Filter_binary.Text = "Filtr binarny";
            this.button_Filter_binary.UseVisualStyleBackColor = true;
            this.button_Filter_binary.Click += new System.EventHandler(this.button_Filter_binary_Click);
            // 
            // button_Filter_minmax
            // 
            this.button_Filter_minmax.Location = new System.Drawing.Point(8, 81);
            this.button_Filter_minmax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Filter_minmax.Name = "button_Filter_minmax";
            this.button_Filter_minmax.Size = new System.Drawing.Size(101, 50);
            this.button_Filter_minmax.TabIndex = 60;
            this.button_Filter_minmax.Text = "Filtr min-max";
            this.button_Filter_minmax.UseVisualStyleBackColor = true;
            this.button_Filter_minmax.Click += new System.EventHandler(this.button_Filter_minmax_Click);
            // 
            // button_Filter_average
            // 
            this.button_Filter_average.Location = new System.Drawing.Point(8, 23);
            this.button_Filter_average.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Filter_average.Name = "button_Filter_average";
            this.button_Filter_average.Size = new System.Drawing.Size(101, 50);
            this.button_Filter_average.TabIndex = 59;
            this.button_Filter_average.Text = "Filtr uśredniający";
            this.button_Filter_average.UseVisualStyleBackColor = true;
            this.button_Filter_average.Click += new System.EventHandler(this.button_Filter_average_Click);
            // 
            // button_Czysc3
            // 
            this.button_Czysc3.Location = new System.Drawing.Point(787, 442);
            this.button_Czysc3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Czysc3.Name = "button_Czysc3";
            this.button_Czysc3.Size = new System.Drawing.Size(81, 31);
            this.button_Czysc3.TabIndex = 98;
            this.button_Czysc3.Text = "Czyść ↓";
            this.button_Czysc3.UseVisualStyleBackColor = true;
            this.button_Czysc3.Click += new System.EventHandler(this.button_Czysc3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(89, 439);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(324, 29);
            this.label7.TabIndex = 99;
            this.label7.Text = "Wykres sygnatury radialnej";
            // 
            // button_Czysc2
            // 
            this.button_Czysc2.Location = new System.Drawing.Point(441, 442);
            this.button_Czysc2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Czysc2.Name = "button_Czysc2";
            this.button_Czysc2.Size = new System.Drawing.Size(81, 31);
            this.button_Czysc2.TabIndex = 100;
            this.button_Czysc2.Text = "Czyść ↑";
            this.button_Czysc2.UseVisualStyleBackColor = true;
            this.button_Czysc2.Click += new System.EventHandler(this.button_Czysc2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown_Average_C2M_weight);
            this.groupBox2.Controls.Add(this.checkBox_Mix_averages);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.radioButton_Average_minmax);
            this.groupBox2.Controls.Add(this.radioButton_Average_moving);
            this.groupBox2.Controls.Add(this.radioButton_Average_constant);
            this.groupBox2.Controls.Add(this.numericUpDown_Moving_Average);
            this.groupBox2.Location = new System.Drawing.Point(7, 697);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(387, 114);
            this.groupBox2.TabIndex = 101;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opcje wyliczania średnie z sygnatury";
            // 
            // numericUpDown_Average_C2M_weight
            // 
            this.numericUpDown_Average_C2M_weight.DecimalPlaces = 2;
            this.numericUpDown_Average_C2M_weight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_Average_C2M_weight.Location = new System.Drawing.Point(251, 79);
            this.numericUpDown_Average_C2M_weight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown_Average_C2M_weight.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Average_C2M_weight.Name = "numericUpDown_Average_C2M_weight";
            this.numericUpDown_Average_C2M_weight.Size = new System.Drawing.Size(89, 22);
            this.numericUpDown_Average_C2M_weight.TabIndex = 106;
            this.numericUpDown_Average_C2M_weight.Value = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            // 
            // checkBox_Mix_averages
            // 
            this.checkBox_Mix_averages.AutoSize = true;
            this.checkBox_Mix_averages.Location = new System.Drawing.Point(8, 80);
            this.checkBox_Mix_averages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_Mix_averages.Name = "checkBox_Mix_averages";
            this.checkBox_Mix_averages.Size = new System.Drawing.Size(228, 21);
            this.checkBox_Mix_averages.TabIndex = 105;
            this.checkBox_Mix_averages.Text = "Mieszaj średnią stałą i ruchomą";
            this.checkBox_Mix_averages.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(171, 54);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 104;
            this.label8.Text = "Szerokość:";
            // 
            // radioButton_Average_minmax
            // 
            this.radioButton_Average_minmax.AutoSize = true;
            this.radioButton_Average_minmax.Location = new System.Drawing.Point(168, 23);
            this.radioButton_Average_minmax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_Average_minmax.Name = "radioButton_Average_minmax";
            this.radioButton_Average_minmax.Size = new System.Drawing.Size(167, 21);
            this.radioButton_Average_minmax.TabIndex = 102;
            this.radioButton_Average_minmax.Text = "Średnia stała min max";
            this.radioButton_Average_minmax.UseVisualStyleBackColor = true;
            // 
            // radioButton_Average_moving
            // 
            this.radioButton_Average_moving.AutoSize = true;
            this.radioButton_Average_moving.Location = new System.Drawing.Point(8, 52);
            this.radioButton_Average_moving.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_Average_moving.Name = "radioButton_Average_moving";
            this.radioButton_Average_moving.Size = new System.Drawing.Size(137, 21);
            this.radioButton_Average_moving.TabIndex = 101;
            this.radioButton_Average_moving.Text = "Średnia ruchoma";
            this.radioButton_Average_moving.UseVisualStyleBackColor = true;
            // 
            // radioButton_Average_constant
            // 
            this.radioButton_Average_constant.AutoSize = true;
            this.radioButton_Average_constant.Checked = true;
            this.radioButton_Average_constant.Location = new System.Drawing.Point(8, 23);
            this.radioButton_Average_constant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_Average_constant.Name = "radioButton_Average_constant";
            this.radioButton_Average_constant.Size = new System.Drawing.Size(112, 21);
            this.radioButton_Average_constant.TabIndex = 100;
            this.radioButton_Average_constant.TabStop = true;
            this.radioButton_Average_constant.Text = "Średnia stała";
            this.radioButton_Average_constant.UseVisualStyleBackColor = true;
            // 
            // button_Raycast_average
            // 
            this.button_Raycast_average.Location = new System.Drawing.Point(401, 754);
            this.button_Raycast_average.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Raycast_average.Name = "button_Raycast_average";
            this.button_Raycast_average.Size = new System.Drawing.Size(104, 50);
            this.button_Raycast_average.TabIndex = 102;
            this.button_Raycast_average.Text = "Uśrednij";
            this.button_Raycast_average.UseVisualStyleBackColor = true;
            this.button_Raycast_average.Click += new System.EventHandler(this.button_Raycast_average_Click);
            // 
            // button_Redraw_raycast
            // 
            this.button_Redraw_raycast.Location = new System.Drawing.Point(401, 697);
            this.button_Redraw_raycast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Redraw_raycast.Name = "button_Redraw_raycast";
            this.button_Redraw_raycast.Size = new System.Drawing.Size(104, 50);
            this.button_Redraw_raycast.TabIndex = 103;
            this.button_Redraw_raycast.Text = "Przemaluj sygnature";
            this.button_Redraw_raycast.UseVisualStyleBackColor = true;
            this.button_Redraw_raycast.Click += new System.EventHandler(this.button_Redraw_raycast_Click);
            // 
            // button_Diff_raycast
            // 
            this.button_Diff_raycast.Location = new System.Drawing.Point(401, 812);
            this.button_Diff_raycast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Diff_raycast.Name = "button_Diff_raycast";
            this.button_Diff_raycast.Size = new System.Drawing.Size(104, 50);
            this.button_Diff_raycast.TabIndex = 104;
            this.button_Diff_raycast.Text = "Sygnatura różnicowa";
            this.button_Diff_raycast.UseVisualStyleBackColor = true;
            this.button_Diff_raycast.Click += new System.EventHandler(this.button_Diff_raycast_Click);
            // 
            // button_Count_vertices
            // 
            this.button_Count_vertices.Location = new System.Drawing.Point(401, 870);
            this.button_Count_vertices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Count_vertices.Name = "button_Count_vertices";
            this.button_Count_vertices.Size = new System.Drawing.Size(104, 50);
            this.button_Count_vertices.TabIndex = 105;
            this.button_Count_vertices.Text = "Licz wierzchołki";
            this.button_Count_vertices.UseVisualStyleBackColor = true;
            this.button_Count_vertices.Click += new System.EventHandler(this.button_Count_vertices_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_Draw_example_rays);
            this.groupBox3.Controls.Add(this.numericUpDown_Ray_slowdown);
            this.groupBox3.Controls.Add(this.checkBox_Enable_slowdown);
            this.groupBox3.Location = new System.Drawing.Point(7, 39);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(456, 92);
            this.groupBox3.TabIndex = 106;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Przykładowe promienie sygnatury";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton_Draw_clockwise);
            this.groupBox4.Controls.Add(this.radioButton_Draw_counterclockwise);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.numericUpDown_Ray_count);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.numericUpDown_Start_angle);
            this.groupBox4.Location = new System.Drawing.Point(471, 39);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(397, 92);
            this.groupBox4.TabIndex = 107;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wybór ilości i sposobu rysowania sygnatury";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Location = new System.Drawing.Point(513, 697);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(353, 319);
            this.listView1.TabIndex = 108;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dane";
            this.columnHeader1.Width = 260;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 953);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 104;
            this.label6.Text = "Wierzchołki:";
            // 
            // textBox_LW
            // 
            this.textBox_LW.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_LW.Location = new System.Drawing.Point(401, 974);
            this.textBox_LW.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_LW.Name = "textBox_LW";
            this.textBox_LW.Size = new System.Drawing.Size(103, 41);
            this.textBox_LW.TabIndex = 109;
            // 
            // cameraButton
            // 
            this.cameraButton.Location = new System.Drawing.Point(736, 7);
            this.cameraButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cameraButton.Name = "cameraButton";
            this.cameraButton.Size = new System.Drawing.Size(72, 25);
            this.cameraButton.TabIndex = 110;
            this.cameraButton.Text = "Kamera";
            this.cameraButton.UseVisualStyleBackColor = true;
            this.cameraButton.Click += new System.EventHandler(this.cameraButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1_sygnatura_pelna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 1019);
            this.Controls.Add(this.cameraButton);
            this.Controls.Add(this.textBox_LW);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_Count_vertices);
            this.Controls.Add(this.button_Diff_raycast);
            this.Controls.Add(this.button_Redraw_raycast);
            this.Controls.Add(this.button_Raycast_average);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_Czysc2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_Czysc3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Czysc);
            this.Controls.Add(this.button_From_File_PB1);
            this.Controls.Add(this.button_Browse_Files_PB1);
            this.Controls.Add(this.textBox_Image_Path_PB1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1_sygnatura_pelna";
            this.Text = "SW T7 - sygnatura radialna";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ray_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ray_slowdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Start_angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Moving_Average)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Filter_width)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Average_C2M_weight)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Browse_Files_PB1;
        private System.Windows.Forms.TextBox textBox_Image_Path_PB1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_From_File_PB1;
        private System.Windows.Forms.Button button_Czysc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_Draw_example_rays;
        private System.Windows.Forms.NumericUpDown numericUpDown_Ray_count;
        private System.Windows.Forms.NumericUpDown numericUpDown_Ray_slowdown;
        private System.Windows.Forms.CheckBox checkBox_Enable_slowdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton_Draw_clockwise;
        private System.Windows.Forms.RadioButton radioButton_Draw_counterclockwise;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_Start_angle;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown_Moving_Average;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Min;
        private System.Windows.Forms.RadioButton radioButton_Max;
        private System.Windows.Forms.NumericUpDown numericUpDown_Filter_width;
        private System.Windows.Forms.Button button_Filter_binary;
        private System.Windows.Forms.Button button_Filter_minmax;
        private System.Windows.Forms.Button button_Filter_average;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Czysc3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Czysc2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton_Average_minmax;
        private System.Windows.Forms.RadioButton radioButton_Average_moving;
        private System.Windows.Forms.RadioButton radioButton_Average_constant;
        private System.Windows.Forms.Button button_Raycast_average;
        private System.Windows.Forms.Button button_Redraw_raycast;
        private System.Windows.Forms.Button button_Diff_raycast;
        private System.Windows.Forms.Button button_Count_vertices;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_LW;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Average_C2M_weight;
        private System.Windows.Forms.CheckBox checkBox_Mix_averages;
        private System.Windows.Forms.CheckBox checkBo_Binary_dont_clr;
        private System.Windows.Forms.Button cameraButton;
        private System.Windows.Forms.Timer timer1;
    }
}
