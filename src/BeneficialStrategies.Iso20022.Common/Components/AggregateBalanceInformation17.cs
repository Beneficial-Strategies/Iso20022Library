// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Overall position, in a single security, held in a securities account at a specified place of safekeeping.
/// </summary>
[IsoId("_IB1Vwf_iEeCcv6nahBzk1w")]
[DisplayName("Aggregate Balance Information")]
public record AggregateBalanceInformation17
{
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_IB1V1__iEeCcv6nahBzk1w")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_IB1V4f_iEeCcv6nahBzk1w")]
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public FinancialInstrumentAttributes35? FinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Elements characterising an investment funds financial instrument.
    /// </summary>
    [IsoId("_IB1V6__iEeCcv6nahBzk1w")]
    [DisplayName("Investment Funds Financial Instrument Attributes")]
    [IsoXmlTag("InvstmtFndsFinInstrmAttrbts")]
    public FinancialInstrument21? InvestmentFundsFinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Details of the swap contract.
    /// </summary>
    [IsoId("_IB1V7__iEeCcv6nahBzk1w")]
    [DisplayName("Additional Derivative Attributes")]
    [IsoXmlTag("AddtlDerivAttrbts")]
    public DerivativeBasicAttributes1? AdditionalDerivativeAttributes { get; init; }

    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [IsoId("_IB1V-f_iEeCcv6nahBzk1w")]
    [DisplayName("Aggregate Balance")]
    [IsoXmlTag("AggtBal")]
    public required Balance1 AggregateBalance { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_IB1WA__iEeCcv6nahBzk1w")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat3Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_IB1WDf_iEeCcv6nahBzk1w")]
    [DisplayName("Corporate Action Option Type")]
    [IsoXmlTag("CorpActnOptnTp")]
    public CorporateActionOption5Code? CorporateActionOptionType { get; init; }

    /// <summary>
    /// Price of the financial instrument in one or more currencies.
    /// </summary>
    [IsoId("_IB1WF__iEeCcv6nahBzk1w")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public ValueList<PriceInformation5> PriceDetails { get; init; } = [];

    // ID for the above is _IB1WF__iEeCcv6nahBzk1w

    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_IB1WIf_iEeCcv6nahBzk1w")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ValueList<ForeignExchangeTerms14> ForeignExchangeDetails { get; init; } = [];

    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_IB1WK__iEeCcv6nahBzk1w")]
    [DisplayName("Days Accrued")]
    [IsoXmlTag("DaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? DaysAccrued { get; init; }

    /// <summary>
    /// Valuation amounts provided in the base currency of the account.
    /// </summary>
    [IsoId("_IB1WNf_iEeCcv6nahBzk1w")]
    [DisplayName("Account Base Currency Amounts")]
    [IsoXmlTag("AcctBaseCcyAmts")]
    public required BalanceAmounts1 AccountBaseCurrencyAmounts { get; init; }

    /// <summary>
    /// Valuation amounts provided in the currency of the financial instrument.
    /// </summary>
    [IsoId("_IB1WP__iEeCcv6nahBzk1w")]
    [DisplayName("Instrument Currency Amounts")]
    [IsoXmlTag("InstrmCcyAmts")]
    public BalanceAmounts1? InstrumentCurrencyAmounts { get; init; }

    /// <summary>
    /// Valuation amounts provided in another currency than the base currency of the account.
    /// </summary>
    [IsoId("_IB1WSf_iEeCcv6nahBzk1w")]
    [DisplayName("Alternate Reporting Currency Amounts")]
    [IsoXmlTag("AltrnRptgCcyAmts")]
    public BalanceAmounts1? AlternateReportingCurrencyAmounts { get; init; }

    /// <summary>
    /// Breakdown of the aggregate quantity reported into significant lots, for example, tax lots.
    /// </summary>
    [IsoId("_IB1WU__iEeCcv6nahBzk1w")]
    [DisplayName("Quantity Breakdown")]
    [IsoXmlTag("QtyBrkdwn")]
    public ValueList<QuantityBreakdown14> QuantityBreakdown { get; init; } = [];

    /// <summary>
    /// Breakdown of the aggregate balance per meaningful sub-balances and availability.
    /// </summary>
    [IsoId("_IB1WXf_iEeCcv6nahBzk1w")]
    [DisplayName("Balance Breakdown")]
    [IsoXmlTag("BalBrkdwn")]
    public ValueList<SubBalanceInformation6> BalanceBreakdown { get; init; } = [];

    /// <summary>
    /// Provides additional instrument sub-balance information on all or parts of the reported financial instrument (unregistered, tax exempt, etc.).
    /// </summary>
    [IsoId("_IB1WZ__iEeCcv6nahBzk1w")]
    [DisplayName("Additional Balance Breakdown")]
    [IsoXmlTag("AddtlBalBrkdwn")]
    public ValueList<AdditionalBalanceInformation6> AdditionalBalanceBreakdown { get; init; } = [];

    /// <summary>
    /// Breakdown of positions per place of safekeeping (and optionally per place of listing).
    /// </summary>
    [IsoId("_IB1Wcf_iEeCcv6nahBzk1w")]
    [DisplayName("Balance At Safekeeping Place")]
    [IsoXmlTag("BalAtSfkpgPlc")]
    public ValueList<AggregateBalancePerSafekeepingPlace16> BalanceAtSafekeepingPlace { get; init; } =
        [];

    /// <summary>
    /// Provides additional information on the holding.
    /// </summary>
    [IsoId("_IB1We__iEeCcv6nahBzk1w")]
    [DisplayName("Holding Additional Details")]
    [IsoXmlTag("HldgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? HoldingAdditionalDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_IB1Whf_iEeCcv6nahBzk1w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
