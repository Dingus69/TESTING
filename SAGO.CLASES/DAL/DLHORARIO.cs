
using System;
using System.Data;
using SAGO.DATAACCESS;
using SAGO.CLASES.DAO;
using SAGO.COMMON;

namespace SAGO.CLASES.DAL
{
	/// <summary>
	/// Summary description for DLHORARIO.
	/// </summary>
	public class DLHORARIO : DLBase
	{
		public DLHORARIO()
		{
		}

        #region Protected Methods

        protected override string GetDeleteProcedure()
        {
            return "proc_delete_HORARIO";
        }

        protected override string GetInsertProcedure()
        {
            return "proc_insert_HORARIO";
        }

        protected override string GetSelectProcedure()
        {
            return "proc_select_HORARIO";
        }

        protected override string GetUpdateProcedure()
        {
            return "proc_update_HORARIO";
        }

        protected override IDbDataParameter[] GetSelectParameters(long id, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);

            prms[0] = db.GetParameter();
            prms[0].Value = id;
            prms[0].ParameterName = "@CORRELATIVO";

            return prms;
        }

        protected override IDbDataParameter[] GetDeleteParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            EHORARIO objHORARIO = obj as EHORARIO;

            prms[0] = db.GetParameter();
            prms[0].Value = objHORARIO.CORRELATIVO;
            prms[0].ParameterName = "@CORRELATIVO";

            return prms;
        }

        protected override IDbDataParameter[] GetInsertParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(3);
            EHORARIO objHORARIO = obj as EHORARIO;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objHORARIO.DIA;
            prms[1].ParameterName = "@DIA";
            	
            prms[2] = db.GetParameter();
            prms[2].Value = objHORARIO.HORAINICIO;
            prms[2].ParameterName = "@HORA_INICIO";
            	
            prms[3] = db.GetParameter();
            prms[3].Value = objHORARIO.HORAFIN;
            prms[3].ParameterName = "@HORA_FIN";
            
            return prms;
        }

        protected override IDbDataParameter[] GetUpdateParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(4);
            EHORARIO objHORARIO = obj as EHORARIO;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[0] = db.GetParameter();
            prms[0].Value = objHORARIO.CORRELATIVO;
            prms[0].ParameterName = "@CORRELATIVO";
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objHORARIO.DIA;
            prms[1].ParameterName = "@DIA";
            	
            prms[2] = db.GetParameter();
            prms[2].Value = objHORARIO.HORAINICIO;
            prms[2].ParameterName = "@HORA_INICIO";
            	
            prms[3] = db.GetParameter();
            prms[3].Value = objHORARIO.HORAFIN;
            prms[3].ParameterName = "@HORA_FIN";
            
            return prms;
        }

        protected override void SetPrimaryKey(DomainObject obj, long id)
        {
            EHORARIO objRoot = obj as EHORARIO;

            objRoot.CORRELATIVO = id;
        }

        #endregion

        #region Public Methods

         public override void Fill(DomainObject obj, IDataReader dr)
        {
            EHORARIO objHORARIO = obj as EHORARIO;
    
            //Poner las rutinas del Tools que se necesiten
            
            objHORARIO.CORRELATIVO = Utiles.ConvertToDecimal(dr["CORRELATIVO"]);
            
            objHORARIO.DIA = Utiles.ConvertToInt32(dr["DIA"]);
            
            objHORARIO.HORAINICIO = Utiles.ConvertToString(dr["HORA_INICIO"]);

            objHORARIO.HORAFIN = Utiles.ConvertToString(dr["HORA_FIN"]);
            
        }

        #endregion

	}
}
