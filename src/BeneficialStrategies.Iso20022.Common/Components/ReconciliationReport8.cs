// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data on transaction requiring reconciliation or pairing.
/// </summary>
[IsoId("_AtBHZ8K3EeuFNp8LZAnorg")]
[DisplayName("Reconciliation Report")]
public record ReconciliationReport8
{
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    [IsoId("_AuXyQcK3EeuFNp8LZAnorg")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? TechnicalRecordIdentification { get; init; }

    /// <summary>
    /// Set of information related to transactions that are subject of reconciliation.
    /// </summary>
    [IsoId("_AuXyQ8K3EeuFNp8LZAnorg")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TradeTransactionIdentification19 TransactionIdentification { get; init; }

    /// <summary>
    /// Indication whether information was modified.
    /// </summary>
    [IsoId("_AuXyRcK3EeuFNp8LZAnorg")]
    [DisplayName("Modified")]
    [IsoXmlTag("Modfd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator Modified { get; init; }

    /// <summary>
    /// Indication whether the reconciliation is required.
    /// </summary>
    [IsoId("_AuXyR8K3EeuFNp8LZAnorg")]
    [DisplayName("Reconciliation Status")]
    [IsoXmlTag("RcncltnSts")]
    public required ReconciliationStatus8Choice_ ReconciliationStatus { get; init; }
}
