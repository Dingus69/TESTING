using System;
using SAGO.CLASES.DAL;

namespace SAGO.CLASES.DAO
{
    public class ESESSIONUSUARIO : DomainObject
    {

        private System.Int64 _rut_usuario = 0;

        private System.String _nombres = String.Empty;

        private System.String _apellidos = String.Empty;

        private System.String _email = String.Empty;

        private System.String _clave_sence = String.Empty;

        private System.Boolean _EsAdministrador = false;

        private System.Boolean _EsGestion = false;

        private System.Boolean _EsJefe = false;

        private System.Boolean _CambioClave = false;

        private System.String _Clave = String.Empty;

        

        public ESESSIONUSUARIO()
            : base()
        {
        }

        public ESESSIONUSUARIO(long id)
            : base(id)
        {
        }

        #region Properties

        public System.Int64 RutUsuario
        {
            get { return _rut_usuario; }
            set { _rut_usuario = value; }
        }

        public System.String Nombres
        {
            get { return _nombres; }
            set { _nombres = value; }
        }

        public System.String Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }

        public System.String Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public System.String ClaveSence
        {
            get { return _clave_sence; }
            set { _clave_sence = value; }
        }

        public System.String Clave
        {
            get { return _Clave; }
            set { _Clave = value; }
        }

        public System.Boolean EsAdministrador
        {
            get { return _EsAdministrador; }
            set { _EsAdministrador = value; }
        }

        public System.Boolean EsGestion
        {
            get { return _EsGestion; }
            set { _EsGestion = value; }
        }

        public System.Boolean EsJefe
        {
            get { return _EsJefe; }
            set { _EsJefe = value; }
        }
        public System.Boolean CambioClave
        {
            get { return _CambioClave; }
            set { _CambioClave = value; }
        }
        #endregion

        #region Methods

        protected override DLBase GetMapper()
        {
            return new DLSESSIONUSUARIO();
        }

        #endregion

    }
}
