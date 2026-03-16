// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amounts linked to a securities balance, for example, holding value.
/// </summary>
[IsoId("_WQIfU9p-Ed-ak6NoX_4Aeg_1080208287")]
[DisplayName("Balance Amounts")]
public record BalanceAmounts4
{
    /// <summary>
    /// Value of an individual financial instrument holding within a safekeeping account.
    /// </summary>
    [IsoId("_WQIfVNp-Ed-ak6NoX_4Aeg_1401606317")]
    [DisplayName("Holding Value")]
    [IsoXmlTag("HldgVal")]
    public AmountAndDirection14? HoldingValue { get; init; }

    /// <summary>
    /// Previous value of an individual financial instrument holding within a safekeeping account.
    /// </summary>
    [IsoId("_WQIfVdp-Ed-ak6NoX_4Aeg_-1475771676")]
    [DisplayName("Previous Holding Value")]
    [IsoXmlTag("PrvsHldgVal")]
    public AmountAndDirection14? PreviousHoldingValue { get; init; }

    /// <summary>
    /// Value of a financial instrument, as booked/acquired in an account. It may be used to establish capital gain tax liability.
    /// </summary>
    [IsoId("_WQIfVtp-Ed-ak6NoX_4Aeg_711211848")]
    [DisplayName("Book Value")]
    [IsoXmlTag("BookVal")]
    public AmountAndDirection14? BookValue { get; init; }

    /// <summary>
    /// Value of the position eligible for collateral purposes.
    /// </summary>
    [IsoId("_WQIfV9p-Ed-ak6NoX_4Aeg_2128801151")]
    [DisplayName("Eligible Collateral Value")]
    [IsoXmlTag("ElgblCollVal")]
    public AmountAndDirection14? EligibleCollateralValue { get; init; }

    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_WQIfWNp-Ed-ak6NoX_4Aeg_20817379")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection14? AccruedInterestAmount { get; init; }
}
