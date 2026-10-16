namespace PromedioFinal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.firstgrade = new System.Windows.Forms.NumericUpDown();
            this.secondgrade = new System.Windows.Forms.NumericUpDown();
            this.thirdgrade = new System.Windows.Forms.NumericUpDown();
            this.fourthgrade = new System.Windows.Forms.NumericUpDown();
            this.fifthgrade = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblprom = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstgrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondgrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdgrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthgrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fifthgrade)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fifthgrade);
            this.groupBox1.Controls.Add(this.fourthgrade);
            this.groupBox1.Controls.Add(this.thirdgrade);
            this.groupBox1.Controls.Add(this.secondgrade);
            this.groupBox1.Controls.Add(this.firstgrade);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese las notas del estudiante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota 1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota 2 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota 3 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota 4 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nota 5 :";
            // 
            // firstgrade
            // 
            this.firstgrade.DecimalPlaces = 2;
            this.firstgrade.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.firstgrade.Location = new System.Drawing.Point(157, 27);
            this.firstgrade.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.firstgrade.Name = "firstgrade";
            this.firstgrade.Size = new System.Drawing.Size(263, 22);
            this.firstgrade.TabIndex = 5;
            // 
            // secondgrade
            // 
            this.secondgrade.DecimalPlaces = 2;
            this.secondgrade.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.secondgrade.Location = new System.Drawing.Point(157, 57);
            this.secondgrade.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.secondgrade.Name = "secondgrade";
            this.secondgrade.Size = new System.Drawing.Size(263, 22);
            this.secondgrade.TabIndex = 6;
            // 
            // thirdgrade
            // 
            this.thirdgrade.DecimalPlaces = 2;
            this.thirdgrade.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.thirdgrade.Location = new System.Drawing.Point(157, 94);
            this.thirdgrade.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.thirdgrade.Name = "thirdgrade";
            this.thirdgrade.Size = new System.Drawing.Size(263, 22);
            this.thirdgrade.TabIndex = 7;
            // 
            // fourthgrade
            // 
            this.fourthgrade.DecimalPlaces = 2;
            this.fourthgrade.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.fourthgrade.Location = new System.Drawing.Point(157, 138);
            this.fourthgrade.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.fourthgrade.Name = "fourthgrade";
            this.fourthgrade.Size = new System.Drawing.Size(263, 22);
            this.fourthgrade.TabIndex = 8;
            // 
            // fifthgrade
            // 
            this.fifthgrade.DecimalPlaces = 2;
            this.fifthgrade.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.fifthgrade.Location = new System.Drawing.Point(157, 176);
            this.fifthgrade.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.fifthgrade.Name = "fifthgrade";
            this.fifthgrade.Size = new System.Drawing.Size(263, 22);
            this.fifthgrade.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(159, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calcular Promedio";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(89, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Promedio Final :";
            // 
            // lblprom
            // 
            this.lblprom.AutoSize = true;
            this.lblprom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprom.Location = new System.Drawing.Point(278, 321);
            this.lblprom.Name = "lblprom";
            this.lblprom.Size = new System.Drawing.Size(0, 24);
            this.lblprom.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 383);
            this.Controls.Add(this.lblprom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Promedio de Notas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstgrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondgrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdgrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthgrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fifthgrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown fifthgrade;
        private System.Windows.Forms.NumericUpDown fourthgrade;
        private System.Windows.Forms.NumericUpDown thirdgrade;
        private System.Windows.Forms.NumericUpDown secondgrade;
        private System.Windows.Forms.NumericUpDown firstgrade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblprom;
    }
}

