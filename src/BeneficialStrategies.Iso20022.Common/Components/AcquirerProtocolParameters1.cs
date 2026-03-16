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
[IsoId("_KsqnwH1DEeCF8NjrBemJWQ_748699006")]
[DisplayName("Acquirer Protocol Parameters")]
public record AcquirerProtocolParameters1
{
    /// <summary>
    /// Identification of the acquirer using this protocol.
    /// </summary>
    [IsoId("_KsqnwX1DEeCF8NjrBemJWQ_-1297060321")]
    [DisplayName("Acquirer Identification")]
    [IsoXmlTag("AcqrrId")]
    public ValueList<GenericIdentification32> AcquirerIdentification { get; init; } = [];

    // ID for the above is _KsqnwX1DEeCF8NjrBemJWQ_-1297060321

    /// <summary>
    /// Identification of the payment application, user of the acquirer protocol.
    /// </summary>
    [IsoId("_Ksqnwn1DEeCF8NjrBemJWQ_-2090866337")]
    [DisplayName("Application Identification")]
    [IsoXmlTag("ApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ApplicationIdentification { get; init; }

    /// <summary>
    /// Acquirer host configuration.
    /// </summary>
    [IsoId("_Ksqnw31DEeCF8NjrBemJWQ_1104861220")]
    [DisplayName("Host")]
    [IsoXmlTag("Hst")]
    public AcquirerHostConfiguration1? Host { get; init; }

    /// <summary>
    /// Acquirer protocol parameters of transactions performing an online authorisation.
    /// </summary>
    [IsoId("_KsqnxH1DEeCF8NjrBemJWQ_-90176465")]
    [DisplayName("On Line Transaction")]
    [IsoXmlTag("OnLineTx")]
    public AcquirerProtocolParameters2? OnLineTransaction { get; init; }

    /// <summary>
    /// Acquirer protocol parameters of transactions performing an offline authorisation.
    /// </summary>
    [IsoId("_KsqnxX1DEeCF8NjrBemJWQ_-601084090")]
    [DisplayName("Off Line Transaction")]
    [IsoXmlTag("OffLineTx")]
    public AcquirerProtocolParameters2? OffLineTransaction { get; init; }

    /// <summary>
    /// Configuration parameters of reconciliation exchanges.
    /// </summary>
    [IsoId("_Ksqnxn1DEeCF8NjrBemJWQ_1405191413")]
    [DisplayName("Reconciliation Exchange")]
    [IsoXmlTag("RcncltnXchg")]
    public ExchangeConfiguration1? ReconciliationExchange { get; init; }

    /// <summary>
    /// Indicates the reconciliation period is assigned by the acquirer instead of the acceptor.
    /// </summary>
    [IsoId("_Ksqnx31DEeCF8NjrBemJWQ_226394548")]
    [DisplayName("Reconciliation By Acquirer")]
    [IsoXmlTag("RcncltnByAcqrr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReconciliationByAcquirer { get; init; }

    /// <summary>
    /// Indicates the reconciliation total amounts are computed per currency.
    /// </summary>
    [IsoId("_KsqnyH1DEeCF8NjrBemJWQ_-1958782800")]
    [DisplayName("Totals Per Currency")]
    [IsoXmlTag("TtlsPerCcy")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? TotalsPerCurrency { get; init; }

    /// <summary>
    /// Types of transaction to include in the batch.
    /// </summary>
    [IsoId("_KszxsH1DEeCF8NjrBemJWQ_-1428276857")]
    [DisplayName("Batch Transfer Content")]
    [IsoXmlTag("BtchTrfCntt")]
    public BatchTransactionType1Code? BatchTransferContent { get; init; }

    /// <summary>
    /// Configuration of a message item.
    /// </summary>
    [IsoId("_KszxsX1DEeCF8NjrBemJWQ_-717374790")]
    [DisplayName("Message Item")]
    [IsoXmlTag("MsgItm")]
    public MessageItemCondition1? MessageItem { get; init; }

    /// <summary>
    /// Indicator to require protection of sensitive card data in messages.
    /// </summary>
    [IsoId("_Kszxsn1DEeCF8NjrBemJWQ_1543671091")]
    [DisplayName("Protect Card Data")]
    [IsoXmlTag("PrtctCardData")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator ProtectCardData { get; init; }
}
