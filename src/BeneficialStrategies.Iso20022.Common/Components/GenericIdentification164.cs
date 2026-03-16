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
[IsoId("_BXLWUThQEeaTjZWmPo-9OA")]
[DisplayName("Generic Identification")]
public record GenericIdentification164
{
    /// <summary>
    /// Name or number assigned by an entity to enable recognition of that entity, for example, account identifier.
    /// </summary>
    [IsoId("_BvkoNThQEeaTjZWmPo-9OA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Specifies the nature of the identifier.
    /// </summary>
    [IsoId("_BvkoNzhQEeaTjZWmPo-9OA")]
    [DisplayName("Identification Type")]
    [IsoXmlTag("IdTp")]
    public required OtherIdentification3Choice_ IdentificationType { get; init; }

    /// <summary>
    /// Entity that assigns the identifier.
    /// </summary>
    [IsoId("_BvkoOzhQEeaTjZWmPo-9OA")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; }
}
