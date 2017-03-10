
using System;
using SAGO.CLASES.DAL;


namespace SAGO.CLASES.DAO
{
	/// <summary>
	/// Summary description for EEMPLEADO.
	/// </summary>
    public class EEMPLEADO : DomainObject
    {
	    	
	    private System.Int64  _RUT_EMPLEADO = 0;
        	
	    private System.String  _NOMBRE = String.Empty;
        	
	    private System.String  _AP_PATERNO = String.Empty;
        	
	    private System.String  _AP_MATERNO = String.Empty;
        	
	    private System.DateTime  _FECHA_NACIMIENTO = Datetime.Now;
        	
	    private System.DateTime  _FECHA_CONTRATO = Datetime.Now;
        	
	    private System.Int64  _RUT_CLIENTE = 0;
        	
	    private System.Int32  _COD_OCUPACION = 0;
        	
	    private System.Int32  _COD_EDUCACION = 0;
        	
	    private System.String  _COD_SEXO = String.Empty;
        	
	    private System.String  _COD_CENTRO_COSTO = String.Empty;
        	
	    private System.String  _COD_CARGO = String.Empty;
        	
	    private System.Int64  _COD_COMUNA = 0;
        	
	    private System.Int32  _COD_FRANQUICIA_ECCL = 0;
        	
	    private System.Int32  _COD_FRANQUICIA_SENCE = 0;
        	
        
	    public EEMPLEADO() : base()
	    {
	    }
	    
		public EEMPLEADO(long id) : base(id)
		{
		}
        
        #region Properties    	
	    	
	    public System.Int64 RUTEMPLEADO
	    {
		    get { return _RUT_EMPLEADO; }
		    set { _RUT_EMPLEADO = value; }
	    }
	    
	    	
	    public System.String NOMBRE
	    {
		    get { return _NOMBRE; }
		    set { _NOMBRE = value; }
	    }
	    
	    	
	    public System.String APPATERNO
	    {
		    get { return _AP_PATERNO; }
		    set { _AP_PATERNO = value; }
	    }
	    
	    	
	    public System.String APMATERNO
	    {
		    get { return _AP_MATERNO; }
		    set { _AP_MATERNO = value; }
	    }
	    
	    	
	    public System.DateTime FECHANACIMIENTO
	    {
		    get { return _FECHA_NACIMIENTO; }
		    set { _FECHA_NACIMIENTO = value; }
	    }
	    
	    	
	    public System.DateTime FECHACONTRATO
	    {
		    get { return _FECHA_CONTRATO; }
		    set { _FECHA_CONTRATO = value; }
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
	    
	    	
	    public System.Int32 CODEDUCACION
	    {
		    get { return _COD_EDUCACION; }
		    set { _COD_EDUCACION = value; }
	    }
	    
	    	
	    public System.String CODSEXO
	    {
		    get { return _COD_SEXO; }
		    set { _COD_SEXO = value; }
	    }
	    
	    	
	    public System.String CODCENTROCOSTO
	    {
		    get { return _COD_CENTRO_COSTO; }
		    set { _COD_CENTRO_COSTO = value; }
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
	    
	    	
	    public System.Int32 CODFRANQUICIAECCL
	    {
		    get { return _COD_FRANQUICIA_ECCL; }
		    set { _COD_FRANQUICIA_ECCL = value; }
	    }
	    
	    	
	    public System.Int32 CODFRANQUICIASENCE
	    {
		    get { return _COD_FRANQUICIA_SENCE; }
		    set { _COD_FRANQUICIA_SENCE = value; }
	    }
	    
	    
	    #endregion
	    
        #region Methods
        
        protected override DLBase GetMapper()
        {
            return new DLEMPLEADO();
        }

        #endregion	    
    }
}