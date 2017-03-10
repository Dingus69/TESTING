
using System;
using System.Collections.Generic;
using SAGO.COMMON;
using SAGO.BUSINESS;
using SAGO.CLASES.DAL;
using SAGO.CLASES.DAO;


namespace SAGO.BUSINESS
{
	/// <summary>
	/// BFCENTROCOSTO.
	/// </summary>
	public class BFCENTROCOSTO
	{
		private DLCENTROCOSTO _objDAL;
		private DLCENTROCOSTOList _objDALList;
		
		public BFCENTROCOSTO()
		{
			_objDAL = new DLCENTROCOSTO();
			_objDALList = new DLCENTROCOSTOList();
		}

		public ECENTROCOSTO GetCENTROCOSTO()
		{
			return new ECENTROCOSTO();
		}

		public ECENTROCOSTO GetCENTROCOSTO(long id)
		{
            return new ECENTROCOSTO(id);
		}

		public bool Save(ECENTROCOSTO objCENTROCOSTO)
		{
			try
			{
				objCENTROCOSTO.Save();
				return true;
			}
			catch (Exception ex)
			{
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
			}
		}

		public List<ECENTROCOSTO> GetCENTROCOSTOAll()
		{
			return _objDALList.SelectAll();
		}

        public bool Delete(ECENTROCOSTO objCENTROCOSTO)
		{
			try
			{
                _objDAL.Delete(objCENTROCOSTO);
			    return true;
            }
            catch (Exception ex)
            {
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
            }
		}

        public bool Update(ECENTROCOSTO objCENTROCOSTO)
        {
            try
            {
                _objDAL.Update(objCENTROCOSTO);
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

