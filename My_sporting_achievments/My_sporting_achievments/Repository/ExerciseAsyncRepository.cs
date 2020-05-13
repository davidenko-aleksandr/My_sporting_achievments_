using My_sporting_achievments.Models;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace My_sporting_achievments.ViewModels
{
    public class ExerciseAsyncRepository 
    {
        SQLiteAsyncConnection dataBase;
        public ExerciseAsyncRepository(string databasePath)
        {
            dataBase = new SQLiteAsyncConnection(databasePath);        
        }
        public async Task CreateTable()
        {
            await dataBase.CreateTableAsync<OneExercise>();
        }
        public async Task<List<OneExercise>> GetItemsAsync()
        {
            return await dataBase.Table<OneExercise>().ToListAsync();
        }
        public async Task<OneExercise> GetItemAsync(int id)
        {
            return await dataBase.GetAsync<OneExercise>(id);
        }
        public async Task<int> DeleteItemAsync(OneExercise item)
        {
            return await dataBase.DeleteAsync(item);
        }
        public async Task<int> SaveItemAsync(OneExercise item)
        {
            if (item.Id != 0)
            {
                await dataBase.UpdateAsync(item);
                return item.Id;
            }
            else
            {
                return await dataBase.InsertAsync(item);
            }
        }
    }
}