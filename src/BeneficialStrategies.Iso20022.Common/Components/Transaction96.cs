// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Batch management transaction.
/// </summary>
[IsoId("_3xcXwVA5EeedyPuM0kK2EQ")]
[DisplayName("Transaction")]
public partial record Transaction96
{
    #nullable enable
    
    /// <summary>
    /// Identification of the batch management transaction.
    /// </summary>
    [IsoId("_38KaBVA5EeedyPuM0kK2EQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public TransactionIdentification10? TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Identification of a batch.
    /// All the messages included within the batch will have the same batch identification value.
    /// </summary>
    [IsoId("_38KaCVA5EeedyPuM0kK2EQ")]
    [DisplayName("Batch Identification")]
    [IsoXmlTag("BtchId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? BatchIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the original batch to answer.
    /// Mandatory when the batch response has not the same identification as the batch initiation.
    /// </summary>
    [IsoId("_38KaDVA5EeedyPuM0kK2EQ")]
    [DisplayName("Original Batch Identification")]
    [IsoXmlTag("OrgnlBtchId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? OriginalBatchIdentification { get; init; } 
    
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
    [IsoXmlTag("NbOfMsgs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfMessages { get; init; } 
    
    /// <summary>
    /// Checksum of the series of messages received in the batch or until a checkpoint.
    /// </summary>
    [IsoId("_38KaFVA5EeedyPuM0kK2EQ")]
    [DisplayName("Batch Checksum")]
    [IsoXmlTag("BtchChcksm")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    public IsoMax35Binary? BatchChecksum { get; init; } 
    
    /// <summary>
    /// Indicator to request acknowlegement.
    /// True: Acknowledgement requested
    /// False: Acknowledgement not requested.
    /// </summary>
    [IsoId("_38KaF1A5EeedyPuM0kK2EQ")]
    [DisplayName("Request Acknowledgement")]
    [IsoXmlTag("ReqAck")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? RequestAcknowledgement { get; init; } 
    
    /// <summary>
    /// Clearing data at batch level allowing clearing in different currencies.
    /// </summary>
    [IsoId("_onRW0FA9EeedyPuM0kK2EQ")]
    [DisplayName("Clearing Batch Data")]
    [IsoXmlTag("ClrBtchData")]
    public ClearingBatchData1? ClearingBatchData { get; init; } 
    
    /// <summary>
    /// Gross amount clearing totals.
    /// </summary>
    [IsoId("_zoTbUFA9EeedyPuM0kK2EQ")]
    [DisplayName("Clearing Control Totals")]
    [IsoXmlTag("ClrCtrlTtls")]
    public ClearingControlTotals1? ClearingControlTotals { get; init; } 
    
    /// <summary>
    /// Information or instructions relevant for the agent in charge of the clearing.
    /// </summary>
    [IsoId("_lwazkFA_EeedyPuM0kK2EQ")]
    [DisplayName("Agent Data")]
    [IsoXmlTag("AgtData")]
    public AdditionalInformation21? AgentData { get; init; } 
    
    /// <summary>
    /// Record in batch.
    /// </summary>
    [IsoId("_gh0uIFBHEeedyPuM0kK2EQ")]
    [DisplayName("Record")]
    [IsoXmlTag("Rcrd")]
    public Record1? Record { get; init; } 
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_qDF70RqmEeqH1IQNpbVpEw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; } 
    
    
    #nullable disable
    
}
