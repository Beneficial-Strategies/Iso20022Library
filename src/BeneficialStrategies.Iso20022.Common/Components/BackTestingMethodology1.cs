// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the characteristics of a backtesting methodology used to test the performance of a risk model.
/// </summary>
[IsoId("_4TLUQLC2EeaSl6vJk5Bd8w")]
[DisplayName("Back Testing Methodology")]
public record BackTestingMethodology1
{
    /// <summary>
    /// Specifies the core model type, excluding any modifications for pro-cyclicality.
    /// </summary>
    [IsoId("_-fqEoLC2EeaSl6vJk5Bd8w")]
    [DisplayName("Risk Model Type")]
    [IsoXmlTag("RskMdlTp")]
    public required ModelType1Choice_ RiskModelType { get; init; }

    /// <summary>
    /// Specifies the confidence interval used on a daily basis to assess the performance of the model.
    /// </summary>
    [IsoId("_N9vjQLC3EeaSl6vJk5Bd8w")]
    [DisplayName("Model Confidence Level")]
    [IsoXmlTag("MdlCnfdncLvl")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public required IsoBaseOneRate ModelConfidenceLevel { get; init; }

    /// <summary>
    /// Indicates whether the CCP model calculates mark-to-market changes on fixed portfolios when backtesting.
    /// </summary>
    [IsoId("_1WtGoLC3EeaSl6vJk5Bd8w")]
    [DisplayName("Variation Margin Clean Indicator")]
    [IsoXmlTag("VartnMrgnCleanInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator VariationMarginCleanIndicator { get; init; }

    /// <summary>
    /// Description of backtesting methodology.
    /// </summary>
    [IsoId("_n56ysMBgEeak3I7j2hsibw")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [StringLength(maximumLength: 2000, MinimumLength = 1)]
    public IsoMax2000Text? Description { get; init; }
}
