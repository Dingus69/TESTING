
using System;
using System.Data;
using SAGO.DATAACCESS;
using SAGO.CLASES.DAO;
using SAGO.COMMON;

namespace SAGO.CLASES.DAL
{
	/// <summary>
	/// Summary description for DLCLIENTE.
	/// </summary>
	public class DLCLIENTE : DLBase
	{
		public DLCLIENTE()
		{
		}

        #region Protected Methods

        protected override string GetDeleteProcedure()
        {
            return "proc_delete_CLIENTE";
        }

        protected override string GetInsertProcedure()
        {
            return "proc_insert_CLIENTE";
        }

        protected override string GetSelectProcedure()
        {
            return "proc_select_CLIENTE";
        }

        protected override string GetUpdateProcedure()
        {
            return "proc_update_CLIENTE";
        }

        protected override IDbDataParameter[] GetSelectParameters(long id, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);

            prms[0] = db.GetParameter();
            prms[0].Value = id;
            prms[0].ParameterName = "@RUT_CLIENTE";

            return prms;
        }

        protected override IDbDataParameter[] GetDeleteParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            ECLIENTE objCLIENTE = obj as ECLIENTE;

            prms[0] = db.GetParameter();
            prms[0].Value = objCLIENTE.RUTCLIENTE;
            prms[0].ParameterName = "@RUT_CLIENTE";

            return prms;
        }

        protected override IDbDataParameter[] GetInsertParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(8);
            ECLIENTE objCLIENTE = obj as ECLIENTE;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objCLIENTE.RUTHOLDING;
            prms[1].ParameterName = "@RUT_HOLDING";
            	
            prms[2] = db.GetParameter();
            prms[2].Value = objCLIENTE.RAZONSOCIALCLIENTE;
            prms[2].ParameterName = "@RAZON_SOCIAL_CLIENTE";
            	
            prms[3] = db.GetParameter();
            prms[3].Value = objCLIENTE.NOMBREFANTASIACLIENTE;
            prms[3].ParameterName = "@NOMBRE_FANTASIA_CLIENTE";
            	
            prms[4] = db.GetParameter();
            prms[4].Value = objCLIENTE.DIRECCIONCLIENTE;
            prms[4].ParameterName = "@DIRECCION_CLIENTE";
            	
            prms[5] = db.GetParameter();
            prms[5].Value = objCLIENTE.NRODIRECCIONCLIENTE;
            prms[5].ParameterName = "@NRO_DIRECCION_CLIENTE";
            	
            prms[6] = db.GetParameter();
            prms[6].Value = objCLIENTE.EMIALCLIENTE;
            prms[6].ParameterName = "@EMIAL_CLIENTE";
            	
            prms[7] = db.GetParameter();
            prms[7].Value = objCLIENTE.TELEFONOCLIENTE;
            prms[7].ParameterName = "@TELEFONO_CLIENTE";
            	
            prms[8] = db.GetParameter();
            prms[8].Value = objCLIENTE.CONTACTOCLIENTE;
            prms[8].ParameterName = "@CONTACTO_CLIENTE";
            
            return prms;
        }

        protected override IDbDataParameter[] GetUpdateParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(9);
            ECLIENTE objCLIENTE = obj as ECLIENTE;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[0] = db.GetParameter();
            prms[0].Value = objCLIENTE.RUTCLIENTE;
            prms[0].ParameterName = "@RUT_CLIENTE";
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objCLIENTE.RUTHOLDING;
            prms[1].ParameterName = "@RUT_HOLDING";
            	
            prms[2] = db.GetParameter();
            prms[2].Value = objCLIENTE.RAZONSOCIALCLIENTE;
            prms[2].ParameterName = "@RAZON_SOCIAL_CLIENTE";
            	
            prms[3] = db.GetParameter();
            prms[3].Value = objCLIENTE.NOMBREFANTASIACLIENTE;
            prms[3].ParameterName = "@NOMBRE_FANTASIA_CLIENTE";
            	
            prms[4] = db.GetParameter();
            prms[4].Value = objCLIENTE.DIRECCIONCLIENTE;
            prms[4].ParameterName = "@DIRECCION_CLIENTE";
            	
            prms[5] = db.GetParameter();
            prms[5].Value = objCLIENTE.NRODIRECCIONCLIENTE;
            prms[5].ParameterName = "@NRO_DIRECCION_CLIENTE";
            	
            prms[6] = db.GetParameter();
            prms[6].Value = objCLIENTE.EMIALCLIENTE;
            prms[6].ParameterName = "@EMIAL_CLIENTE";
            	
            prms[7] = db.GetParameter();
            prms[7].Value = objCLIENTE.TELEFONOCLIENTE;
            prms[7].ParameterName = "@TELEFONO_CLIENTE";
            	
            prms[8] = db.GetParameter();
            prms[8].Value = objCLIENTE.CONTACTOCLIENTE;
            prms[8].ParameterName = "@CONTACTO_CLIENTE";
            
            return prms;
        }

        protected override void SetPrimaryKey(DomainObject obj, long id)
        {
            ECLIENTE objRoot = obj as ECLIENTE;

            objRoot.RUTCLIENTE = id;
        }

        #endregion

        #region Public Methods

         public override void Fill(DomainObject obj, IDataReader dr)
        {
            ECLIENTE objCLIENTE = obj as ECLIENTE;
    
            //Poner las rutinas del Tools que se necesiten
            
            objCLIENTE.RUTCLIENTE = Utiles.ConvertToInt64(dr["RUT_CLIENTE"]);
            
            objCLIENTE.RUTHOLDING = Utiles.ConvertToInt64(dr["RUT_HOLDING"]);

            objCLIENTE.RAZONSOCIALCLIENTE = Utiles.ConvertToString(dr["RAZON_SOCIAL_CLIENTE"]);

            objCLIENTE.NOMBREFANTASIACLIENTE = Utiles.ConvertToString(dr["NOMBRE_FANTASIA_CLIENTE"]);

            objCLIENTE.DIRECCIONCLIENTE = Utiles.ConvertToString(dr["DIRECCION_CLIENTE"]);

            objCLIENTE.NRODIRECCIONCLIENTE = Utiles.ConvertToString(dr["NRO_DIRECCION_CLIENTE"]);

            objCLIENTE.EMIALCLIENTE = Utiles.ConvertToString(dr["EMIAL_CLIENTE"]);

            objCLIENTE.TELEFONOCLIENTE = Utiles.ConvertToString(dr["TELEFONO_CLIENTE"]);

            objCLIENTE.CONTACTOCLIENTE = Utiles.ConvertToString(dr["CONTACTO_CLIENTE"]);
            
        }

        #endregion

	}
}
