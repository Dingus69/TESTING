
using System;
using System.Data;
using SAGO.DATAACCESS;
using SAGO.CLASES.DAO;
using SAGO.COMMON;

namespace SAGO.CLASES.DAL
{
	/// <summary>
	/// Summary description for DLEDUCACIONSENCE.
	/// </summary>
	public class DLEDUCACIONSENCE : DLBase
	{
		public DLEDUCACIONSENCE()
		{
		}

        #region Protected Methods

        protected override string GetDeleteProcedure()
        {
            return "proc_delete_EDUCACION_SENCE";
        }

        protected override string GetInsertProcedure()
        {
            return "proc_insert_EDUCACION_SENCE";
        }

        protected override string GetSelectProcedure()
        {
            return "proc_select_EDUCACION_SENCE";
        }

        protected override string GetUpdateProcedure()
        {
            return "proc_update_EDUCACION_SENCE";
        }

        protected override IDbDataParameter[] GetSelectParameters(long id, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);

            prms[0] = db.GetParameter();
            prms[0].Value = id;
            prms[0].ParameterName = "@COD_EDUCACION";

            return prms;
        }

        protected override IDbDataParameter[] GetDeleteParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            EEDUCACIONSENCE objEDUCACIONSENCE = obj as EEDUCACIONSENCE;

            prms[0] = db.GetParameter();
            prms[0].Value = objEDUCACIONSENCE.CODEDUCACION;
            prms[0].ParameterName = "@COD_EDUCACION";

            return prms;
        }

        protected override IDbDataParameter[] GetInsertParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            EEDUCACIONSENCE objEDUCACIONSENCE = obj as EEDUCACIONSENCE;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objEDUCACIONSENCE.EDUCACION;
            prms[1].ParameterName = "@EDUCACION";
            
            return prms;
        }

        protected override IDbDataParameter[] GetUpdateParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(2);
            EEDUCACIONSENCE objEDUCACIONSENCE = obj as EEDUCACIONSENCE;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[0] = db.GetParameter();
            prms[0].Value = objEDUCACIONSENCE.CODEDUCACION;
            prms[0].ParameterName = "@COD_EDUCACION";
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objEDUCACIONSENCE.EDUCACION;
            prms[1].ParameterName = "@EDUCACION";
            
            return prms;
        }

        protected override void SetPrimaryKey(DomainObject obj, long id)
        {
            EEDUCACIONSENCE objRoot = obj as EEDUCACIONSENCE;

            objRoot.CODEDUCACION = id;
        }

        #endregion

        #region Public Methods

         public override void Fill(DomainObject obj, IDataReader dr)
        {
            EEDUCACIONSENCE objEDUCACIONSENCE = obj as EEDUCACIONSENCE;
    
            //Poner las rutinas del Tools que se necesiten
            
            objEDUCACIONSENCE.CODEDUCACION = Utiles.ConvertToInt16(dr["COD_EDUCACION"]);
            
            objEDUCACIONSENCE.EDUCACION = Utiles.ConvertToString(dr["EDUCACION"]);
            
        }

        #endregion

	}
}
