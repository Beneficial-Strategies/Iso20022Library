// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of the captured set of transactions.
/// </summary>
[IsoId("_NmosEbX4EfCUZfsQO4rYeA")]
[DisplayName("Card Payment Data Set42")]
public record CardPaymentDataSet42
{
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    [IsoId("_NngOxbX4EfCUZfsQO4rYeA")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DataSetIdentification5 DataSetIdentification { get; init; }

    /// <summary>
    /// Result of the data set capture.
    /// </summary>
    [IsoId("_NngOy7X4EfCUZfsQO4rYeA")]
    [DisplayName("Data Set Result")]
    [IsoXmlTag("DataSetRslt")]
    public required ResponseType10 DataSetResult { get; init; }

    /// <summary>
    /// Indicates if the data set must be removed from the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_NngO0bX4EfCUZfsQO4rYeA")]
    [DisplayName("Remove Data Set")]
    [IsoXmlTag("RmvDataSet")]
    public required IsoTrueFalseIndicator RemoveDataSet { get; init; }

    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    [IsoId("_NngO17X4EfCUZfsQO4rYeA")]
    [DisplayName("Data Set Initiator")]
    [IsoXmlTag("DataSetInitr")]
    public GenericIdentification176? DataSetInitiator { get; init; }

    /// <summary>
    /// Transaction totals of the batch.
    /// </summary>
    [IsoId("_NngO3bX4EfCUZfsQO4rYeA")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    [MinLength(1)]
    public ValueList<TransactionTotals12> TransactionTotals { get; init; } = [];

    /// <summary>
    /// Transaction in the batch, whose capture has been rejected.
    /// </summary>
    [IsoId("_NngO47X4EfCUZfsQO4rYeA")]
    [DisplayName("Rejected Transaction")]
    [IsoXmlTag("RjctdTx")]
    public ValueList<CardPaymentDataSet41> RejectedTransaction { get; init; } = [];

    /// <summary>
    /// Transaction in the batch, whose capture has been suspended.
    /// </summary>
    [IsoId("_NngO6bX4EfCUZfsQO4rYeA")]
    [DisplayName("Suspended Transaction")]
    [IsoXmlTag("SspdTx")]
    public ValueList<CardPaymentDataSet41> SuspendedTransaction { get; init; } = [];

    /// <summary>
    /// Transaction in the batch, whose capture has been approved after suspension.
    /// </summary>
    [IsoId("_NngO77X4EfCUZfsQO4rYeA")]
    [DisplayName("Resumed Approval")]
    [IsoXmlTag("RsmdApprvl")]
    public ValueList<CardPaymentDataSet41> ResumedApproval { get; init; } = [];

    /// <summary>
    /// Transaction in the batch, whose capture has been rejected after suspension.
    /// </summary>
    [IsoId("_NngO9bX4EfCUZfsQO4rYeA")]
    [DisplayName("Resumed Rejection")]
    [IsoXmlTag("RsmdRjctn")]
    public ValueList<CardPaymentDataSet41> ResumedRejection { get; init; } = [];
}
