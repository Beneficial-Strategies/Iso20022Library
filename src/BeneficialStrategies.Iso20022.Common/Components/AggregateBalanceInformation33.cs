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
[IsoId("_5eQa85NLEeWGlc8L7oPDIg")]
[DisplayName("Aggregate Balance Information")]
public record AggregateBalanceInformation33
{
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_5eQa_ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Elements characterising a financial instrument other than a investment funds.
    /// </summary>
    [IsoId("_5eQbBZNLEeWGlc8L7oPDIg")]
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public FinancialInstrumentAttributes78? FinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Elements characterising an investment funds financial instrument.
    /// </summary>
    [IsoId("_5eQbDZNLEeWGlc8L7oPDIg")]
    [DisplayName("Investment Funds Financial Instrument Attributes")]
    [IsoXmlTag("InvstmtFndsFinInstrmAttrbts")]
    public FinancialInstrument22? InvestmentFundsFinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Elements used to calculate the valuation haircut.
    /// </summary>
    [IsoId("_5eQbD5NLEeWGlc8L7oPDIg")]
    [DisplayName("Valuation Haircut Details")]
    [IsoXmlTag("ValtnHrcutDtls")]
    public BasicCollateralValuation1Details? ValuationHaircutDetails { get; init; }

    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [IsoId("_5eQbF5NLEeWGlc8L7oPDIg")]
    [DisplayName("Aggregate Balance")]
    [IsoXmlTag("AggtBal")]
    public required Balance10 AggregateBalance { get; init; }

    /// <summary>
    /// Total quantity of financial instruments of the balance that is available.
    /// </summary>
    [IsoId("_5eQbH5NLEeWGlc8L7oPDIg")]
    [DisplayName("Available Balance")]
    [IsoXmlTag("AvlblBal")]
    public Balance12? AvailableBalance { get; init; }

    /// <summary>
    /// Total quantity of financial instruments of the balance that is not available.
    /// </summary>
    [IsoId("_5eQbJ5NLEeWGlc8L7oPDIg")]
    [DisplayName("Not Available Balance")]
    [IsoXmlTag("NotAvlblBal")]
    public BalanceQuantity12Choice_? NotAvailableBalance { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_5eQbL5NLEeWGlc8L7oPDIg")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafeKeepingPlace2? SafekeepingPlace { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_5eQbN5NLEeWGlc8L7oPDIg")]
    [DisplayName("Corporate Action Option Type")]
    [IsoXmlTag("CorpActnOptnTp")]
    public CorporateActionOption5Code? CorporateActionOptionType { get; init; }

    /// <summary>
    /// Price of the financial instrument in one or more currencies.
    /// </summary>
    [IsoId("_5eQbP5NLEeWGlc8L7oPDIg")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public ValueList<PriceInformation14> PriceDetails { get; init; } = [];

    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_5eQbR5NLEeWGlc8L7oPDIg")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ValueList<ForeignExchangeTerms31> ForeignExchangeDetails { get; init; } = [];

    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_5eQbT5NLEeWGlc8L7oPDIg")]
    [DisplayName("Days Accrued")]
    [IsoXmlTag("DaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? DaysAccrued { get; init; }

    /// <summary>
    /// Valuation amounts provided in the base currency of the account.
    /// </summary>
    [IsoId("_5eQbV5NLEeWGlc8L7oPDIg")]
    [DisplayName("Account Base Currency Amounts")]
    [IsoXmlTag("AcctBaseCcyAmts")]
    public BalanceAmounts4? AccountBaseCurrencyAmounts { get; init; }

    /// <summary>
    /// Valuation amounts provided in the currency of the financial instrument.
    /// </summary>
    [IsoId("_5eQbX5NLEeWGlc8L7oPDIg")]
    [DisplayName("Instrument Currency Amounts")]
    [IsoXmlTag("InstrmCcyAmts")]
    public BalanceAmounts4? InstrumentCurrencyAmounts { get; init; }

    /// <summary>
    /// Breakdown of the aggregate quantity reported into significant lots, for example, tax lots.
    /// </summary>
    [IsoId("_5eQbZ5NLEeWGlc8L7oPDIg")]
    [DisplayName("Quantity Breakdown")]
    [IsoXmlTag("QtyBrkdwn")]
    public ValueList<QuantityBreakdown40> QuantityBreakdown { get; init; } = [];

    /// <summary>
    /// Breakdown of the aggregate balance per meaningful sub-balances and availability.
    /// </summary>
    [IsoId("_5eQbb5NLEeWGlc8L7oPDIg")]
    [DisplayName("Balance Breakdown")]
    [IsoXmlTag("BalBrkdwn")]
    public ValueList<SubBalanceInformation17> BalanceBreakdown { get; init; } = [];

    /// <summary>
    /// Provides additional instrument sub-balance information on all or parts of the reported financial instrument (unregistered, tax exempt, etc.).
    /// </summary>
    [IsoId("_5eQbd5NLEeWGlc8L7oPDIg")]
    [DisplayName("Additional Balance Breakdown")]
    [IsoXmlTag("AddtlBalBrkdwn")]
    public ValueList<AdditionalBalanceInformation17> AdditionalBalanceBreakdown { get; init; } = [];

    /// <summary>
    /// Breakdown of positions per place of safekeeping (and optionally per place of listing).
    /// </summary>
    [IsoId("_5eQbf5NLEeWGlc8L7oPDIg")]
    [DisplayName("Balance At Safekeeping Place")]
    [IsoXmlTag("BalAtSfkpgPlc")]
    public ValueList<AggregateBalancePerSafekeepingPlace31> BalanceAtSafekeepingPlace { get; init; } =
        [];

    /// <summary>
    /// Provides additional information on the holding.
    /// </summary>
    [IsoId("_5eQbh5NLEeWGlc8L7oPDIg")]
    [DisplayName("Holding Additional Details")]
    [IsoXmlTag("HldgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoRestrictedFINXMax350Text? HoldingAdditionalDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_5eQbj5NLEeWGlc8L7oPDIg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
