namespace tp_03_ejercicio_06
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
            label1 = new Label();
            TextBoxInput = new TextBox();
            ButtonCalculate = new Button();
            ListBox = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "Max";
            // 
            // TextBoxInput
            // 
            TextBoxInput.Location = new Point(12, 27);
            TextBoxInput.Name = "TextBoxInput";
            TextBoxInput.Size = new Size(100, 23);
            TextBoxInput.TabIndex = 2;
            // 
            // ButtonCalculate
            // 
            ButtonCalculate.Location = new Point(12, 56);
            ButtonCalculate.Name = "ButtonCalculate";
            ButtonCalculate.Size = new Size(100, 50);
            ButtonCalculate.TabIndex = 3;
            ButtonCalculate.Text = "Calcular";
            ButtonCalculate.UseVisualStyleBackColor = true;
            ButtonCalculate.Click += ButtonCalculate_Click;
            // 
            // ListBox
            // 
            ListBox.FormattingEnabled = true;
            ListBox.ItemHeight = 15;
            ListBox.Location = new Point(118, 12);
            ListBox.Name = "ListBox";
            ListBox.Size = new Size(120, 94);
            ListBox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 134);
            Controls.Add(ListBox);
            Controls.Add(ButtonCalculate);
            Controls.Add(TextBoxInput);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Trabajo Práctico 03 - Ejercicio 06";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TextBoxInput;
        private Button ButtonCalculate;
        private ListBox ListBox;
    }
}