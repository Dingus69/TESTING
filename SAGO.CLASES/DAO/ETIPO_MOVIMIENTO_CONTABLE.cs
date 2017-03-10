
using System;
using SAGO.CLASES.DAL;


namespace SAGO.CLASES.DAO
{
	/// <summary>
	/// Summary description for ETIPOMOVIMIENTOCONTABLE.
	/// </summary>
    public class ETIPOMOVIMIENTOCONTABLE : DomainObject
    {
	    	
	    private System.Decimal  _COD_TIPO_MOVIMIENTO_CONTABLE = 0;
        	
	    private System.String  _TIPO_MOVIMIENTO = String.Empty;
        	
        
	    public ETIPOMOVIMIENTOCONTABLE() : base()
	    {
	    }
	    
		public ETIPOMOVIMIENTOCONTABLE(long id) : base(id)
		{
		}
        
        #region Properties    	
	    	
	    public System.Decimal CODTIPOMOVIMIENTOCONTABLE
	    {
		    get { return _COD_TIPO_MOVIMIENTO_CONTABLE; }
		    set { _COD_TIPO_MOVIMIENTO_CONTABLE = value; }
	    }
	    
	    	
	    public System.String TIPOMOVIMIENTO
	    {
		    get { return _TIPO_MOVIMIENTO; }
		    set { _TIPO_MOVIMIENTO = value; }
	    }
	    
	    
	    #endregion
	    
        #region Methods
        
        protected override DLBase GetMapper()
        {
            return new DLTIPOMOVIMIENTOCONTABLE();
        }

        #endregion	    
    }
}