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
[IsoId("_3xcXwVA5EeedyPuM0kK2EQ")]
[DisplayName("Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Transaction96
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the batch management transaction.
    /// </summary>
    [IsoId("_38KaBVA5EeedyPuM0kK2EQ")]
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
    /// Identification of a batch.
    /// All the messages included within the batch will have the same batch identification value.
    /// </summary>
    [IsoId("_38KaCVA5EeedyPuM0kK2EQ")]
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
    /// Identification of the original batch to answer.
    /// Mandatory when the batch response has not the same identification as the batch initiation.
    /// </summary>
    [IsoId("_38KaDVA5EeedyPuM0kK2EQ")]
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
    /// Number of messages.
    /// For a start of a collection, this is the number of expected messages in the collection if known. This is also the last expected message sequence number in the collection.
    /// For a start of a batch, this is the number of expected messages in the batch if known. This is also the last expected message sequence number in the batch.
    /// For a start of a batch acknowledgement, this is the maximum number of messages that can be received in the batch.
    /// For an intermediate acknowledgement, this is the last message sequence number received in sequence.
    /// For an intermediate checkpoint, this is the message sequence number of the last received message.
    /// For an end of batch this is the last message sequence number sent in the closing batch, equal to the number of messages sent in the batch.
    /// For an end of batch acknowledgement, this is the last sequence number received in the sequence.
    /// </summary>
    [IsoId("_38KaEVA5EeedyPuM0kK2EQ")]
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
    /// Checksum of the series of messages received in the batch or until a checkpoint.
    /// </summary>
    [IsoId("_38KaFVA5EeedyPuM0kK2EQ")]
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
    /// Indicator to request acknowlegement.
    /// True: Acknowledgement requested
    /// False: Acknowledgement not requested.
    /// </summary>
    [IsoId("_38KaF1A5EeedyPuM0kK2EQ")]
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
    /// Clearing data at batch level allowing clearing in different currencies.
    /// </summary>
    [IsoId("_onRW0FA9EeedyPuM0kK2EQ")]
    [DisplayName("Clearing Batch Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrBtchData")]
    #endif
    [IsoXmlTag("ClrBtchData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClearingBatchData1? ClearingBatchData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClearingBatchData1? ClearingBatchData { get; init; } 
    #else
    public ClearingBatchData1? ClearingBatchData { get; set; } 
    #endif
    
    /// <summary>
    /// Gross amount clearing totals.
    /// </summary>
    [IsoId("_zoTbUFA9EeedyPuM0kK2EQ")]
    [DisplayName("Clearing Control Totals")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrCtrlTtls")]
    #endif
    [IsoXmlTag("ClrCtrlTtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClearingControlTotals1? ClearingControlTotals { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClearingControlTotals1? ClearingControlTotals { get; init; } 
    #else
    public ClearingControlTotals1? ClearingControlTotals { get; set; } 
    #endif
    
    /// <summary>
    /// Information or instructions relevant for the agent in charge of the clearing.
    /// </summary>
    [IsoId("_lwazkFA_EeedyPuM0kK2EQ")]
    [DisplayName("Agent Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtData")]
    #endif
    [IsoXmlTag("AgtData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation21? AgentData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation21? AgentData { get; init; } 
    #else
    public AdditionalInformation21? AgentData { get; set; } 
    #endif
    
    /// <summary>
    /// Record in batch.
    /// </summary>
    [IsoId("_gh0uIFBHEeedyPuM0kK2EQ")]
    [DisplayName("Record")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rcrd")]
    #endif
    [IsoXmlTag("Rcrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Record1? Record { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Record1? Record { get; init; } 
    #else
    public Record1? Record { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_qDF70RqmEeqH1IQNpbVpEw")]
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
