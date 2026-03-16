// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed Transaction Statistics30.
/// </summary>
[IsoId("_l8bfMfreEe2mU4Wi2q3MzQ")]
[DisplayName("Detailed Transaction Statistics30")]
public partial record DetailedTransactionStatistics30
{
    #nullable enable

    /// <summary>
    /// Total Corrected Rejections.
    /// </summary>
    [DisplayName("Total Corrected Rejections")]
    [IsoXmlTag("TtlCrrctdRjctns")]
    public IsoMax20PositiveNumber? TotalCorrectedRejections { get; init; } 

    /// <summary>
    /// Total Number Of Transactions.
    /// </summary>
    [DisplayName("Total Number Of Transactions")]
    [IsoXmlTag("TtlNbOfTxs")]
    public required IsoMax20PositiveNumber TotalNumberOfTransactions { get; init; } 

    /// <summary>
    /// Total Number Of Transactions Accepted.
    /// </summary>
    [DisplayName("Total Number Of Transactions Accepted")]
    [IsoXmlTag("TtlNbOfTxsAccptd")]
    public required IsoMax20PositiveNumber TotalNumberOfTransactionsAccepted { get; init; } 

    /// <summary>
    /// Total Number Of Transactions Rejected.
    /// </summary>
    [DisplayName("Total Number Of Transactions Rejected")]
    [IsoXmlTag("TtlNbOfTxsRjctd")]
    public required IsoMax20PositiveNumber TotalNumberOfTransactionsRejected { get; init; } 

    /// <summary>
    /// Transactions Rejections Reason.
    /// </summary>
    [DisplayName("Transactions Rejections Reason")]
    [IsoXmlTag("TxsRjctnsRsn")]
    public ValueList<RejectionReason71> TransactionsRejectionsReason { get; init; } = [];

    
    #nullable disable
    
}
