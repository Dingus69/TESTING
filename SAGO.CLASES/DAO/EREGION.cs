
using System;
using SAGO.CLASES.DAL;


namespace SAGO.CLASES.DAO
{
	/// <summary>
	/// Summary description for EREGION.
	/// </summary>
    public class EREGION : DomainObject
    {
	    	
	    private System.Int32  _COD_REGION = 0;
        	
	    private System.String  _REGION = String.Empty;
        	
        
	    public EREGION() : base()
	    {
	    }
	    
		public EREGION(long id) : base(id)
		{
		}
        
        #region Properties    	
	    	
	    public System.Int32 CODREGION
	    {
		    get { return _COD_REGION; }
		    set { _COD_REGION = value; }
	    }
	    
	    	
	    public System.String REGION
	    {
		    get { return _REGION; }
		    set { _REGION = value; }
	    }
	    
	    
	    #endregion
	    
        #region Methods
        
        protected override DLBase GetMapper()
        {
            return new DLREGION();
        }

        #endregion	    
    }
}