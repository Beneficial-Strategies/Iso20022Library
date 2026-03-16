// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Item Description2.
/// </summary>
[IsoId("_PUBfI1xyEe6fgZt44_IqFA")]
[DisplayName("Item Description2")]
public record ItemDescription2
{
    /// <summary>
    /// Description.
    /// </summary>
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public ValueList<IsoMax8000Text> Description { get; init; } = [];

    /// <summary>
    /// Language.
    /// </summary>
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public required ISO2ALanguageCode Language { get; init; }

    /// <summary>
    /// Title.
    /// </summary>
    [DisplayName("Title")]
    [IsoXmlTag("Titl")]
    public IsoMax1025Text? Title { get; init; }
}
