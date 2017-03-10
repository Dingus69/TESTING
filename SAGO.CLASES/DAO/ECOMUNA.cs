
using System;
using SAGO.CLASES.DAL;


namespace SAGO.CLASES.DAO
{
	/// <summary>
	/// Summary description for ECOMUNA.
	/// </summary>
    public class ECOMUNA : DomainObject
    {
	    	
	    private System.Int64  _COD_COMUNA = 0;
        	
	    private System.Int32  _COD_REGION = 0;
        	
	    private System.String  _COMUNA = String.Empty;
        	
        
	    public ECOMUNA() : base()
	    {
	    }
	    
		public ECOMUNA(long id) : base(id)
		{
		}
        
        #region Properties    	
	    	
	    public System.Int64 CODCOMUNA
	    {
		    get { return _COD_COMUNA; }
		    set { _COD_COMUNA = value; }
	    }
	    
	    	
	    public System.Int32 CODREGION
	    {
		    get { return _COD_REGION; }
		    set { _COD_REGION = value; }
	    }
	    
	    	
	    public System.String COMUNA
	    {
		    get { return _COMUNA; }
		    set { _COMUNA = value; }
	    }
	    
	    
	    #endregion
	    
        #region Methods
        
        protected override DLBase GetMapper()
        {
            return new DLCOMUNA();
        }

        #endregion	    
    }
}