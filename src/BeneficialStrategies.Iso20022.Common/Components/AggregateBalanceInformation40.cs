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
[IsoId("_gTjYeSglEey2k_sfZmJz4g")]
[DisplayName("Aggregate Balance Information")]
public record AggregateBalanceInformation40
{
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_grsymSglEey2k_sfZmJz4g")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_grsyoSglEey2k_sfZmJz4g")]
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public FinancialInstrumentAttributes111? FinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Elements characterising an investment funds financial instrument.
    /// </summary>
    [IsoId("_grsyqSglEey2k_sfZmJz4g")]
    [DisplayName("Investment Funds Financial Instrument Attributes")]
    [IsoXmlTag("InvstmtFndsFinInstrmAttrbts")]
    public FinancialInstrument21? InvestmentFundsFinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Details of the swap contract.
    /// </summary>
    [IsoId("_grsyqyglEey2k_sfZmJz4g")]
    [DisplayName("Additional Derivative Attributes")]
    [IsoXmlTag("AddtlDerivAttrbts")]
    public DerivativeBasicAttributes1? AdditionalDerivativeAttributes { get; init; }

    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [IsoId("_grsysyglEey2k_sfZmJz4g")]
    [DisplayName("Aggregate Balance")]
    [IsoXmlTag("AggtBal")]
    public required Balance17 AggregateBalance { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_grsyuyglEey2k_sfZmJz4g")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafeKeepingPlace3? SafekeepingPlace { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_grsywyglEey2k_sfZmJz4g")]
    [DisplayName("Corporate Action Option Type")]
    [IsoXmlTag("CorpActnOptnTp")]
    public CorporateActionOption5Code? CorporateActionOptionType { get; init; }

    /// <summary>
    /// Price of the financial instrument in one or more currencies.
    /// </summary>
    [IsoId("_grsyyyglEey2k_sfZmJz4g")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public ValueList<PriceInformation20> PriceDetails { get; init; } = [];

    // ID for the above is _grsyyyglEey2k_sfZmJz4g

    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_grsy0yglEey2k_sfZmJz4g")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ValueList<ForeignExchangeTerms34> ForeignExchangeDetails { get; init; } = [];

    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_grsy2yglEey2k_sfZmJz4g")]
    [DisplayName("Days Accrued")]
    [IsoXmlTag("DaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? DaysAccrued { get; init; }

    /// <summary>
    /// Valuation amounts provided in the base currency of the account.
    /// </summary>
    [IsoId("_grsy4yglEey2k_sfZmJz4g")]
    [DisplayName("Account Base Currency Amounts")]
    [IsoXmlTag("AcctBaseCcyAmts")]
    public required BalanceAmounts1 AccountBaseCurrencyAmounts { get; init; }

    /// <summary>
    /// Valuation amounts provided in the currency of the financial instrument.
    /// </summary>
    [IsoId("_grsy6yglEey2k_sfZmJz4g")]
    [DisplayName("Instrument Currency Amounts")]
    [IsoXmlTag("InstrmCcyAmts")]
    public BalanceAmounts1? InstrumentCurrencyAmounts { get; init; }

    /// <summary>
    /// Valuation amounts provided in a currency other than the base currency of the account.
    /// </summary>
    [IsoId("_grsy8yglEey2k_sfZmJz4g")]
    [DisplayName("Alternate Reporting Currency Amounts")]
    [IsoXmlTag("AltrnRptgCcyAmts")]
    public BalanceAmounts1? AlternateReportingCurrencyAmounts { get; init; }

    /// <summary>
    /// Breakdown of the aggregate quantity reported into significant lots, for example, tax lots.
    /// </summary>
    [IsoId("_grsy-yglEey2k_sfZmJz4g")]
    [DisplayName("Quantity Breakdown")]
    [IsoXmlTag("QtyBrkdwn")]
    public ValueList<QuantityBreakdown58> QuantityBreakdown { get; init; } = [];

    /// <summary>
    /// Breakdown of the aggregate balance per meaningful sub-balances and availability.
    /// </summary>
    [IsoId("_grszAyglEey2k_sfZmJz4g")]
    [DisplayName("Balance Breakdown")]
    [IsoXmlTag("BalBrkdwn")]
    public ValueList<SubBalanceInformation22> BalanceBreakdown { get; init; } = [];

    /// <summary>
    /// Provides additional instrument sub-balance information on all or parts of the reported financial instrument (unregistered, tax exempt, etc.).
    /// </summary>
    [IsoId("_grszCyglEey2k_sfZmJz4g")]
    [DisplayName("Additional Balance Breakdown")]
    [IsoXmlTag("AddtlBalBrkdwn")]
    public ValueList<AdditionalBalanceInformation22> AdditionalBalanceBreakdown { get; init; } = [];

    /// <summary>
    /// Breakdown of positions per place of safekeeping (and optionally per place of listing).
    /// </summary>
    [IsoId("_grszEyglEey2k_sfZmJz4g")]
    [DisplayName("Balance At Safekeeping Place")]
    [IsoXmlTag("BalAtSfkpgPlc")]
    public ValueList<AggregateBalancePerSafekeepingPlace37> BalanceAtSafekeepingPlace { get; init; } =
        [];

    /// <summary>
    /// Provides additional information on the holding.
    /// </summary>
    [IsoId("_grszGyglEey2k_sfZmJz4g")]
    [DisplayName("Holding Additional Details")]
    [IsoXmlTag("HldgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? HoldingAdditionalDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_grszIyglEey2k_sfZmJz4g")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
