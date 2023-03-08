namespace tp_03_ejercicio_02
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            resultLabel = new Label();
            calculateButton = new Button();
            inputGroupBox = new GroupBox();
            inputGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(112, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(261, 42);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 15);
            resultLabel.TabIndex = 2;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(12, 77);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(75, 23);
            calculateButton.TabIndex = 3;
            calculateButton.Text = "Calcular";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // inputGroupBox
            // 
            inputGroupBox.Controls.Add(textBox1);
            inputGroupBox.Controls.Add(textBox2);
            inputGroupBox.Location = new Point(12, 12);
            inputGroupBox.Name = "inputGroupBox";
            inputGroupBox.Size = new Size(243, 59);
            inputGroupBox.TabIndex = 4;
            inputGroupBox.TabStop = false;
            inputGroupBox.Text = "Input";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 150);
            Controls.Add(inputGroupBox);
            Controls.Add(calculateButton);
            Controls.Add(resultLabel);
            Name = "Form1";
            Text = "Trabajo Práctico 03 - Ejercicio 02";
            inputGroupBox.ResumeLayout(false);
            inputGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label resultLabel;
        private Button calculateButton;
        private GroupBox inputGroupBox;
    }
}