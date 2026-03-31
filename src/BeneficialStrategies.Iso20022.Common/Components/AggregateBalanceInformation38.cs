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
[IsoId("_Z0x7r_fVEeiNZp_PtLohLw")]
[DisplayName("Aggregate Balance Information")]
public record AggregateBalanceInformation38
{
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_Z0x7uffVEeiNZp_PtLohLw")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_Z0x7wffVEeiNZp_PtLohLw")]
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public FinancialInstrumentAttributes97? FinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Elements characterising an investment funds financial instrument.
    /// </summary>
    [IsoId("_Z0x7yffVEeiNZp_PtLohLw")]
    [DisplayName("Investment Funds Financial Instrument Attributes")]
    [IsoXmlTag("InvstmtFndsFinInstrmAttrbts")]
    public FinancialInstrument22? InvestmentFundsFinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Details of the swap contract.
    /// </summary>
    [IsoId("_Z0x7y_fVEeiNZp_PtLohLw")]
    [DisplayName("Additional Derivative Attributes")]
    [IsoXmlTag("AddtlDerivAttrbts")]
    public DerivativeBasicAttributes2? AdditionalDerivativeAttributes { get; init; }

    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [IsoId("_Z0x70_fVEeiNZp_PtLohLw")]
    [DisplayName("Aggregate Balance")]
    [IsoXmlTag("AggtBal")]
    public required Balance10 AggregateBalance { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_Z0x72_fVEeiNZp_PtLohLw")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafeKeepingPlace4? SafekeepingPlace { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_Z0x74_fVEeiNZp_PtLohLw")]
    [DisplayName("Corporate Action Option Type")]
    [IsoXmlTag("CorpActnOptnTp")]
    public CorporateActionOption5Code? CorporateActionOptionType { get; init; }

    /// <summary>
    /// Price of the financial instrument in one or more currencies.
    /// </summary>
    [IsoId("_Z0x76_fVEeiNZp_PtLohLw")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public ValueList<PriceInformation22> PriceDetails { get; init; } = [];

    // ID for the above is _Z0x76_fVEeiNZp_PtLohLw

    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_Z0x78_fVEeiNZp_PtLohLw")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ValueList<ForeignExchangeTerms35> ForeignExchangeDetails { get; init; } = [];

    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_Z0x7-_fVEeiNZp_PtLohLw")]
    [DisplayName("Days Accrued")]
    [IsoXmlTag("DaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? DaysAccrued { get; init; }

    /// <summary>
    /// Valuation amounts provided in the base currency of the account.
    /// </summary>
    [IsoId("_Z0x8A_fVEeiNZp_PtLohLw")]
    [DisplayName("Account Base Currency Amounts")]
    [IsoXmlTag("AcctBaseCcyAmts")]
    public required BalanceAmounts5 AccountBaseCurrencyAmounts { get; init; }

    /// <summary>
    /// Valuation amounts provided in the currency of the financial instrument.
    /// </summary>
    [IsoId("_Z0x8C_fVEeiNZp_PtLohLw")]
    [DisplayName("Instrument Currency Amounts")]
    [IsoXmlTag("InstrmCcyAmts")]
    public BalanceAmounts5? InstrumentCurrencyAmounts { get; init; }

    /// <summary>
    /// Valuation amounts provided in a currency other than the base currency of the account.
    /// </summary>
    [IsoId("_Z0x8E_fVEeiNZp_PtLohLw")]
    [DisplayName("Alternate Reporting Currency Amounts")]
    [IsoXmlTag("AltrnRptgCcyAmts")]
    public BalanceAmounts5? AlternateReportingCurrencyAmounts { get; init; }

    /// <summary>
    /// Breakdown of the aggregate quantity reported into significant lots, for example, tax lots.
    /// </summary>
    [IsoId("_Z0x8G_fVEeiNZp_PtLohLw")]
    [DisplayName("Quantity Breakdown")]
    [IsoXmlTag("QtyBrkdwn")]
    public ValueList<QuantityBreakdown55> QuantityBreakdown { get; init; } = [];

    /// <summary>
    /// Breakdown of the aggregate balance per meaningful sub-balances and availability.
    /// </summary>
    [IsoId("_Z0x8I_fVEeiNZp_PtLohLw")]
    [DisplayName("Balance Breakdown")]
    [IsoXmlTag("BalBrkdwn")]
    public ValueList<SubBalanceInformation16> BalanceBreakdown { get; init; } = [];

    /// <summary>
    /// Provides additional instrument sub-balance information on all or parts of the reported financial instrument (unregistered, tax exempt, etc.).
    /// </summary>
    [IsoId("_Z0x8K_fVEeiNZp_PtLohLw")]
    [DisplayName("Additional Balance Breakdown")]
    [IsoXmlTag("AddtlBalBrkdwn")]
    public ValueList<AdditionalBalanceInformation16> AdditionalBalanceBreakdown { get; init; } = [];

    /// <summary>
    /// Breakdown of positions per place of safekeeping (and optionally per place of listing).
    /// </summary>
    [IsoId("_Z0x8M_fVEeiNZp_PtLohLw")]
    [DisplayName("Balance At Safekeeping Place")]
    [IsoXmlTag("BalAtSfkpgPlc")]
    public ValueList<AggregateBalancePerSafekeepingPlace35> BalanceAtSafekeepingPlace { get; init; } =
        [];

    /// <summary>
    /// Provides additional information on the holding.
    /// </summary>
    [IsoId("_Z0x8O_fVEeiNZp_PtLohLw")]
    [DisplayName("Holding Additional Details")]
    [IsoXmlTag("HldgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoRestrictedFINXMax350Text? HoldingAdditionalDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Z0x8Q_fVEeiNZp_PtLohLw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
