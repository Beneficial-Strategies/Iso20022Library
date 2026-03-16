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
[IsoId("_IeZq4dX2Eeia9rtBTv_9KA")]
[DisplayName("Acquirer Protocol Parameters")]
public record AcquirerProtocolParameters12
{
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_IoCIAdX2Eeia9rtBTv_9KA")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; }

    /// <summary>
    /// Identification of the acquirer using this protocol.
    /// </summary>
    [IsoId("_IoCIA9X2Eeia9rtBTv_9KA")]
    [DisplayName("Acquirer Identification")]
    [IsoXmlTag("AcqrrId")]
    public ValueList<GenericIdentification53> AcquirerIdentification { get; init; } = [];

    // ID for the above is _IoCIA9X2Eeia9rtBTv_9KA

    /// <summary>
    /// Version of the acquirer protocol parameters.
    /// </summary>
    [IsoId("_IoCIBdX2Eeia9rtBTv_9KA")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public required IsoMax256Text Version { get; init; }

    /// <summary>
    /// Identification of the payment application, user of the acquirer protocol.
    /// </summary>
    [IsoId("_IoCIB9X2Eeia9rtBTv_9KA")]
    [DisplayName("Application Identification")]
    [IsoXmlTag("ApplId")]
    public SimpleValueList<IsoMax35Text> ApplicationIdentification { get; init; } = [];

    /// <summary>
    /// Acquirer host configuration.
    /// </summary>
    [IsoId("_IoCICdX2Eeia9rtBTv_9KA")]
    [DisplayName("Host")]
    [IsoXmlTag("Hst")]
    public ValueList<AcquirerHostConfiguration6> Host { get; init; } = [];

    /// <summary>
    /// Acquirer protocol parameters of transactions performing an online authorisation.
    /// </summary>
    [IsoId("_IoCIC9X2Eeia9rtBTv_9KA")]
    [DisplayName("On Line Transaction")]
    [IsoXmlTag("OnLineTx")]
    public AcquirerProtocolParameters8? OnLineTransaction { get; init; }

    /// <summary>
    /// Acquirer protocol parameters of transactions performing an offline authorisation.
    /// </summary>
    [IsoId("_IoCIDdX2Eeia9rtBTv_9KA")]
    [DisplayName("Off Line Transaction")]
    [IsoXmlTag("OffLineTx")]
    public AcquirerProtocolParameters8? OffLineTransaction { get; init; }

    /// <summary>
    /// Configuration parameters of reconciliation exchanges.
    /// </summary>
    [IsoId("_IoCID9X2Eeia9rtBTv_9KA")]
    [DisplayName("Reconciliation Exchange")]
    [IsoXmlTag("RcncltnXchg")]
    public ExchangeConfiguration6? ReconciliationExchange { get; init; }

    /// <summary>
    /// Indicates the reconciliation period is assigned by the acquirer instead of the acceptor.
    /// </summary>
    [IsoId("_IoCIEdX2Eeia9rtBTv_9KA")]
    [DisplayName("Reconciliation By Acquirer")]
    [IsoXmlTag("RcncltnByAcqrr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReconciliationByAcquirer { get; init; }

    /// <summary>
    /// Indicates the reconciliation total amounts are computed per currency.
    /// </summary>
    [IsoId("_IoCIE9X2Eeia9rtBTv_9KA")]
    [DisplayName("Totals Per Currency")]
    [IsoXmlTag("TtlsPerCcy")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? TotalsPerCurrency { get; init; }

    /// <summary>
    /// Indicates that totals in reconciliation or batch must be split per group of points of interaction and card product profiles when these information are present in the transactions.
    /// </summary>
    [IsoId("_IoCIFdX2Eeia9rtBTv_9KA")]
    [DisplayName("Split Totals")]
    [IsoXmlTag("SpltTtls")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? SplitTotals { get; init; }

    /// <summary>
    /// After an error in a totals of the Reconciliation, the POI sends transactions in error in the BatchTransfer messages.
    /// </summary>
    [IsoId("_IoCIF9X2Eeia9rtBTv_9KA")]
    [DisplayName("Reconciliation Error")]
    [IsoXmlTag("RcncltnErr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReconciliationError { get; init; }

    /// <summary>
    /// Indicates whether the POI must send card data (protected or plain card data) in the AcceptorCompletionAdvice message following an authorisation exchange.
    /// </summary>
    [IsoId("_IoCIGdX2Eeia9rtBTv_9KA")]
    [DisplayName("Card Data Verification")]
    [IsoXmlTag("CardDataVrfctn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CardDataVerification { get; init; }

    /// <summary>
    /// Send a cancellation advice for offline transactions not yet captured.
    /// </summary>
    [IsoId("_IoCIG9X2Eeia9rtBTv_9KA")]
    [DisplayName("Notify Off Line Cancellation")]
    [IsoXmlTag("NtfyOffLineCxl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? NotifyOffLineCancellation { get; init; }

    /// <summary>
    /// Types of transaction to include in the batch.
    /// </summary>
    [IsoId("_IoCIHdX2Eeia9rtBTv_9KA")]
    [DisplayName("Batch Transfer Content")]
    [IsoXmlTag("BtchTrfCntt")]
    public SimpleValueList<BatchTransactionType1Code> BatchTransferContent { get; init; } = [];

    /// <summary>
    /// BatchTransfer are exchanged per file transfer protocol rather than per message.
    /// </summary>
    [IsoId("_IoCIH9X2Eeia9rtBTv_9KA")]
    [DisplayName("File Transfer Batch")]
    [IsoXmlTag("FileTrfBtch")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? FileTransferBatch { get; init; }

    /// <summary>
    /// BatchTransfer are authenticated by digital signature rather than a MAC (Message Authentication Code).
    /// </summary>
    [IsoId("_IoCIIdX2Eeia9rtBTv_9KA")]
    [DisplayName("Batch Digital Signature")]
    [IsoXmlTag("BtchDgtlSgntr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? BatchDigitalSignature { get; init; }

    /// <summary>
    /// Configuration of a message item.
    /// </summary>
    [IsoId("_IoCII9X2Eeia9rtBTv_9KA")]
    [DisplayName("Message Item")]
    [IsoXmlTag("MsgItm")]
    public ValueList<MessageItemCondition1> MessageItem { get; init; } = [];

    /// <summary>
    /// Indicator to require protection of sensitive card data in messages.
    /// </summary>
    [IsoId("_IoCIJdX2Eeia9rtBTv_9KA")]
    [DisplayName("Protect Card Data")]
    [IsoXmlTag("PrtctCardData")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator ProtectCardData { get; init; }

    /// <summary>
    /// Indicator to require a private protection of sensitive card data in messages.
    /// </summary>
    [IsoId("_IoCIJ9X2Eeia9rtBTv_9KA")]
    [DisplayName("Private Card Data")]
    [IsoXmlTag("PrvtCardData")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? PrivateCardData { get; init; }

    /// <summary>
    /// A security trailer is mandatory in the messages.
    /// </summary>
    [IsoId("_IoCIKdX2Eeia9rtBTv_9KA")]
    [DisplayName("Mandatory Security Trailer")]
    [IsoXmlTag("MndtrySctyTrlr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? MandatorySecurityTrailer { get; init; }
}
