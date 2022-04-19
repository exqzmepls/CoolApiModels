using Newtonsoft.Json;

namespace CoolApiModels.Messages
{
    /// <summary>
    /// Short message description (without attachments collection).
    /// </summary>
    public class ShortGetMessageModel : BaseGetMessageModel
    {
        /// <summary>
        /// Count of message attachments.
        /// </summary>
        [JsonRequired]
        public int AttachmentsCount { get; set; }
    }
}
