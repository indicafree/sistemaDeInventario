using System;
using System.Windows.Forms;
namespace prytp2_LP2
{
    partial class frmInfo
    {
        private System.ComponentModel.IContainer components = null;
        private Label lbl1Instancia;
        private Label lblNombreAlumno;
        private Label lblDNI;
        private Label lblCarrera;
        private Label lblMateria;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lbl1Instancia = new System.Windows.Forms.Label();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1Instancia
            // 
            this.lbl1Instancia.AutoSize = true;
            this.lbl1Instancia.Location = new System.Drawing.Point(300, 20);
            this.lbl1Instancia.Name = "lbl1Instancia";
            this.lbl1Instancia.Size = new System.Drawing.Size(120, 20);
            this.lbl1Instancia.Text = "1º Instancia Evaluativa";
            this.lbl1Instancia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Location = new System.Drawing.Point(300, 60);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(200, 20);
            this.lblNombreAlumno.Text = "Nombre Alumno: Georgina Jacqueline Valdez";
            this.lblNombreAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(300, 100);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(120, 20);
            this.lblDNI.Text = "DNI Alumno: 35580855";
            this.lblDNI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(300, 140);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(150, 20);
            this.lblCarrera.Text = "Carrera: Analista de Sistemas";
            this.lblCarrera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(300, 180);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(250, 20);
            this.lblMateria.Text = "Materia: Laboratorio de Programación 2";
            this.lblMateria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmInfo
            // 
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.lbl1Instancia);
            this.Controls.Add(this.lblNombreAlumno);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblMateria);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información";
            this.Load += new System.EventHandler(this.frmInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}


