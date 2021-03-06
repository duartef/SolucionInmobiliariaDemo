﻿using InmobiliariaForms.InmobiliariaService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InmobiliariaForms
{
    public partial class frmAgregarInmueble : Form
    {
        public static int MouseHoverTime { get; set; }
        
        frmInmueble frmInmueble;
        frmBuscarInmueble frmBuscarInmueble;
     
        public Vendedor Vendedor { get; set; }

        public frmAgregarInmueble()
        {
            InitializeComponent();
        }

        private void pbAgregarInmueble1_MouseHover(object sender, EventArgs e)
        {
            pbAgregarInmueble1.Visible = false;
            pbAgregarInmueble2.Visible = true;
            MouseHoverTime = 1;
        }

        private void pbAgregarInmueble2_MouseLeave(object sender, EventArgs e)
        {
            pbAgregarInmueble1.Visible = true;
            pbAgregarInmueble2.Visible = false;
        }

        private void pbAgregarInmueble2_Click(object sender, EventArgs e)
        {
            if (frmInmueble == null || frmInmueble.IsDisposed)
                frmInmueble = new frmInmueble();

            frmInmueble.Vendedor = this.Vendedor;
            frmInmueble.MdiParent = (Form)this.Parent.Parent;
            Panel p = (Panel)this.Parent.Parent.Controls.Find("pnlMdi", true).First();
            p.Controls.Add(frmInmueble);

            frmInmueble.BringToFront();
            frmInmueble.StartPosition = FormStartPosition.Manual;
          
            //int width = this.Controls.Find("netBarControl1", true)[0].Width;
            frmInmueble.Location = new Point(120, 0);
            this.Close();
            frmInmueble.Show();
        }

        private void pbBuscarInmueble1_MouseHover(object sender, EventArgs e)
        {
            pbBuscarInmueble1.Visible = false;
            pbBuscarInmueble2.Visible = true;
            MouseHoverTime = 1;
        }

        private void pbBuscarInmueble2_MouseLeave(object sender, EventArgs e)
        {
            pbBuscarInmueble1.Visible = true;
            pbBuscarInmueble2.Visible = false;
        }

        private void pbBuscarInmueble2_Click(object sender, EventArgs e)
        {
            if (frmBuscarInmueble == null || frmBuscarInmueble.IsDisposed)
                frmBuscarInmueble = new frmBuscarInmueble();

            frmBuscarInmueble.Vendedor = this.Vendedor;
            frmBuscarInmueble.MdiParent = (Form)this.Parent.Parent;
            Panel p = (Panel)this.Parent.Parent.Controls.Find("pnlMdi", true).First();
            p.Controls.Add(frmBuscarInmueble);

            frmBuscarInmueble.BringToFront();
            frmBuscarInmueble.StartPosition = FormStartPosition.Manual;

            //int width = this.Controls.Find("netBarControl1", true)[0].Width; 
            frmBuscarInmueble.Location = new Point(120, 0);
            this.Close();
            frmBuscarInmueble.Show();
        }
    }
}
