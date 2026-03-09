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
/// Acceptor parameters dedicated to the acquirer protocol.
/// </summary>
[IsoId("_khp2MTZ4EeOP_KvUKe29ng")]
[DisplayName("Acquirer Protocol Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcquirerProtocolParameters6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcquirerProtocolParameters6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcquirerProtocolParameters6( System.String reqProtectCardData )
    {
        ProtectCardData = reqProtectCardData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the acquirer using this protocol.
    /// </summary>
    [IsoId("_kzSYwTZ4EeOP_KvUKe29ng")]
    [DisplayName("Acquirer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcqrrId")]
    #endif
    [IsoXmlTag("AcqrrId")]
    public ValueList<GenericIdentification32> AcquirerIdentification { get; init; } = new ValueList<GenericIdentification32>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _kzSYwTZ4EeOP_KvUKe29ng
    
    /// <summary>
    /// Identification of the payment application, user of the acquirer protocol.
    /// </summary>
    [IsoId("_kzSYwzZ4EeOP_KvUKe29ng")]
    [DisplayName("Application Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApplId")]
    #endif
    [IsoXmlTag("ApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ApplicationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ApplicationIdentification { get; init; } 
    #else
    public System.String? ApplicationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Acquirer host configuration.
    /// </summary>
    [IsoId("_kzSYxTZ4EeOP_KvUKe29ng")]
    [DisplayName("Host")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hst")]
    #endif
    [IsoXmlTag("Hst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AcquirerHostConfiguration2? Host { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcquirerHostConfiguration2? Host { get; init; } 
    #else
    public AcquirerHostConfiguration2? Host { get; set; } 
    #endif
    
    /// <summary>
    /// Acquirer protocol parameters of transactions performing an online authorisation.
    /// </summary>
    [IsoId("_kzSYxzZ4EeOP_KvUKe29ng")]
    [DisplayName("On Line Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OnLineTx")]
    #endif
    [IsoXmlTag("OnLineTx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AcquirerProtocolParameters5? OnLineTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcquirerProtocolParameters5? OnLineTransaction { get; init; } 
    #else
    public AcquirerProtocolParameters5? OnLineTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Acquirer protocol parameters of transactions performing an offline authorisation.
    /// </summary>
    [IsoId("_kzSYyTZ4EeOP_KvUKe29ng")]
    [DisplayName("Off Line Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OffLineTx")]
    #endif
    [IsoXmlTag("OffLineTx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AcquirerProtocolParameters5? OffLineTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcquirerProtocolParameters5? OffLineTransaction { get; init; } 
    #else
    public AcquirerProtocolParameters5? OffLineTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Configuration parameters of reconciliation exchanges.
    /// </summary>
    [IsoId("_kzSYyzZ4EeOP_KvUKe29ng")]
    [DisplayName("Reconciliation Exchange")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnXchg")]
    #endif
    [IsoXmlTag("RcncltnXchg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExchangeConfiguration4? ReconciliationExchange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExchangeConfiguration4? ReconciliationExchange { get; init; } 
    #else
    public ExchangeConfiguration4? ReconciliationExchange { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the reconciliation period is assigned by the acquirer instead of the acceptor.
    /// </summary>
    [IsoId("_kzSYzTZ4EeOP_KvUKe29ng")]
    [DisplayName("Reconciliation By Acquirer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnByAcqrr")]
    #endif
    [IsoXmlTag("RcncltnByAcqrr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ReconciliationByAcquirer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReconciliationByAcquirer { get; init; } 
    #else
    public System.String? ReconciliationByAcquirer { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the reconciliation total amounts are computed per currency.
    /// </summary>
    [IsoId("_kzSYzzZ4EeOP_KvUKe29ng")]
    [DisplayName("Totals Per Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlsPerCcy")]
    #endif
    [IsoXmlTag("TtlsPerCcy")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? TotalsPerCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TotalsPerCurrency { get; init; } 
    #else
    public System.String? TotalsPerCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that totals in reconciliation or batch must be split per group of points of interaction and card product profiles when these informations are present in the transactions.
    /// </summary>
    [IsoId("_kzSY0TZ4EeOP_KvUKe29ng")]
    [DisplayName("Split Totals")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpltTtls")]
    #endif
    [IsoXmlTag("SpltTtls")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? SplitTotals { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SplitTotals { get; init; } 
    #else
    public System.String? SplitTotals { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that response messages and an AcceptorCompletionAdvice message following an authorisation exchange must contain protected or plain card data.
    /// </summary>
    [IsoId("_kzSY0zZ4EeOP_KvUKe29ng")]
    [DisplayName("Card Data Verification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardDataVrfctn")]
    #endif
    [IsoXmlTag("CardDataVrfctn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? CardDataVerification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardDataVerification { get; init; } 
    #else
    public System.String? CardDataVerification { get; set; } 
    #endif
    
    /// <summary>
    /// Send a cancellation advice for offline transactions not yet captured.
    /// </summary>
    [IsoId("_iLDVwDZ5EeOP_KvUKe29ng")]
    [DisplayName("Notify Off Line Cancellation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfyOffLineCxl")]
    #endif
    [IsoXmlTag("NtfyOffLineCxl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? NotifyOffLineCancellation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NotifyOffLineCancellation { get; init; } 
    #else
    public System.String? NotifyOffLineCancellation { get; set; } 
    #endif
    
    /// <summary>
    /// Types of transaction to include in the batch.
    /// </summary>
    [IsoId("_kzSY1TZ4EeOP_KvUKe29ng")]
    [DisplayName("Batch Transfer Content")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BtchTrfCntt")]
    #endif
    [IsoXmlTag("BtchTrfCntt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BatchTransactionType1Code? BatchTransferContent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BatchTransactionType1Code? BatchTransferContent { get; init; } 
    #else
    public BatchTransactionType1Code? BatchTransferContent { get; set; } 
    #endif
    
    /// <summary>
    /// Configuration of a message item.
    /// </summary>
    [IsoId("_kzSY1zZ4EeOP_KvUKe29ng")]
    [DisplayName("Message Item")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgItm")]
    #endif
    [IsoXmlTag("MsgItm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MessageItemCondition1? MessageItem { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageItemCondition1? MessageItem { get; init; } 
    #else
    public MessageItemCondition1? MessageItem { get; set; } 
    #endif
    
    /// <summary>
    /// Indicator to require protection of sensitive card data in messages.
    /// </summary>
    [IsoId("_kzSY2TZ4EeOP_KvUKe29ng")]
    [DisplayName("Protect Card Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctCardData")]
    #endif
    [IsoXmlTag("PrtctCardData")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator ProtectCardData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ProtectCardData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ProtectCardData { get; init; } 
    #else
    public System.String ProtectCardData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
