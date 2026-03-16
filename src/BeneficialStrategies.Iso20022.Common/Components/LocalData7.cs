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
[IsoId("_bTHMccrfEeuQjLd-KKZrCg")]
[DisplayName("Local Data")]
public record LocalData7
{
    /// <summary>
    /// The language code conforming to ISO 639-1 that identifies the language in which the fields are expressed in this component.
    /// </summary>
    [IsoId("_bY980crfEeuQjLd-KKZrCg")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public required ISOMax3ALanguageCode Language { get; init; }

    /// <summary>
    /// Name of the cardholder in the local language.
    /// </summary>
    [IsoId("_bY9808rfEeuQjLd-KKZrCg")]
    [DisplayName("Cardholder Name")]
    [IsoXmlTag("CrdhldrNm")]
    public CardholderName2? CardholderName { get; init; }

    /// <summary>
    /// Structured postal address in the local language.
    /// </summary>
    [IsoId("_bY981crfEeuQjLd-KKZrCg")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address3? Address { get; init; }

    /// <summary>
    /// Additional local language data
    /// </summary>
    [IsoId("_bY9818rfEeuQjLd-KKZrCg")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];
}
