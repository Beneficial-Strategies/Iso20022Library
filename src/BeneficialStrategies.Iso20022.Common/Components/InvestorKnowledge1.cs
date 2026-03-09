// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Knowledge and/or experience of an investor.
/// </summary>
[IsoId("_40olsDcNEeiIxKQErQxblg")]
[DisplayName("Investor Knowledge")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestorKnowledge1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the investor is a basic investor. A basic investor has one, or more, of the following characteristics:
    /// - a basic knowledge of relevant financial instruments (a basic investor can make an informed investment decision based on the regulated and authorised offering documentation or with the help of basic information provided at the point of sale),
    /// - no financial industry experience, that is, suited to a first time investor.
    /// When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 02010.
    /// </summary>
    [IsoId("__tmooDcNEeiIxKQErQxblg")]
    [DisplayName("Basic Investor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BsicInvstr")]
    #endif
    [IsoXmlTag("BsicInvstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TargetMarket1Code? BasicInvestor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TargetMarket1Code? BasicInvestor { get; init; } 
    #else
    public TargetMarket1Code? BasicInvestor { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the investor is an informed investor. An informed investor has one, or more, of the following characteristics:
    /// - average knowledge of relevant financial products (an informed investor can make an informed investment decision based on the regulated and authorised offering documentation, together with knowledge and understanding of the specific factors/risks highlighted within them only),
    /// - some financial industry experience.
    /// When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 02020.
    /// </summary>
    [IsoId("_BDJfQDcOEeiIxKQErQxblg")]
    [DisplayName("Informed Investor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InfrmdInvstr")]
    #endif
    [IsoXmlTag("InfrmdInvstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TargetMarket1Code? InformedInvestor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TargetMarket1Code? InformedInvestor { get; init; } 
    #else
    public TargetMarket1Code? InformedInvestor { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the investor is an advanced investor. An advanced investor has one, or more, of the following characteristics:
    /// - good knowledge of relevant financial products and transactions, financial industry experience or accompanied by professional investment advice or included in a - discretionary portfolio service.
    /// When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 02030.
    /// </summary>
    [IsoId("_CY1f0DcOEeiIxKQErQxblg")]
    [DisplayName("Advanced Investor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdvncdInvstr")]
    #endif
    [IsoXmlTag("AdvncdInvstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TargetMarket1Code? AdvancedInvestor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TargetMarket1Code? AdvancedInvestor { get; init; } 
    #else
    public TargetMarket1Code? AdvancedInvestor { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the investor is an expert investor. An expert investor has expert knowledge of and/or experience with highly specialised financial products. (Specific to Germany.) 
    /// When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 02040.
    /// </summary>
    [IsoId("_EbwZ0DcOEeiIxKQErQxblg")]
    [DisplayName("Expert Investor Germany")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExprtInvstrDE")]
    #endif
    [IsoXmlTag("ExprtInvstrDE")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TargetMarket1Code? ExpertInvestorGermany { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TargetMarket1Code? ExpertInvestorGermany { get; init; } 
    #else
    public TargetMarket1Code? ExpertInvestorGermany { get; set; } 
    #endif
    
    /// <summary>
    /// Type of investor knowledge and experience for which the financial instrument is targeted.
    /// </summary>
    [IsoId("_uChRgDcOEeiIxKQErQxblg")]
    [DisplayName("Other")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Othr")]
    #endif
    [IsoXmlTag("Othr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherTargetMarketInvestorKnowledge1? Other { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherTargetMarketInvestorKnowledge1? Other { get; init; } 
    #else
    public OtherTargetMarketInvestorKnowledge1? Other { get; set; } 
    #endif
    
    
    #nullable disable
    
}
