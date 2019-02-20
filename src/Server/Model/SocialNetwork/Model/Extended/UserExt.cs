using System;
using System.Collections.Generic;
using odec.Server.Model.Achievement;
using odec.Server.Model.Contact;
using odec.Server.Model.Education.Links;
using odec.Server.Model.Language;
using odec.Server.Model.User;

namespace odec.Server.Model.SocialNetwork.Model.Extended
{
    /// <summary>
    /// Расширенный объект пользователя
    /// </summary>
    public class UserExt:User.User
    {

        /// <summary>
        /// День рождения(может быть не указан)
        /// </summary>
        public DateTime? BirthDate   { get; set; }
        /// <summary>
        /// Информация о местах образований пользователя
        /// </summary>
        public IEnumerable<UserEducation> Education { get; set; }
        /// <summary>
        /// Список языков, которые знает пользователь
        /// </summary>
        public IEnumerable<UserLanguage> Languages { get; set; }
        /// <summary>
        /// Список увлечений пользователя
        /// </summary>
        public IEnumerable<UserHobby> Hobbies { get; set; }
        /// <summary>
        /// Список Друзей пользователя
        /// </summary>
        public IEnumerable<Friend> Friends { get; set; }
        /// <summary>
        /// Список Достижений пользователя
        /// </summary>
        public IEnumerable<UserAchievement> Achievements { get; set; }
        /// <summary>
        /// Пол пользователя
        /// </summary>
        public Sex Sex { get; set; }

        /// <summary>
        /// Список контактов пользователя
        /// </summary>
        public IEnumerable<UserContact> Contacts { get; set; }
        /// <summary>
        /// Родной язык
        /// </summary>
        public Language.Language NativeLanguage { get; set; }
        /// <summary>
        /// Список стен польхователя
        /// </summary>
        public IEnumerable<WallExt> Walls { get; set; }

        public IEnumerable<RelationshipExt> Relationships { get; set; }
    }
}
