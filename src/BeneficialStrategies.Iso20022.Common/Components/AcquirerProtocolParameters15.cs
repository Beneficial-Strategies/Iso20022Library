// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor parameters dedicated to the acquirer protocol.
/// </summary>
[IsoId("_GgFNIVFMEeyApZmLzm74zA")]
[DisplayName("Acquirer Protocol Parameters")]
public record AcquirerProtocolParameters15
{
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_GmQGkVFMEeyApZmLzm74zA")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; }

    /// <summary>
    /// Identification of the acquirer using this protocol.
    /// </summary>
    [IsoId("_GmQGk1FMEeyApZmLzm74zA")]
    [DisplayName("Acquirer Identification")]
    [IsoXmlTag("AcqrrId")]
    public ValueList<GenericIdentification176> AcquirerIdentification { get; init; } = [];

    // ID for the above is _GmQGk1FMEeyApZmLzm74zA

    /// <summary>
    /// Version of the acquirer protocol parameters.
    /// </summary>
    [IsoId("_GmQGlVFMEeyApZmLzm74zA")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public required IsoMax256Text Version { get; init; }

    /// <summary>
    /// Identification of the payment application, user of the acquirer protocol.
    /// </summary>
    [IsoId("_GmQGl1FMEeyApZmLzm74zA")]
    [DisplayName("Application Identification")]
    [IsoXmlTag("ApplId")]
    public SimpleValueList<IsoMax35Text> ApplicationIdentification { get; init; } = [];

    /// <summary>
    /// Acquirer host configuration.
    /// </summary>
    [IsoId("_GmQGmVFMEeyApZmLzm74zA")]
    [DisplayName("Host")]
    [IsoXmlTag("Hst")]
    public ValueList<AcquirerHostConfiguration9> Host { get; init; } = [];

    /// <summary>
    /// Acquirer protocol parameters of transactions performing an online authorisation.
    /// </summary>
    [IsoId("_GmQGm1FMEeyApZmLzm74zA")]
    [DisplayName("On Line Transaction")]
    [IsoXmlTag("OnLineTx")]
    public AcquirerProtocolExchangeBehavior2? OnLineTransaction { get; init; }

    /// <summary>
    /// Acquirer protocol parameters of transactions performing an offline authorisation.
    /// </summary>
    [IsoId("_GmQGnVFMEeyApZmLzm74zA")]
    [DisplayName("Off Line Transaction")]
    [IsoXmlTag("OffLineTx")]
    public AcquirerProtocolExchangeBehavior2? OffLineTransaction { get; init; }

    /// <summary>
    /// Configuration parameters of reconciliation exchanges.
    /// </summary>
    [IsoId("_GmQGn1FMEeyApZmLzm74zA")]
    [DisplayName("Reconciliation Exchange")]
    [IsoXmlTag("RcncltnXchg")]
    public ExchangeConfiguration9? ReconciliationExchange { get; init; }

    /// <summary>
    /// Indicates the reconciliation period is assigned by the acquirer instead of the acceptor.
    /// </summary>
    [IsoId("_GmQGoVFMEeyApZmLzm74zA")]
    [DisplayName("Reconciliation By Acquirer")]
    [IsoXmlTag("RcncltnByAcqrr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReconciliationByAcquirer { get; init; }

    /// <summary>
    /// Indicates the reconciliation total amounts are computed per currency.
    /// </summary>
    [IsoId("_GmQGo1FMEeyApZmLzm74zA")]
    [DisplayName("Totals Per Currency")]
    [IsoXmlTag("TtlsPerCcy")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? TotalsPerCurrency { get; init; }

    /// <summary>
    /// Indicates that totals in reconciliation or batch must be split.
    /// </summary>
    [IsoId("_GmQGpVFMEeyApZmLzm74zA")]
    [DisplayName("Split Totals")]
    [IsoXmlTag("SpltTtls")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? SplitTotals { get; init; }

    /// <summary>
    /// List of criterion to use when totals in reconciliation or batch must be split.
    /// </summary>
    [IsoId("_GmQGp1FMEeyApZmLzm74zA")]
    [DisplayName("Split Total Criteria")]
    [IsoXmlTag("SpltTtlCrit")]
    public SimpleValueList<ReconciliationCriteria1Code> SplitTotalCriteria { get; init; } = [];

    /// <summary>
    /// To notify that the acquirer expect to receive a completion advice after each update of reservation.
    /// </summary>
    [IsoId("_GmQGqVFMEeyApZmLzm74zA")]
    [DisplayName("Completion Advice Mandated")]
    [IsoXmlTag("CmpltnAdvcMndtd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CompletionAdviceMandated { get; init; }

    /// <summary>
    /// Identification of available amount qualifier for a reservation.
    /// </summary>
    [IsoId("_GmQGq1FMEeyApZmLzm74zA")]
    [DisplayName("Amount Qualifier For Reservation")]
    [IsoXmlTag("AmtQlfrForRsvatn")]
    public SimpleValueList<TypeOfAmount8Code> AmountQualifierForReservation { get; init; } = [];

    /// <summary>
    /// After an error in a totals of the Reconciliation, the POI sends transactions in error in the BatchTransfer messages.
    /// </summary>
    [IsoId("_GmQGrVFMEeyApZmLzm74zA")]
    [DisplayName("Reconciliation Error")]
    [IsoXmlTag("RcncltnErr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReconciliationError { get; init; }

    /// <summary>
    /// Indicates whether the POI must send card data (protected or plain card data) in the AcceptorCompletionAdvice message following an authorisation exchange.
    /// </summary>
    [IsoId("_GmQGr1FMEeyApZmLzm74zA")]
    [DisplayName("Card Data Verification")]
    [IsoXmlTag("CardDataVrfctn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CardDataVerification { get; init; }

    /// <summary>
    /// Send a cancellation advice for offline transactions not yet captured.
    /// </summary>
    [IsoId("_GmQGsVFMEeyApZmLzm74zA")]
    [DisplayName("Notify Off Line Cancellation")]
    [IsoXmlTag("NtfyOffLineCxl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? NotifyOffLineCancellation { get; init; }

    /// <summary>
    /// Types of transaction to include in the batch.
    /// </summary>
    [IsoId("_GmQGs1FMEeyApZmLzm74zA")]
    [DisplayName("Batch Transfer Content")]
    [IsoXmlTag("BtchTrfCntt")]
    public SimpleValueList<BatchTransactionType1Code> BatchTransferContent { get; init; } = [];

    /// <summary>
    /// BatchTransfer are exchanged per file transfer protocol rather than per message.
    /// </summary>
    [IsoId("_GmQGtVFMEeyApZmLzm74zA")]
    [DisplayName("File Transfer Batch")]
    [IsoXmlTag("FileTrfBtch")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? FileTransferBatch { get; init; }

    /// <summary>
    /// BatchTransfer are authenticated by digital signature rather than a MAC (Message Authentication Code).
    /// </summary>
    [IsoId("_GmQGt1FMEeyApZmLzm74zA")]
    [DisplayName("Batch Digital Signature")]
    [IsoXmlTag("BtchDgtlSgntr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? BatchDigitalSignature { get; init; }

    /// <summary>
    /// Configuration of a message item.
    /// </summary>
    [IsoId("_GmQGuVFMEeyApZmLzm74zA")]
    [DisplayName("Message Item")]
    [IsoXmlTag("MsgItm")]
    public ValueList<MessageItemCondition1> MessageItem { get; init; } = [];

    /// <summary>
    /// Indicator to require protection of sensitive card data in messages.
    /// </summary>
    [IsoId("_GmQGu1FMEeyApZmLzm74zA")]
    [DisplayName("Protect Card Data")]
    [IsoXmlTag("PrtctCardData")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator ProtectCardData { get; init; }

    /// <summary>
    /// Indicator to require a private protection of sensitive card data in messages.
    /// </summary>
    [IsoId("_GmQGvVFMEeyApZmLzm74zA")]
    [DisplayName("Private Card Data")]
    [IsoXmlTag("PrvtCardData")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? PrivateCardData { get; init; }

    /// <summary>
    /// A security trailer is mandatory in the messages.
    /// </summary>
    [IsoId("_GmQGv1FMEeyApZmLzm74zA")]
    [DisplayName("Mandatory Security Trailer")]
    [IsoXmlTag("MndtrySctyTrlr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? MandatorySecurityTrailer { get; init; }
}
