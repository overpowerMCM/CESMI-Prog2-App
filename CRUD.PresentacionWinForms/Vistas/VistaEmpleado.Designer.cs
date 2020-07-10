using System.Windows.Forms;

namespace CRUD.PresentacionWinForms.Vistas
{
    partial class VistaEmpleado
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
            this._dgvListado = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this._tbNombre = new System.Windows.Forms.TextBox();
            this._tbApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._tbLegajo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._puesto = new System.Windows.Forms.Label();
            this._tbDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._cbPuesto = new System.Windows.Forms.ComboBox();
            this._dtPNacimiento = new System.Windows.Forms.DateTimePicker();
            this._dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this._btnInsertOk = new System.Windows.Forms.Button();
            this._btnEditCancel = new System.Windows.Forms.Button();
            this._btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // _dgvListado
            // 
            this._dgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvListado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this._dgvListado.Location = new System.Drawing.Point(13, 13);
            this._dgvListado.MultiSelect = false;
            this._dgvListado.Name = "_dgvListado";
            this._dgvListado.ReadOnly = true;
            this._dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgvListado.Size = new System.Drawing.Size(790, 585);
            this._dgvListado.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(806, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // _tbNombre
            // 
            this._tbNombre.Location = new System.Drawing.Point(809, 26);
            this._tbNombre.Name = "_tbNombre";
            this._tbNombre.Size = new System.Drawing.Size(200, 20);
            this._tbNombre.TabIndex = 2;
            // 
            // _tbApellido
            // 
            this._tbApellido.Location = new System.Drawing.Point(809, 66);
            this._tbApellido.Name = "_tbApellido";
            this._tbApellido.Size = new System.Drawing.Size(200, 20);
            this._tbApellido.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(806, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // _tbLegajo
            // 
            this._tbLegajo.Location = new System.Drawing.Point(809, 106);
            this._tbLegajo.Name = "_tbLegajo";
            this._tbLegajo.Size = new System.Drawing.Size(200, 20);
            this._tbLegajo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(806, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Legajo";
            // 
            // _puesto
            // 
            this._puesto.AutoSize = true;
            this._puesto.Location = new System.Drawing.Point(806, 129);
            this._puesto.Name = "_puesto";
            this._puesto.Size = new System.Drawing.Size(40, 13);
            this._puesto.TabIndex = 7;
            this._puesto.Text = "Puesto";
            // 
            // _tbDNI
            // 
            this._tbDNI.Location = new System.Drawing.Point(809, 186);
            this._tbDNI.Name = "_tbDNI";
            this._tbDNI.Size = new System.Drawing.Size(200, 20);
            this._tbDNI.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(806, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "DNI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(806, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha de Nacimiento";
            // 
            // _cbPuesto
            // 
            this._cbPuesto.FormattingEnabled = true;
            this._cbPuesto.Location = new System.Drawing.Point(809, 145);
            this._cbPuesto.Name = "_cbPuesto";
            this._cbPuesto.Size = new System.Drawing.Size(200, 21);
            this._cbPuesto.TabIndex = 15;
            // 
            // _dtPNacimiento
            // 
            this._dtPNacimiento.Location = new System.Drawing.Point(809, 225);
            this._dtPNacimiento.Name = "_dtPNacimiento";
            this._dtPNacimiento.Size = new System.Drawing.Size(200, 20);
            this._dtPNacimiento.TabIndex = 16;
            // 
            // _dtpIngreso
            // 
            this._dtpIngreso.Location = new System.Drawing.Point(809, 265);
            this._dtpIngreso.Name = "_dtpIngreso";
            this._dtpIngreso.Size = new System.Drawing.Size(200, 20);
            this._dtpIngreso.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(806, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fecha de Ingreso";
            // 
            // _btnInsertOk
            // 
            this._btnInsertOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnInsertOk.Location = new System.Drawing.Point(13, 605);
            this._btnInsertOk.Name = "_btnInsertOk";
            this._btnInsertOk.Size = new System.Drawing.Size(75, 23);
            this._btnInsertOk.TabIndex = 19;
            this._btnInsertOk.Text = "Nuevo";
            this._btnInsertOk.UseVisualStyleBackColor = true;
            // 
            // _btnEditCancel
            // 
            this._btnEditCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnEditCancel.Location = new System.Drawing.Point(95, 605);
            this._btnEditCancel.Name = "_btnEditCancel";
            this._btnEditCancel.Size = new System.Drawing.Size(75, 23);
            this._btnEditCancel.TabIndex = 20;
            this._btnEditCancel.Text = "Editar";
            this._btnEditCancel.UseVisualStyleBackColor = true;
            // 
            // _btnBorrar
            // 
            this._btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnBorrar.Location = new System.Drawing.Point(177, 605);
            this._btnBorrar.Name = "_btnBorrar";
            this._btnBorrar.Size = new System.Drawing.Size(75, 23);
            this._btnBorrar.TabIndex = 21;
            this._btnBorrar.Text = "Borrar";
            this._btnBorrar.UseVisualStyleBackColor = true;
            // 
            // VistaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1019, 634);
            this.Controls.Add(this._btnBorrar);
            this.Controls.Add(this._btnEditCancel);
            this.Controls.Add(this._btnInsertOk);
            this.Controls.Add(this._dtpIngreso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._dtPNacimiento);
            this.Controls.Add(this._cbPuesto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._tbDNI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._puesto);
            this.Controls.Add(this._tbLegajo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._tbApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._tbNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._dgvListado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VistaEmpleado";
            this.Text = "VistaEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this._dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label _puesto;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.DataGridView _dgvListado;

        private System.Windows.Forms.TextBox _tbNombre;
        private System.Windows.Forms.TextBox _tbApellido;
        private System.Windows.Forms.TextBox _tbLegajo;
        private System.Windows.Forms.TextBox _tbDNI;

        private System.Windows.Forms.ComboBox _cbPuesto;

        private System.Windows.Forms.DateTimePicker _dtPNacimiento;
        private System.Windows.Forms.DateTimePicker _dtpIngreso;

        private System.Windows.Forms.Button _btnInsertOk;
        private System.Windows.Forms.Button _btnEditCancel;
        private System.Windows.Forms.Button _btnBorrar;

        public DataGridView GridListado { get => _dgvListado; }
        public TextBox TextBoxNombre { get => _tbNombre;  }
        public TextBox TextBoxApellido { get => _tbApellido;  }
        public TextBox TextBoxLegajo { get => _tbLegajo;  }
        public TextBox TextBoxDNI { get => _tbDNI;  }
        public ComboBox ComboBoxPuesto { get => _cbPuesto; }
        public DateTimePicker DatePickerNacimiento { get => _dtPNacimiento;  }
        public DateTimePicker DatePickerIngreso { get => _dtpIngreso;  }
        public Button BotonInsertOk { get => _btnInsertOk;  }
        public Button BotonEditCancel { get => _btnEditCancel; }
        public Button BotonBorrar { get => _btnBorrar; }
    }
}