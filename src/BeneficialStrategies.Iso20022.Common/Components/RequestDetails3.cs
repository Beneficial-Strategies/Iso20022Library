// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of data request.
/// </summary>
[IsoId("_SuwKGQEcEeCQm6a_G2yO_w_49393758")]
[DisplayName("Request Details")]
public record RequestDetails3
{
    /// <summary>
    /// Type of data being requested, for example, a sub-member BIC.
    /// </summary>
    [IsoId("_SuwKGgEcEeCQm6a_G2yO_w_-1627802492")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Type { get; init; }

    /// <summary>
    /// Specific report data requested, for example, a BIC.
    /// </summary>
    [IsoId("_SuwKGwEcEeCQm6a_G2yO_w_467150931")]
    [DisplayName("Key")]
    [IsoXmlTag("Key")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Key { get; init; }
}
