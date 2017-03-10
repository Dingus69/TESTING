
using System;
using SAGO.CLASES.DAL;


namespace SAGO.CLASES.DAO
{
	/// <summary>
	/// Summary description for EMOVIMIENTOAPORTE.
	/// </summary>
    public class EMOVIMIENTOAPORTE : DomainObject
    {
	    	
	    private System.Decimal  _COD_APORTE = 0;
        	
	    private System.Decimal  _COD_MOVIENTO = 0;
        	
        
	    public EMOVIMIENTOAPORTE() : base()
	    {
	    }
	    
		public EMOVIMIENTOAPORTE(long id) : base(id)
		{
		}
        
        #region Properties    	
	    	
	    public System.Decimal CODAPORTE
	    {
		    get { return _COD_APORTE; }
		    set { _COD_APORTE = value; }
	    }
	    
	    	
	    public System.Decimal CODMOVIENTO
	    {
		    get { return _COD_MOVIENTO; }
		    set { _COD_MOVIENTO = value; }
	    }
	    
	    
	    #endregion
	    
        #region Methods
        
        protected override DLBase GetMapper()
        {
            return new DLMOVIMIENTOAPORTE();
        }

        #endregion	    
    }
}