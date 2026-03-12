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
[IsoId("_Wf3Xu0EIEeWVgfuHGaKtRQ")]
[DisplayName("Rate Type And Amount And Status")]
public partial record RateTypeAndAmountAndStatus27
{
    #nullable enable
    
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    [IsoId("_WsXik0EIEeWVgfuHGaKtRQ")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public required RateType37Choice_ RateType { get; init; } 
    
    /// <summary>
    /// Value expressed as an amount.
    /// </summary>
    [IsoId("_WsXim0EIEeWVgfuHGaKtRQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    
    /// <summary>
    /// Value expressed as a rate status.
    /// </summary>
    [IsoId("_WsXinUEIEeWVgfuHGaKtRQ")]
    [DisplayName("Rate Status")]
    [IsoXmlTag("RateSts")]
    public RateStatus3Choice_? RateStatus { get; init; } 
    
    
    #nullable disable
    
}
