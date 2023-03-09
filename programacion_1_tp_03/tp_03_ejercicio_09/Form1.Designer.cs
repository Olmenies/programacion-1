namespace tp_03_ejercicio_09
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
            DataGridViewResults = new DataGridView();
            ButtonCalculate = new Button();
            LabelResult = new Label();
            LabelThrow = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridViewResults).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewResults
            // 
            DataGridViewResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewResults.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridViewResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewResults.Location = new Point(12, 12);
            DataGridViewResults.Name = "DataGridViewResults";
            DataGridViewResults.RowTemplate.Height = 25;
            DataGridViewResults.Size = new Size(375, 211);
            DataGridViewResults.TabIndex = 0;
            // 
            // ButtonCalculate
            // 
            ButtonCalculate.Location = new Point(12, 229);
            ButtonCalculate.Name = "ButtonCalculate";
            ButtonCalculate.Size = new Size(186, 100);
            ButtonCalculate.TabIndex = 1;
            ButtonCalculate.Text = "Throw dice";
            ButtonCalculate.UseVisualStyleBackColor = true;
            ButtonCalculate.Click += ButtonCalculate_Click;
            // 
            // LabelResult
            // 
            LabelResult.AutoSize = true;
            LabelResult.Location = new Point(204, 229);
            LabelResult.Name = "LabelResult";
            LabelResult.Size = new Size(33, 15);
            LabelResult.TabIndex = 4;
            LabelResult.Text = "Dice:";
            // 
            // LabelThrow
            // 
            LabelThrow.AutoSize = true;
            LabelThrow.Location = new Point(204, 314);
            LabelThrow.Name = "LabelThrow";
            LabelThrow.Size = new Size(58, 15);
            LabelThrow.TabIndex = 5;
            LabelThrow.Text = "Throwns: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 347);
            Controls.Add(LabelThrow);
            Controls.Add(LabelResult);
            Controls.Add(ButtonCalculate);
            Controls.Add(DataGridViewResults);
            Name = "Form1";
            Text = "Trabajo Práctico 03 - Ejercicio 09";
            ((System.ComponentModel.ISupportInitialize)DataGridViewResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridViewResults;
        private Button ButtonCalculate;
        private Label LabelResult;
        private Label LabelThrow;
    }
}