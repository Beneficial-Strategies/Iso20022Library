// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional information relevant to the destination.
/// </summary>
[IsoId("_EkHNFf2qEeiS2rs-hXBB5Q")]
[DisplayName("Additional Information")]
public record AdditionalInformation19
{
    /// <summary>
    /// Key-entered numeric data.
    /// </summary>
    [IsoId("_EkHNGf2qEeiS2rs-hXBB5Q")]
    [DisplayName("Entered Data Numeric")]
    [IsoXmlTag("NtrdDataNmrc")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public IsoMax35NumericText? EnteredDataNumeric { get; init; }

    /// <summary>
    /// Key-entered alphanumeric data.
    /// </summary>
    [IsoId("_UZ4L4P2qEeiS2rs-hXBB5Q")]
    [DisplayName("Entered Data Alpha Numeric")]
    [IsoXmlTag("NtrdDataAlphaNmrc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? EnteredDataAlphaNumeric { get; init; }

    /// <summary>
    /// Additional fleet summary data.
    /// </summary>
    [IsoId("_W13GIP2qEeiS2rs-hXBB5Q")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalData { get; init; }
}
