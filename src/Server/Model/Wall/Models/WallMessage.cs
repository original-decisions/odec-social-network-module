using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odec.Server.Model.Wall
{
    /// <summary>
    /// Серверный объект - сообщение на стене
    /// </summary>
    public class WallMessage 
    {
        /// <summary>
        /// Серверный объект - сообщение
        /// </summary>
        public Message.Message Message { get; set; }

        /// <summary>
        /// идентификатор сообщения
        /// </summary>
        [Column(Order = 1),Key]
        public int MessageId { get; set; }
        /// <summary>
        /// идентификатор стены
        /// </summary>
        [Column(Order = 0), Key]
        public int WallId { get; set; }

        /// <summary>
        /// Серверный объект - стена
        /// </summary>
        public Wall Wall { get; set; }

    }
}
