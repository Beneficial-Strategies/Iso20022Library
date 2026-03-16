// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about number of transactions accepted and rejected and the reasons of the rejections.
/// </summary>
[IsoId("_hUsuxcK4EeuFNp8LZAnorg")]
[DisplayName("Detailed Transaction Statistics")]
public record DetailedTransactionStatistics13
{
    /// <summary>
    /// Total number of reports sent or received.
    /// </summary>
    [IsoId("_hV-hIcK4EeuFNp8LZAnorg")]
    [DisplayName("Total Number Of Transactions")]
    [IsoXmlTag("TtlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText TotalNumberOfTransactions { get; init; }

    /// <summary>
    /// Total number of transactions accepted.
    /// </summary>
    [IsoId("_hV-hI8K4EeuFNp8LZAnorg")]
    [DisplayName("Total Number Of Transactions Accepted")]
    [IsoXmlTag("TtlNbOfTxsAccptd")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText TotalNumberOfTransactionsAccepted { get; init; }

    /// <summary>
    /// Total number of transactions rejected.
    /// </summary>
    [IsoId("_hV-hJcK4EeuFNp8LZAnorg")]
    [DisplayName("Total Number Of Transactions Rejected")]
    [IsoXmlTag("TtlNbOfTxsRjctd")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText TotalNumberOfTransactionsRejected { get; init; }

    /// <summary>
    /// Details on transactions rejected per error code.
    /// </summary>
    [IsoId("_hV-hJ8K4EeuFNp8LZAnorg")]
    [DisplayName("Transactions Rejections Reason")]
    [IsoXmlTag("TxsRjctnsRsn")]
    public RejectionReason53? TransactionsRejectionsReason { get; init; }
}
