
using System;
using SAGO.CLASES.DAL;


namespace SAGO.CLASES.DAO
{
	/// <summary>
	/// Summary description for EAPORTECLIENTE.
	/// </summary>
    public class EAPORTECLIENTE : DomainObject
    {
	    	
	    private System.Decimal  _COD_APORTE = 0;
        	
	    private System.Decimal  _COD_TIPO_APORTE_CLIENTE = 0;
        	
	    private System.Decimal  _COD_ESTADO_APORTE_CLIENTE = 0;
        	
	    private System.Decimal  _COD_TIPO_DOCTO = 0;
        	
	    private System.Int64  _RUT_CLIENTE = 0;
        	
	    private System.Int32  _COD_CUENTA = 0;
        	
	    private System.Int32  _AGNO = 0;
        	
	    private System.DateTime  _FECHA_REALIZACION = Datetime.Now;
        	
	    private System.DateTime  _FECHA_COBRO = Datetime.Now;
        	
	    private System.DateTime  _FECHA_VENCIMIENTO_DOCTO = Datetime.Now;
        	
	    private System.Int64  _MONTO_NETO = 0;
        	
	    private System.Int64  _MONTO_ADMINISTRACION = 0;
        	
	    private System.String  _NUMERO_DOCTO = String.Empty;
        	
	    private System.String  _FOLIO = String.Empty;
        	
	    private System.String  _OBSERVACIONES_APORTE = String.Empty;
        	
        
	    public EAPORTECLIENTE() : base()
	    {
	    }
	    
		public EAPORTECLIENTE(long id) : base(id)
		{
		}
        
        #region Properties    	
	    	
	    public System.Decimal CODAPORTE
	    {
		    get { return _COD_APORTE; }
		    set { _COD_APORTE = value; }
	    }
	    
	    	
	    public System.Decimal CODTIPOAPORTECLIENTE
	    {
		    get { return _COD_TIPO_APORTE_CLIENTE; }
		    set { _COD_TIPO_APORTE_CLIENTE = value; }
	    }
	    
	    	
	    public System.Decimal CODESTADOAPORTECLIENTE
	    {
		    get { return _COD_ESTADO_APORTE_CLIENTE; }
		    set { _COD_ESTADO_APORTE_CLIENTE = value; }
	    }
	    
	    	
	    public System.Decimal CODTIPODOCTO
	    {
		    get { return _COD_TIPO_DOCTO; }
		    set { _COD_TIPO_DOCTO = value; }
	    }
	    
	    	
	    public System.Int64 RUTCLIENTE
	    {
		    get { return _RUT_CLIENTE; }
		    set { _RUT_CLIENTE = value; }
	    }
	    
	    	
	    public System.Int32 CODCUENTA
	    {
		    get { return _COD_CUENTA; }
		    set { _COD_CUENTA = value; }
	    }
	    
	    	
	    public System.Int32 AGNO
	    {
		    get { return _AGNO; }
		    set { _AGNO = value; }
	    }
	    
	    	
	    public System.DateTime FECHAREALIZACION
	    {
		    get { return _FECHA_REALIZACION; }
		    set { _FECHA_REALIZACION = value; }
	    }
	    
	    	
	    public System.DateTime FECHACOBRO
	    {
		    get { return _FECHA_COBRO; }
		    set { _FECHA_COBRO = value; }
	    }
	    
	    	
	    public System.DateTime FECHAVENCIMIENTODOCTO
	    {
		    get { return _FECHA_VENCIMIENTO_DOCTO; }
		    set { _FECHA_VENCIMIENTO_DOCTO = value; }
	    }
	    
	    	
	    public System.Int64 MONTONETO
	    {
		    get { return _MONTO_NETO; }
		    set { _MONTO_NETO = value; }
	    }
	    
	    	
	    public System.Int64 MONTOADMINISTRACION
	    {
		    get { return _MONTO_ADMINISTRACION; }
		    set { _MONTO_ADMINISTRACION = value; }
	    }
	    
	    	
	    public System.String NUMERODOCTO
	    {
		    get { return _NUMERO_DOCTO; }
		    set { _NUMERO_DOCTO = value; }
	    }
	    
	    	
	    public System.String FOLIO
	    {
		    get { return _FOLIO; }
		    set { _FOLIO = value; }
	    }
	    
	    	
	    public System.String OBSERVACIONESAPORTE
	    {
		    get { return _OBSERVACIONES_APORTE; }
		    set { _OBSERVACIONES_APORTE = value; }
	    }
	    
	    
	    #endregion
	    
        #region Methods
        
        protected override DLBase GetMapper()
        {
            return new DLAPORTECLIENTE();
        }

        #endregion	    
    }
}