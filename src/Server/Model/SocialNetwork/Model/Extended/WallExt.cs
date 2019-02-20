using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace odec.Server.Model.SocialNetwork.Model.Extended
{
    /// <summary>
    /// РАсширенный серверный объект стены пользователя - он включает в себя так же коллекцию с сообщениями
    /// </summary>
    public class WallExt:Wall.Wall
    {
        //TODO: возможно не стоит хранить все сообщения стены. Для этого стоит аяксом подтягивать сообщения
        /// <summary>
        /// Сообщения на данной стене
        /// </summary>
        [NotMapped]
        public ICollection<Message.Message> Messages { get; set; }
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        [NotMapped]
        public int UserId { get; set; }
        /// <summary>
        /// Является ли стеной по умолчанию
        /// </summary>
        [NotMapped]
        public bool IsDefault { get; set; }
    }
}
