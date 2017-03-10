
using System;
using System.Collections.Generic;
using SAGO.COMMON;
using SAGO.BUSINESS;
using SAGO.CLASES.DAL;
using SAGO.CLASES.DAO;


namespace SAGO.BUSINESS
{
	/// <summary>
	/// BFALUMNO.
	/// </summary>
	public class BFALUMNO
	{
		private DLALUMNO _objDAL;
		private DLALUMNOList _objDALList;
		
		public BFALUMNO()
		{
			_objDAL = new DLALUMNO();
			_objDALList = new DLALUMNOList();
		}

		public EALUMNO GetALUMNO()
		{
			return new EALUMNO();
		}

		public EALUMNO GetALUMNO(long id)
		{
            return new EALUMNO(id);
		}

		public bool Save(EALUMNO objALUMNO)
		{
			try
			{
				objALUMNO.Save();
				return true;
			}
			catch (Exception ex)
			{
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
			}
		}

		public List<EALUMNO> GetALUMNOAll()
		{
			return _objDALList.SelectAll();
		}

        public bool Delete(EALUMNO objALUMNO)
		{
			try
			{
                _objDAL.Delete(objALUMNO);
			    return true;
            }
            catch (Exception ex)
            {
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
            }
		}

        public bool Update(EALUMNO objALUMNO)
        {
            try
            {
                _objDAL.Update(objALUMNO);
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

