// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card Payment Data Set36.
/// </summary>
[IsoId("_F-c48ZI3Ee6RsYhlPIxpVw")]
[DisplayName("Card Payment Data Set36")]
public partial record CardPaymentDataSet36
{
    #nullable enable

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
    public ValueList<CardPaymentDataSet35> RejectedTransaction { get; init; } = [];

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
    public ValueList<CardPaymentDataSet35> ResumedApproval { get; init; } = [];

    /// <summary>
    /// Resumed Rejection.
    /// </summary>
    [DisplayName("Resumed Rejection")]
    [IsoXmlTag("RsmdRjctn")]
    public ValueList<CardPaymentDataSet35> ResumedRejection { get; init; } = [];

    /// <summary>
    /// Suspended Transaction.
    /// </summary>
    [DisplayName("Suspended Transaction")]
    [IsoXmlTag("SspdTx")]
    public ValueList<CardPaymentDataSet35> SuspendedTransaction { get; init; } = [];

    /// <summary>
    /// Transaction Totals.
    /// </summary>
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotals12> TransactionTotals { get; init; } = [];

    
    #nullable disable
    
}
