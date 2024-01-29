using BsonData;

namespace System
{
    partial class Document
    {
        public string Type{ get => GetString(nameof(Type)); set => Push(nameof(Type), value); }
    }
}

namespace System
{
    partial class DB
    {
        static public Collection Gallery => Main.GetCollection(nameof(Gallery));
    }
}