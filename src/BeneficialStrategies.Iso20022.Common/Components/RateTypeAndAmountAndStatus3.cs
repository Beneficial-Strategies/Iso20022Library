// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the value expressed as a rate and an amount.
/// </summary>
[IsoId("_UOpIttp-Ed-ak6NoX_4Aeg_-853623387")]
[DisplayName("Rate Type And Amount And Status")]
public partial record RateTypeAndAmountAndStatus3
{
    #nullable enable
    
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    [IsoId("_UOpIt9p-Ed-ak6NoX_4Aeg_-853622525")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public required RateType6Choice_ RateType { get; init; } 
    
    /// <summary>
    /// Value expressed as an amount.
    /// </summary>
    [IsoId("_UOpIuNp-Ed-ak6NoX_4Aeg_-853622990")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    
    /// <summary>
    /// Value expressed as a rate status.
    /// </summary>
    [IsoId("_UOpIudp-Ed-ak6NoX_4Aeg_-853622586")]
    [DisplayName("Rate Status")]
    [IsoXmlTag("RateSts")]
    public RateStatus1Choice_? RateStatus { get; init; } 
    
    
    #nullable disable
    
}
