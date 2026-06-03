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
[IsoId("_bSlwQSz0EfCD0_iZ8tw-zA")]
[DisplayName("Local Data21")]
public record LocalData21
{
    /// <summary>
    /// The language code conforming to ISO 639-1 that identifies the language in which the fields are expressed in this component.
    /// </summary>
    [IsoId("_bVIt8Sz0EfCD0_iZ8tw-zA")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public required ISOMax3ALanguageCode Language { get; init; }

    /// <summary>
    /// Data encoding format for local data.
    /// </summary>
    [IsoId("_bVIt8yz0EfCD0_iZ8tw-zA")]
    [DisplayName("Encoding Format")]
    [IsoXmlTag("NcodgFrmt")]
    public IsoMax35Text? EncodingFormat { get; init; }

    /// <summary>
    /// Name of the financial customer in the local language.
    /// </summary>
    [IsoId("_bVIt9Sz0EfCD0_iZ8tw-zA")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public CardholderName2? Name { get; init; }

    /// <summary>
    /// Alias name of the customer in local language.
    /// </summary>
    [IsoId("_hmvO4Cz0EfCD0_iZ8tw-zA")]
    [DisplayName("Alias Name")]
    [IsoXmlTag("AliasNm")]
    public IsoMax140Text? AliasName { get; init; }

    /// <summary>
    /// Occupation of the customer in local language.
    /// </summary>
    [IsoId("_yGqlACz0EfCD0_iZ8tw-zA")]
    [DisplayName("Occupation")]
    [IsoXmlTag("Ocptn")]
    public IsoMax70Text? Occupation { get; init; }

    /// <summary>
    /// Structured postal address in the local language.
    /// </summary>
    [IsoId("_bVIt9yz0EfCD0_iZ8tw-zA")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public LocalAddress2? Address { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_4ap6UkVYEfCQAqQ9lolFUg")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_4ap6U0VYEfCQAqQ9lolFUg")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
