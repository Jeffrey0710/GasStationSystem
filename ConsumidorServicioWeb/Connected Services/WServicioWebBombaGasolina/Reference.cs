//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsumidorServicioWeb.WServicioWebBombaGasolina {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WServicioWebBombaGasolina.wsbombagasolinaSoap")]
    public interface wsbombagasolinaSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/listado_bombagasolina", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet listado_bombagasolina();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/listado_bombagasolina", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> listado_bombagasolinaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/datos_bombagasolina", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet datos_bombagasolina(int NoBombaGasolina);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/datos_bombagasolina", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> datos_bombagasolinaAsync(int NoBombaGasolina);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertar_bombagasolina", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int insertar_bombagasolina(int IdTipoGasolina, int CantidadGasolina, double MontoTotalGas, string Caracteristicas);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertar_bombagasolina", ReplyAction="*")]
        System.Threading.Tasks.Task<int> insertar_bombagasolinaAsync(int IdTipoGasolina, int CantidadGasolina, double MontoTotalGas, string Caracteristicas);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizar_bombagasolina", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int actualizar_bombagasolina(int NoBombaGasolina, int IdTipoGasolina, int CantidadGasolina, double MontoTotalGas, string Caracteristicas);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizar_bombagasolina", ReplyAction="*")]
        System.Threading.Tasks.Task<int> actualizar_bombagasolinaAsync(int NoBombaGasolina, int IdTipoGasolina, int CantidadGasolina, double MontoTotalGas, string Caracteristicas);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminar_bombagasolina", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int eliminar_bombagasolina(int NoBombaGasolina);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminar_bombagasolina", ReplyAction="*")]
        System.Threading.Tasks.Task<int> eliminar_bombagasolinaAsync(int NoBombaGasolina);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsbombagasolinaSoapChannel : ConsumidorServicioWeb.WServicioWebBombaGasolina.wsbombagasolinaSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsbombagasolinaSoapClient : System.ServiceModel.ClientBase<ConsumidorServicioWeb.WServicioWebBombaGasolina.wsbombagasolinaSoap>, ConsumidorServicioWeb.WServicioWebBombaGasolina.wsbombagasolinaSoap {
        
        public wsbombagasolinaSoapClient() {
        }
        
        public wsbombagasolinaSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsbombagasolinaSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsbombagasolinaSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsbombagasolinaSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet listado_bombagasolina() {
            return base.Channel.listado_bombagasolina();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> listado_bombagasolinaAsync() {
            return base.Channel.listado_bombagasolinaAsync();
        }
        
        public System.Data.DataSet datos_bombagasolina(int NoBombaGasolina) {
            return base.Channel.datos_bombagasolina(NoBombaGasolina);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> datos_bombagasolinaAsync(int NoBombaGasolina) {
            return base.Channel.datos_bombagasolinaAsync(NoBombaGasolina);
        }
        
        public int insertar_bombagasolina(int IdTipoGasolina, int CantidadGasolina, double MontoTotalGas, string Caracteristicas) {
            return base.Channel.insertar_bombagasolina(IdTipoGasolina, CantidadGasolina, MontoTotalGas, Caracteristicas);
        }
        
        public System.Threading.Tasks.Task<int> insertar_bombagasolinaAsync(int IdTipoGasolina, int CantidadGasolina, double MontoTotalGas, string Caracteristicas) {
            return base.Channel.insertar_bombagasolinaAsync(IdTipoGasolina, CantidadGasolina, MontoTotalGas, Caracteristicas);
        }
        
        public int actualizar_bombagasolina(int NoBombaGasolina, int IdTipoGasolina, int CantidadGasolina, double MontoTotalGas, string Caracteristicas) {
            return base.Channel.actualizar_bombagasolina(NoBombaGasolina, IdTipoGasolina, CantidadGasolina, MontoTotalGas, Caracteristicas);
        }
        
        public System.Threading.Tasks.Task<int> actualizar_bombagasolinaAsync(int NoBombaGasolina, int IdTipoGasolina, int CantidadGasolina, double MontoTotalGas, string Caracteristicas) {
            return base.Channel.actualizar_bombagasolinaAsync(NoBombaGasolina, IdTipoGasolina, CantidadGasolina, MontoTotalGas, Caracteristicas);
        }
        
        public int eliminar_bombagasolina(int NoBombaGasolina) {
            return base.Channel.eliminar_bombagasolina(NoBombaGasolina);
        }
        
        public System.Threading.Tasks.Task<int> eliminar_bombagasolinaAsync(int NoBombaGasolina) {
            return base.Channel.eliminar_bombagasolinaAsync(NoBombaGasolina);
        }
    }
}
