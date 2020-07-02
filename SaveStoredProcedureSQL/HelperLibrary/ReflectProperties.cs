using HelperLibrary.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Text;

namespace HelperLibrary
{
    public class ReflectProperties
    {
        public static void GetParameters(OfferDb offerDb, out string nameParameters, out object[] parameters)
        {
            if (offerDb is null)
                throw new ArgumentNullException("offerDb");

            nameParameters = null;
            var listNameParameters = new List<string>();
            var listParameters = new List<SqlParameter>();

            var propertiesInfo = offerDb.GetType().GetProperties();

            parameters = new object[propertiesInfo.Count()];

            foreach (var propertyInfo in propertiesInfo)
            {                
                listNameParameters.Add($"@{propertyInfo.Name}");

                var parameter = new SqlParameter($"@{propertyInfo.Name}", propertyInfo.GetValue(offerDb));

                SetSqlType(parameter, propertyInfo);
                
                listParameters.Add(parameter);
            }

            parameters = listParameters.ToArray();
            nameParameters = string.Join(", ", listNameParameters.ToArray());
        }

        private static void SetSqlType(SqlParameter sqlParameter, PropertyInfo propertyInfo)
        {
            if (sqlParameter.Value is null)
            {
                sqlParameter.IsNullable = true;

                if (propertyInfo.PropertyType == typeof(string))
                {
                    sqlParameter.SqlValue = SqlString.Null;
                }

                if (propertyInfo.PropertyType == typeof(int?))
                {
                    sqlParameter.SqlValue = SqlInt32.Null;
                }

                if (propertyInfo.PropertyType == typeof(bool?))
                {
                    sqlParameter.SqlValue = SqlBinary.Null;
                }

                if (propertyInfo.PropertyType == typeof(DateTime?))
                {
                    sqlParameter.SqlValue = SqlDateTime.Null;
                }

                if (propertyInfo.PropertyType == typeof(double?))
                {
                    sqlParameter.SqlValue = SqlDouble.Null;
                }
            }
        }
    }
}
