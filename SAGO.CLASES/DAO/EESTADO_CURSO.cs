
using System;
using SAGO.CLASES.DAL;


namespace SAGO.CLASES.DAO
{
	/// <summary>
	/// Summary description for EESTADOCURSO.
	/// </summary>
    public class EESTADOCURSO : DomainObject
    {
	    	
	    private System.Decimal  _COD_ESTADO_CURSO = 0;
        	
	    private System.String  _ESTADO_CURSO = String.Empty;
        	
        
	    public EESTADOCURSO() : base()
	    {
	    }
	    
		public EESTADOCURSO(long id) : base(id)
		{
		}
        
        #region Properties    	
	    	
	    public System.Decimal CODESTADOCURSO
	    {
		    get { return _COD_ESTADO_CURSO; }
		    set { _COD_ESTADO_CURSO = value; }
	    }
	    
	    	
	    public System.String ESTADOCURSO
	    {
		    get { return _ESTADO_CURSO; }
		    set { _ESTADO_CURSO = value; }
	    }
	    
	    
	    #endregion
	    
        #region Methods
        
        protected override DLBase GetMapper()
        {
            return new DLESTADOCURSO();
        }

        #endregion	    
    }
}