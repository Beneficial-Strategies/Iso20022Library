// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies an amount and a rate status.
/// </summary>
[IsoId("_SP-qoGOVEeWYYI9c62RCjw")]
[DisplayName("Amount And Rate Status")]
public partial record AmountAndRateStatus1
{
    #nullable enable
    
    /// <summary>
    /// Value expressed as an amount.
    /// </summary>
    [IsoId("_gx2YoGOVEeWYYI9c62RCjw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    
    /// <summary>
    /// Value expressed as a rate status.
    /// </summary>
    [IsoId("_j8yDkGOVEeWYYI9c62RCjw")]
    [DisplayName("Rate Status")]
    [IsoXmlTag("RateSts")]
    public required RateStatus1Code RateStatus { get; init; } 
    
    
    #nullable disable
    
}
