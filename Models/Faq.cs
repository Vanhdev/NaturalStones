using BsonData;

namespace System
{
    partial class Document
    {
        public string Question { get => GetString(nameof(Question)); set => Push(nameof(Question), value); }
        public string Answer { get => GetString(nameof(Answer)); set => Push(nameof(Answer), value); }
    }
}

namespace System
{
    partial class DB
    {
        static public Collection FAQs => Main.GetCollection(nameof(FAQs));
    }
}