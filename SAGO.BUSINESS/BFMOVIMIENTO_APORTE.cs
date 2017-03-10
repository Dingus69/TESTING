
using System;
using System.Collections.Generic;
using SAGO.COMMON;
using SAGO.BUSINESS;
using SAGO.CLASES.DAL;
using SAGO.CLASES.DAO;


namespace SAGO.BUSINESS
{
	/// <summary>
	/// BFMOVIMIENTOAPORTE.
	/// </summary>
	public class BFMOVIMIENTOAPORTE
	{
		private DLMOVIMIENTOAPORTE _objDAL;
		private DLMOVIMIENTOAPORTEList _objDALList;
		
		public BFMOVIMIENTOAPORTE()
		{
			_objDAL = new DLMOVIMIENTOAPORTE();
			_objDALList = new DLMOVIMIENTOAPORTEList();
		}

		public EMOVIMIENTOAPORTE GetMOVIMIENTOAPORTE()
		{
			return new EMOVIMIENTOAPORTE();
		}

		public EMOVIMIENTOAPORTE GetMOVIMIENTOAPORTE(long id)
		{
            return new EMOVIMIENTOAPORTE(id);
		}

		public bool Save(EMOVIMIENTOAPORTE objMOVIMIENTOAPORTE)
		{
			try
			{
				objMOVIMIENTOAPORTE.Save();
				return true;
			}
			catch (Exception ex)
			{
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
			}
		}

		public List<EMOVIMIENTOAPORTE> GetMOVIMIENTOAPORTEAll()
		{
			return _objDALList.SelectAll();
		}

        public bool Delete(EMOVIMIENTOAPORTE objMOVIMIENTOAPORTE)
		{
			try
			{
                _objDAL.Delete(objMOVIMIENTOAPORTE);
			    return true;
            }
            catch (Exception ex)
            {
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
            }
		}

        public bool Update(EMOVIMIENTOAPORTE objMOVIMIENTOAPORTE)
        {
            try
            {
                _objDAL.Update(objMOVIMIENTOAPORTE);
                return true;
            }
            catch (Exception ex)
            {
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
            }
        }

	}
}

