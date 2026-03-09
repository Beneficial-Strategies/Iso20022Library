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
/// Year in which the ISA plan is issued.
/// </summary>
[IsoId("_3gXIVEXfEeGY6MkiuzuPOA_-1850431888")]
[DisplayName("ISA Years Of Issue")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ISAYearsOfIssue5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ISAYearsOfIssue5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ISAYearsOfIssue5( System.String reqCashComponentIndicator,SubscriptionInformation1 reqCurrentYearSubscriptionDetails )
    {
        CashComponentIndicator = reqCashComponentIndicator;
        CurrentYearSubscriptionDetails = reqCurrentYearSubscriptionDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// ISA that was issued during the current fiscal year.
    /// </summary>
    [IsoId("_3gXIVUXfEeGY6MkiuzuPOA_-1964270954")]
    [DisplayName("Current Year")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurYr")]
    #endif
    [IsoXmlTag("CurYr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrentYearType1Choice_? CurrentYear { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrentYearType1Choice_? CurrentYear { get; init; } 
    #else
    public CurrentYearType1Choice_? CurrentYear { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the ISA contains a cash component asset for transfer.
    /// </summary>
    [IsoId("_3gXIVkXfEeGY6MkiuzuPOA_336551636")]
    [DisplayName("Cash Component Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshCmpntInd")]
    #endif
    [IsoXmlTag("CshCmpntInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator CashComponentIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CashComponentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CashComponentIndicator { get; init; } 
    #else
    public System.String CashComponentIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Selection of investment plans issued during previous years.
    /// </summary>
    [IsoId("_3gg5UUXfEeGY6MkiuzuPOA_-1543754004")]
    [DisplayName("Previous Years")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsYrs")]
    #endif
    [IsoXmlTag("PrvsYrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PreviousYear3? PreviousYears { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PreviousYear3? PreviousYears { get; init; } 
    #else
    public PreviousYear3? PreviousYears { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the amounts already subscribed for the current year.
    /// </summary>
    [IsoId("_3gg5UEXfEeGY6MkiuzuPOA_-546681651")]
    [DisplayName("Current Year Subscription Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurYrSbcptDtls")]
    #endif
    [IsoXmlTag("CurYrSbcptDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SubscriptionInformation1 CurrentYearSubscriptionDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SubscriptionInformation1 CurrentYearSubscriptionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SubscriptionInformation1 CurrentYearSubscriptionDetails { get; init; } 
    #else
    public SubscriptionInformation1 CurrentYearSubscriptionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
