using GeometricShapesAutofac.Repozitorys.Interface;

namespace GeometricShapesAutofac.Repozitorys
{
    public class ShapesRepo : IShapesRepo
    {
        private readonly IRepozitory _repozitory;

        public ShapesRepo(IRepozitory repozitory)
        {
            _repozitory = repozitory;
        }

        public void Display()
        {
            for (int i = 0; i < _repozitory.GetName().Count; i++)
            {
                Console.WriteLine($" Name: {_repozitory.GetName()[i]}\n " +
                    $"Information: {_repozitory.GetInformation()[i]}");
                Console.WriteLine("\n|-----------------------------------------------------------|\n");
            }
        }
        public void Save()
        {
            _repozitory.SevaFile();
        }
    }
}
