
using System;
using System.Collections.Generic;
using SAGO.COMMON;
using SAGO.BUSINESS;
using SAGO.CLASES.DAL;
using SAGO.CLASES.DAO;


namespace SAGO.BUSINESS
{
	/// <summary>
	/// BFAPORTECLIENTE.
	/// </summary>
	public class BFAPORTECLIENTE
	{
		private DLAPORTECLIENTE _objDAL;
		private DLAPORTECLIENTEList _objDALList;
		
		public BFAPORTECLIENTE()
		{
			_objDAL = new DLAPORTECLIENTE();
			_objDALList = new DLAPORTECLIENTEList();
		}

		public EAPORTECLIENTE GetAPORTECLIENTE()
		{
			return new EAPORTECLIENTE();
		}

		public EAPORTECLIENTE GetAPORTECLIENTE(long id)
		{
            return new EAPORTECLIENTE(id);
		}

		public bool Save(EAPORTECLIENTE objAPORTECLIENTE)
		{
			try
			{
				objAPORTECLIENTE.Save();
				return true;
			}
			catch (Exception ex)
			{
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
			}
		}

		public List<EAPORTECLIENTE> GetAPORTECLIENTEAll()
		{
			return _objDALList.SelectAll();
		}

        public bool Delete(EAPORTECLIENTE objAPORTECLIENTE)
		{
			try
			{
                _objDAL.Delete(objAPORTECLIENTE);
			    return true;
            }
            catch (Exception ex)
            {
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
            }
		}

        public bool Update(EAPORTECLIENTE objAPORTECLIENTE)
        {
            try
            {
                _objDAL.Update(objAPORTECLIENTE);
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

