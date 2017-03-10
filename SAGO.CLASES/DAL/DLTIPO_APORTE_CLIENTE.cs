
using System;
using System.Data;
using SAGO.DATAACCESS;
using SAGO.CLASES.DAO;
using SAGO.COMMON;

namespace SAGO.CLASES.DAL
{
	/// <summary>
	/// Summary description for DLTIPOAPORTECLIENTE.
	/// </summary>
	public class DLTIPOAPORTECLIENTE : DLBase
	{
		public DLTIPOAPORTECLIENTE()
		{
		}

        #region Protected Methods

        protected override string GetDeleteProcedure()
        {
            return "proc_delete_TIPO_APORTE_CLIENTE";
        }

        protected override string GetInsertProcedure()
        {
            return "proc_insert_TIPO_APORTE_CLIENTE";
        }

        protected override string GetSelectProcedure()
        {
            return "proc_select_TIPO_APORTE_CLIENTE";
        }

        protected override string GetUpdateProcedure()
        {
            return "proc_update_TIPO_APORTE_CLIENTE";
        }

        protected override IDbDataParameter[] GetSelectParameters(long id, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);

            prms[0] = db.GetParameter();
            prms[0].Value = id;
            prms[0].ParameterName = "@COD_TIPO_APORTE_CLIENTE";

            return prms;
        }

        protected override IDbDataParameter[] GetDeleteParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            ETIPOAPORTECLIENTE objTIPOAPORTECLIENTE = obj as ETIPOAPORTECLIENTE;

            prms[0] = db.GetParameter();
            prms[0].Value = objTIPOAPORTECLIENTE.CODTIPOAPORTECLIENTE;
            prms[0].ParameterName = "@COD_TIPO_APORTE_CLIENTE";

            return prms;
        }

        protected override IDbDataParameter[] GetInsertParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            ETIPOAPORTECLIENTE objTIPOAPORTECLIENTE = obj as ETIPOAPORTECLIENTE;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objTIPOAPORTECLIENTE.TIPOAPORTECLIENTE;
            prms[1].ParameterName = "@TIPO_APORTE_CLIENTE";
            
            return prms;
        }

        protected override IDbDataParameter[] GetUpdateParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(2);
            ETIPOAPORTECLIENTE objTIPOAPORTECLIENTE = obj as ETIPOAPORTECLIENTE;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[0] = db.GetParameter();
            prms[0].Value = objTIPOAPORTECLIENTE.CODTIPOAPORTECLIENTE;
            prms[0].ParameterName = "@COD_TIPO_APORTE_CLIENTE";
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objTIPOAPORTECLIENTE.TIPOAPORTECLIENTE;
            prms[1].ParameterName = "@TIPO_APORTE_CLIENTE";
            
            return prms;
        }

        protected override void SetPrimaryKey(DomainObject obj, long id)
        {
            ETIPOAPORTECLIENTE objRoot = obj as ETIPOAPORTECLIENTE;

            objRoot.CODTIPOAPORTECLIENTE = id;
        }

        #endregion

        #region Public Methods

         public override void Fill(DomainObject obj, IDataReader dr)
        {
            ETIPOAPORTECLIENTE objTIPOAPORTECLIENTE = obj as ETIPOAPORTECLIENTE;
    
            //Poner las rutinas del Tools que se necesiten
            
            objTIPOAPORTECLIENTE.CODTIPOAPORTECLIENTE = Utiles.ConvertToDecimal(dr["COD_TIPO_APORTE_CLIENTE"]);

            objTIPOAPORTECLIENTE.TIPOAPORTECLIENTE = Utiles.ConvertToString(dr["TIPO_APORTE_CLIENTE"]);
            
        }

        #endregion

	}
}
