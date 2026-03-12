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
[IsoId("_RtQxE9p-Ed-ak6NoX_4Aeg_706541081")]
[DisplayName("Charge")]
public partial record Charge13
{
    #nullable enable
    
    /// <summary>
    /// Identifies whether the freight charges associated with the goods are &quot;prepaid&quot; or &quot;collect&quot;.
    /// </summary>
    [IsoId("_RtQxFNp-Ed-ak6NoX_4Aeg_1037161492")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required FreightCharges1Code Type { get; init; } 
    
    /// <summary>
    /// Amount of money associated with a service.
    /// </summary>
    [IsoId("_RtQxFdp-Ed-ak6NoX_4Aeg_751858965")]
    [DisplayName("Charges")]
    [IsoXmlTag("Chrgs")]
    public ChargesDetails2? Charges { get; init; } 
    
    
    #nullable disable
    
}
