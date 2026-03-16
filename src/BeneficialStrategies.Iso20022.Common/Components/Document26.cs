// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Document26.
/// </summary>
[IsoId("_PG2_EeJJEe-5wchdE0oJYw")]
[DisplayName("Document26")]
public record Document26
{
    /// <summary>
    /// Description.
    /// </summary>
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public IsoMax2048Text? Description { get; init; }

    /// <summary>
    /// Electronic Seal Reference.
    /// </summary>
    [DisplayName("Electronic Seal Reference")]
    [IsoXmlTag("ElctrncSealRef")]
    public IsoMax2048Text? ElectronicSealReference { get; init; }

    /// <summary>
    /// Language.
    /// </summary>
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public ValueList<ISO2ALanguageCode> Language { get; init; } = [];

    /// <summary>
    /// Original Or Translated.
    /// </summary>
    [DisplayName("Original Or Translated")]
    [IsoXmlTag("OrgnlOrTrnsltd")]
    public LanguageVersion1Code? OriginalOrTranslated { get; init; }

    /// <summary>
    /// Reference.
    /// </summary>
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required IsoMax2048Text Reference { get; init; }
}
