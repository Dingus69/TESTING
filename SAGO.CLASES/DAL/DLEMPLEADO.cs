
using System;
using System.Data;
using SAGO.DATAACCESS;
using SAGO.CLASES.DAO;
using SAGO.COMMON;

namespace SAGO.CLASES.DAL
{
	/// <summary>
	/// Summary description for DLEMPLEADO.
	/// </summary>
	public class DLEMPLEADO : DLBase
	{
		public DLEMPLEADO()
		{
		}

        #region Protected Methods

        protected override string GetDeleteProcedure()
        {
            return "proc_delete_EMPLEADO";
        }

        protected override string GetInsertProcedure()
        {
            return "proc_insert_EMPLEADO";
        }

        protected override string GetSelectProcedure()
        {
            return "proc_select_EMPLEADO";
        }

        protected override string GetUpdateProcedure()
        {
            return "proc_update_EMPLEADO";
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
            EEMPLEADO objEMPLEADO = obj as EEMPLEADO;

            prms[0] = db.GetParameter();
            prms[0].Value = objEMPLEADO.RUTEMPLEADO;
            prms[0].ParameterName = "@RUT_EMPLEADO";

            return prms;
        }

        protected override IDbDataParameter[] GetInsertParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(14);
            EEMPLEADO objEMPLEADO = obj as EEMPLEADO;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objEMPLEADO.NOMBRE;
            prms[1].ParameterName = "@NOMBRE";
            	
            prms[2] = db.GetParameter();
            prms[2].Value = objEMPLEADO.APPATERNO;
            prms[2].ParameterName = "@AP_PATERNO";
            	
            prms[3] = db.GetParameter();
            prms[3].Value = objEMPLEADO.APMATERNO;
            prms[3].ParameterName = "@AP_MATERNO";
            	
            prms[4] = db.GetParameter();
            prms[4].Value = objEMPLEADO.FECHANACIMIENTO;
            prms[4].ParameterName = "@FECHA_NACIMIENTO";
            	
            prms[5] = db.GetParameter();
            prms[5].Value = objEMPLEADO.FECHACONTRATO;
            prms[5].ParameterName = "@FECHA_CONTRATO";
            	
            prms[6] = db.GetParameter();
            prms[6].Value = objEMPLEADO.RUTCLIENTE;
            prms[6].ParameterName = "@RUT_CLIENTE";
            	
            prms[7] = db.GetParameter();
            prms[7].Value = objEMPLEADO.CODOCUPACION;
            prms[7].ParameterName = "@COD_OCUPACION";
            	
            prms[8] = db.GetParameter();
            prms[8].Value = objEMPLEADO.CODEDUCACION;
            prms[8].ParameterName = "@COD_EDUCACION";
            	
            prms[9] = db.GetParameter();
            prms[9].Value = objEMPLEADO.CODSEXO;
            prms[9].ParameterName = "@COD_SEXO";
            	
            prms[10] = db.GetParameter();
            prms[10].Value = objEMPLEADO.CODCENTROCOSTO;
            prms[10].ParameterName = "@COD_CENTRO_COSTO";
            	
            prms[11] = db.GetParameter();
            prms[11].Value = objEMPLEADO.CODCARGO;
            prms[11].ParameterName = "@COD_CARGO";
            	
            prms[12] = db.GetParameter();
            prms[12].Value = objEMPLEADO.CODCOMUNA;
            prms[12].ParameterName = "@COD_COMUNA";
            	
            prms[13] = db.GetParameter();
            prms[13].Value = objEMPLEADO.CODFRANQUICIAECCL;
            prms[13].ParameterName = "@COD_FRANQUICIA_ECCL";
            	
            prms[14] = db.GetParameter();
            prms[14].Value = objEMPLEADO.CODFRANQUICIASENCE;
            prms[14].ParameterName = "@COD_FRANQUICIA_SENCE";
            
            return prms;
        }

        protected override IDbDataParameter[] GetUpdateParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(15);
            EEMPLEADO objEMPLEADO = obj as EEMPLEADO;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[0] = db.GetParameter();
            prms[0].Value = objEMPLEADO.RUTEMPLEADO;
            prms[0].ParameterName = "@RUT_EMPLEADO";
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objEMPLEADO.NOMBRE;
            prms[1].ParameterName = "@NOMBRE";
            	
            prms[2] = db.GetParameter();
            prms[2].Value = objEMPLEADO.APPATERNO;
            prms[2].ParameterName = "@AP_PATERNO";
            	
            prms[3] = db.GetParameter();
            prms[3].Value = objEMPLEADO.APMATERNO;
            prms[3].ParameterName = "@AP_MATERNO";
            	
            prms[4] = db.GetParameter();
            prms[4].Value = objEMPLEADO.FECHANACIMIENTO;
            prms[4].ParameterName = "@FECHA_NACIMIENTO";
            	
            prms[5] = db.GetParameter();
            prms[5].Value = objEMPLEADO.FECHACONTRATO;
            prms[5].ParameterName = "@FECHA_CONTRATO";
            	
            prms[6] = db.GetParameter();
            prms[6].Value = objEMPLEADO.RUTCLIENTE;
            prms[6].ParameterName = "@RUT_CLIENTE";
            	
            prms[7] = db.GetParameter();
            prms[7].Value = objEMPLEADO.CODOCUPACION;
            prms[7].ParameterName = "@COD_OCUPACION";
            	
            prms[8] = db.GetParameter();
            prms[8].Value = objEMPLEADO.CODEDUCACION;
            prms[8].ParameterName = "@COD_EDUCACION";
            	
            prms[9] = db.GetParameter();
            prms[9].Value = objEMPLEADO.CODSEXO;
            prms[9].ParameterName = "@COD_SEXO";
            	
            prms[10] = db.GetParameter();
            prms[10].Value = objEMPLEADO.CODCENTROCOSTO;
            prms[10].ParameterName = "@COD_CENTRO_COSTO";
            	
            prms[11] = db.GetParameter();
            prms[11].Value = objEMPLEADO.CODCARGO;
            prms[11].ParameterName = "@COD_CARGO";
            	
            prms[12] = db.GetParameter();
            prms[12].Value = objEMPLEADO.CODCOMUNA;
            prms[12].ParameterName = "@COD_COMUNA";
            	
            prms[13] = db.GetParameter();
            prms[13].Value = objEMPLEADO.CODFRANQUICIAECCL;
            prms[13].ParameterName = "@COD_FRANQUICIA_ECCL";
            	
            prms[14] = db.GetParameter();
            prms[14].Value = objEMPLEADO.CODFRANQUICIASENCE;
            prms[14].ParameterName = "@COD_FRANQUICIA_SENCE";
            
            return prms;
        }

        protected override void SetPrimaryKey(DomainObject obj, long id)
        {
            EEMPLEADO objRoot = obj as EEMPLEADO;

            objRoot.RUTEMPLEADO = id;
        }

        #endregion

        #region Public Methods

         public override void Fill(DomainObject obj, IDataReader dr)
        {
            EEMPLEADO objEMPLEADO = obj as EEMPLEADO;
    
            //Poner las rutinas del Tools que se necesiten
            
            objEMPLEADO.RUTEMPLEADO = Utiles.ConvertToInt64(dr["RUT_EMPLEADO"]);
            
            objEMPLEADO.NOMBRE = Utiles.ConvertToString(dr["NOMBRE"]);

            objEMPLEADO.APPATERNO = Utiles.ConvertToString(dr["AP_PATERNO"]);

            objEMPLEADO.APMATERNO = Utiles.ConvertToString(dr["AP_MATERNO"]);
            
            objEMPLEADO.FECHANACIMIENTO = Utiles.ConvertToDateTime(dr["FECHA_NACIMIENTO"]);

            objEMPLEADO.FECHACONTRATO = Utiles.ConvertToDateTime(dr["FECHA_CONTRATO"]);
            
            objEMPLEADO.RUTCLIENTE = Utiles.ConvertToInt64(dr["RUT_CLIENTE"]);
            
            objEMPLEADO.CODOCUPACION = Utiles.ConvertToInt32(dr["COD_OCUPACION"]);

            objEMPLEADO.CODEDUCACION = Utiles.ConvertToInt32(dr["COD_EDUCACION"]);

            objEMPLEADO.CODSEXO = Utiles.ConvertToString(dr["COD_SEXO"]);

            objEMPLEADO.CODCENTROCOSTO = Utiles.ConvertToString(dr["COD_CENTRO_COSTO"]);

            objEMPLEADO.CODCARGO = Utiles.ConvertToString(dr["COD_CARGO"]);
            
            objEMPLEADO.CODCOMUNA = Utiles.ConvertToInt64(dr["COD_COMUNA"]);
            
            objEMPLEADO.CODFRANQUICIAECCL = Utiles.ConvertToInt32(dr["COD_FRANQUICIA_ECCL"]);
            
            objEMPLEADO.CODFRANQUICIASENCE = Utiles.ConvertToInt32(dr["COD_FRANQUICIA_SENCE"]);
            
        }

        #endregion

	}
}
