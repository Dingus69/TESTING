
using System;
using System.Data;
using SAGO.DATAACCESS;
using SAGO.CLASES.DAO;
using SAGO.COMMON;

namespace SAGO.CLASES.DAL
{
	/// <summary>
	/// Summary description for DLAPORTECLIENTE.
	/// </summary>
	public class DLAPORTECLIENTE : DLBase
	{
		public DLAPORTECLIENTE()
		{
		}

        #region Protected Methods

        protected override string GetDeleteProcedure()
        {
            return "proc_delete_APORTE_CLIENTE";
        }

        protected override string GetInsertProcedure()
        {
            return "proc_insert_APORTE_CLIENTE";
        }

        protected override string GetSelectProcedure()
        {
            return "proc_select_APORTE_CLIENTE";
        }

        protected override string GetUpdateProcedure()
        {
            return "proc_update_APORTE_CLIENTE";
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
            EAPORTECLIENTE objAPORTECLIENTE = obj as EAPORTECLIENTE;

            prms[0] = db.GetParameter();
            prms[0].Value = objAPORTECLIENTE.CODAPORTE;
            prms[0].ParameterName = "@COD_APORTE";

            return prms;
        }

        protected override IDbDataParameter[] GetInsertParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(14);
            EAPORTECLIENTE objAPORTECLIENTE = obj as EAPORTECLIENTE;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objAPORTECLIENTE.CODTIPOAPORTECLIENTE;
            prms[1].ParameterName = "@COD_TIPO_APORTE_CLIENTE";
            	
            prms[2] = db.GetParameter();
            prms[2].Value = objAPORTECLIENTE.CODESTADOAPORTECLIENTE;
            prms[2].ParameterName = "@COD_ESTADO_APORTE_CLIENTE";
            	
            prms[3] = db.GetParameter();
            prms[3].Value = objAPORTECLIENTE.CODTIPODOCTO;
            prms[3].ParameterName = "@COD_TIPO_DOCTO";
            	
            prms[4] = db.GetParameter();
            prms[4].Value = objAPORTECLIENTE.RUTCLIENTE;
            prms[4].ParameterName = "@RUT_CLIENTE";
            	
            prms[5] = db.GetParameter();
            prms[5].Value = objAPORTECLIENTE.CODCUENTA;
            prms[5].ParameterName = "@COD_CUENTA";
            	
            prms[6] = db.GetParameter();
            prms[6].Value = objAPORTECLIENTE.AGNO;
            prms[6].ParameterName = "@AGNO";
            	
            prms[7] = db.GetParameter();
            prms[7].Value = objAPORTECLIENTE.FECHAREALIZACION;
            prms[7].ParameterName = "@FECHA_REALIZACION";
            	
            prms[8] = db.GetParameter();
            prms[8].Value = objAPORTECLIENTE.FECHACOBRO;
            prms[8].ParameterName = "@FECHA_COBRO";
            	
            prms[9] = db.GetParameter();
            prms[9].Value = objAPORTECLIENTE.FECHAVENCIMIENTODOCTO;
            prms[9].ParameterName = "@FECHA_VENCIMIENTO_DOCTO";
            	
            prms[10] = db.GetParameter();
            prms[10].Value = objAPORTECLIENTE.MONTONETO;
            prms[10].ParameterName = "@MONTO_NETO";
            	
            prms[11] = db.GetParameter();
            prms[11].Value = objAPORTECLIENTE.MONTOADMINISTRACION;
            prms[11].ParameterName = "@MONTO_ADMINISTRACION";
            	
            prms[12] = db.GetParameter();
            prms[12].Value = objAPORTECLIENTE.NUMERODOCTO;
            prms[12].ParameterName = "@NUMERO_DOCTO";
            	
            prms[13] = db.GetParameter();
            prms[13].Value = objAPORTECLIENTE.FOLIO;
            prms[13].ParameterName = "@FOLIO";
            	
            prms[14] = db.GetParameter();
            prms[14].Value = objAPORTECLIENTE.OBSERVACIONESAPORTE;
            prms[14].ParameterName = "@OBSERVACIONES_APORTE";
            
            return prms;
        }

        protected override IDbDataParameter[] GetUpdateParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(15);
            EAPORTECLIENTE objAPORTECLIENTE = obj as EAPORTECLIENTE;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[0] = db.GetParameter();
            prms[0].Value = objAPORTECLIENTE.CODAPORTE;
            prms[0].ParameterName = "@COD_APORTE";
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objAPORTECLIENTE.CODTIPOAPORTECLIENTE;
            prms[1].ParameterName = "@COD_TIPO_APORTE_CLIENTE";
            	
            prms[2] = db.GetParameter();
            prms[2].Value = objAPORTECLIENTE.CODESTADOAPORTECLIENTE;
            prms[2].ParameterName = "@COD_ESTADO_APORTE_CLIENTE";
            	
            prms[3] = db.GetParameter();
            prms[3].Value = objAPORTECLIENTE.CODTIPODOCTO;
            prms[3].ParameterName = "@COD_TIPO_DOCTO";
            	
            prms[4] = db.GetParameter();
            prms[4].Value = objAPORTECLIENTE.RUTCLIENTE;
            prms[4].ParameterName = "@RUT_CLIENTE";
            	
            prms[5] = db.GetParameter();
            prms[5].Value = objAPORTECLIENTE.CODCUENTA;
            prms[5].ParameterName = "@COD_CUENTA";
            	
            prms[6] = db.GetParameter();
            prms[6].Value = objAPORTECLIENTE.AGNO;
            prms[6].ParameterName = "@AGNO";
            	
            prms[7] = db.GetParameter();
            prms[7].Value = objAPORTECLIENTE.FECHAREALIZACION;
            prms[7].ParameterName = "@FECHA_REALIZACION";
            	
            prms[8] = db.GetParameter();
            prms[8].Value = objAPORTECLIENTE.FECHACOBRO;
            prms[8].ParameterName = "@FECHA_COBRO";
            	
            prms[9] = db.GetParameter();
            prms[9].Value = objAPORTECLIENTE.FECHAVENCIMIENTODOCTO;
            prms[9].ParameterName = "@FECHA_VENCIMIENTO_DOCTO";
            	
            prms[10] = db.GetParameter();
            prms[10].Value = objAPORTECLIENTE.MONTONETO;
            prms[10].ParameterName = "@MONTO_NETO";
            	
            prms[11] = db.GetParameter();
            prms[11].Value = objAPORTECLIENTE.MONTOADMINISTRACION;
            prms[11].ParameterName = "@MONTO_ADMINISTRACION";
            	
            prms[12] = db.GetParameter();
            prms[12].Value = objAPORTECLIENTE.NUMERODOCTO;
            prms[12].ParameterName = "@NUMERO_DOCTO";
            	
            prms[13] = db.GetParameter();
            prms[13].Value = objAPORTECLIENTE.FOLIO;
            prms[13].ParameterName = "@FOLIO";
            	
            prms[14] = db.GetParameter();
            prms[14].Value = objAPORTECLIENTE.OBSERVACIONESAPORTE;
            prms[14].ParameterName = "@OBSERVACIONES_APORTE";
            
            return prms;
        }

        protected override void SetPrimaryKey(DomainObject obj, long id)
        {
            EAPORTECLIENTE objRoot = obj as EAPORTECLIENTE;

            objRoot.CODAPORTE = id;
        }

        #endregion

        #region Public Methods

         public override void Fill(DomainObject obj, IDataReader dr)
        {
            EAPORTECLIENTE objAPORTECLIENTE = obj as EAPORTECLIENTE;
    
            //Poner las rutinas del Tools que se necesiten
            
            objAPORTECLIENTE.CODAPORTE = Utiles.ConvertToDecimal(dr["COD_APORTE"]);

            objAPORTECLIENTE.CODTIPOAPORTECLIENTE = Utiles.ConvertToDecimal(dr["COD_TIPO_APORTE_CLIENTE"]);

            objAPORTECLIENTE.CODESTADOAPORTECLIENTE = Utiles.ConvertToDecimal(dr["COD_ESTADO_APORTE_CLIENTE"]);
            
            objAPORTECLIENTE.CODTIPODOCTO = Utiles.ConvertToDecimal(dr["COD_TIPO_DOCTO"]);
            
            objAPORTECLIENTE.RUTCLIENTE = Utiles.ConvertToInt64(dr["RUT_CLIENTE"]);
            
            objAPORTECLIENTE.CODCUENTA = Utiles.ConvertToInt32(dr["COD_CUENTA"]);

            objAPORTECLIENTE.AGNO = Utiles.ConvertToInt32(dr["AGNO"]);
            
            objAPORTECLIENTE.FECHAREALIZACION = Utiles.ConvertToDateTime(dr["FECHA_REALIZACION"]);

            objAPORTECLIENTE.FECHACOBRO = Utiles.ConvertToDateTime(dr["FECHA_COBRO"]);

            objAPORTECLIENTE.FECHAVENCIMIENTODOCTO = Utiles.ConvertToDateTime(dr["FECHA_VENCIMIENTO_DOCTO"]);
            
            objAPORTECLIENTE.MONTONETO = Utiles.ConvertToInt64(dr["MONTO_NETO"]);
            
            objAPORTECLIENTE.MONTOADMINISTRACION = Utiles.ConvertToInt64(dr["MONTO_ADMINISTRACION"]);
            
            objAPORTECLIENTE.NUMERODOCTO = Utiles.ConvertToString(dr["NUMERO_DOCTO"]);

            objAPORTECLIENTE.FOLIO = Utiles.ConvertToString(dr["FOLIO"]);

            objAPORTECLIENTE.OBSERVACIONESAPORTE = Utiles.ConvertToString(dr["OBSERVACIONES_APORTE"]);
            
        }

        #endregion

	}
}
