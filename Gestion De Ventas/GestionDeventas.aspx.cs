using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gestion_De_Ventas
{
    public partial class GestionDeventas : System.Web.UI.Page
    {
        private List<Venta> Ventas
        {
            get
            {
                if (ViewState["Ventas"]== null)
                {
                    ViewState["Ventas"] = new List<Venta>();
                }
                return (List<Venta>)ViewState["Ventas"];
            }
            set
            {
                ViewState["Ventas"]= value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Enlaza la lista de ventas al GridView.
                gvVentas.DataSource = Ventas;
                gvVentas.DataBind();
            }
        }

        protected void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            // Recopila los datos de la venta ingresados por el usuario.
            DateTime fecha = DateTime.Parse(txtFecha.Text);
            string vendedor = txtVendedor.Text;
            string detalle = txtDetalle.Text;
            decimal monto = decimal.Parse(txtMonto.Text);

            // Crea una nueva venta y agrégala a la lista.
            Ventas.Add(new Venta { Fecha = fecha, Vendedor = vendedor, Detalle = detalle, Monto = monto });

            // Actualiza el GridView con la nueva venta.
            gvVentas.DataSource = Ventas;
            gvVentas.DataBind();

            // Limpia los campos del formulario.
            txtFecha.Text = "";
            txtVendedor.Text = "";
            txtDetalle.Text = "";
            txtMonto.Text = "";
        }
    }
    [Serializable]
    public class Venta
    {
        public DateTime Fecha { get; set; }
        public string Vendedor { get; set; }
        public string Detalle { get; set; }
        public decimal Monto { get; set; }
    }
}