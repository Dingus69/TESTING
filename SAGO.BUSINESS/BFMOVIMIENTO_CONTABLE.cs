
using System;
using System.Collections.Generic;
using SAGO.COMMON;
using SAGO.BUSINESS;
using SAGO.CLASES.DAL;
using SAGO.CLASES.DAO;


namespace SAGO.BUSINESS
{
	/// <summary>
	/// BFMOVIMIENTOCONTABLE.
	/// </summary>
	public class BFMOVIMIENTOCONTABLE
	{
		private DLMOVIMIENTOCONTABLE _objDAL;
		private DLMOVIMIENTOCONTABLEList _objDALList;
		
		public BFMOVIMIENTOCONTABLE()
		{
			_objDAL = new DLMOVIMIENTOCONTABLE();
			_objDALList = new DLMOVIMIENTOCONTABLEList();
		}

		public EMOVIMIENTOCONTABLE GetMOVIMIENTOCONTABLE()
		{
			return new EMOVIMIENTOCONTABLE();
		}

		public EMOVIMIENTOCONTABLE GetMOVIMIENTOCONTABLE(long id)
		{
            return new EMOVIMIENTOCONTABLE(id);
		}

		public bool Save(EMOVIMIENTOCONTABLE objMOVIMIENTOCONTABLE)
		{
			try
			{
				objMOVIMIENTOCONTABLE.Save();
				return true;
			}
			catch (Exception ex)
			{
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
			}
		}

		public List<EMOVIMIENTOCONTABLE> GetMOVIMIENTOCONTABLEAll()
		{
			return _objDALList.SelectAll();
		}

        public bool Delete(EMOVIMIENTOCONTABLE objMOVIMIENTOCONTABLE)
		{
			try
			{
                _objDAL.Delete(objMOVIMIENTOCONTABLE);
			    return true;
            }
            catch (Exception ex)
            {
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
            }
		}

        public bool Update(EMOVIMIENTOCONTABLE objMOVIMIENTOCONTABLE)
        {
            try
            {
                _objDAL.Update(objMOVIMIENTOCONTABLE);
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

