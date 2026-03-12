// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SystemPartyModification2Choice
{
    /// <summary>
    /// Specifies the type of residence where the party has its permanent home or principal establishment.
    /// </summary>
    [IsoId("__edeAov_Eei289CGNqs21g")]
    [DisplayName("Residence Type")]
    public partial record ResidenceType : SystemPartyModification2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of residence where the party has its permanent home or principal establishment.
        /// </summary>
        [IsoXmlTag("ResTp")]
        public required ResidenceType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
