namespace Presentacion
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
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            rNo = new RadioButton();
            rSi = new RadioButton();
            btnRegistrar = new Button();
            txtvalorDeclarado = new TextBox();
            label5 = new Label();
            txtFechaPicker = new DateTimePicker();
            label4 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            txtnumeroFormulario = new TextBox();
            label1 = new Label();
            tabPage3 = new TabPage();
            groupBox4 = new GroupBox();
            txtFechav = new TextBox();
            txtValorDeclaradov = new TextBox();
            label12 = new Label();
            groupBox6 = new GroupBox();
            rNov = new RadioButton();
            rSiv = new RadioButton();
            txtTotalDeclarado = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtNombrev = new TextBox();
            label9 = new Label();
            txtIDv = new TextBox();
            label10 = new Label();
            txtNum = new TextBox();
            label11 = new Label();
            groupBox3 = new GroupBox();
            txtBuscar = new TextBox();
            grillaDatos = new DataGridView();
            label6 = new Label();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaDatos).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(49, 16);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(901, 751);
            tabControl1.TabIndex = 3;
            tabControl1.Click += tabControl1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(893, 718);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Formulario";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(txtvalorDeclarado);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtFechaPicker);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtnumeroFormulario);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 9);
            groupBox1.Margin = new Padding(3, 5, 3, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 5, 3, 5);
            groupBox1.Size = new Size(887, 708);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fromulario del impuesto de Avisos y tableros";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rNo);
            groupBox2.Controls.Add(rSi);
            groupBox2.Location = new Point(575, 169);
            groupBox2.Margin = new Padding(3, 5, 3, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 5, 3, 5);
            groupBox2.Size = new Size(275, 81);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Emplazamiento:";
            // 
            // rNo
            // 
            rNo.AutoSize = true;
            rNo.Checked = true;
            rNo.Location = new Point(145, 37);
            rNo.Margin = new Padding(3, 5, 3, 5);
            rNo.Name = "rNo";
            rNo.Size = new Size(50, 24);
            rNo.TabIndex = 1;
            rNo.TabStop = true;
            rNo.Text = "No";
            rNo.UseVisualStyleBackColor = true;
            // 
            // rSi
            // 
            rSi.AutoSize = true;
            rSi.Location = new Point(19, 37);
            rSi.Margin = new Padding(3, 5, 3, 5);
            rSi.Name = "rSi";
            rSi.Size = new Size(42, 24);
            rSi.TabIndex = 0;
            rSi.Text = "Si";
            rSi.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(417, 452);
            btnRegistrar.Margin = new Padding(3, 5, 3, 5);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(98, 41);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click_1;
            // 
            // txtvalorDeclarado
            // 
            txtvalorDeclarado.Location = new Point(575, 316);
            txtvalorDeclarado.Margin = new Padding(3, 5, 3, 5);
            txtvalorDeclarado.Name = "txtvalorDeclarado";
            txtvalorDeclarado.Size = new Size(287, 27);
            txtvalorDeclarado.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(575, 261);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 8;
            label5.Text = "Valor Declarado:";
            // 
            // txtFechaPicker
            // 
            txtFechaPicker.Location = new Point(575, 111);
            txtFechaPicker.Margin = new Padding(3, 5, 3, 5);
            txtFechaPicker.Name = "txtFechaPicker";
            txtFechaPicker.Size = new Size(287, 27);
            txtFechaPicker.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(575, 79);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 6;
            label4.Text = "Fecha: ";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(97, 316);
            txtNombre.Margin = new Padding(3, 5, 3, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(287, 27);
            txtNombre.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 284);
            label3.Name = "label3";
            label3.Size = new Size(159, 20);
            label3.TabIndex = 4;
            label3.Text = "Nombre(Razón Social)";
            // 
            // txtID
            // 
            txtID.Location = new Point(97, 209);
            txtID.Margin = new Padding(3, 5, 3, 5);
            txtID.Name = "txtID";
            txtID.Size = new Size(287, 27);
            txtID.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 169);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 2;
            label2.Text = "Identificación (NIT):";
            // 
            // txtnumeroFormulario
            // 
            txtnumeroFormulario.Location = new Point(267, 73);
            txtnumeroFormulario.Margin = new Padding(3, 5, 3, 5);
            txtnumeroFormulario.Name = "txtnumeroFormulario";
            txtnumeroFormulario.Size = new Size(116, 27);
            txtnumeroFormulario.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 79);
            label1.Name = "label1";
            label1.Size = new Size(163, 20);
            label1.TabIndex = 0;
            label1.Text = "Numero de Formulario:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox4);
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(893, 718);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Visualizar";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtFechav);
            groupBox4.Controls.Add(txtValorDeclaradov);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(groupBox6);
            groupBox4.Controls.Add(txtTotalDeclarado);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(txtNombrev);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(txtIDv);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(txtNum);
            groupBox4.Controls.Add(label11);
            groupBox4.Enabled = false;
            groupBox4.Location = new Point(18, 369);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(855, 331);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Visualizar";
            // 
            // txtFechav
            // 
            txtFechav.Location = new Point(587, 55);
            txtFechav.Margin = new Padding(3, 5, 3, 5);
            txtFechav.Name = "txtFechav";
            txtFechav.Size = new Size(287, 27);
            txtFechav.TabIndex = 27;
            // 
            // txtValorDeclaradov
            // 
            txtValorDeclaradov.Location = new Point(581, 239);
            txtValorDeclaradov.Margin = new Padding(3, 4, 3, 4);
            txtValorDeclaradov.Name = "txtValorDeclaradov";
            txtValorDeclaradov.Size = new Size(252, 27);
            txtValorDeclaradov.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(587, 207);
            label12.Name = "label12";
            label12.Size = new Size(117, 20);
            label12.TabIndex = 23;
            label12.Text = "Valor declarado:";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(rNov);
            groupBox6.Controls.Add(rSiv);
            groupBox6.Location = new Point(587, 113);
            groupBox6.Margin = new Padding(3, 5, 3, 5);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 5, 3, 5);
            groupBox6.Size = new Size(275, 81);
            groupBox6.TabIndex = 22;
            groupBox6.TabStop = false;
            groupBox6.Text = "Emplazamiento:";
            groupBox6.Visible = false;
            // 
            // rNov
            // 
            rNov.AutoSize = true;
            rNov.Location = new Point(145, 37);
            rNov.Margin = new Padding(3, 5, 3, 5);
            rNov.Name = "rNov";
            rNov.Size = new Size(50, 24);
            rNov.TabIndex = 1;
            rNov.Text = "No";
            rNov.UseVisualStyleBackColor = true;
            // 
            // rSiv
            // 
            rSiv.AutoSize = true;
            rSiv.Location = new Point(19, 37);
            rSiv.Margin = new Padding(3, 5, 3, 5);
            rSiv.Name = "rSiv";
            rSiv.Size = new Size(42, 24);
            rSiv.TabIndex = 0;
            rSiv.Text = "Si";
            rSiv.UseVisualStyleBackColor = true;
            // 
            // txtTotalDeclarado
            // 
            txtTotalDeclarado.Location = new Point(330, 368);
            txtTotalDeclarado.Margin = new Padding(3, 5, 3, 5);
            txtTotalDeclarado.Name = "txtTotalDeclarado";
            txtTotalDeclarado.Size = new Size(287, 27);
            txtTotalDeclarado.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(415, 336);
            label7.Name = "label7";
            label7.Size = new Size(116, 20);
            label7.TabIndex = 20;
            label7.Text = "Total declarado:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(587, 23);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 18;
            label8.Text = "Fecha: ";
            // 
            // txtNombrev
            // 
            txtNombrev.Location = new Point(110, 239);
            txtNombrev.Margin = new Padding(3, 5, 3, 5);
            txtNombrev.Name = "txtNombrev";
            txtNombrev.Size = new Size(287, 27);
            txtNombrev.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(110, 207);
            label9.Name = "label9";
            label9.Size = new Size(159, 20);
            label9.TabIndex = 16;
            label9.Text = "Nombre(Razón Social)";
            // 
            // txtIDv
            // 
            txtIDv.Location = new Point(110, 132);
            txtIDv.Margin = new Padding(3, 5, 3, 5);
            txtIDv.Name = "txtIDv";
            txtIDv.Size = new Size(287, 27);
            txtIDv.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(110, 91);
            label10.Name = "label10";
            label10.Size = new Size(139, 20);
            label10.TabIndex = 14;
            label10.Text = "Identificación (NIT):";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(281, 32);
            txtNum.Margin = new Padding(3, 5, 3, 5);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(116, 27);
            txtNum.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(102, 37);
            label11.Name = "label11";
            label11.Size = new Size(163, 20);
            label11.TabIndex = 12;
            label11.Text = "Numero de Formulario:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtBuscar);
            groupBox3.Controls.Add(grillaDatos);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(18, 0);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(855, 361);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lista de Registros";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(291, 43);
            txtBuscar.Margin = new Padding(3, 5, 3, 5);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(258, 27);
            txtBuscar.TabIndex = 3;
            // 
            // grillaDatos
            // 
            grillaDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaDatos.Location = new Point(40, 94);
            grillaDatos.Margin = new Padding(3, 4, 3, 4);
            grillaDatos.Name = "grillaDatos";
            grillaDatos.RowHeadersWidth = 51;
            grillaDatos.RowTemplate.Height = 25;
            grillaDatos.Size = new Size(794, 236);
            grillaDatos.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 53);
            label6.Name = "label6";
            label6.Size = new Size(232, 20);
            label6.TabIndex = 2;
            label6.Text = "Buscar por número de formulario:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 783);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grillaDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private TextBox txtnumeroFormulario;
        private Label label1;
        private TextBox txtvalorDeclarado;
        private Label label5;
        private DateTimePicker txtFechaPicker;
        private Label label4;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtID;
        private Label label2;
        private GroupBox groupBox2;
        private RadioButton rNo;
        private RadioButton rSi;
        private Button btnRegistrar;
        private TabPage tabPage3;
        private GroupBox groupBox4;
        private GroupBox groupBox6;
        private RadioButton rNov;
        private RadioButton rSiv;
        private TextBox txtTotalDeclarado;
        private Label label7;
        private Label label8;
        private TextBox txtNombrev;
        private Label label9;
        private TextBox txtIDv;
        private Label label10;
        private TextBox txtNum;
        private Label label11;
        private GroupBox groupBox3;
        private TextBox txtBuscar;
        private DataGridView grillaDatos;
        private Label label6;
        private TextBox txtValorDeclaradov;
        private Label label12;
        private TextBox txtFechav;
    }
}