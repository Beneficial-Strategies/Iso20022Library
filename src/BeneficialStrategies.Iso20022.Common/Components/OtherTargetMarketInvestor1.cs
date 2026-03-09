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
/// Investor type target market.
/// </summary>
[IsoId("_8aPsYDcLEeiIxKQErQxblg")]
[DisplayName("Other Target Market Investor")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OtherTargetMarketInvestor1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of investor.
    /// </summary>
    [IsoId("_DqAesTcMEeiIxKQErQxblg")]
    [DisplayName("Investor Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstrTp")]
    #endif
    [IsoXmlTag("InvstrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? InvestorType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InvestorType { get; init; } 
    #else
    public System.String? InvestorType { get; set; } 
    #endif
    
    /// <summary>
    /// Choice of formats for the specification of whether the product is aimed at the type of investor.
    /// </summary>
    [IsoId("_K6BvsDcMEeiIxKQErQxblg")]
    [DisplayName("Target")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trgt")]
    #endif
    [IsoXmlTag("Trgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TargetMarket3Choice_? Target { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TargetMarket3Choice_? Target { get; init; } 
    #else
    public TargetMarket3Choice_? Target { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the target market and the investor type.
    /// </summary>
    [IsoId("_qDkL0TcSEeiIxKQErQxblg")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
