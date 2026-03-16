// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Derivative2Choice
{
    /// <summary>
    /// Details specific for Equity derivatives.
    /// </summary>
    [IsoId("_Bv9MR2kwEeaLAKoEUNsD9g")]
    [DisplayName("Equity")]
    public record Equity : Derivative2Choice_
    {
        /// <summary>
        /// Underlying type of the equity derivative.
        /// </summary>
        [IsoId("_PeXW0WlNEeaLAKoEUNsD9g")]
        [DisplayName("Underlying Type")]
        [IsoXmlTag("UndrlygTp")]
        public required EquityDerivative3Choice_ UnderlyingType { get; init; }

        /// <summary>
        /// Return parameter for the equity derivative.
        /// </summary>
        [IsoId("_PeXW02lNEeaLAKoEUNsD9g")]
        [DisplayName("Parameter")]
        [IsoXmlTag("Param")]
        public EquityReturnParameter1Code? Parameter { get; init; }
    }
}
