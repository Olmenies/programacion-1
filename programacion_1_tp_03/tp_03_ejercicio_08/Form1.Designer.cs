namespace tp_03_ejercicio_08
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
            LabelResult = new Label();
            ButtonCalculate = new Button();
            SuspendLayout();
            // 
            // LabelResult
            // 
            LabelResult.AutoSize = true;
            LabelResult.Location = new Point(224, 55);
            LabelResult.Name = "LabelResult";
            LabelResult.Size = new Size(0, 15);
            LabelResult.TabIndex = 0;
            // 
            // ButtonCalculate
            // 
            ButtonCalculate.Location = new Point(12, 12);
            ButtonCalculate.Name = "ButtonCalculate";
            ButtonCalculate.Size = new Size(100, 100);
            ButtonCalculate.TabIndex = 1;
            ButtonCalculate.Text = "Tirar dado";
            ButtonCalculate.UseVisualStyleBackColor = true;
            ButtonCalculate.Click += ButtonCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 131);
            Controls.Add(ButtonCalculate);
            Controls.Add(LabelResult);
            Name = "Form1";
            Text = "Trabajo Práctico 03 - Ejercicio 08";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelResult;
        private Button ButtonCalculate;
    }
}