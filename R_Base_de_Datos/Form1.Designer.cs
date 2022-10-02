
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
            this.btGuardar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btInsertar = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.labelISSS = new System.Windows.Forms.Label();
            this.txtISSS = new System.Windows.Forms.TextBox();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.labelNeto = new System.Windows.Forms.Label();
            this.labelRnombre = new System.Windows.Forms.Label();
            this.labelRdui = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(55, 47);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(65, 20);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDUI
            // 
            this.labelDUI.AutoSize = true;
            this.labelDUI.Location = new System.Drawing.Point(55, 102);
            this.labelDUI.Name = "labelDUI";
            this.labelDUI.Size = new System.Drawing.Size(38, 20);
            this.labelDUI.TabIndex = 1;
            this.labelDUI.Text = "DUI";
            // 
            // labelSalario
            // 
            this.labelSalario.AutoSize = true;
            this.labelSalario.Location = new System.Drawing.Point(55, 157);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(58, 20);
            this.labelSalario.TabIndex = 2;
            this.labelSalario.Text = "Salario";
            // 
            // labelAFP
            // 
            this.labelAFP.AutoSize = true;
            this.labelAFP.Location = new System.Drawing.Point(55, 213);
            this.labelAFP.Name = "labelAFP";
            this.labelAFP.Size = new System.Drawing.Size(40, 20);
            this.labelAFP.TabIndex = 3;
            this.labelAFP.Text = "AFP";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(160, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(111, 26);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(160, 102);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(111, 26);
            this.txtDUI.TabIndex = 5;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(160, 157);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(111, 26);
            this.txtSalario.TabIndex = 6;
            // 
            // txtAFP
            // 
            this.txtAFP.Location = new System.Drawing.Point(160, 213);
            this.txtAFP.Name = "txtAFP";
            this.txtAFP.Size = new System.Drawing.Size(111, 26);
            this.txtAFP.TabIndex = 7;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(79, 371);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(97, 41);
            this.btGuardar.TabIndex = 8;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btInsertar
            // 
            this.btInsertar.Location = new System.Drawing.Point(418, 311);
            this.btInsertar.Name = "btInsertar";
            this.btInsertar.Size = new System.Drawing.Size(146, 41);
            this.btInsertar.TabIndex = 9;
            this.btInsertar.Text = "Insertar Registro";
            this.btInsertar.UseVisualStyleBackColor = true;
            this.btInsertar.Click += new System.EventHandler(this.btInsertar_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(617, 311);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(106, 41);
            this.btConsultar.TabIndex = 10;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(617, 270);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(106, 26);
            this.txtConsulta.TabIndex = 11;
            // 
            // labelISSS
            // 
            this.labelISSS.AutoSize = true;
            this.labelISSS.Location = new System.Drawing.Point(55, 270);
            this.labelISSS.Name = "labelISSS";
            this.labelISSS.Size = new System.Drawing.Size(47, 20);
            this.labelISSS.TabIndex = 14;
            this.labelISSS.Text = "ISSS";
            // 
            // txtISSS
            // 
            this.txtISSS.Location = new System.Drawing.Point(160, 267);
            this.txtISSS.Name = "txtISSS";
            this.txtISSS.Size = new System.Drawing.Size(111, 26);
            this.txtISSS.TabIndex = 16;
            // 
            // txtNeto
            // 
            this.txtNeto.Location = new System.Drawing.Point(160, 318);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.Size = new System.Drawing.Size(111, 26);
            this.txtNeto.TabIndex = 17;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(255, 371);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(107, 41);
            this.btLimpiar.TabIndex = 18;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // labelNeto
            // 
            this.labelNeto.AutoSize = true;
            this.labelNeto.Location = new System.Drawing.Point(55, 321);
            this.labelNeto.Name = "labelNeto";
            this.labelNeto.Size = new System.Drawing.Size(43, 20);
            this.labelNeto.TabIndex = 19;
            this.labelNeto.Text = "Neto";
            // 
            // labelRnombre
            // 
            this.labelRnombre.AutoSize = true;
            this.labelRnombre.Location = new System.Drawing.Point(617, 58);
            this.labelRnombre.Name = "labelRnombre";
            this.labelRnombre.Size = new System.Drawing.Size(0, 20);
            this.labelRnombre.TabIndex = 20;
            // 
            // labelRdui
            // 
            this.labelRdui.AutoSize = true;
            this.labelRdui.Location = new System.Drawing.Point(617, 108);
            this.labelRdui.Name = "labelRdui";
            this.labelRdui.Size = new System.Drawing.Size(0, 20);
            this.labelRdui.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.labelRdui);
            this.Controls.Add(this.labelRnombre);
            this.Controls.Add(this.labelNeto);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.txtNeto);
            this.Controls.Add(this.txtISSS);
            this.Controls.Add(this.labelISSS);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.btInsertar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.txtAFP);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelAFP);
            this.Controls.Add(this.labelSalario);
            this.Controls.Add(this.labelDUI);
            this.Controls.Add(this.labelNombre);
            this.Name = "Form1";
            this.Text = "Registro Bases de Datos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btInsertar;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.TextBox txtNeto;
        private System.Windows.Forms.TextBox txtISSS;
        private System.Windows.Forms.Label labelISSS;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Label labelNeto;
        private System.Windows.Forms.Label labelRdui;
        private System.Windows.Forms.Label labelRnombre;
    }
}

