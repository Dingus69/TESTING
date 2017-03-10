
using System;
using System.Data;
using SAGO.DATAACCESS;
using SAGO.CLASES.DAO;
using SAGO.COMMON;

namespace SAGO.CLASES.DAL
{
	/// <summary>
	/// Summary description for DLCARGO.
	/// </summary>
	public class DLCARGO : DLBase
	{
		public DLCARGO()
		{
		}

        #region Protected Methods

        protected override string GetDeleteProcedure()
        {
            return "proc_delete_CARGO";
        }

        protected override string GetInsertProcedure()
        {
            return "proc_insert_CARGO";
        }

        protected override string GetSelectProcedure()
        {
            return "proc_select_CARGO";
        }

        protected override string GetUpdateProcedure()
        {
            return "proc_update_CARGO";
        }

        protected override IDbDataParameter[] GetSelectParameters(long id, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);

            prms[0] = db.GetParameter();
            prms[0].Value = id;
            prms[0].ParameterName = "@RUT_CLIENTE";

            return prms;
        }

        protected override IDbDataParameter[] GetDeleteParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            ECARGO objCARGO = obj as ECARGO;

            prms[0] = db.GetParameter();
            prms[0].Value = objCARGO.RUTCLIENTE;
            prms[0].ParameterName = "@RUT_CLIENTE";

            return prms;
        }

        protected override IDbDataParameter[] GetInsertParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(2);
            ECARGO objCARGO = obj as ECARGO;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objCARGO.CODCARGO;
            prms[1].ParameterName = "@COD_CARGO";
            	
            prms[2] = db.GetParameter();
            prms[2].Value = objCARGO.CARGO;
            prms[2].ParameterName = "@CARGO";
            
            return prms;
        }

        protected override IDbDataParameter[] GetUpdateParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(3);
            ECARGO objCARGO = obj as ECARGO;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[0] = db.GetParameter();
            prms[0].Value = objCARGO.RUTCLIENTE;
            prms[0].ParameterName = "@RUT_CLIENTE";
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objCARGO.CODCARGO;
            prms[1].ParameterName = "@COD_CARGO";
            	
            prms[2] = db.GetParameter();
            prms[2].Value = objCARGO.CARGO;
            prms[2].ParameterName = "@CARGO";
            
            return prms;
        }

        protected override void SetPrimaryKey(DomainObject obj, long id)
        {
            ECARGO objRoot = obj as ECARGO;

            objRoot.RUTCLIENTE = id;
        }

        #endregion

        #region Public Methods

         public override void Fill(DomainObject obj, IDataReader dr)
        {
            ECARGO objCARGO = obj as ECARGO;
    
            //Poner las rutinas del Tools que se necesiten
            
            objCARGO.RUTCLIENTE = Utiles.ConvertToInt64(dr["RUT_CLIENTE"]);
            
            objCARGO.CODCARGO = Utiles.ConvertToString(dr["COD_CARGO"]);

            objCARGO.CARGO = Utiles.ConvertToString(dr["CARGO"]);
            
        }

        #endregion

	}
}
