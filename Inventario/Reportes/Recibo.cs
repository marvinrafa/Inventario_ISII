using DataModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario.Reportes
{
    class Recibo
    {
        public void imprimir(DataGridView dtgMateriales,int id_cliente, double total)
        {
            string cliente;
            using (var db = new InventarioDB())
            {
                var q =
                    from c in db.Clientes
                    where c.Id == id_cliente
                    select c.ClienteColumn;
                cliente = db.Clientes.Where(u => u.Id == id_cliente).FirstOrDefault().ClienteColumn;

            }

            PrintDocument doc = new PrintDocument();
            doc.DefaultPageSettings.Landscape = true;
            string sAttr = ConfigurationManager.AppSettings.Get("Impresor");
            doc.PrinterSettings.PrinterName = sAttr;

            PrintPreviewDialog ppd = new PrintPreviewDialog { Document = doc };
            ((Form)ppd).WindowState = FormWindowState.Normal;

            doc.PrintPage += delegate (object ev, PrintPageEventArgs ep)
            {
                const int DGV_ALTO = 35;
                int left = ep.MarginBounds.Left, top = ep.MarginBounds.Top;
                ep.Graphics.DrawString("Click, impresión digital - Recibo ", new Font("Segoe UI", 16, FontStyle.Bold), Brushes.DeepSkyBlue, left, top);
                DateTime fecha = DateTime.Now;
                top += DGV_ALTO;
                ep.Graphics.DrawString("Cliente: " + cliente, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.Gray, left, top);
                top += DGV_ALTO + 15;
                ep.Graphics.DrawString("FECHA: " + fecha, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.Gray, left, top);
                top += DGV_ALTO + 15;

                foreach (DataGridViewColumn col in dtgMateriales.Columns)
                {
                  
                    ep.Graphics.DrawString(col.HeaderText, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.Brown, left, top);
                    left += col.Width;

                    if (col.Index < dtgMateriales.ColumnCount -1)
                        ep.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top + 43 + (dtgMateriales.RowCount) * DGV_ALTO);
                }
                left = ep.MarginBounds.Left;
                ep.Graphics.FillRectangle(Brushes.Black, left, top + 40, ep.MarginBounds.Right - left - 200, 3);
                top += 43;

                foreach (DataGridViewRow row in dtgMateriales.Rows)
                {
                    left = ep.MarginBounds.Left;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Segoe UI", 13), Brushes.Black, left, top + 4);
                        left += cell.OwningColumn.Width;
                    }
                    top += DGV_ALTO;
                    ep.Graphics.DrawLine(Pens.Gray, ep.MarginBounds.Left, top, ep.MarginBounds.Right - 150, top);
                    if (row.Index == dtgMateriales.RowCount) break;
                }
             
                top += DGV_ALTO + 5;

                ep.Graphics.DrawString("Total cancelado: $ " + total, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.Gray, left-200, top);
            };

            ppd.ShowDialog();
        }
    }
}
