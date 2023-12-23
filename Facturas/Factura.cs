using System;
using System.Collections.Generic; 
namespace Facturas
{
    static class Null { public const string Value = "NULL"; }
    public class Servicio
    {
           public long Id { get; set; }
           public string Definicion { get; set; }
           public Servicio() {this.Id = 0; this.Definicion = Null.Value; }
    }
    public class RetencionIsr
    {
        public int Id { get; set; } = 0;
        public string Definicion { get; set; }
        public RetencionIsr() { this.Id = 0; this.Definicion = Null.Value; }
    }
    public class FormaDePago
    {
        public int Id { get; set; } 
        public string Definicion { get; set; }
        public FormaDePago() { this.Id = 0; this.Definicion = Null.Value; }
    }
    public class Factura
    {
        public string RncOCedula { get; set; } = Null.Value;
        public string Periodo { get; set; } = Null.Value;
        public int TipoDeId { get; set; } = 0;
        public Servicio TipoDeBienesOServicio { get; set; } = new Servicio();
        public List<Servicio> Servicios { get; set; } = new List<Servicio>();
        public string Nfs { get; set; } = Null.Value;
        public string NfsODocumentoModificado { get; set; } = Null.Value;
        public string FechaDeComprobante { get; set; } = Null.Value;
        public string FechaDePago { get; set; } = Null.Value;
        public string FechaDePagoDia { get; set; } = Null.Value;
        public double MontoFacturadoEnServicio { get; set; } = 0;
        public double MontoFacturadoEnBienes { get; set; } = 0;
        public double TotalMontoFacturado { get; set; } = 0;
        public double ItebisFActurado { get; set; } = 0;
        public double ItebisRetenido { get; set; } = 0;
        public double ItebisSubjetoAProporcionalidad_Art349 { get; set; } = 0;
        public double ItebisLLevadoAlCosto { get; set; } = 0;
        public double ItebisPorAdelantar { get; set; } = 0;
        public double ItebisPorRecibidoEnCompras { get; set; } = 0;
        public RetencionIsr TipoDeRetencionEnIsr { get; set; } = new RetencionIsr();
        public List<RetencionIsr> RetencionesIsr { get; set; } = new List<RetencionIsr>();
        public double MontoDeRetencionRenta { get; set; } = 0;
        public double IsrPercibidoEnCompras { get; set; } = 0;
        public double ImpuestoSelectivoAlConsumo { get; set; } = 0;
        public double OtrosImpuestosOTasas { get; set; } = 0;
        public double MontoPropinaLegal { get; set; } = 0;
        public FormaDePago FormaDePago { get; set; } = new FormaDePago();
        public List<FormaDePago> FormasDePago { get; set; } = new List<FormaDePago>(); 




        public Factura()
        {
            this.Servicios = new List<Servicio>();

            this.Servicios.Add(new Servicio() { Id = 02,Definicion="GASTOS POR TRABAJOS, SUMINISTROS Y SERVICIOS"});
            this.Servicios.Add(new Servicio() { Id = 03,Definicion="ARRENDAMIENTOS"});
            this.Servicios.Add(new Servicio() { Id = 04,Definicion="GASTOS DE ACTIVOS FIJO"});
            this.Servicios.Add(new Servicio() { Id = 05,Definicion="GASTOS DE REPRESENTACIÓN"});
            this.Servicios.Add(new Servicio() { Id = 06,Definicion="OTRAS DEDUCCIONES ADMITIDAS"});
            this.Servicios.Add(new Servicio() { Id = 07,Definicion="GASTOS FINANCIEROS"});
            this.Servicios.Add(new Servicio() { Id = 08,Definicion="GASTOS EXTRAORDINARIOS"});
            this.Servicios.Add(new Servicio() { Id = 09,Definicion="COMPRAS Y GASTOS QUE FORMAN PARTE DEL COSTO DE VENTA"});

            this.RetencionesIsr = new List<RetencionIsr>();

            this.RetencionesIsr.Add(new RetencionIsr() { Id = 01, Definicion = "ALQUILERES" });
            this.RetencionesIsr.Add(new RetencionIsr() { Id = 02, Definicion = "HONORARIOS POR SERVICIOS" });
            this.RetencionesIsr.Add(new RetencionIsr() { Id = 03, Definicion = "OTRAS RENTAS" });
            this.RetencionesIsr.Add(new RetencionIsr() { Id = 04, Definicion = "OTRAS RENTAS (Rentas Presuntas)" });
            this.RetencionesIsr.Add(new RetencionIsr() { Id = 05, Definicion = "INTERESES PAGADOS A PERSONAS JURIDICAS RESIDENTES" });
            this.RetencionesIsr.Add(new RetencionIsr() { Id = 06, Definicion = "INTERESES PAGADOS A PERSONAS FISICAS RESIDENTES" });
            this.RetencionesIsr.Add(new RetencionIsr() { Id = 07, Definicion = "RETENCION POR PROVEEDORES DEL ESTADO" });
            this.RetencionesIsr.Add(new RetencionIsr() { Id = 08, Definicion = "JUEGOS TELEFONICOS" });

            this.FormasDePago = new List<FormaDePago>();

            this.RetencionesIsr.Add(new RetencionIsr() { Id = 01, Definicion = "EFECTIVO" });
            this.RetencionesIsr.Add(new RetencionIsr() { Id = 02, Definicion = "CHEQUES/TRANSFERENCIAS/DEPÓSITO" });
            this.RetencionesIsr.Add(new RetencionIsr() { Id = 03, Definicion = "TARJETA CRÉDITO/DÉBITO" });
            this.RetencionesIsr.Add(new RetencionIsr() { Id = 04, Definicion = "COMPRA A CREDITO" });
            this.RetencionesIsr.Add(new RetencionIsr() { Id = 05, Definicion = "PERMUTA" });
            this.RetencionesIsr.Add(new RetencionIsr() { Id = 06, Definicion = "NOTA DE CREDITO" });
            this.RetencionesIsr.Add(new RetencionIsr() { Id = 07, Definicion = "MIXTO" });

        }

    }
}
