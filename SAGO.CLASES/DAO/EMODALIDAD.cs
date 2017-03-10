
using System;
using SAGO.CLASES.DAL;


namespace SAGO.CLASES.DAO
{
	/// <summary>
	/// Summary description for EMODALIDAD.
	/// </summary>
    public class EMODALIDAD : DomainObject
    {
	    	
	    private System.Decimal  _COD_MODALIDAD = 0;
        	
	    private System.String  _MODALIDAD = String.Empty;
        	
        
	    public EMODALIDAD() : base()
	    {
	    }
	    
		public EMODALIDAD(long id) : base(id)
		{
		}
        
        #region Properties    	
	    	
	    public System.Decimal CODMODALIDAD
	    {
		    get { return _COD_MODALIDAD; }
		    set { _COD_MODALIDAD = value; }
	    }
	    
	    	
	    public System.String MODALIDAD
	    {
		    get { return _MODALIDAD; }
		    set { _MODALIDAD = value; }
	    }
	    
	    
	    #endregion
	    
        #region Methods
        
        protected override DLBase GetMapper()
        {
            return new DLMODALIDAD();
        }

        #endregion	    
    }
}