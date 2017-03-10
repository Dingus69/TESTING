
using System;
using SAGO.CLASES.DAL;


namespace SAGO.CLASES.DAO
{
	/// <summary>
	/// Summary description for EEDUCACIONSENCE.
	/// </summary>
    public class EEDUCACIONSENCE : DomainObject
    {
	    	
	    private System.Int32  _COD_EDUCACION = 0;
        	
	    private System.String  _EDUCACION = String.Empty;
        	
        
	    public EEDUCACIONSENCE() : base()
	    {
	    }
	    
		public EEDUCACIONSENCE(long id) : base(id)
		{
		}
        
        #region Properties    	
	    	
	    public System.Int32 CODEDUCACION
	    {
		    get { return _COD_EDUCACION; }
		    set { _COD_EDUCACION = value; }
	    }
	    
	    	
	    public System.String EDUCACION
	    {
		    get { return _EDUCACION; }
		    set { _EDUCACION = value; }
	    }
	    
	    
	    #endregion
	    
        #region Methods
        
        protected override DLBase GetMapper()
        {
            return new DLEDUCACIONSENCE();
        }

        #endregion	    
    }
}