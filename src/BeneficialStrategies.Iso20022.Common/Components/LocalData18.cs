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
[IsoId("_TXee8RT6EfC_aaedwHHlmw")]
[DisplayName("Local Data18")]
public record LocalData18
{
    /// <summary>
    /// The language code conforming to ISO 639-1 that identifies the language in which the fields are expressed in this component.
    /// </summary>
    [IsoId("_TeY_QRT6EfC_aaedwHHlmw")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public required ISOMax3ALanguageCode Language { get; init; }

    /// <summary>
    /// Data encoding format for local data.
    /// </summary>
    [IsoId("_TeY_QxT6EfC_aaedwHHlmw")]
    [DisplayName("Encoding Format")]
    [IsoXmlTag("NcodgFrmt")]
    public IsoMax35Text? EncodingFormat { get; init; }

    /// <summary>
    /// Business name of the party.
    /// </summary>
    [IsoId("_TeY_RRT6EfC_aaedwHHlmw")]
    [DisplayName("Business Name")]
    [IsoXmlTag("BizNm")]
    public IsoMax70Text? BusinessName { get; init; }

    /// <summary>
    /// Legal Corporate Name of the party in local language.
    /// </summary>
    [IsoId("_TeY_RxT6EfC_aaedwHHlmw")]
    [DisplayName("Legal Corporate Name")]
    [IsoXmlTag("LglCorpNm")]
    public IsoMax210Text? LegalCorporateName { get; init; }

    /// <summary>
    /// Address information in local language.
    /// </summary>
    [IsoId("_f5ZucBT6EfC_aaedwHHlmw")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public LocalAddress2? Address { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_1zjtgkVeEfCQAqQ9lolFUg")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_1zjtg0VeEfCQAqQ9lolFUg")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
