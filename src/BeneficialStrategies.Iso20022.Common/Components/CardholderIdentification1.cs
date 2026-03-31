// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the cardholder involved in a transaction.
/// </summary>
[IsoId("_SoWAKwEcEeCQm6a_G2yO_w_-1995265470")]
[DisplayName("Cardholder Identification")]
public record CardholderIdentification1
{
    /// <summary>
    /// Identification value of the cardholder involved in a transaction.
    /// </summary>
    [IsoId("_SoWALAEcEeCQm6a_G2yO_w_596422852")]
    [DisplayName("Cardholder Identification Value")]
    [IsoXmlTag("CrdhldrIdVal")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text CardholderIdentificationValue { get; init; }

    /// <summary>
    /// Type of identification used for identifying the cardholder.
    /// </summary>
    [IsoId("_SoWALQEcEeCQm6a_G2yO_w_-899306894")]
    [DisplayName("Cardholder Identification Type")]
    [IsoXmlTag("CrdhldrIdTp")]
    public required PersonIdentificationType4Code CardholderIdentificationType { get; init; }
}
