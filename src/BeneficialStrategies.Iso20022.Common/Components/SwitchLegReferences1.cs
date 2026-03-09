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
/// Information about a switch leg that is rejected or repaired.
/// </summary>
[IsoId("_RGg6Idp-Ed-ak6NoX_4Aeg_-513972542")]
[DisplayName("Switch Leg References")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SwitchLegReferences1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SwitchLegReferences1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SwitchLegReferences1( System.String reqRedemptionLegIdentification,System.String reqSubscriptionLegIdentification )
    {
        RedemptionLegIdentification = reqRedemptionLegIdentification;
        SubscriptionLegIdentification = reqSubscriptionLegIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique technical identifier for an instance of a leg within a switch.
    /// </summary>
    [IsoId("_RGg6Itp-Ed-ak6NoX_4Aeg_-325572706")]
    [DisplayName("Redemption Leg Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RedLegId")]
    #endif
    [IsoXmlTag("RedLegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text RedemptionLegIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RedemptionLegIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RedemptionLegIdentification { get; init; } 
    #else
    public System.String RedemptionLegIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique technical identifier for an instance of a leg within a switch.
    /// </summary>
    [IsoId("_RGg6I9p-Ed-ak6NoX_4Aeg_-371751546")]
    [DisplayName("Subscription Leg Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbcptLegId")]
    #endif
    [IsoXmlTag("SbcptLegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text SubscriptionLegIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SubscriptionLegIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SubscriptionLegIdentification { get; init; } 
    #else
    public System.String SubscriptionLegIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the reason for the rejection of a leg.
    /// </summary>
    [IsoId("_RGg6JNp-Ed-ak6NoX_4Aeg_17053572")]
    [DisplayName("Leg Rejection Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LegRjctnRsn")]
    #endif
    [IsoXmlTag("LegRjctnRsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? LegRejectionReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LegRejectionReason { get; init; } 
    #else
    public System.String? LegRejectionReason { get; set; } 
    #endif
    
    /// <summary>
    /// Elements from the original switch order that have been repaired so that the switch order can be accepted.
    /// </summary>
    [IsoId("_RGg6Jdp-Ed-ak6NoX_4Aeg_1991932087")]
    [DisplayName("Repaired Conditions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RprdConds")]
    #endif
    [IsoXmlTag("RprdConds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RepairedConditions3? RepairedConditions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RepairedConditions3? RepairedConditions { get; init; } 
    #else
    public RepairedConditions3? RepairedConditions { get; set; } 
    #endif
    
    /// <summary>
    /// Account identification of the switch leg that is rejected or repaired.
    /// </summary>
    [IsoId("_RGg6Jtp-Ed-ak6NoX_4Aeg_1676085552")]
    [DisplayName("Investment Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcctDtls")]
    #endif
    [IsoXmlTag("InvstmtAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccount13? InvestmentAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount13? InvestmentAccountDetails { get; init; } 
    #else
    public InvestmentAccount13? InvestmentAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Financial instrument identification of the switch leg that is rejected or repaired.
    /// </summary>
    [IsoId("_RGg6J9p-Ed-ak6NoX_4Aeg_1674239005")]
    [DisplayName("Financial Instrument Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmDtls")]
    #endif
    [IsoXmlTag("FinInstrmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrument10? FinancialInstrumentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument10? FinancialInstrumentDetails { get; init; } 
    #else
    public FinancialInstrument10? FinancialInstrumentDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
