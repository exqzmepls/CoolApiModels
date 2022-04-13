using System;
using System.ComponentModel.DataAnnotations;

namespace CoolApiModels.Chats
{
    public class PostChatModel
    {
        [Required(ErrorMessage = "Receiver Id is empty.")]
        public Guid ReceiverId { get; set; }
    }
}
