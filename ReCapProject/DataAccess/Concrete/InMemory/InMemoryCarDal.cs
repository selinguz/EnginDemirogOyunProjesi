using ConsoleUI;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
	public class InMemoryCarDal : ICarDal
	{
		List<Car> _cars;

		public InMemoryCarDal()
		{
			_cars = new List<Car>
			{
				new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=40000, ModelYear=2010, Description="Hatchback"},
				new Car{Id=2, BrandId=2, ColorId=3, DailyPrice=50000, ModelYear=2014, Description="Sedan"}
			};
		}

		public void Add(Car car)
		{
			_cars.Add(car);
		}

		public void Delete(Car car)
		{
			Car carToDelete = _cars.SingleOrDefault(c => c.Id == c.Id);
			_cars.Remove(carToDelete);
		}

		public List<Car> GetAll()
		{
			return _cars;
		}

		public List<Car> GetById(int Id)
		{
			return _cars.Where(c => c.Id == Id).ToList();
		}

		public void Update(Car car)
		{
			Car carToUpdate = _cars.SingleOrDefault(c => c.Id == c.Id);
			carToUpdate.BrandId = car.BrandId;
			carToUpdate.ColorId = car.ColorId;
			carToUpdate.ModelYear = car.ModelYear;
			carToUpdate.DailyPrice = car.DailyPrice;
			carToUpdate.Description = car.Description;
		}
	}
}
