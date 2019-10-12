using System;
using System.Collections.Generic;
using System.Text;
using OdeToFodd.Core;

namespace OdeToFood.Data
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly OdeToFoodDbContext db;

        public SqlRestaurantData(OdeToFoodDbContext db)
        {
            this.db = db;
        }
        public Restaurant Add(Restaurant newRestaurant)
        {
            db.Add(newRestaurant);
            return newRestaurant;
        }

        public int Commit()
        {
            return db.SaveChanges();// this method returns an int that represents the number of rows affected in db
        }

        public Restaurant Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Restaurant GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Restaurant> GetRestaurantsByName(string name)
        {
            throw new NotImplementedException();
        }

        public Restaurant Update(Restaurant updatedRestaurant)
        {
            throw new NotImplementedException();
        }
    }
}
