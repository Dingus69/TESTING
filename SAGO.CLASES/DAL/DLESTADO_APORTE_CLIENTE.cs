
using System;
using System.Data;
using SAGO.DATAACCESS;
using SAGO.CLASES.DAO;
using SAGO.COMMON;

namespace SAGO.CLASES.DAL
{
	/// <summary>
	/// Summary description for DLESTADOAPORTECLIENTE.
	/// </summary>
	public class DLESTADOAPORTECLIENTE : DLBase
	{
		public DLESTADOAPORTECLIENTE()
		{
		}

        #region Protected Methods

        protected override string GetDeleteProcedure()
        {
            return "proc_delete_ESTADO_APORTE_CLIENTE";
        }

        protected override string GetInsertProcedure()
        {
            return "proc_insert_ESTADO_APORTE_CLIENTE";
        }

        protected override string GetSelectProcedure()
        {
            return "proc_select_ESTADO_APORTE_CLIENTE";
        }

        protected override string GetUpdateProcedure()
        {
            return "proc_update_ESTADO_APORTE_CLIENTE";
        }

        protected override IDbDataParameter[] GetSelectParameters(long id, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);

            prms[0] = db.GetParameter();
            prms[0].Value = id;
            prms[0].ParameterName = "@COD_ESTADO_APORTE_CLIENTE";

            return prms;
        }

        protected override IDbDataParameter[] GetDeleteParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            EESTADOAPORTECLIENTE objESTADOAPORTECLIENTE = obj as EESTADOAPORTECLIENTE;

            prms[0] = db.GetParameter();
            prms[0].Value = objESTADOAPORTECLIENTE.CODESTADOAPORTECLIENTE;
            prms[0].ParameterName = "@COD_ESTADO_APORTE_CLIENTE";

            return prms;
        }

        protected override IDbDataParameter[] GetInsertParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            EESTADOAPORTECLIENTE objESTADOAPORTECLIENTE = obj as EESTADOAPORTECLIENTE;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objESTADOAPORTECLIENTE.ESTADOAPORTECLIENTE;
            prms[1].ParameterName = "@ESTADO_APORTE_CLIENTE";
            
            return prms;
        }

        protected override IDbDataParameter[] GetUpdateParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(2);
            EESTADOAPORTECLIENTE objESTADOAPORTECLIENTE = obj as EESTADOAPORTECLIENTE;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[0] = db.GetParameter();
            prms[0].Value = objESTADOAPORTECLIENTE.CODESTADOAPORTECLIENTE;
            prms[0].ParameterName = "@COD_ESTADO_APORTE_CLIENTE";
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objESTADOAPORTECLIENTE.ESTADOAPORTECLIENTE;
            prms[1].ParameterName = "@ESTADO_APORTE_CLIENTE";
            
            return prms;
        }

        protected override void SetPrimaryKey(DomainObject obj, long id)
        {
            EESTADOAPORTECLIENTE objRoot = obj as EESTADOAPORTECLIENTE;

            objRoot.CODESTADOAPORTECLIENTE = id;
        }

        #endregion

        #region Public Methods

         public override void Fill(DomainObject obj, IDataReader dr)
        {
            EESTADOAPORTECLIENTE objESTADOAPORTECLIENTE = obj as EESTADOAPORTECLIENTE;
    
            //Poner las rutinas del Tools que se necesiten
            
            objESTADOAPORTECLIENTE.CODESTADOAPORTECLIENTE = Utiles.ConvertToDecimal(dr["COD_ESTADO_APORTE_CLIENTE"]);
            
            objESTADOAPORTECLIENTE.ESTADOAPORTECLIENTE = Utiles.ConvertToString(dr["ESTADO_APORTE_CLIENTE"]);
            
        }

        #endregion

	}
}
