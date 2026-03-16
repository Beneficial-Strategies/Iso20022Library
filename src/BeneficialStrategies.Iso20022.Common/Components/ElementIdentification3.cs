// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Description of the elements that violated a rule.
/// </summary>
[IsoId("_RFLdZtp-Ed-ak6NoX_4Aeg_-642511348")]
[DisplayName("Element Identification")]
public record ElementIdentification3
{
    /// <summary>
    /// Specifies from the root of the message the complete path of the element that violated a rule.
    /// </summary>
    [IsoId("_RFLdZ9p-Ed-ak6NoX_4Aeg_-642511346")]
    [DisplayName("Element Path")]
    [IsoXmlTag("ElmtPth")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text ElementPath { get; init; }

    /// <summary>
    /// Name of the element.
    /// </summary>
    [IsoId("_RFLdaNp-Ed-ak6NoX_4Aeg_-642511288")]
    [DisplayName("Element Name")]
    [IsoXmlTag("ElmtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ElementName { get; init; }

    /// <summary>
    /// Contents of the element.
    /// </summary>
    [IsoId("_RFUnUNp-Ed-ak6NoX_4Aeg_-642511305")]
    [DisplayName("Element Value")]
    [IsoXmlTag("ElmtVal")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? ElementValue { get; init; }
}
