// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DocumentType1Choice
{
    /// <summary>
    /// Document type, in a coded form.
    /// </summary>
    [IsoId("_iYH70HiJEeidzqjNEfehPg")]
    [DisplayName("Code")]
    public record Code : DocumentType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the document type as published in an external document type code list.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalDocumentType1Code Value { get; init; }
    }
}
