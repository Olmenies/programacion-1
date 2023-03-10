namespace tp_03_ejercicio_10
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
            GroupBoxRadioButtons = new GroupBox();
            RadioButtonKelvin = new RadioButton();
            RadioButtonF = new RadioButton();
            RadioButtonC = new RadioButton();
            DataGridViewResults = new DataGridView();
            TextBoxInput = new TextBox();
            ButtonConvert = new Button();
            GroupBoxRadioButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewResults).BeginInit();
            SuspendLayout();
            // 
            // GroupBoxRadioButtons
            // 
            GroupBoxRadioButtons.Controls.Add(RadioButtonKelvin);
            GroupBoxRadioButtons.Controls.Add(RadioButtonF);
            GroupBoxRadioButtons.Controls.Add(RadioButtonC);
            GroupBoxRadioButtons.Location = new Point(12, 12);
            GroupBoxRadioButtons.Name = "GroupBoxRadioButtons";
            GroupBoxRadioButtons.Size = new Size(277, 57);
            GroupBoxRadioButtons.TabIndex = 0;
            GroupBoxRadioButtons.TabStop = false;
            GroupBoxRadioButtons.Text = "Select scale";
            // 
            // RadioButtonKelvin
            // 
            RadioButtonKelvin.AutoSize = true;
            RadioButtonKelvin.Location = new Point(161, 19);
            RadioButtonKelvin.Name = "RadioButtonKelvin";
            RadioButtonKelvin.Size = new Size(57, 19);
            RadioButtonKelvin.TabIndex = 2;
            RadioButtonKelvin.TabStop = true;
            RadioButtonKelvin.Text = "Kelvin";
            RadioButtonKelvin.UseVisualStyleBackColor = true;
            // 
            // RadioButtonF
            // 
            RadioButtonF.AutoSize = true;
            RadioButtonF.Location = new Point(74, 19);
            RadioButtonF.Name = "RadioButtonF";
            RadioButtonF.Size = new Size(81, 19);
            RadioButtonF.TabIndex = 1;
            RadioButtonF.TabStop = true;
            RadioButtonF.Text = "Fahrenheit";
            RadioButtonF.UseVisualStyleBackColor = true;
            // 
            // RadioButtonC
            // 
            RadioButtonC.AutoSize = true;
            RadioButtonC.Location = new Point(6, 19);
            RadioButtonC.Name = "RadioButtonC";
            RadioButtonC.Size = new Size(62, 19);
            RadioButtonC.TabIndex = 0;
            RadioButtonC.TabStop = true;
            RadioButtonC.Text = "Celsius";
            RadioButtonC.UseVisualStyleBackColor = true;
            // 
            // DataGridViewResults
            // 
            DataGridViewResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewResults.Location = new Point(12, 75);
            DataGridViewResults.Name = "DataGridViewResults";
            DataGridViewResults.RowTemplate.Height = 25;
            DataGridViewResults.Size = new Size(488, 363);
            DataGridViewResults.TabIndex = 1;
            // 
            // TextBoxInput
            // 
            TextBoxInput.Location = new Point(304, 17);
            TextBoxInput.Name = "TextBoxInput";
            TextBoxInput.Size = new Size(100, 23);
            TextBoxInput.TabIndex = 2;
            // 
            // ButtonConvert
            // 
            ButtonConvert.Location = new Point(304, 46);
            ButtonConvert.Name = "ButtonConvert";
            ButtonConvert.Size = new Size(100, 23);
            ButtonConvert.TabIndex = 3;
            ButtonConvert.Text = "Convert";
            ButtonConvert.UseVisualStyleBackColor = true;
            ButtonConvert.Click += ButtonConvert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 450);
            Controls.Add(ButtonConvert);
            Controls.Add(TextBoxInput);
            Controls.Add(DataGridViewResults);
            Controls.Add(GroupBoxRadioButtons);
            Name = "Form1";
            Text = "Trabajo Práctico 03 - Ejercicio 10";
            GroupBoxRadioButtons.ResumeLayout(false);
            GroupBoxRadioButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GroupBoxRadioButtons;
        private RadioButton RadioButtonKelvin;
        private RadioButton RadioButtonF;
        private RadioButton RadioButtonC;
        private DataGridView DataGridViewResults;
        private TextBox TextBoxInput;
        private Button ButtonConvert;
    }
}