using Microsoft.EntityFrameworkCore;

namespace odec.Server.Model.Language.Abstractions.Interfaces
{
    /// <summary>
    /// Прокси объект контекста языка
    /// </summary>
    /// <typeparam name="TLanguage">тип языка</typeparam>
    public interface ILanguagesContext<TLanguage> where TLanguage : class
    {
        /// <summary>
        /// Таблица связи языков
        /// </summary>
        DbSet<TLanguage> Languages { get; set; }
    }
}
