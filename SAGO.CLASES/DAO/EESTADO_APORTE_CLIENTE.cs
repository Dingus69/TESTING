
using System;
using SAGO.CLASES.DAL;


namespace SAGO.CLASES.DAO
{
	/// <summary>
	/// Summary description for EESTADOAPORTECLIENTE.
	/// </summary>
    public class EESTADOAPORTECLIENTE : DomainObject
    {
	    	
	    private System.Decimal  _COD_ESTADO_APORTE_CLIENTE = 0;
        	
	    private System.String  _ESTADO_APORTE_CLIENTE = String.Empty;
        	
        
	    public EESTADOAPORTECLIENTE() : base()
	    {
	    }
	    
		public EESTADOAPORTECLIENTE(long id) : base(id)
		{
		}
        
        #region Properties    	
	    	
	    public System.Decimal CODESTADOAPORTECLIENTE
	    {
		    get { return _COD_ESTADO_APORTE_CLIENTE; }
		    set { _COD_ESTADO_APORTE_CLIENTE = value; }
	    }
	    
	    	
	    public System.String ESTADOAPORTECLIENTE
	    {
		    get { return _ESTADO_APORTE_CLIENTE; }
		    set { _ESTADO_APORTE_CLIENTE = value; }
	    }
	    
	    
	    #endregion
	    
        #region Methods
        
        protected override DLBase GetMapper()
        {
            return new DLESTADOAPORTECLIENTE();
        }

        #endregion	    
    }
}