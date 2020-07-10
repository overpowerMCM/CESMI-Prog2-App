using System.Windows.Forms;

namespace CRUD.PresentacionWinForms.Vistas
{
    partial class Main
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
            this._panelMenu = new System.Windows.Forms.Panel();
            this._btnPagos = new System.Windows.Forms.Button();
            this._btnEmpleados = new System.Windows.Forms.Button();
            this._panelTrabajo = new System.Windows.Forms.Panel();
            this._panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panelMenu
            // 
            this._panelMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._panelMenu.Controls.Add(this._btnPagos);
            this._panelMenu.Controls.Add(this._btnEmpleados);
            this._panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this._panelMenu.Location = new System.Drawing.Point(0, 0);
            this._panelMenu.Name = "_panelMenu";
            this._panelMenu.Size = new System.Drawing.Size(120, 573);
            this._panelMenu.TabIndex = 0;
            // 
            // _btnPagos
            // 
            this._btnPagos.Location = new System.Drawing.Point(12, 103);
            this._btnPagos.Name = "_btnPagos";
            this._btnPagos.Size = new System.Drawing.Size(102, 23);
            this._btnPagos.TabIndex = 1;
            this._btnPagos.Text = "Pagos";
            this._btnPagos.UseVisualStyleBackColor = true;
            // 
            // _btnEmpleados
            // 
            this._btnEmpleados.Location = new System.Drawing.Point(12, 74);
            this._btnEmpleados.Name = "_btnEmpleados";
            this._btnEmpleados.Size = new System.Drawing.Size(102, 23);
            this._btnEmpleados.TabIndex = 0;
            this._btnEmpleados.Text = "Empleados";
            this._btnEmpleados.UseVisualStyleBackColor = true;
            // 
            // _panelTrabajo
            // 
            this._panelTrabajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panelTrabajo.Location = new System.Drawing.Point(120, 0);
            this._panelTrabajo.Name = "_panelTrabajo";
            this._panelTrabajo.Size = new System.Drawing.Size(1048, 573);
            this._panelTrabajo.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 573);
            this.Controls.Add(this._panelTrabajo);
            this.Controls.Add(this._panelMenu);
            this.Name = "Main";
            this.Text = "CRUD v0.0.1";
            this._panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panelMenu;
        private System.Windows.Forms.Button _btnPagos;
        private System.Windows.Forms.Button _btnEmpleados;
        private System.Windows.Forms.Panel _panelTrabajo;

        public Button BotonEmpleados { get => _btnEmpleados; }
        public Button BotonPago { get => _btnPagos; }
        public Panel PanelTrabajo { get => _panelTrabajo; }
    }
}