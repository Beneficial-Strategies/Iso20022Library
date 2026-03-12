// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Investor knowledge and experience target market.
/// </summary>
[IsoId("_pd4osDcOEeiIxKQErQxblg")]
[DisplayName("Other Target Market Investor Knowledge")]
public partial record OtherTargetMarketInvestorKnowledge1
{
    #nullable enable
    
    /// <summary>
    /// Type of investor knowledge and experience.
    /// </summary>
    [IsoId("_07LyczcOEeiIxKQErQxblg")]
    [DisplayName("Investor Knowledge Type")]
    [IsoXmlTag("InvstrKnwldgTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? InvestorKnowledgeType { get; init; } 
    
    /// <summary>
    /// Choice of formats for the specification of whether the product is aimed at the type of knowledge or experience of the investor.
    /// </summary>
    [IsoId("_07LydDcOEeiIxKQErQxblg")]
    [DisplayName("Target")]
    [IsoXmlTag("Trgt")]
    public TargetMarket1Choice_? Target { get; init; } 
    
    /// <summary>
    /// Additional information about the target market and the investor knowledge and experience.
    /// </summary>
    [IsoId("_07LydTcOEeiIxKQErQxblg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
