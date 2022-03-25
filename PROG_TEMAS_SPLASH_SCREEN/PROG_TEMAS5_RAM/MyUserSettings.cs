using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// AGREGAR
using System.Configuration;
using System.Drawing;

namespace PROG_TEMAS5_RAM
{
    public class MyUserSettings : ApplicationSettingsBase
    {
        [UserScopedSetting()]
        [DefaultSettingValue("white")]
        public Color PanelPadre
        {
            get
            {
                return ((Color)this["PanelPadre"]);
            }
            set
            {
                this["PanelPadre"] = (Color)value;
            }
        }
        [UserScopedSetting()]
        [DefaultSettingValue("white")]
        public Color PanelBotones
        {
            get
            {
                return ((Color)this["PanelBotones"]);
            }
            set
            {
                this["PanelBotones"] = (Color)value;
            }
        }
        [UserScopedSetting()]
        [DefaultSettingValue("white")]
        public Color BarraTitulo
        {
            get
            {
                return ((Color)this["BarraTitulo"]);
            }
            set
            {
                this["BarraTitulo"] = (Color)value;
            }
        }
        [UserScopedSetting()]
        [DefaultSettingValue("white")]
        public Color TextBusqueda
        {
            get
            {
                return ((Color)this["TextBusqueda"]);
            }
            set
            {
                this["TextBusqueda"] = (Color)value;
            }
        }
        [UserScopedSetting()]
        [DefaultSettingValue("white")]
        public Color FuenteIconos
        {
            get
            {
                return ((Color)this["FuenteIconos"]);
            }
            set
            {
                this["FuenteIconos"] = (Color)value;
            }
        }
        [UserScopedSetting()]
        [DefaultSettingValue("0")]
        public int Tema
        {
            get
            {
                return ((int)this["Tema"]);
            }
            set
            {
                this["Tema"] = (int)value;
            }

        }

    } //CIERRA EL CLASS
} //CIERRA EL NAMESPACE
