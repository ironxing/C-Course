using System;

namespace BookSerializer {
    public class SerializationException : Exception {
        public SerializationException() : base("Serialization failed!") { }
        public SerializationException(string message) : base(message) { }
    }

    public class DeserializationException : SerializationException { }
}
