
using System;
using SAGO.CLASES.DAL;


namespace SAGO.CLASES.DAO
{
	/// <summary>
	/// Summary description for ESEXO.
	/// </summary>
    public class ESEXO : DomainObject
    {
	    	
	    private System.String  _COD_SEXO = String.Empty;
        	
	    private System.String  _SEXO = String.Empty;
        	
        
	    public ESEXO() : base()
	    {
	    }
	    
		public ESEXO(long id) : base(id)
		{
		}
        
        #region Properties    	
	    	
	    public System.String CODSEXO
	    {
		    get { return _COD_SEXO; }
		    set { _COD_SEXO = value; }
	    }
	    
	    	
	    public System.String SEXO
	    {
		    get { return _SEXO; }
		    set { _SEXO = value; }
	    }
	    
	    
	    #endregion
	    
        #region Methods
        
        protected override DLBase GetMapper()
        {
            return new DLSEXO();
        }

        #endregion	    
    }
}