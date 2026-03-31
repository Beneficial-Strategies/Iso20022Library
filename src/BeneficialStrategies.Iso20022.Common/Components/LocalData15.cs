// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Local Data15.
/// </summary>
[IsoId("_AzP1QZkPEe6Qpd-x8YgzaA")]
[DisplayName("Local Data15")]
public record LocalData15
{
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
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public CardholderName2? Name { get; init; }
}
