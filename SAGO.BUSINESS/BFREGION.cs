
using System;
using System.Collections.Generic;
using SAGO.COMMON;
using SAGO.BUSINESS;
using SAGO.CLASES.DAL;
using SAGO.CLASES.DAO;


namespace SAGO.BUSINESS
{
	/// <summary>
	/// BFREGION.
	/// </summary>
	public class BFREGION
	{
		private DLREGION _objDAL;
		private DLREGIONList _objDALList;
		
		public BFREGION()
		{
			_objDAL = new DLREGION();
			_objDALList = new DLREGIONList();
		}

		public EREGION GetREGION()
		{
			return new EREGION();
		}

		public EREGION GetREGION(long id)
		{
            return new EREGION(id);
		}

		public bool Save(EREGION objREGION)
		{
			try
			{
				objREGION.Save();
				return true;
			}
			catch (Exception ex)
			{
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
			}
		}

		public List<EREGION> GetREGIONAll()
		{
			return _objDALList.SelectAll();
		}

        public bool Delete(EREGION objREGION)
		{
			try
			{
                _objDAL.Delete(objREGION);
			    return true;
            }
            catch (Exception ex)
            {
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
            }
		}

        public bool Update(EREGION objREGION)
        {
            try
            {
                _objDAL.Update(objREGION);
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

