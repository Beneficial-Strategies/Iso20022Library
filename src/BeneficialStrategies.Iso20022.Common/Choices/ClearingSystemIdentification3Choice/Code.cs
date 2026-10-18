// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemIdentification3Choice
{
    /// <inheritdoc cref="ICode"/>
    [IsoId("_TMVXJtp-Ed-ak6NoX_4Aeg_948374929")]
    [DisplayName("Code")]
    public partial record Code : ClearingSystemIdentification3Choice_
    {
        /// <inheritdoc cref="ICode.Value"/>
        [IsoXmlTag("Cd")]
        public required ExternalCashClearingSystem1Code Value { get; init; }
    }
}
