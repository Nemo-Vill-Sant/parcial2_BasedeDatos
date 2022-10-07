
namespace R_Base_de_Datos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDUI = new System.Windows.Forms.Label();
            this.labelSalario = new System.Windows.Forms.Label();
            this.labelAFP = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtAFP = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btInsertar = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.labelISSS = new System.Windows.Forms.Label();
            this.txtISSS = new System.Windows.Forms.TextBox();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.labelNeto = new System.Windows.Forms.Label();
            this.labelAregistro = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btModificar = new System.Windows.Forms.Button();
            this.btVerTodo = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AFP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISSS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Neto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(37, 31);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDUI
            // 
            this.labelDUI.AutoSize = true;
            this.labelDUI.Location = new System.Drawing.Point(37, 66);
            this.labelDUI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDUI.Name = "labelDUI";
            this.labelDUI.Size = new System.Drawing.Size(26, 13);
            this.labelDUI.TabIndex = 1;
            this.labelDUI.Text = "DUI";
            // 
            // labelSalario
            // 
            this.labelSalario.AutoSize = true;
            this.labelSalario.Location = new System.Drawing.Point(37, 102);
            this.labelSalario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(39, 13);
            this.labelSalario.TabIndex = 2;
            this.labelSalario.Text = "Salario";
            // 
            // labelAFP
            // 
            this.labelAFP.AutoSize = true;
            this.labelAFP.Location = new System.Drawing.Point(37, 138);
            this.labelAFP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAFP.Name = "labelAFP";
            this.labelAFP.Size = new System.Drawing.Size(27, 13);
            this.labelAFP.TabIndex = 3;
            this.labelAFP.Text = "AFP";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(107, 31);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(75, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(107, 66);
            this.txtDUI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(75, 20);
            this.txtDUI.TabIndex = 5;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(107, 102);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(75, 20);
            this.txtSalario.TabIndex = 6;
            // 
            // txtAFP
            // 
            this.txtAFP.Location = new System.Drawing.Point(107, 138);
            this.txtAFP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAFP.Name = "txtAFP";
            this.txtAFP.Size = new System.Drawing.Size(75, 20);
            this.txtAFP.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btInsertar
            // 
            this.btInsertar.Location = new System.Drawing.Point(229, 209);
            this.btInsertar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btInsertar.Name = "btInsertar";
            this.btInsertar.Size = new System.Drawing.Size(97, 27);
            this.btInsertar.TabIndex = 9;
            this.btInsertar.Text = "Insertar Registro";
            this.btInsertar.UseVisualStyleBackColor = true;
            this.btInsertar.Click += new System.EventHandler(this.btInsertar_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(285, 17);
            this.btConsultar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(71, 27);
            this.btConsultar.TabIndex = 10;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // labelISSS
            // 
            this.labelISSS.AutoSize = true;
            this.labelISSS.Location = new System.Drawing.Point(37, 175);
            this.labelISSS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelISSS.Name = "labelISSS";
            this.labelISSS.Size = new System.Drawing.Size(31, 13);
            this.labelISSS.TabIndex = 14;
            this.labelISSS.Text = "ISSS";
            // 
            // txtISSS
            // 
            this.txtISSS.Location = new System.Drawing.Point(107, 174);
            this.txtISSS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtISSS.Name = "txtISSS";
            this.txtISSS.Size = new System.Drawing.Size(75, 20);
            this.txtISSS.TabIndex = 16;
            // 
            // txtNeto
            // 
            this.txtNeto.Location = new System.Drawing.Point(107, 207);
            this.txtNeto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.Size = new System.Drawing.Size(75, 20);
            this.txtNeto.TabIndex = 17;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(107, 240);
            this.btLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(71, 27);
            this.btLimpiar.TabIndex = 18;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // labelNeto
            // 
            this.labelNeto.AutoSize = true;
            this.labelNeto.Location = new System.Drawing.Point(37, 209);
            this.labelNeto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNeto.Name = "labelNeto";
            this.labelNeto.Size = new System.Drawing.Size(30, 13);
            this.labelNeto.TabIndex = 19;
            this.labelNeto.Text = "Neto";
            // 
            // labelAregistro
            // 
            this.labelAregistro.AutoSize = true;
            this.labelAregistro.Location = new System.Drawing.Point(205, 247);
            this.labelAregistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAregistro.Name = "labelAregistro";
            this.labelAregistro.Size = new System.Drawing.Size(0, 13);
            this.labelAregistro.TabIndex = 22;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(373, 21);
            this.txtConsulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(65, 20);
            this.txtConsulta.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Dui,
            this.Salario,
            this.AFP,
            this.ISSS,
            this.Neto});
            this.dataGridView1.Location = new System.Drawing.Point(229, 48);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(406, 121);
            this.dataGridView1.TabIndex = 24;
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(417, 209);
            this.btModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(73, 27);
            this.btModificar.TabIndex = 26;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btVerTodo
            // 
            this.btVerTodo.Location = new System.Drawing.Point(546, 14);
            this.btVerTodo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btVerTodo.Name = "btVerTodo";
            this.btVerTodo.Size = new System.Drawing.Size(89, 27);
            this.btVerTodo.TabIndex = 27;
            this.btVerTodo.Text = "Ver Todo";
            this.btVerTodo.UseVisualStyleBackColor = true;
            this.btVerTodo.Click += new System.EventHandler(this.btVerTodo_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Width = 30;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 80;
            // 
            // Dui
            // 
            this.Dui.HeaderText = "Dui";
            this.Dui.MinimumWidth = 8;
            this.Dui.Name = "Dui";
            this.Dui.Width = 80;
            // 
            // Salario
            // 
            this.Salario.HeaderText = "Salario";
            this.Salario.MinimumWidth = 8;
            this.Salario.Name = "Salario";
            this.Salario.Width = 45;
            // 
            // AFP
            // 
            this.AFP.HeaderText = "AFP";
            this.AFP.MinimumWidth = 8;
            this.AFP.Name = "AFP";
            this.AFP.Width = 35;
            // 
            // ISSS
            // 
            this.ISSS.HeaderText = "ISSS";
            this.ISSS.MinimumWidth = 8;
            this.ISSS.Name = "ISSS";
            this.ISSS.Width = 37;
            // 
            // Neto
            // 
            this.Neto.HeaderText = "Neto";
            this.Neto.MinimumWidth = 8;
            this.Neto.Name = "Neto";
            this.Neto.Width = 35;
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(534, 209);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 27);
            this.btEliminar.TabIndex = 28;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 278);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btVerTodo);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.labelAregistro);
            this.Controls.Add(this.labelNeto);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.txtNeto);
            this.Controls.Add(this.txtISSS);
            this.Controls.Add(this.labelISSS);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.btInsertar);
            this.Controls.Add(this.txtAFP);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelAFP);
            this.Controls.Add(this.labelSalario);
            this.Controls.Add(this.labelDUI);
            this.Controls.Add(this.labelNombre);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Registro Bases de Datos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDUI;
        private System.Windows.Forms.Label labelSalario;
        private System.Windows.Forms.Label labelAFP;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtAFP;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btInsertar;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.TextBox txtNeto;
        private System.Windows.Forms.TextBox txtISSS;
        private System.Windows.Forms.Label labelISSS;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Label labelNeto;
        private System.Windows.Forms.Label labelAregistro;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btVerTodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dui;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn AFP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISSS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Neto;
        private System.Windows.Forms.Button btEliminar;
    }
}

