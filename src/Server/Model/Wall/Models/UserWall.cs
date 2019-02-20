using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odec.Server.Model.Wall
{
    /// <summary>
    /// Серверный объект - связь пользователя и стены
    /// </summary>
    public class UserWall
    {
        /// <summary>
        /// Серверный объект - пользователь
        /// </summary>
        public User.User User { get; set; }
        
        
        /// <summary>
        /// идентификатор пользователя
        /// </summary>
         [Key,Column(Order=0)]
        public int UserId { get; set; }

        /// <summary>
         /// идентификатор стены
        /// </summary>
         [Key, Column(Order = 1)]
        public int WallId { get; set; }

        /// <summary>
         /// Серверный объект - стена
        /// </summary>
        public Wall Wall { get; set; }

        /// <summary>
        /// признак того, что эта стена показывается пользователю по умолчанию
        /// </summary>
        public bool IsDefault { get; set; }
    }
}
