// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Service provided by the ATM inside the session.
/// </summary>
[IsoId("_hV3nAa4YEeW_TaP-ygI0SQ")]
[DisplayName("ATM Service")]
public record ATMService18
{
    /// <summary>
    /// Identification of the service variant.
    /// </summary>
    [IsoId("_hhgPQa4YEeW_TaP-ygI0SQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Label of the service variant.
    /// </summary>
    [IsoId("_hhgPQ64YEeW_TaP-ygI0SQ")]
    [DisplayName("Label")]
    [IsoXmlTag("Labl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Label { get; init; }
}
