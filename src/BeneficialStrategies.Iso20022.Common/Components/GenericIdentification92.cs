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
[IsoId("_BOt3EY3cEeW32YMP0mBeyw")]
[DisplayName("Generic Identification")]
public record GenericIdentification92
{
    /// <summary>
    /// Identification of the entity.
    /// </summary>
    [IsoId("_BaCWQY3cEeW32YMP0mBeyw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Type of identified entity.
    /// </summary>
    [IsoId("_BaCWQ43cEeW32YMP0mBeyw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public PartyType5Code? Type { get; init; }

    /// <summary>
    /// Entity assigning the identification (for example merchant, acceptor, acquirer, or tax authority).
    /// </summary>
    [IsoId("_BaCWRY3cEeW32YMP0mBeyw")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyType6Code? Issuer { get; init; }

    /// <summary>
    /// Country of the entity (ISO 3166-1 alpha-2 or alpha-3).
    /// </summary>
    [IsoId("_BaCWR43cEeW32YMP0mBeyw")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    [IsoSimpleType(IsoSimpleType.Min2Max3AlphaText)]
    public IsoMin2Max3AlphaText? Country { get; init; }

    /// <summary>
    /// Name of the entity.
    /// </summary>
    [IsoId("_BaCWSY3cEeW32YMP0mBeyw")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; }

    /// <summary>
    /// Access information to reach the target host.
    /// </summary>
    [IsoId("_KOWEgI3cEeW32YMP0mBeyw")]
    [DisplayName("Remote Access")]
    [IsoXmlTag("RmotAccs")]
    public NetworkParameters5? RemoteAccess { get; init; }
}
