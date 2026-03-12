// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.NettingIdentification2Choice
{
    /// <summary>
    /// Describes the individual trading party.
    /// </summary>
    [IsoId("_CKT6AQN1Ee2-vqzwMUAewg")]
    [DisplayName("Trade Party")]
    public partial record TradeParty : NettingIdentification2Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
