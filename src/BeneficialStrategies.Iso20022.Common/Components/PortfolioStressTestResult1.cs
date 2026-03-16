// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Outcome of the application of a hypothetical scenario on the valuation of a portfolio of financial instruments.
/// </summary>
[IsoId("_pRc2MKs_Eeayv9XxdmMwKQ")]
[DisplayName("Portfolio Stress Test Result")]
public record PortfolioStressTestResult1
{
    /// <summary>
    /// Identification of the portfolio.
    /// </summary>
    [IsoId("_0leIIKs_Eeayv9XxdmMwKQ")]
    [DisplayName("Portfolio Identification")]
    [IsoXmlTag("PrtflId")]
    public required GenericIdentification165 PortfolioIdentification { get; init; }

    /// <summary>
    /// Calculated stress loss over the initial margin requirement, as used in the calculation of stress testing losses to size the default fund. Indicates whether the portfolio experienced a stress loss greater than initial margin.
    /// </summary>
    [IsoId("_Fwj7IKtAEeayv9XxdmMwKQ")]
    [DisplayName("Stress Loss")]
    [IsoXmlTag("StrssLoss")]
    public required AmountAndDirection102 StressLoss { get; init; }

    /// <summary>
    /// Calculated raw stress loss, as used in the calculation of stress testing losses to size the default fund. Indicates whether the portfolio experienced a stress loss.
    /// </summary>
    [IsoId("_wZC40OUSEem3X-64-NKdqg")]
    [DisplayName("Raw Stress Loss")]
    [IsoXmlTag("RawStrssLoss")]
    public AmountAndDirection102? RawStressLoss { get; init; }

    /// <summary>
    /// Indicates whether the stress loss over initial margin under this scenario for the clearing member of which the corresponding account is an account, is the largest stress over initial margin used to size the default fund.
    /// </summary>
    [IsoId("_PMMvIKtAEeayv9XxdmMwKQ")]
    [DisplayName("Cover 1 Flag")]
    [IsoXmlTag("Cover1Flg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator Cover1Flag { get; init; }

    /// <summary>
    /// Indicates whether the stress loss over initial margin under this scenario for the clearing member of which the corresponding account is an account, is the second largest stress over initial margin used to size the default fund.
    /// </summary>
    [IsoId("_Rk99UKtAEeayv9XxdmMwKQ")]
    [DisplayName("Cover 2 Flag")]
    [IsoXmlTag("Cover2Flg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator Cover2Flag { get; init; }
}
