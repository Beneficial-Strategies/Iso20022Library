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
[IsoId("_1y1K4Qx4Eeqdx6buGpCCQw")]
[DisplayName("Card Payment Data Set")]
public record CardPaymentDataSet24
{
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    [IsoId("_1-gPYQx4Eeqdx6buGpCCQw")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DataSetIdentification5 DataSetIdentification { get; init; }

    /// <summary>
    /// Result of the data set capture.
    /// </summary>
    [IsoId("_1-gPYwx4Eeqdx6buGpCCQw")]
    [DisplayName("Data Set Result")]
    [IsoXmlTag("DataSetRslt")]
    public required ResponseType10 DataSetResult { get; init; }

    /// <summary>
    /// Indicates if the data set must be removed from the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_1-gPZQx4Eeqdx6buGpCCQw")]
    [DisplayName("Remove Data Set")]
    [IsoXmlTag("RmvDataSet")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator RemoveDataSet { get; init; }

    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    [IsoId("_1-gPZwx4Eeqdx6buGpCCQw")]
    [DisplayName("Data Set Initiator")]
    [IsoXmlTag("DataSetInitr")]
    public GenericIdentification176? DataSetInitiator { get; init; }

    /// <summary>
    /// Transaction totals of the batch.
    /// </summary>
    [IsoId("_1-gPaQx4Eeqdx6buGpCCQw")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotals7> TransactionTotals { get; init; } = [];

    // ID for the above is _1-gPaQx4Eeqdx6buGpCCQw

    /// <summary>
    /// Transaction in the batch, whose capture has been rejected.
    /// </summary>
    [IsoId("_9MPL8Qx5Eeqdx6buGpCCQw")]
    [DisplayName("Rejected Transaction")]
    [IsoXmlTag("RjctdTx")]
    public CardPaymentDataSet25? RejectedTransaction { get; init; }

    /// <summary>
    /// Transaction in the batch, whose capture has been suspendeed.
    /// </summary>
    [IsoId("_1-gPawx4Eeqdx6buGpCCQw")]
    [DisplayName("Suspended Transaction")]
    [IsoXmlTag("SspdTx")]
    public CardPaymentDataSet25? SuspendedTransaction { get; init; }

    /// <summary>
    /// Transaction in the batch, whose capture has been approved after suspension.
    /// </summary>
    [IsoId("_90xLkQx5Eeqdx6buGpCCQw")]
    [DisplayName("Resumed Approval")]
    [IsoXmlTag("RsmdApprvl")]
    public CardPaymentDataSet25? ResumedApproval { get; init; }

    /// <summary>
    /// Transaction in the batch, whose capture has been rejected after suspension.
    /// </summary>
    [IsoId("_-P-g4Qx5Eeqdx6buGpCCQw")]
    [DisplayName("Resumed Rejection")]
    [IsoXmlTag("RsmdRjctn")]
    public CardPaymentDataSet25? ResumedRejection { get; init; }
}
