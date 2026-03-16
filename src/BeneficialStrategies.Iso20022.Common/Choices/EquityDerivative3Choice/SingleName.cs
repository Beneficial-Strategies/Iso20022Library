// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.EquityDerivative3Choice
{
    /// <summary>
    /// Populated when sub asset class is either swaps or portfolio swaps and the underlying type is a single name.
    /// </summary>
    [IsoId("_hW-FPGlPEeaLAKoEUNsD9g")]
    [DisplayName("Single Name")]
    public record SingleName : EquityDerivative3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type for a contract for equity derivatives.
        /// </summary>
        [IsoXmlTag("SnglNm")]
        public required UnderlyingEquityType5Code Value { get; init; }
    }
}
