using AutoMapper;
using My_sporting_achievments.Models;
using My_sporting_achievments.ViewModels;

namespace My_sporting_achievments.Converters
{
    public class OneExsToViewModelConverter
    {
        //Конвертируем тип "OneExercise" в тип "OneExerciseViewModel" и аналогично наоборот
        //Это нужно для того, чтобы управлять свойствами и взаимодействовать с БД SQL
        public OneExercise ConvertToOneExs(OneExerciseViewModel viewModel) 
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<OneExerciseViewModel, OneExercise>(); });
            IMapper iMapper = config.CreateMapper();
            var destination = iMapper.Map<OneExerciseViewModel, OneExercise>(viewModel);
            return destination;
        }
        public OneExerciseViewModel ConvertTooneexsVM(OneExercise oneExercise)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<OneExercise, OneExerciseViewModel>(); });
            IMapper iMapper = config.CreateMapper();
            var destination = iMapper.Map<OneExercise, OneExerciseViewModel>(oneExercise);
            return destination;
        }

        
    }
}
