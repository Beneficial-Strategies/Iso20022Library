// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding, in a single security, within the overall position held in a securities account at a specified place of safekeeping.
/// </summary>
[IsoId("_VLcIKtp-Ed-ak6NoX_4Aeg_1774314000")]
[DisplayName("Aggregate Balance Per Safekeeping Place")]
public record AggregateBalancePerSafekeepingPlace1
{
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding.
    /// </summary>
    [IsoId("_VLcIK9p-Ed-ak6NoX_4Aeg_-2028596341")]
    [DisplayName("Aggregate Quantity")]
    [IsoXmlTag("AggtQty")]
    public required BalanceQuantity1Choice_ AggregateQuantity { get; init; }

    /// <summary>
    /// Total quantity of financial instrument for the referenced holding that is available.
    /// </summary>
    [IsoId("_VLlSENp-Ed-ak6NoX_4Aeg_-2028596221")]
    [DisplayName("Available Quantity")]
    [IsoXmlTag("AvlblQty")]
    public BalanceQuantity1Choice_? AvailableQuantity { get; init; }

    /// <summary>
    /// Total quantity of financial instrument for the referenced holding that is not available.
    /// </summary>
    [IsoId("_VLlSEdp-Ed-ak6NoX_4Aeg_-2028596126")]
    [DisplayName("Not Available Quantity")]
    [IsoXmlTag("NotAvlblQty")]
    public BalanceQuantity1Choice_? NotAvailableQuantity { get; init; }

    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_VLlSEtp-Ed-ak6NoX_4Aeg_-1353366144")]
    [DisplayName("Days Accrued")]
    [IsoXmlTag("DaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? DaysAccrued { get; init; }

    /// <summary>
    /// Total value of a balance of the securities account for a specific financial instrument, expressed in one or more currencies.
    /// </summary>
    [IsoId("_VLlSE9p-Ed-ak6NoX_4Aeg_-1353365824")]
    [DisplayName("Holding Value")]
    [IsoXmlTag("HldgVal")]
    public ValueList<ActiveOrHistoricCurrencyAndAmount> HoldingValue { get; init; } = [];

    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_VLlSFNp-Ed-ak6NoX_4Aeg_-1353365729")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public ActiveOrHistoricCurrencyAndAmount? AccruedInterestAmount { get; init; }

    /// <summary>
    /// Value of a security, as booked in an account. Book value is often different from the current market value of the security.
    /// </summary>
    [IsoId("_VLlSFdp-Ed-ak6NoX_4Aeg_-1353365368")]
    [DisplayName("Book Value")]
    [IsoXmlTag("BookVal")]
    public ActiveOrHistoricCurrencyAndAmount? BookValue { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_VLlSFtp-Ed-ak6NoX_4Aeg_1516698504")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public required SafekeepingPlaceFormatChoice_ SafekeepingPlace { get; init; }

    /// <summary>
    /// Price of the financial instrument in one or more currencies.
    /// </summary>
    [IsoId("_VLlSF9p-Ed-ak6NoX_4Aeg_-738225302")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public ValueList<PriceInformation1> PriceDetails { get; init; } = [];

    /// <summary>
    /// Currency exchange related to a securities order.
    /// </summary>
    [IsoId("_VLlSGNp-Ed-ak6NoX_4Aeg_-1691847513")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FrgnXchgDtls")]
    public ForeignExchangeTerms3? ForeignExchangeDetails { get; init; }

    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in a securities account, eg, sub-balance per status.
    /// </summary>
    [IsoId("_VLlSGdp-Ed-ak6NoX_4Aeg_-985941865")]
    [DisplayName("Balance Breakdown Details")]
    [IsoXmlTag("BalBrkdwnDtls")]
    public ValueList<SubBalanceInformation1> BalanceBreakdownDetails { get; init; } = [];

    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_VLvDENp-Ed-ak6NoX_4Aeg_-196328617")]
    [DisplayName("Additional Balance Breakdown Details")]
    [IsoXmlTag("AddtlBalBrkdwnDtls")]
    public ValueList<AdditionalBalanceInformation> AdditionalBalanceBreakdownDetails { get; init; } =
        [];
}
