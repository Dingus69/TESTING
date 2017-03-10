
using System;
using System.Collections.Generic;
using SAGO.COMMON;
using SAGO.BUSINESS;
using SAGO.CLASES.DAL;
using SAGO.CLASES.DAO;


namespace SAGO.BUSINESS
{
	/// <summary>
	/// BFHORARIO.
	/// </summary>
	public class BFHORARIO
	{
		private DLHORARIO _objDAL;
		private DLHORARIOList _objDALList;
		
		public BFHORARIO()
		{
			_objDAL = new DLHORARIO();
			_objDALList = new DLHORARIOList();
		}

		public EHORARIO GetHORARIO()
		{
			return new EHORARIO();
		}

		public EHORARIO GetHORARIO(long id)
		{
            return new EHORARIO(id);
		}

		public bool Save(EHORARIO objHORARIO)
		{
			try
			{
				objHORARIO.Save();
				return true;
			}
			catch (Exception ex)
			{
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
			}
		}

		public List<EHORARIO> GetHORARIOAll()
		{
			return _objDALList.SelectAll();
		}

        public bool Delete(EHORARIO objHORARIO)
		{
			try
			{
                _objDAL.Delete(objHORARIO);
			    return true;
            }
            catch (Exception ex)
            {
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
            }
		}

        public bool Update(EHORARIO objHORARIO)
        {
            try
            {
                _objDAL.Update(objHORARIO);
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

