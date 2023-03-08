namespace tp_03_ejercicio_05
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
            GroupBoxInput = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            TextBoxMax = new TextBox();
            TextBoxMin = new TextBox();
            ListBox = new ListBox();
            ButtonCalculate = new Button();
            GroupBoxInput.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBoxInput
            // 
            GroupBoxInput.Controls.Add(label2);
            GroupBoxInput.Controls.Add(label1);
            GroupBoxInput.Controls.Add(TextBoxMax);
            GroupBoxInput.Controls.Add(TextBoxMin);
            GroupBoxInput.Location = new Point(12, 12);
            GroupBoxInput.Name = "GroupBoxInput";
            GroupBoxInput.Size = new Size(238, 100);
            GroupBoxInput.TabIndex = 0;
            GroupBoxInput.TabStop = false;
            GroupBoxInput.Text = "Input";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 19);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 3;
            label2.Text = "Max";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 19);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 2;
            label1.Text = "Min";
            // 
            // TextBoxMax
            // 
            TextBoxMax.Location = new Point(117, 37);
            TextBoxMax.Name = "TextBoxMax";
            TextBoxMax.Size = new Size(100, 23);
            TextBoxMax.TabIndex = 1;
            // 
            // TextBoxMin
            // 
            TextBoxMin.Location = new Point(11, 37);
            TextBoxMin.Name = "TextBoxMin";
            TextBoxMin.Size = new Size(100, 23);
            TextBoxMin.TabIndex = 0;
            // 
            // ListBox
            // 
            ListBox.FormattingEnabled = true;
            ListBox.ItemHeight = 15;
            ListBox.Location = new Point(256, 18);
            ListBox.Name = "ListBox";
            ListBox.Size = new Size(120, 94);
            ListBox.TabIndex = 1;
            // 
            // ButtonCalculate
            // 
            ButtonCalculate.Location = new Point(12, 118);
            ButtonCalculate.Name = "ButtonCalculate";
            ButtonCalculate.Size = new Size(75, 23);
            ButtonCalculate.TabIndex = 2;
            ButtonCalculate.Text = "Calculate";
            ButtonCalculate.UseVisualStyleBackColor = true;
            ButtonCalculate.Click += ButtonCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 166);
            Controls.Add(ButtonCalculate);
            Controls.Add(ListBox);
            Controls.Add(GroupBoxInput);
            Name = "Form1";
            Text = "Trabajo Práctico 03 - Ejercicio 05";
            GroupBoxInput.ResumeLayout(false);
            GroupBoxInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBoxInput;
        private Label label2;
        private Label label1;
        private TextBox TextBoxMax;
        private TextBox TextBoxMin;
        private ListBox ListBox;
        private Button ButtonCalculate;
    }
}