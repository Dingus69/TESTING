
using System;
using SAGO.CLASES.DAL;


namespace SAGO.CLASES.DAO
{
	/// <summary>
	/// Summary description for EFRANQUICIAECCL.
	/// </summary>
    public class EFRANQUICIAECCL : DomainObject
    {
	    	
	    private System.Int32  _COD_FRANQUICIA_ECCL = 0;
        	
	    private System.Int32  _FRANQUICIA_ECCL = 0;
        	
        
	    public EFRANQUICIAECCL() : base()
	    {
	    }
	    
		public EFRANQUICIAECCL(long id) : base(id)
		{
		}
        
        #region Properties    	
	    	
	    public System.Int32 CODFRANQUICIAECCL
	    {
		    get { return _COD_FRANQUICIA_ECCL; }
		    set { _COD_FRANQUICIA_ECCL = value; }
	    }
	    
	    	
	    public System.Int32 FRANQUICIAECCL
	    {
		    get { return _FRANQUICIA_ECCL; }
		    set { _FRANQUICIA_ECCL = value; }
	    }
	    
	    
	    #endregion
	    
        #region Methods
        
        protected override DLBase GetMapper()
        {
            return new DLFRANQUICIAECCL();
        }

        #endregion	    
    }
}