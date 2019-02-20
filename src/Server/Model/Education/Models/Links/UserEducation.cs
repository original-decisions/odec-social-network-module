using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odec.Server.Model.Education.Links
{
    /// <summary>
    /// Связь юзера и обучения. Характерезует где, когда, как и почему учился пользователь
    /// </summary>
    public class UserEducation
    {
        /// <summary>
        /// Идетификатор учебного заведения
        /// </summary>
        [Key,Column(Order = 1)]
        public int EducationUnitId { get; set; }
        /// <summary>
        /// Серверный объект учебного заведения
        /// </summary>
        public EducationUnit EducationUnit { get; set; }
        /// <summary>
        /// Идентификатор типа документа об окончании( диплом, аттестат и т д)
        /// </summary>
        public int? EndUpDocumentTypeId { get; set; }
        /// <summary>
        /// Серверный объект -тип документа об окончании( диплом, аттестат и т д)
        /// </summary>
        public EndUpEducationDocumentType EndUpEducationDocumentType { get; set; }
        /// <summary>
        /// Идентификатор типа обучения
        /// </summary>
        public int? EducationTypeId { get; set; }
        /// <summary>
        /// Серверный объект - тип обучения
        /// </summary>
        public EducationType EducationType { get; set; }
        /// <summary>
        /// Идентификатор специализации
        /// </summary>
        public int? SpecializationId { get; set; }
        /// <summary>
        /// Серверный объект специализации
        /// </summary>
        public Specialization Specialization { get; set; }
        /// <summary>
        /// Тема документа об окончании к примеру диплома 
        /// </summary>
        public string EndUpDocumentTheme { get; set; }
        /// <summary>
        /// Дата начала обучения
        /// </summary>
        public DateTime? DateEducationStarted { get; set; }
        /// <summary>
        /// Дата окончания обучения
        /// </summary>
        public DateTime? DateEducationEnded { get; set; }

        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        [Key,Column(Order=0)]
        public int UserId { get; set; }
        /// <summary>
        /// Серверный объект- пользователь
        /// </summary>
        public User.User User { get; set; }
    }
}
