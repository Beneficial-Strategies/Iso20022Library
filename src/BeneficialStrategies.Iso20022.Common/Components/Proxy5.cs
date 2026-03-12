// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the elements that identify a proxy appointed to represent a party authorised to vote at a shareholders meeting.
/// </summary>
[IsoId("_79cljVtgEeSwKe7KuKvXhg")]
[DisplayName("Proxy")]
public partial record Proxy5
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of proxy.
    /// </summary>
    [IsoId("_8aBMw1tgEeSwKe7KuKvXhg")]
    [DisplayName("Proxy Type")]
    [IsoXmlTag("PrxyTp")]
    [MinLength(1)]
    [MaxLength(2)]
    public SimpleValueList<ProxyType2Code> ProxyType { get; init; } = new SimpleValueList<ProxyType2Code>(){};
    
    /// <summary>
    /// Identifies an authorized proxy that has been assigned by the issuer of the meeting.
    /// </summary>
    [IsoId("_8aBMxVtgEeSwKe7KuKvXhg")]
    [DisplayName("Preassigned Proxy")]
    [IsoXmlTag("PrssgndPrxy")]
    public IndividualPerson25? PreassignedProxy { get; init; } 
    
    
    #nullable disable
    
}
