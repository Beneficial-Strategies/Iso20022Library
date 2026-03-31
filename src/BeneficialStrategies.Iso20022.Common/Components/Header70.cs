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
[IsoId("_15eK4XJLEe299ZbWCkdR_w")]
[DisplayName("Header")]
public record Header70
{
    /// <summary>
    /// Identifies the type of process related to the message.
    /// </summary>
    [IsoId("_2BNxoXJLEe299ZbWCkdR_w")]
    [DisplayName("Message Function")]
    [IsoXmlTag("MsgFctn")]
    public required MessageFunction46Code MessageFunction { get; init; }

    /// <summary>
    /// Version of the acquirer protocol specifications.
    /// </summary>
    [IsoId("_2BNxo3JLEe299ZbWCkdR_w")]
    [DisplayName("Protocol Version")]
    [IsoXmlTag("PrtcolVrsn")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6, MinimumLength = 1)]
    public required IsoMax6Text ProtocolVersion { get; init; }

    /// <summary>
    /// Unique identification of an exchange occurrence.
    /// </summary>
    [IsoId("_2BNxpXJLEe299ZbWCkdR_w")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber ExchangeIdentification { get; init; }

    /// <summary>
    /// Number of retransmissions of the message.
    /// </summary>
    [IsoId("_2BNxp3JLEe299ZbWCkdR_w")]
    [DisplayName("Re Transmission Counter")]
    [IsoXmlTag("ReTrnsmssnCntr")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? ReTransmissionCounter { get; init; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_2BNxqXJLEe299ZbWCkdR_w")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    [IsoId("_2BNxq3JLEe299ZbWCkdR_w")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required GenericIdentification176 InitiatingParty { get; init; }

    /// <summary>
    /// Unique identification of the partner that is the recipient of the message exchange.
    /// </summary>
    [IsoId("_2BNxrXJLEe299ZbWCkdR_w")]
    [DisplayName("Recipient Party")]
    [IsoXmlTag("RcptPty")]
    public GenericIdentification177? RecipientParty { get; init; }

    /// <summary>
    /// Identification of partners involved in exchange from the merchant to the issuer, with the relative timestamp of their exchanges.
    /// </summary>
    [IsoId("_2BNxr3JLEe299ZbWCkdR_w")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public ValueList<Traceability8> Traceability { get; init; } = [];
}
