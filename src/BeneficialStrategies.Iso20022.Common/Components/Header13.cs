// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics related to the protocol after a rejection.
/// </summary>
[IsoId("_Hl7pwWpCEeS4VPLpYyQgxQ")]
[DisplayName("Header")]
public record Header13
{
    /// <summary>
    /// Identifies the type of process related to the message.
    /// </summary>
    [IsoId("_HyTR0WpCEeS4VPLpYyQgxQ")]
    [DisplayName("Message Function")]
    [IsoXmlTag("MsgFctn")]
    public required MessageFunction4Code MessageFunction { get; init; }

    /// <summary>
    /// Version of the acquirer protocol specifications.
    /// </summary>
    [IsoId("_HyTR02pCEeS4VPLpYyQgxQ")]
    [DisplayName("Protocol Version")]
    [IsoXmlTag("PrtcolVrsn")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6, MinimumLength = 1)]
    public required IsoMax6Text ProtocolVersion { get; init; }

    /// <summary>
    /// Unique identification of an exchange occurrence.
    /// </summary>
    [IsoId("_HyTR1WpCEeS4VPLpYyQgxQ")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? ExchangeIdentification { get; init; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_HyTR12pCEeS4VPLpYyQgxQ")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    [IsoId("_HyTR2WpCEeS4VPLpYyQgxQ")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public GenericIdentification53? InitiatingParty { get; init; }

    /// <summary>
    /// Unique identification of the partner that is the recipient of the message exchange.
    /// </summary>
    [IsoId("_HyTR22pCEeS4VPLpYyQgxQ")]
    [DisplayName("Recipient Party")]
    [IsoXmlTag("RcptPty")]
    public GenericIdentification53? RecipientParty { get; init; }

    /// <summary>
    /// Identification of partners involved in exchange from the merchant to the issuer, with the relative timestamp of their exchanges.
    /// </summary>
    [IsoId("_HyTR3WpCEeS4VPLpYyQgxQ")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public ValueList<Traceability2> Traceability { get; init; } = [];
}
