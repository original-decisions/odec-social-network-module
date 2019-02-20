using Microsoft.EntityFrameworkCore;

namespace odec.Server.Model.Wall.Abstractions.Interfaces
{
    /// <summary>
    /// Прокси объект для контекста стены
    /// </summary>
    /// <typeparam name="TWallMessage">тип связи сообщение - стена</typeparam>
    /// <typeparam name="TWall">тип стены</typeparam>
    public interface IWallContext<TWallMessage, TWall> where TWallMessage : class where TWall : class
    {
        /// <summary>
        /// Таблица стен
        /// </summary>
        DbSet<TWall> Walls { get; set; }

        /// <summary>
        /// Таблица связи сообщений на стене
        /// </summary>
        DbSet<TWallMessage> WallMessages { get; set; }
    }


    
}
