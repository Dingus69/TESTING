
using System;
using System.Collections.Generic;
using SAGO.COMMON;
using SAGO.BUSINESS;
using SAGO.CLASES.DAL;
using SAGO.CLASES.DAO;


namespace SAGO.BUSINESS
{
	/// <summary>
	/// BFESTADOMOVIMEINTOCONTABLE.
	/// </summary>
	public class BFESTADOMOVIMEINTOCONTABLE
	{
		private DLESTADOMOVIMEINTOCONTABLE _objDAL;
		private DLESTADOMOVIMEINTOCONTABLEList _objDALList;
		
		public BFESTADOMOVIMEINTOCONTABLE()
		{
			_objDAL = new DLESTADOMOVIMEINTOCONTABLE();
			_objDALList = new DLESTADOMOVIMEINTOCONTABLEList();
		}

		public EESTADOMOVIMEINTOCONTABLE GetESTADOMOVIMEINTOCONTABLE()
		{
			return new EESTADOMOVIMEINTOCONTABLE();
		}

		public EESTADOMOVIMEINTOCONTABLE GetESTADOMOVIMEINTOCONTABLE(long id)
		{
            return new EESTADOMOVIMEINTOCONTABLE(id);
		}

		public bool Save(EESTADOMOVIMEINTOCONTABLE objESTADOMOVIMEINTOCONTABLE)
		{
			try
			{
				objESTADOMOVIMEINTOCONTABLE.Save();
				return true;
			}
			catch (Exception ex)
			{
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
			}
		}

		public List<EESTADOMOVIMEINTOCONTABLE> GetESTADOMOVIMEINTOCONTABLEAll()
		{
			return _objDALList.SelectAll();
		}

        public bool Delete(EESTADOMOVIMEINTOCONTABLE objESTADOMOVIMEINTOCONTABLE)
		{
			try
			{
                _objDAL.Delete(objESTADOMOVIMEINTOCONTABLE);
			    return true;
            }
            catch (Exception ex)
            {
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
            }
		}

        public bool Update(EESTADOMOVIMEINTOCONTABLE objESTADOMOVIMEINTOCONTABLE)
        {
            try
            {
                _objDAL.Update(objESTADOMOVIMEINTOCONTABLE);
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

