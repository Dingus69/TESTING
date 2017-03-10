
using System;
using SAGO.CLASES.DAL;


namespace SAGO.CLASES.DAO
{
	/// <summary>
	/// Summary description for EOCUPACIONSENCE.
	/// </summary>
    public class EOCUPACIONSENCE : DomainObject
    {
	    	
	    private System.Int32  _COD_OCUPACION = 0;
        	
	    private System.String  _OCUPACION = String.Empty;
        	
        
	    public EOCUPACIONSENCE() : base()
	    {
	    }
	    
		public EOCUPACIONSENCE(long id) : base(id)
		{
		}
        
        #region Properties    	
	    	
	    public System.Int32 CODOCUPACION
	    {
		    get { return _COD_OCUPACION; }
		    set { _COD_OCUPACION = value; }
	    }
	    
	    	
	    public System.String OCUPACION
	    {
		    get { return _OCUPACION; }
		    set { _OCUPACION = value; }
	    }
	    
	    
	    #endregion
	    
        #region Methods
        
        protected override DLBase GetMapper()
        {
            return new DLOCUPACIONSENCE();
        }

        #endregion	    
    }
}