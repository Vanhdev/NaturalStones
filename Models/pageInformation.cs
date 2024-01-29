using BsonData;

namespace System
{
    partial class Document
    {
        public string Info_Name { get => ObjectId; set => ObjectId = value; }
        public string PhoneNumber { get => GetString(nameof(PhoneNumber)); set => Push(nameof(PhoneNumber), value); }
        public string Email { get => GetString(nameof(Email)); set => Push(nameof(Email), value); }
        public string Address { get => GetString(nameof(Address)); set => Push(nameof(Address), value);}
    }
}

namespace System
{
    partial class DB
    {
        static Collection? _pageInfo;
        static public Collection PageInfo
        {
            get
            {
                if (_pageInfo == null)
                {
                    _pageInfo = Main.GetCollection(nameof(PageInfo));
                    if (_pageInfo.Find("layour") == null)
                    {
                        var generalInfo = new Document
                        {
                            Info_Name = "layout"
                        };
                        _pageInfo.Insert(generalInfo);
                    }
                }
                return _pageInfo;
            }
        }
    }
}