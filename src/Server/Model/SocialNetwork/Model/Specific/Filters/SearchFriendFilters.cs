using odec.Framework.Generic;

namespace odec.Server.Model.SocialNetwork.Model.Specific.Filters
{
    /// <summary>
    /// Серверный объект - фильтры поиска друзей (объект обертка)
    /// </summary>
    public class SearchFriendFilters: FilterBase
    {
        
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Фамилия 
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string Patronymic { get; set; }
        /// <summary>
        /// Идентификаторы полов
        /// </summary>
        public int[] SexIds { get; set; }
        /// <summary>
        /// Идентификаторы хобби
        /// </summary>
        public int[] HobbyIds { get; set; }
        /// <summary>
        /// Идентификатор пользователя, осуществляющего фильтрацию
        /// </summary>
        public int CurrentUserId { get; set; }
    }
}
