
using System;
using System.Collections.Generic;
using SAGO.COMMON;
using SAGO.BUSINESS;
using SAGO.CLASES.DAL;
using SAGO.CLASES.DAO;


namespace SAGO.BUSINESS
{
	/// <summary>
	/// BFOTEC.
	/// </summary>
	public class BFOTEC
	{
		private DLOTEC _objDAL;
		private DLOTECList _objDALList;
		
		public BFOTEC()
		{
			_objDAL = new DLOTEC();
			_objDALList = new DLOTECList();
		}

		public EOTEC GetOTEC()
		{
			return new EOTEC();
		}

		public EOTEC GetOTEC(long id)
		{
            return new EOTEC(id);
		}

		public bool Save(EOTEC objOTEC)
		{
			try
			{
				objOTEC.Save();
				return true;
			}
			catch (Exception ex)
			{
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
			}
		}

		public List<EOTEC> GetOTECAll()
		{
			return _objDALList.SelectAll();
		}

        public bool Delete(EOTEC objOTEC)
		{
			try
			{
                _objDAL.Delete(objOTEC);
			    return true;
            }
            catch (Exception ex)
            {
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
            }
		}

        public bool Update(EOTEC objOTEC)
        {
            try
            {
                _objDAL.Update(objOTEC);
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

