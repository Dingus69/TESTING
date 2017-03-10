
using System;
using System.Collections.Generic;
using SAGO.COMMON;
using SAGO.BUSINESS;
using SAGO.CLASES.DAL;
using SAGO.CLASES.DAO;


namespace SAGO.BUSINESS
{
	/// <summary>
	/// BFTIPODOCTO.
	/// </summary>
	public class BFTIPODOCTO
	{
		private DLTIPODOCTO _objDAL;
		private DLTIPODOCTOList _objDALList;
		
		public BFTIPODOCTO()
		{
			_objDAL = new DLTIPODOCTO();
			_objDALList = new DLTIPODOCTOList();
		}

		public ETIPODOCTO GetTIPODOCTO()
		{
			return new ETIPODOCTO();
		}

		public ETIPODOCTO GetTIPODOCTO(long id)
		{
            return new ETIPODOCTO(id);
		}

		public bool Save(ETIPODOCTO objTIPODOCTO)
		{
			try
			{
				objTIPODOCTO.Save();
				return true;
			}
			catch (Exception ex)
			{
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
			}
		}

		public List<ETIPODOCTO> GetTIPODOCTOAll()
		{
			return _objDALList.SelectAll();
		}

        public bool Delete(ETIPODOCTO objTIPODOCTO)
		{
			try
			{
                _objDAL.Delete(objTIPODOCTO);
			    return true;
            }
            catch (Exception ex)
            {
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
            }
		}

        public bool Update(ETIPODOCTO objTIPODOCTO)
        {
            try
            {
                _objDAL.Update(objTIPODOCTO);
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

