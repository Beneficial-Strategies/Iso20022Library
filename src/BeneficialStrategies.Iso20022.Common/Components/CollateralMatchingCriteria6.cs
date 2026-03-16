// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Compares information related to both sides of a collateral.
/// </summary>
[IsoId("_A0ExqcK3EeuFNp8LZAnorg")]
[DisplayName("Collateral Matching Criteria")]
public record CollateralMatchingCriteria6
{
    /// <summary>
    /// Specifies whether the values defined as true/false indicator are matching or not.
    /// </summary>
    [IsoId("_A1bcg8K3EeuFNp8LZAnorg")]
    [DisplayName("Uncollateralised Flag")]
    [IsoXmlTag("UncollsdFlg")]
    public CompareTrueFalseIndicator3? UncollateralisedFlag { get; init; }

    /// <summary>
    /// Specifies whether the values defined as true/false indicator are matching or not.
    /// </summary>
    [IsoId("_A1bchcK3EeuFNp8LZAnorg")]
    [DisplayName("Net Exposure Collateralisation Indicator")]
    [IsoXmlTag("NetXpsrCollstnInd")]
    public CompareTrueFalseIndicator3? NetExposureCollateralisationIndicator { get; init; }

    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_A1bch8K3EeuFNp8LZAnorg")]
    [DisplayName("Collateral Value Date")]
    [IsoXmlTag("CollValDt")]
    public CompareDate3? CollateralValueDate { get; init; }

    /// <summary>
    /// Specifies whether the information on the component type is matching or not.
    /// </summary>
    [IsoId("_A1bcicK3EeuFNp8LZAnorg")]
    [DisplayName("Asset Type")]
    [IsoXmlTag("AsstTp")]
    public SecurityCommodityCash4? AssetType { get; init; }

    /// <summary>
    /// Specifies whether the values defined as security identification are matching or not.
    /// </summary>
    [IsoId("_A1bci8K3EeuFNp8LZAnorg")]
    [DisplayName("Basket Identifier")]
    [IsoXmlTag("BsktIdr")]
    public CompareSecurityIdentification4? BasketIdentifier { get; init; }
}
