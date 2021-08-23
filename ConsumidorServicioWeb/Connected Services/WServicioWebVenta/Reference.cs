﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsumidorServicioWeb.WServicioWebVenta {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WServicioWebVenta.wsVentaSoap")]
    public interface wsVentaSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/listado_venta", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet listado_venta();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/listado_venta", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> listado_ventaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/datos_venta", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet datos_venta(int NoFactura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/datos_venta", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> datos_ventaAsync(int NoFactura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertar_venta", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int insertar_venta(int idClientes, int idEmpleados, int idFormaPago, int idTipoGasolina, int NoBombaGasolina, string Fecha, double MontoTotal, int CantidadComprada);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertar_venta", ReplyAction="*")]
        System.Threading.Tasks.Task<int> insertar_ventaAsync(int idClientes, int idEmpleados, int idFormaPago, int idTipoGasolina, int NoBombaGasolina, string Fecha, double MontoTotal, int CantidadComprada);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizar_venta", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int actualizar_venta(int NoFactura, int idClientes, int idEmpleados, int idFormaPago, int idTipoGasolina, int NoBombaGasolina, string Fecha, double MontoTotal, int CantidadComprada);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizar_venta", ReplyAction="*")]
        System.Threading.Tasks.Task<int> actualizar_ventaAsync(int NoFactura, int idClientes, int idEmpleados, int idFormaPago, int idTipoGasolina, int NoBombaGasolina, string Fecha, double MontoTotal, int CantidadComprada);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminar_cliente", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int eliminar_cliente(int NoFactura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminar_cliente", ReplyAction="*")]
        System.Threading.Tasks.Task<int> eliminar_clienteAsync(int NoFactura);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsVentaSoapChannel : ConsumidorServicioWeb.WServicioWebVenta.wsVentaSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsVentaSoapClient : System.ServiceModel.ClientBase<ConsumidorServicioWeb.WServicioWebVenta.wsVentaSoap>, ConsumidorServicioWeb.WServicioWebVenta.wsVentaSoap {
        
        public wsVentaSoapClient() {
        }
        
        public wsVentaSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsVentaSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsVentaSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsVentaSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet listado_venta() {
            return base.Channel.listado_venta();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> listado_ventaAsync() {
            return base.Channel.listado_ventaAsync();
        }
        
        public System.Data.DataSet datos_venta(int NoFactura) {
            return base.Channel.datos_venta(NoFactura);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> datos_ventaAsync(int NoFactura) {
            return base.Channel.datos_ventaAsync(NoFactura);
        }
        
        public int insertar_venta(int idClientes, int idEmpleados, int idFormaPago, int idTipoGasolina, int NoBombaGasolina, string Fecha, double MontoTotal, int CantidadComprada) {
            return base.Channel.insertar_venta(idClientes, idEmpleados, idFormaPago, idTipoGasolina, NoBombaGasolina, Fecha, MontoTotal, CantidadComprada);
        }
        
        public System.Threading.Tasks.Task<int> insertar_ventaAsync(int idClientes, int idEmpleados, int idFormaPago, int idTipoGasolina, int NoBombaGasolina, string Fecha, double MontoTotal, int CantidadComprada) {
            return base.Channel.insertar_ventaAsync(idClientes, idEmpleados, idFormaPago, idTipoGasolina, NoBombaGasolina, Fecha, MontoTotal, CantidadComprada);
        }
        
        public int actualizar_venta(int NoFactura, int idClientes, int idEmpleados, int idFormaPago, int idTipoGasolina, int NoBombaGasolina, string Fecha, double MontoTotal, int CantidadComprada) {
            return base.Channel.actualizar_venta(NoFactura, idClientes, idEmpleados, idFormaPago, idTipoGasolina, NoBombaGasolina, Fecha, MontoTotal, CantidadComprada);
        }
        
        public System.Threading.Tasks.Task<int> actualizar_ventaAsync(int NoFactura, int idClientes, int idEmpleados, int idFormaPago, int idTipoGasolina, int NoBombaGasolina, string Fecha, double MontoTotal, int CantidadComprada) {
            return base.Channel.actualizar_ventaAsync(NoFactura, idClientes, idEmpleados, idFormaPago, idTipoGasolina, NoBombaGasolina, Fecha, MontoTotal, CantidadComprada);
        }
        
        public int eliminar_cliente(int NoFactura) {
            return base.Channel.eliminar_cliente(NoFactura);
        }
        
        public System.Threading.Tasks.Task<int> eliminar_clienteAsync(int NoFactura) {
            return base.Channel.eliminar_clienteAsync(NoFactura);
        }
    }
}
