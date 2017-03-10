
using System;
using SAGO.CLASES.DAL;


namespace SAGO.CLASES.DAO
{
	/// <summary>
	/// Summary description for ECURSOCAPACITACION.
	/// </summary>
    public class ECURSOCAPACITACION : DomainObject
    {

        private System.Int64 _CORRELATIVO = 0;
        	
	    private System.Int64  _RUT_CLIENTE = 0;
        	
	    private System.Int64  _CORRELATIVO_AGNO = 0;
        	
	    private System.String  _CORRELATIVO_CLIENTE = String.Empty;
        	
	    private System.Int64  _COD_SENCE = 0;
        	
	    private System.Int64  _NUMERO_ACCION_SENCE = 0;
        	
	    private System.Decimal  _COD_ESTADO_CURSO = 0;
        	
	    private System.Decimal  _COD_TIPO_CONTRATO = 0;
        	
	    private System.String  _DIRECCION_CURSO = String.Empty;
        	
	    private System.String  _NRO_DIRECCION_CURSO = String.Empty;
        	
	    private System.String  _CIUDAD_CURSO = String.Empty;
        	
	    private System.Int64  _COD_COMUNA = 0;
        	
	    private System.DateTime  _FECHA_CREACION = Datetime.Now;
        	
	    private System.DateTime  _FECHA_INICIO = Datetime.Now;
        	
	    private System.DateTime  _FECHA_TERMINO = Datetime.Now;
        	
	    private System.Int32  _HORAS_CURSO = 0;
        	
	    private System.DateTime  _FECHA_COMUNICACION = Datetime.Now;
        	
	    private System.DateTime  _FECHA_LIQUIDACION = Datetime.Now;
        	
	    private System.DateTime  _FECHA_PAGO = Datetime.Now;
        	
	    private System.Boolean  _COMITE_BIPARTITO = false;
        	
	    private System.Boolean  _DNC = false;
        	
	    private System.Int64  _MONTO_DESCUENTO = 0;
        	
	    private System.Int32  _NRO_ALUMOS = 0;
        	
	    private System.Double  _NOTA_MINIMA = null;
        	
	    private System.String  _OBSERVACION_CURSO = String.Empty;
        	
	    private System.Int32  _HORAS_COMPLEMENTO = 0;
        	
	    private System.Decimal  _CORRELATIVO_COMPLEMENTARIO = 0;
        	
        
	    public ECURSOCAPACITACION() : base()
	    {
	    }
	    
		public ECURSOCAPACITACION(long id) : base(id)
		{
		}
        
        #region Properties    	
	    	
        public System.Int64 CORRELATIVO
	    {
		    get { return _CORRELATIVO; }
		    set { _CORRELATIVO = value; }
	    }
	    
	    	
	    public System.Int64 RUTCLIENTE
	    {
		    get { return _RUT_CLIENTE; }
		    set { _RUT_CLIENTE = value; }
	    }
	    
	    	
	    public System.Int64 CORRELATIVOAGNO
	    {
		    get { return _CORRELATIVO_AGNO; }
		    set { _CORRELATIVO_AGNO = value; }
	    }
	    
	    	
	    public System.String CORRELATIVOCLIENTE
	    {
		    get { return _CORRELATIVO_CLIENTE; }
		    set { _CORRELATIVO_CLIENTE = value; }
	    }
	    
	    	
	    public System.Int64 CODSENCE
	    {
		    get { return _COD_SENCE; }
		    set { _COD_SENCE = value; }
	    }
	    
	    	
	    public System.Int64 NUMEROACCIONSENCE
	    {
		    get { return _NUMERO_ACCION_SENCE; }
		    set { _NUMERO_ACCION_SENCE = value; }
	    }
	    
	    	
	    public System.Decimal CODESTADOCURSO
	    {
		    get { return _COD_ESTADO_CURSO; }
		    set { _COD_ESTADO_CURSO = value; }
	    }
	    
	    	
	    public System.Decimal CODTIPOCONTRATO
	    {
		    get { return _COD_TIPO_CONTRATO; }
		    set { _COD_TIPO_CONTRATO = value; }
	    }
	    
	    	
	    public System.String DIRECCIONCURSO
	    {
		    get { return _DIRECCION_CURSO; }
		    set { _DIRECCION_CURSO = value; }
	    }
	    
	    	
	    public System.String NRODIRECCIONCURSO
	    {
		    get { return _NRO_DIRECCION_CURSO; }
		    set { _NRO_DIRECCION_CURSO = value; }
	    }
	    
	    	
	    public System.String CIUDADCURSO
	    {
		    get { return _CIUDAD_CURSO; }
		    set { _CIUDAD_CURSO = value; }
	    }
	    
	    	
	    public System.Int64 CODCOMUNA
	    {
		    get { return _COD_COMUNA; }
		    set { _COD_COMUNA = value; }
	    }
	    
	    	
	    public System.DateTime FECHACREACION
	    {
		    get { return _FECHA_CREACION; }
		    set { _FECHA_CREACION = value; }
	    }
	    
	    	
	    public System.DateTime FECHAINICIO
	    {
		    get { return _FECHA_INICIO; }
		    set { _FECHA_INICIO = value; }
	    }
	    
	    	
	    public System.DateTime FECHATERMINO
	    {
		    get { return _FECHA_TERMINO; }
		    set { _FECHA_TERMINO = value; }
	    }
	    
	    	
	    public System.Int32 HORASCURSO
	    {
		    get { return _HORAS_CURSO; }
		    set { _HORAS_CURSO = value; }
	    }
	    
	    	
	    public System.DateTime FECHACOMUNICACION
	    {
		    get { return _FECHA_COMUNICACION; }
		    set { _FECHA_COMUNICACION = value; }
	    }
	    
	    	
	    public System.DateTime FECHALIQUIDACION
	    {
		    get { return _FECHA_LIQUIDACION; }
		    set { _FECHA_LIQUIDACION = value; }
	    }
	    
	    	
	    public System.DateTime FECHAPAGO
	    {
		    get { return _FECHA_PAGO; }
		    set { _FECHA_PAGO = value; }
	    }
	    
	    	
	    public System.Boolean COMITEBIPARTITO
	    {
		    get { return _COMITE_BIPARTITO; }
		    set { _COMITE_BIPARTITO = value; }
	    }
	    
	    	
	    public System.Boolean DNC
	    {
		    get { return _DNC; }
		    set { _DNC = value; }
	    }
	    
	    	
	    public System.Int64 MONTODESCUENTO
	    {
		    get { return _MONTO_DESCUENTO; }
		    set { _MONTO_DESCUENTO = value; }
	    }
	    
	    	
	    public System.Int32 NROALUMOS
	    {
		    get { return _NRO_ALUMOS; }
		    set { _NRO_ALUMOS = value; }
	    }
	    
	    	
	    public System.Double NOTAMINIMA
	    {
		    get { return _NOTA_MINIMA; }
		    set { _NOTA_MINIMA = value; }
	    }
	    
	    	
	    public System.String OBSERVACIONCURSO
	    {
		    get { return _OBSERVACION_CURSO; }
		    set { _OBSERVACION_CURSO = value; }
	    }
	    
	    	
	    public System.Int32 HORASCOMPLEMENTO
	    {
		    get { return _HORAS_COMPLEMENTO; }
		    set { _HORAS_COMPLEMENTO = value; }
	    }
	    
	    	
	    public System.Decimal CORRELATIVOCOMPLEMENTARIO
	    {
		    get { return _CORRELATIVO_COMPLEMENTARIO; }
		    set { _CORRELATIVO_COMPLEMENTARIO = value; }
	    }
	    
	    
	    #endregion
	    
        #region Methods
        
        protected override DLBase GetMapper()
        {
            return new DLCURSOCAPACITACION();
        }

        #endregion	    
    }
}