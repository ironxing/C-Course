using System;
using System.IO;

namespace BookSerializer {
	public static class SerializedReaderWriter {
		public static T Read<T>(string filename) where T : ISerializeable, new() {
			var filecontent = "";

            using (var fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                using (var sr = new StreamReader(fs))
                {
                    filecontent = sr.ReadToEnd();
                }
            }

			if (!string.IsNullOrEmpty(filecontent)) {
				try {
                    return SerializeableFactory.FromString<T>(filecontent);
				} catch (Exception ex) {
					throw ex;
				}
			}
			throw new SerializationException("Couldn't read file!");
		}

		public static void Write<T>(string filename, T data) where T : ISerializeable {
            using (var fs = new FileStream(filename, FileMode.Create, FileAccess.ReadWrite))
            {
                using (var sw = new StreamWriter(fs))
                {
                    sw.Write(data.Serialize());
                    Console.WriteLine("yep, it is wrong here");
                }
            }
        }
    }
}
