using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ventas_online
{
    public partial class frmFacturaaspx : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                wsEmpleado.wsEmpleadoSoapClient empleado = new wsEmpleado.wsEmpleadoSoapClient(); //ver los web services//
                DataSet dsempleado = new DataSet();

                dsempleado = empleado.listado_empleados();
                DDempleado.DataSource = dsempleado;
                DDempleado.DataValueField = "idEmpleado";
                DDempleado.DataTextField = "nombre";
                DDempleado.DataBind();

                wsCliente.wsClienteSoapClient cliente = new wsCliente.wsClienteSoapClient();//ver los web services//
                DataSet dscliente = new DataSet();

                dscliente = cliente.listado_clientes();

                DDcliente.DataSource = dscliente;
                DDcliente.DataValueField = "NIT";
                DDcliente.DataTextField = "nombre";
                DDcliente.DataBind();

                wsFormaPago.wsFormaPagoSoapClient formapago = new wsFormaPago.wsFormaPagoSoapClient(); //ver los web services//
                DataSet dsformapago = new DataSet();

                dsformapago = formapago.formas_pago();
                DDempleado.DataSource = dsformapago;
                DDempleado.DataValueField = "idFormaPago";
                DDempleado.DataTextField = "nombre"; 
                DDempleado.DataBind();

                wsTipoGasolina.wsTipoGasolinaSoapClient tipogas = new wsTipoGasolina.wsTipoGasolinaSoapClient();
                DataSet dstipogas = new DataSet();
                dstipogas = tipogas.precios_gasolina();
                DDtipogas.DataSource = dstipogas;
                DDtipogas.DataValueField = "idTipoGasolina";
                DDtipogas.DataTextField = "nombre";
                DDtipogas.DataBind();

                buscartipogas(Convert.ToInt32(DDtipogas.SelectedValue));

                DataColumn id = dt.Columns.Add("IdArticulo", typeof(int));
                DataColumn articulocolumna = dt.Columns.Add("Articulo", typeof(string));
                DataColumn cantidad = dt.Columns.Add("Cantidad", typeof(double));
                DataColumn precio = dt.Columns.Add("Precio", typeof(double));
                DataColumn subtotal = dt.Columns.Add("SubTotal", typeof(double));

                Session["tablaSesion"] = dt;
            }
        }

        protected void buscartipogas(int idtipoGasolina)
        {
            try
            {

                wsTipoGasolina.wsTipoGasolinaSoapClient tipogas = new wsTipoGasolina.wsTipoGasolinaSoapClient();
                DataSet dstipogas = new DataSet();

                dstipogas = tipogas.precios_gasolina(idtipoGasolina);//se necesita corregir

                if (dstipogas.Tables[0].Rows.Count > 0)
                {
                    txtprecio.Text = dstipogas.Tables[0].Rows[0]["precio"].ToString();

                }
            }
            catch (Exception ex)
            {

            }
        }

        protected void DDtipogas_SelectedIndexChanged(object sender, EventArgs e)
        {
            buscartipogas(Convert.ToInt32(DDtipogas.SelectedValue));
        }

        protected void btnagregar_Click(object sender, EventArgs e)
        {
            dt = Session["tablaSesion"] as DataTable;
            DataRow fila = dt.NewRow();

            double subtotal = Convert.ToDouble(txtcantcomprada.Text) * Convert.ToDouble(txtprecio.Text);
            dt.Rows.Add(DDtipogas.SelectedValue, DDtipogas.SelectedItem.ToString(), txtcantcomprada.Text, txtprecio.Text, subtotal);
            GVarticulo.DataSource = dt;
            GVarticulo.DataBind();

            Session["tablaSesion"] = dt;

            totalFactura();
        }

        public void totalFactura()
        {
            double total = 0;
            foreach (GridView row in GVarticulo.Rows)
            {
                total += Convert.ToDouble(row.Cells[4].Text); //este error si esta raro bb
            }

            txttotalfactura.Text = total.ToString();
        }

        protected void GVarticulo_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "select")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                dt = (DataTable)Session["tablaSesion"];
                dt.Rows.RemoveAt(index);

                GVarticulo.DataSource = dt;
                GVarticulo.DataBind();

                Session["tablaSesion"] = dt;
                totalFactura();
            }
        }

        protected void btnguardar_Click(object sender, EventArgs e)
        {
            wsVenta.wsVentaSoapClient venta = new wsVenta.wsVentaSoapClient();
            int respuetaencabezado;
            int cont = 0;


            respuetaencabezado = venta.insertar_venta(txtFactura.Text, DDcliente.SelectedValue, Convert.ToInt32(DDempleado.SelectedValue), Convert.ToDouble(txttotalfactura));
            if (respuetaencabezado == 1)
            {
                foreach (GridViewRow row in GVarticulo.Rows)
                {
                    venta.insertar_detalleventa(txtFactura.Text, Convert.ToInt32(GVarticulo.DataKeys[cont].Value), Convert.ToInt32(row.Cells[2].Text)); //revisar este error
                    cont += 1;
                }

                this.Page.Response.Write("<script language = 'JavaScript'>window.alert('Venta realizada correctamente');</script>");

            }
            else
            {

                this.Page.Response.Write("<script language = 'JavaScript'>window.alert('Venta no realizada');</script>");
            }
        }
    }
}
