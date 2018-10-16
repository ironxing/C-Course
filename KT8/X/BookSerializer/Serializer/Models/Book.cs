using System;

namespace BookSerializer {   
    public class Book : ISerializeable {
		public string Title { get; set; }
		public string Author { get; set; }
        
		public void Deserialize(string serializedString) {
            var splitted = serializedString.Split(new [] { '|' });
            Title = splitted[0];
            try
            {
                Author = splitted[1];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

		public string Serialize() {
			return string.Join("|", new[] { Title, Author });
		}
	}
}
