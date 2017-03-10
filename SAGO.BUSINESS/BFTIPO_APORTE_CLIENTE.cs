
using System;
using System.Collections.Generic;
using SAGO.COMMON;
using SAGO.BUSINESS;
using SAGO.CLASES.DAL;
using SAGO.CLASES.DAO;


namespace SAGO.BUSINESS
{
	/// <summary>
	/// BFTIPOAPORTECLIENTE.
	/// </summary>
	public class BFTIPOAPORTECLIENTE
	{
		private DLTIPOAPORTECLIENTE _objDAL;
		private DLTIPOAPORTECLIENTEList _objDALList;
		
		public BFTIPOAPORTECLIENTE()
		{
			_objDAL = new DLTIPOAPORTECLIENTE();
			_objDALList = new DLTIPOAPORTECLIENTEList();
		}

		public ETIPOAPORTECLIENTE GetTIPOAPORTECLIENTE()
		{
			return new ETIPOAPORTECLIENTE();
		}

		public ETIPOAPORTECLIENTE GetTIPOAPORTECLIENTE(long id)
		{
            return new ETIPOAPORTECLIENTE(id);
		}

		public bool Save(ETIPOAPORTECLIENTE objTIPOAPORTECLIENTE)
		{
			try
			{
				objTIPOAPORTECLIENTE.Save();
				return true;
			}
			catch (Exception ex)
			{
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
			}
		}

		public List<ETIPOAPORTECLIENTE> GetTIPOAPORTECLIENTEAll()
		{
			return _objDALList.SelectAll();
		}

        public bool Delete(ETIPOAPORTECLIENTE objTIPOAPORTECLIENTE)
		{
			try
			{
                _objDAL.Delete(objTIPOAPORTECLIENTE);
			    return true;
            }
            catch (Exception ex)
            {
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
            }
		}

        public bool Update(ETIPOAPORTECLIENTE objTIPOAPORTECLIENTE)
        {
            try
            {
                _objDAL.Update(objTIPOAPORTECLIENTE);
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

