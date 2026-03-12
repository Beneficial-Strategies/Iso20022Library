// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Investor type target market.
/// </summary>
[IsoId("_8aPsYDcLEeiIxKQErQxblg")]
[DisplayName("Other Target Market Investor")]
public partial record OtherTargetMarketInvestor1
{
    #nullable enable
    
    /// <summary>
    /// Type of investor.
    /// </summary>
    [IsoId("_DqAesTcMEeiIxKQErQxblg")]
    [DisplayName("Investor Type")]
    [IsoXmlTag("InvstrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? InvestorType { get; init; } 
    
    /// <summary>
    /// Choice of formats for the specification of whether the product is aimed at the type of investor.
    /// </summary>
    [IsoId("_K6BvsDcMEeiIxKQErQxblg")]
    [DisplayName("Target")]
    [IsoXmlTag("Trgt")]
    public TargetMarket3Choice_? Target { get; init; } 
    
    /// <summary>
    /// Additional information about the target market and the investor type.
    /// </summary>
    [IsoId("_qDkL0TcSEeiIxKQErQxblg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
