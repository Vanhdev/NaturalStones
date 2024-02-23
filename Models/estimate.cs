using BsonData;

namespace System
{
    partial class Document
    {
        public string Subject { get => GetString(nameof(Subject)); set => Push(nameof(Subject), value); }
    }
}

namespace System
{
    partial class DB
    {
        static public Collection Estimates => Main.GetCollection(nameof(Estimates));
    }
}