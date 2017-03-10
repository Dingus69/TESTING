
using System;
using SAGO.CLASES.DAL;


namespace SAGO.CLASES.DAO
{
	/// <summary>
	/// Summary description for ETIPOCONTRATO.
	/// </summary>
    public class ETIPOCONTRATO : DomainObject
    {
	    	
	    private System.Decimal  _COD_TIPO_CONTRATO = 0;
        	
	    private System.String  _TIPO_CONTRATO = String.Empty;
        	
        
	    public ETIPOCONTRATO() : base()
	    {
	    }
	    
		public ETIPOCONTRATO(long id) : base(id)
		{
		}
        
        #region Properties    	
	    	
	    public System.Decimal CODTIPOCONTRATO
	    {
		    get { return _COD_TIPO_CONTRATO; }
		    set { _COD_TIPO_CONTRATO = value; }
	    }
	    
	    	
	    public System.String TIPOCONTRATO
	    {
		    get { return _TIPO_CONTRATO; }
		    set { _TIPO_CONTRATO = value; }
	    }
	    
	    
	    #endregion
	    
        #region Methods
        
        protected override DLBase GetMapper()
        {
            return new DLTIPOCONTRATO();
        }

        #endregion	    
    }
}