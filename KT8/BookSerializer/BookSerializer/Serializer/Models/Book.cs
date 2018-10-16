namespace BookSerializer {   
    public class Book : ISerializeable {
		public string Title { get; set; }
		public string Author { get; set; }
        
		public void Deserialize(string serializedString) {
			// TODO: Split string on '|' into an array,
			// TODO: set Title to the first value in the array
			// TODO: and set Author to the second value
			// TODO: Throw a DeserializationException if the array does not have 
			// TODO: two items
			throw new System.NotImplementedException();
		}

		public string Serialize() {
			return string.Join("|", new[] { Title, Author });
		}
	}
}
