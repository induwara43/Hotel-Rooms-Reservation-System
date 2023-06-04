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
            nameBox = new TextBox();
            label3 = new Label();
            addressBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            roomBox = new ComboBox();
            roomCountBox = new TextBox();
            label4 = new Label();
            calculateBtn = new Button();
            clearBtn = new Button();
            exitBtn = new Button();
            anotherBox = new ComboBox();
            label5 = new Label();
            totalBox = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // nameBox
            // 
            nameBox.Location = new Point(215, 95);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(249, 23);
            nameBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 98);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Name";
            // 
            // addressBox
            // 
            addressBox.Location = new Point(215, 184);
            addressBox.Name = "addressBox";
            addressBox.Size = new Size(352, 23);
            addressBox.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 187);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 7;
            label1.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 265);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 9;
            label2.Text = "Room Type";
            // 
            // roomBox
            // 
            roomBox.FormattingEnabled = true;
            roomBox.Items.AddRange(new object[] { "Single", "Double", "Family", "Suite" });
            roomBox.Location = new Point(215, 257);
            roomBox.Name = "roomBox";
            roomBox.Size = new Size(121, 23);
            roomBox.TabIndex = 10;
            // 
            // roomCountBox
            // 
            roomCountBox.Location = new Point(215, 330);
            roomCountBox.Name = "roomCountBox";
            roomCountBox.Size = new Size(65, 23);
            roomCountBox.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 333);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 11;
            label4.Text = "Number of Rooms";
            // 
            // calculateBtn
            // 
            calculateBtn.Location = new Point(636, 87);
            calculateBtn.Name = "calculateBtn";
            calculateBtn.Size = new Size(136, 36);
            calculateBtn.TabIndex = 13;
            calculateBtn.Text = "Calculate the Price";
            calculateBtn.UseVisualStyleBackColor = true;
            calculateBtn.Click += calculateBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(636, 166);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(84, 36);
            clearBtn.TabIndex = 14;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(636, 254);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(84, 36);
            exitBtn.TabIndex = 15;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            // 
            // anotherBox
            // 
            anotherBox.FormattingEnabled = true;
            anotherBox.Items.AddRange(new object[] { "Yes", "No" });
            anotherBox.Location = new Point(325, 392);
            anotherBox.Name = "anotherBox";
            anotherBox.Size = new Size(48, 23);
            anotherBox.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 400);
            label5.Name = "label5";
            label5.Size = new Size(212, 15);
            label5.TabIndex = 16;
            label5.Text = "Do you want to do an another booking";
            // 
            // totalBox
            // 
            totalBox.Location = new Point(633, 397);
            totalBox.Name = "totalBox";
            totalBox.Size = new Size(65, 23);
            totalBox.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(503, 400);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 18;
            label6.Text = "Total Price";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(totalBox);
            Controls.Add(label6);
            Controls.Add(anotherBox);
            Controls.Add(label5);
            Controls.Add(exitBtn);
            Controls.Add(clearBtn);
            Controls.Add(calculateBtn);
            Controls.Add(roomCountBox);
            Controls.Add(label4);
            Controls.Add(roomBox);
            Controls.Add(label2);
            Controls.Add(addressBox);
            Controls.Add(label1);
            Controls.Add(nameBox);
            Controls.Add(label3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameBox;
        private Label label3;
        private TextBox addressBox;
        private Label label1;
        private Label label2;
        private ComboBox roomBox;
        private TextBox roomCountBox;
        private Label label4;
        private Button calculateBtn;
        private Button clearBtn;
        private Button exitBtn;
        private ComboBox anotherBox;
        private Label label5;
        private TextBox totalBox;
        private Label label6;
    }
}