// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of the captured set of transactions.
/// </summary>
[IsoId("_PbyDIXIuEe299ZbWCkdR_w")]
[DisplayName("Card Payment Data Set")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentDataSet33
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardPaymentDataSet33 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardPaymentDataSet33( DataSetIdentification5 reqDataSetIdentification,ResponseType10 reqDataSetResult,System.String reqRemoveDataSet )
    {
        DataSetIdentification = reqDataSetIdentification;
        DataSetResult = reqDataSetResult;
        RemoveDataSet = reqRemoveDataSet;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    [IsoId("_Pi3ikXIuEe299ZbWCkdR_w")]
    [DisplayName("Data Set Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DataSetId")]
    #endif
    [IsoXmlTag("DataSetId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DataSetIdentification5 DataSetIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DataSetIdentification5 DataSetIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataSetIdentification5 DataSetIdentification { get; init; } 
    #else
    public DataSetIdentification5 DataSetIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the data set capture.
    /// </summary>
    [IsoId("_Pi3ik3IuEe299ZbWCkdR_w")]
    [DisplayName("Data Set Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DataSetRslt")]
    #endif
    [IsoXmlTag("DataSetRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResponseType10 DataSetResult { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResponseType10 DataSetResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseType10 DataSetResult { get; init; } 
    #else
    public ResponseType10 DataSetResult { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the data set must be removed from the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_Pi3ilXIuEe299ZbWCkdR_w")]
    [DisplayName("Remove Data Set")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmvDataSet")]
    #endif
    [IsoXmlTag("RmvDataSet")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator RemoveDataSet { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RemoveDataSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RemoveDataSet { get; init; } 
    #else
    public System.String RemoveDataSet { get; set; } 
    #endif
    
    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    [IsoId("_Pi3il3IuEe299ZbWCkdR_w")]
    [DisplayName("Data Set Initiator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DataSetInitr")]
    #endif
    [IsoXmlTag("DataSetInitr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification176? DataSetInitiator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification176? DataSetInitiator { get; init; } 
    #else
    public GenericIdentification176? DataSetInitiator { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction totals of the batch.
    /// </summary>
    [IsoId("_Pi3imXIuEe299ZbWCkdR_w")]
    [DisplayName("Transaction Totals")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTtls")]
    #endif
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotals12> TransactionTotals { get; init; } = new ValueList<TransactionTotals12>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Pi3imXIuEe299ZbWCkdR_w
    
    /// <summary>
    /// Transaction in the batch, whose capture has been rejected.
    /// </summary>
    [IsoId("_Pi3im3IuEe299ZbWCkdR_w")]
    [DisplayName("Rejected Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctdTx")]
    #endif
    [IsoXmlTag("RjctdTx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentDataSet32? RejectedTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentDataSet32? RejectedTransaction { get; init; } 
    #else
    public CardPaymentDataSet32? RejectedTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction in the batch, whose capture has been suspended.
    /// </summary>
    [IsoId("_Pi3inXIuEe299ZbWCkdR_w")]
    [DisplayName("Suspended Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SspdTx")]
    #endif
    [IsoXmlTag("SspdTx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentDataSet32? SuspendedTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentDataSet32? SuspendedTransaction { get; init; } 
    #else
    public CardPaymentDataSet32? SuspendedTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction in the batch, whose capture has been approved after suspension.
    /// </summary>
    [IsoId("_Pi3in3IuEe299ZbWCkdR_w")]
    [DisplayName("Resumed Approval")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsmdApprvl")]
    #endif
    [IsoXmlTag("RsmdApprvl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentDataSet32? ResumedApproval { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentDataSet32? ResumedApproval { get; init; } 
    #else
    public CardPaymentDataSet32? ResumedApproval { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction in the batch, whose capture has been rejected after suspension.
    /// </summary>
    [IsoId("_Pi3ioXIuEe299ZbWCkdR_w")]
    [DisplayName("Resumed Rejection")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsmdRjctn")]
    #endif
    [IsoXmlTag("RsmdRjctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentDataSet32? ResumedRejection { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentDataSet32? ResumedRejection { get; init; } 
    #else
    public CardPaymentDataSet32? ResumedRejection { get; set; } 
    #endif
    
    
    #nullable disable
    
}
