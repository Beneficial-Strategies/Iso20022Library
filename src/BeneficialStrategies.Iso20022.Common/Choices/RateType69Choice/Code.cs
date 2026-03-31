// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateType69Choice
{
    /// <summary>
    /// Standard code to specify the type of net dividend rate.
    /// </summary>
    [IsoId("_AUTxsZb8Eee8S7xwGG7Veg")]
    [DisplayName("Code")]
    public record Code : RateType69Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of net dividend rate.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required NetDividendRateType4Code Value { get; init; }
    }
}
