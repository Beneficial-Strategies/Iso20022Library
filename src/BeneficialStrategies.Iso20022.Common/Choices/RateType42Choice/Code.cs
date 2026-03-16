// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateType42Choice
{
    /// <summary>
    /// Standard code to specify the type of withholding tax rate.
    /// </summary>
    [IsoId("__pfAUUEIEeWVgfuHGaKtRQ")]
    [DisplayName("Code")]
    public record Code : RateType42Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of withholding tax rate.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required WithholdingTaxRateType1Code Value { get; init; }
    }
}
