
using System;
using SAGO.CLASES.DAL;


namespace SAGO.CLASES.DAO
{
	/// <summary>
	/// Summary description for ETIPODOCTO.
	/// </summary>
    public class ETIPODOCTO : DomainObject
    {
	    	
	    private System.Decimal  _COD_TIPO_DOCTO = 0;
        	
	    private System.String  _TIPO_DOCTO = String.Empty;
        	
        
	    public ETIPODOCTO() : base()
	    {
	    }
	    
		public ETIPODOCTO(long id) : base(id)
		{
		}
        
        #region Properties    	
	    	
	    public System.Decimal CODTIPODOCTO
	    {
		    get { return _COD_TIPO_DOCTO; }
		    set { _COD_TIPO_DOCTO = value; }
	    }
	    
	    	
	    public System.String TIPODOCTO
	    {
		    get { return _TIPO_DOCTO; }
		    set { _TIPO_DOCTO = value; }
	    }
	    
	    
	    #endregion
	    
        #region Methods
        
        protected override DLBase GetMapper()
        {
            return new DLTIPODOCTO();
        }

        #endregion	    
    }
}