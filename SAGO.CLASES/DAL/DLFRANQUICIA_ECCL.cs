
using System;
using System.Data;
using SAGO.DATAACCESS;
using SAGO.CLASES.DAO;
using SAGO.COMMON;

namespace SAGO.CLASES.DAL
{
	/// <summary>
	/// Summary description for DLFRANQUICIAECCL.
	/// </summary>
	public class DLFRANQUICIAECCL : DLBase
	{
		public DLFRANQUICIAECCL()
		{
		}

        #region Protected Methods

        protected override string GetDeleteProcedure()
        {
            return "proc_delete_FRANQUICIA_ECCL";
        }

        protected override string GetInsertProcedure()
        {
            return "proc_insert_FRANQUICIA_ECCL";
        }

        protected override string GetSelectProcedure()
        {
            return "proc_select_FRANQUICIA_ECCL";
        }

        protected override string GetUpdateProcedure()
        {
            return "proc_update_FRANQUICIA_ECCL";
        }

        protected override IDbDataParameter[] GetSelectParameters(long id, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);

            prms[0] = db.GetParameter();
            prms[0].Value = id;
            prms[0].ParameterName = "@COD_FRANQUICIA_ECCL";

            return prms;
        }

        protected override IDbDataParameter[] GetDeleteParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            EFRANQUICIAECCL objFRANQUICIAECCL = obj as EFRANQUICIAECCL;

            prms[0] = db.GetParameter();
            prms[0].Value = objFRANQUICIAECCL.CODFRANQUICIAECCL;
            prms[0].ParameterName = "@COD_FRANQUICIA_ECCL";

            return prms;
        }

        protected override IDbDataParameter[] GetInsertParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            EFRANQUICIAECCL objFRANQUICIAECCL = obj as EFRANQUICIAECCL;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objFRANQUICIAECCL.FRANQUICIAECCL;
            prms[1].ParameterName = "@FRANQUICIA_ECCL";
            
            return prms;
        }

        protected override IDbDataParameter[] GetUpdateParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(2);
            EFRANQUICIAECCL objFRANQUICIAECCL = obj as EFRANQUICIAECCL;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[0] = db.GetParameter();
            prms[0].Value = objFRANQUICIAECCL.CODFRANQUICIAECCL;
            prms[0].ParameterName = "@COD_FRANQUICIA_ECCL";
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objFRANQUICIAECCL.FRANQUICIAECCL;
            prms[1].ParameterName = "@FRANQUICIA_ECCL";
            
            return prms;
        }

        protected override void SetPrimaryKey(DomainObject obj, long id)
        {
            EFRANQUICIAECCL objRoot = obj as EFRANQUICIAECCL;

            objRoot.CODFRANQUICIAECCL = id;
        }

        #endregion

        #region Public Methods

         public override void Fill(DomainObject obj, IDataReader dr)
        {
            EFRANQUICIAECCL objFRANQUICIAECCL = obj as EFRANQUICIAECCL;
    
            //Poner las rutinas del Tools que se necesiten
            
            objFRANQUICIAECCL.CODFRANQUICIAECCL = Utiles.ConvertToInt32(dr["COD_FRANQUICIA_ECCL"]);
            
            objFRANQUICIAECCL.FRANQUICIAECCL = Utiles.ConvertToInt32(dr["FRANQUICIA_ECCL"]);
            
        }

        #endregion

	}
}
