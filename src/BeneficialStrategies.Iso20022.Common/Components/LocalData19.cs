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
[IsoId("_yySYoRT9EfC_aaedwHHlmw")]
[DisplayName("Local Data19")]
public record LocalData19
{
    /// <summary>
    /// The language code conforming to ISO 639-1 that identifies the language in which the fields are expressed in this component.
    /// </summary>
    [IsoId("_y5hpERT9EfC_aaedwHHlmw")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public required ISOMax3ALanguageCode Language { get; init; }

    /// <summary>
    /// Data encoding format for local data.
    /// </summary>
    [IsoId("_y5hpExT9EfC_aaedwHHlmw")]
    [DisplayName("Encoding Format")]
    [IsoXmlTag("NcodgFrmt")]
    public IsoMax35Text? EncodingFormat { get; init; }

    /// <summary>
    /// Business name of the acceptor in the local language.
    /// </summary>
    [IsoId("_y5hpFRT9EfC_aaedwHHlmw")]
    [DisplayName("Business Name")]
    [IsoXmlTag("BizNm")]
    public IsoMax70Text? BusinessName { get; init; }

    /// <summary>
    /// Legal Corporate Name of the party in the local language.
    /// </summary>
    [IsoId("_y5hpFxT9EfC_aaedwHHlmw")]
    [DisplayName("Legal Corporate Name")]
    [IsoXmlTag("LglCorpNm")]
    public IsoMax210Text? LegalCorporateName { get; init; }

    /// <summary>
    /// Name and location of acceptor in the local language. May only contain name when the location is specified elsewhere.
    /// </summary>
    [IsoId("_y5hpGRT9EfC_aaedwHHlmw")]
    [DisplayName("Name And Location")]
    [IsoXmlTag("NmAndLctn")]
    public IsoMax200Text? NameAndLocation { get; init; }

    /// <summary>
    /// Structured postal address in the local language.
    /// </summary>
    [IsoId("_y5hpLRT9EfC_aaedwHHlmw")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public LocalAddress2? Address { get; init; }

    /// <summary>
    /// Location where the cardholder receive the service. Only required if the service location is different than acceptor location.
    /// </summary>
    [IsoId("_9OWu4RT9EfC_aaedwHHlmw")]
    [DisplayName("Service Location")]
    [IsoXmlTag("SvcLctn")]
    public LocalAddress1? ServiceLocation { get; init; }

    /// <summary>
    /// Additional information used when card acceptor street address is insufficient.
    /// </summary>
    [IsoId("_y5hpLxT9EfC_aaedwHHlmw")]
    [DisplayName("Additional Address")]
    [IsoXmlTag("AddtlAdr")]
    public IsoMax512Text? AdditionalAddress { get; init; }

    /// <summary>
    /// Additional information used to facilitate contact with the card acceptor.
    /// </summary>
    [IsoId("_y5hpNxT9EfC_aaedwHHlmw")]
    [DisplayName("Additional Contact")]
    [IsoXmlTag("AddtlCtct")]
    public IsoMax512Text? AdditionalContact { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_UvgWIkhxEfCMZJtj4J7UGQ")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_UvgWI0hxEfCMZJtj4J7UGQ")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
