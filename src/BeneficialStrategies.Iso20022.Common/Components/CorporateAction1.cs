// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// An event determined by a corporation&apos;s board of directors, that changes the existing corporate capital structure or financial condition.
/// </summary>
[IsoId("_TdBeiNp-Ed-ak6NoX_4Aeg_-1683156107")]
[DisplayName("Corporate Action")]
public record CorporateAction1
{
    /// <summary>
    /// Specifies the code of corporate action event, in free-text format.
    /// </summary>
    [IsoId("_TdKocNp-Ed-ak6NoX_4Aeg_-1320212655")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Code { get; init; }

    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_TdKocdp-Ed-ak6NoX_4Aeg_-1122577775")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Number { get; init; }

    /// <summary>
    /// Proprietary corporate action event information.
    /// </summary>
    [IsoId("_TdKoctp-Ed-ak6NoX_4Aeg_-788263855")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Proprietary { get; init; }
}
