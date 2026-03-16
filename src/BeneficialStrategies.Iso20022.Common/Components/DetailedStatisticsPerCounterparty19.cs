// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed Statistics Per Counterparty19.
/// </summary>
[IsoId("_l21NhfreEe2mU4Wi2q3MzQ")]
[DisplayName("Detailed Statistics Per Counterparty19")]
public record DetailedStatisticsPerCounterparty19
{
    /// <summary>
    /// Reference Date.
    /// </summary>
    [DisplayName("Reference Date")]
    [IsoXmlTag("RefDt")]
    public required IsoISODate ReferenceDate { get; init; }

    /// <summary>
    /// Rejection Statistics.
    /// </summary>
    [DisplayName("Rejection Statistics")]
    [IsoXmlTag("RjctnSttstcs")]
    public ValueList<RejectionStatistics9> RejectionStatistics { get; init; } = [];

    /// <summary>
    /// Total Corrected Rejections.
    /// </summary>
    [DisplayName("Total Corrected Rejections")]
    [IsoXmlTag("TtlCrrctdRjctns")]
    public IsoMax20PositiveNumber? TotalCorrectedRejections { get; init; }

    /// <summary>
    /// Total Number Of Reports.
    /// </summary>
    [DisplayName("Total Number Of Reports")]
    [IsoXmlTag("TtlNbOfRpts")]
    public required IsoMax20PositiveNumber TotalNumberOfReports { get; init; }

    /// <summary>
    /// Total Number Of Reports Accepted.
    /// </summary>
    [DisplayName("Total Number Of Reports Accepted")]
    [IsoXmlTag("TtlNbOfRptsAccptd")]
    public required IsoMax20PositiveNumber TotalNumberOfReportsAccepted { get; init; }

    /// <summary>
    /// Total Number Of Reports Rejected.
    /// </summary>
    [DisplayName("Total Number Of Reports Rejected")]
    [IsoXmlTag("TtlNbOfRptsRjctd")]
    public required IsoMax20PositiveNumber TotalNumberOfReportsRejected { get; init; }

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
}
