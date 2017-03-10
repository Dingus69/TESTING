
using System;
using SAGO.CLASES.DAL;


namespace SAGO.CLASES.DAO
{
	/// <summary>
	/// Summary description for EFRANQUICIASENCE.
	/// </summary>
    public class EFRANQUICIASENCE : DomainObject
    {
	    	
	    private System.Int32  _COD_FRANQUICIA_SENCE = 0;
        	
	    private System.Int32  _FRANQUICIA_SENCE = 0;
        	
        
	    public EFRANQUICIASENCE() : base()
	    {
	    }
	    
		public EFRANQUICIASENCE(long id) : base(id)
		{
		}
        
        #region Properties    	
	    	
	    public System.Int32 CODFRANQUICIASENCE
	    {
		    get { return _COD_FRANQUICIA_SENCE; }
		    set { _COD_FRANQUICIA_SENCE = value; }
	    }
	    
	    	
	    public System.Int32 FRANQUICIASENCE
	    {
		    get { return _FRANQUICIA_SENCE; }
		    set { _FRANQUICIA_SENCE = value; }
	    }
	    
	    
	    #endregion
	    
        #region Methods
        
        protected override DLBase GetMapper()
        {
            return new DLFRANQUICIASENCE();
        }

        #endregion	    
    }
}