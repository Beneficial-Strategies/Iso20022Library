// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PresentationDocumentFormat1Choice
{
    /// <summary>
    /// Presentation document.
    /// </summary>
    [IsoId("_94JmoXltEeG7BsjMvd1mEw_-430320891")]
    [DisplayName("Code")]
    public record Code : PresentationDocumentFormat1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the external undertaking document type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalUndertakingDocumentType1Code Value { get; init; }
    }
}
