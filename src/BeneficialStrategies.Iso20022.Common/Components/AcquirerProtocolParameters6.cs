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
[IsoId("_khp2MTZ4EeOP_KvUKe29ng")]
[DisplayName("Acquirer Protocol Parameters")]
public record AcquirerProtocolParameters6
{
    /// <summary>
    /// Identification of the acquirer using this protocol.
    /// </summary>
    [IsoId("_kzSYwTZ4EeOP_KvUKe29ng")]
    [DisplayName("Acquirer Identification")]
    [IsoXmlTag("AcqrrId")]
    public ValueList<GenericIdentification32> AcquirerIdentification { get; init; } = [];

    // ID for the above is _kzSYwTZ4EeOP_KvUKe29ng

    /// <summary>
    /// Identification of the payment application, user of the acquirer protocol.
    /// </summary>
    [IsoId("_kzSYwzZ4EeOP_KvUKe29ng")]
    [DisplayName("Application Identification")]
    [IsoXmlTag("ApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ApplicationIdentification { get; init; }

    /// <summary>
    /// Acquirer host configuration.
    /// </summary>
    [IsoId("_kzSYxTZ4EeOP_KvUKe29ng")]
    [DisplayName("Host")]
    [IsoXmlTag("Hst")]
    public AcquirerHostConfiguration2? Host { get; init; }

    /// <summary>
    /// Acquirer protocol parameters of transactions performing an online authorisation.
    /// </summary>
    [IsoId("_kzSYxzZ4EeOP_KvUKe29ng")]
    [DisplayName("On Line Transaction")]
    [IsoXmlTag("OnLineTx")]
    public AcquirerProtocolParameters5? OnLineTransaction { get; init; }

    /// <summary>
    /// Acquirer protocol parameters of transactions performing an offline authorisation.
    /// </summary>
    [IsoId("_kzSYyTZ4EeOP_KvUKe29ng")]
    [DisplayName("Off Line Transaction")]
    [IsoXmlTag("OffLineTx")]
    public AcquirerProtocolParameters5? OffLineTransaction { get; init; }

    /// <summary>
    /// Configuration parameters of reconciliation exchanges.
    /// </summary>
    [IsoId("_kzSYyzZ4EeOP_KvUKe29ng")]
    [DisplayName("Reconciliation Exchange")]
    [IsoXmlTag("RcncltnXchg")]
    public ExchangeConfiguration4? ReconciliationExchange { get; init; }

    /// <summary>
    /// Indicates the reconciliation period is assigned by the acquirer instead of the acceptor.
    /// </summary>
    [IsoId("_kzSYzTZ4EeOP_KvUKe29ng")]
    [DisplayName("Reconciliation By Acquirer")]
    [IsoXmlTag("RcncltnByAcqrr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReconciliationByAcquirer { get; init; }

    /// <summary>
    /// Indicates the reconciliation total amounts are computed per currency.
    /// </summary>
    [IsoId("_kzSYzzZ4EeOP_KvUKe29ng")]
    [DisplayName("Totals Per Currency")]
    [IsoXmlTag("TtlsPerCcy")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? TotalsPerCurrency { get; init; }

    /// <summary>
    /// Indicates that totals in reconciliation or batch must be split per group of points of interaction and card product profiles when these informations are present in the transactions.
    /// </summary>
    [IsoId("_kzSY0TZ4EeOP_KvUKe29ng")]
    [DisplayName("Split Totals")]
    [IsoXmlTag("SpltTtls")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? SplitTotals { get; init; }

    /// <summary>
    /// Indicates that response messages and an AcceptorCompletionAdvice message following an authorisation exchange must contain protected or plain card data.
    /// </summary>
    [IsoId("_kzSY0zZ4EeOP_KvUKe29ng")]
    [DisplayName("Card Data Verification")]
    [IsoXmlTag("CardDataVrfctn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CardDataVerification { get; init; }

    /// <summary>
    /// Send a cancellation advice for offline transactions not yet captured.
    /// </summary>
    [IsoId("_iLDVwDZ5EeOP_KvUKe29ng")]
    [DisplayName("Notify Off Line Cancellation")]
    [IsoXmlTag("NtfyOffLineCxl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? NotifyOffLineCancellation { get; init; }

    /// <summary>
    /// Types of transaction to include in the batch.
    /// </summary>
    [IsoId("_kzSY1TZ4EeOP_KvUKe29ng")]
    [DisplayName("Batch Transfer Content")]
    [IsoXmlTag("BtchTrfCntt")]
    public BatchTransactionType1Code? BatchTransferContent { get; init; }

    /// <summary>
    /// Configuration of a message item.
    /// </summary>
    [IsoId("_kzSY1zZ4EeOP_KvUKe29ng")]
    [DisplayName("Message Item")]
    [IsoXmlTag("MsgItm")]
    public MessageItemCondition1? MessageItem { get; init; }

    /// <summary>
    /// Indicator to require protection of sensitive card data in messages.
    /// </summary>
    [IsoId("_kzSY2TZ4EeOP_KvUKe29ng")]
    [DisplayName("Protect Card Data")]
    [IsoXmlTag("PrtctCardData")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator ProtectCardData { get; init; }
}
