
using System;
using SAGO.CLASES.DAL;


namespace SAGO.CLASES.DAO
{
	/// <summary>
	/// Summary description for ECARGO.
	/// </summary>
    public class ECARGO : DomainObject
    {
	    	
	    private System.Int64  _RUT_CLIENTE = 0;
        	
	    private System.String  _COD_CARGO = String.Empty;
        	
	    private System.String  _CARGO = String.Empty;
        	
        
	    public ECARGO() : base()
	    {
	    }
	    
		public ECARGO(long id) : base(id)
		{
		}
        
        #region Properties    	
	    	
	    public System.Int64 RUTCLIENTE
	    {
		    get { return _RUT_CLIENTE; }
		    set { _RUT_CLIENTE = value; }
	    }
	    
	    	
	    public System.String CODCARGO
	    {
		    get { return _COD_CARGO; }
		    set { _COD_CARGO = value; }
	    }
	    
	    	
	    public System.String CARGO
	    {
		    get { return _CARGO; }
		    set { _CARGO = value; }
	    }
	    
	    
	    #endregion
	    
        #region Methods
        
        protected override DLBase GetMapper()
        {
            return new DLCARGO();
        }

        #endregion	    
    }
}