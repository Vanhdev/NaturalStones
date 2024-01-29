using BsonData;

namespace System
{
    partial class Document
    {
        public string Name { get => GetString(nameof(Name)); set => Push(nameof(Name), value); }
        public List<string> ImageUrlList { get => GetArray<List<string>>(nameof(ImageUrlList)); set => Push(nameof(ImageUrlList), value); }
        public string ShortDescription {  get => GetString(nameof(ShortDescription)); set => Push(nameof(ShortDescription), value); }
        public string Description { get => GetString(nameof(Description)); set => Push(nameof(Description), value); }
        public string Category { get => GetString(nameof(Category)); set => Push(nameof(Category), value);}
    }
}

namespace System
{
    partial class DB
    {
        static public Collection Products => Main.GetCollection(nameof(Products));
        static public Collection Categories => Main.GetCollection(nameof(Categories));
    }
}