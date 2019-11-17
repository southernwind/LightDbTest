using System;
using System.Linq;

using LiteDB;

namespace LightDbTest {
	internal class Program {
		private static void Main(string[] args) {
			using var db = new LiteDatabase("database.db");
			db.DropCollection("collection1");
			var collection = db.GetCollection<Model>("collection1");
			var models = new Model[]{
				new Model(){Id=1},
				new Model(){Id=2},
			};
			collection.Insert(models);

			// OK
			collection.Query().Where(x => new int[] { 3 }.Contains(x.Id)).ToList();

			// System.NullReferenceException: 'Object reference not set to an instance of an object.'
			collection.Query().Where(x => new int[] { }.Contains(x.Id)).ToList();
		}
	}

	public class Model {
		public int Id {
			get; set;
		}
	}
}
