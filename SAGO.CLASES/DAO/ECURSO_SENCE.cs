
using System;
using SAGO.CLASES.DAL;


namespace SAGO.CLASES.DAO
{
	/// <summary>
	/// Summary description for ECURSOSENCE.
	/// </summary>
    public class ECURSOSENCE : DomainObject
    {
	    	
	    private System.Int64  _COD_SENCE = 0;
        	
	    private System.Decimal  _COD_MODALIDAD = 0;
        	
	    private System.Int64  _RUT_OTEC = 0;
        	
	    private System.String  _NOMBRE_SENCE = String.Empty;
        	
	    private System.Int32  _HORAS_TEORICAS = 0;
        	
	    private System.Int32  _HORAS_PRACTICAS = 0;
        	
	    private System.Int32  _HORAS_ELEARNING = 0;
        	
	    private System.Int32  _NUMERO_PARTICIPANTE = 0;
        	
	    private System.String  _AREA = String.Empty;
        	
	    private System.String  _ESPECIALIDAD = String.Empty;
        	
	    private System.Int64  _VALOR_CURSO = 0;
        	
	    private System.Int64  _VALOR_EFECTIVO_PARTICIPANTE = 0;
        	
	    private System.Int64  _VALOR_IMPUTABLE_PARTICITANTE = 0;
        	
        
	    public ECURSOSENCE() : base()
	    {
	    }
	    
		public ECURSOSENCE(long id) : base(id)
		{
		}
        
        #region Properties    	
	    	
	    public System.Int64 CODSENCE
	    {
		    get { return _COD_SENCE; }
		    set { _COD_SENCE = value; }
	    }
	    
	    	
	    public System.Decimal CODMODALIDAD
	    {
		    get { return _COD_MODALIDAD; }
		    set { _COD_MODALIDAD = value; }
	    }
	    
	    	
	    public System.Int64 RUTOTEC
	    {
		    get { return _RUT_OTEC; }
		    set { _RUT_OTEC = value; }
	    }
	    
	    	
	    public System.String NOMBRESENCE
	    {
		    get { return _NOMBRE_SENCE; }
		    set { _NOMBRE_SENCE = value; }
	    }
	    
	    	
	    public System.Int32 HORASTEORICAS
	    {
		    get { return _HORAS_TEORICAS; }
		    set { _HORAS_TEORICAS = value; }
	    }
	    
	    	
	    public System.Int32 HORASPRACTICAS
	    {
		    get { return _HORAS_PRACTICAS; }
		    set { _HORAS_PRACTICAS = value; }
	    }
	    
	    	
	    public System.Int32 HORASELEARNING
	    {
		    get { return _HORAS_ELEARNING; }
		    set { _HORAS_ELEARNING = value; }
	    }
	    
	    	
	    public System.Int32 NUMEROPARTICIPANTE
	    {
		    get { return _NUMERO_PARTICIPANTE; }
		    set { _NUMERO_PARTICIPANTE = value; }
	    }
	    
	    	
	    public System.String AREA
	    {
		    get { return _AREA; }
		    set { _AREA = value; }
	    }
	    
	    	
	    public System.String ESPECIALIDAD
	    {
		    get { return _ESPECIALIDAD; }
		    set { _ESPECIALIDAD = value; }
	    }
	    
	    	
	    public System.Int64 VALORCURSO
	    {
		    get { return _VALOR_CURSO; }
		    set { _VALOR_CURSO = value; }
	    }
	    
	    	
	    public System.Int64 VALOREFECTIVOPARTICIPANTE
	    {
		    get { return _VALOR_EFECTIVO_PARTICIPANTE; }
		    set { _VALOR_EFECTIVO_PARTICIPANTE = value; }
	    }
	    
	    	
	    public System.Int64 VALORIMPUTABLEPARTICITANTE
	    {
		    get { return _VALOR_IMPUTABLE_PARTICITANTE; }
		    set { _VALOR_IMPUTABLE_PARTICITANTE = value; }
	    }
	    
	    
	    #endregion
	    
        #region Methods
        
        protected override DLBase GetMapper()
        {
            return new DLCURSOSENCE();
        }

        #endregion	    
    }
}