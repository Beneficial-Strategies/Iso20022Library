// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics related to the protocol.
/// </summary>
[IsoId("_XLTzkR7XEfCkq6-p7S3J1Q")]
[DisplayName("Header72")]
public record Header72
{
    /// <summary>
    /// Identifies the type of process related to the message.
    /// </summary>
    [IsoId("_XYNnIR7XEfCkq6-p7S3J1Q")]
    [DisplayName("Message Function")]
    [IsoXmlTag("MsgFctn")]
    public required ExternalMessageFunction1Code MessageFunction { get; init; }

    /// <summary>
    /// Version of the acquirer to issuer protocol specifications.
    /// </summary>
    [IsoId("_XYNnIx7XEfCkq6-p7S3J1Q")]
    [DisplayName("Protocol Version")]
    [IsoXmlTag("PrtcolVrsn")]
    public IsoMax2048Text? ProtocolVersion { get; init; }

    /// <summary>
    /// Unique identification of an exchange of messages between two parties.
    /// </summary>
    [IsoId("_XYNnJR7XEfCkq6-p7S3J1Q")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    public IsoMax35Text? ExchangeIdentification { get; init; }

    /// <summary>
    /// Number of retransmission of the message. Incremented by one for each retransmission.
    /// </summary>
    [IsoId("_XYNnJx7XEfCkq6-p7S3J1Q")]
    [DisplayName("Re Transmission Counter")]
    [IsoXmlTag("ReTrnsmssnCntr")]
    public IsoMax3NumericText? ReTransmissionCounter { get; init; }

    /// <summary>
    /// Date and time at which the message was sent.
    /// </summary>
    [IsoId("_XYNnKR7XEfCkq6-p7S3J1Q")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public IsoISODateTime? CreationDateTime { get; init; }

    /// <summary>
    /// Identification of the collection to which the batch belongs.
    /// </summary>
    [IsoId("_fNEOFB7YEfCkq6-p7S3J1Q")]
    [DisplayName("Collection Identification")]
    [IsoXmlTag("ColltnId")]
    public IsoMax35Text? CollectionIdentification { get; init; }

    /// <summary>
    /// Identification of the batch to which the message belongs.
    /// </summary>
    [IsoId("_fNEOFR7YEfCkq6-p7S3J1Q")]
    [DisplayName("Batch Identification")]
    [IsoXmlTag("BtchId")]
    public IsoMax35Text? BatchIdentification { get; init; }

    /// <summary>
    /// Sequence number of the message inside the batch.
    /// </summary>
    [IsoId("_fNEOFh7YEfCkq6-p7S3J1Q")]
    [DisplayName("Message Sequence Number")]
    [IsoXmlTag("MsgSeqNb")]
    public IsoMax15NumericText? MessageSequenceNumber { get; init; }

    /// <summary>
    /// Value of the message to use for the computation of the checksum of the batch or collection of messages.
    /// </summary>
    [IsoId("_fNEOFx7YEfCkq6-p7S3J1Q")]
    [DisplayName("Message Checksum Input Value")]
    [IsoXmlTag("MsgChcksmInptVal")]
    public IsoMax140Binary? MessageChecksumInputValue { get; init; }

    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    [IsoId("_XYNnLR7XEfCkq6-p7S3J1Q")]
    [DisplayName("Initiating Party Identification")]
    [IsoXmlTag("InitgPtyId")]
    public IsoMax35Text? InitiatingPartyIdentification { get; init; }

    /// <summary>
    /// Unique identification of the partner that is the recipient of the message exchange.
    /// </summary>
    [IsoId("_XYNnLx7XEfCkq6-p7S3J1Q")]
    [DisplayName("Recipient Party Identification")]
    [IsoXmlTag("RcptPtyId")]
    public IsoMax35Text? RecipientPartyIdentification { get; init; }

    /// <summary>
    /// Information sent in the request message to be returned in the response one, for instance to help in the retrieval of the context of the exchange.
    /// </summary>
    [IsoId("_XYNnMR7XEfCkq6-p7S3J1Q")]
    [DisplayName("Trace Data")]
    [IsoXmlTag("TracData")]
    public IsoMax70Text? TraceData { get; init; }
}
