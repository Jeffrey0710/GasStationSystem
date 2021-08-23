using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ConsumidorServicioWeb
{
    public partial class WebFormEmpleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WServicioWebEmpleado.wsEmpleadoSoapClient ws = new WServicioWebEmpleado.wsEmpleadoSoapClient();
            DataSet ds = ws.listado_empleados();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            WServicioWebEmpleado.wsEmpleadoSoapClient ws = new WServicioWebEmpleado.wsEmpleadoSoapClient();
            ws.insertar_empleado(txt_Nombre.Text, txt_Puesto.Text, Convert.ToInt32(txt_Telefono.Text), txt_Email.Text);
            DataSet ds = ws.listado_empleados();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();

        }

        protected void BtnActualizar_Click(object sender, EventArgs e)
        {
            WServicioWebEmpleado.wsEmpleadoSoapClient ws = new WServicioWebEmpleado.wsEmpleadoSoapClient();
            ws.actualizar_empleado(Convert.ToInt32(Lbl_IdEmpleado.Text), txt_Nombre.Text, txt_Puesto.Text, Convert.ToInt32(txt_Telefono.Text), txt_Email.Text);

            DataSet ds = ws.listado_empleados();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lbl_IdEmpleado.Text = GridView1.SelectedRow.Cells[1].Text.ToString();
            txt_Nombre.Text = GridView1.SelectedRow.Cells[2].Text.ToString();
            txt_Puesto.Text = GridView1.SelectedRow.Cells[3].Text.ToString();
            txt_Telefono.Text = GridView1.SelectedRow.Cells[4].Text.ToString();
            txt_Email.Text = GridView1.SelectedRow.Cells[5].Text.ToString();
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            WServicioWebEmpleado.wsEmpleadoSoapClient ws = new WServicioWebEmpleado.wsEmpleadoSoapClient();
            ws.eliminar_empleado(Convert.ToInt32(Lbl_IdEmpleado.Text));

            DataSet ds = ws.listado_empleados();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }
    }
}