
using System;
using System.Collections.Generic;
using SAGO.COMMON;
using SAGO.BUSINESS;
using SAGO.CLASES.DAL;
using SAGO.CLASES.DAO;


namespace SAGO.BUSINESS
{
	/// <summary>
	/// BFCURSOSENCE.
	/// </summary>
	public class BFCURSOSENCE
	{
		private DLCURSOSENCE _objDAL;
		private DLCURSOSENCEList _objDALList;
		
		public BFCURSOSENCE()
		{
			_objDAL = new DLCURSOSENCE();
			_objDALList = new DLCURSOSENCEList();
		}

		public ECURSOSENCE GetCURSOSENCE()
		{
			return new ECURSOSENCE();
		}

		public ECURSOSENCE GetCURSOSENCE(long id)
		{
            return new ECURSOSENCE(id);
		}

		public bool Save(ECURSOSENCE objCURSOSENCE)
		{
			try
			{
				objCURSOSENCE.Save();
				return true;
			}
			catch (Exception ex)
			{
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
			}
		}

		public List<ECURSOSENCE> GetCURSOSENCEAll()
		{
			return _objDALList.SelectAll();
		}

        public bool Delete(ECURSOSENCE objCURSOSENCE)
		{
			try
			{
                _objDAL.Delete(objCURSOSENCE);
			    return true;
            }
            catch (Exception ex)
            {
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
            }
		}

        public bool Update(ECURSOSENCE objCURSOSENCE)
        {
            try
            {
                _objDAL.Update(objCURSOSENCE);
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

