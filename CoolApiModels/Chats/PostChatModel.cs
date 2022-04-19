using System;
using System.ComponentModel.DataAnnotations;

namespace CoolApiModels.Chats
{
    /// <summary>
    /// New chat description.
    /// </summary>
    public class PostChatModel
    {
        /// <summary>
        /// ID of user to chat with.
        /// </summary>
        [Required(ErrorMessage = "Receiver Id is empty.")]
        public Guid ReceiverId { get; set; }
    }
}
