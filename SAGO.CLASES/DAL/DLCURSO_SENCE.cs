
using System;
using System.Data;
using SAGO.DATAACCESS;
using SAGO.CLASES.DAO;
using SAGO.COMMON;

namespace SAGO.CLASES.DAL
{
	/// <summary>
	/// Summary description for DLCURSOSENCE.
	/// </summary>
	public class DLCURSOSENCE : DLBase
	{
		public DLCURSOSENCE()
		{
		}

        #region Protected Methods

        protected override string GetDeleteProcedure()
        {
            return "proc_delete_CURSO_SENCE";
        }

        protected override string GetInsertProcedure()
        {
            return "proc_insert_CURSO_SENCE";
        }

        protected override string GetSelectProcedure()
        {
            return "proc_select_CURSO_SENCE";
        }

        protected override string GetUpdateProcedure()
        {
            return "proc_update_CURSO_SENCE";
        }

        protected override IDbDataParameter[] GetSelectParameters(long id, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);

            prms[0] = db.GetParameter();
            prms[0].Value = id;
            prms[0].ParameterName = "@COD_SENCE";

            return prms;
        }

        protected override IDbDataParameter[] GetDeleteParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            ECURSOSENCE objCURSOSENCE = obj as ECURSOSENCE;

            prms[0] = db.GetParameter();
            prms[0].Value = objCURSOSENCE.CODSENCE;
            prms[0].ParameterName = "@COD_SENCE";

            return prms;
        }

        protected override IDbDataParameter[] GetInsertParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(12);
            ECURSOSENCE objCURSOSENCE = obj as ECURSOSENCE;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objCURSOSENCE.CODMODALIDAD;
            prms[1].ParameterName = "@COD_MODALIDAD";
            	
            prms[2] = db.GetParameter();
            prms[2].Value = objCURSOSENCE.RUTOTEC;
            prms[2].ParameterName = "@RUT_OTEC";
            	
            prms[3] = db.GetParameter();
            prms[3].Value = objCURSOSENCE.NOMBRESENCE;
            prms[3].ParameterName = "@NOMBRE_SENCE";
            	
            prms[4] = db.GetParameter();
            prms[4].Value = objCURSOSENCE.HORASTEORICAS;
            prms[4].ParameterName = "@HORAS_TEORICAS";
            	
            prms[5] = db.GetParameter();
            prms[5].Value = objCURSOSENCE.HORASPRACTICAS;
            prms[5].ParameterName = "@HORAS_PRACTICAS";
            	
            prms[6] = db.GetParameter();
            prms[6].Value = objCURSOSENCE.HORASELEARNING;
            prms[6].ParameterName = "@HORAS_ELEARNING";
            	
            prms[7] = db.GetParameter();
            prms[7].Value = objCURSOSENCE.NUMEROPARTICIPANTE;
            prms[7].ParameterName = "@NUMERO_PARTICIPANTE";
            	
            prms[8] = db.GetParameter();
            prms[8].Value = objCURSOSENCE.AREA;
            prms[8].ParameterName = "@AREA";
            	
            prms[9] = db.GetParameter();
            prms[9].Value = objCURSOSENCE.ESPECIALIDAD;
            prms[9].ParameterName = "@ESPECIALIDAD";
            	
            prms[10] = db.GetParameter();
            prms[10].Value = objCURSOSENCE.VALORCURSO;
            prms[10].ParameterName = "@VALOR_CURSO";
            	
            prms[11] = db.GetParameter();
            prms[11].Value = objCURSOSENCE.VALOREFECTIVOPARTICIPANTE;
            prms[11].ParameterName = "@VALOR_EFECTIVO_PARTICIPANTE";
            	
            prms[12] = db.GetParameter();
            prms[12].Value = objCURSOSENCE.VALORIMPUTABLEPARTICITANTE;
            prms[12].ParameterName = "@VALOR_IMPUTABLE_PARTICITANTE";
            
            return prms;
        }

        protected override IDbDataParameter[] GetUpdateParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(13);
            ECURSOSENCE objCURSOSENCE = obj as ECURSOSENCE;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[0] = db.GetParameter();
            prms[0].Value = objCURSOSENCE.CODSENCE;
            prms[0].ParameterName = "@COD_SENCE";
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objCURSOSENCE.CODMODALIDAD;
            prms[1].ParameterName = "@COD_MODALIDAD";
            	
            prms[2] = db.GetParameter();
            prms[2].Value = objCURSOSENCE.RUTOTEC;
            prms[2].ParameterName = "@RUT_OTEC";
            	
            prms[3] = db.GetParameter();
            prms[3].Value = objCURSOSENCE.NOMBRESENCE;
            prms[3].ParameterName = "@NOMBRE_SENCE";
            	
            prms[4] = db.GetParameter();
            prms[4].Value = objCURSOSENCE.HORASTEORICAS;
            prms[4].ParameterName = "@HORAS_TEORICAS";
            	
            prms[5] = db.GetParameter();
            prms[5].Value = objCURSOSENCE.HORASPRACTICAS;
            prms[5].ParameterName = "@HORAS_PRACTICAS";
            	
            prms[6] = db.GetParameter();
            prms[6].Value = objCURSOSENCE.HORASELEARNING;
            prms[6].ParameterName = "@HORAS_ELEARNING";
            	
            prms[7] = db.GetParameter();
            prms[7].Value = objCURSOSENCE.NUMEROPARTICIPANTE;
            prms[7].ParameterName = "@NUMERO_PARTICIPANTE";
            	
            prms[8] = db.GetParameter();
            prms[8].Value = objCURSOSENCE.AREA;
            prms[8].ParameterName = "@AREA";
            	
            prms[9] = db.GetParameter();
            prms[9].Value = objCURSOSENCE.ESPECIALIDAD;
            prms[9].ParameterName = "@ESPECIALIDAD";
            	
            prms[10] = db.GetParameter();
            prms[10].Value = objCURSOSENCE.VALORCURSO;
            prms[10].ParameterName = "@VALOR_CURSO";
            	
            prms[11] = db.GetParameter();
            prms[11].Value = objCURSOSENCE.VALOREFECTIVOPARTICIPANTE;
            prms[11].ParameterName = "@VALOR_EFECTIVO_PARTICIPANTE";
            	
            prms[12] = db.GetParameter();
            prms[12].Value = objCURSOSENCE.VALORIMPUTABLEPARTICITANTE;
            prms[12].ParameterName = "@VALOR_IMPUTABLE_PARTICITANTE";
            
            return prms;
        }

        protected override void SetPrimaryKey(DomainObject obj, long id)
        {
            ECURSOSENCE objRoot = obj as ECURSOSENCE;

            objRoot.CODSENCE = id;
        }

        #endregion

        #region Public Methods

         public override void Fill(DomainObject obj, IDataReader dr)
        {
            ECURSOSENCE objCURSOSENCE = obj as ECURSOSENCE;
    
            //Poner las rutinas del Tools que se necesiten
            
            objCURSOSENCE.CODSENCE = Utiles.ConvertToInt64(dr["COD_SENCE"]);
            
            objCURSOSENCE.CODMODALIDAD = Utiles.ConvertToDecimal(dr["COD_MODALIDAD"]);
            
            objCURSOSENCE.RUTOTEC = Utiles.ConvertToInt64(dr["RUT_OTEC"]);

            objCURSOSENCE.NOMBRESENCE = Utiles.ConvertToString(dr["NOMBRE_SENCE"]);

            objCURSOSENCE.HORASTEORICAS = Utiles.ConvertToInt16(dr["HORAS_TEORICAS"]);

            objCURSOSENCE.HORASPRACTICAS = Utiles.ConvertToInt16(dr["HORAS_PRACTICAS"]);

            objCURSOSENCE.HORASELEARNING = Utiles.ConvertToInt16(dr["HORAS_ELEARNING"]);

            objCURSOSENCE.NUMEROPARTICIPANTE = Utiles.ConvertToInt16(dr["NUMERO_PARTICIPANTE"]);

            objCURSOSENCE.AREA = Utiles.ConvertToString(dr["AREA"]);

            objCURSOSENCE.ESPECIALIDAD = Utiles.ConvertToString(dr["ESPECIALIDAD"]);
            
            objCURSOSENCE.VALORCURSO = Utiles.ConvertToInt64(dr["VALOR_CURSO"]);
            
            objCURSOSENCE.VALOREFECTIVOPARTICIPANTE = Utiles.ConvertToInt64(dr["VALOR_EFECTIVO_PARTICIPANTE"]);
            
            objCURSOSENCE.VALORIMPUTABLEPARTICITANTE = Utiles.ConvertToInt64(dr["VALOR_IMPUTABLE_PARTICITANTE"]);
            
        }

        #endregion

	}
}
