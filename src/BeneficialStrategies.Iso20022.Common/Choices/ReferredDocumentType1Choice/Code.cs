// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReferredDocumentType1Choice
{
    /// <inheritdoc cref="ICode"/>
    [IsoId("_T3sBRtp-Ed-ak6NoX_4Aeg_174928147")]
    [DisplayName("Code")]
    public partial record Code : ReferredDocumentType1Choice_
    {
        /// <inheritdoc cref="ICode.Value"/>
        [IsoXmlTag("Cd")]
        public required DocumentType5Code Value { get; init; }
    }
}
