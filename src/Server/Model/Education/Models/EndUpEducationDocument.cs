using odec.Framework.Generic;

namespace odec.Server.Model.Education
{
    /// <summary>
    /// This is a type of document that is graduated to student
    /// </summary>
    public class EndUpEducationDocumentType : Glossary<int>
    {
        /// <summary>
        /// серверный объект - тип документа
        /// </summary>
        public bool ShouldHaveTheme { get; set; }
    }
}
