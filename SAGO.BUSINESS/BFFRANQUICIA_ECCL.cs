
using System;
using System.Collections.Generic;
using SAGO.COMMON;
using SAGO.BUSINESS;
using SAGO.CLASES.DAL;
using SAGO.CLASES.DAO;


namespace SAGO.BUSINESS
{
	/// <summary>
	/// BFFRANQUICIAECCL.
	/// </summary>
	public class BFFRANQUICIAECCL
	{
		private DLFRANQUICIAECCL _objDAL;
		private DLFRANQUICIAECCLList _objDALList;
		
		public BFFRANQUICIAECCL()
		{
			_objDAL = new DLFRANQUICIAECCL();
			_objDALList = new DLFRANQUICIAECCLList();
		}

		public EFRANQUICIAECCL GetFRANQUICIAECCL()
		{
			return new EFRANQUICIAECCL();
		}

		public EFRANQUICIAECCL GetFRANQUICIAECCL(long id)
		{
            return new EFRANQUICIAECCL(id);
		}

		public bool Save(EFRANQUICIAECCL objFRANQUICIAECCL)
		{
			try
			{
				objFRANQUICIAECCL.Save();
				return true;
			}
			catch (Exception ex)
			{
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
			}
		}

		public List<EFRANQUICIAECCL> GetFRANQUICIAECCLAll()
		{
			return _objDALList.SelectAll();
		}

        public bool Delete(EFRANQUICIAECCL objFRANQUICIAECCL)
		{
			try
			{
                _objDAL.Delete(objFRANQUICIAECCL);
			    return true;
            }
            catch (Exception ex)
            {
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
            }
		}

        public bool Update(EFRANQUICIAECCL objFRANQUICIAECCL)
        {
            try
            {
                _objDAL.Update(objFRANQUICIAECCL);
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

