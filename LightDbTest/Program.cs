using System;

using LiteDB;

namespace LightDbTest {
	internal class Program {
		private static void Main(string[] args) {
			using var db = new LiteDatabase("database.db");
			var imageFiles = db.GetCollection<ImageFile>("imageFiles");
			Console.WriteLine($"count : {imageFiles.Count()}");

			var image = new ImageFile {
				FileName = "IMG_8024.JPG",
				Tags = new[] { "Ocean", "Dolphin" },
				Exif = new Exif {
					Date = new DateTime(2001, 8, 5, 11, 30, 35),
					Latitude = 27.037597,
					Longitude = 128.468554,
					Altitude = 0
				}
			};
			imageFiles.Insert(image);

			Console.WriteLine($"count : {imageFiles.Count()}");
			Console.WriteLine($"id : {image.Id}");
		}
	}
}
