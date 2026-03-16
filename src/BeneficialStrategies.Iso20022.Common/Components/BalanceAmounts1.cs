// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
/// </summary>
[IsoId("_SVo_sdp-Ed-ak6NoX_4Aeg_-1149439730")]
[DisplayName("Balance Amounts")]
public record BalanceAmounts1
{
    /// <summary>
    /// Value of an individual financial instrument holding within a safekeeping account.
    /// </summary>
    [IsoId("_SVo_stp-Ed-ak6NoX_4Aeg_-1179710233")]
    [DisplayName("Holding Value")]
    [IsoXmlTag("HldgVal")]
    public required AmountAndDirection6 HoldingValue { get; init; }

    /// <summary>
    /// Previous value of an individual financial instrument holding within a safekeeping account.
    /// </summary>
    [IsoId("_SVo_s9p-Ed-ak6NoX_4Aeg_2045487517")]
    [DisplayName("Previous Holding Value")]
    [IsoXmlTag("PrvsHldgVal")]
    public AmountAndDirection6? PreviousHoldingValue { get; init; }

    /// <summary>
    /// Value of a financial instrument, as booked/acquired in an account. It may be used to establish capital gain tax liability.
    /// </summary>
    [IsoId("_SVo_tNp-Ed-ak6NoX_4Aeg_-1007220732")]
    [DisplayName("Book Value")]
    [IsoXmlTag("BookVal")]
    public AmountAndDirection6? BookValue { get; init; }

    /// <summary>
    /// Difference between holding value and the book value.
    /// </summary>
    [IsoId("_SVo_tdp-Ed-ak6NoX_4Aeg_221334284")]
    [DisplayName("Unrealised Gain Loss")]
    [IsoXmlTag("UrlsdGnLoss")]
    public AmountAndDirection6? UnrealisedGainLoss { get; init; }

    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_SVo_ttp-Ed-ak6NoX_4Aeg_-1354594058")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection6? AccruedInterestAmount { get; init; }
}
