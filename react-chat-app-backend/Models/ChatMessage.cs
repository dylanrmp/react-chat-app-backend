using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace react_chat_app_backend.Models;

public class ChatMessage
{
    [Key] 
    public Guid id { get; set; }

    public DateTime date { get; set; }
    
    [DisallowNull]
    public string senderId { get; set; }
    [DisallowNull]
    public string receiverId { get; set; }
    [DisallowNull]
    public string name { get; set; }
    [DisallowNull] 
    public string text { get; set; }
    [AllowNull]
    public string photoURL { get; set; }

    public ChatMessage()
    {
        id = Guid.NewGuid();
        date = DateTime.UtcNow;
    }
    
}