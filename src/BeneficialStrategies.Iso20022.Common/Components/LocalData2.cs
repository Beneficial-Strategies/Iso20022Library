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
[IsoId("_wC-R4cWpEeuhguwJmlgagQ")]
[DisplayName("Local Data")]
public record LocalData2
{
    /// <summary>
    /// The language code conforming to ISO 639-1 that identifies the language in which the fields are expressed in this component.
    /// </summary>
    [IsoId("_wHgzocWpEeuhguwJmlgagQ")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public required ISOMax3ALanguageCode Language { get; init; }

    /// <summary>
    /// Name of the financial institution in the local language.
    /// </summary>
    [IsoId("_wHgzo8WpEeuhguwJmlgagQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }

    /// <summary>
    /// Structured postal address in the local language.
    /// </summary>
    [IsoId("_p2qrMMWqEeuhguwJmlgagQ")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address3? Address { get; init; }

    /// <summary>
    /// Additional information, in the local language, used to facilitate contact with the financial institution, for instance dispute manager name.
    /// </summary>
    [IsoId("_3pQUgMWuEeuhguwJmlgagQ")]
    [DisplayName("Additional Contact Information")]
    [IsoXmlTag("AddtlCtctInf")]
    [IsoSimpleType(IsoSimpleType.Max512Text)]
    [StringLength(maximumLength: 512, MinimumLength = 1)]
    public IsoMax512Text? AdditionalContactInformation { get; init; }

    /// <summary>
    /// Additional local language data
    /// </summary>
    [IsoId("_v5cqAcXLEeumGdYElfgmbw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; }
}
