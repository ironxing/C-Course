using System;
namespace BookSerializer {
	public abstract class AbstractSerializeable<T> : ISerializeable {
		public AbstractSerializeable(string serializedData) {
			Deserialize(serializedData);
		}

		public abstract void Deserialize(string serializedString);
		public abstract string Serialize();
    }
}
