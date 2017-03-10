
using System;
using System.Data;
using SAGO.DATAACCESS;
using SAGO.CLASES.DAO;
using SAGO.COMMON;

namespace SAGO.CLASES.DAL
{
	/// <summary>
	/// Summary description for DLESTADOCURSO.
	/// </summary>
	public class DLESTADOCURSO : DLBase
	{
		public DLESTADOCURSO()
		{
		}

        #region Protected Methods

        protected override string GetDeleteProcedure()
        {
            return "proc_delete_ESTADO_CURSO";
        }

        protected override string GetInsertProcedure()
        {
            return "proc_insert_ESTADO_CURSO";
        }

        protected override string GetSelectProcedure()
        {
            return "proc_select_ESTADO_CURSO";
        }

        protected override string GetUpdateProcedure()
        {
            return "proc_update_ESTADO_CURSO";
        }

        protected override IDbDataParameter[] GetSelectParameters(long id, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);

            prms[0] = db.GetParameter();
            prms[0].Value = id;
            prms[0].ParameterName = "@COD_ESTADO_CURSO";

            return prms;
        }

        protected override IDbDataParameter[] GetDeleteParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            EESTADOCURSO objESTADOCURSO = obj as EESTADOCURSO;

            prms[0] = db.GetParameter();
            prms[0].Value = objESTADOCURSO.CODESTADOCURSO;
            prms[0].ParameterName = "@COD_ESTADO_CURSO";

            return prms;
        }

        protected override IDbDataParameter[] GetInsertParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            EESTADOCURSO objESTADOCURSO = obj as EESTADOCURSO;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objESTADOCURSO.ESTADOCURSO;
            prms[1].ParameterName = "@ESTADO_CURSO";
            
            return prms;
        }

        protected override IDbDataParameter[] GetUpdateParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(2);
            EESTADOCURSO objESTADOCURSO = obj as EESTADOCURSO;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[0] = db.GetParameter();
            prms[0].Value = objESTADOCURSO.CODESTADOCURSO;
            prms[0].ParameterName = "@COD_ESTADO_CURSO";
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objESTADOCURSO.ESTADOCURSO;
            prms[1].ParameterName = "@ESTADO_CURSO";
            
            return prms;
        }

        protected override void SetPrimaryKey(DomainObject obj, long id)
        {
            EESTADOCURSO objRoot = obj as EESTADOCURSO;

            objRoot.CODESTADOCURSO = id;
        }

        #endregion

        #region Public Methods

         public override void Fill(DomainObject obj, IDataReader dr)
        {
            EESTADOCURSO objESTADOCURSO = obj as EESTADOCURSO;
    
            //Poner las rutinas del Tools que se necesiten
            
            objESTADOCURSO.CODESTADOCURSO = Utiles.ConvertToDecimal(dr["COD_ESTADO_CURSO"]);
            
            objESTADOCURSO.ESTADOCURSO = Utiles.ConvertToString(dr["ESTADO_CURSO"]);
            
        }

        #endregion

	}
}
