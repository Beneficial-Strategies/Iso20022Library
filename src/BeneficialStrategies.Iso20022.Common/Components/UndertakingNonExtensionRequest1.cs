// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the non extension request.
/// </summary>
[IsoId("_-D6xxnltEeG7BsjMvd1mEw_-1432358339")]
[DisplayName("Undertaking Non Extension Request")]
public partial record UndertakingNonExtensionRequest1
{
    #nullable enable
    
    /// <summary>
    /// Details related to the requesting party.
    /// </summary>
    [IsoId("_-D6xx3ltEeG7BsjMvd1mEw_-452692672")]
    [DisplayName("Requesting Party")]
    [IsoXmlTag("RqstngPty")]
    public required PartyIdentification43 RequestingParty { get; init; } 
    
    /// <summary>
    /// Details related to the identification of the undertaking.
    /// </summary>
    [IsoId("_-D6xyHltEeG7BsjMvd1mEw_747345040")]
    [DisplayName("Undertaking Identification")]
    [IsoXmlTag("UdrtkgId")]
    public required Undertaking9 UndertakingIdentification { get; init; } 
    
    
    #nullable disable
    
}
