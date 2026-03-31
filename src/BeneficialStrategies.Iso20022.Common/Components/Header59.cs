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
[IsoId("_Rz5m4S_aEeugIJ3Gvoevmg")]
[DisplayName("Header")]
public record Header59
{
    /// <summary>
    /// Identifies the type of process related to the message.
    /// </summary>
    [IsoId("_SHEagS_aEeugIJ3Gvoevmg")]
    [DisplayName("Message Function")]
    [IsoXmlTag("MsgFctn")]
    public required MessageFunction42Code MessageFunction { get; init; }

    /// <summary>
    /// Version of the acquirer protocol specifications.
    /// </summary>
    [IsoId("_SHEagy_aEeugIJ3Gvoevmg")]
    [DisplayName("Protocol Version")]
    [IsoXmlTag("PrtcolVrsn")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6, MinimumLength = 1)]
    public required IsoMax6Text ProtocolVersion { get; init; }

    /// <summary>
    /// Unique identification of an exchange occurrence.
    /// </summary>
    [IsoId("_SHEahS_aEeugIJ3Gvoevmg")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber ExchangeIdentification { get; init; }

    /// <summary>
    /// Number of retransmissions of the message.
    /// </summary>
    [IsoId("_SHEahy_aEeugIJ3Gvoevmg")]
    [DisplayName("Re Transmission Counter")]
    [IsoXmlTag("ReTrnsmssnCntr")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? ReTransmissionCounter { get; init; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_SHEaiS_aEeugIJ3Gvoevmg")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    [IsoId("_SHEaiy_aEeugIJ3Gvoevmg")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required GenericIdentification176 InitiatingParty { get; init; }

    /// <summary>
    /// Unique identification of the partner that is the recipient of the message exchange.
    /// </summary>
    [IsoId("_SHEajS_aEeugIJ3Gvoevmg")]
    [DisplayName("Recipient Party")]
    [IsoXmlTag("RcptPty")]
    public GenericIdentification177? RecipientParty { get; init; }

    /// <summary>
    /// Identification of partners involved in exchange from the merchant to the issuer, with the relative timestamp of their exchanges.
    /// </summary>
    [IsoId("_SHEajy_aEeugIJ3Gvoevmg")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public ValueList<Traceability8> Traceability { get; init; } = [];
}
