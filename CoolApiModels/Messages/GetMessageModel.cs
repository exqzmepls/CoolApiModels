using System.Collections.Generic;

namespace CoolApiModels.Messages
{
    public class GetMessageModel : BaseGetMessageModel
    {
        public List<string> Attachments { get; set; }
    }
}
