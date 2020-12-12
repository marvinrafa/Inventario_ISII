using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;

namespace Inventario
{
    public partial class CambiarImpresor : Form
    {
        public CambiarImpresor()
        {
            InitializeComponent();
        }

        private void CambiarImpresor_Load(object sender, EventArgs e)
        {
            string sAttr = ConfigurationManager.AppSettings.Get("Impresor");
            lblImpresor.Text = sAttr;
        
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                string pkInstalledPrinters;
                pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
                cmbImpresoras.Items.Add(pkInstalledPrinters);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["Impresor"].Value = cmbImpresoras.SelectedText;
                config.Save(ConfigurationSaveMode.Modified);
                MessageBox.Show("IMPRESOR CAMBIADO, REINICIE EL SISTEMA POR FAVOR");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
