
using System;
using SAGO.CLASES.DAL;


namespace SAGO.CLASES.DAO
{
	/// <summary>
	/// Summary description for ETIPOAPORTECLIENTE.
	/// </summary>
    public class ETIPOAPORTECLIENTE : DomainObject
    {
	    	
	    private System.Decimal  _COD_TIPO_APORTE_CLIENTE = 0;
        	
	    private System.String  _TIPO_APORTE_CLIENTE = String.Empty;
        	
        
	    public ETIPOAPORTECLIENTE() : base()
	    {
	    }
	    
		public ETIPOAPORTECLIENTE(long id) : base(id)
		{
		}
        
        #region Properties    	
	    	
	    public System.Decimal CODTIPOAPORTECLIENTE
	    {
		    get { return _COD_TIPO_APORTE_CLIENTE; }
		    set { _COD_TIPO_APORTE_CLIENTE = value; }
	    }
	    
	    	
	    public System.String TIPOAPORTECLIENTE
	    {
		    get { return _TIPO_APORTE_CLIENTE; }
		    set { _TIPO_APORTE_CLIENTE = value; }
	    }
	    
	    
	    #endregion
	    
        #region Methods
        
        protected override DLBase GetMapper()
        {
            return new DLTIPOAPORTECLIENTE();
        }

        #endregion	    
    }
}