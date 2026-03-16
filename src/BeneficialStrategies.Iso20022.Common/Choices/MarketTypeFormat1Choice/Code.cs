// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MarketTypeFormat1Choice
{
    /// <summary>
    /// Standard code to specify the type of market in which transactions take place, for example, primary or secondary.
    /// </summary>
    [IsoId("_Q4XJYtp-Ed-ak6NoX_4Aeg_1331206916")]
    [DisplayName("Code")]
    public record Code : MarketTypeFormat1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of market in which transactions take place, for example, primary or secondary.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required MarketType3Code Value { get; init; }
    }
}
