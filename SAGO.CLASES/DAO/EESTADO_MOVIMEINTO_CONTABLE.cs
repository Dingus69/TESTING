
using System;
using SAGO.CLASES.DAL;


namespace SAGO.CLASES.DAO
{
	/// <summary>
	/// Summary description for EESTADOMOVIMEINTOCONTABLE.
	/// </summary>
    public class EESTADOMOVIMEINTOCONTABLE : DomainObject
    {
	    	
	    private System.Decimal  _COD_ESTADO_MOVIMEINTO_CONTABLE = 0;
        	
	    private System.String  _ESTADO_MOVIMIENTO = String.Empty;
        	
        
	    public EESTADOMOVIMEINTOCONTABLE() : base()
	    {
	    }
	    
		public EESTADOMOVIMEINTOCONTABLE(long id) : base(id)
		{
		}
        
        #region Properties    	
	    	
	    public System.Decimal CODESTADOMOVIMEINTOCONTABLE
	    {
		    get { return _COD_ESTADO_MOVIMEINTO_CONTABLE; }
		    set { _COD_ESTADO_MOVIMEINTO_CONTABLE = value; }
	    }
	    
	    	
	    public System.String ESTADOMOVIMIENTO
	    {
		    get { return _ESTADO_MOVIMIENTO; }
		    set { _ESTADO_MOVIMIENTO = value; }
	    }
	    
	    
	    #endregion
	    
        #region Methods
        
        protected override DLBase GetMapper()
        {
            return new DLESTADOMOVIMEINTOCONTABLE();
        }

        #endregion	    
    }
}