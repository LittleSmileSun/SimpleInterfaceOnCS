using System.Collections.Generic;

namespace Lesson13CS.Repository
{
    using Model;

    public class ShopDb
    {
        public List<Apple> Apples { get; }
        public List<SoldApple> SoldApples { get; }

        public ShopDb()
        {
            Apples = new List<Apple>();
            SoldApples = new List<SoldApple>();

            LoadData();
        }

        private void LoadData()
        {
            #region Apple
            Apples.Add(new Apple
            {
                Color = AppleColor.Green,
                Kind = "Gold",
                Price = 2.56
            });

            Apples.Add(new Apple
            {
                Color = AppleColor.Green,
                Kind = "Gold",
                Price = 3.90
            });

            Apples.Add(new Apple
            {
                Color = AppleColor.Yellow,
                Kind = "Double Sun",
                Price = 4.56
            });
            #endregion

            #region SoldApple

            SoldApples.Add(new SoldApple
            {
                Color = AppleColor.Green,
                Kind = "Gold",
                Price = 5.56
            });
            SoldApples.Add(new SoldApple
            {
                Color = AppleColor.Red,
                Kind = "Gold FD",
                Price = 13.90
            });
            SoldApples.Add(new SoldApple
            {
                Color = AppleColor.Yellow,
                Kind = "Double Sun",
                Price = 45.56
            });
            SoldApples.Add(new SoldApple
            {
                Color = AppleColor.Yellow,
                Kind = "Double Sun",
                Price = 15.56
            });
            SoldApples.Add(new SoldApple
            {
                Color = AppleColor.Red,
                Kind = "Double Sun",
                Price = 7.56
            });
            #endregion
        }
    }
}
