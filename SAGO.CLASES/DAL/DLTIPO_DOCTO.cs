
using System;
using System.Data;
using SAGO.DATAACCESS;
using SAGO.CLASES.DAO;
using SAGO.COMMON;

namespace SAGO.CLASES.DAL
{
	/// <summary>
	/// Summary description for DLTIPODOCTO.
	/// </summary>
	public class DLTIPODOCTO : DLBase
	{
		public DLTIPODOCTO()
		{
		}

        #region Protected Methods

        protected override string GetDeleteProcedure()
        {
            return "proc_delete_TIPO_DOCTO";
        }

        protected override string GetInsertProcedure()
        {
            return "proc_insert_TIPO_DOCTO";
        }

        protected override string GetSelectProcedure()
        {
            return "proc_select_TIPO_DOCTO";
        }

        protected override string GetUpdateProcedure()
        {
            return "proc_update_TIPO_DOCTO";
        }

        protected override IDbDataParameter[] GetSelectParameters(long id, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);

            prms[0] = db.GetParameter();
            prms[0].Value = id;
            prms[0].ParameterName = "@COD_TIPO_DOCTO";

            return prms;
        }

        protected override IDbDataParameter[] GetDeleteParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            ETIPODOCTO objTIPODOCTO = obj as ETIPODOCTO;

            prms[0] = db.GetParameter();
            prms[0].Value = objTIPODOCTO.CODTIPODOCTO;
            prms[0].ParameterName = "@COD_TIPO_DOCTO";

            return prms;
        }

        protected override IDbDataParameter[] GetInsertParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            ETIPODOCTO objTIPODOCTO = obj as ETIPODOCTO;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objTIPODOCTO.TIPODOCTO;
            prms[1].ParameterName = "@TIPO_DOCTO";
            
            return prms;
        }

        protected override IDbDataParameter[] GetUpdateParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(2);
            ETIPODOCTO objTIPODOCTO = obj as ETIPODOCTO;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[0] = db.GetParameter();
            prms[0].Value = objTIPODOCTO.CODTIPODOCTO;
            prms[0].ParameterName = "@COD_TIPO_DOCTO";
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objTIPODOCTO.TIPODOCTO;
            prms[1].ParameterName = "@TIPO_DOCTO";
            
            return prms;
        }

        protected override void SetPrimaryKey(DomainObject obj, long id)
        {
            ETIPODOCTO objRoot = obj as ETIPODOCTO;

            objRoot.CODTIPODOCTO = id;
        }

        #endregion

        #region Public Methods

         public override void Fill(DomainObject obj, IDataReader dr)
        {
            ETIPODOCTO objTIPODOCTO = obj as ETIPODOCTO;
    
            //Poner las rutinas del Tools que se necesiten
            
            objTIPODOCTO.CODTIPODOCTO = Utiles.ConvertToDecimal(dr["COD_TIPO_DOCTO"]);

            objTIPODOCTO.TIPODOCTO = Utiles.ConvertToString(dr["TIPO_DOCTO"]);
            
        }

        #endregion

	}
}
