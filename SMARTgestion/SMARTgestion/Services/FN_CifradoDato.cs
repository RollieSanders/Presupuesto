using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;


namespace SMARTgestion.Services
{

    public class FN_CifradoDato
    {
        private SymmetricAlgorithm mCSP;

        public string decripta(string Cad, int x)
        {

            int i = 0;
            int y = 0;
            string cadr = "";
            int n = 0;
            int nasc = 0;
            int nmod = 0;

            y = x;
            cadr = "";
            for (i = 1; i <= Cad.TrimEnd().Length; i++)
            {
                nasc = RetAsciiCode(Cad.Substring(i, 1));
                nmod = (y % 256);
                n = (nasc+nmod);
                if (n < 0)
                {
                    n = 256 + n;
                }
                cadr = cadr + RetAsciiChar(n);
                y = y + 1;
            }
            return cadr;

        }

        //public int Asc(string String)
        //{
        //    return String.Substring(0, 1).ToCharArray()[0];
        //}

        public string encripta(string cad, int x)
        {
            int i = 0;
            int y = 0;
            string cadr = "";
            int nasc = 0;
            int nmod = 0;
            string cletra = "";
            y = x;
            cadr = "";
            for (i = 0; i <= cad.TrimEnd().Length-1; i++)
            {
                cletra = cad.Substring(i, 1);
                nasc = RetAsciiCode(cletra);
                nmod = (y % 256);
                cadr = cadr + RetAsciiChar(nasc + nmod);
                
                y = y + 1;
            }

            return cadr;

        }


        private int RetAsciiCode(string MyString)
        {
            if (MyString.Length == 0)
                return 0;
            else if (MyString.Length > 1)
                MyString = MyString[0].ToString();
            int AsciiCodeO = (int)System.Convert.ToChar(MyString);
            byte[] AsciiCodeB = System.Text.Encoding.ASCII.GetBytes(MyString);
            //int AsciiCode = System.Convert.ToInt32(AsciiCodeB);
            return AsciiCodeO;
        }

        private string RetAsciiChar(int AsciiCode)
        {
            return System.Convert.ToChar(AsciiCode).ToString();
        }


        public string Desencripta_Contraseña(string strValor, string strClave, string strVector)
        {
            string strContraseña = "";
            mCSP = SetEnc();
            mCSP.GenerateKey();
            strContraseña = DecryptString(strValor.Trim(), strClave.Trim(), strVector.Trim());

            return strContraseña;

        }

        private string DecryptString(string Value, string Clave, string Vector)
        {
            ICryptoTransform ct;
            MemoryStream ms;
            CryptoStream cs;
            byte[] byt;
            byte[] lbClave;
            byte[] lbvector;

            lbClave = Convert.FromBase64String(Clave);
            lbvector = Convert.FromBase64String(Vector);

            ct = mCSP.CreateDecryptor(lbClave, lbvector);

            //ct = mCSP.CreateDecryptor(mCSP.Key, mCSP.IV)

            byt = Convert.FromBase64String(Value);

            ms = new MemoryStream();
            cs = new CryptoStream(ms, ct, CryptoStreamMode.Write);
            cs.Write(byt, 0, byt.Length);
            cs.FlushFinalBlock();

            cs.Close();

            return Encoding.UTF8.GetString(ms.ToArray());
        }

        private SymmetricAlgorithm SetEnc()
        {
            return new DESCryptoServiceProvider();
        }

    }
}
