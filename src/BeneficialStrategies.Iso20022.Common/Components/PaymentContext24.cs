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
/// Payment context in which the transaction is performed.
/// </summary>
[IsoId("_EOAe0bDIEeaW-9Sj0pzN5A")]
[DisplayName("Payment Context")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentContext24
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the transaction has been initiated by a card physically present or not.
    /// </summary>
    [IsoId("_EZGUgbDIEeaW-9Sj0pzN5A")]
    [DisplayName("Card Present")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardPres")]
    #endif
    [IsoXmlTag("CardPres")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? CardPresent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardPresent { get; init; } 
    #else
    public System.String? CardPresent { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the transaction has been initiated in presence of the cardholder or not.
    /// </summary>
    [IsoId("_EZGUg7DIEeaW-9Sj0pzN5A")]
    [DisplayName("Cardholder Present")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrPres")]
    #endif
    [IsoXmlTag("CrdhldrPres")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? CardholderPresent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardholderPresent { get; init; } 
    #else
    public System.String? CardholderPresent { get; set; } 
    #endif
    
    /// <summary>
    /// On-line or off-line context of the transaction.
    /// </summary>
    [IsoId("_EZGUhbDIEeaW-9Sj0pzN5A")]
    [DisplayName("On Line Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OnLineCntxt")]
    #endif
    [IsoXmlTag("OnLineCntxt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? OnLineContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OnLineContext { get; init; } 
    #else
    public System.String? OnLineContext { get; set; } 
    #endif
    
    /// <summary>
    /// Human attendance at the POI (Point Of Interaction) location during the transaction.
    /// </summary>
    [IsoId("_EZGUh7DIEeaW-9Sj0pzN5A")]
    [DisplayName("Attendance Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AttndncCntxt")]
    #endif
    [IsoXmlTag("AttndncCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AttendanceContext1Code? AttendanceContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AttendanceContext1Code? AttendanceContext { get; init; } 
    #else
    public AttendanceContext1Code? AttendanceContext { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the environment of the transaction.
    /// </summary>
    [IsoId("_EZGUibDIEeaW-9Sj0pzN5A")]
    [DisplayName("Transaction Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxEnvt")]
    #endif
    [IsoXmlTag("TxEnvt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionEnvironment1Code? TransactionEnvironment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionEnvironment1Code? TransactionEnvironment { get; init; } 
    #else
    public TransactionEnvironment1Code? TransactionEnvironment { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the type of the communication channels used by the cardholder to the acceptor system.
    /// </summary>
    [IsoId("_EZGUi7DIEeaW-9Sj0pzN5A")]
    [DisplayName("Transaction Channel")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxChanl")]
    #endif
    [IsoXmlTag("TxChanl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionChannel5Code? TransactionChannel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionChannel5Code? TransactionChannel { get; init; } 
    #else
    public TransactionChannel5Code? TransactionChannel { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether a message can be sent or not on an attendant display (attendant display present or not).
    /// </summary>
    [IsoId("_EZGUjbDIEeaW-9Sj0pzN5A")]
    [DisplayName("Attendant Message Capable")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AttndntMsgCpbl")]
    #endif
    [IsoXmlTag("AttndntMsgCpbl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? AttendantMessageCapable { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AttendantMessageCapable { get; init; } 
    #else
    public System.String? AttendantMessageCapable { get; set; } 
    #endif
    
    /// <summary>
    /// Language used to display messages to the attendant.
    /// Reference ISO 639-1 (alpha-2) et ISO 639-2 (alpha-3).
    /// </summary>
    [IsoId("_EZGUj7DIEeaW-9Sj0pzN5A")]
    [DisplayName("Attendant Language")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AttndntLang")]
    #endif
    [IsoXmlTag("AttndntLang")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LanguageCode? AttendantLanguage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? AttendantLanguage { get; init; } 
    #else
    public string? AttendantLanguage { get; set; } 
    #endif
    
    /// <summary>
    /// Entry mode of the card data.
    /// </summary>
    [IsoId("_EZGUkbDIEeaW-9Sj0pzN5A")]
    [DisplayName("Card Data Entry Mode")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardDataNtryMd")]
    #endif
    [IsoXmlTag("CardDataNtryMd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardDataReading5Code? CardDataEntryMode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardDataReading5Code? CardDataEntryMode { get; init; } 
    #else
    public CardDataReading5Code? CardDataEntryMode { get; set; } 
    #endif
    
    /// <summary>
    /// Indicator of a card entry mode fallback.
    /// </summary>
    [IsoId("_EZGUk7DIEeaW-9Sj0pzN5A")]
    [DisplayName("Fallback Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FllbckInd")]
    #endif
    [IsoXmlTag("FllbckInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardFallback1Code? FallbackIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardFallback1Code? FallbackIndicator { get; init; } 
    #else
    public CardFallback1Code? FallbackIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Payment options the card acceptor can support.
    /// </summary>
    [IsoId("_EZG7kbDIEeaW-9Sj0pzN5A")]
    [DisplayName("Supported Option")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpprtdOptn")]
    #endif
    [IsoXmlTag("SpprtdOptn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupportedPaymentOption1Code? SupportedOption { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupportedPaymentOption1Code? SupportedOption { get; init; } 
    #else
    public SupportedPaymentOption1Code? SupportedOption { get; set; } 
    #endif
    
    
    #nullable disable
    
}
