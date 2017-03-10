
using System;
using System.Collections.Generic;
using SAGO.COMMON;
using SAGO.BUSINESS;
using SAGO.CLASES.DAL;
using SAGO.CLASES.DAO;


namespace SAGO.BUSINESS
{
	/// <summary>
	/// BFTIPOCONTRATO.
	/// </summary>
	public class BFTIPOCONTRATO
	{
		private DLTIPOCONTRATO _objDAL;
		private DLTIPOCONTRATOList _objDALList;
		
		public BFTIPOCONTRATO()
		{
			_objDAL = new DLTIPOCONTRATO();
			_objDALList = new DLTIPOCONTRATOList();
		}

		public ETIPOCONTRATO GetTIPOCONTRATO()
		{
			return new ETIPOCONTRATO();
		}

		public ETIPOCONTRATO GetTIPOCONTRATO(long id)
		{
            return new ETIPOCONTRATO(id);
		}

		public bool Save(ETIPOCONTRATO objTIPOCONTRATO)
		{
			try
			{
				objTIPOCONTRATO.Save();
				return true;
			}
			catch (Exception ex)
			{
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
			}
		}

		public List<ETIPOCONTRATO> GetTIPOCONTRATOAll()
		{
			return _objDALList.SelectAll();
		}

        public bool Delete(ETIPOCONTRATO objTIPOCONTRATO)
		{
			try
			{
                _objDAL.Delete(objTIPOCONTRATO);
			    return true;
            }
            catch (Exception ex)
            {
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
            }
		}

        public bool Update(ETIPOCONTRATO objTIPOCONTRATO)
        {
            try
            {
                _objDAL.Update(objTIPOCONTRATO);
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

