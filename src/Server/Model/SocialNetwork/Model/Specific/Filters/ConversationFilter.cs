using System.Collections.Generic;
using odec.Framework.Generic;

namespace odec.Server.Model.SocialNetwork.Model.Specific.Filters
{
    /// <summary>
    /// Фильтры для поиска обсуждений 
    /// </summary>
    public class ConversationFilter: FilterBase
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public ConversationFilter()
        {
            //При создании объекта по умолчанию используются значения для Page = 1 и Rows =30
            //Таким образом выводится 10 записей на страницу, а нумирация начинается с единицы.
            Page = 1;
            Rows = 10;
        }
        /// <summary>
        /// Идентификаторы пользователей, которые учавствуют в обсуждении
        /// </summary>
        public IList<int> ConversationUserIds { get; set; }

        /// <summary>
        /// Тема обсуждения
        /// </summary>
        public string ConversationTheme { get; set; }
        /// <summary>
        /// Поиск части в теле сообщения 
        /// </summary>
        public string BodyPart { get; set; }

        /// <summary>
        /// Точное совпадения по фразе
        /// </summary>
        public bool FullMatch { get; set; }

        /// <summary>
        /// Является ли чувствительным к регистру
        /// </summary>
        public bool CaseSensitive { get; set; }
    }
}
