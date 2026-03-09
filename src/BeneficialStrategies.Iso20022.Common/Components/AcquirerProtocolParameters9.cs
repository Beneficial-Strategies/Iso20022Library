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
[IsoId("_CegvYY36EeWRwov1g9WL_A")]
[DisplayName("Acquirer Protocol Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcquirerProtocolParameters9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcquirerProtocolParameters9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcquirerProtocolParameters9( TerminalManagementAction3Code reqActionType,System.String reqVersion,System.String reqProtectCardData )
    {
        ActionType = reqActionType;
        Version = reqVersion;
        ProtectCardData = reqProtectCardData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_hBoTcI36EeWRwov1g9WL_A")]
    [DisplayName("Action Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActnTp")]
    #endif
    [IsoXmlTag("ActnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TerminalManagementAction3Code ActionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TerminalManagementAction3Code ActionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalManagementAction3Code ActionType { get; init; } 
    #else
    public TerminalManagementAction3Code ActionType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the acquirer using this protocol.
    /// </summary>
    [IsoId("_CpYioY36EeWRwov1g9WL_A")]
    [DisplayName("Acquirer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcqrrId")]
    #endif
    [IsoXmlTag("AcqrrId")]
    public ValueList<GenericIdentification53> AcquirerIdentification { get; init; } = new ValueList<GenericIdentification53>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _CpYioY36EeWRwov1g9WL_A
    
    /// <summary>
    /// Version of the acquirer protocol parameters.
    /// </summary>
    [IsoId("_CpYio436EeWRwov1g9WL_A")]
    [DisplayName("Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vrsn")]
    #endif
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax256Text Version { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Version { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Version { get; init; } 
    #else
    public System.String Version { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the payment application, user of the acquirer protocol.
    /// </summary>
    [IsoId("_CpYipY36EeWRwov1g9WL_A")]
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
    [IsoId("_CpYip436EeWRwov1g9WL_A")]
    [DisplayName("Host")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hst")]
    #endif
    [IsoXmlTag("Hst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AcquirerHostConfiguration3? Host { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcquirerHostConfiguration3? Host { get; init; } 
    #else
    public AcquirerHostConfiguration3? Host { get; set; } 
    #endif
    
    /// <summary>
    /// Acquirer protocol parameters of transactions performing an online authorisation.
    /// </summary>
    [IsoId("_CpYiqY36EeWRwov1g9WL_A")]
    [DisplayName("On Line Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OnLineTx")]
    #endif
    [IsoXmlTag("OnLineTx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AcquirerProtocolParameters8? OnLineTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcquirerProtocolParameters8? OnLineTransaction { get; init; } 
    #else
    public AcquirerProtocolParameters8? OnLineTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Acquirer protocol parameters of transactions performing an offline authorisation.
    /// </summary>
    [IsoId("_CpYiq436EeWRwov1g9WL_A")]
    [DisplayName("Off Line Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OffLineTx")]
    #endif
    [IsoXmlTag("OffLineTx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AcquirerProtocolParameters8? OffLineTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcquirerProtocolParameters8? OffLineTransaction { get; init; } 
    #else
    public AcquirerProtocolParameters8? OffLineTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Configuration parameters of reconciliation exchanges.
    /// </summary>
    [IsoId("_CpYirY36EeWRwov1g9WL_A")]
    [DisplayName("Reconciliation Exchange")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnXchg")]
    #endif
    [IsoXmlTag("RcncltnXchg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExchangeConfiguration6? ReconciliationExchange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExchangeConfiguration6? ReconciliationExchange { get; init; } 
    #else
    public ExchangeConfiguration6? ReconciliationExchange { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the reconciliation period is assigned by the acquirer instead of the acceptor.
    /// </summary>
    [IsoId("_CpYir436EeWRwov1g9WL_A")]
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
    [IsoId("_CpYisY36EeWRwov1g9WL_A")]
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
    /// Indicates that totals in reconciliation or batch must be split per group of points of interaction and card product profiles when these information are present in the transactions.
    /// </summary>
    [IsoId("_CpYis436EeWRwov1g9WL_A")]
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
    /// After an error in a totals of the Reconciliation, the POI sends transactions in error in the BatchTransfer messages.
    /// </summary>
    [IsoId("_8yJ0EI36EeWRwov1g9WL_A")]
    [DisplayName("Reconciliation Error")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnErr")]
    #endif
    [IsoXmlTag("RcncltnErr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ReconciliationError { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReconciliationError { get; init; } 
    #else
    public System.String? ReconciliationError { get; set; } 
    #endif
    
    /// <summary>
    /// True if the POI must send card data (protected or plain card data) in the AcceptorCompletionAdvice message following an authorisation exchange.
    /// </summary>
    [IsoId("_CpYitY36EeWRwov1g9WL_A")]
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
    [IsoId("_CpYit436EeWRwov1g9WL_A")]
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
    [IsoId("_CpYiuY36EeWRwov1g9WL_A")]
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
    /// BatchTransfer are exchanged per file transfer protocol rather than per message.
    /// </summary>
    [IsoId("_CpYiu436EeWRwov1g9WL_A")]
    [DisplayName("File Transfer Batch")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FileTrfBtch")]
    #endif
    [IsoXmlTag("FileTrfBtch")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? FileTransferBatch { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FileTransferBatch { get; init; } 
    #else
    public System.String? FileTransferBatch { get; set; } 
    #endif
    
    /// <summary>
    /// BatchTransfer are authenticated by digital signature rather than a MAC (Message Authentication Code).
    /// </summary>
    [IsoId("_CpYivY36EeWRwov1g9WL_A")]
    [DisplayName("Batch Digital Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BtchDgtlSgntr")]
    #endif
    [IsoXmlTag("BtchDgtlSgntr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? BatchDigitalSignature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BatchDigitalSignature { get; init; } 
    #else
    public System.String? BatchDigitalSignature { get; set; } 
    #endif
    
    /// <summary>
    /// Configuration of a message item.
    /// </summary>
    [IsoId("_CpYiv436EeWRwov1g9WL_A")]
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
    [IsoId("_CpYiwY36EeWRwov1g9WL_A")]
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
    
    /// <summary>
    /// A security trailer is mandatory in the messages.
    /// </summary>
    [IsoId("_9CGpsI38EeWRwov1g9WL_A")]
    [DisplayName("Mandatory Security Trailer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MndtrySctyTrlr")]
    #endif
    [IsoXmlTag("MndtrySctyTrlr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? MandatorySecurityTrailer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MandatorySecurityTrailer { get; init; } 
    #else
    public System.String? MandatorySecurityTrailer { get; set; } 
    #endif
    
    
    #nullable disable
    
}
