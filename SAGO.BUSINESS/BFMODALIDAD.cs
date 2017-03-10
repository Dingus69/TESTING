
using System;
using System.Collections.Generic;
using SAGO.COMMON;
using SAGO.BUSINESS;
using SAGO.CLASES.DAL;
using SAGO.CLASES.DAO;


namespace SAGO.BUSINESS
{
	/// <summary>
	/// BFMODALIDAD.
	/// </summary>
	public class BFMODALIDAD
	{
		private DLMODALIDAD _objDAL;
		private DLMODALIDADList _objDALList;
		
		public BFMODALIDAD()
		{
			_objDAL = new DLMODALIDAD();
			_objDALList = new DLMODALIDADList();
		}

		public EMODALIDAD GetMODALIDAD()
		{
			return new EMODALIDAD();
		}

		public EMODALIDAD GetMODALIDAD(long id)
		{
            return new EMODALIDAD(id);
		}

		public bool Save(EMODALIDAD objMODALIDAD)
		{
			try
			{
				objMODALIDAD.Save();
				return true;
			}
			catch (Exception ex)
			{
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
			}
		}

		public List<EMODALIDAD> GetMODALIDADAll()
		{
			return _objDALList.SelectAll();
		}

        public bool Delete(EMODALIDAD objMODALIDAD)
		{
			try
			{
                _objDAL.Delete(objMODALIDAD);
			    return true;
            }
            catch (Exception ex)
            {
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
            }
		}

        public bool Update(EMODALIDAD objMODALIDAD)
        {
            try
            {
                _objDAL.Update(objMODALIDAD);
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

