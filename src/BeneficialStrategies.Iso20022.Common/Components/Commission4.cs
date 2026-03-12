// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money due to a party as compensation for a service.
/// </summary>
[IsoId("_VPT7itp-Ed-ak6NoX_4Aeg_-1102950857")]
[DisplayName("Commission")]
public partial record Commission4
{
    #nullable enable
    
    /// <summary>
    /// Service for which the commission is asked or paid.
    /// </summary>
    [IsoId("_VPT7i9p-Ed-ak6NoX_4Aeg_-1102950390")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CommissionType1 Type { get; init; } 
    
    /// <summary>
    /// Commission expressed as an amount of money.
    /// </summary>
    [IsoId("_VPT7jNp-Ed-ak6NoX_4Aeg_-1102950330")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    
    /// <summary>
    /// Commission expressed as a percentage.
    /// </summary>
    [IsoId("_VPT7jdp-Ed-ak6NoX_4Aeg_-1102950305")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate Rate { get; init; } 
    
    
    #nullable disable
    
}
