using System.ComponentModel.DataAnnotations;

namespace HappyKids.Parties.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}