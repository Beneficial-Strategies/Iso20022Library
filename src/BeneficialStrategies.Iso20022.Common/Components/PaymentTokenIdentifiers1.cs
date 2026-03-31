// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifier of a token provider requestor.
/// </summary>
[IsoId("_PxXUcGkhEeSTIuB9A-QJ6g")]
[DisplayName("Payment Token Identifiers")]
public record PaymentTokenIdentifiers1
{
    /// <summary>
    /// Identifier of the token provider.
    /// </summary>
    [IsoId("_XWGRMGkhEeSTIuB9A-QJ6g")]
    [DisplayName("Provider Identification")]
    [IsoXmlTag("PrvdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ProviderIdentification { get; init; }

    /// <summary>
    /// Identifier of the token requestor.
    /// </summary>
    [IsoId("_eIqKIGkhEeSTIuB9A-QJ6g")]
    [DisplayName("Requestor Identification")]
    [IsoXmlTag("RqstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text RequestorIdentification { get; init; }
}
