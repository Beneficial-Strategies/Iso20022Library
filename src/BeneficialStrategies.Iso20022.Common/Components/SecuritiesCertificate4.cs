// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Physical representation of a security.
/// </summary>
[IsoId("_fTKNkTtHEeWRTLSN0i0tng")]
[DisplayName("Securities Certificate")]
public record SecuritiesCertificate4
{
    /// <summary>
    /// Unique and unambiguous identifier of a certificate assigned by the issuer.
    /// </summary>
    [IsoId("_f0oi9ztHEeWRTLSN0i0tng")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Number { get; init; }

    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_f0oi_ztHEeWRTLSN0i0tng")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; }

    /// <summary>
    /// Short textual description of the scheme.
    /// </summary>
    [IsoId("_f0ojBztHEeWRTLSN0i0tng")]
    [DisplayName("Scheme Name")]
    [IsoXmlTag("SchmeNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SchemeName { get; init; }
}
