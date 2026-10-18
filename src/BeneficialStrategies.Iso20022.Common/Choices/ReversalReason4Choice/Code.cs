// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReversalReason4Choice
{
    /// <inheritdoc cref="ICode"/>
    [IsoId("_TRGiYNp-Ed-ak6NoX_4Aeg_-340627868")]
    [DisplayName("Code")]
    public partial record Code : ReversalReason4Choice_
    {
        /// <inheritdoc cref="ICode.Value"/>
        [IsoXmlTag("Cd")]
        public required ExternalReversalReason1Code Value { get; init; }
    }
}
