// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Alternate Party Identification11.
/// </summary>
[IsoId("_g5D4IaDcEe-CRv8HNM1RKw")]
[DisplayName("Alternate Party Identification11")]
public record AlternatePartyIdentification11
{
    /// <summary>
    /// Alternate Identification.
    /// </summary>
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public required IsoMax35Text AlternateIdentification { get; init; }

    /// <summary>
    /// Country.
    /// </summary>
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public required CountryCode Country { get; init; }

    /// <summary>
    /// Identification Type.
    /// </summary>
    [DisplayName("Identification Type")]
    [IsoXmlTag("IdTp")]
    public required IdentificationType46Choice_ IdentificationType { get; init; }
}
