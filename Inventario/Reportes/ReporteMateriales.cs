using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Configuration;

namespace Inventario.Reportes
{
    class ReporteMateriales
    {
        public void imprimir(DataGridView dtgMateriales)
        {
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
                ep.Graphics.DrawString("REPORTE DE MATERIALES ", new Font("Segoe UI", 16, FontStyle.Bold), Brushes.DeepSkyBlue, left, top);
                DateTime fecha = DateTime.Now;
                top += DGV_ALTO;
                ep.Graphics.DrawString("FECHA: " + fecha, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.Gray, left, top);
                top += DGV_ALTO + 15;

                foreach (DataGridViewColumn col in dtgMateriales.Columns)
                {
                    ep.Graphics.DrawString(col.HeaderText, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.Brown, left, top);
                    left += col.Width;

                    if (col.Index < dtgMateriales.ColumnCount - 1)
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
                    ep.Graphics.DrawLine(Pens.Gray, ep.MarginBounds.Left, top, ep.MarginBounds.Right - 200, top);
                    if (row.Index == dtgMateriales.RowCount) break;
                }
            };
            ppd.ShowDialog();
        }

    }
}
