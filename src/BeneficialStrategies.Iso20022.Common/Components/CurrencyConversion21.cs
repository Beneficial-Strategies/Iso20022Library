// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Conversion between the currency of a card acceptor and the currency of a card issuer, provided by a dedicated service provider.
/// </summary>
[IsoId("_4l8twS82Eeu125Ip9zFcsQ")]
[DisplayName("Currency Conversion")]
public record CurrencyConversion21
{
    /// <summary>
    /// True if the cardholder has accepted the currency conversion that the acquirer has proposed.
    /// </summary>
    [IsoId("_4zW3oS82Eeu125Ip9zFcsQ")]
    [DisplayName("Accepted By Cardholder")]
    [IsoXmlTag("AccptdByCrdhldr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AcceptedByCardholder { get; init; }

    /// <summary>
    /// Conversion between the currency of a card acceptor and the currency of a cardholder, provided by a dedicated service provider.
    /// </summary>
    [IsoId("_4zW3oy82Eeu125Ip9zFcsQ")]
    [DisplayName("Conversion")]
    [IsoXmlTag("Convs")]
    public CurrencyConversion20? Conversion { get; init; }
}
