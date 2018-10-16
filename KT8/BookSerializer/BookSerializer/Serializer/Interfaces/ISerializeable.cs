namespace BookSerializer {
	public interface ISerializeable {
		string Serialize();
		void Deserialize(string serializedString);
    }
}
