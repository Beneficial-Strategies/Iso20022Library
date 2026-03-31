// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card Payment Data Set39.
/// </summary>
[IsoId("_zUrnoaEYEe-MRKYsaX6JDg")]
[DisplayName("Card Payment Data Set39")]
public record CardPaymentDataSet39
{
    /// <summary>
    /// Data Set Identification.
    /// </summary>
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DataSetIdentification5 DataSetIdentification { get; init; }

    /// <summary>
    /// Data Set Initiator.
    /// </summary>
    [DisplayName("Data Set Initiator")]
    [IsoXmlTag("DataSetInitr")]
    public GenericIdentification176? DataSetInitiator { get; init; }

    /// <summary>
    /// Data Set Result.
    /// </summary>
    [DisplayName("Data Set Result")]
    [IsoXmlTag("DataSetRslt")]
    public required ResponseType10 DataSetResult { get; init; }

    /// <summary>
    /// Rejected Transaction.
    /// </summary>
    [DisplayName("Rejected Transaction")]
    [IsoXmlTag("RjctdTx")]
    public ValueList<CardPaymentDataSet38> RejectedTransaction { get; init; } = [];

    /// <summary>
    /// Remove Data Set.
    /// </summary>
    [DisplayName("Remove Data Set")]
    [IsoXmlTag("RmvDataSet")]
    public required IsoTrueFalseIndicator RemoveDataSet { get; init; }

    /// <summary>
    /// Resumed Approval.
    /// </summary>
    [DisplayName("Resumed Approval")]
    [IsoXmlTag("RsmdApprvl")]
    public ValueList<CardPaymentDataSet38> ResumedApproval { get; init; } = [];

    /// <summary>
    /// Resumed Rejection.
    /// </summary>
    [DisplayName("Resumed Rejection")]
    [IsoXmlTag("RsmdRjctn")]
    public ValueList<CardPaymentDataSet38> ResumedRejection { get; init; } = [];

    /// <summary>
    /// Suspended Transaction.
    /// </summary>
    [DisplayName("Suspended Transaction")]
    [IsoXmlTag("SspdTx")]
    public ValueList<CardPaymentDataSet38> SuspendedTransaction { get; init; } = [];

    /// <summary>
    /// Transaction Totals.
    /// </summary>
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotals12> TransactionTotals { get; init; } = [];
}
