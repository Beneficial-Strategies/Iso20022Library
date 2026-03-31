// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics related to the reject of a transaction.
/// </summary>
[IsoId("_Ns0VYWp3EeSojYXQbRlLzA")]
[DisplayName("Header")]
public record Header16
{
    /// <summary>
    /// Version of the terminal management protocol specifications.
    /// </summary>
    [IsoId("_ecq94Gp3EeSojYXQbRlLzA")]
    [DisplayName("Protocol Version")]
    [IsoXmlTag("PrtcolVrsn")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6, MinimumLength = 1)]
    public required IsoMax6Text ProtocolVersion { get; init; }

    /// <summary>
    /// Unique identification of an exchange occurrence.
    /// </summary>
    [IsoId("_N6FVVWp3EeSojYXQbRlLzA")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? ExchangeIdentification { get; init; }

    /// <summary>
    /// Date and time at which the file or message was created.
    /// </summary>
    [IsoId("_N6FVV2p3EeSojYXQbRlLzA")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    [IsoId("_N6FVWWp3EeSojYXQbRlLzA")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required GenericIdentification72 InitiatingParty { get; init; }

    /// <summary>
    /// Unique identification of the partner that is the recipient of the exchange.
    /// </summary>
    [IsoId("_N6FVW2p3EeSojYXQbRlLzA")]
    [DisplayName("Recipient Party")]
    [IsoXmlTag("RcptPty")]
    public GenericIdentification72? RecipientParty { get; init; }
}
