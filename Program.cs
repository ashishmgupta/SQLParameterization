using lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLParameterization
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SqlHelper sqlHelper = new SqlHelper();
                //string planetName = sqlHelper.GetPlanetNameById_DynamicQuery(1);
                string planetName= sqlHelper.GetPlanetNameById_SqlParameter(1);
                //string planetName = sqlHelper.GetPlanetNameById_StoredProcedure(1);
                Console.WriteLine(planetName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
            Console.ReadLine();
        }
    }
}
