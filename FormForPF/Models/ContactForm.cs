using System.ComponentModel.DataAnnotations;

namespace FormForPF.Models
{
    public class ContactForm
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Имя обязательно")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Email обязателен")]
        [EmailAddress(ErrorMessage = "Некорректный email")]
        public required string Email { get; set; }

        [Phone(ErrorMessage = "Некорректный телефон")]
        public required string Phone { get; set; }

        [Required(ErrorMessage = "Сообщение обязательно")]
        public required string Message { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}