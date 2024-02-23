using BsonData;

namespace System
{
    partial class Document
    {
        public string CustomerName { get => GetString(nameof(CustomerName)); set => Push(nameof(CustomerName), value); }
        public string CustomerPosition { get => GetString(nameof(CustomerPosition)); set => Push(nameof(CustomerPosition), value); }
        public string Testimonial { get => GetString(nameof(Testimonial)); set => Push(nameof(Testimonial), value); }
    }
}

namespace System
{
    partial class DB
    {
        static public Collection Testimonials => Main.GetCollection(nameof(Testimonials));
    }
}