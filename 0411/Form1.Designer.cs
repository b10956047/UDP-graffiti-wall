﻿
namespace _0411
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.textBox_listenPort = new System.Windows.Forms.TextBox();
            this.radioButton_red = new System.Windows.Forms.RadioButton();
            this.radioButton_green = new System.Windows.Forms.RadioButton();
            this.radioButton_blue = new System.Windows.Forms.RadioButton();
            this.radioButton_black = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "目標IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "目標Port";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "接聽Port";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(614, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "連接";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(86, 44);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(100, 22);
            this.textBox_ip.TabIndex = 4;
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(273, 44);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(100, 22);
            this.textBox_port.TabIndex = 5;
            // 
            // textBox_listenPort
            // 
            this.textBox_listenPort.Location = new System.Drawing.Point(461, 44);
            this.textBox_listenPort.Name = "textBox_listenPort";
            this.textBox_listenPort.Size = new System.Drawing.Size(100, 22);
            this.textBox_listenPort.TabIndex = 6;
            // 
            // radioButton_red
            // 
            this.radioButton_red.AutoSize = true;
            this.radioButton_red.Location = new System.Drawing.Point(42, 88);
            this.radioButton_red.Name = "radioButton_red";
            this.radioButton_red.Size = new System.Drawing.Size(38, 16);
            this.radioButton_red.TabIndex = 7;
            this.radioButton_red.TabStop = true;
            this.radioButton_red.Text = "red";
            this.radioButton_red.UseVisualStyleBackColor = true;
            this.radioButton_red.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton_green
            // 
            this.radioButton_green.AutoSize = true;
            this.radioButton_green.Location = new System.Drawing.Point(86, 88);
            this.radioButton_green.Name = "radioButton_green";
            this.radioButton_green.Size = new System.Drawing.Size(49, 16);
            this.radioButton_green.TabIndex = 8;
            this.radioButton_green.TabStop = true;
            this.radioButton_green.Text = "green";
            this.radioButton_green.UseVisualStyleBackColor = true;
            // 
            // radioButton_blue
            // 
            this.radioButton_blue.AutoSize = true;
            this.radioButton_blue.Location = new System.Drawing.Point(141, 88);
            this.radioButton_blue.Name = "radioButton_blue";
            this.radioButton_blue.Size = new System.Drawing.Size(43, 16);
            this.radioButton_blue.TabIndex = 9;
            this.radioButton_blue.TabStop = true;
            this.radioButton_blue.Text = "blue";
            this.radioButton_blue.UseVisualStyleBackColor = true;
            // 
            // radioButton_black
            // 
            this.radioButton_black.AutoSize = true;
            this.radioButton_black.Location = new System.Drawing.Point(190, 88);
            this.radioButton_black.Name = "radioButton_black";
            this.radioButton_black.Size = new System.Drawing.Size(48, 16);
            this.radioButton_black.TabIndex = 10;
            this.radioButton_black.TabStop = true;
            this.radioButton_black.Text = "black";
            this.radioButton_black.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.radioButton_black);
            this.Controls.Add(this.radioButton_blue);
            this.Controls.Add(this.radioButton_green);
            this.Controls.Add(this.radioButton_red);
            this.Controls.Add(this.textBox_listenPort);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.TextBox textBox_listenPort;
        private System.Windows.Forms.RadioButton radioButton_red;
        private System.Windows.Forms.RadioButton radioButton_green;
        private System.Windows.Forms.RadioButton radioButton_blue;
        private System.Windows.Forms.RadioButton radioButton_black;
    }
}

