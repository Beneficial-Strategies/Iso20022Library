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
[IsoId("_l60LgXq_EeSA34QF-FhTBw")]
[DisplayName("Header")]
public record Header17
{
    /// <summary>
    /// Identifies the type of process related to the message.
    /// </summary>
    [IsoId("_mHyQgXq_EeSA34QF-FhTBw")]
    [DisplayName("Message Function")]
    [IsoXmlTag("MsgFctn")]
    public required MessageFunction6Code MessageFunction { get; init; }

    /// <summary>
    /// Version of the acquirer to issuer protocol specifications.
    /// </summary>
    [IsoId("_mHyQg3q_EeSA34QF-FhTBw")]
    [DisplayName("Protocol Version")]
    [IsoXmlTag("PrtcolVrsn")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6, MinimumLength = 1)]
    public required IsoMax6Text ProtocolVersion { get; init; }

    /// <summary>
    /// Unique identification of an exchange occurrence.
    /// </summary>
    [IsoId("_mHyQhXq_EeSA34QF-FhTBw")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public required IsoMax3NumericText ExchangeIdentification { get; init; }

    /// <summary>
    /// Number of retransmission of the message. Incremented by one for each retransmission.
    /// </summary>
    [IsoId("_GZ7nkHrTEeSfJf8ETXpBxg")]
    [DisplayName("Re Transmission Counter")]
    [IsoXmlTag("ReTrnsmssnCntr")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? ReTransmissionCounter { get; init; }

    /// <summary>
    /// Date and time at which the message was sent.
    /// </summary>
    [IsoId("_mHyQh3q_EeSA34QF-FhTBw")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    [IsoId("_mHyQiXq_EeSA34QF-FhTBw")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required GenericIdentification73 InitiatingParty { get; init; }

    /// <summary>
    /// Unique identification of the partner that is the recipient of the message exchange.
    /// </summary>
    [IsoId("_mHyQi3q_EeSA34QF-FhTBw")]
    [DisplayName("Recipient Party")]
    [IsoXmlTag("RcptPty")]
    public GenericIdentification73? RecipientParty { get; init; }

    /// <summary>
    /// Identification of partners involved in exchange from the merchant to the issuer, with the relative timestamp of their exchanges.
    /// </summary>
    [IsoId("_mHyQjXq_EeSA34QF-FhTBw")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public Traceability3? Traceability { get; init; }
}
