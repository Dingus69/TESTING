
using System;
using System.Data;
using SAGO.DATAACCESS;
using SAGO.CLASES.DAO;
using SAGO.COMMON;

namespace SAGO.CLASES.DAL
{
	/// <summary>
	/// Summary description for DLMOVIMIENTOCONTABLE.
	/// </summary>
	public class DLMOVIMIENTOCONTABLE : DLBase
	{
		public DLMOVIMIENTOCONTABLE()
		{
		}

        #region Protected Methods

        protected override string GetDeleteProcedure()
        {
            return "proc_delete_MOVIMIENTO_CONTABLE";
        }

        protected override string GetInsertProcedure()
        {
            return "proc_insert_MOVIMIENTO_CONTABLE";
        }

        protected override string GetSelectProcedure()
        {
            return "proc_select_MOVIMIENTO_CONTABLE";
        }

        protected override string GetUpdateProcedure()
        {
            return "proc_update_MOVIMIENTO_CONTABLE";
        }

        protected override IDbDataParameter[] GetSelectParameters(long id, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);

            prms[0] = db.GetParameter();
            prms[0].Value = id;
            prms[0].ParameterName = "@COD_MOVIENTO";

            return prms;
        }

        protected override IDbDataParameter[] GetDeleteParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            EMOVIMIENTOCONTABLE objMOVIMIENTOCONTABLE = obj as EMOVIMIENTOCONTABLE;

            prms[0] = db.GetParameter();
            prms[0].Value = objMOVIMIENTOCONTABLE.CODMOVIENTO;
            prms[0].ParameterName = "@COD_MOVIENTO";

            return prms;
        }

        protected override IDbDataParameter[] GetInsertParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(8);
            EMOVIMIENTOCONTABLE objMOVIMIENTOCONTABLE = obj as EMOVIMIENTOCONTABLE;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objMOVIMIENTOCONTABLE.CODTIPOMOVIMIENTOCONTABLE;
            prms[1].ParameterName = "@COD_TIPO_MOVIMIENTO_CONTABLE";
            	
            prms[2] = db.GetParameter();
            prms[2].Value = objMOVIMIENTOCONTABLE.CODCUENTA;
            prms[2].ParameterName = "@COD_CUENTA";
            	
            prms[3] = db.GetParameter();
            prms[3].Value = objMOVIMIENTOCONTABLE.CODESTADOMOVIMEINTOCONTABLE;
            prms[3].ParameterName = "@COD_ESTADO_MOVIMEINTO_CONTABLE";
            	
            prms[4] = db.GetParameter();
            prms[4].Value = objMOVIMIENTOCONTABLE.CORRELATIVO;
            prms[4].ParameterName = "@CORRELATIVO";
            	
            prms[5] = db.GetParameter();
            prms[5].Value = objMOVIMIENTOCONTABLE.RUTCLIENTE;
            prms[5].ParameterName = "@RUT_CLIENTE";
            	
            prms[6] = db.GetParameter();
            prms[6].Value = objMOVIMIENTOCONTABLE.FECHAHORAMOVIMIENTO;
            prms[6].ParameterName = "@FECHA_HORA_MOVIMIENTO";
            	
            prms[7] = db.GetParameter();
            prms[7].Value = objMOVIMIENTOCONTABLE.DESCRIPCIONMOVIMIENTO;
            prms[7].ParameterName = "@DESCRIPCION_MOVIMIENTO";
            	
            prms[8] = db.GetParameter();
            prms[8].Value = objMOVIMIENTOCONTABLE.MONTO;
            prms[8].ParameterName = "@MONTO";
            
            return prms;
        }

        protected override IDbDataParameter[] GetUpdateParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(9);
            EMOVIMIENTOCONTABLE objMOVIMIENTOCONTABLE = obj as EMOVIMIENTOCONTABLE;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[0] = db.GetParameter();
            prms[0].Value = objMOVIMIENTOCONTABLE.CODMOVIENTO;
            prms[0].ParameterName = "@COD_MOVIENTO";
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objMOVIMIENTOCONTABLE.CODTIPOMOVIMIENTOCONTABLE;
            prms[1].ParameterName = "@COD_TIPO_MOVIMIENTO_CONTABLE";
            	
            prms[2] = db.GetParameter();
            prms[2].Value = objMOVIMIENTOCONTABLE.CODCUENTA;
            prms[2].ParameterName = "@COD_CUENTA";
            	
            prms[3] = db.GetParameter();
            prms[3].Value = objMOVIMIENTOCONTABLE.CODESTADOMOVIMEINTOCONTABLE;
            prms[3].ParameterName = "@COD_ESTADO_MOVIMEINTO_CONTABLE";
            	
            prms[4] = db.GetParameter();
            prms[4].Value = objMOVIMIENTOCONTABLE.CORRELATIVO;
            prms[4].ParameterName = "@CORRELATIVO";
            	
            prms[5] = db.GetParameter();
            prms[5].Value = objMOVIMIENTOCONTABLE.RUTCLIENTE;
            prms[5].ParameterName = "@RUT_CLIENTE";
            	
            prms[6] = db.GetParameter();
            prms[6].Value = objMOVIMIENTOCONTABLE.FECHAHORAMOVIMIENTO;
            prms[6].ParameterName = "@FECHA_HORA_MOVIMIENTO";
            	
            prms[7] = db.GetParameter();
            prms[7].Value = objMOVIMIENTOCONTABLE.DESCRIPCIONMOVIMIENTO;
            prms[7].ParameterName = "@DESCRIPCION_MOVIMIENTO";
            	
            prms[8] = db.GetParameter();
            prms[8].Value = objMOVIMIENTOCONTABLE.MONTO;
            prms[8].ParameterName = "@MONTO";
            
            return prms;
        }

        protected override void SetPrimaryKey(DomainObject obj, long id)
        {
            EMOVIMIENTOCONTABLE objRoot = obj as EMOVIMIENTOCONTABLE;

            objRoot.CODMOVIENTO = id;
        }

        #endregion

        #region Public Methods

         public override void Fill(DomainObject obj, IDataReader dr)
        {
            EMOVIMIENTOCONTABLE objMOVIMIENTOCONTABLE = obj as EMOVIMIENTOCONTABLE;
    
            //Poner las rutinas del Tools que se necesiten
            
            objMOVIMIENTOCONTABLE.CODMOVIENTO = Utiles.ConvertToDecimal(dr["COD_MOVIENTO"]);

            objMOVIMIENTOCONTABLE.CODTIPOMOVIMIENTOCONTABLE = Utiles.ConvertToDecimal(dr["COD_TIPO_MOVIMIENTO_CONTABLE"]);
            
            objMOVIMIENTOCONTABLE.CODCUENTA = Utiles.ConvertToInt32(dr["COD_CUENTA"]);

            objMOVIMIENTOCONTABLE.CODESTADOMOVIMEINTOCONTABLE = Utiles.ConvertToDecimal(dr["COD_ESTADO_MOVIMEINTO_CONTABLE"]);

            objMOVIMIENTOCONTABLE.CORRELATIVO = Utiles.ConvertToDecimal(dr["CORRELATIVO"]);
            
            objMOVIMIENTOCONTABLE.RUTCLIENTE = Utiles.ConvertToInt64(dr["RUT_CLIENTE"]);
            
            objMOVIMIENTOCONTABLE.FECHAHORAMOVIMIENTO = Utiles.ConvertToDateTime(dr["FECHA_HORA_MOVIMIENTO"]);
            
            objMOVIMIENTOCONTABLE.DESCRIPCIONMOVIMIENTO = Utiles.ConvertToString(dr["DESCRIPCION_MOVIMIENTO"]);
            
            objMOVIMIENTOCONTABLE.MONTO = Utiles.ConvertToInt64(dr["MONTO"]);
            
        }

        #endregion

	}
}
