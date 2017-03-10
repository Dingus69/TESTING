
using System;
using System.Collections.Generic;
using SAGO.COMMON;
using SAGO.BUSINESS;
using SAGO.CLASES.DAL;
using SAGO.CLASES.DAO;


namespace SAGO.BUSINESS
{
	/// <summary>
	/// BFESTADOAPORTECLIENTE.
	/// </summary>
	public class BFESTADOAPORTECLIENTE
	{
		private DLESTADOAPORTECLIENTE _objDAL;
		private DLESTADOAPORTECLIENTEList _objDALList;
		
		public BFESTADOAPORTECLIENTE()
		{
			_objDAL = new DLESTADOAPORTECLIENTE();
			_objDALList = new DLESTADOAPORTECLIENTEList();
		}

		public EESTADOAPORTECLIENTE GetESTADOAPORTECLIENTE()
		{
			return new EESTADOAPORTECLIENTE();
		}

		public EESTADOAPORTECLIENTE GetESTADOAPORTECLIENTE(long id)
		{
            return new EESTADOAPORTECLIENTE(id);
		}

		public bool Save(EESTADOAPORTECLIENTE objESTADOAPORTECLIENTE)
		{
			try
			{
				objESTADOAPORTECLIENTE.Save();
				return true;
			}
			catch (Exception ex)
			{
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
			}
		}

		public List<EESTADOAPORTECLIENTE> GetESTADOAPORTECLIENTEAll()
		{
			return _objDALList.SelectAll();
		}

        public bool Delete(EESTADOAPORTECLIENTE objESTADOAPORTECLIENTE)
		{
			try
			{
                _objDAL.Delete(objESTADOAPORTECLIENTE);
			    return true;
            }
            catch (Exception ex)
            {
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
            }
		}

        public bool Update(EESTADOAPORTECLIENTE objESTADOAPORTECLIENTE)
        {
            try
            {
                _objDAL.Update(objESTADOAPORTECLIENTE);
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

