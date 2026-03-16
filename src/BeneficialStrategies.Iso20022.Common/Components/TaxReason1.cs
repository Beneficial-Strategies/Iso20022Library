// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason why the service is taxed.
/// </summary>
[IsoId("_6TrGE5qlEeGSON8vddiWzQ_2115552253")]
[DisplayName("Tax Reason")]
public record TaxReason1
{
    /// <summary>
    /// Reason why the service is taxed, in a coded form.
    /// </summary>
    [IsoId("_6TrGFJqlEeGSON8vddiWzQ_-393693755")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10, MinimumLength = 1)]
    public required IsoMax10Text Code { get; init; }

    /// <summary>
    /// Reason why the service is taxed, in a free-text form.
    /// </summary>
    [IsoId("_6TrGFZqlEeGSON8vddiWzQ_887562025")]
    [DisplayName("Explanation")]
    [IsoXmlTag("Expltn")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105, MinimumLength = 1)]
    public required IsoMax105Text Explanation { get; init; }
}
