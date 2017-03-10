
using System;
using System.Collections.Generic;
using SAGO.COMMON;
using SAGO.BUSINESS;
using SAGO.CLASES.DAL;
using SAGO.CLASES.DAO;


namespace SAGO.BUSINESS
{
	/// <summary>
	/// BFESTADOCURSO.
	/// </summary>
	public class BFESTADOCURSO
	{
		private DLESTADOCURSO _objDAL;
		private DLESTADOCURSOList _objDALList;
		
		public BFESTADOCURSO()
		{
			_objDAL = new DLESTADOCURSO();
			_objDALList = new DLESTADOCURSOList();
		}

		public EESTADOCURSO GetESTADOCURSO()
		{
			return new EESTADOCURSO();
		}

		public EESTADOCURSO GetESTADOCURSO(long id)
		{
            return new EESTADOCURSO(id);
		}

		public bool Save(EESTADOCURSO objESTADOCURSO)
		{
			try
			{
				objESTADOCURSO.Save();
				return true;
			}
			catch (Exception ex)
			{
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
			}
		}

		public List<EESTADOCURSO> GetESTADOCURSOAll()
		{
			return _objDALList.SelectAll();
		}

        public bool Delete(EESTADOCURSO objESTADOCURSO)
		{
			try
			{
                _objDAL.Delete(objESTADOCURSO);
			    return true;
            }
            catch (Exception ex)
            {
                Log objLog = new Log();
                objLog.EscribirLog(ex);
                return false;
            }
		}

        public bool Update(EESTADOCURSO objESTADOCURSO)
        {
            try
            {
                _objDAL.Update(objESTADOCURSO);
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

