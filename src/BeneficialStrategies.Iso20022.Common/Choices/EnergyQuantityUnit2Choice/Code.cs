// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.EnergyQuantityUnit2Choice
{
    /// <summary>
    /// Energy quantity units, expressed as a code.
    /// </summary>
    [IsoId("_sTr98Si_EeuKKc2MztSwPw")]
    [DisplayName("Code")]
    public record Code : EnergyQuantityUnit2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies an energy quantity unit.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required EnergyQuantityUnit2Code Value { get; init; }
    }
}
