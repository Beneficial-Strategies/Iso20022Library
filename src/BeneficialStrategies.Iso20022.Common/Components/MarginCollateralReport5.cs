// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Margin Collateral Report5.
/// </summary>
[IsoId("_TH2kh8EkEe66laxnCpxfpw")]
[DisplayName("Margin Collateral Report5")]
public record MarginCollateralReport5
{
    /// <summary>
    /// Collateralisation Category.
    /// </summary>
    [DisplayName("Collateralisation Category")]
    [IsoXmlTag("CollstnCtgy")]
    public required CollateralisationType3Code CollateralisationCategory { get; init; }

    /// <summary>
    /// Collateral Portfolio Code.
    /// </summary>
    [DisplayName("Collateral Portfolio Code")]
    [IsoXmlTag("CollPrtflCd")]
    public required CollateralPortfolioCode6Choice_ CollateralPortfolioCode { get; init; }

    /// <summary>
    /// Time Stamp.
    /// </summary>
    [DisplayName("Time Stamp")]
    [IsoXmlTag("TmStmp")]
    public IsoISODateTime? TimeStamp { get; init; }
}
