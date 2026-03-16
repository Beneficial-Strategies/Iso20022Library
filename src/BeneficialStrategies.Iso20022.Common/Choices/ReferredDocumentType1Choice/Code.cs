// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReferredDocumentType1Choice
{
    /// <summary>
    /// Document type in a coded form.
    /// </summary>
    [IsoId("_T3sBRtp-Ed-ak6NoX_4Aeg_174928147")]
    [DisplayName("Code")]
    public record Code : ReferredDocumentType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of financial or commercial document.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required DocumentType5Code Value { get; init; }
    }
}
