
using System;
using SAGO.CLASES.DAL;


namespace SAGO.CLASES.DAO
{
	/// <summary>
	/// Summary description for ECLIENTE.
	/// </summary>
    public class ECLIENTE : DomainObject
    {
	    	
	    private System.Int64  _RUT_CLIENTE = 0;
        	
	    private System.Int64  _RUT_HOLDING = 0;
        	
	    private System.String  _RAZON_SOCIAL_CLIENTE = String.Empty;
        	
	    private System.String  _NOMBRE_FANTASIA_CLIENTE = String.Empty;
        	
	    private System.String  _DIRECCION_CLIENTE = String.Empty;
        	
	    private System.String  _NRO_DIRECCION_CLIENTE = String.Empty;
        	
	    private System.String  _EMIAL_CLIENTE = String.Empty;
        	
	    private System.String  _TELEFONO_CLIENTE = String.Empty;
        	
	    private System.String  _CONTACTO_CLIENTE = String.Empty;
        	
        
	    public ECLIENTE() : base()
	    {
	    }
	    
		public ECLIENTE(long id) : base(id)
		{
		}
        
        #region Properties    	
	    	
	    public System.Int64 RUTCLIENTE
	    {
		    get { return _RUT_CLIENTE; }
		    set { _RUT_CLIENTE = value; }
	    }
	    
	    	
	    public System.Int64 RUTHOLDING
	    {
		    get { return _RUT_HOLDING; }
		    set { _RUT_HOLDING = value; }
	    }
	    
	    	
	    public System.String RAZONSOCIALCLIENTE
	    {
		    get { return _RAZON_SOCIAL_CLIENTE; }
		    set { _RAZON_SOCIAL_CLIENTE = value; }
	    }
	    
	    	
	    public System.String NOMBREFANTASIACLIENTE
	    {
		    get { return _NOMBRE_FANTASIA_CLIENTE; }
		    set { _NOMBRE_FANTASIA_CLIENTE = value; }
	    }
	    
	    	
	    public System.String DIRECCIONCLIENTE
	    {
		    get { return _DIRECCION_CLIENTE; }
		    set { _DIRECCION_CLIENTE = value; }
	    }
	    
	    	
	    public System.String NRODIRECCIONCLIENTE
	    {
		    get { return _NRO_DIRECCION_CLIENTE; }
		    set { _NRO_DIRECCION_CLIENTE = value; }
	    }
	    
	    	
	    public System.String EMIALCLIENTE
	    {
		    get { return _EMIAL_CLIENTE; }
		    set { _EMIAL_CLIENTE = value; }
	    }
	    
	    	
	    public System.String TELEFONOCLIENTE
	    {
		    get { return _TELEFONO_CLIENTE; }
		    set { _TELEFONO_CLIENTE = value; }
	    }
	    
	    	
	    public System.String CONTACTOCLIENTE
	    {
		    get { return _CONTACTO_CLIENTE; }
		    set { _CONTACTO_CLIENTE = value; }
	    }
	    
	    
	    #endregion
	    
        #region Methods
        
        protected override DLBase GetMapper()
        {
            return new DLCLIENTE();
        }

        #endregion	    
    }
}