
using System;
using SAGO.CLASES.DAL;


namespace SAGO.CLASES.DAO
{
	/// <summary>
	/// Summary description for ECENTROCOSTO.
	/// </summary>
    public class ECENTROCOSTO : DomainObject
    {
	    	
	    private System.Int64  _RUT_CLIENTE = 0;
        	
	    private System.String  _COD_CENTRO_COSTO = String.Empty;
        	
	    private System.String  _CENTRO_COSTO = String.Empty;
        	
        
	    public ECENTROCOSTO() : base()
	    {
	    }
	    
		public ECENTROCOSTO(long id) : base(id)
		{
		}
        
        #region Properties    	
	    	
	    public System.Int64 RUTCLIENTE
	    {
		    get { return _RUT_CLIENTE; }
		    set { _RUT_CLIENTE = value; }
	    }
	    
	    	
	    public System.String CODCENTROCOSTO
	    {
		    get { return _COD_CENTRO_COSTO; }
		    set { _COD_CENTRO_COSTO = value; }
	    }
	    
	    	
	    public System.String CENTROCOSTO
	    {
		    get { return _CENTRO_COSTO; }
		    set { _CENTRO_COSTO = value; }
	    }
	    
	    
	    #endregion
	    
        #region Methods
        
        protected override DLBase GetMapper()
        {
            return new DLCENTROCOSTO();
        }

        #endregion	    
    }
}