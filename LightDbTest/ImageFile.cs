namespace LightDbTest {
	internal class ImageFile {
		public int Id {
			get;
			set;
		}

		public string FileName {
			get;
			set;
		}

		public Exif Exif {
			get;
			set;
		}

		public string[] Tags {
			get;
			set;
		}
	}
}
