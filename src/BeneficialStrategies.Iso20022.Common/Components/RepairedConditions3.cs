// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Charge or commission of the original individual order details that have been repaired so that the order can be accepted.
/// </summary>
[IsoId("_RLb2ZNp-Ed-ak6NoX_4Aeg_-1888312620")]
[DisplayName("Repaired Conditions")]
public partial record RepairedConditions3
{
    #nullable enable
    
    /// <summary>
    /// Modified value of the charge applied on the order (the charge in the original individual order that has been repaired so that the order can be accepted).
    /// </summary>
    [IsoId("_RLb2Zdp-Ed-ak6NoX_4Aeg_-1888312329")]
    [DisplayName("Repaired Charge")]
    [IsoXmlTag("RprdChrg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Charge19> RepairedCharge { get; init; } = [];
    
    /// <summary>
    /// Modified value of the commission applied on the order (the commission in the original individual order that has been repaired so that the order can be accepted).
    /// </summary>
    [IsoId("_RLb2Ztp-Ed-ak6NoX_4Aeg_-1888312610")]
    [DisplayName("Repaired Commission")]
    [IsoXmlTag("RprdComssn")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Commission11> RepairedCommission { get; init; } = [];
    
    
    #nullable disable
    
}
