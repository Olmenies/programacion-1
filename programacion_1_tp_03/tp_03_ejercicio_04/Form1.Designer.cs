namespace tp_03_ejercicio_04
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
            TextBoxInput0 = new TextBox();
            TextBoxInput1 = new TextBox();
            LabelResult = new Label();
            ButtonAdd = new Button();
            ButtonMinus = new Button();
            ButtonMultiply = new Button();
            ButtonDivide = new Button();
            GroupBoxInput = new GroupBox();
            GroupBoxInput.SuspendLayout();
            SuspendLayout();
            // 
            // TextBoxInput0
            // 
            TextBoxInput0.Location = new Point(6, 21);
            TextBoxInput0.Name = "TextBoxInput0";
            TextBoxInput0.Size = new Size(100, 23);
            TextBoxInput0.TabIndex = 0;
            // 
            // TextBoxInput1
            // 
            TextBoxInput1.Location = new Point(6, 49);
            TextBoxInput1.Name = "TextBoxInput1";
            TextBoxInput1.Size = new Size(100, 23);
            TextBoxInput1.TabIndex = 1;
            // 
            // LabelResult
            // 
            LabelResult.AutoSize = true;
            LabelResult.Location = new Point(231, 20);
            LabelResult.Name = "LabelResult";
            LabelResult.Size = new Size(42, 15);
            LabelResult.TabIndex = 2;
            LabelResult.Text = "Result:";
            // 
            // ButtonAdd
            // 
            ButtonAdd.Location = new Point(12, 12);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(75, 23);
            ButtonAdd.TabIndex = 3;
            ButtonAdd.Text = "+";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // ButtonMinus
            // 
            ButtonMinus.Location = new Point(12, 41);
            ButtonMinus.Name = "ButtonMinus";
            ButtonMinus.Size = new Size(75, 23);
            ButtonMinus.TabIndex = 4;
            ButtonMinus.Text = "-";
            ButtonMinus.UseVisualStyleBackColor = true;
            ButtonMinus.Click += ButtonMinus_Click;
            // 
            // ButtonMultiply
            // 
            ButtonMultiply.Location = new Point(12, 70);
            ButtonMultiply.Name = "ButtonMultiply";
            ButtonMultiply.Size = new Size(75, 23);
            ButtonMultiply.TabIndex = 5;
            ButtonMultiply.Text = "*";
            ButtonMultiply.UseVisualStyleBackColor = true;
            ButtonMultiply.Click += ButtonMultiply_Click;
            // 
            // ButtonDivide
            // 
            ButtonDivide.Location = new Point(12, 99);
            ButtonDivide.Name = "ButtonDivide";
            ButtonDivide.Size = new Size(75, 23);
            ButtonDivide.TabIndex = 6;
            ButtonDivide.Text = "/";
            ButtonDivide.UseVisualStyleBackColor = true;
            ButtonDivide.Click += ButtonDivide_Click;
            // 
            // GroupBoxInput
            // 
            GroupBoxInput.Controls.Add(TextBoxInput1);
            GroupBoxInput.Controls.Add(TextBoxInput0);
            GroupBoxInput.Location = new Point(93, 12);
            GroupBoxInput.Name = "GroupBoxInput";
            GroupBoxInput.Size = new Size(132, 110);
            GroupBoxInput.TabIndex = 7;
            GroupBoxInput.TabStop = false;
            GroupBoxInput.Text = "Input";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 174);
            Controls.Add(GroupBoxInput);
            Controls.Add(ButtonDivide);
            Controls.Add(ButtonMultiply);
            Controls.Add(ButtonMinus);
            Controls.Add(ButtonAdd);
            Controls.Add(LabelResult);
            Name = "Form1";
            Text = "Trabajo Práctico 03 - Ejercicio 04";
            GroupBoxInput.ResumeLayout(false);
            GroupBoxInput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxInput0;
        private TextBox TextBoxInput1;
        private Label LabelResult;
        private Button ButtonAdd;
        private Button ButtonMinus;
        private Button ButtonMultiply;
        private Button ButtonDivide;
        private GroupBox GroupBoxInput;
    }
}