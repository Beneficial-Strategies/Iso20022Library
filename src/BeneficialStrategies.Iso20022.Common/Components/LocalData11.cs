// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Local Data11.
/// </summary>
[IsoId("_V34-cW9nEe6DxcrvCrq6hQ")]
[DisplayName("Local Data11")]
public record LocalData11
{
    /// <summary>
    /// Additional Address.
    /// </summary>
    [DisplayName("Additional Address")]
    [IsoXmlTag("AddtlAdr")]
    public IsoMax512Text? AdditionalAddress { get; init; }

    /// <summary>
    /// Additional Contact.
    /// </summary>
    [DisplayName("Additional Contact")]
    [IsoXmlTag("AddtlCtct")]
    public IsoMax512Text? AdditionalContact { get; init; }

    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];

    /// <summary>
    /// Address.
    /// </summary>
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public LocalAddress1? Address { get; init; }

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
    /// Name And Location.
    /// </summary>
    [DisplayName("Name And Location")]
    [IsoXmlTag("NmAndLctn")]
    public IsoMax200Text? NameAndLocation { get; init; }

    /// <summary>
    /// Short Name.
    /// </summary>
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    public IsoMax70Text? ShortName { get; init; }
}
