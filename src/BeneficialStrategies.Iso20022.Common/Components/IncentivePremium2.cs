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
/// Cash premium made available if the securities holder consents or participates to an event.
/// </summary>
[IsoId("_TjIGjtp-Ed-ak6NoX_4Aeg_-593608139")]
[DisplayName("Incentive Premium")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IncentivePremium2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IncentivePremium2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IncentivePremium2( PriceRateOrAmountChoice_ reqAmount,System.UInt64 reqPerSecurity,System.UInt64 reqPerVote,System.String reqPerAttendee )
    {
        Amount = reqAmount;
        PerSecurity = reqPerSecurity;
        PerVote = reqPerVote;
        PerAttendee = reqPerAttendee;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Description of the premium.
    /// </summary>
    [IsoId("_TjR3gNp-Ed-ak6NoX_4Aeg_-593607912")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Description { get; init; } 
    #else
    public System.String? Description { get; set; } 
    #endif
    
    /// <summary>
    /// Cash premium paid per security, per vote or per attendee.
    /// </summary>
    [IsoId("_TjR3gdp-Ed-ak6NoX_4Aeg_-593607904")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PriceRateOrAmountChoice_ Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PriceRateOrAmountChoice_ Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceRateOrAmountChoice_ Amount { get; init; } 
    #else
    public PriceRateOrAmountChoice_ Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Number of securities giving right to a premium.
    /// </summary>
    [IsoId("_TjR3gtp-Ed-ak6NoX_4Aeg_-593607879")]
    [DisplayName("Per Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PerScty")]
    #endif
    [IsoXmlTag("PerScty")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber PerSecurity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 PerSecurity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 PerSecurity { get; init; } 
    #else
    public System.UInt64 PerSecurity { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes giving right to a premium.
    /// </summary>
    [IsoId("_TjR3g9p-Ed-ak6NoX_4Aeg_-593607844")]
    [DisplayName("Per Vote")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PerVote")]
    #endif
    [IsoXmlTag("PerVote")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber PerVote { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 PerVote { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 PerVote { get; init; } 
    #else
    public System.UInt64 PerVote { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that the premium is given per attendee.
    /// </summary>
    [IsoId("_TjR3hNp-Ed-ak6NoX_4Aeg_-593607819")]
    [DisplayName("Per Attendee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PerAttndee")]
    #endif
    [IsoXmlTag("PerAttndee")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator PerAttendee { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PerAttendee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PerAttendee { get; init; } 
    #else
    public System.String PerAttendee { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time for the payment of the premium.
    /// </summary>
    [IsoId("_TjR3hdp-Ed-ak6NoX_4Aeg_-593607802")]
    [DisplayName("Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtDt")]
    #endif
    [IsoXmlTag("PmtDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat3Choice_? PaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat3Choice_? PaymentDate { get; init; } 
    #else
    public DateFormat3Choice_? PaymentDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
