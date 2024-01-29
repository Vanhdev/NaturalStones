using BsonData;

namespace System
{
    partial class Document
    {
        public string Title { get => GetString(nameof(Title)); set => Push(nameof(Title), value); }
        public string ImageUrl { get => GetString(nameof(ImageUrl)); set => Push(nameof(ImageUrl), value); }
        public DateTime? PublishTime{ get => GetDateTime(nameof(PublishTime)); set => Push(nameof(PublishTime), value); }
        public string Content { get => GetString(nameof(Content)); set => Push(nameof(Content), value); }
    }
}

namespace System
{
    partial class DB
    {
        static public Collection Blogs => Main.GetCollection(nameof(Blogs));
    }
}