
using System;
using System.Collections.Generic;
using SAGO.COMMON;
using SAGO.BUSINESS;
using SAGO.CLASES.DAL;
using SAGO.CLASES.DAO;


namespace SAGO.BUSINESS
{
	/// <summary>
	/// BFFRANQUICIASENCE.
	/// </summary>
	public class BFFRANQUICIASENCE
	{
		private DLFRANQUICIASENCE _objDAL;
		private DLFRANQUICIASENCEList _objDALList;
		
		public BFFRANQUICIASENCE()
		{
			_objDAL = new DLFRANQUICIASENCE();
			_objDALList = new DLFRANQUICIASENCEList();
		}

		public EFRANQUICIASENCE GetFRANQUICIASENCE()
		{
			return new EFRANQUICIASENCE();
		}

		public EFRANQUICIASENCE GetFRANQUICIASENCE(long id)
		{
            return new EFRANQUICIASENCE(id);
		}

		public bool Save(EFRANQUICIASENCE objFRANQUICIASENCE)
		{
			try
			{
				objFRANQUICIASENCE.Save();
				return true;
			}
			catch (Exception ex)
			{
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
			}
		}

		public List<EFRANQUICIASENCE> GetFRANQUICIASENCEAll()
		{
			return _objDALList.SelectAll();
		}

        public bool Delete(EFRANQUICIASENCE objFRANQUICIASENCE)
		{
			try
			{
                _objDAL.Delete(objFRANQUICIASENCE);
			    return true;
            }
            catch (Exception ex)
            {
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
            }
		}

        public bool Update(EFRANQUICIASENCE objFRANQUICIASENCE)
        {
            try
            {
                _objDAL.Update(objFRANQUICIASENCE);
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

