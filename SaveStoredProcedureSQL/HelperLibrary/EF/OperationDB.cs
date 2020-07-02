using AutoMapper;
using HelperLibrary.Model;
using HelperLibrary.Mappers;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace HelperLibrary.EF
{
    public class OperationDB
    {
        private readonly string _connectionString;

        public OperationDB(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void CreateSqlDb()
        {
            using (var db = new DBContext(_connectionString))
            {
                db.Database.Log = query => Console.Write(query);
                db.Database.Delete();
                db.Database.Create();                
            }
        }

        public void SaveOffersToDbBySP(Offers offers)
        {
            if (offers is null)
                throw new ArgumentNullException("offers");

            var mapper = FactoryMapper.CreateMapper(new ProfileOffer());
            using (var db = new DBContext(_connectionString))
            {
                db.Database.Log = query => Console.Write(query);
                
                foreach (var offer in offers.offer)
                {
                    var offerDb = mapper.Map<OfferDb>(offer);

                    string nameParameters;
                    object[] parameters;
                    ReflectProperties.GetParameters(offerDb, out nameParameters, out parameters);

                    SaveEntityBySP(db, "Exec InsertOffer", nameParameters, parameters);
                }
            }
        }

        private int SaveEntityBySP(DBContext db, string nameProcedure, string nameParametrs, object[] parameters)
        {
            if (nameProcedure is null)
                throw new ArgumentNullException("nameProcedure");

            if (nameParametrs is null)
                throw new ArgumentNullException("nameParemeters");

            if (parameters is null)
                throw new ArgumentNullException("parameters");            
            
            var command = $"{nameProcedure} {nameParametrs}";
            
            return db.Database.ExecuteSqlCommand(command, parameters);
        }
    }
}
