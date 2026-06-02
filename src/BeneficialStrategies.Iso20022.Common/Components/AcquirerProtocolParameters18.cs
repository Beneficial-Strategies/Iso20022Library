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
[IsoId("_sKF7AbZ_EfCUZfsQO4rYeA")]
[DisplayName("Acquirer Protocol Parameters18")]
public record AcquirerProtocolParameters18
{
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_sK_59bZ_EfCUZfsQO4rYeA")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; }

    /// <summary>
    /// Identification of the acquirer using this protocol.
    /// </summary>
    [IsoId("_sK_5-7Z_EfCUZfsQO4rYeA")]
    [DisplayName("Acquirer Identification")]
    [IsoXmlTag("AcqrrId")]
    [MinLength(1)]
    public ValueList<GenericIdentification176> AcquirerIdentification { get; init; } = [];

    /// <summary>
    /// Version of the acquirer protocol parameters.
    /// </summary>
    [IsoId("_sK_6AbZ_EfCUZfsQO4rYeA")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    public required IsoMax256Text Version { get; init; }

    /// <summary>
    /// Identification of the payment application, user of the acquirer protocol.
    /// </summary>
    [IsoId("_sK_6B7Z_EfCUZfsQO4rYeA")]
    [DisplayName("Application Identification")]
    [IsoXmlTag("ApplId")]
    public SimpleValueList<IsoMax35Text> ApplicationIdentification { get; init; } = [];

    /// <summary>
    /// Acquirer host configuration.
    /// </summary>
    [IsoId("_sK_6DbZ_EfCUZfsQO4rYeA")]
    [DisplayName("Host")]
    [IsoXmlTag("Hst")]
    public ValueList<AcquirerHostConfiguration11> Host { get; init; } = [];

    /// <summary>
    /// Acquirer protocol parameters of transactions performing an online authorisation.
    /// </summary>
    [IsoId("_sK_6E7Z_EfCUZfsQO4rYeA")]
    [DisplayName("On Line Transaction")]
    [IsoXmlTag("OnLineTx")]
    public AcquirerProtocolExchangeBehavior2? OnLineTransaction { get; init; }

    /// <summary>
    /// Acquirer protocol parameters of transactions performing an offline authorisation.
    /// </summary>
    [IsoId("_sK_6GbZ_EfCUZfsQO4rYeA")]
    [DisplayName("Off Line Transaction")]
    [IsoXmlTag("OffLineTx")]
    public AcquirerProtocolExchangeBehavior2? OffLineTransaction { get; init; }

    /// <summary>
    /// Configuration parameters of reconciliation exchanges.
    /// </summary>
    [IsoId("_sK_6H7Z_EfCUZfsQO4rYeA")]
    [DisplayName("Reconciliation Exchange")]
    [IsoXmlTag("RcncltnXchg")]
    public ExchangeConfiguration9? ReconciliationExchange { get; init; }

    /// <summary>
    /// Indicates the reconciliation period is assigned by the acquirer instead of the acceptor.
    /// </summary>
    [IsoId("_sK_6JbZ_EfCUZfsQO4rYeA")]
    [DisplayName("Reconciliation By Acquirer")]
    [IsoXmlTag("RcncltnByAcqrr")]
    public IsoTrueFalseIndicator? ReconciliationByAcquirer { get; init; }

    /// <summary>
    /// Indicates the reconciliation total amounts are computed per currency.
    /// </summary>
    [IsoId("_sK_6K7Z_EfCUZfsQO4rYeA")]
    [DisplayName("Totals Per Currency")]
    [IsoXmlTag("TtlsPerCcy")]
    public IsoTrueFalseIndicator? TotalsPerCurrency { get; init; }

    /// <summary>
    /// Indicates that totals in reconciliation or batch must be split.
    /// </summary>
    [IsoId("_sK_6MbZ_EfCUZfsQO4rYeA")]
    [DisplayName("Split Totals")]
    [IsoXmlTag("SpltTtls")]
    public IsoTrueFalseIndicator? SplitTotals { get; init; }

    /// <summary>
    /// List of criterion to use when totals in reconciliation or batch must be split.
    /// </summary>
    [IsoId("_sK_6N7Z_EfCUZfsQO4rYeA")]
    [DisplayName("Split Total Criteria")]
    [IsoXmlTag("SpltTtlCrit")]
    public SimpleValueList<ReconciliationCriteria1Code> SplitTotalCriteria { get; init; } = [];

    /// <summary>
    /// To notify that the acquirer expect to receive a completion advice after each update of reservation.
    /// </summary>
    [IsoId("_sK_6PbZ_EfCUZfsQO4rYeA")]
    [DisplayName("Completion Advice Mandated")]
    [IsoXmlTag("CmpltnAdvcMndtd")]
    public IsoTrueFalseIndicator? CompletionAdviceMandated { get; init; }

    /// <summary>
    /// Identification of available amount qualifier for a reservation.
    /// </summary>
    [IsoId("_sK_6Q7Z_EfCUZfsQO4rYeA")]
    [DisplayName("Amount Qualifier For Reservation")]
    [IsoXmlTag("AmtQlfrForRsvatn")]
    public SimpleValueList<TypeOfAmount8Code> AmountQualifierForReservation { get; init; } = [];

    /// <summary>
    /// After an error in a totals of the Reconciliation, the POI sends transactions in error in the BatchTransfer messages.
    /// </summary>
    [IsoId("_sK_6SbZ_EfCUZfsQO4rYeA")]
    [DisplayName("Reconciliation Error")]
    [IsoXmlTag("RcncltnErr")]
    public IsoTrueFalseIndicator? ReconciliationError { get; init; }

    /// <summary>
    /// Indicates whether the POI must send card data in the AcceptorCompletionAdvice message following an authorisation exchange.
    /// </summary>
    [IsoId("_sK_6T7Z_EfCUZfsQO4rYeA")]
    [DisplayName("Card Data Verification")]
    [IsoXmlTag("CardDataVrfctn")]
    public IsoTrueFalseIndicator? CardDataVerification { get; init; }

    /// <summary>
    /// Send a cancellation advice for offline transactions not yet captured.
    /// </summary>
    [IsoId("_sK_6VbZ_EfCUZfsQO4rYeA")]
    [DisplayName("Notify Off Line Cancellation")]
    [IsoXmlTag("NtfyOffLineCxl")]
    public IsoTrueFalseIndicator? NotifyOffLineCancellation { get; init; }

    /// <summary>
    /// Types of transaction to include in the batch.
    /// </summary>
    [IsoId("_sK_6W7Z_EfCUZfsQO4rYeA")]
    [DisplayName("Batch Transfer Content")]
    [IsoXmlTag("BtchTrfCntt")]
    public SimpleValueList<BatchTransactionType1Code> BatchTransferContent { get; init; } = [];

    /// <summary>
    /// BatchTransfer are exchanged per file transfer protocol rather than per message.
    /// </summary>
    [IsoId("_sK_6YbZ_EfCUZfsQO4rYeA")]
    [DisplayName("File Transfer Batch")]
    [IsoXmlTag("FileTrfBtch")]
    public IsoTrueFalseIndicator? FileTransferBatch { get; init; }

    /// <summary>
    /// BatchTransfer are authenticated by digital signature rather than a MAC.
    /// </summary>
    [IsoId("_sK_6Z7Z_EfCUZfsQO4rYeA")]
    [DisplayName("Batch Digital Signature")]
    [IsoXmlTag("BtchDgtlSgntr")]
    public IsoTrueFalseIndicator? BatchDigitalSignature { get; init; }

    /// <summary>
    /// Configuration of a message item.
    /// </summary>
    [IsoId("_sK_6bbZ_EfCUZfsQO4rYeA")]
    [DisplayName("Message Item")]
    [IsoXmlTag("MsgItm")]
    public ValueList<MessageItemCondition2> MessageItem { get; init; } = [];

    /// <summary>
    /// Indicator to require protection of sensitive card data in messages.
    /// </summary>
    [IsoId("_sK_6c7Z_EfCUZfsQO4rYeA")]
    [DisplayName("Protect Card Data")]
    [IsoXmlTag("PrtctCardData")]
    public required IsoTrueFalseIndicator ProtectCardData { get; init; }

    /// <summary>
    /// Indicator to require a private protection of sensitive card data in messages.
    /// </summary>
    [IsoId("_sK_6ebZ_EfCUZfsQO4rYeA")]
    [DisplayName("Private Card Data")]
    [IsoXmlTag("PrvtCardData")]
    public IsoTrueFalseIndicator? PrivateCardData { get; init; }

    /// <summary>
    /// A security trailer is mandatory in the messages.
    /// </summary>
    [IsoId("_sK_6f7Z_EfCUZfsQO4rYeA")]
    [DisplayName("Mandatory Security Trailer")]
    [IsoXmlTag("MndtrySctyTrlr")]
    public IsoTrueFalseIndicator? MandatorySecurityTrailer { get; init; }
}
