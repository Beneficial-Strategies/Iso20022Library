// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Communication device number or electronic address used for communication.
/// </summary>
[IsoId("_vBAHGxrmEeyhRdHRjakS2w")]
[DisplayName("Communication Address")]
public partial record CommunicationAddress12
{
    #nullable enable
    
    /// <summary>
    /// Address for the Universal Resource Locator (URL), for example used over the www (HTTP) service.
    /// </summary>
    [IsoId("_vVty0xrmEeyhRdHRjakS2w")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    public IsoMax2048Text? URLAddress { get; init; } 
    
    
    #nullable disable
    
}
