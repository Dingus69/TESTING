
using System;
using System.Collections.Generic;
using SAGO.COMMON;
using SAGO.BUSINESS;
using SAGO.CLASES.DAL;
using SAGO.CLASES.DAO;


namespace SAGO.BUSINESS
{
	/// <summary>
	/// BFEMPLEADO.
	/// </summary>
	public class BFEMPLEADO
	{
		private DLEMPLEADO _objDAL;
		private DLEMPLEADOList _objDALList;
		
		public BFEMPLEADO()
		{
			_objDAL = new DLEMPLEADO();
			_objDALList = new DLEMPLEADOList();
		}

		public EEMPLEADO GetEMPLEADO()
		{
			return new EEMPLEADO();
		}

		public EEMPLEADO GetEMPLEADO(long id)
		{
            return new EEMPLEADO(id);
		}

		public bool Save(EEMPLEADO objEMPLEADO)
		{
			try
			{
				objEMPLEADO.Save();
				return true;
			}
			catch (Exception ex)
			{
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
			}
		}

		public List<EEMPLEADO> GetEMPLEADOAll()
		{
			return _objDALList.SelectAll();
		}

        public bool Delete(EEMPLEADO objEMPLEADO)
		{
			try
			{
                _objDAL.Delete(objEMPLEADO);
			    return true;
            }
            catch (Exception ex)
            {
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
            }
		}

        public bool Update(EEMPLEADO objEMPLEADO)
        {
            try
            {
                _objDAL.Update(objEMPLEADO);
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

