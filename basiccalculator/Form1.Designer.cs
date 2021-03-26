
namespace basiccalculator
{
    partial class Calculator
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Standard");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Scientific");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Graphing");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonEq = new System.Windows.Forms.Button();
            this.buttonDec = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonTimes = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.rtbDisplayHistory = new System.Windows.Forms.RichTextBox();
            this.buttonTrash = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.HistoryLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.lblHistoryDisplay = new System.Windows.Forms.Label();
            this.lblShowOps = new System.Windows.Forms.Label();
            this.textDisplay = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(3, 366);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 69);
            this.button7.TabIndex = 0;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.numbers_only);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(3, 437);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 69);
            this.button4.TabIndex = 0;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.numbers_only);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.numbers_only);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button0.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.button0.FlatAppearance.BorderSize = 0;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(95, 579);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(90, 69);
            this.button0.TabIndex = 0;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.numbers_only);
            // 
            // buttonEq
            // 
            this.buttonEq.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonEq.FlatAppearance.BorderSize = 0;
            this.buttonEq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEq.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEq.Location = new System.Drawing.Point(187, 579);
            this.buttonEq.Name = "buttonEq";
            this.buttonEq.Size = new System.Drawing.Size(182, 69);
            this.buttonEq.TabIndex = 0;
            this.buttonEq.Text = "=";
            this.buttonEq.UseVisualStyleBackColor = false;
            this.buttonEq.Click += new System.EventHandler(this.buttonEq_Click);
            // 
            // buttonDec
            // 
            this.buttonDec.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDec.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonDec.FlatAppearance.BorderSize = 0;
            this.buttonDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDec.Location = new System.Drawing.Point(3, 579);
            this.buttonDec.Name = "buttonDec";
            this.buttonDec.Size = new System.Drawing.Size(90, 69);
            this.buttonDec.TabIndex = 0;
            this.buttonDec.Text = ".";
            this.buttonDec.UseVisualStyleBackColor = false;
            this.buttonDec.Click += new System.EventHandler(this.numbers_only);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(187, 508);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 69);
            this.button3.TabIndex = 0;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.numbers_only);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(95, 508);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 69);
            this.button2.TabIndex = 0;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.numbers_only);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(187, 437);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 69);
            this.button6.TabIndex = 0;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.numbers_only);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(95, 437);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 69);
            this.button5.TabIndex = 0;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.numbers_only);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(187, 366);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(90, 69);
            this.button9.TabIndex = 0;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.numbers_only);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(95, 366);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 69);
            this.button8.TabIndex = 0;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.numbers_only);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonC.FlatAppearance.BorderSize = 0;
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.Location = new System.Drawing.Point(95, 295);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(90, 69);
            this.buttonC.TabIndex = 0;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonCE.FlatAppearance.BorderSize = 0;
            this.buttonCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCE.Location = new System.Drawing.Point(3, 295);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(90, 69);
            this.buttonCE.TabIndex = 0;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = false;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonPlus.FlatAppearance.BorderSize = 0;
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.Location = new System.Drawing.Point(279, 508);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(90, 69);
            this.buttonPlus.TabIndex = 0;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.OperatorClick);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonMinus.FlatAppearance.BorderSize = 0;
            this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinus.Location = new System.Drawing.Point(279, 437);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(90, 69);
            this.buttonMinus.TabIndex = 0;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.OperatorClick);
            // 
            // buttonTimes
            // 
            this.buttonTimes.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonTimes.FlatAppearance.BorderSize = 0;
            this.buttonTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimes.Location = new System.Drawing.Point(279, 366);
            this.buttonTimes.Name = "buttonTimes";
            this.buttonTimes.Size = new System.Drawing.Size(90, 69);
            this.buttonTimes.TabIndex = 0;
            this.buttonTimes.Text = "×";
            this.buttonTimes.UseVisualStyleBackColor = false;
            this.buttonTimes.Click += new System.EventHandler(this.OperatorClick);
            // 
            // buttonDiv
            // 
            this.buttonDiv.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonDiv.FlatAppearance.BorderSize = 0;
            this.buttonDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiv.Location = new System.Drawing.Point(279, 295);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(90, 69);
            this.buttonDiv.TabIndex = 0;
            this.buttonDiv.Text = "÷";
            this.buttonDiv.UseVisualStyleBackColor = false;
            this.buttonDiv.Click += new System.EventHandler(this.OperatorClick);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(187, 295);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(90, 69);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "←";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // rtbDisplayHistory
            // 
            this.rtbDisplayHistory.BackColor = System.Drawing.Color.LightGray;
            this.rtbDisplayHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDisplayHistory.Location = new System.Drawing.Point(595, 135);
            this.rtbDisplayHistory.Name = "rtbDisplayHistory";
            this.rtbDisplayHistory.Size = new System.Drawing.Size(174, 470);
            this.rtbDisplayHistory.TabIndex = 1;
            this.rtbDisplayHistory.Text = "";
            // 
            // buttonTrash
            // 
            this.buttonTrash.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrash.Location = new System.Drawing.Point(737, 608);
            this.buttonTrash.Name = "buttonTrash";
            this.buttonTrash.Size = new System.Drawing.Size(32, 40);
            this.buttonTrash.TabIndex = 2;
            this.buttonTrash.Text = "🗑";
            this.buttonTrash.UseVisualStyleBackColor = true;
            this.buttonTrash.Click += new System.EventHandler(this.buttonTrash_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "≡";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(50, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(110, 29);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Standard";
            // 
            // HistoryLabel
            // 
            this.HistoryLabel.AutoSize = true;
            this.HistoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryLabel.Location = new System.Drawing.Point(609, 45);
            this.HistoryLabel.Name = "HistoryLabel";
            this.HistoryLabel.Size = new System.Drawing.Size(87, 29);
            this.HistoryLabel.TabIndex = 3;
            this.HistoryLabel.Text = "History";
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryLabel.ForeColor = System.Drawing.Color.LightGray;
            this.MemoryLabel.Location = new System.Drawing.Point(386, 13);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(100, 29);
            this.MemoryLabel.TabIndex = 3;
            this.MemoryLabel.Text = "Memory";
            // 
            // lblHistoryDisplay
            // 
            this.lblHistoryDisplay.AutoSize = true;
            this.lblHistoryDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryDisplay.Location = new System.Drawing.Point(511, 82);
            this.lblHistoryDisplay.Name = "lblHistoryDisplay";
            this.lblHistoryDisplay.Size = new System.Drawing.Size(240, 29);
            this.lblHistoryDisplay.TabIndex = 3;
            this.lblHistoryDisplay.Text = "There\'s no history yet";
            // 
            // lblShowOps
            // 
            this.lblShowOps.AutoSize = true;
            this.lblShowOps.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowOps.Location = new System.Drawing.Point(331, 114);
            this.lblShowOps.Name = "lblShowOps";
            this.lblShowOps.Size = new System.Drawing.Size(0, 29);
            this.lblShowOps.TabIndex = 3;
            // 
            // textDisplay
            // 
            this.textDisplay.BackColor = System.Drawing.Color.LightGray;
            this.textDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDisplay.Location = new System.Drawing.Point(3, 146);
            this.textDisplay.Multiline = true;
            this.textDisplay.Name = "textDisplay";
            this.textDisplay.Size = new System.Drawing.Size(366, 49);
            this.textDisplay.TabIndex = 4;
            this.textDisplay.Text = "0";
            this.textDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textDisplay.TextChanged += new System.EventHandler(this.textDisplay_TextChanged);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.LightGray;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(18, 45);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Standard";
            treeNode3.Name = "Node3";
            treeNode3.Text = "";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Scientific";
            treeNode5.Name = "Node5";
            treeNode5.Text = "";
            treeNode6.Name = "Node6";
            treeNode6.Text = "Graphing";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(190, 169);
            this.treeView1.TabIndex = 5;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(773, 651);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.textDisplay);
            this.Controls.Add(this.lblShowOps);
            this.Controls.Add(this.lblHistoryDisplay);
            this.Controls.Add(this.MemoryLabel);
            this.Controls.Add(this.HistoryLabel);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTrash);
            this.Controls.Add(this.rtbDisplayHistory);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonDec);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonTimes);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonEq);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(789, 690);
            this.MinimumSize = new System.Drawing.Size(420, 690);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonEq;
        private System.Windows.Forms.Button buttonDec;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonTimes;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.RichTextBox rtbDisplayHistory;
        private System.Windows.Forms.Button buttonTrash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label HistoryLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label lblHistoryDisplay;
        private System.Windows.Forms.Label lblShowOps;
        private System.Windows.Forms.TextBox textDisplay;
        private System.Windows.Forms.TreeView treeView1;
    }
}

