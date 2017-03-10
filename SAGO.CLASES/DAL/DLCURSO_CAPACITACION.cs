
using System;
using System.Data;
using SAGO.DATAACCESS;
using SAGO.CLASES.DAO;
using SAGO.COMMON;

namespace SAGO.CLASES.DAL
{
	/// <summary>
	/// Summary description for DLCURSOCAPACITACION.
	/// </summary>
	public class DLCURSOCAPACITACION : DLBase
	{
		public DLCURSOCAPACITACION()
		{
		}

        #region Protected Methods

        protected override string GetDeleteProcedure()
        {
            return "proc_delete_CURSO_CAPACITACION";
        }

        protected override string GetInsertProcedure()
        {
            return "proc_insert_CURSO_CAPACITACION";
        }

        protected override string GetSelectProcedure()
        {
            return "proc_select_CURSO_CAPACITACION";
        }

        protected override string GetUpdateProcedure()
        {
            return "proc_update_CURSO_CAPACITACION";
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
            ECURSOCAPACITACION objCURSOCAPACITACION = obj as ECURSOCAPACITACION;

            prms[0] = db.GetParameter();
            prms[0].Value = objCURSOCAPACITACION.CORRELATIVO;
            prms[0].ParameterName = "@CORRELATIVO";

            return prms;
        }

        protected override IDbDataParameter[] GetInsertParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(26);
            ECURSOCAPACITACION objCURSOCAPACITACION = obj as ECURSOCAPACITACION;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objCURSOCAPACITACION.RUTCLIENTE;
            prms[1].ParameterName = "@RUT_CLIENTE";
            	
            prms[2] = db.GetParameter();
            prms[2].Value = objCURSOCAPACITACION.CORRELATIVOAGNO;
            prms[2].ParameterName = "@CORRELATIVO_AGNO";
            	
            prms[3] = db.GetParameter();
            prms[3].Value = objCURSOCAPACITACION.CORRELATIVOCLIENTE;
            prms[3].ParameterName = "@CORRELATIVO_CLIENTE";
            	
            prms[4] = db.GetParameter();
            prms[4].Value = objCURSOCAPACITACION.CODSENCE;
            prms[4].ParameterName = "@COD_SENCE";
            	
            prms[5] = db.GetParameter();
            prms[5].Value = objCURSOCAPACITACION.NUMEROACCIONSENCE;
            prms[5].ParameterName = "@NUMERO_ACCION_SENCE";
            	
            prms[6] = db.GetParameter();
            prms[6].Value = objCURSOCAPACITACION.CODESTADOCURSO;
            prms[6].ParameterName = "@COD_ESTADO_CURSO";
            	
            prms[7] = db.GetParameter();
            prms[7].Value = objCURSOCAPACITACION.CODTIPOCONTRATO;
            prms[7].ParameterName = "@COD_TIPO_CONTRATO";
            	
            prms[8] = db.GetParameter();
            prms[8].Value = objCURSOCAPACITACION.DIRECCIONCURSO;
            prms[8].ParameterName = "@DIRECCION_CURSO";
            	
            prms[9] = db.GetParameter();
            prms[9].Value = objCURSOCAPACITACION.NRODIRECCIONCURSO;
            prms[9].ParameterName = "@NRO_DIRECCION_CURSO";
            	
            prms[10] = db.GetParameter();
            prms[10].Value = objCURSOCAPACITACION.CIUDADCURSO;
            prms[10].ParameterName = "@CIUDAD_CURSO";
            	
            prms[11] = db.GetParameter();
            prms[11].Value = objCURSOCAPACITACION.CODCOMUNA;
            prms[11].ParameterName = "@COD_COMUNA";
            	
            prms[12] = db.GetParameter();
            prms[12].Value = objCURSOCAPACITACION.FECHACREACION;
            prms[12].ParameterName = "@FECHA_CREACION";
            	
            prms[13] = db.GetParameter();
            prms[13].Value = objCURSOCAPACITACION.FECHAINICIO;
            prms[13].ParameterName = "@FECHA_INICIO";
            	
            prms[14] = db.GetParameter();
            prms[14].Value = objCURSOCAPACITACION.FECHATERMINO;
            prms[14].ParameterName = "@FECHA_TERMINO";
            	
            prms[15] = db.GetParameter();
            prms[15].Value = objCURSOCAPACITACION.HORASCURSO;
            prms[15].ParameterName = "@HORAS_CURSO";
            	
            prms[16] = db.GetParameter();
            prms[16].Value = objCURSOCAPACITACION.FECHACOMUNICACION;
            prms[16].ParameterName = "@FECHA_COMUNICACION";
            	
            prms[17] = db.GetParameter();
            prms[17].Value = objCURSOCAPACITACION.FECHALIQUIDACION;
            prms[17].ParameterName = "@FECHA_LIQUIDACION";
            	
            prms[18] = db.GetParameter();
            prms[18].Value = objCURSOCAPACITACION.FECHAPAGO;
            prms[18].ParameterName = "@FECHA_PAGO";
            	
            prms[19] = db.GetParameter();
            prms[19].Value = objCURSOCAPACITACION.COMITEBIPARTITO;
            prms[19].ParameterName = "@COMITE_BIPARTITO";
            	
            prms[20] = db.GetParameter();
            prms[20].Value = objCURSOCAPACITACION.DNC;
            prms[20].ParameterName = "@DNC";
            	
            prms[21] = db.GetParameter();
            prms[21].Value = objCURSOCAPACITACION.MONTODESCUENTO;
            prms[21].ParameterName = "@MONTO_DESCUENTO";
            	
            prms[22] = db.GetParameter();
            prms[22].Value = objCURSOCAPACITACION.NROALUMOS;
            prms[22].ParameterName = "@NRO_ALUMOS";
            	
            prms[23] = db.GetParameter();
            prms[23].Value = objCURSOCAPACITACION.NOTAMINIMA;
            prms[23].ParameterName = "@NOTA_MINIMA";
            	
            prms[24] = db.GetParameter();
            prms[24].Value = objCURSOCAPACITACION.OBSERVACIONCURSO;
            prms[24].ParameterName = "@OBSERVACION_CURSO";
            	
            prms[25] = db.GetParameter();
            prms[25].Value = objCURSOCAPACITACION.HORASCOMPLEMENTO;
            prms[25].ParameterName = "@HORAS_COMPLEMENTO";
            	
            prms[26] = db.GetParameter();
            prms[26].Value = objCURSOCAPACITACION.CORRELATIVOCOMPLEMENTARIO;
            prms[26].ParameterName = "@CORRELATIVO_COMPLEMENTARIO";
            
            return prms;
        }

        protected override IDbDataParameter[] GetUpdateParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(27);
            ECURSOCAPACITACION objCURSOCAPACITACION = obj as ECURSOCAPACITACION;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[0] = db.GetParameter();
            prms[0].Value = objCURSOCAPACITACION.CORRELATIVO;
            prms[0].ParameterName = "@CORRELATIVO";
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objCURSOCAPACITACION.RUTCLIENTE;
            prms[1].ParameterName = "@RUT_CLIENTE";
            	
            prms[2] = db.GetParameter();
            prms[2].Value = objCURSOCAPACITACION.CORRELATIVOAGNO;
            prms[2].ParameterName = "@CORRELATIVO_AGNO";
            	
            prms[3] = db.GetParameter();
            prms[3].Value = objCURSOCAPACITACION.CORRELATIVOCLIENTE;
            prms[3].ParameterName = "@CORRELATIVO_CLIENTE";
            	
            prms[4] = db.GetParameter();
            prms[4].Value = objCURSOCAPACITACION.CODSENCE;
            prms[4].ParameterName = "@COD_SENCE";
            	
            prms[5] = db.GetParameter();
            prms[5].Value = objCURSOCAPACITACION.NUMEROACCIONSENCE;
            prms[5].ParameterName = "@NUMERO_ACCION_SENCE";
            	
            prms[6] = db.GetParameter();
            prms[6].Value = objCURSOCAPACITACION.CODESTADOCURSO;
            prms[6].ParameterName = "@COD_ESTADO_CURSO";
            	
            prms[7] = db.GetParameter();
            prms[7].Value = objCURSOCAPACITACION.CODTIPOCONTRATO;
            prms[7].ParameterName = "@COD_TIPO_CONTRATO";
            	
            prms[8] = db.GetParameter();
            prms[8].Value = objCURSOCAPACITACION.DIRECCIONCURSO;
            prms[8].ParameterName = "@DIRECCION_CURSO";
            	
            prms[9] = db.GetParameter();
            prms[9].Value = objCURSOCAPACITACION.NRODIRECCIONCURSO;
            prms[9].ParameterName = "@NRO_DIRECCION_CURSO";
            	
            prms[10] = db.GetParameter();
            prms[10].Value = objCURSOCAPACITACION.CIUDADCURSO;
            prms[10].ParameterName = "@CIUDAD_CURSO";
            	
            prms[11] = db.GetParameter();
            prms[11].Value = objCURSOCAPACITACION.CODCOMUNA;
            prms[11].ParameterName = "@COD_COMUNA";
            	
            prms[12] = db.GetParameter();
            prms[12].Value = objCURSOCAPACITACION.FECHACREACION;
            prms[12].ParameterName = "@FECHA_CREACION";
            	
            prms[13] = db.GetParameter();
            prms[13].Value = objCURSOCAPACITACION.FECHAINICIO;
            prms[13].ParameterName = "@FECHA_INICIO";
            	
            prms[14] = db.GetParameter();
            prms[14].Value = objCURSOCAPACITACION.FECHATERMINO;
            prms[14].ParameterName = "@FECHA_TERMINO";
            	
            prms[15] = db.GetParameter();
            prms[15].Value = objCURSOCAPACITACION.HORASCURSO;
            prms[15].ParameterName = "@HORAS_CURSO";
            	
            prms[16] = db.GetParameter();
            prms[16].Value = objCURSOCAPACITACION.FECHACOMUNICACION;
            prms[16].ParameterName = "@FECHA_COMUNICACION";
            	
            prms[17] = db.GetParameter();
            prms[17].Value = objCURSOCAPACITACION.FECHALIQUIDACION;
            prms[17].ParameterName = "@FECHA_LIQUIDACION";
            	
            prms[18] = db.GetParameter();
            prms[18].Value = objCURSOCAPACITACION.FECHAPAGO;
            prms[18].ParameterName = "@FECHA_PAGO";
            	
            prms[19] = db.GetParameter();
            prms[19].Value = objCURSOCAPACITACION.COMITEBIPARTITO;
            prms[19].ParameterName = "@COMITE_BIPARTITO";
            	
            prms[20] = db.GetParameter();
            prms[20].Value = objCURSOCAPACITACION.DNC;
            prms[20].ParameterName = "@DNC";
            	
            prms[21] = db.GetParameter();
            prms[21].Value = objCURSOCAPACITACION.MONTODESCUENTO;
            prms[21].ParameterName = "@MONTO_DESCUENTO";
            	
            prms[22] = db.GetParameter();
            prms[22].Value = objCURSOCAPACITACION.NROALUMOS;
            prms[22].ParameterName = "@NRO_ALUMOS";
            	
            prms[23] = db.GetParameter();
            prms[23].Value = objCURSOCAPACITACION.NOTAMINIMA;
            prms[23].ParameterName = "@NOTA_MINIMA";
            	
            prms[24] = db.GetParameter();
            prms[24].Value = objCURSOCAPACITACION.OBSERVACIONCURSO;
            prms[24].ParameterName = "@OBSERVACION_CURSO";
            	
            prms[25] = db.GetParameter();
            prms[25].Value = objCURSOCAPACITACION.HORASCOMPLEMENTO;
            prms[25].ParameterName = "@HORAS_COMPLEMENTO";
            	
            prms[26] = db.GetParameter();
            prms[26].Value = objCURSOCAPACITACION.CORRELATIVOCOMPLEMENTARIO;
            prms[26].ParameterName = "@CORRELATIVO_COMPLEMENTARIO";
            
            return prms;
        }

        protected override void SetPrimaryKey(DomainObject obj, long id)
        {
            ECURSOCAPACITACION objRoot = obj as ECURSOCAPACITACION;

            objRoot.CORRELATIVO = id;
        }

        #endregion

        #region Public Methods

         public override void Fill(DomainObject obj, IDataReader dr)
        {
            ECURSOCAPACITACION objCURSOCAPACITACION = obj as ECURSOCAPACITACION;
    
            //Poner las rutinas del Tools que se necesiten

            objCURSOCAPACITACION.CORRELATIVO = Utiles.ConvertToInt64(dr["CORRELATIVO"]);
            
            objCURSOCAPACITACION.RUTCLIENTE = Utiles.ConvertToInt64(dr["RUT_CLIENTE"]);
            
            objCURSOCAPACITACION.CORRELATIVOAGNO = Utiles.ConvertToInt64(dr["CORRELATIVO_AGNO"]);
            
            objCURSOCAPACITACION.CORRELATIVOCLIENTE = Utiles.ConvertToString(dr["CORRELATIVO_CLIENTE"]);
            
            objCURSOCAPACITACION.CODSENCE = Utiles.ConvertToInt64(dr["COD_SENCE"]);
            
            objCURSOCAPACITACION.NUMEROACCIONSENCE = Utiles.ConvertToInt64(dr["NUMERO_ACCION_SENCE"]);
            
            objCURSOCAPACITACION.CODESTADOCURSO = Utiles.ConvertToDecimal(dr["COD_ESTADO_CURSO"]);

            objCURSOCAPACITACION.CODTIPOCONTRATO = Utiles.ConvertToDecimal(dr["COD_TIPO_CONTRATO"]);
            
            objCURSOCAPACITACION.DIRECCIONCURSO = Utiles.ConvertToString(dr["DIRECCION_CURSO"]);
            
            objCURSOCAPACITACION.NRODIRECCIONCURSO = Utiles.ConvertToString(dr["NRO_DIRECCION_CURSO"]);
            
            objCURSOCAPACITACION.CIUDADCURSO = Utiles.ConvertToString(dr["CIUDAD_CURSO"]);
            
            objCURSOCAPACITACION.CODCOMUNA = Utiles.ConvertToInt64(dr["COD_COMUNA"]);
            
            objCURSOCAPACITACION.FECHACREACION = Utiles.ConvertToDateTime(dr["FECHA_CREACION"]);
            
            objCURSOCAPACITACION.FECHAINICIO = Utiles.ConvertToDateTime(dr["FECHA_INICIO"]);
            
            objCURSOCAPACITACION.FECHATERMINO = Utiles.ConvertToDateTime(dr["FECHA_TERMINO"]);
            
            objCURSOCAPACITACION.HORASCURSO = Utiles.ConvertToInt16(dr["HORAS_CURSO"]);
            
            objCURSOCAPACITACION.FECHACOMUNICACION = Utiles.ConvertToDateTime(dr["FECHA_COMUNICACION"]);
            
            objCURSOCAPACITACION.FECHALIQUIDACION = Utiles.ConvertToDateTime(dr["FECHA_LIQUIDACION"]);
            
            objCURSOCAPACITACION.FECHAPAGO = Utiles.ConvertToDateTime(dr["FECHA_PAGO"]);
            
            objCURSOCAPACITACION.COMITEBIPARTITO = Utiles.ConvertToBoolean(dr["COMITE_BIPARTITO"]);
            
            objCURSOCAPACITACION.DNC = Utiles.ConvertToBoolean(dr["DNC"]);
            
            objCURSOCAPACITACION.MONTODESCUENTO = Utiles.ConvertToInt64(dr["MONTO_DESCUENTO"]);
            
            objCURSOCAPACITACION.NROALUMOS = Utiles.ConvertToInt16(dr["NRO_ALUMOS"]);
            
            objCURSOCAPACITACION.NOTAMINIMA = Utiles.ConvertToDouble(dr["NOTA_MINIMA"]);
            
            objCURSOCAPACITACION.OBSERVACIONCURSO = Utiles.ConvertToString(dr["OBSERVACION_CURSO"]);
            
            objCURSOCAPACITACION.HORASCOMPLEMENTO = Utiles.ConvertToInt16(dr["HORAS_COMPLEMENTO"]);

            objCURSOCAPACITACION.CORRELATIVOCOMPLEMENTARIO = Utiles.ConvertToDecimal(dr["CORRELATIVO_COMPLEMENTARIO"]);
            
        }

        #endregion

	}
}
