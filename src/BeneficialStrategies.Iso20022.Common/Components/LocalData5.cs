// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains text fields in the local language.
/// </summary>
[IsoId("_BD1sscW8EeuhguwJmlgagQ")]
[DisplayName("Local Data")]
public record LocalData5
{
    /// <summary>
    /// The language code conforming to ISO 639-1 that identifies the language in which the fields are expressed in this component.
    /// </summary>
    [IsoId("_BIoGEcW8EeuhguwJmlgagQ")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public required ISOMax3ALanguageCode Language { get; init; }

    /// <summary>
    /// Contains the full name of the sponsored merchant in the local language.
    /// </summary>
    [IsoId("_BIoGE8W8EeuhguwJmlgagQ")]
    [DisplayName("Common Name")]
    [IsoXmlTag("CmonNm")]
    [IsoSimpleType(IsoSimpleType.Max280Text)]
    [StringLength(maximumLength: 280, MinimumLength = 1)]
    public IsoMax280Text? CommonName { get; init; }

    /// <summary>
    /// Legal Corporate Name of the party
    /// </summary>
    [IsoId("_3_5Z0CB6Eey8XKHwKquEQw")]
    [DisplayName("Legal Corporate Name")]
    [IsoXmlTag("LglCorpNm")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? LegalCorporateName { get; init; }

    /// <summary>
    /// Structured postal address in the local language.
    /// </summary>
    [IsoId("_BIoGKcW8EeuhguwJmlgagQ")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address3? Address { get; init; }

    /// <summary>
    /// Additional information used when card acceptor street address is insufficient.
    /// </summary>
    [IsoId("_kaTCIMrZEeuQjLd-KKZrCg")]
    [DisplayName("Additional Address Information")]
    [IsoXmlTag("AddtlAdrInf")]
    [IsoSimpleType(IsoSimpleType.Max512Text)]
    [StringLength(maximumLength: 512, MinimumLength = 1)]
    public IsoMax512Text? AdditionalAddressInformation { get; init; }

    /// <summary>
    /// Additional local language data
    /// </summary>
    [IsoId("_s1OrEcXLEeumGdYElfgmbw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; }
}
