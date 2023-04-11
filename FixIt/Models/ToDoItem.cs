using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace FixIt.Models
{
    public class ToDoItem
    {
        [Key]
        public Guid ToDoItemId { get; set; } 
        public Boolean IsDone { get; set; }
        [Required]
        [StringLength(maximumLength:50, MinimumLength =3)]
        public string Title { get; set; } = string.Empty;
        public DateTimeOffset? DueAt { get; set; }  
    }
}
