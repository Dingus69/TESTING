
using System;
using SAGO.CLASES.DAL;


namespace SAGO.CLASES.DAO
{
	/// <summary>
	/// Summary description for EMOVIMIENTOCONTABLE.
	/// </summary>
    public class EMOVIMIENTOCONTABLE : DomainObject
    {
	    	
	    private System.Decimal  _COD_MOVIENTO = 0;
        	
	    private System.Decimal  _COD_TIPO_MOVIMIENTO_CONTABLE = 0;
        	
	    private System.Int32  _COD_CUENTA = 0;
        	
	    private System.Decimal  _COD_ESTADO_MOVIMEINTO_CONTABLE = 0;
        	
	    private System.Decimal  _CORRELATIVO = 0;
        	
	    private System.Int64  _RUT_CLIENTE = 0;
        	
	    private System.DateTime  _FECHA_HORA_MOVIMIENTO = Datetime.Now;
        	
	    private System.String  _DESCRIPCION_MOVIMIENTO = String.Empty;

        private System.Int64 _MONTO = 0;
        	
        
	    public EMOVIMIENTOCONTABLE() : base()
	    {
	    }
	    
		public EMOVIMIENTOCONTABLE(long id) : base(id)
		{
		}
        
        #region Properties    	
	    	
	    public System.Decimal CODMOVIENTO
	    {
		    get { return _COD_MOVIENTO; }
		    set { _COD_MOVIENTO = value; }
	    }
	    
	    	
	    public System.Decimal CODTIPOMOVIMIENTOCONTABLE
	    {
		    get { return _COD_TIPO_MOVIMIENTO_CONTABLE; }
		    set { _COD_TIPO_MOVIMIENTO_CONTABLE = value; }
	    }
	    
	    	
	    public System.Int32 CODCUENTA
	    {
		    get { return _COD_CUENTA; }
		    set { _COD_CUENTA = value; }
	    }
	    
	    	
	    public System.Decimal CODESTADOMOVIMEINTOCONTABLE
	    {
		    get { return _COD_ESTADO_MOVIMEINTO_CONTABLE; }
		    set { _COD_ESTADO_MOVIMEINTO_CONTABLE = value; }
	    }
	    
	    	
	    public System.Decimal CORRELATIVO
	    {
		    get { return _CORRELATIVO; }
		    set { _CORRELATIVO = value; }
	    }
	    
	    	
	    public System.Int64 RUTCLIENTE
	    {
		    get { return _RUT_CLIENTE; }
		    set { _RUT_CLIENTE = value; }
	    }
	    
	    	
	    public System.DateTime FECHAHORAMOVIMIENTO
	    {
		    get { return _FECHA_HORA_MOVIMIENTO; }
		    set { _FECHA_HORA_MOVIMIENTO = value; }
	    }
	    
	    	
	    public System.String DESCRIPCIONMOVIMIENTO
	    {
		    get { return _DESCRIPCION_MOVIMIENTO; }
		    set { _DESCRIPCION_MOVIMIENTO = value; }
	    }


        public System.Int64 MONTO
	    {
		    get { return _MONTO; }
		    set { _MONTO = value; }
	    }
	    
	    
	    #endregion
	    
        #region Methods
        
        protected override DLBase GetMapper()
        {
            return new DLMOVIMIENTOCONTABLE();
        }

        #endregion	    
    }
}