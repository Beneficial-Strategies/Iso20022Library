// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details for one to many netting cut off update requests to be actioned by a central system.
/// </summary>
[IsoId("_B-239QN1Ee2-vqzwMUAewg")]
[DisplayName("Netting Cut Off")]
public partial record NettingCutOff2
{
    #nullable enable
    
    /// <summary>
    /// Identifies the netting party or group.
    /// </summary>
    [IsoId("_CEZfQQN1Ee2-vqzwMUAewg")]
    [DisplayName("Netting Identification")]
    [IsoXmlTag("NetgId")]
    public required NettingIdentification2Choice_ NettingIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the information regarding the updated netting cut off.
    /// </summary>
    [IsoId("_CEZfQwN1Ee2-vqzwMUAewg")]
    [DisplayName("New Cut Off")]
    [IsoXmlTag("NewCutOff")]
    public ValueList<CutOff1> NewCutOff { get; init; } = new ValueList<CutOff1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _CEZfQwN1Ee2-vqzwMUAewg
    
    
    #nullable disable
    
}
