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
[IsoId("_-dm5JqMOEeCojJW5vEuTEQ_455413091")]
[DisplayName("Collateral")]
public record Collateral6
{
    /// <summary>
    /// Value of the collateral after deduction of a percentage (the haircut) that reflects the perceived risk associated with holding this collateral.
    /// </summary>
    [IsoId("_-dm5J6MOEeCojJW5vEuTEQ_341574025")]
    [DisplayName("Post Haircut Value")]
    [IsoXmlTag("PstHrcutVal")]
    public required ActiveCurrencyAndAmount PostHaircutValue { get; init; }

    /// <summary>
    /// Value of the underlying collateral (cash, securities, Letter of credit.) based on current market prices.
    /// </summary>
    [IsoId("_-dm5KKMOEeCojJW5vEuTEQ_-541659262")]
    [DisplayName("Market Value")]
    [IsoXmlTag("MktVal")]
    public required ActiveCurrencyAndAmount MarketValue { get; init; }

    /// <summary>
    /// Provides the type of collateral, such as securities or cash.
    /// </summary>
    [IsoId("_-dm5KaMOEeCojJW5vEuTEQ_-655498328")]
    [DisplayName("Collateral Type")]
    [IsoXmlTag("CollTp")]
    public required CollateralType1Code CollateralType { get; init; }
}
