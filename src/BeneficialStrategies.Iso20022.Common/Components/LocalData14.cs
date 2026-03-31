// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Local Data14.
/// </summary>
[IsoId("_KSaikZkIEe6Qpd-x8YgzaA")]
[DisplayName("Local Data14")]
public record LocalData14
{
    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];

    /// <summary>
    /// Encoding Format.
    /// </summary>
    [DisplayName("Encoding Format")]
    [IsoXmlTag("NcodgFrmt")]
    public IsoMax35Text? EncodingFormat { get; init; }

    /// <summary>
    /// Language.
    /// </summary>
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public required ISOMax3ALanguageCode Language { get; init; }

    /// <summary>
    /// Legal Corporate Name.
    /// </summary>
    [DisplayName("Legal Corporate Name")]
    [IsoXmlTag("LglCorpNm")]
    public IsoMax210Text? LegalCorporateName { get; init; }

    /// <summary>
    /// Short Name.
    /// </summary>
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    public IsoMax70Text? ShortName { get; init; }
}
