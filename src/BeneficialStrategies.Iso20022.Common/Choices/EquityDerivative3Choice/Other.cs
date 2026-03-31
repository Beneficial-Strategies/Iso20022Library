// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.EquityDerivative3Choice
{
    /// <summary>
    /// Populated when the sub asset class is neither swaps nor portfolio swaps.
    /// </summary>
    [IsoId("_hW-FO2lPEeaLAKoEUNsD9g")]
    [DisplayName("Other")]
    public record Other : EquityDerivative3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type for a contract for equity derivatives.
        /// </summary>
        [IsoXmlTag("Othr")]
        public required UnderlyingEquityType6Code Value { get; init; }
    }
}
