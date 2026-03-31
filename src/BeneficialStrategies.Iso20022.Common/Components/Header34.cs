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
[IsoId("_begWIBCJEeeriKqGwDrUEg")]
[DisplayName("Header")]
public record Header34
{
    /// <summary>
    /// Identifies the type of process related to the message.
    /// </summary>
    [IsoId("_b31cIRCJEeeriKqGwDrUEg")]
    [DisplayName("Message Function")]
    [IsoXmlTag("MsgFctn")]
    public required MessageFunction13Code MessageFunction { get; init; }

    /// <summary>
    /// Version of the acquirer protocol specifications.
    /// </summary>
    [IsoId("_b31cIxCJEeeriKqGwDrUEg")]
    [DisplayName("Protocol Version")]
    [IsoXmlTag("PrtcolVrsn")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6, MinimumLength = 1)]
    public required IsoMax6Text ProtocolVersion { get; init; }

    /// <summary>
    /// Unique identification of an exchange occurrence.
    /// </summary>
    [IsoId("_b31cJRCJEeeriKqGwDrUEg")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber ExchangeIdentification { get; init; }

    /// <summary>
    /// Number of retransmissions of the message.
    /// </summary>
    [IsoId("_b31cJxCJEeeriKqGwDrUEg")]
    [DisplayName("Re Transmission Counter")]
    [IsoXmlTag("ReTrnsmssnCntr")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? ReTransmissionCounter { get; init; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_b31cKRCJEeeriKqGwDrUEg")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    [IsoId("_b31cKxCJEeeriKqGwDrUEg")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required GenericIdentification53 InitiatingParty { get; init; }

    /// <summary>
    /// Unique identification of the partner that is the recipient of the message exchange.
    /// </summary>
    [IsoId("_b31cLRCJEeeriKqGwDrUEg")]
    [DisplayName("Recipient Party")]
    [IsoXmlTag("RcptPty")]
    public GenericIdentification94? RecipientParty { get; init; }

    /// <summary>
    /// Identification of partners involved in exchange from the merchant to the issuer, with the relative timestamp of their exchanges.
    /// </summary>
    [IsoId("_b31cLxCJEeeriKqGwDrUEg")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public ValueList<Traceability5> Traceability { get; init; } = [];
}
