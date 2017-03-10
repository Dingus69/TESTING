
using System;
using System.Data;
using SAGO.DATAACCESS;
using SAGO.CLASES.DAO;
using SAGO.COMMON;

namespace SAGO.CLASES.DAL
{
	/// <summary>
	/// Summary description for DLCUENTA.
	/// </summary>
	public class DLCUENTA : DLBase
	{
		public DLCUENTA()
		{
		}

        #region Protected Methods

        protected override string GetDeleteProcedure()
        {
            return "proc_delete_CUENTA";
        }

        protected override string GetInsertProcedure()
        {
            return "proc_insert_CUENTA";
        }

        protected override string GetSelectProcedure()
        {
            return "proc_select_CUENTA";
        }

        protected override string GetUpdateProcedure()
        {
            return "proc_update_CUENTA";
        }

        protected override IDbDataParameter[] GetSelectParameters(long id, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);

            prms[0] = db.GetParameter();
            prms[0].Value = id;
            prms[0].ParameterName = "@COD_CUENTA";

            return prms;
        }

        protected override IDbDataParameter[] GetDeleteParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            ECUENTA objCUENTA = obj as ECUENTA;

            prms[0] = db.GetParameter();
            prms[0].Value = objCUENTA.CODCUENTA;
            prms[0].ParameterName = "@COD_CUENTA";

            return prms;
        }

        protected override IDbDataParameter[] GetInsertParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            ECUENTA objCUENTA = obj as ECUENTA;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objCUENTA.CUENTA;
            prms[1].ParameterName = "@CUENTA";
            
            return prms;
        }

        protected override IDbDataParameter[] GetUpdateParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(2);
            ECUENTA objCUENTA = obj as ECUENTA;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[0] = db.GetParameter();
            prms[0].Value = objCUENTA.CODCUENTA;
            prms[0].ParameterName = "@COD_CUENTA";
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objCUENTA.CUENTA;
            prms[1].ParameterName = "@CUENTA";
            
            return prms;
        }

        protected override void SetPrimaryKey(DomainObject obj, int id)
        {
            ECUENTA objRoot = obj as ECUENTA;

            objRoot.CODCUENTA = id;
        }

        #endregion

        #region Public Methods

         public override void Fill(DomainObject obj, IDataReader dr)
        {
            ECUENTA objCUENTA = obj as ECUENTA;
    
            //Poner las rutinas del Tools que se necesiten
            
            objCUENTA.CODCUENTA = Utiles.ConvertToInt32(dr["COD_CUENTA"]);

            objCUENTA.CUENTA = Utiles.ConvertToString(dr["CUENTA"]);
            
        }

        #endregion

	}
}
