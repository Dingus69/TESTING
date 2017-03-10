using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using SAGO.CLASES.DAO;
using SAGO.COMMON;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Web.SessionState;
using SAGO.BUSINESS;
using System.IO;
using System.Text;
using System.Drawing;
namespace SAGO.WEB
{
    public class UtilesWEB
    {
        public Boolean CheckeaSessionUsuario()
        {
            ESESSIONUSUARIO objSesion = new ESESSIONUSUARIO();
            objSesion = CargaSessionUsuario();
            if (objSesion != null)
            {
                if (objSesion.RutUsuario == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        public ESESSIONUSUARIO CargaSessionUsuario()
        {
            ESESSIONUSUARIO objSesion = new ESESSIONUSUARIO();
            Page pagina = new Page();
            objSesion = (ESESSIONUSUARIO)pagina.Session["SessionUsuario"];
            return objSesion;
        }
        public void LlenaGrilladt(ref GridView grdObjeto, DataTable dt, Int16 NumPaginacion)
        {
            grdObjeto.AllowPaging = true;
            grdObjeto.EmptyDataText = "";
            grdObjeto.PagerSettings.Position = PagerPosition.Bottom;
            grdObjeto.PagerSettings.Mode = PagerButtons.NumericFirstLast;
            grdObjeto.PageSize = NumPaginacion;
            grdObjeto.PagerStyle.CssClass = "GridPager";

            grdObjeto.DataSource = null;
            grdObjeto.DataSource = dt;
            grdObjeto.DataBind();
        }
        public void seteaGrilla(ref GridView grd, Int16 NumPaginacion)
        {
            grd.AllowPaging = true;
            grd.PagerSettings.Position = PagerPosition.Bottom;
            grd.PagerSettings.Mode = PagerButtons.NumericFirstLast;
            grd.PageSize = NumPaginacion;
            grd.PagerStyle.CssClass = "GridPager";


            for (int x = 0; x <= grd.Columns.Count - 1; x++)
            {
                grd.Columns[x].ItemStyle.HorizontalAlign = HorizontalAlign.Left;
            }

            //Attribute to show the Plus Minus Button.
            if (grd.Rows.Count > 0)
            {
                grd.HeaderRow.Cells[0].Attributes["data-class"] = "expand";
                grd.HeaderRow.Cells[0].Attributes["data-toggle"] = "true";
                int count = grd.HeaderRow.Cells.Count - 1;
                for (int i = 2; i <= count; i++)
                {
                    //Attribute to hide column in Phone.
                    grd.HeaderRow.Cells[i].Attributes["data-hide"] = "phone,tablet";
                }
                //Adds THEAD and TBODY to GridView.
                grd.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
        }
        /// <summary>
        /// Recibe una lista de objetos para poblar la grilla
        /// </summary>
        /// <param name="grd">Nombre de la grilla</param>
        /// <param name="objList">objeto casteado: ListaObjeto.Cast<DomainObject>().ToList();</param>
        public void LlenaGrilla(ref GridView grd, List<DomainObject> objList, Int16 NumPaginacion)
        {

            grd.AllowPaging = true;
            grd.EmptyDataText = "";
            grd.PagerSettings.Position = PagerPosition.Bottom;
            grd.PagerSettings.Mode = PagerButtons.NumericFirstLast;
            grd.PageSize = NumPaginacion;
            grd.PagerStyle.CssClass = "GridPager";


            // seteaGrilla(ref grd, NumPaginacion);
            grd.DataSource = objList;
            grd.DataBind();
        }
        public void LlenaListBox(ref ListBox lst, List<DomainObject> objList, string Valor, string Texto)
        {
            lst.DataValueField = Valor;
            lst.DataTextField = Texto;
            lst.DataSource = objList;
            lst.DataBind();
        }
        public void LlenaDDL(ref DropDownList ddl, List<DomainObject> objList, string Valor, string Texto)
        {
            ddl.DataValueField = Valor;
            ddl.DataTextField = Texto;
            ddl.DataSource = objList;
            ddl.DataBind();
        }
        public void LlenaDDL(ref DropDownList ddl, DataTable dt, string Valor, string Texto)
        {
            ddl.DataValueField = Valor;
            ddl.DataTextField = Texto;
            ddl.DataSource = dt;
            ddl.DataBind();
        }
        public static double FormatoPesoADouble(string Monto)
        {
            return double.Parse(Monto, NumberStyles.Currency);
        }
        public static long FormatoPesoALong(string Monto)
        {
            return long.Parse(Monto, NumberStyles.Currency);
        }
        public static string FormatoPeso(double Monto)
        {
            return "$" + Monto.ToString("#,##0");
        }
        public static void BindDropDownList(DropDownList combo, ItemCollection collection)
        {
            BindListControl(combo, collection);
        }
        public static void SetSelectedDropDownList(DropDownList combo, string selectedValue)
        {
            SetSelectedListControl(combo, selectedValue);
        }
        public static void BindListBox(ListBox listBox, ItemCollection collection)
        {
            BindListControl(listBox, collection);
        }
        public static void SetSelectedListBox(ListBox listBox, string selectedValue)
        {
            SetSelectedListControl(listBox, selectedValue);
        }
        private static void BindListControl(ListControl listControl, ItemCollection collection)
        {
            listControl.DataSource = collection;
            listControl.DataTextField = "Text";
            listControl.DataValueField = "Value";
            listControl.DataBind();
        }
        private static void SetSelectedListControl(ListControl listControl, string selectedValue)
        {
            ListItem item = listControl.Items.FindByValue(selectedValue);
            if (item != null)
            {
                listControl.SelectedIndex = -1;
                item.Selected = true;
            }
        }
        public void AgregaValorLST(ref ListBox lstList, string strTexto, string strValue)
        {
            ListItem lit = new ListItem();
            lit.Text = strTexto;
            lit.Value = strValue;
            lstList.Items.Add(lit);
        }
        public void AgregaValorDDL(ref DropDownList ddl, string strTexto, string strValue)
        {
            ListItem lit = new ListItem();
            lit.Text = strTexto;
            lit.Value = strValue;
            ddl.Items.Add(lit);
        }
        public void EliminaValorLST(ref ListBox lstList, string strTexto, string strValue)
        {
            ListItem lit = new ListItem();
            lit.Text = strTexto;
            lit.Value = strValue;
            lstList.Items.Remove(lit);
        }
        public void CargaLst(ref ListBox lbxInicio, ref ListBox lbxLlegadaados)
        {
            string strCod = null;
            string strText = null;
            if (!string.IsNullOrEmpty(lbxInicio.SelectedValue))
            {
                strCod = lbxInicio.SelectedValue;
                strText = lbxInicio.SelectedItem.ToString();
                if (!string.IsNullOrEmpty(lbxInicio.SelectedValue))
                {
                    AgregaValorLST(ref lbxLlegadaados, strText, strCod);
                }
                EliminaValorLST(ref lbxInicio, strText, strCod);
            }
            else
            {
                return;
            }
        }
        public void CargaLstcompleta(ref ListBox lbxInicio, ref ListBox lbxLlegadaAdos)
        {
            string strCod = null;
            string strText = null;
            int i = 0;
            int j = 0;
            if (lbxInicio.Items.Count > 0)
            {
                j = lbxInicio.Items.Count - 1;
                i = 0;
                while (i <= j)
                {
                    lbxInicio.SelectedIndex = i;
                    if (!string.IsNullOrEmpty(lbxInicio.SelectedValue))
                    {
                        strCod = lbxInicio.SelectedValue;
                        strText = lbxInicio.SelectedItem.ToString();
                        if (!string.IsNullOrEmpty(lbxInicio.SelectedValue))
                        {
                            AgregaValorLST(ref lbxLlegadaAdos, strText, strCod);
                        }
                        EliminaValorLST(ref lbxInicio, strText, strCod);
                        j = j - 1;
                    }
                }
            }
        }
        public string GetFormatRUT(object objValue)
        {

            long rut = Utiles.ConvertToInt64(objValue);

            if (rut > 0)
                return Utiles.RutLngAUsr(rut);
            return "0";
        }
        public DataTable Agnos()
        {
            DataTable obj = new DataTable();
            obj.Columns.Add("texto");
            obj.Columns.Add("valor");
            DataRow item;
            item = obj.NewRow();
            item["texto"] = Utiles.ConvertToString(DateTime.Now.Year);
            item["valor"] = Utiles.ConvertToString(DateTime.Now.Year);
            obj.Rows.Add(item);
            item = obj.NewRow();
            item["texto"] = Utiles.ConvertToString(DateTime.Now.Year + 1);
            item["valor"] = Utiles.ConvertToString(DateTime.Now.Year + 1);
            obj.Rows.Add(item);
            item = obj.NewRow();
            item["texto"] = Utiles.ConvertToString(DateTime.Now.Year + 2);
            item["valor"] = Utiles.ConvertToString(DateTime.Now.Year + 2);
            obj.Rows.Add(item);

            return obj;
        }

        public DataTable Sexo()
        {
            DataTable obj = new DataTable();
            obj.Columns.Add("texto");
            obj.Columns.Add("valor");
            DataRow item;
            item = obj.NewRow();
            item["texto"] = "M";
            item["valor"] = "MASCULINO";
            obj.Rows.Add(item);
            item = obj.NewRow();
            item["texto"] = "F";
            item["valor"] = "FEMENINO";
            obj.Rows.Add(item);

            return obj;
        }

        public Boolean ValidaFecha(string strFecha)
        {
            if (Regex.IsMatch(strFecha, "(((0|1)[1-9]|2[1-9]|3[0-1])\\/(0[1-9]|1[1-2])\\/((19|20)\\d\\d))$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean ValidaHora(string strHora)
        {
            if (Regex.IsMatch(strHora, "^([0-9]|0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean ValidaEmail(string strEmail)
        {
            if (Regex.IsMatch(strEmail, "^[_a-z0-9-]+(.[_a-z0-9-]+)*@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DTToExcel(DataTable dt, string NombreArchivo)
        {
            string attachment = "attachment; filename=" + NombreArchivo;
            HttpContext.Current.Response.ClearContent();
            HttpContext.Current.Response.AddHeader("content-disposition", attachment);
            HttpContext.Current.Response.ContentType = "application/vnd.ms-excel";
            HttpContext.Current.Response.Charset = "utf-8";
            HttpContext.Current.Response.ContentEncoding = System.Text.Encoding.GetEncoding("windows-1250");
            string tab = "";
            foreach (DataColumn dc in dt.Columns)
            {
                HttpContext.Current.Response.Write(tab + dc.ColumnName);
                tab = "\t";
            }
            HttpContext.Current.Response.Write("\n");
            int i;
            foreach (DataRow dr in dt.Rows)
            {
                tab = "";
                for (i = 0; i < dt.Columns.Count; i++)
                {
                    HttpContext.Current.Response.Write(tab + dr[i].ToString());
                    tab = "\t";
                }
                HttpContext.Current.Response.Write("\n");
            }
            HttpContext.Current.Response.End();
        }
        public String[] ArrColores(int Cantidad)
        {
            string[] Colores = new string[Cantidad];
            Random randonGen = new Random();
            for (int i = 0; i <= Cantidad - 1; i++)
            {
                Color randomColor = Color.Empty;
                randomColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255), randonGen.Next(255));
                Colores[i] = randomColor.Name.Substring(randomColor.Name.Length - 6, 6);
            }

            return Colores;
        }
    }
}