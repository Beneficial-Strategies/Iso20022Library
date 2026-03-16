// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about outstanding derivatives, outstanding derivatives with no margin and outstanding derivatives with outdated margin.
/// </summary>
[IsoId("_rsDixVowEe23K4GXSpBSeg")]
[DisplayName("Detailed Transaction Statistics")]
public record DetailedTransactionStatistics26
{
    /// <summary>
    /// Number of outstanding derivatives.
    /// </summary>
    [IsoId("_rtPOgVowEe23K4GXSpBSeg")]
    [DisplayName("Number Of Outstanding Derivatives")]
    [IsoXmlTag("NbOfOutsdngDerivs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber NumberOfOutstandingDerivatives { get; init; }

    /// <summary>
    /// Number of outstanding derivatives with no margin information.
    /// </summary>
    [IsoId("_rtPOg1owEe23K4GXSpBSeg")]
    [DisplayName("Number Of Outstanding Derivatives With No Margin Information")]
    [IsoXmlTag("NbOfOutsdngDerivsWthNoMrgnInf")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber NumberOfOutstandingDerivativesWithNoMarginInformation { get; init; }

    /// <summary>
    /// Number of outstanding derivatives with outdated margin information.
    /// </summary>
    [IsoId("_rtPOhVowEe23K4GXSpBSeg")]
    [DisplayName("Number Of Outstanding Derivatives With Outdated Margin Information")]
    [IsoXmlTag("NbOfOutsdngDerivsWthOutdtdMrgnInf")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber NumberOfOutstandingDerivativesWithOutdatedMarginInformation { get; init; }

    /// <summary>
    /// Details of the outstanding derivatives for which no margin information has been reported, or the margin information that was reported is dated more than fourteen calendar days earlier than the day.
    /// </summary>
    [IsoId("_rtPOh1owEe23K4GXSpBSeg")]
    [DisplayName("Warnings")]
    [IsoXmlTag("Wrnngs")]
    public ValueList<MissingMarginData2> Warnings { get; init; } = [];
    // ID for the above is _rtPOh1owEe23K4GXSpBSeg
}
