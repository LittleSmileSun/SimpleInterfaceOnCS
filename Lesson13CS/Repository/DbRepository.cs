using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13CS.Repository
{
    using Model;

    public class DbRepository
    {
        private readonly ShopDb _db;
        private readonly List<IApple> _apples;

        public HistoryHelper HistoryHelper { get; }
        public DbRepository()
        {
            _db = new ShopDb();
            _apples = new List<IApple>();
            HistoryHelper = new HistoryHelper();
        }

        public List<Apple> GetApples()
        {
            return _db.Apples;
        }

        public List<SoldApple> GetSoldApples()
        {
            return _db.SoldApples;
        }

        public List<IApple> GetAllApplesBy()
        {
            try
            {
                var apples = new List<IApple>();

                apples.AddRange(_db.Apples);
                apples.AddRange(_db.SoldApples);

                return apples;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public List<IApple> GetAllApplesBy(string kind)
        {
            try
            {
                return GetAllApplesBy().Where(ap => ap.Kind.Equals(kind)).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private bool Iskind(IApple apple)
        {
            return apple.Kind.Equals("Gold");
        }
    }
}
