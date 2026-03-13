// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of the captured set of transactions.
/// </summary>
[IsoId("_yarcAS4-EeunNvJlR_vCbg")]
[DisplayName("Card Payment Data Set")]
public partial record CardPaymentDataSet27
{
    #nullable enable
    
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    [IsoId("_ymNWkS4-EeunNvJlR_vCbg")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DataSetIdentification5 DataSetIdentification { get; init; } 
    
    /// <summary>
    /// Result of the data set capture.
    /// </summary>
    [IsoId("_ymNWky4-EeunNvJlR_vCbg")]
    [DisplayName("Data Set Result")]
    [IsoXmlTag("DataSetRslt")]
    public required ResponseType10 DataSetResult { get; init; } 
    
    /// <summary>
    /// Indicates if the data set must be removed from the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_ymNWlS4-EeunNvJlR_vCbg")]
    [DisplayName("Remove Data Set")]
    [IsoXmlTag("RmvDataSet")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator RemoveDataSet { get; init; } 
    
    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    [IsoId("_ymNWly4-EeunNvJlR_vCbg")]
    [DisplayName("Data Set Initiator")]
    [IsoXmlTag("DataSetInitr")]
    public GenericIdentification176? DataSetInitiator { get; init; } 
    
    /// <summary>
    /// Transaction totals of the batch.
    /// </summary>
    [IsoId("_ymNWmS4-EeunNvJlR_vCbg")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotals12> TransactionTotals { get; init; } = [];
    // ID for the above is _ymNWmS4-EeunNvJlR_vCbg
    
    /// <summary>
    /// Transaction in the batch, whose capture has been rejected.
    /// </summary>
    [IsoId("_ymNWmy4-EeunNvJlR_vCbg")]
    [DisplayName("Rejected Transaction")]
    [IsoXmlTag("RjctdTx")]
    public CardPaymentDataSet28? RejectedTransaction { get; init; } 
    
    /// <summary>
    /// Transaction in the batch, whose capture has been suspended.
    /// </summary>
    [IsoId("_ymNWnS4-EeunNvJlR_vCbg")]
    [DisplayName("Suspended Transaction")]
    [IsoXmlTag("SspdTx")]
    public CardPaymentDataSet28? SuspendedTransaction { get; init; } 
    
    /// <summary>
    /// Transaction in the batch, whose capture has been approved after suspension.
    /// </summary>
    [IsoId("_ymNWny4-EeunNvJlR_vCbg")]
    [DisplayName("Resumed Approval")]
    [IsoXmlTag("RsmdApprvl")]
    public CardPaymentDataSet28? ResumedApproval { get; init; } 
    
    /// <summary>
    /// Transaction in the batch, whose capture has been rejected after suspension.
    /// </summary>
    [IsoId("_ymNWoS4-EeunNvJlR_vCbg")]
    [DisplayName("Resumed Rejection")]
    [IsoXmlTag("RsmdRjctn")]
    public CardPaymentDataSet28? ResumedRejection { get; init; } 
    
    
    #nullable disable
    
}
