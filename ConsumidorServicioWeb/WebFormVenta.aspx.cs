using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ConsumidorServicioWeb
{
    public partial class WebFormVenta1 : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                WServicioWebEmpleado.wsEmpleadoSoapClient empleado = new WServicioWebEmpleado.wsEmpleadoSoapClient(); //ver los web services//
                DataSet dsempleado = new DataSet();

                dsempleado = empleado.listado_empleados();

                DDempleado.DataSource = dsempleado;
                DDempleado.DataValueField = "idEmpleados";
                DDempleado.DataTextField = "nombre";
                DDempleado.DataBind();

                WServicioWebCliente.wsClienteSoapClient cliente = new WServicioWebCliente.wsClienteSoapClient();//ver los web services//
                DataSet dscliente = new DataSet();

                dscliente = cliente.listado_clientes();

                DDcliente.DataSource = dscliente;
                DDcliente.DataValueField = "idClientes";
                DDcliente.DataTextField = "nombre";
                DDcliente.DataBind();

                WServicioWebFormaPago.wsFormaPagoSoapClient formapago = new WServicioWebFormaPago.wsFormaPagoSoapClient(); //ver los web services//
                DataSet dsformapago = new DataSet();

                dsformapago = formapago.formas_pago();
                DDformapago.DataSource = dsformapago;
                DDformapago.DataValueField = "idFormaPago";
                DDformapago.DataTextField = "nombre";
                DDformapago.DataBind();

                WServicioWebTipoGasolina.wsTipoGasolinaSoapClient tipogas = new WServicioWebTipoGasolina.wsTipoGasolinaSoapClient();
                DataSet dstipogas = new DataSet();

                dstipogas = tipogas.precios_gasolina();
                DDtipogas.DataSource = dstipogas;
                DDtipogas.DataValueField = "idTipoGasolina";
                DDtipogas.DataTextField = "nombre";
                DDtipogas.DataBind();

                buscartipogas(Convert.ToInt32(DDtipogas.SelectedValue));

                DataColumn id = dt.Columns.Add("IdArticulo", typeof(int));
                DataColumn tGas = dt.Columns.Add("Tipo", typeof(string));
                DataColumn cantidad = dt.Columns.Add("Cantidad", typeof(double));
                DataColumn precio = dt.Columns.Add("Precio", typeof(double));
                DataColumn subtotal = dt.Columns.Add("SubTotal", typeof(double));

                Session["tablaSesion"] = dt;
            }
        }
        protected void buscartipogas(int idTipoGasolina)
        {
            try
            {
                WServicioWebTipoGasolina.wsTipoGasolinaSoapClient tipogas = new WServicioWebTipoGasolina.wsTipoGasolinaSoapClient();
                DataSet dstipogas = new DataSet();
                
                dstipogas = tipogas.tipoGas(idTipoGasolina); //Prueba JH
                //dstipogas = tipogas.precios_gasolina(idtipoGasolina);//se necesita corregir

                if (dstipogas.Tables[0].Rows.Count > 0)
                {
                    txtprecio.Text = dstipogas.Tables[0].Rows[0]["precio"].ToString();

                }
            }
            catch (Exception ex)
            {

            }
        }

        protected void DDtipogas_SelectedIndexChanged1(object sender, EventArgs e)
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
            foreach (GridViewRow row in GVarticulo.Rows)
            {
                total += Convert.ToDouble(row.Cells[4].Text); //este error si esta raro bb // Te faltaba el "Row" en GridView bro :3 JH 
            }
            
            txttotalfactura.Text = total.ToString();
        }

        protected void GVarticulo_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            
            if (e.CommandName == "Select")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                dt = (DataTable) Session["tablaSesion"];
                dt.Rows.RemoveAt(index);

                GVarticulo.DataSource = dt;
                GVarticulo.DataBind();

                Session["tablaSesion"] = dt;
                totalFactura();
            }
        }
        protected void btnguardar_Click(object sender, EventArgs e)
        {

            int respuesta = 0; 
            
            WServicioWebVenta.wsVentaSoapClient venta = new WServicioWebVenta.wsVentaSoapClient();
            respuesta = venta.insertar_venta(Convert.ToInt32(DDcliente.SelectedValue), Convert.ToInt32(DDempleado.SelectedValue), Convert.ToInt32(DDformapago.SelectedValue), Convert.ToInt32(DDtipogas.SelectedValue), Convert.ToInt32(txtnobombagas.Text), txtfecha.Text, Convert.ToDouble(txttotalfactura.Text), Convert.ToInt32(txtcantcomprada.Text));

            if(respuesta > 0)
            {
                this.Page.Response.Write("<script language = 'JavaScript'>window.alert('Venta realizada correctamente');</script>");

            }
            else
            {

                this.Page.Response.Write("<script language = 'JavaScript'>window.alert('Venta no realizada');</script>");
            }

        
        }
    }
}