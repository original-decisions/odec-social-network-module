using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odec.Server.Model.Education
{
    /// <summary>
    /// It is a link between Edcuation Unit and education type
    /// </summary>
    public class EducationTypeEducationUnit
    {
        /// <summary>
        /// идентификатор типа образования
        /// </summary>
        [Key,Column(Order = 0)]
        public int EducationTypeId { get; set; }

        /// <summary>
        /// серверный объект - тип образования
        /// </summary>
        public EducationType EducationType { get; set; }
         
        /// <summary>
        /// идентификатор блока образования
        /// </summary>
        [Key, Column(Order = 1)]
        
        public int EducationUnitId { get; set; }

        /// <summary>
        /// серверный объект - блок образования
        /// </summary>
        public EducationUnit EducationUnit { get; set; }
    }
}
