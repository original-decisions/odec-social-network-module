using Microsoft.EntityFrameworkCore;

namespace odec.Server.Model.Education.Abstractions.Interfaces
{
    /// <summary>
    /// Прокси объект для контекста пользователя и образования
    /// </summary>
    /// <typeparam name="TUserEducation">тип образования</typeparam>
    public interface IUserEducation<TUserEducation> where TUserEducation : class
    {
        /// <summary>
        /// Таблица связи пользователя и образований
        /// </summary>
        DbSet<TUserEducation> UserEducations { get; set; }
    }
}
