﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmArmarPermisos : Form
    {
        public frmArmarPermisos()
        {
            InitializeComponent();
            Controlador_Vista.VistaArmarPermisos _vc = new Controlador_Vista.VistaArmarPermisos(this);
        }
    }
}
