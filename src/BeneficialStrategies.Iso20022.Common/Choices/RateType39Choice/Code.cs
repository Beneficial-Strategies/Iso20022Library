// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateType39Choice
{
    /// <summary>
    /// Standard code to specify the type of net dividend rate.
    /// </summary>
    [IsoId("_g4YRUUENEeWVgfuHGaKtRQ")]
    [DisplayName("Code")]
    public record Code : RateType39Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of net dividend rate.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required NetDividendRateType2Code Value { get; init; }
    }
}
