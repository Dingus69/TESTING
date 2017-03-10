
using System;
using System.Collections.Generic;
using SAGO.COMMON;
using SAGO.BUSINESS;
using SAGO.CLASES.DAL;
using SAGO.CLASES.DAO;


namespace SAGO.BUSINESS
{
	/// <summary>
	/// BFCLIENTE.
	/// </summary>
	public class BFCLIENTE
	{
		private DLCLIENTE _objDAL;
		private DLCLIENTEList _objDALList;
		
		public BFCLIENTE()
		{
			_objDAL = new DLCLIENTE();
			_objDALList = new DLCLIENTEList();
		}

		public ECLIENTE GetCLIENTE()
		{
			return new ECLIENTE();
		}

		public ECLIENTE GetCLIENTE(long id)
		{
            return new ECLIENTE(id);
		}

		public bool Save(ECLIENTE objCLIENTE)
		{
			try
			{
				objCLIENTE.Save();
				return true;
			}
			catch (Exception ex)
			{
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
			}
		}

		public List<ECLIENTE> GetCLIENTEAll()
		{
			return _objDALList.SelectAll();
		}

        public bool Delete(ECLIENTE objCLIENTE)
		{
			try
			{
                _objDAL.Delete(objCLIENTE);
			    return true;
            }
            catch (Exception ex)
            {
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
            }
		}

        public bool Update(ECLIENTE objCLIENTE)
        {
            try
            {
                _objDAL.Update(objCLIENTE);
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

