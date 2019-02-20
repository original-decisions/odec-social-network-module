using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odec.Server.Model.Education
{
    /// <summary>
    /// серверный объект связь между Образовательным учереждением и специализациями
    /// </summary>
    public class EducationUnitSpecialization
    {
        /// <summary>
        /// Идентификатор образовательного учереждения
        /// </summary>
        [Key,Column(Order = 0)]
        public int EducationUnitId { get; set; }
        /// <summary>
        /// Серверный объект- образовательное учереждение
        /// </summary>
        public EducationUnit EducationUnit { get; set; }
        /// <summary>
        /// Идентификатор специализации
        /// </summary>
        [Key,Column(Order = 1)]
        public int SpecializationId { get; set; }
        /// <summary>
        /// Серверный объект -специализация
        /// </summary>
        public Specialization Specialization { get; set; }

    }
}
