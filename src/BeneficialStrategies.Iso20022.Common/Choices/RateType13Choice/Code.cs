// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateType13Choice
{
    /// <summary>
    /// Standard code to specify the type of gross dividend rate.
    /// </summary>
    [IsoId("_Q2uKo9p-Ed-ak6NoX_4Aeg_-37294086")]
    [DisplayName("Code")]
    public record Code : RateType13Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of gross dividend rate.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required GrossDividendRateType1Code Value { get; init; }
    }
}
