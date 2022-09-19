using Microsoft.EntityFrameworkCore;
using System.Runtime.Serialization;

namespace ModeFirstContinueProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OfficeDbInit.Init();

            //ExplicitLoading.Run();

            LazyLoading.Run();

            //EagerLoading.Run();
        }
    }
}