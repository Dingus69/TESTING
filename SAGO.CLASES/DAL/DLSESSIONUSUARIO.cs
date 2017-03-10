﻿using System;
using System.Data;
using SAGO.CLASES.DAO;
using SAGO.COMMON;
using SAGO.DATAACCESS;

namespace SAGO.CLASES.DAL
{
    public class DLSESSIONUSUARIO : DLBase
    {

        public DLSESSIONUSUARIO()
        {
        }

        #region Protected Methods

        protected override string GetSelectProcedure()
        {
            return "proc_select_session_usuario";
        }

        protected override IDbDataParameter[] GetSelectParameters(long id, DB db)
        {
            IDbDataParameter[] prms = db.GetArrayParameter(2);

            prms[0] = db.GetParameter();
            prms[0].Value = id;
            prms[0].ParameterName = "@rut_usuario";

            prms[1] = db.GetParameter();
            prms[1].Value = id;
            prms[1].ParameterName = "@passwd_enc";

            return prms;
        }

        protected override void SetPrimaryKey(DomainObject obj, long id)
        {
            ESESSIONUSUARIO objRoot = obj as ESESSIONUSUARIO;

            objRoot.RutUsuario = id;
        }

        #endregion

        #region Public Methods

        public override void Fill(DomainObject obj, IDataReader dr)
        {
            ESESSIONUSUARIO objUSUARIO = obj as ESESSIONUSUARIO;

            //Poner las rutinas del Tools que se necesiten

            objUSUARIO.RutUsuario = Utiles.ConvertToInt64(dr["rut_usuario"]);

            objUSUARIO.Nombres = Utiles.ConvertToString(dr["nombre"]);

            objUSUARIO.Apellidos = Utiles.ConvertToString(dr["apellidos"]);

            objUSUARIO.Email = Utiles.ConvertToString(dr["email"]);

            //objUSUARIO.ClaveSence = Utiles.ConvertToString(dr["clave_sence"]);

            objUSUARIO.EsAdministrador = Utiles.ConvertToBoolean(dr["es_administrador"]);

            objUSUARIO.EsGestion = Utiles.ConvertToBoolean(dr["es_gestion"]);

            objUSUARIO.EsJefe = Utiles.ConvertToBoolean(dr["es_jefe"]);

            objUSUARIO.Clave = Utiles.ConvertToString(dr["clave"]);

            objUSUARIO.CambioClave = Utiles.ConvertToBoolean(dr["cambio_clave"]);

        }

        public ESESSIONUSUARIO SelectSessionUsuario(long Rut, string Passwd)
        {

            DB db = DatabaseFactory.Instance.GetDatabase();
            IDbDataParameter[] prms = db.GetArrayParameter(2);

            prms[0] = db.GetParameter();
            prms[0].Value = Rut;
            prms[0].ParameterName = "@RutUsuario";

            prms[1] = db.GetParameter();
            prms[1].Value = CCryptografia.Encriptar(Passwd);
            prms[1].ParameterName = "@Clave";

            IDataReader dr = db.ExecuteReader(CommandType.StoredProcedure, "proc_SELECT_SESSION_USUARIO_SEDD", prms);
            ESESSIONUSUARIO objSessionUsuario = new ESESSIONUSUARIO();
            if ((dr != null) && dr.Read())
            {
                this.Fill(objSessionUsuario, dr);
                objSessionUsuario.IsPersisted = true;
            }
            dr.Close();
            return objSessionUsuario;
        }

        public ESESSIONUSUARIO SelectSessionUsuarioNonSecure(long Rut)
        {

            DB db = DatabaseFactory.Instance.GetDatabase();
            IDbDataParameter[] prms = db.GetArrayParameter(1);

            prms[0] = db.GetParameter();
            prms[0].Value = Rut;
            prms[0].ParameterName = "@RutUsuario";

            IDataReader dr = db.ExecuteReader(CommandType.StoredProcedure, "proc_SELECT_SESSION_USUARIO_SEDD_NON_SECURE", prms);
            ESESSIONUSUARIO objSessionUsuario = new ESESSIONUSUARIO();
            if ((dr != null) && dr.Read())
            {
                this.Fill(objSessionUsuario, dr);
                objSessionUsuario.IsPersisted = true;
            }
            dr.Close();
            return objSessionUsuario;
        }


        #endregion
    }
}
