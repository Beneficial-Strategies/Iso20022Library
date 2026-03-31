// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains credential information.
/// </summary>
[IsoId("_3tXfsad2EeuEcqP2FGAFaA")]
[DisplayName("Credentials")]
public record Credentials2
{
    /// <summary>
    /// Identification of the type of credential.
    /// </summary>
    [IsoId("_3zANoad2EeuEcqP2FGAFaA")]
    [DisplayName("Identification Code")]
    [IsoXmlTag("IdCd")]
    public required Identification3Code IdentificationCode { get; init; }

    /// <summary>
    /// Used when OtherNational or OtherPrivate value is selected in identification code list.
    /// </summary>
    [IsoId("_3zA0sad2EeuEcqP2FGAFaA")]
    [DisplayName("Other Identification Code")]
    [IsoXmlTag("OthrIdCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherIdentificationCode { get; init; }

    /// <summary>
    /// Value of identification.
    /// </summary>
    [IsoId("_3zA0s6d2EeuEcqP2FGAFaA")]
    [DisplayName("Identification Value")]
    [IsoXmlTag("IdVal")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public required IsoMax70Text IdentificationValue { get; init; }

    /// <summary>
    /// Expiration date of the identification.
    /// </summary>
    [IsoId("_HbqHgCX9Eeym0KcvJF9aDQ")]
    [DisplayName("Identification Expiry Date")]
    [IsoXmlTag("IdXpryDt")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    public IsoISOYearMonth? IdentificationExpiryDate { get; init; }

    /// <summary>
    /// Entity that assigns and manages this type of identification.
    /// </summary>
    [IsoId("_JSH9oKd8EeuEcqP2FGAFaA")]
    [DisplayName("Assigner Authority")]
    [IsoXmlTag("AssgnrAuthrty")]
    public Authority1? AssignerAuthority { get; init; }
}
