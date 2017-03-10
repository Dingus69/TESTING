
using System;
using System.Data;
using SAGO.DATAACCESS;
using SAGO.CLASES.DAO;
using SAGO.COMMON;

namespace SAGO.CLASES.DAL
{
	/// <summary>
	/// Summary description for DLREGION.
	/// </summary>
	public class DLREGION : DLBase
	{
		public DLREGION()
		{
		}

        #region Protected Methods

        protected override string GetDeleteProcedure()
        {
            return "proc_delete_REGION";
        }

        protected override string GetInsertProcedure()
        {
            return "proc_insert_REGION";
        }

        protected override string GetSelectProcedure()
        {
            return "proc_select_REGION";
        }

        protected override string GetUpdateProcedure()
        {
            return "proc_update_REGION";
        }

        protected override IDbDataParameter[] GetSelectParameters(long id, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);

            prms[0] = db.GetParameter();
            prms[0].Value = id;
            prms[0].ParameterName = "@COD_REGION";

            return prms;
        }

        protected override IDbDataParameter[] GetDeleteParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            EREGION objREGION = obj as EREGION;

            prms[0] = db.GetParameter();
            prms[0].Value = objREGION.CODREGION;
            prms[0].ParameterName = "@COD_REGION";

            return prms;
        }

        protected override IDbDataParameter[] GetInsertParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            EREGION objREGION = obj as EREGION;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objREGION.REGION;
            prms[1].ParameterName = "@REGION";
            
            return prms;
        }

        protected override IDbDataParameter[] GetUpdateParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(2);
            EREGION objREGION = obj as EREGION;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[0] = db.GetParameter();
            prms[0].Value = objREGION.CODREGION;
            prms[0].ParameterName = "@COD_REGION";
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objREGION.REGION;
            prms[1].ParameterName = "@REGION";
            
            return prms;
        }

        protected override void SetPrimaryKey(DomainObject obj, int id)
        {
            EREGION objRoot = obj as EREGION;

            objRoot.CODREGION = id;
        }

        #endregion

        #region Public Methods

         public override void Fill(DomainObject obj, IDataReader dr)
        {
            EREGION objREGION = obj as EREGION;
    
            //Poner las rutinas del Tools que se necesiten
            
            objREGION.CODREGION = Utiles.ConvertToInt32(dr["COD_REGION"]);

            objREGION.REGION = Utiles.ConvertToString(dr["REGION"]);
            
        }

        #endregion

	}
}
