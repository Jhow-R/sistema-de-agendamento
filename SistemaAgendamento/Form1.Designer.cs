﻿namespace SistemaAgendamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtH1 = new System.Windows.Forms.TextBox();
            this.txtH2 = new System.Windows.Forms.TextBox();
            this.txtH3 = new System.Windows.Forms.TextBox();
            this.txtH4 = new System.Windows.Forms.TextBox();
            this.txtH5 = new System.Windows.Forms.TextBox();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "08:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "09:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "10:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "11:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "12:00";
            // 
            // txtH1
            // 
            this.txtH1.Location = new System.Drawing.Point(78, 28);
            this.txtH1.Name = "txtH1";
            this.txtH1.Size = new System.Drawing.Size(131, 20);
            this.txtH1.TabIndex = 5;
            // 
            // txtH2
            // 
            this.txtH2.Location = new System.Drawing.Point(78, 61);
            this.txtH2.Name = "txtH2";
            this.txtH2.Size = new System.Drawing.Size(131, 20);
            this.txtH2.TabIndex = 6;
            // 
            // txtH3
            // 
            this.txtH3.Location = new System.Drawing.Point(78, 97);
            this.txtH3.Name = "txtH3";
            this.txtH3.Size = new System.Drawing.Size(131, 20);
            this.txtH3.TabIndex = 7;
            // 
            // txtH4
            // 
            this.txtH4.Location = new System.Drawing.Point(78, 132);
            this.txtH4.Name = "txtH4";
            this.txtH4.Size = new System.Drawing.Size(131, 20);
            this.txtH4.TabIndex = 8;
            // 
            // txtH5
            // 
            this.txtH5.Location = new System.Drawing.Point(78, 166);
            this.txtH5.Name = "txtH5";
            this.txtH5.Size = new System.Drawing.Size(131, 20);
            this.txtH5.TabIndex = 9;
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(359, 223);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(75, 23);
            this.btnAgendar.TabIndex = 10;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(234, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 269);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.txtH5);
            this.Controls.Add(this.txtH4);
            this.Controls.Add(this.txtH3);
            this.Controls.Add(this.txtH2);
            this.Controls.Add(this.txtH1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sistema de Agendamento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtH1;
        private System.Windows.Forms.TextBox txtH2;
        private System.Windows.Forms.TextBox txtH3;
        private System.Windows.Forms.TextBox txtH4;
        private System.Windows.Forms.TextBox txtH5;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

