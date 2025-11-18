namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            dropOffBox = new ComboBox();
            label3 = new Label();
            panel2 = new Panel();
            pickUpBox = new ComboBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel4 = new Panel();
            stdntBtn = new RadioButton();
            label5 = new Label();
            label4 = new Label();
            panel5 = new Panel();
            rglrBtn = new RadioButton();
            label6 = new Label();
            label7 = new Label();
            panel6 = new Panel();
            nrmlBtn = new RadioButton();
            label8 = new Label();
            panel7 = new Panel();
            prmmBtn = new RadioButton();
            label9 = new Label();
            panel8 = new Panel();
            totalTxt = new Label();
            label14 = new Label();
            dscntTxt = new Label();
            distFeeTxt = new Label();
            label11 = new Label();
            label10 = new Label();
            bookbtn = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(538, 271);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(dropOffBox);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(84, 148);
            panel3.Name = "panel3";
            panel3.Size = new Size(320, 41);
            panel3.TabIndex = 2;
            // 
            // dropOffBox
            // 
            dropOffBox.FormattingEnabled = true;
            dropOffBox.Items.AddRange(new object[] { "Marquee", "AUF", "SMC" });
            dropOffBox.Location = new Point(139, 8);
            dropOffBox.Name = "dropOffBox";
            dropOffBox.Size = new Size(178, 28);
            dropOffBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 13);
            label3.Name = "label3";
            label3.Size = new Size(135, 17);
            label3.TabIndex = 2;
            label3.Text = "Drop-off Location";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(pickUpBox);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(84, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(320, 41);
            panel2.TabIndex = 1;
            // 
            // pickUpBox
            // 
            pickUpBox.FormattingEnabled = true;
            pickUpBox.Items.AddRange(new object[] { "Marquee", "AUF", "SMC" });
            pickUpBox.Location = new Point(139, 7);
            pickUpBox.Name = "pickUpBox";
            pickUpBox.Size = new Size(178, 28);
            pickUpBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 12);
            label2.Name = "label2";
            label2.Size = new Size(130, 17);
            label2.TabIndex = 0;
            label2.Text = "Pick-up Location";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.map;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(484, 271);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.J_new;
            pictureBox2.Location = new Point(210, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 76);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(104, 77);
            label1.Name = "label1";
            label1.Size = new Size(284, 34);
            label1.TabIndex = 2;
            label1.Text = "BOOK YOUR RIDE";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLightLight;
            panel4.Controls.Add(stdntBtn);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(7, 449);
            panel4.Name = "panel4";
            panel4.Size = new Size(173, 39);
            panel4.TabIndex = 3;
            // 
            // stdntBtn
            // 
            stdntBtn.AutoSize = true;
            stdntBtn.Location = new Point(143, 12);
            stdntBtn.Name = "stdntBtn";
            stdntBtn.Size = new Size(17, 16);
            stdntBtn.TabIndex = 6;
            stdntBtn.TabStop = true;
            stdntBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(5, 11);
            label5.Name = "label5";
            label5.Size = new Size(79, 17);
            label5.TabIndex = 5;
            label5.Text = "STUDENT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 412);
            label4.Name = "label4";
            label4.Size = new Size(145, 17);
            label4.TabIndex = 1;
            label4.Text = "PASSENGER TYPE";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLightLight;
            panel5.Controls.Add(rglrBtn);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(7, 503);
            panel5.Name = "panel5";
            panel5.Size = new Size(173, 39);
            panel5.TabIndex = 4;
            // 
            // rglrBtn
            // 
            rglrBtn.AutoSize = true;
            rglrBtn.Location = new Point(143, 13);
            rglrBtn.Name = "rglrBtn";
            rglrBtn.Size = new Size(17, 16);
            rglrBtn.TabIndex = 7;
            rglrBtn.TabStop = true;
            rglrBtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(5, 12);
            label6.Name = "label6";
            label6.Size = new Size(83, 17);
            label6.TabIndex = 6;
            label6.Text = "REGULAR";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 566);
            label7.Name = "label7";
            label7.Size = new Size(100, 17);
            label7.TabIndex = 5;
            label7.Text = "RIDE CLASS";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlLightLight;
            panel6.Controls.Add(nrmlBtn);
            panel6.Controls.Add(label8);
            panel6.Location = new Point(7, 598);
            panel6.Name = "panel6";
            panel6.Size = new Size(173, 39);
            panel6.TabIndex = 7;
            // 
            // nrmlBtn
            // 
            nrmlBtn.AutoSize = true;
            nrmlBtn.Location = new Point(143, 12);
            nrmlBtn.Name = "nrmlBtn";
            nrmlBtn.Size = new Size(17, 16);
            nrmlBtn.TabIndex = 6;
            nrmlBtn.TabStop = true;
            nrmlBtn.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(5, 11);
            label8.Name = "label8";
            label8.Size = new Size(74, 17);
            label8.TabIndex = 5;
            label8.Text = "NORMAL";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ControlLightLight;
            panel7.Controls.Add(prmmBtn);
            panel7.Controls.Add(label9);
            panel7.Location = new Point(7, 652);
            panel7.Name = "panel7";
            panel7.Size = new Size(173, 39);
            panel7.TabIndex = 8;
            // 
            // prmmBtn
            // 
            prmmBtn.AutoSize = true;
            prmmBtn.Location = new Point(143, 12);
            prmmBtn.Name = "prmmBtn";
            prmmBtn.Size = new Size(17, 16);
            prmmBtn.TabIndex = 6;
            prmmBtn.TabStop = true;
            prmmBtn.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(5, 11);
            label9.Name = "label9";
            label9.Size = new Size(79, 17);
            label9.TabIndex = 5;
            label9.Text = "PREMIUM";
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ControlLightLight;
            panel8.Controls.Add(totalTxt);
            panel8.Controls.Add(label14);
            panel8.Controls.Add(dscntTxt);
            panel8.Controls.Add(distFeeTxt);
            panel8.Controls.Add(label11);
            panel8.Controls.Add(label10);
            panel8.Location = new Point(220, 407);
            panel8.Name = "panel8";
            panel8.Size = new Size(250, 284);
            panel8.TabIndex = 9;
            // 
            // totalTxt
            // 
            totalTxt.AutoSize = true;
            totalTxt.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalTxt.ForeColor = SystemColors.Highlight;
            totalTxt.Location = new Point(100, 219);
            totalTxt.Name = "totalTxt";
            totalTxt.Size = new Size(33, 34);
            totalTxt.TabIndex = 15;
            totalTxt.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.Highlight;
            label14.Location = new Point(4, 175);
            label14.Name = "label14";
            label14.Size = new Size(218, 23);
            label14.TabIndex = 14;
            label14.Text = "Total Estimated Fare:";
            // 
            // dscntTxt
            // 
            dscntTxt.AutoSize = true;
            dscntTxt.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dscntTxt.Location = new Point(4, 118);
            dscntTxt.Name = "dscntTxt";
            dscntTxt.Size = new Size(159, 17);
            dscntTxt.TabIndex = 13;
            dscntTxt.Text = "Passenger Discount:";
            // 
            // distFeeTxt
            // 
            distFeeTxt.AutoSize = true;
            distFeeTxt.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            distFeeTxt.Location = new Point(4, 82);
            distFeeTxt.Name = "distFeeTxt";
            distFeeTxt.Size = new Size(108, 17);
            distFeeTxt.TabIndex = 12;
            distFeeTxt.Text = "Distance Fee:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(4, 42);
            label11.Name = "label11";
            label11.Size = new Size(126, 17);
            label11.TabIndex = 11;
            label11.Text = "Base Rate: 100₱";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(4, 5);
            label10.Name = "label10";
            label10.Size = new Size(129, 17);
            label10.TabIndex = 10;
            label10.Text = "FARE SUMMARY";
            // 
            // bookbtn
            // 
            bookbtn.BackColor = SystemColors.MenuHighlight;
            bookbtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookbtn.ForeColor = SystemColors.ButtonHighlight;
            bookbtn.Location = new Point(150, 717);
            bookbtn.Name = "bookbtn";
            bookbtn.Size = new Size(169, 43);
            bookbtn.TabIndex = 10;
            bookbtn.Text = "BOOK NOW!";
            bookbtn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(482, 772);
            Controls.Add(bookbtn);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(label7);
            Controls.Add(panel5);
            Controls.Add(label4);
            Controls.Add(panel4);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Ride";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel panel3;
        private Panel panel2;
        private Label label2;
        private ComboBox pickUpBox;
        private ComboBox dropOffBox;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private Label label5;
        private Panel panel5;
        private Label label6;
        private RadioButton stdntBtn;
        private RadioButton rglrBtn;
        private Label label7;
        private Panel panel6;
        private RadioButton nrmlBtn;
        private Label label8;
        private Panel panel7;
        private RadioButton prmmBtn;
        private Label label9;
        private Panel panel8;
        private Label label10;
        private Button bookbtn;
        private Label label11;
        private Label distFeeTxt;
        private Label label14;
        private Label dscntTxt;
        private Label totalTxt;
    }
}
