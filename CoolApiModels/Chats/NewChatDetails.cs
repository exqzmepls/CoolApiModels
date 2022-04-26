using Swashbuckle.AspNetCore.Annotations;
using System;
using System.ComponentModel.DataAnnotations;

namespace CoolApiModels.Chats
{
    /// <summary>
    /// New chat details.
    /// </summary>
    [SwaggerSchema("New chat details.")]
    public class NewChatDetails
    {
        /// <summary>
        /// ID of user to chat with.
        /// </summary>
        [Required(ErrorMessage = "Receiver ID is empty.")]
        [SwaggerSchema("ID of user to chat with.")]
        public Guid ReceiverId { get; set; }
    }
}
