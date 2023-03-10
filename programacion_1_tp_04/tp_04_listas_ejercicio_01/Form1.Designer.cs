namespace tp_04_listas_ejercicio_01
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
            ButtonAddPatient = new Button();
            TextBoxName = new TextBox();
            TextBoxSurname = new TextBox();
            TextBoxAddress = new TextBox();
            TextBoxTel = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            DataGridViewPatient = new DataGridView();
            ButtomRemoveSelectedPatient = new Button();
            ButtonUpdatePatient = new Button();
            ButtonShowList = new Button();
            GroupBoxInput = new GroupBox();
            ButtonDummyLoad = new Button();
            ButtonAddAfter = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewPatient).BeginInit();
            GroupBoxInput.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonAddPatient
            // 
            ButtonAddPatient.Location = new Point(478, 97);
            ButtonAddPatient.Name = "ButtonAddPatient";
            ButtonAddPatient.Size = new Size(75, 72);
            ButtonAddPatient.TabIndex = 0;
            ButtonAddPatient.Text = "Registrar paciente";
            ButtonAddPatient.UseVisualStyleBackColor = true;
            ButtonAddPatient.Click += ButtonAddPatient_Click;
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(24, 38);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(100, 23);
            TextBoxName.TabIndex = 4;
            // 
            // TextBoxSurname
            // 
            TextBoxSurname.Location = new Point(130, 38);
            TextBoxSurname.Name = "TextBoxSurname";
            TextBoxSurname.Size = new Size(100, 23);
            TextBoxSurname.TabIndex = 5;
            // 
            // TextBoxAddress
            // 
            TextBoxAddress.Location = new Point(236, 38);
            TextBoxAddress.Name = "TextBoxAddress";
            TextBoxAddress.Size = new Size(100, 23);
            TextBoxAddress.TabIndex = 6;
            // 
            // TextBoxTel
            // 
            TextBoxTel.Location = new Point(342, 38);
            TextBoxTel.Name = "TextBoxTel";
            TextBoxTel.Size = new Size(100, 23);
            TextBoxTel.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 20);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 8;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 20);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 9;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(238, 20);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 10;
            label3.Text = "Dirección";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(342, 20);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 11;
            label4.Text = "Teléfono";
            // 
            // DataGridViewPatient
            // 
            DataGridViewPatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewPatient.Location = new Point(12, 97);
            DataGridViewPatient.Name = "DataGridViewPatient";
            DataGridViewPatient.RowTemplate.Height = 25;
            DataGridViewPatient.Size = new Size(442, 384);
            DataGridViewPatient.TabIndex = 12;
            // 
            // ButtomRemoveSelectedPatient
            // 
            ButtomRemoveSelectedPatient.Location = new Point(559, 97);
            ButtomRemoveSelectedPatient.Name = "ButtomRemoveSelectedPatient";
            ButtomRemoveSelectedPatient.Size = new Size(75, 72);
            ButtomRemoveSelectedPatient.TabIndex = 13;
            ButtomRemoveSelectedPatient.Text = "Eliminar paciente";
            ButtomRemoveSelectedPatient.UseVisualStyleBackColor = true;
            ButtomRemoveSelectedPatient.Click += ButtomRemoveSelectedPatient_Click;
            // 
            // ButtonUpdatePatient
            // 
            ButtonUpdatePatient.Location = new Point(478, 175);
            ButtonUpdatePatient.Name = "ButtonUpdatePatient";
            ButtonUpdatePatient.Size = new Size(75, 72);
            ButtonUpdatePatient.TabIndex = 14;
            ButtonUpdatePatient.Text = "Actualizar paciente";
            ButtonUpdatePatient.UseVisualStyleBackColor = true;
            ButtonUpdatePatient.Click += ButtonUpdatePatient_Click;
            // 
            // ButtonShowList
            // 
            ButtonShowList.Location = new Point(559, 175);
            ButtonShowList.Name = "ButtonShowList";
            ButtonShowList.Size = new Size(75, 72);
            ButtonShowList.TabIndex = 15;
            ButtonShowList.Text = "Actualizar listado";
            ButtonShowList.UseVisualStyleBackColor = true;
            ButtonShowList.Click += ButtonShowList_Click;
            // 
            // GroupBoxInput
            // 
            GroupBoxInput.Controls.Add(TextBoxTel);
            GroupBoxInput.Controls.Add(TextBoxName);
            GroupBoxInput.Controls.Add(TextBoxSurname);
            GroupBoxInput.Controls.Add(TextBoxAddress);
            GroupBoxInput.Controls.Add(label1);
            GroupBoxInput.Controls.Add(label4);
            GroupBoxInput.Controls.Add(label2);
            GroupBoxInput.Controls.Add(label3);
            GroupBoxInput.Location = new Point(12, 12);
            GroupBoxInput.Name = "GroupBoxInput";
            GroupBoxInput.Size = new Size(541, 79);
            GroupBoxInput.TabIndex = 16;
            GroupBoxInput.TabStop = false;
            GroupBoxInput.Text = "Input";
            // 
            // ButtonDummyLoad
            // 
            ButtonDummyLoad.Location = new Point(559, 253);
            ButtonDummyLoad.Name = "ButtonDummyLoad";
            ButtonDummyLoad.Size = new Size(75, 72);
            ButtonDummyLoad.TabIndex = 17;
            ButtonDummyLoad.Text = "Dummy load";
            ButtonDummyLoad.UseVisualStyleBackColor = true;
            ButtonDummyLoad.Click += ButtonDummyLoad_Click;
            // 
            // ButtonAddAfter
            // 
            ButtonAddAfter.Location = new Point(478, 253);
            ButtonAddAfter.Name = "ButtonAddAfter";
            ButtonAddAfter.Size = new Size(75, 72);
            ButtonAddAfter.TabIndex = 18;
            ButtonAddAfter.Text = "Agregar después";
            ButtonAddAfter.UseVisualStyleBackColor = true;
            ButtonAddAfter.Click += ButtonAddAfter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 498);
            Controls.Add(ButtonAddAfter);
            Controls.Add(ButtonDummyLoad);
            Controls.Add(GroupBoxInput);
            Controls.Add(ButtonShowList);
            Controls.Add(ButtonUpdatePatient);
            Controls.Add(ButtomRemoveSelectedPatient);
            Controls.Add(DataGridViewPatient);
            Controls.Add(ButtonAddPatient);
            Name = "Form1";
            Text = "Trabajo Práctico 04 - Listas - Ejercicio 01";
            ((System.ComponentModel.ISupportInitialize)DataGridViewPatient).EndInit();
            GroupBoxInput.ResumeLayout(false);
            GroupBoxInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonAddPatient;
        private TextBox TextBoxName;
        private TextBox TextBoxSurname;
        private TextBox TextBoxAddress;
        private TextBox TextBoxTel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView DataGridViewPatient;
        private Button ButtomRemoveSelectedPatient;
        private Button ButtonUpdatePatient;
        private Button ButtonShowList;
        private GroupBox GroupBoxInput;
        private Button ButtonDummyLoad;
        private Button ButtonAddAfter;
    }
}