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
/// Specifies information about the letter of intent.
/// </summary>
[IsoId("_QXVWcxKHEeKj15WxqwlXPw")]
[DisplayName("Letter Intent")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LetterIntent1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LetterIntent1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LetterIntent1( System.String reqLetterIntentReference )
    {
        LetterIntentReference = reqLetterIntentReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference of a letter of intent program, in which sales commissions are reduced based on the aggregate of a customer&apos;s actual purchase and anticipated purchases, over a specific period of time, and as agreed by the customer.
    /// </summary>
    [IsoId("_iqLbsBKHEeKj15WxqwlXPw")]
    [DisplayName("Letter Intent Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LttrInttRef")]
    #endif
    [IsoXmlTag("LttrInttRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text LetterIntentReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String LetterIntentReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String LetterIntentReference { get; init; } 
    #else
    public System.String LetterIntentReference { get; set; } 
    #endif
    
    /// <summary>
    /// Amount stated on the letter of intent.
    /// </summary>
    [IsoId("_vuVOgBKHEeKj15WxqwlXPw")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd13DecimalAmount? Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount? Amount { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount? Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Start date stated on the letter of intent.
    /// </summary>
    [IsoId("_3Jsz4BKHEeKj15WxqwlXPw")]
    [DisplayName("Start Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartDt")]
    #endif
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? StartDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? StartDate { get; init; } 
    #else
    public System.DateOnly? StartDate { get; set; } 
    #endif
    
    /// <summary>
    /// End date stated on the letter of intent.
    /// </summary>
    [IsoId("_-X9KUBKHEeKj15WxqwlXPw")]
    [DisplayName("End Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndDt")]
    #endif
    [IsoXmlTag("EndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? EndDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? EndDate { get; init; } 
    #else
    public System.DateOnly? EndDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
