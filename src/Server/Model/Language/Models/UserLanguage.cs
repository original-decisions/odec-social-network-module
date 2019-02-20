using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odec.Server.Model.Language
{
   /// <summary>
    /// Серверный объект - связь пользователя и языка
   /// </summary>
    public class UserLanguage
    {
        /// <summary>
        /// идентификатор пользователя
        /// </summary>
        [Key,Column(Order=0)]
        public int UserId { get; set; }

        /// <summary>
        /// Серверный объект - пользователь
        /// </summary>
        public User.User User { get; set; }
        
        /// <summary>
        /// идентификатор языка
        /// </summary>
        [Key, Column(Order = 1)]
        public int LanguageId { get; set; }

        /// <summary>
        /// Серверный объект - язык
        /// </summary>
        public Language Language { get; set; }

        /// <summary>
        /// Серверный объект - родной язык
        /// </summary>
        public bool IsNative { get; set; }
    }
}
