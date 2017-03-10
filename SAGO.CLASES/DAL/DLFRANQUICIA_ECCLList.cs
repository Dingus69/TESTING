
using System;
using System.Data;
using System.Collections.Generic;
using SAGO.CLASES.DAO;
using SAGO.COMMON;
using SAGO.DATAACCESS;



namespace SAGO.CLASES.DAL
{
	/// <summary>
	/// Summary description for DLFRANQUICIAECCLList.
	/// </summary>
    public class DLFRANQUICIAECCLList : DLGenericBaseList<EFRANQUICIAECCL>
	{
		public DLFRANQUICIAECCLList()
		{
            this._proc_select_all = "proc_select_FRANQUICIA_ECCL_all";
		}
		
		#region Methods


        /// <summary>
        /// Selecciona todos los registros de la tabla.
        /// </summary>
        /// <returns>Una lista con los registros</returns>
        public List<EFRANQUICIAECCL> SelectAll()
        {
            DB db = DatabaseFactory.Instance.GetDatabase();

            IDataReader dr = db.ExecuteReader(CommandType.StoredProcedure, _proc_select_all, null);

            return GetCollection(dr);
        }

		#endregion
	}
}
