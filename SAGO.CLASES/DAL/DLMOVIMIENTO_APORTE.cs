
using System;
using System.Data;
using SAGO.DATAACCESS;
using SAGO.CLASES.DAO;
using SAGO.COMMON;

namespace SAGO.CLASES.DAL
{
	/// <summary>
	/// Summary description for DLMOVIMIENTOAPORTE.
	/// </summary>
	public class DLMOVIMIENTOAPORTE : DLBase
	{
		public DLMOVIMIENTOAPORTE()
		{
		}

        #region Protected Methods

        protected override string GetDeleteProcedure()
        {
            return "proc_delete_MOVIMIENTO_APORTE";
        }

        protected override string GetInsertProcedure()
        {
            return "proc_insert_MOVIMIENTO_APORTE";
        }

        protected override string GetSelectProcedure()
        {
            return "proc_select_MOVIMIENTO_APORTE";
        }

        protected override string GetUpdateProcedure()
        {
            return "proc_update_MOVIMIENTO_APORTE";
        }

        protected override IDbDataParameter[] GetSelectParameters(long id, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);

            prms[0] = db.GetParameter();
            prms[0].Value = id;
            prms[0].ParameterName = "@COD_APORTE";

            return prms;
        }

        protected override IDbDataParameter[] GetDeleteParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            EMOVIMIENTOAPORTE objMOVIMIENTOAPORTE = obj as EMOVIMIENTOAPORTE;

            prms[0] = db.GetParameter();
            prms[0].Value = objMOVIMIENTOAPORTE.CODAPORTE;
            prms[0].ParameterName = "@COD_APORTE";

            return prms;
        }

        protected override IDbDataParameter[] GetInsertParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            EMOVIMIENTOAPORTE objMOVIMIENTOAPORTE = obj as EMOVIMIENTOAPORTE;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objMOVIMIENTOAPORTE.CODMOVIENTO;
            prms[1].ParameterName = "@COD_MOVIENTO";
            
            return prms;
        }

        protected override IDbDataParameter[] GetUpdateParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(2);
            EMOVIMIENTOAPORTE objMOVIMIENTOAPORTE = obj as EMOVIMIENTOAPORTE;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[0] = db.GetParameter();
            prms[0].Value = objMOVIMIENTOAPORTE.CODAPORTE;
            prms[0].ParameterName = "@COD_APORTE";
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objMOVIMIENTOAPORTE.CODMOVIENTO;
            prms[1].ParameterName = "@COD_MOVIENTO";
            
            return prms;
        }

        protected override void SetPrimaryKey(DomainObject obj, long id)
        {
            EMOVIMIENTOAPORTE objRoot = obj as EMOVIMIENTOAPORTE;

            objRoot.CODAPORTE = id;
        }

        #endregion

        #region Public Methods

         public override void Fill(DomainObject obj, IDataReader dr)
        {
            EMOVIMIENTOAPORTE objMOVIMIENTOAPORTE = obj as EMOVIMIENTOAPORTE;
    
            //Poner las rutinas del Tools que se necesiten
            
            objMOVIMIENTOAPORTE.CODAPORTE = Utiles.ConvertToDecimal(dr["COD_APORTE"]);

            objMOVIMIENTOAPORTE.CODMOVIENTO = Utiles.ConvertToDecimal(dr["COD_MOVIENTO"]);
            
        }

        #endregion

	}
}
