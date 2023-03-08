namespace tp_03_ejercicio_07
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
            DataGridViewResult = new DataGridView();
            GroupBoxInput = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TextBoxDays = new TextBox();
            TextBoxTNA = new TextBox();
            TextBoxAmount = new TextBox();
            ButtonCalculate = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewResult).BeginInit();
            GroupBoxInput.SuspendLayout();
            SuspendLayout();
            // 
            // DataGridViewResult
            // 
            DataGridViewResult.AllowUserToOrderColumns = true;
            DataGridViewResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewResult.Location = new Point(12, 12);
            DataGridViewResult.Name = "DataGridViewResult";
            DataGridViewResult.RowTemplate.Height = 25;
            DataGridViewResult.Size = new Size(776, 325);
            DataGridViewResult.TabIndex = 0;
            // 
            // GroupBoxInput
            // 
            GroupBoxInput.Controls.Add(label3);
            GroupBoxInput.Controls.Add(label2);
            GroupBoxInput.Controls.Add(label1);
            GroupBoxInput.Controls.Add(TextBoxDays);
            GroupBoxInput.Controls.Add(TextBoxTNA);
            GroupBoxInput.Controls.Add(TextBoxAmount);
            GroupBoxInput.Location = new Point(12, 343);
            GroupBoxInput.Name = "GroupBoxInput";
            GroupBoxInput.Size = new Size(390, 81);
            GroupBoxInput.TabIndex = 1;
            GroupBoxInput.TabStop = false;
            GroupBoxInput.Text = "Input";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 19);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 5;
            label3.Text = "Days";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 19);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 4;
            label2.Text = "TNA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 3;
            label1.Text = "Monto";
            // 
            // TextBoxDays
            // 
            TextBoxDays.Location = new Point(218, 37);
            TextBoxDays.Name = "TextBoxDays";
            TextBoxDays.Size = new Size(100, 23);
            TextBoxDays.TabIndex = 2;
            // 
            // TextBoxTNA
            // 
            TextBoxTNA.Location = new Point(112, 37);
            TextBoxTNA.Name = "TextBoxTNA";
            TextBoxTNA.Size = new Size(100, 23);
            TextBoxTNA.TabIndex = 1;
            // 
            // TextBoxAmount
            // 
            TextBoxAmount.Location = new Point(6, 37);
            TextBoxAmount.Name = "TextBoxAmount";
            TextBoxAmount.Size = new Size(100, 23);
            TextBoxAmount.TabIndex = 0;
            // 
            // ButtonCalculate
            // 
            ButtonCalculate.Location = new Point(624, 353);
            ButtonCalculate.Name = "ButtonCalculate";
            ButtonCalculate.Size = new Size(164, 71);
            ButtonCalculate.TabIndex = 2;
            ButtonCalculate.Text = "Calcular";
            ButtonCalculate.UseVisualStyleBackColor = true;
            ButtonCalculate.Click += ButtonCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 449);
            Controls.Add(ButtonCalculate);
            Controls.Add(GroupBoxInput);
            Controls.Add(DataGridViewResult);
            Name = "Form1";
            Text = "Trabajo Práctico 03 - Ejercicio 07";
            ((System.ComponentModel.ISupportInitialize)DataGridViewResult).EndInit();
            GroupBoxInput.ResumeLayout(false);
            GroupBoxInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridViewResult;
        private DataGridViewTextBoxColumn ColMount;
        private GroupBox GroupBoxInput;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TextBoxDays;
        private TextBox TextBoxTNA;
        private TextBox TextBoxAmount;
        private Button ButtonCalculate;
    }
}