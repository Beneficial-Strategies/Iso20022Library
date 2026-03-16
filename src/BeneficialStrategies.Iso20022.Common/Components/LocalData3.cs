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
[IsoId("_bp4_QcWxEeuhguwJmlgagQ")]
[DisplayName("Local Data")]
public record LocalData3
{
    /// <summary>
    /// The language code conforming to ISO 639-1 that identifies the language in which the fields are expressed in this component.
    /// </summary>
    [IsoId("_bucIEcWxEeuhguwJmlgagQ")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public required ISOMax3ALanguageCode Language { get; init; }

    /// <summary>
    /// Name of the financial customer in the local language.
    /// </summary>
    [IsoId("_bucIE8WxEeuhguwJmlgagQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public CardholderName2? Name { get; init; }

    /// <summary>
    /// Structured postal address in the local language.
    /// </summary>
    [IsoId("_bucIFcWxEeuhguwJmlgagQ")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address3? Address { get; init; }

    /// <summary>
    /// Additional local language data
    /// </summary>
    [IsoId("_uM8r8cXLEeumGdYElfgmbw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; }
}
