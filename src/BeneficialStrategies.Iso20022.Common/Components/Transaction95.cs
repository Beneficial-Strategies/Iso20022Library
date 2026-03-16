// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Batch management transaction.
/// </summary>
[IsoId("_0xLc0FAaEeedyPuM0kK2EQ")]
[DisplayName("Transaction")]
public record Transaction95
{
    /// <summary>
    /// Type of batch management activity.
    /// ISO 8583:87/93 bit 24
    /// ISO 8583:2003 bit 68-1
    /// </summary>
    [IsoId("__bmYIFAaEeedyPuM0kK2EQ")]
    [DisplayName("Batch Management Type")]
    [IsoXmlTag("BtchMgmtTp")]
    public required BatchManagementType1Code BatchManagementType { get; init; }

    /// <summary>
    /// Other type of batch management activity.
    /// </summary>
    [IsoId("_GD6I4FAbEeedyPuM0kK2EQ")]
    [DisplayName("Other Batch Management Type")]
    [IsoXmlTag("OthrBtchMgmtTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherBatchManagementType { get; init; }

    /// <summary>
    /// Identification of the batch management transaction.
    /// </summary>
    [IsoId("_QsZKgFAbEeedyPuM0kK2EQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public TransactionIdentification10? TransactionIdentification { get; init; }

    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_95zpg_F6EeiGNursv3uE_g")]
    [DisplayName("Additional Fees")]
    [IsoXmlTag("AddtlFees")]
    public AdditionalFee1? AdditionalFees { get; init; }

    /// <summary>
    /// Identification of a collection.
    /// Mandatory for start or end of a collection and their acknowledgements if the batch is included in a collection.
    /// All the messages included within the collection will have the same collection identification value.
    /// </summary>
    [IsoId("_7nNEAFAbEeedyPuM0kK2EQ")]
    [DisplayName("Collection Identification")]
    [IsoXmlTag("ColltnId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? CollectionIdentification { get; init; }

    /// <summary>
    /// Identification of a batch.
    /// All the messages included within the batch will have the same batch identification value.
    /// </summary>
    [IsoId("_Fwck4FAcEeedyPuM0kK2EQ")]
    [DisplayName("Batch Identification")]
    [IsoXmlTag("BtchId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? BatchIdentification { get; init; }

    /// <summary>
    /// Total length in bytes of the collection to be transferred.
    /// ISO 8583:2003 bit 70-2
    /// </summary>
    [IsoId("_SgZWQGeqEeeuT9Qn0D6Z_w")]
    [DisplayName("Collection Size")]
    [IsoXmlTag("ColltnSz")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? CollectionSize { get; init; }

    /// <summary>
    /// Identification of the original collection.
    /// Mandatory when the collection containing the batch response has not the same identification as the collection containing the original batch.
    /// </summary>
    [IsoId("_VBJHwFAcEeedyPuM0kK2EQ")]
    [DisplayName("Original Collection Identification")]
    [IsoXmlTag("OrgnlColltnId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? OriginalCollectionIdentification { get; init; }

    /// <summary>
    /// Identification of the original batch to answer.
    /// Mandatory when the batch response has not the same identification as the batch initiation.
    /// </summary>
    [IsoId("_iWqXYFAcEeedyPuM0kK2EQ")]
    [DisplayName("Original Batch Identification")]
    [IsoXmlTag("OrgnlBtchId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? OriginalBatchIdentification { get; init; }

    /// <summary>
    /// Number of batches in the collection.
    /// For a start of collection, this is the number of expected batches if known.
    /// For a start of collection acknowledgement, this is the maximum number of batches that can be received in the collection.
    /// For an end of collection, this is the number of batches sent in the closing collection.
    /// For an end of collection acknowledgement, this is the number of batches received in the collection.
    /// </summary>
    [IsoId("_ArVPwFAdEeedyPuM0kK2EQ")]
    [DisplayName("Number Of Batches In Collection")]
    [IsoXmlTag("NbOfBtchsInColltn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfBatchesInCollection { get; init; }

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
    [IsoXmlTag("NbOfMsgs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfMessages { get; init; }

    /// <summary>
    /// Number of remaining messages in the collection.
    /// ISO 8583:2003 bit 70-3
    /// </summary>
    [IsoId("_tJqT4GeqEeeuT9Qn0D6Z_w")]
    [DisplayName("Remaining Messages In Collection")]
    [IsoXmlTag("RmngMsgsInColltn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? RemainingMessagesInCollection { get; init; }

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
    [IsoXmlTag("MsgSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? MessageSequenceNumber { get; init; }

    /// <summary>
    /// List of batch identifications of the collection.
    /// For a start of collection, the identification of expected batches, if known.
    /// For an end of collection, this is the identification of batches sent in the closing collection.
    /// For an end of collection acknowledgement, this is the identification of batches received in the collection.
    /// </summary>
    [IsoId("_ARN0sFAfEeedyPuM0kK2EQ")]
    [DisplayName("Batch Identification List")]
    [IsoXmlTag("BtchIdList")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? BatchIdentificationList { get; init; }

    /// <summary>
    /// Identification of a specific checkpoint.
    /// </summary>
    [IsoId("_iad08d3xEeieV46qhAnbyQ")]
    [DisplayName("Checkpoint Identification")]
    [IsoXmlTag("ChckptId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? CheckpointIdentification { get; init; }

    /// <summary>
    /// Checksum of the series of messages in the batch or until a checkpoint.
    /// </summary>
    [IsoId("_KAk18FAfEeedyPuM0kK2EQ")]
    [DisplayName("Batch Checksum")]
    [IsoXmlTag("BtchChcksm")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    public IsoMax35Binary? BatchChecksum { get; init; }

    /// <summary>
    /// Indicator to request acknowledgement.
    /// True: Acknowledgement requested
    /// False: Acknowledgement not requested.
    /// </summary>
    [IsoId("_pvoBoFAfEeedyPuM0kK2EQ")]
    [DisplayName("Request Acknowledgement")]
    [IsoXmlTag("ReqAck")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? RequestAcknowledgement { get; init; }

    /// <summary>
    /// Maximum number of messages to be sent before acknowledgement. The receiver will send an acknowledgement response every time the indicated number of messages is reached.
    /// </summary>
    [IsoId("_MNVzAFAgEeedyPuM0kK2EQ")]
    [DisplayName("Messages Before Acknowledgement")]
    [IsoXmlTag("MsgsBfrAck")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MessagesBeforeAcknowledgement { get; init; }

    /// <summary>
    /// Indicate whether the acknowledgement is positive or not.
    /// True: Positive acknowledgement.
    /// False: Negative acknowledgement.
    /// </summary>
    [IsoId("_cdRlUFAgEeedyPuM0kK2EQ")]
    [DisplayName("Positive Acknowledgement")]
    [IsoXmlTag("PostvAck")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? PositiveAcknowledgement { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_gFmX8RqmEeqH1IQNpbVpEw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; }
}
