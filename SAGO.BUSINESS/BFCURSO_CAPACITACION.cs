
using System;
using System.Collections.Generic;
using SAGO.COMMON;
using SAGO.BUSINESS;
using SAGO.CLASES.DAL;
using SAGO.CLASES.DAO;


namespace SAGO.BUSINESS
{
	/// <summary>
	/// BFCURSOCAPACITACION.
	/// </summary>
	public class BFCURSOCAPACITACION
	{
		private DLCURSOCAPACITACION _objDAL;
		private DLCURSOCAPACITACIONList _objDALList;
		
		public BFCURSOCAPACITACION()
		{
			_objDAL = new DLCURSOCAPACITACION();
			_objDALList = new DLCURSOCAPACITACIONList();
		}

		public ECURSOCAPACITACION GetCURSOCAPACITACION()
		{
			return new ECURSOCAPACITACION();
		}

		public ECURSOCAPACITACION GetCURSOCAPACITACION(long id)
		{
            return new ECURSOCAPACITACION(id);
		}

		public bool Save(ECURSOCAPACITACION objCURSOCAPACITACION)
		{
			try
			{
				objCURSOCAPACITACION.Save();
				return true;
			}
			catch (Exception ex)
			{
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
			}
		}

		public List<ECURSOCAPACITACION> GetCURSOCAPACITACIONAll()
		{
			return _objDALList.SelectAll();
		}

        public bool Delete(ECURSOCAPACITACION objCURSOCAPACITACION)
		{
			try
			{
                _objDAL.Delete(objCURSOCAPACITACION);
			    return true;
            }
            catch (Exception ex)
            {
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
            }
		}

        public bool Update(ECURSOCAPACITACION objCURSOCAPACITACION)
        {
            try
            {
                _objDAL.Update(objCURSOCAPACITACION);
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

