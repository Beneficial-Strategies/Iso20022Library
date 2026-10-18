// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReferredDocumentType3Choice
{
    /// <inheritdoc cref="ICode"/>
    [IsoId("_YCiq4x77EeSxevWRRWxNAg")]
    [DisplayName("Code")]
    public partial record Code : ReferredDocumentType3Choice_
    {
        /// <inheritdoc cref="ICode.Value"/>
        [IsoXmlTag("Cd")]
        public required DocumentType6Code Value { get; init; }
    }
}
