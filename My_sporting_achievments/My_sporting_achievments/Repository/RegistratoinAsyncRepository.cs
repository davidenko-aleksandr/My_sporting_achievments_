using My_sporting_achievments.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace My_sporting_achievments.Repository
{
    public class RegistratoinAsyncRepository
    {
        SQLiteAsyncConnection dataBaseLogin; 
        public RegistratoinAsyncRepository(string databasePath)
        {
            dataBaseLogin = new SQLiteAsyncConnection(databasePath);
        }
        public async Task CreateTable() 
        {
            await dataBaseLogin.CreateTableAsync<Registration>();
        }
        public async Task<List<Registration>> GetItemsAsync()
        {
            return await dataBaseLogin.Table<Registration>().ToListAsync();
        }
        public async Task<Registration> GetItemAsync(string login)
        {
            return await dataBaseLogin.GetAsync<Registration>(login);
        }
        public async Task<int> DeleteItemAsync(Registration item)
        {
            return await dataBaseLogin.DeleteAsync(item);
        }
        public async Task<int> SaveItemAsync(Registration item)
        {
            if (item.Id != 0)
            {
                await dataBaseLogin.UpdateAsync(item);
                return item.Id;
            }
            else
            {
                return await dataBaseLogin.InsertAsync(item);
            }
        }
    }
}
 