using System;
using System.Collections.Generic;
using SAGO.COMMON;
using SAGO.BUSINESS;
using SAGO.CLASES.DAL;
using SAGO.CLASES.DAO;

namespace SAGO.BUSINESS
{
    public class BFSESSIONUSUARIO
    {
        private DLSESSIONUSUARIO _objDAL;

        public BFSESSIONUSUARIO()
        {
            _objDAL = new DLSESSIONUSUARIO();
        }

        public ESESSIONUSUARIO GetSESSIONUSUARIO()
        {
            return new ESESSIONUSUARIO();
        }

        public ESESSIONUSUARIO GetSESSIONUSUARIO(long id)
        {
            return new ESESSIONUSUARIO(id);
        }

        public ESESSIONUSUARIO GetSESSIONUSUARIO(long Rut, String Passwd)
        {
            ESESSIONUSUARIO objUSUARIO = _objDAL.SelectSessionUsuario(Rut, Passwd);

            return objUSUARIO;
        }

        public ESESSIONUSUARIO GetSESSIONUSUARIONONSECURE(long Rut)
        {
            ESESSIONUSUARIO objUSUARIO = _objDAL.SelectSessionUsuarioNonSecure(Rut);

            return objUSUARIO;
        }
        
    }
}

