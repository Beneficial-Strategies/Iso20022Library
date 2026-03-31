// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DocumentLineType1Choice
{
    /// <summary>
    /// Line identification type in a coded form.
    /// </summary>
    [IsoId("__rM9WabkEeKvUvwX_r3tzA")]
    [DisplayName("Code")]
    public record Code : DocumentLineType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the document line type as published in an external document type code list.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalDocumentLineType1Code Value { get; init; }
    }
}
