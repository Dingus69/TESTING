
using System;
using System.Data;
using SAGO.DATAACCESS;
using SAGO.CLASES.DAO;
using SAGO.COMMON;

namespace SAGO.CLASES.DAL
{
	/// <summary>
	/// Summary description for DLESTADOMOVIMEINTOCONTABLE.
	/// </summary>
	public class DLESTADOMOVIMEINTOCONTABLE : DLBase
	{
		public DLESTADOMOVIMEINTOCONTABLE()
		{
		}

        #region Protected Methods

        protected override string GetDeleteProcedure()
        {
            return "proc_delete_ESTADO_MOVIMEINTO_CONTABLE";
        }

        protected override string GetInsertProcedure()
        {
            return "proc_insert_ESTADO_MOVIMEINTO_CONTABLE";
        }

        protected override string GetSelectProcedure()
        {
            return "proc_select_ESTADO_MOVIMEINTO_CONTABLE";
        }

        protected override string GetUpdateProcedure()
        {
            return "proc_update_ESTADO_MOVIMEINTO_CONTABLE";
        }

        protected override IDbDataParameter[] GetSelectParameters(long id, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);

            prms[0] = db.GetParameter();
            prms[0].Value = id;
            prms[0].ParameterName = "@COD_ESTADO_MOVIMEINTO_CONTABLE";

            return prms;
        }

        protected override IDbDataParameter[] GetDeleteParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            EESTADOMOVIMEINTOCONTABLE objESTADOMOVIMEINTOCONTABLE = obj as EESTADOMOVIMEINTOCONTABLE;

            prms[0] = db.GetParameter();
            prms[0].Value = objESTADOMOVIMEINTOCONTABLE.CODESTADOMOVIMEINTOCONTABLE;
            prms[0].ParameterName = "@COD_ESTADO_MOVIMEINTO_CONTABLE";

            return prms;
        }

        protected override IDbDataParameter[] GetInsertParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            EESTADOMOVIMEINTOCONTABLE objESTADOMOVIMEINTOCONTABLE = obj as EESTADOMOVIMEINTOCONTABLE;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objESTADOMOVIMEINTOCONTABLE.ESTADOMOVIMIENTO;
            prms[1].ParameterName = "@ESTADO_MOVIMIENTO";
            
            return prms;
        }

        protected override IDbDataParameter[] GetUpdateParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(2);
            EESTADOMOVIMEINTOCONTABLE objESTADOMOVIMEINTOCONTABLE = obj as EESTADOMOVIMEINTOCONTABLE;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[0] = db.GetParameter();
            prms[0].Value = objESTADOMOVIMEINTOCONTABLE.CODESTADOMOVIMEINTOCONTABLE;
            prms[0].ParameterName = "@COD_ESTADO_MOVIMEINTO_CONTABLE";
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objESTADOMOVIMEINTOCONTABLE.ESTADOMOVIMIENTO;
            prms[1].ParameterName = "@ESTADO_MOVIMIENTO";
            
            return prms;
        }

        protected override void SetPrimaryKey(DomainObject obj, long id)
        {
            EESTADOMOVIMEINTOCONTABLE objRoot = obj as EESTADOMOVIMEINTOCONTABLE;

            objRoot.CODESTADOMOVIMEINTOCONTABLE = id;
        }

        #endregion

        #region Public Methods

         public override void Fill(DomainObject obj, IDataReader dr)
        {
            EESTADOMOVIMEINTOCONTABLE objESTADOMOVIMEINTOCONTABLE = obj as EESTADOMOVIMEINTOCONTABLE;
    
            //Poner las rutinas del Tools que se necesiten
            
            objESTADOMOVIMEINTOCONTABLE.CODESTADOMOVIMEINTOCONTABLE = Utiles.ConvertToDecimal(dr["COD_ESTADO_MOVIMEINTO_CONTABLE"]);
            
            objESTADOMOVIMEINTOCONTABLE.ESTADOMOVIMIENTO = Utiles.ConvertToString(dr["ESTADO_MOVIMIENTO"]);
            
        }
        
        #endregion

	}
}
