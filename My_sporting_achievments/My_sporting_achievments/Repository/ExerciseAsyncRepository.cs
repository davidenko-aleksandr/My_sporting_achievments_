using My_sporting_achievments.Models;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace My_sporting_achievments.ViewModels
{
    //Создание репозитория для работы с SQL
    public class ExerciseAsyncRepository 
    {
        readonly SQLiteAsyncConnection dataBase;
        public ExerciseAsyncRepository(string databasePath)
        {
            dataBase = new SQLiteAsyncConnection(databasePath);        
        }
        //Создание таблицы
        public async Task CreateTable()
        {
            await dataBase.CreateTableAsync<OneExercise>();
        }
        //Получение всех элементов из таблицы
        public async Task<List<OneExercise>> GetItemsAsync()
        {
            return await dataBase.Table<OneExercise>().ToListAsync();
        }
        //Получение конкретного элемента по id номеру
        public async Task<OneExercise> GetItemAsync(int id)
        {
            return await dataBase.GetAsync<OneExercise>(id);
        }
        //Удаление элемента
        public async Task<int> DeleteItemAsync(OneExercise item)
        {
            return await dataBase.DeleteAsync(item);
        }
        //Сохранение элемента 
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