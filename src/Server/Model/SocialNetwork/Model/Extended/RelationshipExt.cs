using System.Collections.Generic;
using odec.Server.Model.User.Refactor;

namespace odec.Server.Model.SocialNetwork.Model.Extended
{
    /// <summary>
    /// Расширенный класс отношений 
    /// </summary>
    public class RelationshipExt:Relationship
    {
        /// <summary>
        /// Отнощения с какими юзерами установлены у пользователя
        /// </summary>
        public IEnumerable<User.User> WithUsers { get; set; }
    }
}
