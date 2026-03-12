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
[IsoId("_3VEsgJVHEeaYkf5FCqYMeA")]
[DisplayName("Netting Cut Off")]
public partial record NettingCutOff1
{
    #nullable enable
    
    /// <summary>
    /// Identifies the netting party or group.
    /// </summary>
    [IsoId("_lQffwJXWEeaYkf5FCqYMeA")]
    [DisplayName("Netting Identification")]
    [IsoXmlTag("NetgId")]
    public required NettingIdentification1Choice_ NettingIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the information regarding the updated netting cut off.
    /// </summary>
    [IsoId("_JpSG4JVMEeaYkf5FCqYMeA")]
    [DisplayName("New Cut Off")]
    [IsoXmlTag("NewCutOff")]
    public ValueList<CutOff1> NewCutOff { get; init; } = new ValueList<CutOff1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _JpSG4JVMEeaYkf5FCqYMeA
    
    
    #nullable disable
    
}
