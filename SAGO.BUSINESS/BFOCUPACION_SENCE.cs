
using System;
using System.Collections.Generic;
using SAGO.COMMON;
using SAGO.BUSINESS;
using SAGO.CLASES.DAL;
using SAGO.CLASES.DAO;


namespace SAGO.BUSINESS
{
	/// <summary>
	/// BFOCUPACIONSENCE.
	/// </summary>
	public class BFOCUPACIONSENCE
	{
		private DLOCUPACIONSENCE _objDAL;
		private DLOCUPACIONSENCEList _objDALList;
		
		public BFOCUPACIONSENCE()
		{
			_objDAL = new DLOCUPACIONSENCE();
			_objDALList = new DLOCUPACIONSENCEList();
		}

		public EOCUPACIONSENCE GetOCUPACIONSENCE()
		{
			return new EOCUPACIONSENCE();
		}

		public EOCUPACIONSENCE GetOCUPACIONSENCE(long id)
		{
            return new EOCUPACIONSENCE(id);
		}

		public bool Save(EOCUPACIONSENCE objOCUPACIONSENCE)
		{
			try
			{
				objOCUPACIONSENCE.Save();
				return true;
			}
			catch (Exception ex)
			{
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
			}
		}

		public List<EOCUPACIONSENCE> GetOCUPACIONSENCEAll()
		{
			return _objDALList.SelectAll();
		}

        public bool Delete(EOCUPACIONSENCE objOCUPACIONSENCE)
		{
			try
			{
                _objDAL.Delete(objOCUPACIONSENCE);
			    return true;
            }
            catch (Exception ex)
            {
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
            }
		}

        public bool Update(EOCUPACIONSENCE objOCUPACIONSENCE)
        {
            try
            {
                _objDAL.Update(objOCUPACIONSENCE);
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

