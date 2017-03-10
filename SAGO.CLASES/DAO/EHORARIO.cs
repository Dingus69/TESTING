
using System;
using SAGO.CLASES.DAL;


namespace SAGO.CLASES.DAO
{
	/// <summary>
	/// Summary description for EHORARIO.
	/// </summary>
    public class EHORARIO : DomainObject
    {
	    	
	    private System.Decimal  _CORRELATIVO = 0;
        	
	    private System.Int32  _DIA = 0;

        private System.String _HORA_INICIO = String.Empty;

        private System.String _HORA_FIN = String.Empty;
        	
        
	    public EHORARIO() : base()
	    {
	    }
	    
		public EHORARIO(long id) : base(id)
		{
		}
        
        #region Properties    	
	    	
	    public System.Decimal CORRELATIVO
	    {
		    get { return _CORRELATIVO; }
		    set { _CORRELATIVO = value; }
	    }
	    
	    	
	    public System.Int32 DIA
	    {
		    get { return _DIA; }
		    set { _DIA = value; }
	    }
	    
	    	
	    public System.String HORAINICIO
	    {
		    get { return _HORA_INICIO; }
		    set { _HORA_INICIO = value; }
	    }


        public System.String HORAFIN
	    {
		    get { return _HORA_FIN; }
		    set { _HORA_FIN = value; }
	    }
	    
	    
	    #endregion
	    
        #region Methods
        
        protected override DLBase GetMapper()
        {
            return new DLHORARIO();
        }

        #endregion	    
    }
}