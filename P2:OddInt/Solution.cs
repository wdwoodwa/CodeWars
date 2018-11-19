using System.Linq;
namespace Solution
{
    class Kata
    {
        public static int find_it(int[] seq) 
        {
            var groups = seq.GroupBy(item => item);

            return groups.Where(x => x.Count() % 2 == 1)
                .Select(x => x.Key).FirstOrDefault();
        }      
    } 
}