using System;
using System.IO;

namespace BookSerializer {
	public static class SerializedReaderWriter {
		public static T Read<T>(string filename) where T : ISerializeable, new() {
			var filecontent = "";

			// TODO: Read contents from filename into filecontent using StreamReader!

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
			// TODO: Write data.Serialize() into filename using StreamWriter!

			throw new NotImplementedException();
		}
    }
}
