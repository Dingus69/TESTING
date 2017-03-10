
using System;
using System.Data;
using SAGO.DATAACCESS;
using SAGO.CLASES.DAO;
using SAGO.COMMON;

namespace SAGO.CLASES.DAL
{
	/// <summary>
	/// Summary description for DLFRANQUICIASENCE.
	/// </summary>
	public class DLFRANQUICIASENCE : DLBase
	{
		public DLFRANQUICIASENCE()
		{
		}

        #region Protected Methods

        protected override string GetDeleteProcedure()
        {
            return "proc_delete_FRANQUICIA_SENCE";
        }

        protected override string GetInsertProcedure()
        {
            return "proc_insert_FRANQUICIA_SENCE";
        }

        protected override string GetSelectProcedure()
        {
            return "proc_select_FRANQUICIA_SENCE";
        }

        protected override string GetUpdateProcedure()
        {
            return "proc_update_FRANQUICIA_SENCE";
        }

        protected override IDbDataParameter[] GetSelectParameters(long id, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);

            prms[0] = db.GetParameter();
            prms[0].Value = id;
            prms[0].ParameterName = "@COD_FRANQUICIA_SENCE";

            return prms;
        }

        protected override IDbDataParameter[] GetDeleteParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            EFRANQUICIASENCE objFRANQUICIASENCE = obj as EFRANQUICIASENCE;

            prms[0] = db.GetParameter();
            prms[0].Value = objFRANQUICIASENCE.CODFRANQUICIASENCE;
            prms[0].ParameterName = "@COD_FRANQUICIA_SENCE";

            return prms;
        }

        protected override IDbDataParameter[] GetInsertParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            EFRANQUICIASENCE objFRANQUICIASENCE = obj as EFRANQUICIASENCE;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objFRANQUICIASENCE.FRANQUICIASENCE;
            prms[1].ParameterName = "@FRANQUICIA_SENCE";
            
            return prms;
        }

        protected override IDbDataParameter[] GetUpdateParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(2);
            EFRANQUICIASENCE objFRANQUICIASENCE = obj as EFRANQUICIASENCE;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[0] = db.GetParameter();
            prms[0].Value = objFRANQUICIASENCE.CODFRANQUICIASENCE;
            prms[0].ParameterName = "@COD_FRANQUICIA_SENCE";
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objFRANQUICIASENCE.FRANQUICIASENCE;
            prms[1].ParameterName = "@FRANQUICIA_SENCE";
            
            return prms;
        }

        protected override void SetPrimaryKey(DomainObject obj, long id)
        {
            EFRANQUICIASENCE objRoot = obj as EFRANQUICIASENCE;

            objRoot.CODFRANQUICIASENCE = id;
        }

        #endregion

        #region Public Methods

         public override void Fill(DomainObject obj, IDataReader dr)
        {
            EFRANQUICIASENCE objFRANQUICIASENCE = obj as EFRANQUICIASENCE;
    
            //Poner las rutinas del Tools que se necesiten
            
            objFRANQUICIASENCE.CODFRANQUICIASENCE = Utiles.ConvertToInt32(dr["COD_FRANQUICIA_SENCE"]);
            
            objFRANQUICIASENCE.FRANQUICIASENCE = Utiles.ConvertToInt32(dr["FRANQUICIA_SENCE"]);
            
        }

        #endregion

	}
}
