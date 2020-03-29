namespace Fence_Calculator
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
            this.fLen = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tPost = new System.Windows.Forms.TextBox();
            this.tSect = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pDist = new System.Windows.Forms.NumericUpDown();
            this.sRails = new System.Windows.Forms.NumericUpDown();
            this.nRails = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.n3Gate = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.n8Gate = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.fPost = new System.Windows.Forms.TextBox();
            this.fSect = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fPick = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.fRail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.fHinge = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.fLatch = new System.Windows.Forms.TextBox();
            this.aCustom = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.fCane = new System.Windows.Forms.TextBox();
            this.aExact = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.aTen = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.aButton = new System.Windows.Forms.Button();
            this.pWidth = new System.Windows.Forms.NumericUpDown();
            this.nPicket = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pSpace = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.sInch = new System.Windows.Forms.Label();
            this.wInch = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fLen)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pDist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRails)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n3Gate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n8Gate)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aCustom)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSpace)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // fLen
            // 
            this.fLen.Location = new System.Drawing.Point(9, 58);
            this.fLen.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.fLen.Name = "fLen";
            this.fLen.Size = new System.Drawing.Size(117, 20);
            this.fLen.TabIndex = 1;
            this.fLen.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            this.fLen.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fence Length";
            // 
            // tPost
            // 
            this.tPost.Location = new System.Drawing.Point(9, 145);
            this.tPost.Name = "tPost";
            this.tPost.Size = new System.Drawing.Size(117, 20);
            this.tPost.TabIndex = 22;
            this.tPost.TabStop = false;
            this.tPost.TextChanged += new System.EventHandler(this.tPost_TextChanged);
            // 
            // tSect
            // 
            this.tSect.Location = new System.Drawing.Point(9, 184);
            this.tSect.Name = "tSect";
            this.tSect.Size = new System.Drawing.Size(117, 20);
            this.tSect.TabIndex = 22;
            this.tSect.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Number of Posts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Number of Sections";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.pDist);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tSect);
            this.groupBox1.Controls.Add(this.tPost);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fLen);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 237);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Number of Posts Needed";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 22);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 13);
            this.label22.TabIndex = 18;
            this.label22.Text = "Entered in Feet";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 81);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "Post Distance";
            // 
            // pDist
            // 
            this.pDist.Location = new System.Drawing.Point(9, 97);
            this.pDist.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.pDist.Name = "pDist";
            this.pDist.Size = new System.Drawing.Size(117, 20);
            this.pDist.TabIndex = 2;
            this.pDist.ValueChanged += new System.EventHandler(this.pDist_ValueChanged);
            this.pDist.Text = "";
            // 
            // sRails
            // 
            this.sRails.Location = new System.Drawing.Point(9, 35);
            this.sRails.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.sRails.Name = "sRails";
            this.sRails.Size = new System.Drawing.Size(117, 20);
            this.sRails.TabIndex = 5;
            this.sRails.ValueChanged += new System.EventHandler(this.sRails_ValueChanged);
            this.sRails.Text = "";
            // 
            // nRails
            // 
            this.nRails.Location = new System.Drawing.Point(9, 81);
            this.nRails.Name = "nRails";
            this.nRails.Size = new System.Drawing.Size(117, 20);
            this.nRails.TabIndex = 22;
            this.nRails.TabStop = false;
            this.nRails.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Rails Per Section";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Number of Rails";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.nRails);
            this.groupBox2.Controls.Add(this.sRails);
            this.groupBox2.Location = new System.Drawing.Point(357, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 120);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Number of Rails Needed";
            // 
            // n3Gate
            // 
            this.n3Gate.Location = new System.Drawing.Point(9, 32);
            this.n3Gate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.n3Gate.Name = "n3Gate";
            this.n3Gate.Size = new System.Drawing.Size(117, 20);
            this.n3Gate.TabIndex = 6;
            this.n3Gate.ValueChanged += new System.EventHandler(this.n3Gate_ValueChanged);
            this.n3Gate.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Number of 3 Ft Gates";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // n8Gate
            // 
            this.n8Gate.Location = new System.Drawing.Point(9, 71);
            this.n8Gate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.n8Gate.Name = "n8Gate";
            this.n8Gate.Size = new System.Drawing.Size(117, 20);
            this.n8Gate.TabIndex = 7;
            this.n8Gate.ValueChanged += new System.EventHandler(this.n8Gate_ValueChanged);
            this.n8Gate.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Number of 8 Ft Gates";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.n8Gate);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.n3Gate);
            this.groupBox4.Location = new System.Drawing.Point(357, 138);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(150, 111);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Number of Gates";
            // 
            // fPost
            // 
            this.fPost.Location = new System.Drawing.Point(9, 66);
            this.fPost.Name = "fPost";
            this.fPost.Size = new System.Drawing.Size(117, 20);
            this.fPost.TabIndex = 22;
            this.fPost.TabStop = false;
            // 
            // fSect
            // 
            this.fSect.Location = new System.Drawing.Point(272, 66);
            this.fSect.Name = "fSect";
            this.fSect.Size = new System.Drawing.Size(117, 20);
            this.fSect.TabIndex = 22;
            this.fSect.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Number of Posts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Number of Sections";
            // 
            // fPick
            // 
            this.fPick.Location = new System.Drawing.Point(9, 144);
            this.fPick.Name = "fPick";
            this.fPick.Size = new System.Drawing.Size(117, 20);
            this.fPick.TabIndex = 22;
            this.fPick.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Number of Pickets";
            // 
            // fRail
            // 
            this.fRail.Location = new System.Drawing.Point(9, 105);
            this.fRail.Name = "fRail";
            this.fRail.Size = new System.Drawing.Size(117, 20);
            this.fRail.TabIndex = 22;
            this.fRail.TabStop = false;
            this.fRail.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Number of Rails";
            // 
            // fHinge
            // 
            this.fHinge.Location = new System.Drawing.Point(141, 66);
            this.fHinge.Name = "fHinge";
            this.fHinge.Size = new System.Drawing.Size(117, 20);
            this.fHinge.TabIndex = 22;
            this.fHinge.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(138, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Number of Hinges";
            // 
            // fLatch
            // 
            this.fLatch.Location = new System.Drawing.Point(141, 105);
            this.fLatch.Name = "fLatch";
            this.fLatch.Size = new System.Drawing.Size(117, 20);
            this.fLatch.TabIndex = 22;
            this.fLatch.TabStop = false;
            // 
            // aCustom
            // 
            this.aCustom.Location = new System.Drawing.Point(354, 16);
            this.aCustom.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.aCustom.Name = "aCustom";
            this.aCustom.Size = new System.Drawing.Size(117, 20);
            this.aCustom.TabIndex = 10;
            this.aCustom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.aCustom.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.aCustom.Text = "";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(138, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "Number of Latches";
            // 
            // fCane
            // 
            this.fCane.Location = new System.Drawing.Point(141, 144);
            this.fCane.Name = "fCane";
            this.fCane.Size = new System.Drawing.Size(117, 20);
            this.fCane.TabIndex = 22;
            this.fCane.TabStop = false;
            this.fCane.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // aExact
            // 
            this.aExact.AutoSize = true;
            this.aExact.Location = new System.Drawing.Point(9, 19);
            this.aExact.Name = "aExact";
            this.aExact.Size = new System.Drawing.Size(83, 17);
            this.aExact.TabIndex = 8;
            this.aExact.Text = "Exact Count";
            this.aExact.UseVisualStyleBackColor = true;
            this.aExact.CheckedChanged += new System.EventHandler(this.aExact_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Custom % Extra";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(138, 128);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 13);
            this.label18.TabIndex = 22;
            this.label18.Text = "Number of Cane Bolts";
            // 
            // aTen
            // 
            this.aTen.AutoSize = true;
            this.aTen.Location = new System.Drawing.Point(141, 17);
            this.aTen.Name = "aTen";
            this.aTen.Size = new System.Drawing.Size(117, 17);
            this.aTen.TabIndex = 9;
            this.aTen.Text = "10% Extra Materials";
            this.aTen.UseVisualStyleBackColor = true;
            this.aTen.CheckedChanged += new System.EventHandler(this.aTen_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.aButton);
            this.groupBox5.Controls.Add(this.aTen);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.aExact);
            this.groupBox5.Controls.Add(this.fCane);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.aCustom);
            this.groupBox5.Controls.Add(this.fLatch);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.fHinge);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.fRail);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.fPick);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.fSect);
            this.groupBox5.Controls.Add(this.fPost);
            this.groupBox5.Location = new System.Drawing.Point(12, 255);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(495, 175);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Total Materials Needed";
            // 
            // aButton
            // 
            this.aButton.Location = new System.Drawing.Point(272, 141);
            this.aButton.Name = "aButton";
            this.aButton.Size = new System.Drawing.Size(117, 23);
            this.aButton.TabIndex = 11;
            this.aButton.Text = "Calculate";
            this.aButton.UseVisualStyleBackColor = true;
            this.aButton.Click += new System.EventHandler(this.aButton_Click);
            // 
            // pWidth
            // 
            this.pWidth.Location = new System.Drawing.Point(9, 58);
            this.pWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.pWidth.Name = "pWidth";
            this.pWidth.Size = new System.Drawing.Size(117, 20);
            this.pWidth.TabIndex = 3;
            this.pWidth.ValueChanged += new System.EventHandler(this.pWidth_ValueChanged);
            this.pWidth.Text = "";
            // 
            // nPicket
            // 
            this.nPicket.Location = new System.Drawing.Point(9, 145);
            this.nPicket.Name = "nPicket";
            this.nPicket.Size = new System.Drawing.Size(117, 20);
            this.nPicket.TabIndex = 22;
            this.nPicket.TabStop = false;
            this.nPicket.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Picket Width";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Number of Pickets";
            // 
            // pSpace
            // 
            this.pSpace.Location = new System.Drawing.Point(9, 97);
            this.pSpace.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.pSpace.Name = "pSpace";
            this.pSpace.Size = new System.Drawing.Size(117, 20);
            this.pSpace.TabIndex = 4;
            this.pSpace.ValueChanged += new System.EventHandler(this.pSpace_ValueChanged);
            this.pSpace.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Picket Spacing";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.sInch);
            this.groupBox3.Controls.Add(this.wInch);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.pSpace);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.nPicket);
            this.groupBox3.Controls.Add(this.pWidth);
            this.groupBox3.Location = new System.Drawing.Point(166, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 237);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Number of Pickets Needed";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 22);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(122, 13);
            this.label21.TabIndex = 17;
            this.label21.Text = "Entered in 1/8 th Inches";
            // 
            // sInch
            // 
            this.sInch.AutoSize = true;
            this.sInch.Location = new System.Drawing.Point(132, 104);
            this.sInch.Name = "sInch";
            this.sInch.Size = new System.Drawing.Size(0, 13);
            this.sInch.TabIndex = 16;
            // 
            // wInch
            // 
            this.wInch.AutoSize = true;
            this.wInch.Location = new System.Drawing.Point(133, 64);
            this.wInch.Name = "wInch";
            this.wInch.Size = new System.Drawing.Size(0, 13);
            this.wInch.TabIndex = 15;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label20.Location = new System.Drawing.Point(12, 437);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 13);
            this.label20.TabIndex = 15;
            this.label20.Text = " © Ian Kelly, 2020";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 459);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Fence Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.fLen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pDist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRails)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n3Gate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n8Gate)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aCustom)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSpace)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown fLen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tPost;
        private System.Windows.Forms.TextBox tSect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown pDist;
        private System.Windows.Forms.NumericUpDown sRails;
        private System.Windows.Forms.TextBox nRails;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown n3Gate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown n8Gate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox fPost;
        private System.Windows.Forms.TextBox fSect;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fPick;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox fRail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox fHinge;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox fLatch;
        private System.Windows.Forms.NumericUpDown aCustom;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox fCane;
        private System.Windows.Forms.RadioButton aExact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RadioButton aTen;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown pWidth;
        private System.Windows.Forms.TextBox nPicket;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown pSpace;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button aButton;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label sInch;
        private System.Windows.Forms.Label wInch;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
    }
}

