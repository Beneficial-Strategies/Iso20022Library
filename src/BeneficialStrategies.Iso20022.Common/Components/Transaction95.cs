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
/// Batch management transaction.
/// </summary>
[IsoId("_0xLc0FAaEeedyPuM0kK2EQ")]
[DisplayName("Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Transaction95
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Transaction95 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Transaction95( BatchManagementType1Code reqBatchManagementType )
    {
        BatchManagementType = reqBatchManagementType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of batch management activity.
    /// ISO 8583:87/93 bit 24
    /// ISO 8583:2003 bit 68-1
    /// </summary>
    [IsoId("__bmYIFAaEeedyPuM0kK2EQ")]
    [DisplayName("Batch Management Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BtchMgmtTp")]
    #endif
    [IsoXmlTag("BtchMgmtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BatchManagementType1Code BatchManagementType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BatchManagementType1Code BatchManagementType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BatchManagementType1Code BatchManagementType { get; init; } 
    #else
    public BatchManagementType1Code BatchManagementType { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of batch management activity.
    /// </summary>
    [IsoId("_GD6I4FAbEeedyPuM0kK2EQ")]
    [DisplayName("Other Batch Management Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrBtchMgmtTp")]
    #endif
    [IsoXmlTag("OthrBtchMgmtTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherBatchManagementType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherBatchManagementType { get; init; } 
    #else
    public System.String? OtherBatchManagementType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the batch management transaction.
    /// </summary>
    [IsoId("_QsZKgFAbEeedyPuM0kK2EQ")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionIdentification10? TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentification10? TransactionIdentification { get; init; } 
    #else
    public TransactionIdentification10? TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_95zpg_F6EeiGNursv3uE_g")]
    [DisplayName("Additional Fees")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlFees")]
    #endif
    [IsoXmlTag("AddtlFees")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalFee1? AdditionalFees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalFee1? AdditionalFees { get; init; } 
    #else
    public AdditionalFee1? AdditionalFees { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a collection.
    /// Mandatory for start or end of a collection and their acknowledgements if the batch is included in a collection.
    /// All the messages included within the collection will have the same collection identification value.
    /// </summary>
    [IsoId("_7nNEAFAbEeedyPuM0kK2EQ")]
    [DisplayName("Collection Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ColltnId")]
    #endif
    [IsoXmlTag("ColltnId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? CollectionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CollectionIdentification { get; init; } 
    #else
    public System.String? CollectionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a batch.
    /// All the messages included within the batch will have the same batch identification value.
    /// </summary>
    [IsoId("_Fwck4FAcEeedyPuM0kK2EQ")]
    [DisplayName("Batch Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BtchId")]
    #endif
    [IsoXmlTag("BtchId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? BatchIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BatchIdentification { get; init; } 
    #else
    public System.String? BatchIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Total length in bytes of the collection to be transferred. 
    /// ISO 8583:2003 bit 70-2
    /// </summary>
    [IsoId("_SgZWQGeqEeeuT9Qn0D6Z_w")]
    [DisplayName("Collection Size")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ColltnSz")]
    #endif
    [IsoXmlTag("ColltnSz")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? CollectionSize { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? CollectionSize { get; init; } 
    #else
    public System.UInt64? CollectionSize { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the original collection.
    /// Mandatory when the collection containing the batch response has not the same identification as the collection containing the original batch.
    /// </summary>
    [IsoId("_VBJHwFAcEeedyPuM0kK2EQ")]
    [DisplayName("Original Collection Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlColltnId")]
    #endif
    [IsoXmlTag("OrgnlColltnId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? OriginalCollectionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalCollectionIdentification { get; init; } 
    #else
    public System.String? OriginalCollectionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the original batch to answer.
    /// Mandatory when the batch response has not the same identification as the batch initiation.
    /// </summary>
    [IsoId("_iWqXYFAcEeedyPuM0kK2EQ")]
    [DisplayName("Original Batch Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlBtchId")]
    #endif
    [IsoXmlTag("OrgnlBtchId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? OriginalBatchIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalBatchIdentification { get; init; } 
    #else
    public System.String? OriginalBatchIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Number of batches in the collection.
    /// For a start of collection, this is the number of expected batches if known.
    /// For a start of collection acknowledgement, this is the maximum number of batches that can be received in the collection.
    /// For an end of collection, this is the number of batches sent in the closing collection.
    /// For an end of collection acknowledgement, this is the number of batches received in the collection.
    /// </summary>
    [IsoId("_ArVPwFAdEeedyPuM0kK2EQ")]
    [DisplayName("Number Of Batches In Collection")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfBtchsInColltn")]
    #endif
    [IsoXmlTag("NbOfBtchsInColltn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? NumberOfBatchesInCollection { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfBatchesInCollection { get; init; } 
    #else
    public System.UInt64? NumberOfBatchesInCollection { get; set; } 
    #endif
    
    /// <summary>
    /// Number of messages.
    /// ISO 8583:87 bit 72
    /// ISO 8583:2003 bit 70-1 or bit 69-1
    /// For a start of collection, this is the number of expected messages in the collection if known. 
    /// For a start of batch, this is the number of expected messages in the batch if known.
    /// For an AcknowledgementRequest , this is the number of sent messages since last check point.
    /// For an AcknowledgementResponse, this is the number of received messages since last check point.
    /// For an end of batch this is the number of received messages in the batch.
    /// For an end of collection, this is the number of received messages in the collection.
    /// Note: Batch management messages are excluded from the count.
    /// </summary>
    [IsoId("_IyjOgFAdEeedyPuM0kK2EQ")]
    [DisplayName("Number Of Messages")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfMsgs")]
    #endif
    [IsoXmlTag("NbOfMsgs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? NumberOfMessages { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfMessages { get; init; } 
    #else
    public System.UInt64? NumberOfMessages { get; set; } 
    #endif
    
    /// <summary>
    /// Number of remaining messages in the collection.
    /// ISO 8583:2003 bit 70-3
    /// </summary>
    [IsoId("_tJqT4GeqEeeuT9Qn0D6Z_w")]
    [DisplayName("Remaining Messages In Collection")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmngMsgsInColltn")]
    #endif
    [IsoXmlTag("RmngMsgsInColltn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? RemainingMessagesInCollection { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? RemainingMessagesInCollection { get; init; } 
    #else
    public System.UInt64? RemainingMessagesInCollection { get; set; } 
    #endif
    
    /// <summary>
    /// For a start of collection, sequence number of first expected message of the collection. 
    /// For a start of batch, sequence number of first expected message of the batch.
    /// For an AcknowledgementRequest , sequence number of the last message sent for this checkpoint.
    /// For an AcknowledgementResponse, sequence number of the last message received for this checkpoint.
    /// For an end of batch, sequence number of last message of the batch.
    /// For an end of collection, sequence number of last message of the collection.
    /// </summary>
    [IsoId("__brW0d3wEeieV46qhAnbyQ")]
    [DisplayName("Message Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgSeqNb")]
    #endif
    [IsoXmlTag("MsgSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15NumericText? MessageSequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MessageSequenceNumber { get; init; } 
    #else
    public System.String? MessageSequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// List of batch identifications of the collection.
    /// For a start of collection, the identification of expected batches, if known.
    /// For an end of collection, this is the identification of batches sent in the closing collection.
    /// For an end of collection acknowledgement, this is the identification of batches received in the collection.
    /// </summary>
    [IsoId("_ARN0sFAfEeedyPuM0kK2EQ")]
    [DisplayName("Batch Identification List")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BtchIdList")]
    #endif
    [IsoXmlTag("BtchIdList")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? BatchIdentificationList { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BatchIdentificationList { get; init; } 
    #else
    public System.String? BatchIdentificationList { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a specific checkpoint.
    /// </summary>
    [IsoId("_iad08d3xEeieV46qhAnbyQ")]
    [DisplayName("Checkpoint Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChckptId")]
    #endif
    [IsoXmlTag("ChckptId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? CheckpointIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CheckpointIdentification { get; init; } 
    #else
    public System.String? CheckpointIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Checksum of the series of messages in the batch or until a checkpoint.
    /// </summary>
    [IsoId("_KAk18FAfEeedyPuM0kK2EQ")]
    [DisplayName("Batch Checksum")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BtchChcksm")]
    #endif
    [IsoXmlTag("BtchChcksm")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Binary? BatchChecksum { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? BatchChecksum { get; init; } 
    #else
    public System.Byte[]? BatchChecksum { get; set; } 
    #endif
    
    /// <summary>
    /// Indicator to request acknowledgement.
    /// True: Acknowledgement requested
    /// False: Acknowledgement not requested.
    /// </summary>
    [IsoId("_pvoBoFAfEeedyPuM0kK2EQ")]
    [DisplayName("Request Acknowledgement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqAck")]
    #endif
    [IsoXmlTag("ReqAck")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? RequestAcknowledgement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RequestAcknowledgement { get; init; } 
    #else
    public System.String? RequestAcknowledgement { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum number of messages to be sent before acknowledgement. The receiver will send an acknowledgement response every time the indicated number of messages is reached.
    /// </summary>
    [IsoId("_MNVzAFAgEeedyPuM0kK2EQ")]
    [DisplayName("Messages Before Acknowledgement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgsBfrAck")]
    #endif
    [IsoXmlTag("MsgsBfrAck")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? MessagesBeforeAcknowledgement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MessagesBeforeAcknowledgement { get; init; } 
    #else
    public System.UInt64? MessagesBeforeAcknowledgement { get; set; } 
    #endif
    
    /// <summary>
    /// Indicate whether the acknowledgement is positive or not.
    /// True: Positive acknowledgement.
    /// False: Negative acknowledgement.
    /// </summary>
    [IsoId("_cdRlUFAgEeedyPuM0kK2EQ")]
    [DisplayName("Positive Acknowledgement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PostvAck")]
    #endif
    [IsoXmlTag("PostvAck")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? PositiveAcknowledgement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PositiveAcknowledgement { get; init; } 
    #else
    public System.String? PositiveAcknowledgement { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_gFmX8RqmEeqH1IQNpbVpEw")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? AdditionalData { get; init; } 
    #else
    public AdditionalData1? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
