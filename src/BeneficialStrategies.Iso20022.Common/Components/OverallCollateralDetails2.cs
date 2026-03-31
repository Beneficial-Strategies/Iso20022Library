// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Global collateral status of all transactions covered in the message, in the reporting currency, that is, the total of the exposure amount, of the posted collateral, of the margin amounts, of the accrued interest, of the fees or commissions and of the principals. In addition, it provides collateral-specific information.
/// </summary>
[IsoId("_5qoZgRIlEeyLzJfz3xPQNA")]
[DisplayName("Overall Collateral Details")]
public record OverallCollateralDetails2
{
    /// <summary>
    /// Provides details on the collateral valuation.
    /// </summary>
    [IsoId("_6CxMsRIlEeyLzJfz3xPQNA")]
    [DisplayName("Valuation Amounts")]
    [IsoXmlTag("ValtnAmts")]
    public required CollateralAmount15 ValuationAmounts { get; init; }

    /// <summary>
    /// The collateral excess/shortage expressed in the percentage of the collateral required.
    /// </summary>
    [IsoId("_6CxMsxIlEeyLzJfz3xPQNA")]
    [DisplayName("Margin Rate")]
    [IsoXmlTag("MrgnRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? MarginRate { get; init; }

    /// <summary>
    /// Provides the status after comparing the total collateral required and the total collateral value of all transactions covered in the message.
    /// </summary>
    [IsoId("_6CxMtRIlEeyLzJfz3xPQNA")]
    [DisplayName("Global Collateral Status")]
    [IsoXmlTag("GblCollSts")]
    public CollateralStatus1Code? GlobalCollateralStatus { get; init; }

    /// <summary>
    /// Valuation date/time of both the collateral and the exposure.
    /// </summary>
    [IsoId("_6CxMtxIlEeyLzJfz3xPQNA")]
    [DisplayName("Valuation Date")]
    [IsoXmlTag("ValtnDt")]
    public required DateAndDateTime2Choice_ ValuationDate { get; init; }

    /// <summary>
    /// Provides additional information on the collateral.
    /// </summary>
    [IsoId("_6CxMuRIlEeyLzJfz3xPQNA")]
    [DisplayName("Collateral Additional Details")]
    [IsoXmlTag("CollAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? CollateralAdditionalDetails { get; init; }
}
