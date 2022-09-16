using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThemeMode
{
    public class Theme
    {
        #region Scheme

        #region DarkColor
        public static Color DarkFormColor = Color.Black;
        public static Color DarkColor2 = Color.FromArgb(33, 37, 41);
        public static Color DarkColor3 = Color.FromArgb(52, 58, 64);
        public static Color DarkColor4 = Color.FromArgb(73, 80, 87);
        public static Color DarkColor5 = Color.FromArgb(108, 117, 125);
        public static Color DarkForeColor = Color.White;
        #endregion

        #region LightColor
        public static Color LightFormColor = Color.White;
        public static Color LightColor2 = Color.FromArgb(170, 170, 170);
        public static Color LightColor3 = Color.FromArgb(187, 187, 187);
        public static Color LightColor4 = Color.FromArgb(204, 204, 204);
        public static Color LightColor5 = Color.FromArgb(221, 221, 221);
        public static Color LightForeColor = Color.Black;
        #endregion

        #endregion

        public static void ChangeTheme(bool mode, Control.ControlCollection container, Form form)
        {
            //Mode true = DARK
            //Mode false = LİGHT

            #region Form
            if (mode)
            {
                form.BackColor = DarkFormColor;
                form.ForeColor = DarkForeColor;
            }
            else
            {
                form.BackColor = LightFormColor;
                form.ForeColor = LightForeColor;
            }
            #endregion

            #region Controls
            foreach (Control component in container)
            {
                if (component is Panel)
                {
                    if (component.BackColor != Color.Transparent)
                    {
                        if (mode)
                        {
                            component.BackColor = DarkColor2;
                            component.ForeColor = DarkForeColor;
                        }
                        else
                        {
                            component.BackColor = LightColor2;
                            component.ForeColor = LightForeColor;
                        }
                    }
                }
                else if (component is Button)
                {
                    if (mode)
                    {
                        component.BackColor = DarkColor3;
                        component.ForeColor = DarkForeColor;
                    }
                    else
                    {
                        component.BackColor = LightColor3;
                        component.ForeColor = LightForeColor;
                    }
                }
                else if (component is TextBox)
                {
                    if (mode)
                    {
                        component.BackColor = DarkColor3;
                        component.ForeColor = DarkForeColor;
                    }
                    else
                    {
                        component.BackColor = LightColor3;
                        component.ForeColor = LightForeColor;
                    }
                }
                else if (component is Label)
                {
                    if (mode)
                    {
                        component.BackColor = Color.Transparent;
                        component.ForeColor = DarkForeColor;
                    }
                    else
                    {
                        component.BackColor = Color.Transparent;
                        component.ForeColor = LightForeColor;
                    }
                }
                else if (component is CheckBox)
                {
                    if (mode)
                    {
                        component.BackColor = Color.Transparent;
                        component.ForeColor = DarkForeColor;
                    }
                    else
                    {
                        component.BackColor = Color.Transparent;
                        component.ForeColor = LightForeColor;
                    }
                }
                else if (component is ComboBox)
                {
                    if (mode)
                    {
                        component.BackColor = DarkColor3;
                        component.ForeColor = DarkForeColor;
                    }
                    else
                    {
                        component.BackColor = LightColor3;
                        component.ForeColor = LightForeColor;
                    }
                }
                else if (component is DataGridView)
                {
                    DataGridView dataGridView = (DataGridView)component;

                    if (mode)
                    {
                        dataGridView.BackgroundColor = DarkColor3;
                        dataGridView.ColumnHeadersDefaultCellStyle.BackColor = DarkColor4;
                        dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = DarkForeColor;
                        dataGridView.DefaultCellStyle.BackColor = DarkColor5;
                        dataGridView.DefaultCellStyle.ForeColor = DarkForeColor;
                    }
                    else
                    {
                        dataGridView.BackgroundColor = LightColor3;
                        dataGridView.ColumnHeadersDefaultCellStyle.BackColor = LightColor4;
                        dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = LightForeColor;
                        dataGridView.DefaultCellStyle.BackColor = LightColor5;
                        dataGridView.DefaultCellStyle.ForeColor = LightForeColor;
                    }
                }
            }
            #endregion
        }
    }
}