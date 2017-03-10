
using System;
using System.Collections.Generic;
using SAGO.COMMON;
using SAGO.BUSINESS;
using SAGO.CLASES.DAL;
using SAGO.CLASES.DAO;


namespace SAGO.BUSINESS
{
	/// <summary>
	/// BFEDUCACIONSENCE.
	/// </summary>
	public class BFEDUCACIONSENCE
	{
		private DLEDUCACIONSENCE _objDAL;
		private DLEDUCACIONSENCEList _objDALList;
		
		public BFEDUCACIONSENCE()
		{
			_objDAL = new DLEDUCACIONSENCE();
			_objDALList = new DLEDUCACIONSENCEList();
		}

		public EEDUCACIONSENCE GetEDUCACIONSENCE()
		{
			return new EEDUCACIONSENCE();
		}

		public EEDUCACIONSENCE GetEDUCACIONSENCE(long id)
		{
            return new EEDUCACIONSENCE(id);
		}

		public bool Save(EEDUCACIONSENCE objEDUCACIONSENCE)
		{
			try
			{
				objEDUCACIONSENCE.Save();
				return true;
			}
			catch (Exception ex)
			{
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
			}
		}

		public List<EEDUCACIONSENCE> GetEDUCACIONSENCEAll()
		{
			return _objDALList.SelectAll();
		}

        public bool Delete(EEDUCACIONSENCE objEDUCACIONSENCE)
		{
			try
			{
                _objDAL.Delete(objEDUCACIONSENCE);
			    return true;
            }
            catch (Exception ex)
            {
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
            }
		}

        public bool Update(EEDUCACIONSENCE objEDUCACIONSENCE)
        {
            try
            {
                _objDAL.Update(objEDUCACIONSENCE);
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

