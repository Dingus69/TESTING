
using System;
using System.Data;
using System.Collections.Generic;
using SAGO.CLASES.DAO;
using SAGO.COMMON;
using SAGO.DATAACCESS;



namespace SAGO.CLASES.DAL
{
	/// <summary>
	/// Summary description for DLMOVIMIENTOAPORTEList.
	/// </summary>
    public class DLMOVIMIENTOAPORTEList : DLGenericBaseList<EMOVIMIENTOAPORTE>
	{
		public DLMOVIMIENTOAPORTEList()
		{
            this._proc_select_all = "proc_select_MOVIMIENTO_APORTE_all";
		}
		
		#region Methods


        /// <summary>
        /// Selecciona todos los registros de la tabla.
        /// </summary>
        /// <returns>Una lista con los registros</returns>
        public List<EMOVIMIENTOAPORTE> SelectAll()
        {
            DB db = DatabaseFactory.Instance.GetDatabase();

            IDataReader dr = db.ExecuteReader(CommandType.StoredProcedure, _proc_select_all, null);

            return GetCollection(dr);
        }

		#endregion
	}
}
