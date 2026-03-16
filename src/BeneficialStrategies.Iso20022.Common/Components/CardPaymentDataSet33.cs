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
[IsoId("_PbyDIXIuEe299ZbWCkdR_w")]
[DisplayName("Card Payment Data Set")]
public record CardPaymentDataSet33
{
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    [IsoId("_Pi3ikXIuEe299ZbWCkdR_w")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DataSetIdentification5 DataSetIdentification { get; init; }

    /// <summary>
    /// Result of the data set capture.
    /// </summary>
    [IsoId("_Pi3ik3IuEe299ZbWCkdR_w")]
    [DisplayName("Data Set Result")]
    [IsoXmlTag("DataSetRslt")]
    public required ResponseType10 DataSetResult { get; init; }

    /// <summary>
    /// Indicates if the data set must be removed from the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_Pi3ilXIuEe299ZbWCkdR_w")]
    [DisplayName("Remove Data Set")]
    [IsoXmlTag("RmvDataSet")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator RemoveDataSet { get; init; }

    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    [IsoId("_Pi3il3IuEe299ZbWCkdR_w")]
    [DisplayName("Data Set Initiator")]
    [IsoXmlTag("DataSetInitr")]
    public GenericIdentification176? DataSetInitiator { get; init; }

    /// <summary>
    /// Transaction totals of the batch.
    /// </summary>
    [IsoId("_Pi3imXIuEe299ZbWCkdR_w")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotals12> TransactionTotals { get; init; } = [];

    // ID for the above is _Pi3imXIuEe299ZbWCkdR_w

    /// <summary>
    /// Transaction in the batch, whose capture has been rejected.
    /// </summary>
    [IsoId("_Pi3im3IuEe299ZbWCkdR_w")]
    [DisplayName("Rejected Transaction")]
    [IsoXmlTag("RjctdTx")]
    public CardPaymentDataSet32? RejectedTransaction { get; init; }

    /// <summary>
    /// Transaction in the batch, whose capture has been suspended.
    /// </summary>
    [IsoId("_Pi3inXIuEe299ZbWCkdR_w")]
    [DisplayName("Suspended Transaction")]
    [IsoXmlTag("SspdTx")]
    public CardPaymentDataSet32? SuspendedTransaction { get; init; }

    /// <summary>
    /// Transaction in the batch, whose capture has been approved after suspension.
    /// </summary>
    [IsoId("_Pi3in3IuEe299ZbWCkdR_w")]
    [DisplayName("Resumed Approval")]
    [IsoXmlTag("RsmdApprvl")]
    public CardPaymentDataSet32? ResumedApproval { get; init; }

    /// <summary>
    /// Transaction in the batch, whose capture has been rejected after suspension.
    /// </summary>
    [IsoId("_Pi3ioXIuEe299ZbWCkdR_w")]
    [DisplayName("Resumed Rejection")]
    [IsoXmlTag("RsmdRjctn")]
    public CardPaymentDataSet32? ResumedRejection { get; init; }
}
