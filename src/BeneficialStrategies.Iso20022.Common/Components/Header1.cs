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
[IsoId("_SvV__wEcEeCQm6a_G2yO_w_677025486")]
[DisplayName("Header")]
public record Header1
{
    /// <summary>
    /// Identifies the type of process related to the message.
    /// </summary>
    [IsoId("_Svfw8AEcEeCQm6a_G2yO_w_563186420")]
    [DisplayName("Message Function")]
    [IsoXmlTag("MsgFctn")]
    public required MessageFunction1Code MessageFunction { get; init; }

    /// <summary>
    /// Version of the acquirer protocol specifications.
    /// </summary>
    [IsoId("_Svfw8QEcEeCQm6a_G2yO_w_-433885933")]
    [DisplayName("Protocol Version")]
    [IsoXmlTag("PrtcolVrsn")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6, MinimumLength = 1)]
    public required IsoMax6Text ProtocolVersion { get; init; }

    /// <summary>
    /// Unique identification of an exchange occurrence.
    /// </summary>
    [IsoId("_Svfw8gEcEeCQm6a_G2yO_w_-1430958286")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public required IsoMax3NumericText ExchangeIdentification { get; init; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_Svfw8wEcEeCQm6a_G2yO_w_869864304")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    [IsoId("_Svfw9AEcEeCQm6a_G2yO_w_1730336137")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required GenericIdentification32 InitiatingParty { get; init; }

    /// <summary>
    /// Unique identification of the partner that is the recipient of the message exchange.
    /// </summary>
    [IsoId("_Svfw9QEcEeCQm6a_G2yO_w_-441232965")]
    [DisplayName("Recipient Party")]
    [IsoXmlTag("RcptPty")]
    public GenericIdentification32? RecipientParty { get; init; }

    /// <summary>
    /// Identification of partners involved in exchange from the merchant to the issuer, with the relative timestamp of their exchanges.
    /// </summary>
    [IsoId("_Svfw9gEcEeCQm6a_G2yO_w_-2121352755")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public ValueList<Traceability1> Traceability { get; init; } = [];
}
