using System;

namespace CoolApiModels.Messages
{
    public abstract class BaseGetMessageModel
    {
        public Guid Id { get; set; }

        public Guid SenderId { get; set; }

        public DateTime SendingDateUtc { get; set; }

        public bool IsViewed { get; set; }

        public string Text { get; set; }
    }
}
