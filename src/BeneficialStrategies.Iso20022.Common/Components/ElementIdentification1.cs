// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Description of the element that creates the mismatch.
/// </summary>
[IsoId("_RJf8s9p-Ed-ak6NoX_4Aeg_1263580782")]
[DisplayName("Element Identification")]
public record ElementIdentification1
{
    /// <summary>
    /// Refers to the identification number of the document in which the mismatch was found.
    /// </summary>
    [IsoId("_RJf8tNp-Ed-ak6NoX_4Aeg_-1274214222")]
    [DisplayName("Document Index")]
    [IsoXmlTag("DocIndx")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public required IsoMax3NumericText DocumentIndex { get; init; }

    /// <summary>
    /// Specifies from the root of the message the complete path of the element that violated a rule.
    /// </summary>
    [IsoId("_RJf8tdp-Ed-ak6NoX_4Aeg_1320841192")]
    [DisplayName("Element Path")]
    [IsoXmlTag("ElmtPth")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text ElementPath { get; init; }

    /// <summary>
    /// Name of the element.
    /// </summary>
    [IsoId("_RJf8ttp-Ed-ak6NoX_4Aeg_-1433356393")]
    [DisplayName("Element Name")]
    [IsoXmlTag("ElmtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ElementName { get; init; }

    /// <summary>
    /// Content of the element.
    /// </summary>
    [IsoId("_RJf8t9p-Ed-ak6NoX_4Aeg_1327304238")]
    [DisplayName("Element Value")]
    [IsoXmlTag("ElmtVal")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? ElementValue { get; init; }
}
