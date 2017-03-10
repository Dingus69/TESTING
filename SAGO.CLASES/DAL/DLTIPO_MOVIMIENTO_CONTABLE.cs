
using System;
using System.Data;
using SAGO.DATAACCESS;
using SAGO.CLASES.DAO;
using SAGO.COMMON;

namespace SAGO.CLASES.DAL
{
	/// <summary>
	/// Summary description for DLTIPOMOVIMIENTOCONTABLE.
	/// </summary>
	public class DLTIPOMOVIMIENTOCONTABLE : DLBase
	{
		public DLTIPOMOVIMIENTOCONTABLE()
		{
		}

        #region Protected Methods

        protected override string GetDeleteProcedure()
        {
            return "proc_delete_TIPO_MOVIMIENTO_CONTABLE";
        }

        protected override string GetInsertProcedure()
        {
            return "proc_insert_TIPO_MOVIMIENTO_CONTABLE";
        }

        protected override string GetSelectProcedure()
        {
            return "proc_select_TIPO_MOVIMIENTO_CONTABLE";
        }

        protected override string GetUpdateProcedure()
        {
            return "proc_update_TIPO_MOVIMIENTO_CONTABLE";
        }

        protected override IDbDataParameter[] GetSelectParameters(long id, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);

            prms[0] = db.GetParameter();
            prms[0].Value = id;
            prms[0].ParameterName = "@COD_TIPO_MOVIMIENTO_CONTABLE";

            return prms;
        }

        protected override IDbDataParameter[] GetDeleteParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            ETIPOMOVIMIENTOCONTABLE objTIPOMOVIMIENTOCONTABLE = obj as ETIPOMOVIMIENTOCONTABLE;

            prms[0] = db.GetParameter();
            prms[0].Value = objTIPOMOVIMIENTOCONTABLE.CODTIPOMOVIMIENTOCONTABLE;
            prms[0].ParameterName = "@COD_TIPO_MOVIMIENTO_CONTABLE";

            return prms;
        }

        protected override IDbDataParameter[] GetInsertParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(1);
            ETIPOMOVIMIENTOCONTABLE objTIPOMOVIMIENTOCONTABLE = obj as ETIPOMOVIMIENTOCONTABLE;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objTIPOMOVIMIENTOCONTABLE.TIPOMOVIMIENTO;
            prms[1].ParameterName = "@TIPO_MOVIMIENTO";
            
            return prms;
        }

        protected override IDbDataParameter[] GetUpdateParameters(DomainObject obj, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(2);
            ETIPOMOVIMIENTOCONTABLE objTIPOMOVIMIENTOCONTABLE = obj as ETIPOMOVIMIENTOCONTABLE;

            //Poner las rutinas del Tools que se necesiten
            	
            prms[0] = db.GetParameter();
            prms[0].Value = objTIPOMOVIMIENTOCONTABLE.CODTIPOMOVIMIENTOCONTABLE;
            prms[0].ParameterName = "@COD_TIPO_MOVIMIENTO_CONTABLE";
            	
            prms[1] = db.GetParameter();
            prms[1].Value = objTIPOMOVIMIENTOCONTABLE.TIPOMOVIMIENTO;
            prms[1].ParameterName = "@TIPO_MOVIMIENTO";
            
            return prms;
        }

        protected override void SetPrimaryKey(DomainObject obj, long id)
        {
            ETIPOMOVIMIENTOCONTABLE objRoot = obj as ETIPOMOVIMIENTOCONTABLE;

            objRoot.CODTIPOMOVIMIENTOCONTABLE = id;
        }

        #endregion

        #region Public Methods

         public override void Fill(DomainObject obj, IDataReader dr)
        {
            ETIPOMOVIMIENTOCONTABLE objTIPOMOVIMIENTOCONTABLE = obj as ETIPOMOVIMIENTOCONTABLE;
    
            //Poner las rutinas del Tools que se necesiten
            
            objTIPOMOVIMIENTOCONTABLE.CODTIPOMOVIMIENTOCONTABLE = Utiles.ConvertToDecimal(dr["COD_TIPO_MOVIMIENTO_CONTABLE"]);

            objTIPOMOVIMIENTOCONTABLE.TIPOMOVIMIENTO = Utiles.ConvertToString(dr["TIPO_MOVIMIENTO"]);
            
        }

        #endregion

	}
}
