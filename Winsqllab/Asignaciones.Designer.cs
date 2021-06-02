namespace Winsqllab
{
    partial class Asignaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.botonAgregaHorario = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxProfesor = new System.Windows.Forms.ListBox();
            this.listBoxMateria = new System.Windows.Forms.ListBox();
            this.listBoxHora = new System.Windows.Forms.ListBox();
            this.listBoxDia = new System.Windows.Forms.ListBox();
            this.listBoxLaboratorio = new System.Windows.Forms.ListBox();
            this.listBoxGrupo = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnModificR = new System.Windows.Forms.Button();
            this.comboDocente = new System.Windows.Forms.ComboBox();
            this.comboMateria = new System.Windows.Forms.ComboBox();
            this.comboHora = new System.Windows.Forms.ComboBox();
            this.comboDia = new System.Windows.Forms.ComboBox();
            this.comboLabo = new System.Windows.Forms.ComboBox();
            this.comboGrupo = new System.Windows.Forms.ComboBox();
            this.listTodasAsigna = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1241, 625);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPage1.Controls.Add(this.botonAgregaHorario);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.listBoxProfesor);
            this.tabPage1.Controls.Add(this.listBoxMateria);
            this.tabPage1.Controls.Add(this.listBoxHora);
            this.tabPage1.Controls.Add(this.listBoxDia);
            this.tabPage1.Controls.Add(this.listBoxLaboratorio);
            this.tabPage1.Controls.Add(this.listBoxGrupo);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1233, 590);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar horario";
            // 
            // botonAgregaHorario
            // 
            this.botonAgregaHorario.Location = new System.Drawing.Point(453, 472);
            this.botonAgregaHorario.Name = "botonAgregaHorario";
            this.botonAgregaHorario.Size = new System.Drawing.Size(195, 65);
            this.botonAgregaHorario.TabIndex = 14;
            this.botonAgregaHorario.Text = "Asignar laboratorio";
            this.botonAgregaHorario.UseVisualStyleBackColor = true;
            this.botonAgregaHorario.Click += new System.EventHandler(this.botonAgregaHorario_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(807, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Docente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Materia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(840, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Laboratorio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Grupo:";
            // 
            // listBoxProfesor
            // 
            this.listBoxProfesor.FormattingEnabled = true;
            this.listBoxProfesor.ItemHeight = 22;
            this.listBoxProfesor.Location = new System.Drawing.Point(811, 270);
            this.listBoxProfesor.Name = "listBoxProfesor";
            this.listBoxProfesor.Size = new System.Drawing.Size(387, 136);
            this.listBoxProfesor.TabIndex = 6;
            // 
            // listBoxMateria
            // 
            this.listBoxMateria.FormattingEnabled = true;
            this.listBoxMateria.ItemHeight = 22;
            this.listBoxMateria.Location = new System.Drawing.Point(436, 270);
            this.listBoxMateria.Name = "listBoxMateria";
            this.listBoxMateria.Size = new System.Drawing.Size(351, 136);
            this.listBoxMateria.TabIndex = 5;
            // 
            // listBoxHora
            // 
            this.listBoxHora.FormattingEnabled = true;
            this.listBoxHora.ItemHeight = 22;
            this.listBoxHora.Location = new System.Drawing.Point(239, 270);
            this.listBoxHora.Name = "listBoxHora";
            this.listBoxHora.Size = new System.Drawing.Size(165, 136);
            this.listBoxHora.TabIndex = 4;
            // 
            // listBoxDia
            // 
            this.listBoxDia.FormattingEnabled = true;
            this.listBoxDia.ItemHeight = 22;
            this.listBoxDia.Location = new System.Drawing.Point(21, 270);
            this.listBoxDia.Name = "listBoxDia";
            this.listBoxDia.Size = new System.Drawing.Size(187, 136);
            this.listBoxDia.TabIndex = 3;
            // 
            // listBoxLaboratorio
            // 
            this.listBoxLaboratorio.FormattingEnabled = true;
            this.listBoxLaboratorio.ItemHeight = 22;
            this.listBoxLaboratorio.Location = new System.Drawing.Point(844, 48);
            this.listBoxLaboratorio.Name = "listBoxLaboratorio";
            this.listBoxLaboratorio.Size = new System.Drawing.Size(323, 136);
            this.listBoxLaboratorio.TabIndex = 2;
            // 
            // listBoxGrupo
            // 
            this.listBoxGrupo.FormattingEnabled = true;
            this.listBoxGrupo.ItemHeight = 22;
            this.listBoxGrupo.Location = new System.Drawing.Point(21, 48);
            this.listBoxGrupo.Name = "listBoxGrupo";
            this.listBoxGrupo.Size = new System.Drawing.Size(793, 136);
            this.listBoxGrupo.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.btnModificR);
            this.tabPage2.Controls.Add(this.comboDocente);
            this.tabPage2.Controls.Add(this.comboMateria);
            this.tabPage2.Controls.Add(this.comboHora);
            this.tabPage2.Controls.Add(this.comboDia);
            this.tabPage2.Controls.Add(this.comboLabo);
            this.tabPage2.Controls.Add(this.comboGrupo);
            this.tabPage2.Controls.Add(this.listTodasAsigna);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1233, 590);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Eliminar / modificar horario";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(746, 446);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 22);
            this.label12.TabIndex = 21;
            this.label12.Text = "Docente:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(413, 446);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 22);
            this.label11.TabIndex = 20;
            this.label11.Text = "Materia:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(221, 446);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 22);
            this.label10.TabIndex = 19;
            this.label10.Text = "Horario:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 446);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "Dia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(823, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 22);
            this.label8.TabIndex = 17;
            this.label8.Text = "Aula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Grupo:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(551, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 67);
            this.button2.TabIndex = 8;
            this.button2.Text = "Eliminar horario";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnModificR
            // 
            this.btnModificR.Location = new System.Drawing.Point(551, 521);
            this.btnModificR.Name = "btnModificR";
            this.btnModificR.Size = new System.Drawing.Size(140, 58);
            this.btnModificR.TabIndex = 7;
            this.btnModificR.Text = "Modificar horario";
            this.btnModificR.UseVisualStyleBackColor = true;
            this.btnModificR.Click += new System.EventHandler(this.btnModificR_Click);
            // 
            // comboDocente
            // 
            this.comboDocente.FormattingEnabled = true;
            this.comboDocente.Location = new System.Drawing.Point(750, 471);
            this.comboDocente.Name = "comboDocente";
            this.comboDocente.Size = new System.Drawing.Size(362, 30);
            this.comboDocente.TabIndex = 6;
            this.comboDocente.Text = "-Selecciona docente-";
            // 
            // comboMateria
            // 
            this.comboMateria.FormattingEnabled = true;
            this.comboMateria.Location = new System.Drawing.Point(417, 471);
            this.comboMateria.Name = "comboMateria";
            this.comboMateria.Size = new System.Drawing.Size(319, 30);
            this.comboMateria.TabIndex = 5;
            this.comboMateria.Text = "-Selecciona materia-";
            // 
            // comboHora
            // 
            this.comboHora.FormattingEnabled = true;
            this.comboHora.Location = new System.Drawing.Point(225, 471);
            this.comboHora.Name = "comboHora";
            this.comboHora.Size = new System.Drawing.Size(170, 30);
            this.comboHora.TabIndex = 4;
            this.comboHora.Text = "-Selecciona hora-";
            // 
            // comboDia
            // 
            this.comboDia.FormattingEnabled = true;
            this.comboDia.Location = new System.Drawing.Point(79, 471);
            this.comboDia.Name = "comboDia";
            this.comboDia.Size = new System.Drawing.Size(121, 30);
            this.comboDia.TabIndex = 3;
            this.comboDia.Text = "-Selecciona día-";
            // 
            // comboLabo
            // 
            this.comboLabo.FormattingEnabled = true;
            this.comboLabo.Location = new System.Drawing.Point(827, 392);
            this.comboLabo.Name = "comboLabo";
            this.comboLabo.Size = new System.Drawing.Size(235, 30);
            this.comboLabo.TabIndex = 2;
            this.comboLabo.Text = "-Selecciona aula-";
            // 
            // comboGrupo
            // 
            this.comboGrupo.FormattingEnabled = true;
            this.comboGrupo.Location = new System.Drawing.Point(91, 392);
            this.comboGrupo.Name = "comboGrupo";
            this.comboGrupo.Size = new System.Drawing.Size(666, 30);
            this.comboGrupo.TabIndex = 1;
            this.comboGrupo.Text = "-Selecciona grupo-";
            // 
            // listTodasAsigna
            // 
            this.listTodasAsigna.FormattingEnabled = true;
            this.listTodasAsigna.ItemHeight = 22;
            this.listTodasAsigna.Location = new System.Drawing.Point(18, 18);
            this.listTodasAsigna.Name = "listTodasAsigna";
            this.listTodasAsigna.Size = new System.Drawing.Size(1199, 246);
            this.listTodasAsigna.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1233, 590);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Consulta horario";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(326, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 22);
            this.label13.TabIndex = 2;
            this.label13.Text = "Periodo: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(432, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(467, 30);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1197, 467);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1113, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Asignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1265, 697);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Asignaciones";
            this.Text = "Asignaciones";
            this.Load += new System.EventHandler(this.Asignaciones_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button botonAgregaHorario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxProfesor;
        private System.Windows.Forms.ListBox listBoxMateria;
        private System.Windows.Forms.ListBox listBoxHora;
        private System.Windows.Forms.ListBox listBoxDia;
        private System.Windows.Forms.ListBox listBoxLaboratorio;
        private System.Windows.Forms.ListBox listBoxGrupo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listTodasAsigna;
        private System.Windows.Forms.ComboBox comboDocente;
        private System.Windows.Forms.ComboBox comboMateria;
        private System.Windows.Forms.ComboBox comboHora;
        private System.Windows.Forms.ComboBox comboDia;
        private System.Windows.Forms.ComboBox comboLabo;
        private System.Windows.Forms.ComboBox comboGrupo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnModificR;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}