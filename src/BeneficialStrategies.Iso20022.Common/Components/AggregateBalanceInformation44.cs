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
[IsoId("_csVCTzi8Eeydid5dcNPKvg")]
[DisplayName("Aggregate Balance Information")]
public record AggregateBalanceInformation44
{
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_csVCWzi8Eeydid5dcNPKvg")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Elements characterising a financial instrument other than a investment funds.
    /// </summary>
    [IsoId("_csVCYzi8Eeydid5dcNPKvg")]
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public FinancialInstrumentAttributes122? FinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Elements characterising an investment funds financial instrument.
    /// </summary>
    [IsoId("_csVCazi8Eeydid5dcNPKvg")]
    [DisplayName("Investment Funds Financial Instrument Attributes")]
    [IsoXmlTag("InvstmtFndsFinInstrmAttrbts")]
    public FinancialInstrument22? InvestmentFundsFinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Elements used to calculate the valuation haircut.
    /// </summary>
    [IsoId("_csVCbTi8Eeydid5dcNPKvg")]
    [DisplayName("Valuation Haircut Details")]
    [IsoXmlTag("ValtnHrcutDtls")]
    public BasicCollateralValuation1Details? ValuationHaircutDetails { get; init; }

    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [IsoId("_csVCdTi8Eeydid5dcNPKvg")]
    [DisplayName("Aggregate Balance")]
    [IsoXmlTag("AggtBal")]
    public required Balance22 AggregateBalance { get; init; }

    /// <summary>
    /// Total quantity of financial instruments of the balance that is available.
    /// </summary>
    [IsoId("_csVCfTi8Eeydid5dcNPKvg")]
    [DisplayName("Available Balance")]
    [IsoXmlTag("AvlblBal")]
    public Balance25? AvailableBalance { get; init; }

    /// <summary>
    /// Total quantity of financial instruments of the balance that is not available.
    /// </summary>
    [IsoId("_csVChTi8Eeydid5dcNPKvg")]
    [DisplayName("Not Available Balance")]
    [IsoXmlTag("NotAvlblBal")]
    public BalanceQuantity17Choice_? NotAvailableBalance { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_csVCjTi8Eeydid5dcNPKvg")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafeKeepingPlace4? SafekeepingPlace { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_csVClTi8Eeydid5dcNPKvg")]
    [DisplayName("Corporate Action Option Type")]
    [IsoXmlTag("CorpActnOptnTp")]
    public CorporateActionOption5Code? CorporateActionOptionType { get; init; }

    /// <summary>
    /// Price of the financial instrument in one or more currencies.
    /// </summary>
    [IsoId("_csVCnTi8Eeydid5dcNPKvg")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public ValueList<PriceInformation22> PriceDetails { get; init; } = [];

    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_csVCpTi8Eeydid5dcNPKvg")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ValueList<ForeignExchangeTerms35> ForeignExchangeDetails { get; init; } = [];

    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_csVCrTi8Eeydid5dcNPKvg")]
    [DisplayName("Days Accrued")]
    [IsoXmlTag("DaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? DaysAccrued { get; init; }

    /// <summary>
    /// Valuation amounts provided in the base currency of the account.
    /// </summary>
    [IsoId("_csVCtTi8Eeydid5dcNPKvg")]
    [DisplayName("Account Base Currency Amounts")]
    [IsoXmlTag("AcctBaseCcyAmts")]
    public BalanceAmounts4? AccountBaseCurrencyAmounts { get; init; }

    /// <summary>
    /// Valuation amounts provided in the currency of the financial instrument.
    /// </summary>
    [IsoId("_csVCvTi8Eeydid5dcNPKvg")]
    [DisplayName("Instrument Currency Amounts")]
    [IsoXmlTag("InstrmCcyAmts")]
    public BalanceAmounts4? InstrumentCurrencyAmounts { get; init; }

    /// <summary>
    /// Breakdown of the aggregate quantity reported into significant lots, for example, tax lots.
    /// </summary>
    [IsoId("_csVCxTi8Eeydid5dcNPKvg")]
    [DisplayName("Quantity Breakdown")]
    [IsoXmlTag("QtyBrkdwn")]
    public ValueList<QuantityBreakdown71> QuantityBreakdown { get; init; } = [];

    /// <summary>
    /// Breakdown of the aggregate balance per meaningful sub-balances and availability.
    /// </summary>
    [IsoId("_csVCzTi8Eeydid5dcNPKvg")]
    [DisplayName("Balance Breakdown")]
    [IsoXmlTag("BalBrkdwn")]
    public ValueList<SubBalanceInformation24> BalanceBreakdown { get; init; } = [];

    /// <summary>
    /// Provides additional instrument sub-balance information on all or parts of the reported financial instrument (unregistered, tax exempt, etc.).
    /// </summary>
    [IsoId("_csVC1Ti8Eeydid5dcNPKvg")]
    [DisplayName("Additional Balance Breakdown")]
    [IsoXmlTag("AddtlBalBrkdwn")]
    public ValueList<AdditionalBalanceInformation24> AdditionalBalanceBreakdown { get; init; } = [];

    /// <summary>
    /// Breakdown of positions per place of safekeeping (and optionally per place of listing).
    /// </summary>
    [IsoId("_csVC3Ti8Eeydid5dcNPKvg")]
    [DisplayName("Balance At Safekeeping Place")]
    [IsoXmlTag("BalAtSfkpgPlc")]
    public ValueList<AggregateBalancePerSafekeepingPlace41> BalanceAtSafekeepingPlace { get; init; } =
        [];

    /// <summary>
    /// Provides additional information on the holding.
    /// </summary>
    [IsoId("_csVC5Ti8Eeydid5dcNPKvg")]
    [DisplayName("Holding Additional Details")]
    [IsoXmlTag("HldgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoRestrictedFINXMax350Text? HoldingAdditionalDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_csVC7Ti8Eeydid5dcNPKvg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
