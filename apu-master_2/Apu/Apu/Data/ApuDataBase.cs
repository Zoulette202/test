using System;
using Apu.Models;
using SQLite;

namespace Apu.Data
{
    public class ApuDataBase
    {
        readonly SQLiteAsyncConnection db;

        public ApuDataBase(string connectionString)
        {
            db = new SQLiteAsyncConnection(connectionString);
            db.CreateTableAsync<City>().Wait();
        }


       /* public async Task<int> SaveAsync (City city)
        {
            if (city.ID != 0){
                return await db.UpdateAsync(city);
            } else {
                return await db.InsertAsync(city);
            }
        }


        public async Task<int> DeleteAsync(City city)
        {
            return await db.DeleteAsync(city);
        }

        public async Task<List<int>> GetAll()
        {
            return await db.QueryAsync<City>("SELECT * FROM [City]");
        }*/
    }
}
