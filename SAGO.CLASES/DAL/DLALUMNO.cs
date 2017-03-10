
using System;
using System.Data;
using SAGO.DATAACCESS;
using SAGO.CLASES.DAO;
using SAGO.COMMON;

namespace SAGO.CLASES.DAL
{
	/// <summary>
	/// Summary description for DLALUMNO.
	/// </summary>
	public class DLALUMNO : DLBase
	{
		public DLALUMNO()
		{
		}

        #region Protected Methods

        protected override string GetDeleteProcedure()
        {
            return "proc_delete_ALUMNO";
        }

        protected override string GetInsertProcedure()
        {
            return "proc_insert_ALUMNO";
        }

        protected override string GetSelectProcedure()
        {
            return "proc_select_ALUMNO";
        }

        protected override string GetUpdateProcedure()
        {
            return "proc_update_ALUMNO";
        }

        protected override IDbDataParameter[] GetSelectParameters(long id, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);

            prms[0] = db.GetParameter();
            prms[0].Value = id;
            prms[0].ParameterName = "@RUT_EMPLEADO";

            return prms;
        }

        protected override IDbDataParameter[] GetDeleteParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            EALUMNO objALUMNO = obj as EALUMNO;

            prms[0] = db.GetParameter();
            prms[0].Value = objALUMNO.RUTEMPLEADO;
            prms[0].ParameterName = "@RUT_EMPLEADO";

            return prms;
        }

        protected override IDbDataParameter[] GetInsertParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(11);
            EALUMNO objALUMNO = obj as EALUMNO;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objALUMNO.CORRELATIVO;
            prms[1].ParameterName = "@CORRELATIVO";
            	
            prms[2] = db.GetParameter();
            prms[2].Value = objALUMNO.RUTCLIENTE;
            prms[2].ParameterName = "@RUT_CLIENTE";
            	
            prms[3] = db.GetParameter();
            prms[3].Value = objALUMNO.CODOCUPACION;
            prms[3].ParameterName = "@COD_OCUPACION";
            	
            prms[4] = db.GetParameter();
            prms[4].Value = objALUMNO.CODCENTROCOSTO;
            prms[4].ParameterName = "@COD_CENTRO_COSTO";
            	
            prms[5] = db.GetParameter();
            prms[5].Value = objALUMNO.CODFRANQUICIASENCE;
            prms[5].ParameterName = "@COD_FRANQUICIA_SENCE";
            	
            prms[6] = db.GetParameter();
            prms[6].Value = objALUMNO.CODFRANQUICIAECCL;
            prms[6].ParameterName = "@COD_FRANQUICIA_ECCL";
            	
            prms[7] = db.GetParameter();
            prms[7].Value = objALUMNO.CODEDUCACION;
            prms[7].ParameterName = "@COD_EDUCACION";
            	
            prms[8] = db.GetParameter();
            prms[8].Value = objALUMNO.CODCARGO;
            prms[8].ParameterName = "@COD_CARGO";
            	
            prms[9] = db.GetParameter();
            prms[9].Value = objALUMNO.CODCOMUNA;
            prms[9].ParameterName = "@COD_COMUNA";
            	
            prms[10] = db.GetParameter();
            prms[10].Value = objALUMNO.ASISTENCIA;
            prms[10].ParameterName = "@ASISTENCIA";
            	
            prms[11] = db.GetParameter();
            prms[11].Value = objALUMNO.EVALUACION;
            prms[11].ParameterName = "@EVALUACION";
            
            return prms;
        }

        protected override IDbDataParameter[] GetUpdateParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(12);
            EALUMNO objALUMNO = obj as EALUMNO;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[0] = db.GetParameter();
            prms[0].Value = objALUMNO.RUTEMPLEADO;
            prms[0].ParameterName = "@RUT_EMPLEADO";
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objALUMNO.CORRELATIVO;
            prms[1].ParameterName = "@CORRELATIVO";
            	
            prms[2] = db.GetParameter();
            prms[2].Value = objALUMNO.RUTCLIENTE;
            prms[2].ParameterName = "@RUT_CLIENTE";
            	
            prms[3] = db.GetParameter();
            prms[3].Value = objALUMNO.CODOCUPACION;
            prms[3].ParameterName = "@COD_OCUPACION";
            	
            prms[4] = db.GetParameter();
            prms[4].Value = objALUMNO.CODCENTROCOSTO;
            prms[4].ParameterName = "@COD_CENTRO_COSTO";
            	
            prms[5] = db.GetParameter();
            prms[5].Value = objALUMNO.CODFRANQUICIASENCE;
            prms[5].ParameterName = "@COD_FRANQUICIA_SENCE";
            	
            prms[6] = db.GetParameter();
            prms[6].Value = objALUMNO.CODFRANQUICIAECCL;
            prms[6].ParameterName = "@COD_FRANQUICIA_ECCL";
            	
            prms[7] = db.GetParameter();
            prms[7].Value = objALUMNO.CODEDUCACION;
            prms[7].ParameterName = "@COD_EDUCACION";
            	
            prms[8] = db.GetParameter();
            prms[8].Value = objALUMNO.CODCARGO;
            prms[8].ParameterName = "@COD_CARGO";
            	
            prms[9] = db.GetParameter();
            prms[9].Value = objALUMNO.CODCOMUNA;
            prms[9].ParameterName = "@COD_COMUNA";
            	
            prms[10] = db.GetParameter();
            prms[10].Value = objALUMNO.ASISTENCIA;
            prms[10].ParameterName = "@ASISTENCIA";
            	
            prms[11] = db.GetParameter();
            prms[11].Value = objALUMNO.EVALUACION;
            prms[11].ParameterName = "@EVALUACION";
            
            return prms;
        }

        protected override void SetPrimaryKey(DomainObject obj, long id)
        {
            EALUMNO objRoot = obj as EALUMNO;

            objRoot.RUTEMPLEADO = id;
        }

        #endregion

        #region Public Methods

         public override void Fill(DomainObject obj, IDataReader dr)
        {
            EALUMNO objALUMNO = obj as EALUMNO;
    
            //Poner las rutinas del Tools que se necesiten
            
            objALUMNO.RUTEMPLEADO = Utiles.ConvertToInt64(dr["RUT_EMPLEADO"]);
            
            objALUMNO.CORRELATIVO = Utiles.ConvertToDecimal(dr["CORRELATIVO"]);
            
            objALUMNO.RUTCLIENTE = Utiles.ConvertToInt64(dr["RUT_CLIENTE"]);
            
            objALUMNO.CODOCUPACION = Utiles.ConvertToInt32(dr["COD_OCUPACION"]);
            
            objALUMNO.CODCENTROCOSTO = Utiles.ConvertToString(dr["COD_CENTRO_COSTO"]);

            objALUMNO.CODFRANQUICIASENCE = Utiles.ConvertToInt32(dr["COD_FRANQUICIA_SENCE"]);

            objALUMNO.CODFRANQUICIAECCL = Utiles.ConvertToInt32(dr["COD_FRANQUICIA_ECCL"]);

            objALUMNO.CODEDUCACION = Utiles.ConvertToInt32(dr["COD_EDUCACION"]);

            objALUMNO.CODCARGO = Utiles.ConvertToString(dr["COD_CARGO"]);
            
            objALUMNO.CODCOMUNA = Utiles.ConvertToInt64(dr["COD_COMUNA"]);
            
            objALUMNO.ASISTENCIA = Utiles.ConvertToDouble(dr["ASISTENCIA"]);

            objALUMNO.EVALUACION = Utiles.ConvertToDouble(dr["EVALUACION"]);
            
        }

        #endregion

	}
}
