﻿namespace WindowsFormsApplication1
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
               this.components = new System.ComponentModel.Container();
               this.button1 = new System.Windows.Forms.Button();
               this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
               this.button2 = new System.Windows.Forms.Button();
               this.radioButton1 = new System.Windows.Forms.RadioButton();
               this.radioButton2 = new System.Windows.Forms.RadioButton();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.textBox2 = new System.Windows.Forms.TextBox();
               this.label3 = new System.Windows.Forms.Label();
               this.textBox3 = new System.Windows.Forms.TextBox();
               this.label4 = new System.Windows.Forms.Label();
               this.textBox4 = new System.Windows.Forms.TextBox();
               this.comboBox1 = new System.Windows.Forms.ComboBox();
               this.label5 = new System.Windows.Forms.Label();
               this.label6 = new System.Windows.Forms.Label();
               this.textBox5 = new System.Windows.Forms.TextBox();
               this.label7 = new System.Windows.Forms.Label();
               this.textBox6 = new System.Windows.Forms.TextBox();
               this.label9 = new System.Windows.Forms.Label();
               this.textBox8 = new System.Windows.Forms.TextBox();
               this.label10 = new System.Windows.Forms.Label();
               this.textBox9 = new System.Windows.Forms.TextBox();
               this.label11 = new System.Windows.Forms.Label();
               this.textBox10 = new System.Windows.Forms.TextBox();
               this.label12 = new System.Windows.Forms.Label();
               this.textBox11 = new System.Windows.Forms.TextBox();
               this.label13 = new System.Windows.Forms.Label();
               this.textBox12 = new System.Windows.Forms.TextBox();
               this.label14 = new System.Windows.Forms.Label();
               this.textBox13 = new System.Windows.Forms.TextBox();
               this.label8 = new System.Windows.Forms.Label();
               this.textBox7 = new System.Windows.Forms.TextBox();
               this.label15 = new System.Windows.Forms.Label();
               this.textBox14 = new System.Windows.Forms.TextBox();
               this.label16 = new System.Windows.Forms.Label();
               this.textBox15 = new System.Windows.Forms.TextBox();
               this.button3 = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
               this.SuspendLayout();
               // 
               // button1
               // 
               this.button1.Location = new System.Drawing.Point(604, 21);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(75, 23);
               this.button1.TabIndex = 18;
               this.button1.Text = "Guardar";
               this.button1.UseVisualStyleBackColor = true;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // errorProvider1
               // 
               this.errorProvider1.ContainerControl = this;
               // 
               // button2
               // 
               this.button2.Location = new System.Drawing.Point(510, 21);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(75, 23);
               this.button2.TabIndex = 17;
               this.button2.Text = "Limpiar";
               this.button2.UseVisualStyleBackColor = true;
               this.button2.Click += new System.EventHandler(this.button2_Click);
               // 
               // radioButton1
               // 
               this.radioButton1.AutoSize = true;
               this.radioButton1.Location = new System.Drawing.Point(311, 21);
               this.radioButton1.Name = "radioButton1";
               this.radioButton1.Size = new System.Drawing.Size(57, 17);
               this.radioButton1.TabIndex = 19;
               this.radioButton1.TabStop = true;
               this.radioButton1.Text = "Nuevo";
               this.radioButton1.UseVisualStyleBackColor = true;
               this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
               // 
               // radioButton2
               // 
               this.radioButton2.AutoSize = true;
               this.radioButton2.Location = new System.Drawing.Point(399, 21);
               this.radioButton2.Name = "radioButton2";
               this.radioButton2.Size = new System.Drawing.Size(52, 17);
               this.radioButton2.TabIndex = 20;
               this.radioButton2.TabStop = true;
               this.radioButton2.Text = "Editar";
               this.radioButton2.UseVisualStyleBackColor = true;
               this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
               // 
               // textBox1
               // 
               this.textBox1.Location = new System.Drawing.Point(134, 80);
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(121, 20);
               this.textBox1.TabIndex = 2;
               this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(15, 83);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(44, 13);
               this.label1.TabIndex = 111;
               this.label1.Text = "Nombre";
               this.label1.Click += new System.EventHandler(this.label1_Click);
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(15, 109);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(44, 13);
               this.label2.TabIndex = 111;
               this.label2.Text = "Apellido";
               // 
               // textBox2
               // 
               this.textBox2.Location = new System.Drawing.Point(134, 106);
               this.textBox2.Name = "textBox2";
               this.textBox2.Size = new System.Drawing.Size(121, 20);
               this.textBox2.TabIndex = 3;
               this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
               this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(15, 135);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(33, 13);
               this.label3.TabIndex = 111;
               this.label3.Text = "Titulo";
               this.label3.Click += new System.EventHandler(this.label3_Click);
               // 
               // textBox3
               // 
               this.textBox3.Location = new System.Drawing.Point(134, 132);
               this.textBox3.Name = "textBox3";
               this.textBox3.Size = new System.Drawing.Size(121, 20);
               this.textBox3.TabIndex = 4;
               this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(15, 57);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(16, 13);
               this.label4.TabIndex = 111;
               this.label4.Text = "Id";
               // 
               // textBox4
               // 
               this.textBox4.Location = new System.Drawing.Point(134, 54);
               this.textBox4.Name = "textBox4";
               this.textBox4.Size = new System.Drawing.Size(121, 20);
               this.textBox4.TabIndex = 1;
               this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
               this.textBox4.Leave += new System.EventHandler(this.textBox4_Leave);
               // 
               // comboBox1
               // 
               this.comboBox1.FormattingEnabled = true;
               this.comboBox1.Location = new System.Drawing.Point(430, 242);
               this.comboBox1.Name = "comboBox1";
               this.comboBox1.Size = new System.Drawing.Size(121, 21);
               this.comboBox1.TabIndex = 16;
               this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Location = new System.Drawing.Point(314, 245);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(27, 13);
               this.label5.TabIndex = 111;
               this.label5.Text = "Jefe";
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Location = new System.Drawing.Point(314, 165);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(91, 13);
               this.label6.TabIndex = 111;
               this.label6.Text = "Telefono de Casa";
               this.label6.Click += new System.EventHandler(this.label6_Click);
               // 
               // textBox5
               // 
               this.textBox5.Location = new System.Drawing.Point(430, 161);
               this.textBox5.Name = "textBox5";
               this.textBox5.Size = new System.Drawing.Size(121, 20);
               this.textBox5.TabIndex = 13;
               this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
               this.textBox5.Leave += new System.EventHandler(this.textBox5_Leave);
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.Location = new System.Drawing.Point(314, 191);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(53, 13);
               this.label7.TabIndex = 18;
               this.label7.Text = "Extension";
               // 
               // textBox6
               // 
               this.textBox6.Location = new System.Drawing.Point(430, 187);
               this.textBox6.Name = "textBox6";
               this.textBox6.Size = new System.Drawing.Size(121, 20);
               this.textBox6.TabIndex = 14;
               this.textBox6.Leave += new System.EventHandler(this.textBox6_Leave);
               // 
               // label9
               // 
               this.label9.AutoSize = true;
               this.label9.Location = new System.Drawing.Point(314, 61);
               this.label9.Name = "label9";
               this.label9.Size = new System.Drawing.Size(40, 13);
               this.label9.TabIndex = 22;
               this.label9.Text = "Ciudad";
               // 
               // textBox8
               // 
               this.textBox8.Location = new System.Drawing.Point(430, 57);
               this.textBox8.Name = "textBox8";
               this.textBox8.Size = new System.Drawing.Size(121, 20);
               this.textBox8.TabIndex = 9;
               this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
               this.textBox8.Leave += new System.EventHandler(this.textBox8_Leave);
               // 
               // label10
               // 
               this.label10.AutoSize = true;
               this.label10.Location = new System.Drawing.Point(314, 87);
               this.label10.Name = "label10";
               this.label10.Size = new System.Drawing.Size(41, 13);
               this.label10.TabIndex = 24;
               this.label10.Text = "Region";
               // 
               // textBox9
               // 
               this.textBox9.Location = new System.Drawing.Point(430, 83);
               this.textBox9.Name = "textBox9";
               this.textBox9.Size = new System.Drawing.Size(121, 20);
               this.textBox9.TabIndex = 10;
               this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
               this.textBox9.Leave += new System.EventHandler(this.textBox9_Leave);
               // 
               // label11
               // 
               this.label11.AutoSize = true;
               this.label11.Location = new System.Drawing.Point(314, 113);
               this.label11.Name = "label11";
               this.label11.Size = new System.Drawing.Size(72, 13);
               this.label11.TabIndex = 26;
               this.label11.Text = "Codigo Postal";
               this.label11.Click += new System.EventHandler(this.label11_Click);
               // 
               // textBox10
               // 
               this.textBox10.Location = new System.Drawing.Point(430, 109);
               this.textBox10.Name = "textBox10";
               this.textBox10.Size = new System.Drawing.Size(121, 20);
               this.textBox10.TabIndex = 11;
               this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
               this.textBox10.Leave += new System.EventHandler(this.textBox10_Leave);
               // 
               // label12
               // 
               this.label12.AutoSize = true;
               this.label12.Location = new System.Drawing.Point(15, 164);
               this.label12.Name = "label12";
               this.label12.Size = new System.Drawing.Size(88, 13);
               this.label12.TabIndex = 28;
               this.label12.Text = "Titulo de cortesia";
               this.label12.Click += new System.EventHandler(this.label12_Click);
               // 
               // textBox11
               // 
               this.textBox11.Location = new System.Drawing.Point(134, 161);
               this.textBox11.Name = "textBox11";
               this.textBox11.Size = new System.Drawing.Size(121, 20);
               this.textBox11.TabIndex = 5;
               this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
               // 
               // label13
               // 
               this.label13.AutoSize = true;
               this.label13.Location = new System.Drawing.Point(15, 190);
               this.label13.Name = "label13";
               this.label13.Size = new System.Drawing.Size(106, 13);
               this.label13.TabIndex = 30;
               this.label13.Text = "Fecha de nacimiento";
               this.label13.Click += new System.EventHandler(this.label13_Click);
               // 
               // textBox12
               // 
               this.textBox12.Location = new System.Drawing.Point(134, 187);
               this.textBox12.Name = "textBox12";
               this.textBox12.Size = new System.Drawing.Size(121, 20);
               this.textBox12.TabIndex = 6;
               this.textBox12.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
               this.textBox12.Leave += new System.EventHandler(this.textBox12_Leave);
               // 
               // label14
               // 
               this.label14.AutoSize = true;
               this.label14.Location = new System.Drawing.Point(15, 242);
               this.label14.Name = "label14";
               this.label14.Size = new System.Drawing.Size(52, 13);
               this.label14.TabIndex = 32;
               this.label14.Text = "Dirección";
               this.label14.Click += new System.EventHandler(this.label14_Click);
               // 
               // textBox13
               // 
               this.textBox13.Location = new System.Drawing.Point(134, 239);
               this.textBox13.Name = "textBox13";
               this.textBox13.Size = new System.Drawing.Size(121, 20);
               this.textBox13.TabIndex = 8;
               // 
               // label8
               // 
               this.label8.AutoSize = true;
               this.label8.Location = new System.Drawing.Point(314, 139);
               this.label8.Name = "label8";
               this.label8.Size = new System.Drawing.Size(27, 13);
               this.label8.TabIndex = 34;
               this.label8.Text = "Pais";
               // 
               // textBox7
               // 
               this.textBox7.Location = new System.Drawing.Point(430, 135);
               this.textBox7.Name = "textBox7";
               this.textBox7.Size = new System.Drawing.Size(121, 20);
               this.textBox7.TabIndex = 12;
               // 
               // label15
               // 
               this.label15.AutoSize = true;
               this.label15.Location = new System.Drawing.Point(314, 216);
               this.label15.Name = "label15";
               this.label15.Size = new System.Drawing.Size(35, 13);
               this.label15.TabIndex = 36;
               this.label15.Text = "Notas";
               // 
               // textBox14
               // 
               this.textBox14.Location = new System.Drawing.Point(430, 213);
               this.textBox14.Name = "textBox14";
               this.textBox14.Size = new System.Drawing.Size(121, 20);
               this.textBox14.TabIndex = 15;
               // 
               // label16
               // 
               this.label16.AutoSize = true;
               this.label16.Location = new System.Drawing.Point(15, 216);
               this.label16.Name = "label16";
               this.label16.Size = new System.Drawing.Size(115, 13);
               this.label16.TabIndex = 38;
               this.label16.Text = "Fecha de Contratacion";
               this.label16.Click += new System.EventHandler(this.label16_Click);
               // 
               // textBox15
               // 
               this.textBox15.Enabled = false;
               this.textBox15.Location = new System.Drawing.Point(134, 213);
               this.textBox15.Name = "textBox15";
               this.textBox15.Size = new System.Drawing.Size(121, 20);
               this.textBox15.TabIndex = 7;
               // 
               // button3
               // 
               this.button3.Location = new System.Drawing.Point(653, 237);
               this.button3.Name = "button3";
               this.button3.Size = new System.Drawing.Size(75, 23);
               this.button3.TabIndex = 112;
               this.button3.Text = "Consultas";
               this.button3.UseVisualStyleBackColor = true;
               this.button3.Click += new System.EventHandler(this.button3_Click);
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(731, 301);
               this.Controls.Add(this.button3);
               this.Controls.Add(this.label16);
               this.Controls.Add(this.textBox15);
               this.Controls.Add(this.label15);
               this.Controls.Add(this.textBox14);
               this.Controls.Add(this.label8);
               this.Controls.Add(this.textBox7);
               this.Controls.Add(this.label14);
               this.Controls.Add(this.textBox13);
               this.Controls.Add(this.label13);
               this.Controls.Add(this.textBox12);
               this.Controls.Add(this.label12);
               this.Controls.Add(this.textBox11);
               this.Controls.Add(this.label11);
               this.Controls.Add(this.textBox10);
               this.Controls.Add(this.label10);
               this.Controls.Add(this.textBox9);
               this.Controls.Add(this.label9);
               this.Controls.Add(this.textBox8);
               this.Controls.Add(this.label7);
               this.Controls.Add(this.textBox6);
               this.Controls.Add(this.label6);
               this.Controls.Add(this.textBox5);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.comboBox1);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.textBox4);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.textBox3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.textBox2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.textBox1);
               this.Controls.Add(this.radioButton2);
               this.Controls.Add(this.radioButton1);
               this.Controls.Add(this.button2);
               this.Controls.Add(this.button1);
               this.Name = "Form1";
               this.Text = "Form1";
               this.Load += new System.EventHandler(this.Form1_Load);
               ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.ErrorProvider errorProvider1;
          private System.Windows.Forms.Button button2;
          private System.Windows.Forms.RadioButton radioButton2;
          private System.Windows.Forms.RadioButton radioButton1;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.TextBox textBox1;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.TextBox textBox4;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.TextBox textBox3;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.TextBox textBox2;
          private System.Windows.Forms.ComboBox comboBox1;
          private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
          private System.Windows.Forms.Label label13;
          private System.Windows.Forms.TextBox textBox12;
          private System.Windows.Forms.Label label12;
          private System.Windows.Forms.TextBox textBox11;
          private System.Windows.Forms.Label label14;
          private System.Windows.Forms.TextBox textBox13;
          private System.Windows.Forms.Label label8;
          private System.Windows.Forms.TextBox textBox7;
          private System.Windows.Forms.Label label15;
          private System.Windows.Forms.TextBox textBox14;
          private System.Windows.Forms.Label label16;
          private System.Windows.Forms.TextBox textBox15;
          private System.Windows.Forms.Button button3;
     }
}

