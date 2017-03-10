
using System;
using System.Collections.Generic;
using SAGO.COMMON;
using SAGO.BUSINESS;
using SAGO.CLASES.DAL;
using SAGO.CLASES.DAO;


namespace SAGO.BUSINESS
{
	/// <summary>
	/// BFTIPOMOVIMIENTOCONTABLE.
	/// </summary>
	public class BFTIPOMOVIMIENTOCONTABLE
	{
		private DLTIPOMOVIMIENTOCONTABLE _objDAL;
		private DLTIPOMOVIMIENTOCONTABLEList _objDALList;
		
		public BFTIPOMOVIMIENTOCONTABLE()
		{
			_objDAL = new DLTIPOMOVIMIENTOCONTABLE();
			_objDALList = new DLTIPOMOVIMIENTOCONTABLEList();
		}

		public ETIPOMOVIMIENTOCONTABLE GetTIPOMOVIMIENTOCONTABLE()
		{
			return new ETIPOMOVIMIENTOCONTABLE();
		}

		public ETIPOMOVIMIENTOCONTABLE GetTIPOMOVIMIENTOCONTABLE(long id)
		{
            return new ETIPOMOVIMIENTOCONTABLE(id);
		}

		public bool Save(ETIPOMOVIMIENTOCONTABLE objTIPOMOVIMIENTOCONTABLE)
		{
			try
			{
				objTIPOMOVIMIENTOCONTABLE.Save();
				return true;
			}
			catch (Exception ex)
			{
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
			}
		}

		public List<ETIPOMOVIMIENTOCONTABLE> GetTIPOMOVIMIENTOCONTABLEAll()
		{
			return _objDALList.SelectAll();
		}

        public bool Delete(ETIPOMOVIMIENTOCONTABLE objTIPOMOVIMIENTOCONTABLE)
		{
			try
			{
                _objDAL.Delete(objTIPOMOVIMIENTOCONTABLE);
			    return true;
            }
            catch (Exception ex)
            {
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
            }
		}

        public bool Update(ETIPOMOVIMIENTOCONTABLE objTIPOMOVIMIENTOCONTABLE)
        {
            try
            {
                _objDAL.Update(objTIPOMOVIMIENTOCONTABLE);
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

