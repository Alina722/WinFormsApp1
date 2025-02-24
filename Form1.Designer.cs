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
            components = new System.ComponentModel.Container();
            省錢 = new CheckBox();
            notifyIcon1 = new NotifyIcon(components);
            notifyIcon2 = new NotifyIcon(components);
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            listBox1 = new ListBox();
            notifyIcon3 = new NotifyIcon(components);
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // 省錢
            // 
            省錢.AutoSize = true;
            省錢.Location = new Point(37, 46);
            省錢.Name = "省錢";
            省錢.Size = new Size(104, 23);
            省錢.TabIndex = 0;
            省錢.Text = "checkBox1";
            省錢.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // notifyIcon2
            // 
            notifyIcon2.Text = "notifyIcon2";
            notifyIcon2.Visible = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(37, 75);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(104, 23);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(37, 104);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(104, 23);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Location = new Point(191, 46);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(477, 327);
            listBox1.TabIndex = 3;
            // 
            // notifyIcon3
            // 
            notifyIcon3.Text = "notifyIcon3";
            notifyIcon3.Visible = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 27);
            comboBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(232, 389);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(332, 389);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(432, 389);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 8;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(532, 389);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 9;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(省錢);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox 省錢;
        private NotifyIcon notifyIcon1;
        private NotifyIcon notifyIcon2;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private ListBox listBox1;
        private NotifyIcon notifyIcon3;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
