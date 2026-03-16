// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to an identification, eg, party identification or account identification.
/// </summary>
[IsoId("_VC8Tdtp-Ed-ak6NoX_4Aeg_198571543")]
[DisplayName("Generic Identification")]
public record GenericIdentification8
{
    /// <summary>
    /// Name or number assigned by an entity to enable recognition of that entity, eg, account identifier.
    /// </summary>
    [IsoId("_VC8Td9p-Ed-ak6NoX_4Aeg_272452388")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Specifies the nature of the identifier.
    /// </summary>
    [IsoId("_VC8TeNp-Ed-ak6NoX_4Aeg_272452311")]
    [DisplayName("Identification Type")]
    [IsoXmlTag("IdTp")]
    public required IdentificationType1 IdentificationType { get; init; }

    /// <summary>
    /// Entity that assigns the identifier.
    /// </summary>
    [IsoId("_VC8Tedp-Ed-ak6NoX_4Aeg_1583085770")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; }
}
