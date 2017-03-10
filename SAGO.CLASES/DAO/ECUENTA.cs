
using System;
using SAGO.CLASES.DAL;


namespace SAGO.CLASES.DAO
{
	/// <summary>
	/// Summary description for ECUENTA.
	/// </summary>
    public class ECUENTA : DomainObject
    {
	    	
	    private System.Int32  _COD_CUENTA = 0;
        	
	    private System.String  _CUENTA = String.Empty;
        	
        
	    public ECUENTA() : base()
	    {
	    }
	    
		public ECUENTA(long id) : base(id)
		{
		}
        
        #region Properties    	
	    	
	    public System.Int32 CODCUENTA
	    {
		    get { return _COD_CUENTA; }
		    set { _COD_CUENTA = value; }
	    }
	    
	    	
	    public System.String CUENTA
	    {
		    get { return _CUENTA; }
		    set { _CUENTA = value; }
	    }
	    
	    
	    #endregion
	    
        #region Methods
        
        protected override DLBase GetMapper()
        {
            return new DLCUENTA();
        }

        #endregion	    
    }
}