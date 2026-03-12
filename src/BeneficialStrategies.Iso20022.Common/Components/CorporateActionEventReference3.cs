// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a linked corporate action event.
/// </summary>
[IsoId("_n8yzsznYEeWLJsP1cO-amg")]
[DisplayName("Corporate Action Event Reference")]
public partial record CorporateActionEventReference3
{
    #nullable enable
    
    /// <summary>
    /// Identification of the linked corporate action event.
    /// </summary>
    [IsoId("_oI_ckTnYEeWLJsP1cO-amg")]
    [DisplayName("Event Identification")]
    [IsoXmlTag("EvtId")]
    public required CorporateActionEventReference3Choice_ EventIdentification { get; init; } 
    
    /// <summary>
    /// Specifies when this corporate action event is to be processed relative to a linked corporate action event.
    /// </summary>
    [IsoId("_oI_cmTnYEeWLJsP1cO-amg")]
    [DisplayName("Linkage Type")]
    [IsoXmlTag("LkgTp")]
    public ProcessingPosition7Choice_? LinkageType { get; init; } 
    
    
    #nullable disable
    
}
