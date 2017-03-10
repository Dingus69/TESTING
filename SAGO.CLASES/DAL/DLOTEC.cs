
using System;
using System.Data;
using SAGO.DATAACCESS;
using SAGO.CLASES.DAO;
using SAGO.COMMON;

namespace SAGO.CLASES.DAL
{
	/// <summary>
	/// Summary description for DLOTEC.
	/// </summary>
	public class DLOTEC : DLBase
	{
		public DLOTEC()
		{
		}

        #region Protected Methods

        protected override string GetDeleteProcedure()
        {
            return "proc_delete_OTEC";
        }

        protected override string GetInsertProcedure()
        {
            return "proc_insert_OTEC";
        }

        protected override string GetSelectProcedure()
        {
            return "proc_select_OTEC";
        }

        protected override string GetUpdateProcedure()
        {
            return "proc_update_OTEC";
        }

        protected override IDbDataParameter[] GetSelectParameters(long id, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);

            prms[0] = db.GetParameter();
            prms[0].Value = id;
            prms[0].ParameterName = "@RUT_OTEC";

            return prms;
        }

        protected override IDbDataParameter[] GetDeleteParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            EOTEC objOTEC = obj as EOTEC;

            prms[0] = db.GetParameter();
            prms[0].Value = objOTEC.RUTOTEC;
            prms[0].ParameterName = "@RUT_OTEC";

            return prms;
        }

        protected override IDbDataParameter[] GetInsertParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(7);
            EOTEC objOTEC = obj as EOTEC;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objOTEC.RAZONSOCIALOTEC;
            prms[1].ParameterName = "@RAZON_SOCIAL_OTEC";
            	
            prms[2] = db.GetParameter();
            prms[2].Value = objOTEC.NOMBREFANTASIAOTEC;
            prms[2].ParameterName = "@NOMBRE_FANTASIA_OTEC";
            	
            prms[3] = db.GetParameter();
            prms[3].Value = objOTEC.DIRECCIONOTEC;
            prms[3].ParameterName = "@DIRECCION_OTEC";
            	
            prms[4] = db.GetParameter();
            prms[4].Value = objOTEC.TELEFONOOTEC;
            prms[4].ParameterName = "@TELEFONO_OTEC";
            	
            prms[5] = db.GetParameter();
            prms[5].Value = objOTEC.REPRESENTANTELEGALOTEC;
            prms[5].ParameterName = "@REPRESENTANTE_LEGAL_OTEC";
            	
            prms[6] = db.GetParameter();
            prms[6].Value = objOTEC.EMAILOTEC;
            prms[6].ParameterName = "@EMAIL_OTEC";
            	
            prms[7] = db.GetParameter();
            prms[7].Value = objOTEC.CONTACTOOTEC;
            prms[7].ParameterName = "@CONTACTO_OTEC";
            
            return prms;
        }

        protected override IDbDataParameter[] GetUpdateParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(8);
            EOTEC objOTEC = obj as EOTEC;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[0] = db.GetParameter();
            prms[0].Value = objOTEC.RUTOTEC;
            prms[0].ParameterName = "@RUT_OTEC";
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objOTEC.RAZONSOCIALOTEC;
            prms[1].ParameterName = "@RAZON_SOCIAL_OTEC";
            	
            prms[2] = db.GetParameter();
            prms[2].Value = objOTEC.NOMBREFANTASIAOTEC;
            prms[2].ParameterName = "@NOMBRE_FANTASIA_OTEC";
            	
            prms[3] = db.GetParameter();
            prms[3].Value = objOTEC.DIRECCIONOTEC;
            prms[3].ParameterName = "@DIRECCION_OTEC";
            	
            prms[4] = db.GetParameter();
            prms[4].Value = objOTEC.TELEFONOOTEC;
            prms[4].ParameterName = "@TELEFONO_OTEC";
            	
            prms[5] = db.GetParameter();
            prms[5].Value = objOTEC.REPRESENTANTELEGALOTEC;
            prms[5].ParameterName = "@REPRESENTANTE_LEGAL_OTEC";
            	
            prms[6] = db.GetParameter();
            prms[6].Value = objOTEC.EMAILOTEC;
            prms[6].ParameterName = "@EMAIL_OTEC";
            	
            prms[7] = db.GetParameter();
            prms[7].Value = objOTEC.CONTACTOOTEC;
            prms[7].ParameterName = "@CONTACTO_OTEC";
            
            return prms;
        }

        protected override void SetPrimaryKey(DomainObject obj, long id)
        {
            EOTEC objRoot = obj as EOTEC;

            objRoot.RUTOTEC = id;
        }

        #endregion

        #region Public Methods

         public override void Fill(DomainObject obj, IDataReader dr)
        {
            EOTEC objOTEC = obj as EOTEC;
    
            //Poner las rutinas del Tools que se necesiten
            
            objOTEC.RUTOTEC = Utiles.ConvertToInt64(dr["RUT_OTEC"]);
            
            objOTEC.RAZONSOCIALOTEC = Utiles.ConvertToString(dr["RAZON_SOCIAL_OTEC"]);

            objOTEC.NOMBREFANTASIAOTEC = Utiles.ConvertToString(dr["NOMBRE_FANTASIA_OTEC"]);

            objOTEC.DIRECCIONOTEC = Utiles.ConvertToString(dr["DIRECCION_OTEC"]);

            objOTEC.TELEFONOOTEC = Utiles.ConvertToString(dr["TELEFONO_OTEC"]);

            objOTEC.REPRESENTANTELEGALOTEC = Utiles.ConvertToString(dr["REPRESENTANTE_LEGAL_OTEC"]);

            objOTEC.EMAILOTEC = Utiles.ConvertToString(dr["EMAIL_OTEC"]);

            objOTEC.CONTACTOOTEC = Utiles.ConvertToString(dr["CONTACTO_OTEC"]);
            
        }

        #endregion

	}
}
