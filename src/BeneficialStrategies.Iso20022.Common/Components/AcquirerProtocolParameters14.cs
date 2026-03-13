// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor parameters dedicated to the acquirer protocol.
/// </summary>
[IsoId("_hO02USpUEeuUucRY0yCMTA")]
[DisplayName("Acquirer Protocol Parameters")]
public partial record AcquirerProtocolParameters14
{
    #nullable enable
    
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_hgGMgSpUEeuUucRY0yCMTA")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; } 
    
    /// <summary>
    /// Identification of the acquirer using this protocol.
    /// </summary>
    [IsoId("_hgGMgypUEeuUucRY0yCMTA")]
    [DisplayName("Acquirer Identification")]
    [IsoXmlTag("AcqrrId")]
    public ValueList<GenericIdentification176> AcquirerIdentification { get; init; } = [];
    // ID for the above is _hgGMgypUEeuUucRY0yCMTA
    
    /// <summary>
    /// Version of the acquirer protocol parameters.
    /// </summary>
    [IsoId("_hgGMhSpUEeuUucRY0yCMTA")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public required IsoMax256Text Version { get; init; } 
    
    /// <summary>
    /// Identification of the payment application, user of the acquirer protocol.
    /// </summary>
    [IsoId("_hgGMhypUEeuUucRY0yCMTA")]
    [DisplayName("Application Identification")]
    [IsoXmlTag("ApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ApplicationIdentification { get; init; } 
    
    /// <summary>
    /// Acquirer host configuration.
    /// </summary>
    [IsoId("_hgGMiSpUEeuUucRY0yCMTA")]
    [DisplayName("Host")]
    [IsoXmlTag("Hst")]
    public AcquirerHostConfiguration8? Host { get; init; } 
    
    /// <summary>
    /// Acquirer protocol parameters of transactions performing an online authorisation.
    /// </summary>
    [IsoId("_hgGMiypUEeuUucRY0yCMTA")]
    [DisplayName("On Line Transaction")]
    [IsoXmlTag("OnLineTx")]
    public AcquirerProtocolExchangeBehavior2? OnLineTransaction { get; init; } 
    
    /// <summary>
    /// Acquirer protocol parameters of transactions performing an offline authorisation.
    /// </summary>
    [IsoId("_hgGMjSpUEeuUucRY0yCMTA")]
    [DisplayName("Off Line Transaction")]
    [IsoXmlTag("OffLineTx")]
    public AcquirerProtocolExchangeBehavior2? OffLineTransaction { get; init; } 
    
    /// <summary>
    /// Configuration parameters of reconciliation exchanges.
    /// </summary>
    [IsoId("_hgGMjypUEeuUucRY0yCMTA")]
    [DisplayName("Reconciliation Exchange")]
    [IsoXmlTag("RcncltnXchg")]
    public ExchangeConfiguration9? ReconciliationExchange { get; init; } 
    
    /// <summary>
    /// Indicates the reconciliation period is assigned by the acquirer instead of the acceptor.
    /// </summary>
    [IsoId("_hgGMkSpUEeuUucRY0yCMTA")]
    [DisplayName("Reconciliation By Acquirer")]
    [IsoXmlTag("RcncltnByAcqrr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReconciliationByAcquirer { get; init; } 
    
    /// <summary>
    /// Indicates the reconciliation total amounts are computed per currency.
    /// </summary>
    [IsoId("_hgGMkypUEeuUucRY0yCMTA")]
    [DisplayName("Totals Per Currency")]
    [IsoXmlTag("TtlsPerCcy")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? TotalsPerCurrency { get; init; } 
    
    /// <summary>
    /// Indicates that totals in reconciliation or batch must be split.
    /// </summary>
    [IsoId("_hgGMlSpUEeuUucRY0yCMTA")]
    [DisplayName("Split Totals")]
    [IsoXmlTag("SpltTtls")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? SplitTotals { get; init; } 
    
    /// <summary>
    /// List of criterion to use when totals in reconciliation or batch must be split.
    /// </summary>
    [IsoId("_R-Fv0CpXEeuUucRY0yCMTA")]
    [DisplayName("Split Total Criteria")]
    [IsoXmlTag("SpltTtlCrit")]
    public ReconciliationCriteria1Code? SplitTotalCriteria { get; init; } 
    
    /// <summary>
    /// To notify that the acquirer expect to receive a completion advice after each update of reservation.
    /// </summary>
    [IsoId("_TCxqgCpYEeuUucRY0yCMTA")]
    [DisplayName("Completion Advice Mandated")]
    [IsoXmlTag("CmpltnAdvcMndtd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CompletionAdviceMandated { get; init; } 
    
    /// <summary>
    /// Identification of available amount qualifier for a reservation. 
    /// </summary>
    [IsoId("_y4FZwCpZEeuUucRY0yCMTA")]
    [DisplayName("Amount Qualifier For Reservation")]
    [IsoXmlTag("AmtQlfrForRsvatn")]
    public TypeOfAmount8Code? AmountQualifierForReservation { get; init; } 
    
    /// <summary>
    /// After an error in a totals of the Reconciliation, the POI sends transactions in error in the BatchTransfer messages.
    /// </summary>
    [IsoId("_hgGMlypUEeuUucRY0yCMTA")]
    [DisplayName("Reconciliation Error")]
    [IsoXmlTag("RcncltnErr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReconciliationError { get; init; } 
    
    /// <summary>
    /// Indicates whether the POI must send card data (protected or plain card data) in the AcceptorCompletionAdvice message following an authorisation exchange.
    /// </summary>
    [IsoId("_hgGzkSpUEeuUucRY0yCMTA")]
    [DisplayName("Card Data Verification")]
    [IsoXmlTag("CardDataVrfctn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CardDataVerification { get; init; } 
    
    /// <summary>
    /// Send a cancellation advice for offline transactions not yet captured.
    /// </summary>
    [IsoId("_hgGzkypUEeuUucRY0yCMTA")]
    [DisplayName("Notify Off Line Cancellation")]
    [IsoXmlTag("NtfyOffLineCxl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? NotifyOffLineCancellation { get; init; } 
    
    /// <summary>
    /// Types of transaction to include in the batch.
    /// </summary>
    [IsoId("_hgGzlSpUEeuUucRY0yCMTA")]
    [DisplayName("Batch Transfer Content")]
    [IsoXmlTag("BtchTrfCntt")]
    public BatchTransactionType1Code? BatchTransferContent { get; init; } 
    
    /// <summary>
    /// BatchTransfer are exchanged per file transfer protocol rather than per message.
    /// </summary>
    [IsoId("_hgGzlypUEeuUucRY0yCMTA")]
    [DisplayName("File Transfer Batch")]
    [IsoXmlTag("FileTrfBtch")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? FileTransferBatch { get; init; } 
    
    /// <summary>
    /// BatchTransfer are authenticated by digital signature rather than a MAC (Message Authentication Code).
    /// </summary>
    [IsoId("_hgGzmSpUEeuUucRY0yCMTA")]
    [DisplayName("Batch Digital Signature")]
    [IsoXmlTag("BtchDgtlSgntr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? BatchDigitalSignature { get; init; } 
    
    /// <summary>
    /// Configuration of a message item.
    /// </summary>
    [IsoId("_hgGzmypUEeuUucRY0yCMTA")]
    [DisplayName("Message Item")]
    [IsoXmlTag("MsgItm")]
    public MessageItemCondition1? MessageItem { get; init; } 
    
    /// <summary>
    /// Indicator to require protection of sensitive card data in messages.
    /// </summary>
    [IsoId("_hgGznSpUEeuUucRY0yCMTA")]
    [DisplayName("Protect Card Data")]
    [IsoXmlTag("PrtctCardData")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator ProtectCardData { get; init; } 
    
    /// <summary>
    /// Indicator to require a private protection of sensitive card data in messages.
    /// </summary>
    [IsoId("_hgGznypUEeuUucRY0yCMTA")]
    [DisplayName("Private Card Data")]
    [IsoXmlTag("PrvtCardData")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? PrivateCardData { get; init; } 
    
    /// <summary>
    /// A security trailer is mandatory in the messages.
    /// </summary>
    [IsoId("_hgGzoSpUEeuUucRY0yCMTA")]
    [DisplayName("Mandatory Security Trailer")]
    [IsoXmlTag("MndtrySctyTrlr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? MandatorySecurityTrailer { get; init; } 
    
    
    #nullable disable
    
}
