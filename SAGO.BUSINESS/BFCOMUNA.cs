
using System;
using System.Collections.Generic;
using SAGO.COMMON;
using SAGO.BUSINESS;
using SAGO.CLASES.DAL;
using SAGO.CLASES.DAO;


namespace SAGO.BUSINESS
{
	/// <summary>
	/// BFCOMUNA.
	/// </summary>
	public class BFCOMUNA
	{
		private DLCOMUNA _objDAL;
		private DLCOMUNAList _objDALList;
		
		public BFCOMUNA()
		{
			_objDAL = new DLCOMUNA();
			_objDALList = new DLCOMUNAList();
		}

		public ECOMUNA GetCOMUNA()
		{
			return new ECOMUNA();
		}

		public ECOMUNA GetCOMUNA(long id)
		{
            return new ECOMUNA(id);
		}

		public bool Save(ECOMUNA objCOMUNA)
		{
			try
			{
				objCOMUNA.Save();
				return true;
			}
			catch (Exception ex)
			{
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
			}
		}

		public List<ECOMUNA> GetCOMUNAAll()
		{
			return _objDALList.SelectAll();
		}

        public bool Delete(ECOMUNA objCOMUNA)
		{
			try
			{
                _objDAL.Delete(objCOMUNA);
			    return true;
            }
            catch (Exception ex)
            {
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
            }
		}

        public bool Update(ECOMUNA objCOMUNA)
        {
            try
            {
                _objDAL.Update(objCOMUNA);
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

