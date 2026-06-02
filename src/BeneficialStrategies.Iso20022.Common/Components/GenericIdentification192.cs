// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of an entity.
/// </summary>
[IsoId("_blcNcbXxEfCUZfsQO4rYeA")]
[DisplayName("Generic Identification192")]
public record GenericIdentification192
{
    /// <summary>
    /// Identification of the entity.
    /// </summary>
    [IsoId("_boKxUbXxEfCUZfsQO4rYeA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Type of identified entity.
    /// </summary>
    [IsoId("_boKxU7XxEfCUZfsQO4rYeA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public PartyType35Code? Type { get; init; }

    /// <summary>
    /// Entity assigning the identification (for example merchant, acceptor, acquirer, or tax authority).
    /// </summary>
    [IsoId("_boKxVbXxEfCUZfsQO4rYeA")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyType4Code? Issuer { get; init; }

    /// <summary>
    /// Name of the entity.
    /// </summary>
    [IsoId("_boKxV7XxEfCUZfsQO4rYeA")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    public IsoMax35Text? ShortName { get; init; }
}
