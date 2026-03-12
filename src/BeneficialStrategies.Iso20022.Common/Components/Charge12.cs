// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the different types of freight charges associated with goods.
/// </summary>
[IsoId("_RtQxENp-Ed-ak6NoX_4Aeg_-1147593410")]
[DisplayName("Charge")]
public partial record Charge12
{
    #nullable enable
    
    /// <summary>
    /// Identifies whether the freight charges associated with the goods are &quot;prepaid&quot; or &quot;collect&quot;.
    /// </summary>
    [IsoId("_RtQxEdp-Ed-ak6NoX_4Aeg_485847604")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required FreightCharges1Code Type { get; init; } 
    
    /// <summary>
    /// Amount of money associated with a service.
    /// </summary>
    [IsoId("_RtQxEtp-Ed-ak6NoX_4Aeg_-2132493840")]
    [DisplayName("Charges")]
    [IsoXmlTag("Chrgs")]
    public ChargesDetails1? Charges { get; init; } 
    
    
    #nullable disable
    
}
