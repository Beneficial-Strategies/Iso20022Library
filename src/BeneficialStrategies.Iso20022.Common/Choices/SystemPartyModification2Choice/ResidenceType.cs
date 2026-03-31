// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SystemPartyModification2Choice
{
    /// <summary>
    /// Specifies the type of residence where the party has its permanent home or principal establishment.
    /// </summary>
    [IsoId("__edeAov_Eei289CGNqs21g")]
    [DisplayName("Residence Type")]
    public record ResidenceType : SystemPartyModification2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of residence where the party has its permanent home or principal establishment.
        /// </summary>
        [IsoXmlTag("ResTp")]
        public required ResidenceType1Code Value { get; init; }
    }
}
