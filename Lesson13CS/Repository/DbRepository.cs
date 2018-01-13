using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            _apples.Clear();

            _apples.AddRange(_db.Apples);
            _db.Apples.ForEach(HistoryHelper.AddItem);
            return _apples.OfType<Apple>().ToList();
        }

        public List<SoldApple> GetSoldApples()
        {
            _apples.Clear();

            _apples.AddRange(_db.SoldApples);
            _db.SoldApples.ForEach(HistoryHelper.AddItem);

            return _apples.OfType<SoldApple>().ToList();
        }

        public List<IApple> GetAllApplesBy()
        {
            try
            {
                _apples.Clear();

                _apples.AddRange(_db.Apples);
                _apples.AddRange(_db.SoldApples);
                _db.Apples.ForEach(HistoryHelper.AddItem);
                _db.SoldApples.ForEach(HistoryHelper.AddItem);

                return _apples;
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
