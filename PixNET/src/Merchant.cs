﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PixNet.src
{
    public static class Merchant
    {
        public static string GetValue(string id, string valor)
        {
            int size = valor.Length;
            string sizeFormated = Convert.ToString(size);

            if (size < 10)
            {
                sizeFormated = $"0{size}";
            }

            return $"{id}{sizeFormated}{valor}";
        }

        public static string GetMerchantAccountInformation(string idGui, string idKey, string pixKey, string idDescription, string descriptionValue, string iDMerchantInfo)
        {
            string gui = GetValue(idGui, "br.gov.bcb.pix");

            string key = GetValue(idKey, pixKey);

            string description = "";
            if (descriptionValue.Length > 0)
            {
                description = GetValue(idDescription, descriptionValue);
            }

            return GetValue(iDMerchantInfo, $"{gui}{key}{description}");
        }

        public static string GetAdditionalDataFieldTemplate(string idTx, string txIdValue, string idTemplate)
        {
            string txId = GetValue(idTx, txIdValue);

            return GetValue(idTemplate, txId);
        }
    }
}
