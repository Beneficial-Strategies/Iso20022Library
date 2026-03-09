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
/// Context of the card transaction.
/// </summary>
[IsoId("_q3WpQHsHEeSR68OJvMfxJQ")]
[DisplayName("Card Transaction Context")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardTransactionContext2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardTransactionContext2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardTransactionContext2( CardDataReading2Code reqCardDataEntryMode )
    {
        CardDataEntryMode = reqCardDataEntryMode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the transaction has been initiated by a card physically present or not. 
    /// It correspond to the ISO 8583: 1993 field number 22-6.
    /// </summary>
    [IsoId("_1Z6pEHsHEeSR68OJvMfxJQ")]
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
    /// It correspond to the ISO 8583: 1993 field number 22-5.
    /// </summary>
    [IsoId("_Cx2TgHsIEeSR68OJvMfxJQ")]
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
    /// Location category of the place where the transaction is actually performed. 
    /// It correspond partially to the ISO 8583: 1993 field number 22-4.
    /// </summary>
    [IsoId("_RHwCEHsIEeSR68OJvMfxJQ")]
    [DisplayName("Location Category")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LctnCtgy")]
    #endif
    [IsoXmlTag("LctnCtgy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LocationCategory2Code? LocationCategory { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LocationCategory2Code? LocationCategory { get; init; } 
    #else
    public LocationCategory2Code? LocationCategory { get; set; } 
    #endif
    
    /// <summary>
    /// Human attendance at the terminal location during the transaction. 
    /// It correspond partially to the ISO 8583: 1993 field number 22-4.
    /// </summary>
    [IsoId("_Xy5EYHsIEeSR68OJvMfxJQ")]
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
    [IsoId("_jdKTIHsIEeSR68OJvMfxJQ")]
    [DisplayName("Transaction Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxEnvt")]
    #endif
    [IsoXmlTag("TxEnvt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionEnvironment2Code? TransactionEnvironment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionEnvironment2Code? TransactionEnvironment { get; init; } 
    #else
    public TransactionEnvironment2Code? TransactionEnvironment { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the entity hosting the terminal performing the transaction. 
    /// It correspond partially to the ISO 8583: 1993 field number 22-4.
    /// </summary>
    [IsoId("_PNJhIHsJEeSR68OJvMfxJQ")]
    [DisplayName("Hosting Category")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HstgCtgy")]
    #endif
    [IsoXmlTag("HstgCtgy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionEnvironment3Code? HostingCategory { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionEnvironment3Code? HostingCategory { get; init; } 
    #else
    public TransactionEnvironment3Code? HostingCategory { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the type of the communication channels used by the cardholder to the acceptor system. 
    /// It correspond to the ISO 8583: 1993 field number 22-5.
    /// </summary>
    [IsoId("_aAfu8HsJEeSR68OJvMfxJQ")]
    [DisplayName("Transaction Channel")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxChanl")]
    #endif
    [IsoXmlTag("TxChanl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionChannel3Code? TransactionChannel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionChannel3Code? TransactionChannel { get; init; } 
    #else
    public TransactionChannel3Code? TransactionChannel { get; set; } 
    #endif
    
    /// <summary>
    /// Entry mode of the card data. 
    /// It correspond to the ISO 8583 field number 25 for the version 87 (partially), field number 22-7 for the version 93, and field number 22-1 for the version 2003.
    /// </summary>
    [IsoId("_fJ-KMHsJEeSR68OJvMfxJQ")]
    [DisplayName("Card Data Entry Mode")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardDataNtryMd")]
    #endif
    [IsoXmlTag("CardDataNtryMd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardDataReading2Code CardDataEntryMode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardDataReading2Code CardDataEntryMode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardDataReading2Code CardDataEntryMode { get; init; } 
    #else
    public CardDataReading2Code CardDataEntryMode { get; set; } 
    #endif
    
    /// <summary>
    /// Indicator of a card entry mode fall-back. It correspond to the ISO 8583: 2003 field number 22-1.
    /// </summary>
    [IsoId("_k-fGgHsJEeSR68OJvMfxJQ")]
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
    [IsoId("_tOOvIHsJEeSR68OJvMfxJQ")]
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
    
    /// <summary>
    /// Data used to assign specific condition such as liability shift or preferential interchange fees.
    /// </summary>
    [IsoId("_-BLu8HsJEeSR68OJvMfxJQ")]
    [DisplayName("Special Conditions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpclConds")]
    #endif
    [IsoXmlTag("SpclConds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardTransactionCondition1? SpecialConditions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardTransactionCondition1? SpecialConditions { get; init; } 
    #else
    public CardTransactionCondition1? SpecialConditions { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates to the issuer the level of risk of the transaction.
    /// </summary>
    [IsoId("_vLIrQHsKEeSR68OJvMfxJQ")]
    [DisplayName("Risk Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RskInd")]
    #endif
    [IsoXmlTag("RskInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardTransactionRiskIndicator1? RiskIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardTransactionRiskIndicator1? RiskIndicator { get; init; } 
    #else
    public CardTransactionRiskIndicator1? RiskIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
