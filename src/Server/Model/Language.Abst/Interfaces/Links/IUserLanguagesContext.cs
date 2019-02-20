using Microsoft.EntityFrameworkCore;

namespace odec.Server.Model.Language.Abstractions.Interfaces.Links
{
    /// <summary>
    /// Прокси объект для контекста пользователя и языка
    /// </summary>
    /// <typeparam name="TUserLanguage">тип языка</typeparam>
    public interface IUserLanguagesContext<TUserLanguage> where TUserLanguage : class
    {
        /// <summary>
        /// Таблица связи пользователя и языков
        /// </summary>
        DbSet<TUserLanguage> UserLanguages { get; set; }
    }
}
