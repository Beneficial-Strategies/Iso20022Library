// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding, in a single security, within the overall position held in a securities account. A securities balance is calculated from the sum of securities&apos; receipts minus the sum of securities&apos; deliveries.
/// </summary>
[IsoId("_VLSXKNp-Ed-ak6NoX_4Aeg_770800567")]
[DisplayName("Aggregate Balance Information")]
public record AggregateBalanceInformation2
{
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding.
    /// </summary>
    [IsoId("_VLSXKdp-Ed-ak6NoX_4Aeg_-1281859646")]
    [DisplayName("Aggregate Quantity")]
    [IsoXmlTag("AggtQty")]
    public required BalanceQuantity1Choice_ AggregateQuantity { get; init; }

    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_VLSXKtp-Ed-ak6NoX_4Aeg_-1281858691")]
    [DisplayName("Days Accrued")]
    [IsoXmlTag("DaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? DaysAccrued { get; init; }

    /// <summary>
    /// Total value of a balance of the securities account for a specific financial instrument, expressed in one or more currencies.
    /// </summary>
    [IsoId("_VLSXK9p-Ed-ak6NoX_4Aeg_-1281858379")]
    [DisplayName("Holding Value")]
    [IsoXmlTag("HldgVal")]
    public ValueList<ActiveOrHistoricCurrencyAndAmount> HoldingValue { get; init; } = [];

    // ID for the above is _VLSXK9p-Ed-ak6NoX_4Aeg_-1281858379

    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_VLSXLNp-Ed-ak6NoX_4Aeg_-1281858284")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public ActiveOrHistoricCurrencyAndAmount? AccruedInterestAmount { get; init; }

    /// <summary>
    /// Value of a security, as booked in an account. Book value is often different from the current market value of the security.
    /// </summary>
    [IsoId("_VLSXLdp-Ed-ak6NoX_4Aeg_-1281857864")]
    [DisplayName("Book Value")]
    [IsoXmlTag("BookVal")]
    public ActiveOrHistoricCurrencyAndAmount? BookValue { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_VLcIINp-Ed-ak6NoX_4Aeg_-1059660066")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormatChoice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Security held on the account for which the balance is calculated.
    /// </summary>
    [IsoId("_VLcIIdp-Ed-ak6NoX_4Aeg_-941778674")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument4 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Price of the financial instrument in one or more currencies.
    /// </summary>
    [IsoId("_VLcIItp-Ed-ak6NoX_4Aeg_233320292")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public ValueList<PriceInformation1> PriceDetails { get; init; } = [];

    // ID for the above is _VLcIItp-Ed-ak6NoX_4Aeg_233320292

    /// <summary>
    /// Currency exchange related to a securities order.
    /// </summary>
    [IsoId("_VLcII9p-Ed-ak6NoX_4Aeg_-2031702353")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FrgnXchgDtls")]
    public ForeignExchangeTerms3? ForeignExchangeDetails { get; init; }

    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in a securities account, eg, sub-balance per status.
    /// </summary>
    [IsoId("_VLcIJNp-Ed-ak6NoX_4Aeg_-1418910095")]
    [DisplayName("Balance Breakdown Details")]
    [IsoXmlTag("BalBrkdwnDtls")]
    public ValueList<SubBalanceInformation1> BalanceBreakdownDetails { get; init; } = [];

    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in a securities account, eg, sub-balance per status.
    /// </summary>
    [IsoId("_VLcIJdp-Ed-ak6NoX_4Aeg_140919700")]
    [DisplayName("Additional Balance Breakdown Details")]
    [IsoXmlTag("AddtlBalBrkdwnDtls")]
    public ValueList<AdditionalBalanceInformation> AdditionalBalanceBreakdownDetails { get; init; } =
        [];

    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account at a specified place of safekeeping.
    /// </summary>
    [IsoId("_VLcIJtp-Ed-ak6NoX_4Aeg_1554879228")]
    [DisplayName("Balance At Safekeeping Place")]
    [IsoXmlTag("BalAtSfkpgPlc")]
    public ValueList<AggregateBalancePerSafekeepingPlace2> BalanceAtSafekeepingPlace { get; init; } =
        [];
}
