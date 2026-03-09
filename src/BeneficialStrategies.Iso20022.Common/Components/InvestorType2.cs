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
/// Investor for which a financial instrument is targeted.
/// </summary>
[IsoId("_Si1WsbSaEeq-6ssAXwSh-g")]
[DisplayName("Investor Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestorType2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the product is aimed at the retail investor. If neutral, the manufacturer estimates that there is neither a negative nor a positive target market. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 01010.
    /// </summary>
    [IsoId("_S3OSUbSaEeq-6ssAXwSh-g")]
    [DisplayName("Investor Type Retail")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstrTpRtl")]
    #endif
    [IsoXmlTag("InvstrTpRtl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TargetMarket1Code? InvestorTypeRetail { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TargetMarket1Code? InvestorTypeRetail { get; init; } 
    #else
    public TargetMarket1Code? InvestorTypeRetail { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how the product is aimed at the professional investor. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 01020.
    /// </summary>
    [IsoId("_S3OSU7SaEeq-6ssAXwSh-g")]
    [DisplayName("Investor Type Professional")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstrTpPrfssnl")]
    #endif
    [IsoXmlTag("InvstrTpPrfssnl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TargetMarket5Choice_? InvestorTypeProfessional { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TargetMarket5Choice_? InvestorTypeProfessional { get; init; } 
    #else
    public TargetMarket5Choice_? InvestorTypeProfessional { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the product is aimed at the eligible counterparty. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 01030.
    /// </summary>
    [IsoId("_S3OSVbSaEeq-6ssAXwSh-g")]
    [DisplayName("Investor Type Eligible Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstrTpElgblCtrPty")]
    #endif
    [IsoXmlTag("InvstrTpElgblCtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TargetMarket3Code? InvestorTypeEligibleCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TargetMarket3Code? InvestorTypeEligibleCounterparty { get; init; } 
    #else
    public TargetMarket3Code? InvestorTypeEligibleCounterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies another investor type.
    /// </summary>
    [IsoId("_S3OSV7SaEeq-6ssAXwSh-g")]
    [DisplayName("Other")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Othr")]
    #endif
    [IsoXmlTag("Othr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherTargetMarketInvestor1? Other { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherTargetMarketInvestor1? Other { get; init; } 
    #else
    public OtherTargetMarketInvestor1? Other { get; set; } 
    #endif
    
    
    #nullable disable
    
}
