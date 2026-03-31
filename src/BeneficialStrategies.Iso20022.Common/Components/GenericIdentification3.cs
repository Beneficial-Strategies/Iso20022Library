// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to an identification, for example, party identification or account identification.
/// </summary>
[IsoId("_P-sWcdp-Ed-ak6NoX_4Aeg_1185673654")]
[DisplayName("Generic Identification")]
public record GenericIdentification3
{
    /// <summary>
    /// Name or number assigned by an entity to enable recognition of that entity, for example, account identifier.
    /// </summary>
    [IsoId("_P-sWctp-Ed-ak6NoX_4Aeg_1256785338")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    [IsoId("_P-sWc9p-Ed-ak6NoX_4Aeg_1555083105")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; }
}
