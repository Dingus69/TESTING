
using System;
using System.Collections.Generic;
using SAGO.COMMON;
using SAGO.BUSINESS;
using SAGO.CLASES.DAL;
using SAGO.CLASES.DAO;


namespace SAGO.BUSINESS
{
	/// <summary>
	/// BFCUENTA.
	/// </summary>
	public class BFCUENTA
	{
		private DLCUENTA _objDAL;
		private DLCUENTAList _objDALList;
		
		public BFCUENTA()
		{
			_objDAL = new DLCUENTA();
			_objDALList = new DLCUENTAList();
		}

		public ECUENTA GetCUENTA()
		{
			return new ECUENTA();
		}

		public ECUENTA GetCUENTA(long id)
		{
            return new ECUENTA(id);
		}

		public bool Save(ECUENTA objCUENTA)
		{
			try
			{
				objCUENTA.Save();
				return true;
			}
			catch (Exception ex)
			{
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
			}
		}

		public List<ECUENTA> GetCUENTAAll()
		{
			return _objDALList.SelectAll();
		}

        public bool Delete(ECUENTA objCUENTA)
		{
			try
			{
                _objDAL.Delete(objCUENTA);
			    return true;
            }
            catch (Exception ex)
            {
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
            }
		}

        public bool Update(ECUENTA objCUENTA)
        {
            try
            {
                _objDAL.Update(objCUENTA);
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

