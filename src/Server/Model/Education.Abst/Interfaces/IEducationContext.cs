using Microsoft.EntityFrameworkCore;

namespace odec.Server.Model.Education.Abstractions.Interfaces
{
    /// <summary>
    /// Прокси объект контекста образования
    /// </summary>
    /// <typeparam name="TEducationType">тип типов образования</typeparam>
    /// <typeparam name="TEducationUnit">тип учебного заведения</typeparam>
    /// <typeparam name="TEndUpDocumentType">тип типов докуиментов об образовании</typeparam>
    /// <typeparam name="TSpecialization">тип специальностей</typeparam>
    /// <typeparam name="TEducationUnitEducationType">тип типов учебных заведений</typeparam>
    /// <typeparam name="TEducationUnitSpecializations">тип учебного заведения и специальности</typeparam>
    public interface IEducationContext<TEducationType, TEducationUnit, TEndUpDocumentType, TSpecialization, TEducationUnitEducationType, TEducationUnitSpecializations>
        where TEducationType : class
        where TEducationUnit : class
        where TEndUpDocumentType : class
        where TSpecialization : class
        where TEducationUnitEducationType : class where TEducationUnitSpecializations : class
    {
        /// <summary>
        /// таблица связи учебных заведений
        /// </summary>
        DbSet<TEducationUnit> EducationUnits { get; set; }

        /// <summary>
        /// таблица связи типов учебных заведений
        /// </summary>
        DbSet<TEducationUnitEducationType> EducationUnitEducationTypes { get; set; }

        /// <summary>
        /// таблица связи типов документов об образовании
        /// </summary>
        DbSet<TEndUpDocumentType> EndUpDocumentTypes { get; set; }

        /// <summary>
        /// таблица связи учебного заведения и специальностей
        /// </summary>
        DbSet<TEducationUnitSpecializations> EducationUnitSpecializationses { get; set; }

        /// <summary>
        /// таблица связи специальностей
        /// </summary>
        DbSet<TSpecialization> Specializations { get; set; }

        /// <summary>
        /// таблица связи типов образований
        /// </summary>
        DbSet<TEducationType> EducationTypes { get; set; }
    }
}
