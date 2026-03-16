// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a security.
/// </summary>
[IsoId("_W9k0Idp-Ed-ak6NoX_4Aeg_-702562121")]
[DisplayName("Security Identification")]
public record SecurityIdentification12
{
    /// <summary>
    /// Identification of a security.
    /// </summary>
    [IsoId("_W9k0Itp-Ed-ak6NoX_4Aeg_-87061904")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification12Choice_ Identification { get; init; }

    /// <summary>
    /// Textual description of a security instrument.
    /// </summary>
    [IsoId("_W9k0I9p-Ed-ak6NoX_4Aeg_1508646071")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoRestrictedFINXMax140Text? Description { get; init; }
}
