namespace ColoreoGrafos
{
    partial class Form1
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
            this.AgregarNodo = new System.Windows.Forms.Button();
            this.xEntry = new System.Windows.Forms.TextBox();
            this.Canvas = new System.Windows.Forms.Panel();
            this.yEntry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.origenCombo = new System.Windows.Forms.ComboBox();
            this.IDEntry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AgregarArista = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.destinoCombo = new System.Windows.Forms.ComboBox();
            this.SolucionarGrafo = new System.Windows.Forms.Button();
            this.cantColoresEntry = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AgregarNodo
            // 
            this.AgregarNodo.Location = new System.Drawing.Point(365, 11);
            this.AgregarNodo.Name = "AgregarNodo";
            this.AgregarNodo.Size = new System.Drawing.Size(75, 23);
            this.AgregarNodo.TabIndex = 0;
            this.AgregarNodo.Text = "Agregar";
            this.AgregarNodo.UseVisualStyleBackColor = true;
            this.AgregarNodo.Click += new System.EventHandler(this.AgregarNodo_Click);
            // 
            // xEntry
            // 
            this.xEntry.Location = new System.Drawing.Point(203, 13);
            this.xEntry.Name = "xEntry";
            this.xEntry.Size = new System.Drawing.Size(38, 20);
            this.xEntry.TabIndex = 1;
            // 
            // Canvas
            // 
            this.Canvas.Location = new System.Drawing.Point(15, 120);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(811, 559);
            this.Canvas.TabIndex = 2;
            this.Canvas.Click += new System.EventHandler(this.Canvas_Click);
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            // 
            // yEntry
            // 
            this.yEntry.Location = new System.Drawing.Point(309, 13);
            this.yEntry.Name = "yEntry";
            this.yEntry.Size = new System.Drawing.Size(38, 20);
            this.yEntry.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "X Position:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y Position:";
            // 
            // origenCombo
            // 
            this.origenCombo.FormattingEnabled = true;
            this.origenCombo.Location = new System.Drawing.Point(53, 15);
            this.origenCombo.Name = "origenCombo";
            this.origenCombo.Size = new System.Drawing.Size(121, 21);
            this.origenCombo.TabIndex = 6;
            // 
            // IDEntry
            // 
            this.IDEntry.Location = new System.Drawing.Point(40, 13);
            this.IDEntry.Name = "IDEntry";
            this.IDEntry.Size = new System.Drawing.Size(86, 20);
            this.IDEntry.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.yEntry);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AgregarNodo);
            this.groupBox1.Controls.Add(this.IDEntry);
            this.groupBox1.Controls.Add(this.xEntry);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 39);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nodo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(446, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(349, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "(Para obtener coordenadas se puede hacer click en el canvas del grafo)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AgregarArista);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.destinoCombo);
            this.groupBox2.Controls.Add(this.origenCombo);
            this.groupBox2.Location = new System.Drawing.Point(12, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 42);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arista";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // AgregarArista
            // 
            this.AgregarArista.Location = new System.Drawing.Point(365, 13);
            this.AgregarArista.Name = "AgregarArista";
            this.AgregarArista.Size = new System.Drawing.Size(75, 23);
            this.AgregarArista.TabIndex = 10;
            this.AgregarArista.Text = "Agregar";
            this.AgregarArista.UseVisualStyleBackColor = true;
            this.AgregarArista.Click += new System.EventHandler(this.AgregarArista_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Destino:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Origen:";
            // 
            // destinoCombo
            // 
            this.destinoCombo.FormattingEnabled = true;
            this.destinoCombo.Location = new System.Drawing.Point(232, 18);
            this.destinoCombo.Name = "destinoCombo";
            this.destinoCombo.Size = new System.Drawing.Size(121, 21);
            this.destinoCombo.TabIndex = 7;
            // 
            // SolucionarGrafo
            // 
            this.SolucionarGrafo.Location = new System.Drawing.Point(749, 75);
            this.SolucionarGrafo.Name = "SolucionarGrafo";
            this.SolucionarGrafo.Size = new System.Drawing.Size(75, 23);
            this.SolucionarGrafo.TabIndex = 10;
            this.SolucionarGrafo.Text = "Solucionar";
            this.SolucionarGrafo.UseVisualStyleBackColor = true;
            this.SolucionarGrafo.Click += new System.EventHandler(this.SolucionarGrafo_Click);
            // 
            // cantColoresEntry
            // 
            this.cantColoresEntry.Location = new System.Drawing.Point(688, 75);
            this.cantColoresEntry.Name = "cantColoresEntry";
            this.cantColoresEntry.Size = new System.Drawing.Size(55, 20);
            this.cantColoresEntry.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(510, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cantidad de colores por utilizar:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(510, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tiempo de ejecucion (ms) :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 688);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cantColoresEntry);
            this.Controls.Add(this.SolucionarGrafo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AgregarNodo;
        private System.Windows.Forms.TextBox xEntry;
        private System.Windows.Forms.Panel Canvas;
        private System.Windows.Forms.TextBox yEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox origenCombo;
        private System.Windows.Forms.TextBox IDEntry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AgregarArista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox destinoCombo;
        private System.Windows.Forms.Button SolucionarGrafo;
        private System.Windows.Forms.TextBox cantColoresEntry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

