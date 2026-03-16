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
/// Header for an amendment message.
/// </summary>
[IsoId("_PgRJoRymEeyVgKPonV4SjQ")]
[DisplayName("Header")]
public record Header65
{
    /// <summary>
    /// Identifies the type of process related to the message.
    /// </summary>
    [IsoId("_PndWwRymEeyVgKPonV4SjQ")]
    [DisplayName("Message Function")]
    [IsoXmlTag("MsgFctn")]
    public required MessageFunction27Code MessageFunction { get; init; }

    /// <summary>
    /// Version of the acquirer to issuer protocol specifications.
    /// </summary>
    [IsoId("_PndWwxymEeyVgKPonV4SjQ")]
    [DisplayName("Protocol Version")]
    [IsoXmlTag("PrtcolVrsn")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048, MinimumLength = 1)]
    public required IsoMax2048Text ProtocolVersion { get; init; }

    /// <summary>
    /// Unique identification of an exchange of messages between two parties.
    /// </summary>
    [IsoId("_PndWxRymEeyVgKPonV4SjQ")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ExchangeIdentification { get; init; }

    /// <summary>
    /// Number of retransmission of the message. Incremented by one for each retransmission.
    /// </summary>
    [IsoId("_PndWxxymEeyVgKPonV4SjQ")]
    [DisplayName("Re Transmission Counter")]
    [IsoXmlTag("ReTrnsmssnCntr")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? ReTransmissionCounter { get; init; }

    /// <summary>
    /// Date and time at which the message was sent.
    /// </summary>
    [IsoId("_PndWyRymEeyVgKPonV4SjQ")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Information related to the batch and the collection to which the message belongs if any.
    /// </summary>
    [IsoId("_PndWyxymEeyVgKPonV4SjQ")]
    [DisplayName("Batch Management Information")]
    [IsoXmlTag("BtchMgmtInf")]
    public BatchManagementInformation1? BatchManagementInformation { get; init; }

    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    [IsoId("_PndWzRymEeyVgKPonV4SjQ")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required GenericIdentification183 InitiatingParty { get; init; }

    /// <summary>
    /// Unique identification of the partner that is the recipient of the message exchange.
    /// </summary>
    [IsoId("_PndWzxymEeyVgKPonV4SjQ")]
    [DisplayName("Recipient Party")]
    [IsoXmlTag("RcptPty")]
    public GenericIdentification183? RecipientParty { get; init; }

    /// <summary>
    /// Information sent in the request message to be returned in the response one, for instance to help in the retrieval of the context of the exchange.
    /// </summary>
    [IsoId("_PndW0RymEeyVgKPonV4SjQ")]
    [DisplayName("Trace Data")]
    [IsoXmlTag("TracData")]
    public ValueList<AdditionalData1> TraceData { get; init; } = [];

    /// <summary>
    /// Identification of partners involved in exchange from the merchant to the issuer, with the relative timestamp of their exchanges.
    /// </summary>
    [IsoId("_PndW0xymEeyVgKPonV4SjQ")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public ValueList<Traceability9> Traceability { get; init; } = [];
}
