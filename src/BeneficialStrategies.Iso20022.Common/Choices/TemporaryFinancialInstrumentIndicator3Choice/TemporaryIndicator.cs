// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TemporaryFinancialInstrumentIndicator3Choice
{
    /// <summary>
    /// Temporary financial instrument identification used for processing reasons.
    /// </summary>
    [IsoId("_KWEpYUEKEeWVgfuHGaKtRQ")]
    [DisplayName("Temporary Indicator")]
    public record TemporaryIndicator : TemporaryFinancialInstrumentIndicator3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates a &quot;Yes&quot; or &quot;No&quot; type of answer for an element.
        /// </summary>
        [IsoXmlTag("TempInd")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public required IsoYesNoIndicator Value { get; init; }
    }
}
