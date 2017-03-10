
using System;
using System.Data;
using SAGO.DATAACCESS;
using SAGO.CLASES.DAO;
using SAGO.COMMON;

namespace SAGO.CLASES.DAL
{
	/// <summary>
	/// Summary description for DLMODALIDAD.
	/// </summary>
	public class DLMODALIDAD : DLBase
	{
		public DLMODALIDAD()
		{
		}

        #region Protected Methods

        protected override string GetDeleteProcedure()
        {
            return "proc_delete_MODALIDAD";
        }

        protected override string GetInsertProcedure()
        {
            return "proc_insert_MODALIDAD";
        }

        protected override string GetSelectProcedure()
        {
            return "proc_select_MODALIDAD";
        }

        protected override string GetUpdateProcedure()
        {
            return "proc_update_MODALIDAD";
        }

        protected override IDbDataParameter[] GetSelectParameters(long id, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);

            prms[0] = db.GetParameter();
            prms[0].Value = id;
            prms[0].ParameterName = "@COD_MODALIDAD";

            return prms;
        }

        protected override IDbDataParameter[] GetDeleteParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            EMODALIDAD objMODALIDAD = obj as EMODALIDAD;

            prms[0] = db.GetParameter();
            prms[0].Value = objMODALIDAD.CODMODALIDAD;
            prms[0].ParameterName = "@COD_MODALIDAD";

            return prms;
        }

        protected override IDbDataParameter[] GetInsertParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            EMODALIDAD objMODALIDAD = obj as EMODALIDAD;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objMODALIDAD.MODALIDAD;
            prms[1].ParameterName = "@MODALIDAD";
            
            return prms;
        }

        protected override IDbDataParameter[] GetUpdateParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(2);
            EMODALIDAD objMODALIDAD = obj as EMODALIDAD;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[0] = db.GetParameter();
            prms[0].Value = objMODALIDAD.CODMODALIDAD;
            prms[0].ParameterName = "@COD_MODALIDAD";
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objMODALIDAD.MODALIDAD;
            prms[1].ParameterName = "@MODALIDAD";
            
            return prms;
        }

        protected override void SetPrimaryKey(DomainObject obj, long id)
        {
            EMODALIDAD objRoot = obj as EMODALIDAD;

            objRoot.CODMODALIDAD = id;
        }

        #endregion

        #region Public Methods

         public override void Fill(DomainObject obj, IDataReader dr)
        {
            EMODALIDAD objMODALIDAD = obj as EMODALIDAD;
    
            //Poner las rutinas del Tools que se necesiten
            
            objMODALIDAD.CODMODALIDAD = Utiles.ConvertToDecimal(dr["COD_MODALIDAD"]);
            
            objMODALIDAD.MODALIDAD = Utiles.ConvertToString(dr["MODALIDAD"]);
            
        }

        #endregion

	}
}
