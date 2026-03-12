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
[IsoId("_ToBFQdBbEee0mNiKMkpGNQ")]
[DisplayName("Rate Type And Amount And Status")]
public partial record RateTypeAndAmountAndStatus54
{
    #nullable enable
    
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    [IsoId("_T5IDYdBbEee0mNiKMkpGNQ")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public required DeemedRateType2Choice_ RateType { get; init; } 
    
    /// <summary>
    /// Value expressed as an amount.
    /// </summary>
    [IsoId("_T5IDadBbEee0mNiKMkpGNQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required RestrictedFINActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    
    /// <summary>
    /// Value expressed as a rate status.
    /// </summary>
    [IsoId("_T5IDa9BbEee0mNiKMkpGNQ")]
    [DisplayName("Rate Status")]
    [IsoXmlTag("RateSts")]
    public RateStatus4Choice_? RateStatus { get; init; } 
    
    
    #nullable disable
    
}
