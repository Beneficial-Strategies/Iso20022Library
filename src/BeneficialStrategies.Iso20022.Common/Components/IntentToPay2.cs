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
/// Specifies the details of an intention to pay based on purchase orders or commercial invoice.
/// </summary>
[IsoId("_9-CfYRVaEeOCqpkCrPgk4g")]
[DisplayName("Intent To Pay")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IntentToPay2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IntentToPay2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IntentToPay2( BreakDown1Choice_ reqBreakdown,System.DateOnly reqExpectedPaymentDate )
    {
        Breakdown = reqBreakdown;
        ExpectedPaymentDate = reqExpectedPaymentDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies if breakdown is by purchase order or commercial invoice.
    /// </summary>
    [IsoId("_Hn3ngBrZEeOVR9VN6fAMUg")]
    [DisplayName("Breakdown")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Brkdwn")]
    #endif
    [IsoXmlTag("Brkdwn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BreakDown1Choice_ Breakdown { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BreakDown1Choice_ Breakdown { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BreakDown1Choice_ Breakdown { get; init; } 
    #else
    public BreakDown1Choice_ Breakdown { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the payment would be effected.
    /// </summary>
    [IsoId("_-X0RVxVaEeOCqpkCrPgk4g")]
    [DisplayName("Expected Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpctdPmtDt")]
    #endif
    [IsoXmlTag("XpctdPmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ExpectedPaymentDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ExpectedPaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ExpectedPaymentDate { get; init; } 
    #else
    public System.DateOnly ExpectedPaymentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the beneficiary&apos;s account information.
    /// </summary>
    [IsoId("_-X0RWRVaEeOCqpkCrPgk4g")]
    [DisplayName("Settlement Terms")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmTerms")]
    #endif
    [IsoXmlTag("SttlmTerms")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementTerms3? SettlementTerms { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTerms3? SettlementTerms { get; init; } 
    #else
    public SettlementTerms3? SettlementTerms { get; set; } 
    #endif
    
    
    #nullable disable
    
}
