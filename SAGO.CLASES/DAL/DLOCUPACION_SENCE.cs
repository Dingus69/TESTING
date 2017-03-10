
using System;
using System.Data;
using SAGO.DATAACCESS;
using SAGO.CLASES.DAO;
using SAGO.COMMON;

namespace SAGO.CLASES.DAL
{
	/// <summary>
	/// Summary description for DLOCUPACIONSENCE.
	/// </summary>
	public class DLOCUPACIONSENCE : DLBase
	{
		public DLOCUPACIONSENCE()
		{
		}

        #region Protected Methods

        protected override string GetDeleteProcedure()
        {
            return "proc_delete_OCUPACION_SENCE";
        }

        protected override string GetInsertProcedure()
        {
            return "proc_insert_OCUPACION_SENCE";
        }

        protected override string GetSelectProcedure()
        {
            return "proc_select_OCUPACION_SENCE";
        }

        protected override string GetUpdateProcedure()
        {
            return "proc_update_OCUPACION_SENCE";
        }

        protected override IDbDataParameter[] GetSelectParameters(long id, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);

            prms[0] = db.GetParameter();
            prms[0].Value = id;
            prms[0].ParameterName = "@COD_OCUPACION";

            return prms;
        }

        protected override IDbDataParameter[] GetDeleteParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            EOCUPACIONSENCE objOCUPACIONSENCE = obj as EOCUPACIONSENCE;

            prms[0] = db.GetParameter();
            prms[0].Value = objOCUPACIONSENCE.CODOCUPACION;
            prms[0].ParameterName = "@COD_OCUPACION";

            return prms;
        }

        protected override IDbDataParameter[] GetInsertParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            EOCUPACIONSENCE objOCUPACIONSENCE = obj as EOCUPACIONSENCE;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objOCUPACIONSENCE.OCUPACION;
            prms[1].ParameterName = "@OCUPACION";
            
            return prms;
        }

        protected override IDbDataParameter[] GetUpdateParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(2);
            EOCUPACIONSENCE objOCUPACIONSENCE = obj as EOCUPACIONSENCE;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[0] = db.GetParameter();
            prms[0].Value = objOCUPACIONSENCE.CODOCUPACION;
            prms[0].ParameterName = "@COD_OCUPACION";
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objOCUPACIONSENCE.OCUPACION;
            prms[1].ParameterName = "@OCUPACION";
            
            return prms;
        }

        protected override void SetPrimaryKey(DomainObject obj, int id)
        {
            EOCUPACIONSENCE objRoot = obj as EOCUPACIONSENCE;

            objRoot.CODOCUPACION = id;
        }

        #endregion

        #region Public Methods

         public override void Fill(DomainObject obj, IDataReader dr)
        {
            EOCUPACIONSENCE objOCUPACIONSENCE = obj as EOCUPACIONSENCE;
    
            //Poner las rutinas del Tools que se necesiten
            
            objOCUPACIONSENCE.CODOCUPACION = Utiles.ConvertToInt32(dr["COD_OCUPACION"]);
            
            objOCUPACIONSENCE.OCUPACION = Utiles.ConvertToString(dr["OCUPACION"]);
            
        }

        #endregion

	}
}
