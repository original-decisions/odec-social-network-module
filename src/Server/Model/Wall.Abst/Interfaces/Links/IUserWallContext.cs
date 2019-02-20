using Microsoft.EntityFrameworkCore;

namespace odec.Server.Model.Wall.Abstractions.Interfaces.Links
{
    /// <summary>
    /// Прокси объект для контекста пользователя и стены
    /// </summary>
    /// <typeparam name="TUserWall">тип связи пользователь - стена</typeparam>
    public interface IUserWallContext<TUserWall> where TUserWall : class
    {
        /// <summary>
        /// Таблица связи пользователей и стен
        /// </summary>
        DbSet<TUserWall> UserWalls { get; set; }
    }
}
