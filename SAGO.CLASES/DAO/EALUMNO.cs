
using System;
using SAGO.CLASES.DAL;


namespace SAGO.CLASES.DAO
{
	/// <summary>
	/// Summary description for EALUMNO.
	/// </summary>
    public class EALUMNO : DomainObject
    {
	    	
	    private System.Int64  _RUT_EMPLEADO = 0;
        	
	    private System.Decimal  _CORRELATIVO = 0;
        	
	    private System.Int64  _RUT_CLIENTE = 0;
        	
	    private System.Int32  _COD_OCUPACION = 0;
        	
	    private System.String  _COD_CENTRO_COSTO = String.Empty;
        	
	    private System.Int32  _COD_FRANQUICIA_SENCE = 0;
        	
	    private System.Int32  _COD_FRANQUICIA_ECCL = 0;
        	
	    private System.Int32  _COD_EDUCACION = 0;
        	
	    private System.String  _COD_CARGO = String.Empty;
        	
	    private System.Int64  _COD_COMUNA = 0;
        	
	    private System.Double  _ASISTENCIA = null;
        	
	    private System.Double  _EVALUACION = null;
        	
        
	    public EALUMNO() : base()
	    {
	    }
	    
		public EALUMNO(long id) : base(id)
		{
		}
        
        #region Properties    	
	    	
	    public System.Int64 RUTEMPLEADO
	    {
		    get { return _RUT_EMPLEADO; }
		    set { _RUT_EMPLEADO = value; }
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
	    
	    	
	    public System.Int32 CODOCUPACION
	    {
		    get { return _COD_OCUPACION; }
		    set { _COD_OCUPACION = value; }
	    }
	    
	    	
	    public System.String CODCENTROCOSTO
	    {
		    get { return _COD_CENTRO_COSTO; }
		    set { _COD_CENTRO_COSTO = value; }
	    }
	    
	    	
	    public System.Int32 CODFRANQUICIASENCE
	    {
		    get { return _COD_FRANQUICIA_SENCE; }
		    set { _COD_FRANQUICIA_SENCE = value; }
	    }
	    
	    	
	    public System.Int32 CODFRANQUICIAECCL
	    {
		    get { return _COD_FRANQUICIA_ECCL; }
		    set { _COD_FRANQUICIA_ECCL = value; }
	    }
	    
	    	
	    public System.Int32 CODEDUCACION
	    {
		    get { return _COD_EDUCACION; }
		    set { _COD_EDUCACION = value; }
	    }
	    
	    	
	    public System.String CODCARGO
	    {
		    get { return _COD_CARGO; }
		    set { _COD_CARGO = value; }
	    }
	    
	    	
	    public System.Int64 CODCOMUNA
	    {
		    get { return _COD_COMUNA; }
		    set { _COD_COMUNA = value; }
	    }
	    
	    	
	    public System.Double ASISTENCIA
	    {
		    get { return _ASISTENCIA; }
		    set { _ASISTENCIA = value; }
	    }
	    
	    	
	    public System.Double EVALUACION
	    {
		    get { return _EVALUACION; }
		    set { _EVALUACION = value; }
	    }
	    
	    
	    #endregion
	    
        #region Methods
        
        protected override DLBase GetMapper()
        {
            return new DLALUMNO();
        }

        #endregion	    
    }
}