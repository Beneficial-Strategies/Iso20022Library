// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the current and market value of the collateral held.
/// </summary>
[IsoId("_UmfA-dp-Ed-ak6NoX_4Aeg_1051098621")]
[DisplayName("Collateral")]
public record Collateral3
{
    /// <summary>
    /// Value of the collateral after deduction of a percentage (the haircut) that reflects the perceived risk associated with holding this collateral.
    /// </summary>
    [IsoId("_UmoK4Np-Ed-ak6NoX_4Aeg_-843597326")]
    [DisplayName("Post Haircut Value")]
    [IsoXmlTag("PstHrcutVal")]
    public required ActiveCurrencyAndAmount PostHaircutValue { get; init; }

    /// <summary>
    /// Value of the underlying collateral (cash, securities, LoC) based on current market prices.
    /// </summary>
    [IsoId("_UmoK4dp-Ed-ak6NoX_4Aeg_347210571")]
    [DisplayName("Market Value")]
    [IsoXmlTag("MktVal")]
    public required ActiveCurrencyAndAmount MarketValue { get; init; }

    /// <summary>
    /// Provides the type of collateral, such as securities or cash.
    /// </summary>
    [IsoId("_UmoK4tp-Ed-ak6NoX_4Aeg_2099519852")]
    [DisplayName("Collateral Type")]
    [IsoXmlTag("CollTp")]
    public required CollateralType2Code CollateralType { get; init; }
}
