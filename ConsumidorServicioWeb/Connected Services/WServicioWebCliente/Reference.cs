﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsumidorServicioWeb.WServicioWebCliente {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WServicioWebCliente.wsClienteSoap")]
    public interface wsClienteSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/listado_clientes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet listado_clientes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/listado_clientes", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> listado_clientesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/datos_cliente", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet datos_cliente(int idCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/datos_cliente", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> datos_clienteAsync(int idCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertar_cliente", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int insertar_cliente(string nombre, int nit, string direccion, int telefono);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertar_cliente", ReplyAction="*")]
        System.Threading.Tasks.Task<int> insertar_clienteAsync(string nombre, int nit, string direccion, int telefono);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizar_cliente", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int actualizar_cliente(int idCliente, string nombre, int nit, string direccion, int telefono);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizar_cliente", ReplyAction="*")]
        System.Threading.Tasks.Task<int> actualizar_clienteAsync(int idCliente, string nombre, int nit, string direccion, int telefono);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminar_cliente", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int eliminar_cliente(int idCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminar_cliente", ReplyAction="*")]
        System.Threading.Tasks.Task<int> eliminar_clienteAsync(int idCliente);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsClienteSoapChannel : ConsumidorServicioWeb.WServicioWebCliente.wsClienteSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsClienteSoapClient : System.ServiceModel.ClientBase<ConsumidorServicioWeb.WServicioWebCliente.wsClienteSoap>, ConsumidorServicioWeb.WServicioWebCliente.wsClienteSoap {
        
        public wsClienteSoapClient() {
        }
        
        public wsClienteSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsClienteSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsClienteSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsClienteSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet listado_clientes() {
            return base.Channel.listado_clientes();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> listado_clientesAsync() {
            return base.Channel.listado_clientesAsync();
        }
        
        public System.Data.DataSet datos_cliente(int idCliente) {
            return base.Channel.datos_cliente(idCliente);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> datos_clienteAsync(int idCliente) {
            return base.Channel.datos_clienteAsync(idCliente);
        }
        
        public int insertar_cliente(string nombre, int nit, string direccion, int telefono) {
            return base.Channel.insertar_cliente(nombre, nit, direccion, telefono);
        }
        
        public System.Threading.Tasks.Task<int> insertar_clienteAsync(string nombre, int nit, string direccion, int telefono) {
            return base.Channel.insertar_clienteAsync(nombre, nit, direccion, telefono);
        }
        
        public int actualizar_cliente(int idCliente, string nombre, int nit, string direccion, int telefono) {
            return base.Channel.actualizar_cliente(idCliente, nombre, nit, direccion, telefono);
        }
        
        public System.Threading.Tasks.Task<int> actualizar_clienteAsync(int idCliente, string nombre, int nit, string direccion, int telefono) {
            return base.Channel.actualizar_clienteAsync(idCliente, nombre, nit, direccion, telefono);
        }
        
        public int eliminar_cliente(int idCliente) {
            return base.Channel.eliminar_cliente(idCliente);
        }
        
        public System.Threading.Tasks.Task<int> eliminar_clienteAsync(int idCliente) {
            return base.Channel.eliminar_clienteAsync(idCliente);
        }
    }
}
