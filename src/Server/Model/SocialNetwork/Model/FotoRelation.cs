using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using odec.Server.Model.User.Refactor;

namespace odec.Server.Model.SocialNetwork.Model
{
    /// <summary>
    /// Серверный объект отношений фотографии
    /// </summary>
    public class FotoRelation
    {
        /// <summary>
        /// Идентификатор фото
        /// </summary>
        [Column(Order = 2), Key]
        public int FotoId { get; set; }
        /// <summary>
        /// Серверный объект фото
        /// </summary>
        public Image Foto { get; set; }

        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        [Column(Order = 1), Key]
        public int UserId { get; set; }
        /// <summary>
        /// Серверный объет пользователя
        /// </summary>
        public User.User User { get; set; }
        /// <summary>
        /// Идентификатор альбома
        /// </summary>
        [Column(Order = 0), Key]
        public int AlbumId { get; set; }
        /// <summary>
        /// Серверный объект Альбом
        /// </summary>
        public Album Album { get; set; }
    }
}
