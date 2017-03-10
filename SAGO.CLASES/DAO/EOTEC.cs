
using System;
using SAGO.CLASES.DAL;


namespace SAGO.CLASES.DAO
{
	/// <summary>
	/// Summary description for EOTEC.
	/// </summary>
    public class EOTEC : DomainObject
    {
	    	
	    private System.Int64  _RUT_OTEC = 0;
        	
	    private System.String  _RAZON_SOCIAL_OTEC = String.Empty;
        	
	    private System.String  _NOMBRE_FANTASIA_OTEC = String.Empty;
        	
	    private System.String  _DIRECCION_OTEC = String.Empty;
        	
	    private System.String  _TELEFONO_OTEC = String.Empty;
        	
	    private System.String  _REPRESENTANTE_LEGAL_OTEC = String.Empty;
        	
	    private System.String  _EMAIL_OTEC = String.Empty;
        	
	    private System.String  _CONTACTO_OTEC = String.Empty;
        	
        
	    public EOTEC() : base()
	    {
	    }
	    
		public EOTEC(long id) : base(id)
		{
		}
        
        #region Properties    	
	    	
	    public System.Int64 RUTOTEC
	    {
		    get { return _RUT_OTEC; }
		    set { _RUT_OTEC = value; }
	    }
	    
	    	
	    public System.String RAZONSOCIALOTEC
	    {
		    get { return _RAZON_SOCIAL_OTEC; }
		    set { _RAZON_SOCIAL_OTEC = value; }
	    }
	    
	    	
	    public System.String NOMBREFANTASIAOTEC
	    {
		    get { return _NOMBRE_FANTASIA_OTEC; }
		    set { _NOMBRE_FANTASIA_OTEC = value; }
	    }
	    
	    	
	    public System.String DIRECCIONOTEC
	    {
		    get { return _DIRECCION_OTEC; }
		    set { _DIRECCION_OTEC = value; }
	    }
	    
	    	
	    public System.String TELEFONOOTEC
	    {
		    get { return _TELEFONO_OTEC; }
		    set { _TELEFONO_OTEC = value; }
	    }
	    
	    	
	    public System.String REPRESENTANTELEGALOTEC
	    {
		    get { return _REPRESENTANTE_LEGAL_OTEC; }
		    set { _REPRESENTANTE_LEGAL_OTEC = value; }
	    }
	    
	    	
	    public System.String EMAILOTEC
	    {
		    get { return _EMAIL_OTEC; }
		    set { _EMAIL_OTEC = value; }
	    }
	    
	    	
	    public System.String CONTACTOOTEC
	    {
		    get { return _CONTACTO_OTEC; }
		    set { _CONTACTO_OTEC = value; }
	    }
	    
	    
	    #endregion
	    
        #region Methods
        
        protected override DLBase GetMapper()
        {
            return new DLOTEC();
        }

        #endregion	    
    }
}