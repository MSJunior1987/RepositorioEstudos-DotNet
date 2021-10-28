namespace Biblioteca.DataAccess.Util
{
    using System;
    using System.Data;

    public static class DbParse
    {
        /// <summary>
        /// Converte o datareader para int
        /// </summary>
        /// <param name="campo">o inteiro</param>        
        /// <returns>
        /// Campo convertido do retorno
        /// </returns>
        public static int ToInt(int? campo)
        {                     
            int retorno;
            try
            {
            return retorno = (campo != null) ? Convert.ToInt32(campo) : 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            // int retorno;
            // if (campo != null)
            // {
            //     retorno = Convert.ToInt32(campo);
            // }
            // else
            // {
            //     retorno = 0;
            // }

            // return retorno;
        }

        /// <summary>
        /// Converte o datareader para int
        /// </summary>
        /// <param name="row">o DataReader</param>
        /// <param name="campo">Nome do campo</param>
        /// <returns>
        /// Campo convertido do retorno
        /// </returns>
        public static int? DbParseIntOrNull(IDataRecord row, string campo)
        {
           int? retorno;   
          try
          {
             return retorno = (row[campo] != DBNull.Value) ? Convert.ToInt32(row[campo]) : null;
          }
         catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
            

            // int? retorno;
            // if (row[campo] != DBNull.Value)
            // {
            //     retorno = Convert.ToInt32(row[campo]);
            // }
            // else
            // {
            //     retorno = null;
            // }

            // return retorno;
        }

        /// <summary>
        /// Converte o datareader para int
        /// </summary>
        /// <param name="row">o DataReader</param>
        /// <param name="campo">Nome do campo</param>
        /// <returns>
        /// Campo convertido do retorno
        /// </returns>
        public static int DbParseInt(IDataRecord row, string campo)
        {
            int retorno;
            return retorno = (row[campo] != DBNull.Value) ? Convert.ToInt32(row[campo]) : 0;
            // if (row[campo] != DBNull.Value)
            // {
            //     retorno = Convert.ToInt32(row[campo]);
            // }
            // else
            // {
            //     retorno = 0;
            // }

            // return retorno;
        }

        /// <summary>
        /// Converte o datareader para string
        /// </summary>
        /// <param name="row">o DataReader</param>
        /// <param name="campo">Nome do campo</param>
        /// <returns>
        /// Campo convertido do retorno
        /// </returns>
        public static string DbParseString(IDataRecord row, string campo)
        {
            try
            {
                string retorno;
                return retorno = (row[campo] != DBNull.Value) ? Convert.string(row[campo]) : string.Empty;
                // if (row[campo] != DBNull.Value)
                // {
                //     retorno = row[campo].ToString().Trim();
                // }
                // else
                // {
                //     retorno = string.Empty;
                // }

                // return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Método Estático Converte o datareader para string
        /// </summary>
        /// <param name="campo">o campo</param>        
        /// <returns>
        /// Campo convertido do retorno
        /// </returns>
        public static decimal ToDecimal(decimal? campo)
        {
            decimal retorno;
            if (campo != null)
            {
                retorno = Convert.ToDecimal(campo);
            }
            else
            {
                retorno = 0;
            }

            return retorno;
        }

        /// <summary>
        /// Método Estático Converte o datareader para string
        /// </summary>
        /// <param name="row">o DataReader</param>
        /// <param name="campo">Nome do campo</param>
        /// <returns>
        /// Campo convertido do retorno
        /// </returns>
        public static decimal DbParseDecimal(IDataRecord row, string campo)
        {
            decimal retorno;
            if (row[campo] != DBNull.Value)
            {
                retorno = Convert.ToDecimal(row[campo]);
            }
            else
            {
                retorno = 0;
            }

            return retorno;
        }

        /// <summary>
        /// Método Estático Converte o datareader para string
        /// </summary>
        /// <param name="row">o DataReader</param>
        /// <param name="campo">Nome do campo</param>
        /// <returns>
        /// Campo convertido do retorno
        /// </returns>
        public static decimal? DbParseDecimalorNull(IDataRecord row, string campo)
        {
            decimal? retorno;
            if (row[campo] != DBNull.Value)
            {
                retorno = Convert.ToDecimal(row[campo]);
            }
            else
            {
                retorno = null;
            }

            return retorno;
        }

        /// <summary>
        /// Converte o datareader para long
        /// </summary>
        /// <param name="campo">o campo</param>
        /// <returns>
        /// Campo convertido do retorno
        /// </returns>
        public static long ToLong(long? campo)
        {
            long retorno;
            if (campo != null)
            {
                retorno = Convert.ToInt64(campo);
            }
            else
            {
                retorno = 0;
            }

            return retorno;
        }

        /// <summary>
        /// Converte o datareader para long
        /// </summary>
        /// <param name="row">o DataReader</param>
        /// <param name="campo">Nome do campo</param>
        /// <returns>
        /// Campo convertido do retorno
        /// </returns>
        public static long? DbParseLong(IDataRecord row, string campo)
        {
            long? retorno;
            if (row[campo] != DBNull.Value)
            {
                retorno = Convert.ToInt64(row[campo]);
            }
            else
            {
                retorno = null;
            }

            return retorno;
        }

        /// <summary>
        /// Converte o datareader para string
        /// </summary>
        /// <param name="campo">o campo</param>
        /// <returns>
        /// Campo convertido do retorno
        /// </returns>
        public static short ToShort(short? campo)
        {
            short retorno;
            if (campo != null)
            {
                retorno = Convert.ToInt16(campo);
            }
            else
            {
                retorno = 0;
            }

            return retorno;
        }

        /// <summary>
        /// Converte o datareader para string
        /// </summary>
        /// <param name="campo">o campo</param>
        /// <returns>
        /// Campo convertido do retorno
        /// </returns>
        public static short? ToShortOrNull(short? campo)
        {
            short? retorno;
            if (campo != null)
            {
                retorno = Convert.ToInt16(campo);
            }
            else
            {
                retorno = null;
            }

            return retorno;
        }

        /// <summary>
        /// Converte o datareader para short ou nulo
        /// </summary>
        /// <param name="row">o DataReader</param>
        /// <param name="campo">Nome do campo</param>
        /// <returns>
        /// Campo convertido do retorno
        /// </returns>
        public static short? DbParseShortOrNull(IDataRecord row, string campo)
        {
            short? retorno;
            if (row[campo] != DBNull.Value)
            {
                retorno = Convert.ToInt16(row[campo]);
            }
            else
            {
                retorno = null;
            }

            return retorno;
        }

        /// <summary>
        /// Converte o datareader para short
        /// </summary>
        /// <param name="row">o DataReader</param>
        /// <param name="campo">Nome do campo</param>
        /// <returns>
        /// Campo convertido do retorno
        /// </returns>
        public static short DbParseShort(IDataRecord row, string campo)
        {
            short retorno;
            if (row[campo] != DBNull.Value)
            {
                retorno = Convert.ToInt16(row[campo]);
            }
            else
            {
                retorno = 0;
            }

            return retorno;
        }

        /// <summary>
        /// Trata o objeto para retorno em adições de parametros
        /// </summary>
        /// <param name="campo">o campo de entrada</param>
        /// <returns>o objeto convertido</returns>
        public static object DBParseObject(object campo)
        {
            object retorno;
            if (campo != null)
            {
                retorno = campo;
            }
            else
            {
                retorno = DBNull.Value;
            }

            return retorno;
        }

        /// <summary>
        /// Trata o objeto para retorno em adições de parametros
        /// </summary>
        /// <param name="campo">o campo de entrada</param>
        /// <returns>o objeto convertido</returns>
        public static object DBParseObjectZeroToNull(object campo)
        {
            object retorno;
            if (campo != null)
            {
                string campoString = campo.ToString();
                if (campoString.Length > 0)
                {
                    if (campoString.Equals("0"))
                    {
                        retorno = DBNull.Value;
                    }
                    else
                    {
                        retorno = campo;
                    }
                }
                else
                {
                    retorno = campo;
                }
            }
            else
            {
                retorno = DBNull.Value;
            }

            return retorno;
        }

        /// <summary>
        /// Converte o datareader para Datetime
        /// </summary>
        /// <param name="row">o DataReader</param>
        /// <param name="campo">Nome do campo</param>
        /// <returns>
        /// Campo convertido do retorno
        /// </returns>
        public static DateTime DbParseDateTime(IDataRecord row, string campo)
        {
            DateTime retorno;
            if (row[campo] != DBNull.Value)
            {
                retorno = Convert.ToDateTime(row[campo]);
            }
            else
            {
                retorno = DateTime.MinValue;
            }

            return retorno;
        }

        /// <summary>
        /// Converte o datareader para DateTme ou nulo
        /// </summary>
        /// <param name="row">o DataReader</param>
        /// <param name="campo">Nome do campo</param>
        /// <returns>
        /// Campo convertido do retorno
        /// </returns>
        public static DateTime? DbParseDateTimeOrNull(IDataRecord row, string campo)
        {
            DateTime? retorno;
            if (row[campo] != DBNull.Value)
            {
                retorno = Convert.ToDateTime(row[campo]);
            }
            else
            {
                retorno = null;
            }

            return retorno;
        }
    }

}