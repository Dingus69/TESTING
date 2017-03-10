
using System;
using System.Collections.Generic;
using SAGO.COMMON;
using SAGO.BUSINESS;
using SAGO.CLASES.DAL;
using SAGO.CLASES.DAO;


namespace SAGO.BUSINESS
{
	/// <summary>
	/// BFCARGO.
	/// </summary>
	public class BFCARGO
	{
		private DLCARGO _objDAL;
		private DLCARGOList _objDALList;
		
		public BFCARGO()
		{
			_objDAL = new DLCARGO();
			_objDALList = new DLCARGOList();
		}

		public ECARGO GetCARGO()
		{
			return new ECARGO();
		}

		public ECARGO GetCARGO(long id)
		{
            return new ECARGO(id);
		}

		public bool Save(ECARGO objCARGO)
		{
			try
			{
				objCARGO.Save();
				return true;
			}
			catch (Exception ex)
			{
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
			}
		}

		public List<ECARGO> GetCARGOAll()
		{
			return _objDALList.SelectAll();
		}

        public bool Delete(ECARGO objCARGO)
		{
			try
			{
                _objDAL.Delete(objCARGO);
			    return true;
            }
            catch (Exception ex)
            {
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
            }
		}

        public bool Update(ECARGO objCARGO)
        {
            try
            {
                _objDAL.Update(objCARGO);
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

