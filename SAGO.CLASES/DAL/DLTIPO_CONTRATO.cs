
using System;
using System.Data;
using SAGO.DATAACCESS;
using SAGO.CLASES.DAO;
using SAGO.COMMON;

namespace SAGO.CLASES.DAL
{
	/// <summary>
	/// Summary description for DLTIPOCONTRATO.
	/// </summary>
	public class DLTIPOCONTRATO : DLBase
	{
		public DLTIPOCONTRATO()
		{
		}

        #region Protected Methods

        protected override string GetDeleteProcedure()
        {
            return "proc_delete_TIPO_CONTRATO";
        }

        protected override string GetInsertProcedure()
        {
            return "proc_insert_TIPO_CONTRATO";
        }

        protected override string GetSelectProcedure()
        {
            return "proc_select_TIPO_CONTRATO";
        }

        protected override string GetUpdateProcedure()
        {
            return "proc_update_TIPO_CONTRATO";
        }

        protected override IDbDataParameter[] GetSelectParameters(long id, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);

            prms[0] = db.GetParameter();
            prms[0].Value = id;
            prms[0].ParameterName = "@COD_TIPO_CONTRATO";

            return prms;
        }

        protected override IDbDataParameter[] GetDeleteParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            ETIPOCONTRATO objTIPOCONTRATO = obj as ETIPOCONTRATO;

            prms[0] = db.GetParameter();
            prms[0].Value = objTIPOCONTRATO.CODTIPOCONTRATO;
            prms[0].ParameterName = "@COD_TIPO_CONTRATO";

            return prms;
        }

        protected override IDbDataParameter[] GetInsertParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            ETIPOCONTRATO objTIPOCONTRATO = obj as ETIPOCONTRATO;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objTIPOCONTRATO.TIPOCONTRATO;
            prms[1].ParameterName = "@TIPO_CONTRATO";
            
            return prms;
        }

        protected override IDbDataParameter[] GetUpdateParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(2);
            ETIPOCONTRATO objTIPOCONTRATO = obj as ETIPOCONTRATO;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[0] = db.GetParameter();
            prms[0].Value = objTIPOCONTRATO.CODTIPOCONTRATO;
            prms[0].ParameterName = "@COD_TIPO_CONTRATO";
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objTIPOCONTRATO.TIPOCONTRATO;
            prms[1].ParameterName = "@TIPO_CONTRATO";
            
            return prms;
        }

        protected override void SetPrimaryKey(DomainObject obj, long id)
        {
            ETIPOCONTRATO objRoot = obj as ETIPOCONTRATO;

            objRoot.CODTIPOCONTRATO = id;
        }

        #endregion

        #region Public Methods

         public override void Fill(DomainObject obj, IDataReader dr)
        {
            ETIPOCONTRATO objTIPOCONTRATO = obj as ETIPOCONTRATO;
    
            //Poner las rutinas del Tools que se necesiten
            
            objTIPOCONTRATO.CODTIPOCONTRATO = Utiles.ConvertToDecimal(dr["COD_TIPO_CONTRATO"]);

            objTIPOCONTRATO.TIPOCONTRATO = Utiles.ConvertToString(dr["TIPO_CONTRATO"]);
            
        }

        #endregion

	}
}
