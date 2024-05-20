﻿
using Quan_Ly_Kho_Data_Access.Data.Danh_Muc_Co_Ban;

namespace Quan_Ly_Kho_Controls.Danh_Muc
{
    public class FControl_San_Pham_Combo : FControl_Combobox_Base
    {
        public static void Load_Combo(ComboBox p_objCombo, List<CDM_San_Pham> p_arrData, string p_strValue_Field,
              string p_strValue_Display)
        {
            if (p_arrData.Count == 0)
                return;

            CDM_San_Pham v_objFirst = p_arrData.FirstOrDefault();
            Check_Fields_Combo(v_objFirst, p_strValue_Field, p_strValue_Display);

            if (g_bIs_Success == false)
                return;

            p_objCombo.ValueMember = p_strValue_Field;
            p_objCombo.DisplayMember = p_strValue_Display;
            p_objCombo.DataSource = p_arrData.ToList();

        }
    }
}
