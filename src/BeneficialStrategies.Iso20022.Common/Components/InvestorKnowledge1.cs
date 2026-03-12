// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Knowledge and/or experience of an investor.
/// </summary>
[IsoId("_40olsDcNEeiIxKQErQxblg")]
[DisplayName("Investor Knowledge")]
public partial record InvestorKnowledge1
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the investor is a basic investor. A basic investor has one, or more, of the following characteristics:
    /// - a basic knowledge of relevant financial instruments (a basic investor can make an informed investment decision based on the regulated and authorised offering documentation or with the help of basic information provided at the point of sale),
    /// - no financial industry experience, that is, suited to a first time investor.
    /// When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 02010.
    /// </summary>
    [IsoId("__tmooDcNEeiIxKQErQxblg")]
    [DisplayName("Basic Investor")]
    [IsoXmlTag("BsicInvstr")]
    public TargetMarket1Code? BasicInvestor { get; init; } 
    
    /// <summary>
    /// Specifies whether the investor is an informed investor. An informed investor has one, or more, of the following characteristics:
    /// - average knowledge of relevant financial products (an informed investor can make an informed investment decision based on the regulated and authorised offering documentation, together with knowledge and understanding of the specific factors/risks highlighted within them only),
    /// - some financial industry experience.
    /// When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 02020.
    /// </summary>
    [IsoId("_BDJfQDcOEeiIxKQErQxblg")]
    [DisplayName("Informed Investor")]
    [IsoXmlTag("InfrmdInvstr")]
    public TargetMarket1Code? InformedInvestor { get; init; } 
    
    /// <summary>
    /// Specifies whether the investor is an advanced investor. An advanced investor has one, or more, of the following characteristics:
    /// - good knowledge of relevant financial products and transactions, financial industry experience or accompanied by professional investment advice or included in a - discretionary portfolio service.
    /// When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 02030.
    /// </summary>
    [IsoId("_CY1f0DcOEeiIxKQErQxblg")]
    [DisplayName("Advanced Investor")]
    [IsoXmlTag("AdvncdInvstr")]
    public TargetMarket1Code? AdvancedInvestor { get; init; } 
    
    /// <summary>
    /// Specifies whether the investor is an expert investor. An expert investor has expert knowledge of and/or experience with highly specialised financial products. (Specific to Germany.) 
    /// When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 02040.
    /// </summary>
    [IsoId("_EbwZ0DcOEeiIxKQErQxblg")]
    [DisplayName("Expert Investor Germany")]
    [IsoXmlTag("ExprtInvstrDE")]
    public TargetMarket1Code? ExpertInvestorGermany { get; init; } 
    
    /// <summary>
    /// Type of investor knowledge and experience for which the financial instrument is targeted.
    /// </summary>
    [IsoId("_uChRgDcOEeiIxKQErQxblg")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public OtherTargetMarketInvestorKnowledge1? Other { get; init; } 
    
    
    #nullable disable
    
}
