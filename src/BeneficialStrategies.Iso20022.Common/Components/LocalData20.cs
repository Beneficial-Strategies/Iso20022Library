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
[IsoId("_IENp4R7dEfCkq6-p7S3J1Q")]
[DisplayName("Local Data20")]
public record LocalData20
{
    /// <summary>
    /// The language code conforming to ISO 639-1 that identifies the language in which the fields are expressed in this component.
    /// </summary>
    [IsoId("_ILNpwR7dEfCkq6-p7S3J1Q")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public required ISOMax3ALanguageCode Language { get; init; }

    /// <summary>
    /// Data encoding format for local data.
    /// </summary>
    [IsoId("_ILNpwx7dEfCkq6-p7S3J1Q")]
    [DisplayName("Encoding Format")]
    [IsoXmlTag("NcodgFrmt")]
    public IsoMax35Text? EncodingFormat { get; init; }

    /// <summary>
    /// Business name of the party in local language.
    /// </summary>
    [IsoId("_ILNpxR7dEfCkq6-p7S3J1Q")]
    [DisplayName("Business Name")]
    [IsoXmlTag("BizNm")]
    public IsoMax70Text? BusinessName { get; init; }

    /// <summary>
    /// Legal Corporate Name of the party in local language.
    /// </summary>
    [IsoId("_ILNpxx7dEfCkq6-p7S3J1Q")]
    [DisplayName("Legal Corporate Name")]
    [IsoXmlTag("LglCorpNm")]
    public IsoMax210Text? LegalCorporateName { get; init; }

    /// <summary>
    /// Structured postal address in the local language.
    /// </summary>
    [IsoId("_Dq9fwR7fEfCkq6-p7S3J1Q")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public LocalAddress2? Address { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_SEOnckVXEfCQAqQ9lolFUg")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_SEOnc0VXEfCQAqQ9lolFUg")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
