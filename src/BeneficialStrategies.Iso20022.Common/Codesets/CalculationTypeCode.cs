// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies calculation types such as yield, duration, analytics etc.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bWBbENp-Ed-ak6NoX_4Aeg_-1231865775")]
[Description(@"Specifies calculation types such as yield, duration, analytics etc.")]
[Derivations(typeof(CalculationType1Code))]
public enum CalculationTypeCode
{
    /// <summary>
    /// Measure of change in duration (linear measure of changes in bond price in reaction to interest rate changes) of a bond as interest rate changes over time.
    /// Encoded/decoded by serializers as &quot;CNVX&quot;.
    /// </summary>
    [EnumMember(Value = "CNVX")]
    [IsoId("_bWBbEdp-Ed-ak6NoX_4Aeg_-1231865744")]
    [Description(
        @"Measure of change in duration (linear measure of changes in bond price in reaction to interest rate changes) of a bond as interest rate changes over time."
    )]
    Convexity,

    /// <summary>
    /// A statistical measure of the dispersion of returns for a given security or market index. Volatility can either be measured by using the standard deviation or variance between returns from that same security or market index.
    /// Encoded/decoded by serializers as &quot;VOLA&quot;.
    /// </summary>
    [EnumMember(Value = "VOLA")]
    [IsoId("_bWBbEtp-Ed-ak6NoX_4Aeg_-1231865714")]
    [Description(
        @"A statistical measure of the dispersion of returns for a given security or market index. Volatility can either be measured by using the standard deviation or variance between returns from that same security or market index."
    )]
    Volatility,

    /// <summary>
    /// Excess return on an investment attributed to an investment managers performance.
    /// Encoded/decoded by serializers as &quot;ALFA&quot;.
    /// </summary>
    [EnumMember(Value = "ALFA")]
    [IsoId("_bWBbE9p-Ed-ak6NoX_4Aeg_-1231865713")]
    [Description(
        @"Excess return on an investment attributed to an investment managers performance."
    )]
    Alpha,

    /// <summary>
    /// Volatility of an instrument relative to a particular market set of instruments.
    /// Encoded/decoded by serializers as &quot;BETA&quot;.
    /// </summary>
    [EnumMember(Value = "BETA")]
    [IsoId("_bWBbFNp-Ed-ak6NoX_4Aeg_-1231865712")]
    [Description(
        @"Volatility of an instrument relative to a particular market set of instruments."
    )]
    Beta,

    /// <summary>
    /// First order (linear) sensitivity to changes in an underlying security price.
    /// Encoded/decoded by serializers as &quot;DLTA&quot;.
    /// </summary>
    [EnumMember(Value = "DLTA")]
    [IsoId("_bWBbFdp-Ed-ak6NoX_4Aeg_-1231865466")]
    [Description(@"First order (linear) sensitivity to changes in an underlying security price.")]
    Delta,

    /// <summary>
    /// Second order (quadratic) sensitivity to changes in an underlying security price.
    /// Encoded/decoded by serializers as &quot;GAMA&quot;.
    /// </summary>
    [EnumMember(Value = "GAMA")]
    [IsoId("_bWBbFtp-Ed-ak6NoX_4Aeg_-1231865465")]
    [Description(
        @"Second order (quadratic) sensitivity to changes in an underlying security price."
    )]
    Gamma,

    /// <summary>
    /// Third order sensitivity to changes in an underlying security price.
    /// Encoded/decoded by serializers as &quot;SPID&quot;.
    /// </summary>
    [EnumMember(Value = "SPID")]
    [IsoId("_bWBbF9p-Ed-ak6NoX_4Aeg_-1231865464")]
    [Description(@"Third order sensitivity to changes in an underlying security price.")]
    Speed,

    /// <summary>
    /// First order (linear) sensitivity to changes in the risk free rate of return.
    /// Encoded/decoded by serializers as &quot;RHOO&quot;.
    /// </summary>
    [EnumMember(Value = "RHOO")]
    [IsoId("_bWBbGNp-Ed-ak6NoX_4Aeg_-1231865436")]
    [Description(@"First order (linear) sensitivity to changes in the risk free rate of return.")]
    Rho,

    /// <summary>
    /// First order (linear) sensitivity to the passage of time.
    /// Encoded/decoded by serializers as &quot;TETA&quot;.
    /// </summary>
    [EnumMember(Value = "TETA")]
    [IsoId("_bWKlANp-Ed-ak6NoX_4Aeg_-1231865435")]
    [Description(@"First order (linear) sensitivity to the passage of time.")]
    Theta,

    /// <summary>
    /// First order (linear) sensitivity to changes in implied volatility of an underlying security. Sometimes called kappa or tau.
    /// Encoded/decoded by serializers as &quot;VEGA&quot;.
    /// </summary>
    [EnumMember(Value = "VEGA")]
    [IsoId("_bWKlAdp-Ed-ak6NoX_4Aeg_-1231865434")]
    [Description(
        @"First order (linear) sensitivity to changes in implied volatility of an underlying security. Sometimes called kappa or tau."
    )]
    Vega,

    /// <summary>
    /// A ratio used to determine a stock&apos;s value while taking into account earnings growth.
    /// Encoded/decoded by serializers as &quot;PRER&quot;.
    /// </summary>
    [EnumMember(Value = "PRER")]
    [IsoId("_bWKlAtp-Ed-ak6NoX_4Aeg_-1231865405")]
    [Description(
        @"A ratio used to determine a stock's value while taking into account earnings growth."
    )]
    PriceEarningRatio,

    /// <summary>
    /// Percent change in option value per change in underlying price.
    /// Encoded/decoded by serializers as &quot;LMDA&quot;.
    /// </summary>
    [EnumMember(Value = "LMDA")]
    [IsoId("_bWKlA9p-Ed-ak6NoX_4Aeg_-1231865404")]
    [Description(@"Percent change in option value per change in underlying price.")]
    Lambda,

    /// <summary>
    /// Second order (quadratic) sensitivity to changes in implied volatility in an underlying security price. Also called Volga.
    /// Encoded/decoded by serializers as &quot;VGAM&quot;.
    /// </summary>
    [EnumMember(Value = "VGAM")]
    [IsoId("_bWKlBNp-Ed-ak6NoX_4Aeg_-1231865403")]
    [Description(
        @"Second order (quadratic) sensitivity to changes in implied volatility in an underlying security price. Also called Volga."
    )]
    VegaGamma,

    /// <summary>
    /// Sensitivity of delta to a change in volatility.
    /// Encoded/decoded by serializers as &quot;VANA&quot;.
    /// </summary>
    [EnumMember(Value = "VANA")]
    [IsoId("_bWKlBdp-Ed-ak6NoX_4Aeg_-1231865382")]
    [Description(@"Sensitivity of delta to a change in volatility.")]
    Vanna,

    /// <summary>
    /// Measures time decay of Delta.
    /// Encoded/decoded by serializers as &quot;DEDE&quot;.
    /// </summary>
    [EnumMember(Value = "DEDE")]
    [IsoId("_bWKlBtp-Ed-ak6NoX_4Aeg_-1231865374")]
    [Description(@"Measures time decay of Delta.")]
    DeltaDecay,

    /// <summary>
    /// Sensitivity of Delta Decay to underlying price.
    /// Encoded/decoded by serializers as &quot;COLR&quot;.
    /// </summary>
    [EnumMember(Value = "COLR")]
    [IsoId("_bWKlB9p-Ed-ak6NoX_4Aeg_-1231865373")]
    [Description(@"Sensitivity of Delta Decay to underlying price.")]
    Color,

    /// <summary>
    /// A ratio used to compare a stock&apos;s market value to its book value. It is calculated by dividing the current closing price of the stock by the latest quarter&apos;s book value per share.
    /// Encoded/decoded by serializers as &quot;PRBR&quot;.
    /// </summary>
    [EnumMember(Value = "PRBR")]
    [IsoId("_bWKlCNp-Ed-ak6NoX_4Aeg_-1231865351")]
    [Description(
        @"A ratio used to compare a stock's market value to its book value. It is calculated by dividing the current closing price of the stock by the latest quarter's book value per share."
    )]
    PriceBookRatio,

    /// <summary>
    /// A ratio for valuing a stock relative to its own past performance, other companies or the market itself. Price to sales is calculated by dividing a stock&apos;s current price by its revenue per share for the trailing 12 months.
    /// Encoded/decoded by serializers as &quot;PRSR&quot;.
    /// </summary>
    [EnumMember(Value = "PRSR")]
    [IsoId("_bWKlCdp-Ed-ak6NoX_4Aeg_-1231865343")]
    [Description(
        @"A ratio for valuing a stock relative to its own past performance, other companies or the market itself. Price to sales is calculated by dividing a stock's current price by its revenue per share for the trailing 12 months."
    )]
    PriceSalesRatio,

    /// <summary>
    /// The portion of a company&apos;s profit allocated to each outstanding share of common stock. EPS serves as an indicator of a company&apos;s profitability.
    /// Encoded/decoded by serializers as &quot;EAPS&quot;.
    /// </summary>
    [EnumMember(Value = "EAPS")]
    [IsoId("_bWUWANp-Ed-ak6NoX_4Aeg_-1231865342")]
    [Description(
        @"The portion of a company's profit allocated to each outstanding share of common stock. EPS serves as an indicator of a company's profitability."
    )]
    EarningPerShare,

    /// <summary>
    /// Percent Change in EPS Trailing Twelve Months.
    /// Encoded/decoded by serializers as &quot;EPPC&quot;.
    /// </summary>
    [EnumMember(Value = "EPPC")]
    [IsoId("_bWUWAdp-Ed-ak6NoX_4Aeg_-1231865341")]
    [Description(@"Percent Change in EPS Trailing Twelve Months.")]
    EPSPercentChange,

    /// <summary>
    /// Net income as percent of sales.
    /// Encoded/decoded by serializers as &quot;NISR&quot;.
    /// </summary>
    [EnumMember(Value = "NISR")]
    [IsoId("_bWUWAtp-Ed-ak6NoX_4Aeg_-1231865320")]
    [Description(@"Net income as percent of sales.")]
    NetIncomeSalesRatio,

    /// <summary>
    /// A ratio used to determine a stock&apos;s value while taking into account earnings growth.
    /// Encoded/decoded by serializers as &quot;PREG&quot;.
    /// </summary>
    [EnumMember(Value = "PREG")]
    [IsoId("_bWUWA9p-Ed-ak6NoX_4Aeg_-1231865312")]
    [Description(
        @"A ratio used to determine a stock's value while taking into account earnings growth."
    )]
    PriceEarningsGrowth,

    /// <summary>
    /// The current assets minus the inventory and the result is divided by the liabilities.|(Current Assets - Inventory)/Liabilities.
    /// Encoded/decoded by serializers as &quot;QIKR&quot;.
    /// </summary>
    [EnumMember(Value = "QIKR")]
    [IsoId("_bWUWBNp-Ed-ak6NoX_4Aeg_-1231865311")]
    [Description(
        @"The current assets minus the inventory and the result is divided by the liabilities.|(Current Assets - Inventory)/Liabilities."
    )]
    QuickRatio,

    /// <summary>
    /// The current assets are divided by the current liabilities.
    /// Encoded/decoded by serializers as &quot;CURA&quot;.
    /// </summary>
    [EnumMember(Value = "CURA")]
    [IsoId("_bWUWBdp-Ed-ak6NoX_4Aeg_-1231865042")]
    [Description(@"The current assets are divided by the current liabilities.")]
    CurrentRatio,

    /// <summary>
    /// Dividends per Share divided by EPS.
    /// Encoded/decoded by serializers as &quot;DIPR&quot;.
    /// </summary>
    [EnumMember(Value = "DIPR")]
    [IsoId("_bWUWBtp-Ed-ak6NoX_4Aeg_-1231865041")]
    [Description(@"Dividends per Share divided by EPS.")]
    DividendPayoutRatio,

    /// <summary>
    /// Total Liabilities divided by the shareholder equity.
    /// Encoded/decoded by serializers as &quot;DEQR&quot;.
    /// </summary>
    [EnumMember(Value = "DEQR")]
    [IsoId("_bWUWB9p-Ed-ak6NoX_4Aeg_-1231865033")]
    [Description(@"Total Liabilities divided by the shareholder equity.")]
    DebtEquityRatio,

    /// <summary>
    /// A measure of a corporation&apos;s profitability that reveals how much profit a company generates with the money shareholders have invested. .
    /// Encoded/decoded by serializers as &quot;RTOE&quot;.
    /// </summary>
    [EnumMember(Value = "RTOE")]
    [IsoId("_bWUWCNp-Ed-ak6NoX_4Aeg_-1231865011")]
    [Description(
        @"A measure of a corporation's profitability that reveals how much profit a company generates with the money shareholders have invested. ."
    )]
    ReturnOnEquity,

    /// <summary>
    /// An indicator of how profitable a company is relative to its total assets. Return On Assets gives an idea as to how efficient management is at using its assets to generate earnings. Calculated by dividing a company&apos;s annual earnings by its total assets, Return On Assets is displayed as a percentage.
    /// Encoded/decoded by serializers as &quot;RTOA&quot;.
    /// </summary>
    [EnumMember(Value = "RTOA")]
    [IsoId("_bWUWCdp-Ed-ak6NoX_4Aeg_-1231865010")]
    [Description(
        @"An indicator of how profitable a company is relative to its total assets. Return On Assets gives an idea as to how efficient management is at using its assets to generate earnings. Calculated by dividing a company's annual earnings by its total assets, Return On Assets is displayed as a percentage."
    )]
    ReturnOnAssets,

    /// <summary>
    /// Return on investment.
    /// Encoded/decoded by serializers as &quot;REOI&quot;.
    /// </summary>
    [EnumMember(Value = "REOI")]
    [IsoId("_bWeHANp-Ed-ak6NoX_4Aeg_-1231865002")]
    [Description(@"Return on investment.")]
    ReturnOnInvestment,

    /// <summary>
    /// Important ratio that looks at a company&apos;s sales in relation to the number of employees they have.
    /// Encoded/decoded by serializers as &quot;SAEM&quot;.
    /// </summary>
    [EnumMember(Value = "SAEM")]
    [IsoId("_bWeHAdp-Ed-ak6NoX_4Aeg_-1231864980")]
    [Description(
        @"Important ratio that looks at a company's sales in relation to the number of employees they have."
    )]
    SalesEmployee,

    /// <summary>
    /// Balance sheet account that represents the value of all assets that are reasonably expected to be converted into cash within one year in the normal course of business. Current assets include cash, accounts receivable, inventory, marketable securities, prepaid expenses and other liquid assets that can be readily converted to cash.
    /// Encoded/decoded by serializers as &quot;CUAS&quot;.
    /// </summary>
    [EnumMember(Value = "CUAS")]
    [IsoId("_bWeHAtp-Ed-ak6NoX_4Aeg_-1231864979")]
    [Description(
        @"Balance sheet account that represents the value of all assets that are reasonably expected to be converted into cash within one year in the normal course of business. Current assets include cash, accounts receivable, inventory, marketable securities, prepaid expenses and other liquid assets that can be readily converted to cash."
    )]
    CurrentAssets,

    /// <summary>
    /// Loans and financial obligations lasting over one year.
    /// Encoded/decoded by serializers as &quot;LTDB&quot;.
    /// </summary>
    [EnumMember(Value = "LTDB")]
    [IsoId("_bWeHA9p-Ed-ak6NoX_4Aeg_-1231864971")]
    [Description(@"Loans and financial obligations lasting over one year.")]
    LongTermDebt,

    /// <summary>
    /// Company&apos;s debts or obligations that are due within one year. Current liabilities appear on the company&apos;s balance sheet and include short term debt, accounts payable, accrued liabilities and other debts.
    /// Encoded/decoded by serializers as &quot;CULI&quot;.
    /// </summary>
    [EnumMember(Value = "CULI")]
    [IsoId("_bWeHBNp-Ed-ak6NoX_4Aeg_-1231864950")]
    [Description(
        @"Company's debts or obligations that are due within one year. Current liabilities appear on the company's balance sheet and include short term debt, accounts payable, accrued liabilities and other debts."
    )]
    CurrentLiabilities,

    /// <summary>
    /// Amount of sales.
    /// Encoded/decoded by serializers as &quot;SARE&quot;.
    /// </summary>
    [EnumMember(Value = "SARE")]
    [IsoId("_bWeHBdp-Ed-ak6NoX_4Aeg_-1231864949")]
    [Description(@"Amount of sales.")]
    SalesRevenue,

    /// <summary>
    /// Financial metric used to assess a firm&apos;s financial health by revealing the proportion of money left over from revenues after accounting for the cost of goods sold. Gross profit margin serves as the source for paying additional expenses and future savings.
    /// Encoded/decoded by serializers as &quot;SAMA&quot;.
    /// </summary>
    [EnumMember(Value = "SAMA")]
    [IsoId("_bWeHBtp-Ed-ak6NoX_4Aeg_-1231864948")]
    [Description(
        @"Financial metric used to assess a firm's financial health by revealing the proportion of money left over from revenues after accounting for the cost of goods sold. Gross profit margin serves as the source for paying additional expenses and future savings."
    )]
    SalesMargin,

    /// <summary>
    /// Last twelve months or calendar year.
    /// Encoded/decoded by serializers as &quot;FUAR&quot;.
    /// </summary>
    [EnumMember(Value = "FUAR")]
    [IsoId("_bWeHB9p-Ed-ak6NoX_4Aeg_-1231864919")]
    [Description(@"Last twelve months or calendar year.")]
    FundAnnualReturn,

    /// <summary>
    /// Requires timeframe - generally from inception or in 3, 5, and 10 year periods.
    /// Encoded/decoded by serializers as &quot;FUCR&quot;.
    /// </summary>
    [EnumMember(Value = "FUCR")]
    [IsoId("_bWeHCNp-Ed-ak6NoX_4Aeg_-1231864918")]
    [Description(@"Requires timeframe - generally from inception or in 3, 5, and 10 year periods.")]
    FundCumReturn,

    /// <summary>
    /// Portfolio volatility as a percentage.
    /// Encoded/decoded by serializers as &quot;FUSD&quot;.
    /// </summary>
    [EnumMember(Value = "FUSD")]
    [IsoId("_bWeHCdp-Ed-ak6NoX_4Aeg_-1231864917")]
    [Description(@"Portfolio volatility as a percentage.")]
    FundStandardDeviation,

    /// <summary>
    /// Variance between the fund annual return and a benchmark.
    /// Encoded/decoded by serializers as &quot;FEAR&quot;.
    /// </summary>
    [EnumMember(Value = "FEAR")]
    [IsoId("_bWeHCtp-Ed-ak6NoX_4Aeg_-1231864889")]
    [Description(@"Variance between the fund annual return and a benchmark.")]
    FundBenchExcessAnnualReturn,

    /// <summary>
    /// Requires timeframe - generally from inception or in 3, 5, and 10 year periods.
    /// Encoded/decoded by serializers as &quot;FECR&quot;.
    /// </summary>
    [EnumMember(Value = "FECR")]
    [IsoId("_bWnQ8Np-Ed-ak6NoX_4Aeg_-1231864888")]
    [Description(@"Requires timeframe - generally from inception or in 3, 5, and 10 year periods.")]
    FundBenchExcessCumReturn,

    /// <summary>
    /// Volatility of fund excess return.
    /// Encoded/decoded by serializers as &quot;FBTE&quot;.
    /// </summary>
    [EnumMember(Value = "FBTE")]
    [IsoId("_bWnQ8dp-Ed-ak6NoX_4Aeg_-1231864887")]
    [Description(@"Volatility of fund excess return.")]
    FundBenchTrackingError,

    /// <summary>
    /// Portfolio volatility as a percentage.
    /// Encoded/decoded by serializers as &quot;FPSD&quot;.
    /// </summary>
    [EnumMember(Value = "FPSD")]
    [IsoId("_bWnQ8tp-Ed-ak6NoX_4Aeg_-1231864858")]
    [Description(@"Portfolio volatility as a percentage.")]
    FundPortfolioStandardDeviation,

    /// <summary>
    /// Last twelve months or calendar year.
    /// Encoded/decoded by serializers as &quot;FBAR&quot;.
    /// </summary>
    [EnumMember(Value = "FBAR")]
    [IsoId("_bWnQ89p-Ed-ak6NoX_4Aeg_-1231864857")]
    [Description(@"Last twelve months or calendar year.")]
    FundBenchAnnualReturn,

    /// <summary>
    /// Requires timeframe - generally from inception or in 3, 5, and 10 year periods.
    /// Encoded/decoded by serializers as &quot;FBCR&quot;.
    /// </summary>
    [EnumMember(Value = "FBCR")]
    [IsoId("_bWnQ9Np-Ed-ak6NoX_4Aeg_-1231864856")]
    [Description(@"Requires timeframe - generally from inception or in 3, 5, and 10 year periods.")]
    FundBenchCumReturn,

    /// <summary>
    /// Life of the bond to next probable call.
    /// Encoded/decoded by serializers as &quot;LNPC&quot;.
    /// </summary>
    [EnumMember(Value = "LNPC")]
    [IsoId("_bWnQ9dp-Ed-ak6NoX_4Aeg_1599249320")]
    [Description(@"Life of the bond to next probable call.")]
    LifeToNextProbableCall,

    /// <summary>
    /// Weighted average time to redemption of an amortising bond using relative redemption cash flows as weights.
    /// Encoded/decoded by serializers as &quot;AVGL&quot;.
    /// </summary>
    [EnumMember(Value = "AVGL")]
    [IsoId("_bWnQ9tp-Ed-ak6NoX_4Aeg_-1098877955")]
    [Description(
        @"Weighted average time to redemption of an amortising bond using relative redemption cash flows as weights."
    )]
    AverageLife,

    /// <summary>
    /// Weighted-average term to maturity of the cash flows from a bond. The weight of each cash flow is determined by dividing the present value of the cash flow by the price.
    /// Encoded/decoded by serializers as &quot;MADU&quot;.
    /// </summary>
    [EnumMember(Value = "MADU")]
    [IsoId("_bWnQ99p-Ed-ak6NoX_4Aeg_-1069324206")]
    [Description(
        @"Weighted-average term to maturity of the cash flows from a bond. The weight of each cash flow is determined by dividing the present value of the cash flow by the price."
    )]
    MacaulyDuration,

    /// <summary>
    /// Formula that expresses the measurable change in the value of a security in response to a change in interest rates.
    /// Encoded/decoded by serializers as &quot;MODU&quot;.
    /// </summary>
    [EnumMember(Value = "MODU")]
    [IsoId("_bWnQ-Np-Ed-ak6NoX_4Aeg_-1059167316")]
    [Description(
        @"Formula that expresses the measurable change in the value of a security in response to a change in interest rates."
    )]
    ModifiedDuration,

    /// <summary>
    /// Measurement of how long, in years, it takes for the price of a bond to be repaid by its internal cash flows.
    /// Encoded/decoded by serializers as &quot;DURA&quot;.
    /// </summary>
    [EnumMember(Value = "DURA")]
    [IsoId("_bWnQ-dp-Ed-ak6NoX_4Aeg_-1049006373")]
    [Description(
        @"Measurement of how long, in years, it takes for the price of a bond to be repaid by its internal cash flows."
    )]
    Duration,

    /// <summary>
    /// Yield is the annual rate of return for any investment and is expressed as a percentage.
    /// Encoded/decoded by serializers as &quot;YIEL&quot;.
    /// </summary>
    [EnumMember(Value = "YIEL")]
    [IsoId("_bWxB8Np-Ed-ak6NoX_4Aeg_-1040697443")]
    [Description(
        @"Yield is the annual rate of return for any investment and is expressed as a percentage."
    )]
    Yield,

    /// <summary>
    /// Internal rate of return an investor would achieve if he or she purchased that bond at its current dirty price, and held it to maturity, assuming all coupon and principal payments are received as scheduled.
    /// Encoded/decoded by serializers as &quot;YTMA&quot;.
    /// </summary>
    [EnumMember(Value = "YTMA")]
    [IsoId("_bWxB8dp-Ed-ak6NoX_4Aeg_-1031460976")]
    [Description(
        @"Internal rate of return an investor would achieve if he or she purchased that bond at its current dirty price, and held it to maturity, assuming all coupon and principal payments are received as scheduled."
    )]
    YieldToMaturity,

    /// <summary>
    /// The ratio of the interest payment amount to the clean price.
    /// Encoded/decoded by serializers as &quot;CUYI&quot;.
    /// </summary>
    [EnumMember(Value = "CUYI")]
    [IsoId("_bWxB8tp-Ed-ak6NoX_4Aeg_-1028688911")]
    [Description(@"The ratio of the interest payment amount to the clean price.")]
    CurrentYield,

    /// <summary>
    /// Yield quoted for a discount instrument. This is the ratio of the discount to the face value, divided by the period to maturity as a fraction of a year.
    /// Encoded/decoded by serializers as &quot;DIYI&quot;.
    /// </summary>
    [EnumMember(Value = "DIYI")]
    [IsoId("_bWxB89p-Ed-ak6NoX_4Aeg_-817205884")]
    [Description(
        @"Yield quoted for a discount instrument. This is the ratio of the discount to the face value, divided by the period to maturity as a fraction of a year."
    )]
    DiscountYield,

    /// <summary>
    /// Dividend related to the price.
    /// Encoded/decoded by serializers as &quot;DIRY&quot;.
    /// </summary>
    [EnumMember(Value = "DIRY")]
    [IsoId("_bWxB9Np-Ed-ak6NoX_4Aeg_-814434220")]
    [Description(@"Dividend related to the price.")]
    DirectYield,

    /// <summary>
    /// Yield of a bond to the next possible call date.
    /// Encoded/decoded by serializers as &quot;YTNC&quot;.
    /// </summary>
    [EnumMember(Value = "YTNC")]
    [IsoId("_bWxB9dp-Ed-ak6NoX_4Aeg_-811663811")]
    [Description(@"Yield of a bond to the next possible call date.")]
    YieldToNextCall,

    /// <summary>
    /// The yield achieved by substituting a bond&apos;s average life for the issue&apos;s final maturity date.
    /// Encoded/decoded by serializers as &quot;YTAL&quot;.
    /// </summary>
    [EnumMember(Value = "YTAL")]
    [IsoId("_bWxB9tp-Ed-ak6NoX_4Aeg_-802429116")]
    [Description(
        @"The yield achieved by substituting a bond's average life for the issue's final maturity date."
    )]
    YieldToAverageLife,

    /// <summary>
    /// Calculation for restating semi-annual, quarterly, or monthly discount-bond or note yields into an annual yield.
    /// Encoded/decoded by serializers as &quot;BEQY&quot;.
    /// </summary>
    [EnumMember(Value = "BEQY")]
    [IsoId("_bWxB99p-Ed-ak6NoX_4Aeg_-799656597")]
    [Description(
        @"Calculation for restating semi-annual, quarterly, or monthly discount-bond or note yields into an annual yield."
    )]
    BondEquivalentYield,

    /// <summary>
    /// The yield on the bond net of any tax consequences from holding the bond. The discount on municipal securities can be subject to both capital gains taxes and ordinary income taxes. Calculated from dollar price.
    /// Encoded/decoded by serializers as &quot;AFTX&quot;.
    /// </summary>
    [EnumMember(Value = "AFTX")]
    [IsoId("_bWxB-Np-Ed-ak6NoX_4Aeg_-60929298")]
    [Description(
        @"The yield on the bond net of any tax consequences from holding the bond. The discount on municipal securities can be subject to both capital gains taxes and ordinary income taxes. Calculated from dollar price."
    )]
    AfterTax,

    /// <summary>
    /// The annual interest or dividend income an investment earns, expressed as a percentage of the investment&apos;s total value.
    /// Encoded/decoded by serializers as &quot;ANNU&quot;.
    /// </summary>
    [EnumMember(Value = "ANNU")]
    [IsoId("_bWxB-dp-Ed-ak6NoX_4Aeg_-60928883")]
    [Description(
        @"The annual interest or dividend income an investment earns, expressed as a percentage of the investment's total value."
    )]
    Annual,

    /// <summary>
    /// The yield of the bond offered on the issue date.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_bW6L4Np-Ed-ak6NoX_4Aeg_-60928728")]
    [Description(@"The yield of the bond offered on the issue date.")]
    AtIssue,

    /// <summary>
    /// The yield of a security calculated by using its book value instead of the current market price. This term is typically used in the US domestic market.
    /// Encoded/decoded by serializers as &quot;BOOK&quot;.
    /// </summary>
    [EnumMember(Value = "BOOK")]
    [IsoId("_bW6L4dp-Ed-ak6NoX_4Aeg_-20701157")]
    [Description(
        @"The yield of a security calculated by using its book value instead of the current market price. This term is typically used in the US domestic market."
    )]
    Book,

    /// <summary>
    /// The yield achieved by substituting a bond&apos;s average maturity for the issue&apos;s final maturity date.
    /// Encoded/decoded by serializers as &quot;AVMA&quot;.
    /// </summary>
    [EnumMember(Value = "AVMA")]
    [IsoId("_bW6L4tp-Ed-ak6NoX_4Aeg_315462865")]
    [Description(
        @"The yield achieved by substituting a bond's average maturity for the issue's final maturity date."
    )]
    ToAverageMaturity,

    /// <summary>
    /// The change in the yield since the previous day&apos;s closing yield.
    /// Encoded/decoded by serializers as &quot;CHCL&quot;.
    /// </summary>
    [EnumMember(Value = "CHCL")]
    [IsoId("_bW6L49p-Ed-ak6NoX_4Aeg_333933404")]
    [Description(@"The change in the yield since the previous day's closing yield.")]
    ChangeSinceClose,

    /// <summary>
    /// The yield of a bond based on the closing price.
    /// Encoded/decoded by serializers as &quot;CLOS&quot;.
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_bW6L5Np-Ed-ak6NoX_4Aeg_523254033")]
    [Description(@"The yield of a bond based on the closing price.")]
    Closing,

    /// <summary>
    /// The yield of certain Japanese bonds based on its price. Certain Japanese bonds have irregular first or last coupons, and the yield is calculated compound for these irregular periods.
    /// Encoded/decoded by serializers as &quot;CMPD&quot;.
    /// </summary>
    [EnumMember(Value = "CMPD")]
    [IsoId("_bW6L5dp-Ed-ak6NoX_4Aeg_523254248")]
    [Description(
        @"The yield of certain Japanese bonds based on its price. Certain Japanese bonds have irregular first or last coupons, and the yield is calculated compound for these irregular periods."
    )]
    Compound,

    /// <summary>
    /// Yield calculated using the price including accrued interest, where coupon dates are moved from holidays and weekends to the next trading day.
    /// Encoded/decoded by serializers as &quot;TRGR&quot;.
    /// </summary>
    [EnumMember(Value = "TRGR")]
    [IsoId("_bW6L5tp-Ed-ak6NoX_4Aeg_747669804")]
    [Description(
        @"Yield calculated using the price including accrued interest, where coupon dates are moved from holidays and weekends to the next trading day."
    )]
    TrueGross,

    /// <summary>
    /// Ask yield based on semi-annual coupons compounding in all periods and actual/actual calendar.
    /// Encoded/decoded by serializers as &quot;GVEQ&quot;.
    /// </summary>
    [EnumMember(Value = "GVEQ")]
    [IsoId("_bW6L59p-Ed-ak6NoX_4Aeg_747670211")]
    [Description(
        @"Ask yield based on semi-annual coupons compounding in all periods and actual/actual calendar."
    )]
    GovernmentEquivalent,

    /// <summary>
    /// Based on price, the return an investor would require on a normal bond that would make the real return equal to that of the inflation-indexed bond, assuming a constant inflation rate.
    /// Encoded/decoded by serializers as &quot;FLAS&quot;.
    /// </summary>
    [EnumMember(Value = "FLAS")]
    [IsoId("_bW6L6Np-Ed-ak6NoX_4Aeg_747670632")]
    [Description(
        @"Based on price, the return an investor would require on a normal bond that would make the real return equal to that of the inflation-indexed bond, assuming a constant inflation rate."
    )]
    InflationAssumption,

    /// <summary>
    /// Inverse Floater Bond Yield - Inverse floater semi-annual bond equivalent rate.
    /// Encoded/decoded by serializers as &quot;NVFL&quot;.
    /// </summary>
    [EnumMember(Value = "NVFL")]
    [IsoId("_bW6L6dp-Ed-ak6NoX_4Aeg_747670769")]
    [Description(@"Inverse Floater Bond Yield - Inverse floater semi-annual bond equivalent rate.")]
    InverseFloater,

    /// <summary>
    /// Most Recent Closing Yield - The last available yield stored in history, computed using price.
    /// Encoded/decoded by serializers as &quot;LSCL&quot;.
    /// </summary>
    [EnumMember(Value = "LSCL")]
    [IsoId("_bXD84Np-Ed-ak6NoX_4Aeg_747670848")]
    [Description(
        @"Most Recent Closing Yield - The last available yield stored in history, computed using price."
    )]
    LastClose,

    /// <summary>
    /// Closing Yield Most Recent Month - The yield of a bond based on the closing price as of the most recent month&apos;s end.
    /// Encoded/decoded by serializers as &quot;LSMT&quot;.
    /// </summary>
    [EnumMember(Value = "LSMT")]
    [IsoId("_bXD84dp-Ed-ak6NoX_4Aeg_747671125")]
    [Description(
        @"Closing Yield Most Recent Month - The yield of a bond based on the closing price as of the most recent month's end."
    )]
    LastMonth,

    /// <summary>
    /// Closing Yield Most Recent Quarter - The yield of a bond based on the closing price as of the most recent quarter&apos;s end.
    /// Encoded/decoded by serializers as &quot;LSQR&quot;.
    /// </summary>
    [EnumMember(Value = "LSQR")]
    [IsoId("_bXD84tp-Ed-ak6NoX_4Aeg_747671202")]
    [Description(
        @"Closing Yield Most Recent Quarter - The yield of a bond based on the closing price as of the most recent quarter's end."
    )]
    LastQuarter,

    /// <summary>
    /// Closing Yield Most Recent Year - The yield of a bond based on the closing price as of the most recent year&apos;s end.
    /// Encoded/decoded by serializers as &quot;LSYR&quot;.
    /// </summary>
    [EnumMember(Value = "LSYR")]
    [IsoId("_bXD849p-Ed-ak6NoX_4Aeg_748591234")]
    [Description(
        @"Closing Yield Most Recent Year - The yield of a bond based on the closing price as of the most recent year's end."
    )]
    LastYear,

    /// <summary>
    /// The yield assuming only mandatory sinks are taken. This results in a lower paydown of debt; the yield is then calculated to the final payment date.
    /// Encoded/decoded by serializers as &quot;LGAL&quot;.
    /// </summary>
    [EnumMember(Value = "LGAL")]
    [IsoId("_bXD85Np-Ed-ak6NoX_4Aeg_-583391276")]
    [Description(
        @"The yield assuming only mandatory sinks are taken. This results in a lower paydown of debt; the yield is then calculated to the final payment date."
    )]
    LongestAverageLife,

    /// <summary>
    /// An adjustment in the valuation of a securities portfolio to reflect the current market values of the respective securities in the portfolio.
    /// Encoded/decoded by serializers as &quot;MARK&quot;.
    /// </summary>
    [EnumMember(Value = "MARK")]
    [IsoId("_bXD85dp-Ed-ak6NoX_4Aeg_-339579654")]
    [Description(
        @"An adjustment in the valuation of a securities portfolio to reflect the current market values of the respective securities in the portfolio."
    )]
    MarkToMarket,

    /// <summary>
    /// Yield To Next Refund (Sinking Fund Bonds) - Yield assuming all bonds are redeemed at the next refund date at the redemption price.
    /// Encoded/decoded by serializers as &quot;NXRF&quot;.
    /// </summary>
    [EnumMember(Value = "NXRF")]
    [IsoId("_bXD85tp-Ed-ak6NoX_4Aeg_-313720664")]
    [Description(
        @"Yield To Next Refund (Sinking Fund Bonds) - Yield assuming all bonds are redeemed at the next refund date at the redemption price."
    )]
    ToNextRefund,

    /// <summary>
    /// The average yield of the respective securities in the portfolio.
    /// Encoded/decoded by serializers as &quot;PNAV&quot;.
    /// </summary>
    [EnumMember(Value = "PNAV")]
    [IsoId("_bXD859p-Ed-ak6NoX_4Aeg_-313720232")]
    [Description(@"The average yield of the respective securities in the portfolio.")]
    OpenAverage,

    /// <summary>
    /// The yield to the date at which the bond holder can next put the bond to the issuer.
    /// Encoded/decoded by serializers as &quot;NXPT&quot;.
    /// </summary>
    [EnumMember(Value = "NXPT")]
    [IsoId("_bXD86Np-Ed-ak6NoX_4Aeg_-312800045")]
    [Description(
        @"The yield to the date at which the bond holder can next put the bond to the issuer."
    )]
    ToNextPut,

    /// <summary>
    /// The yield of a bond based on the closing price 1 day ago.
    /// Encoded/decoded by serializers as &quot;PRCL&quot;.
    /// </summary>
    [EnumMember(Value = "PRCL")]
    [IsoId("_bXD86dp-Ed-ak6NoX_4Aeg_-312799975")]
    [Description(@"The yield of a bond based on the closing price 1 day ago.")]
    PreviousClose,

    /// <summary>
    /// The CD equivalent yield when the remaining time to maturity is less than two years.
    /// Encoded/decoded by serializers as &quot;PRYL&quot;.
    /// </summary>
    [EnumMember(Value = "PRYL")]
    [IsoId("_bXNt4Np-Ed-ak6NoX_4Aeg_-312799890")]
    [Description(
        @"The CD equivalent yield when the remaining time to maturity is less than two years."
    )]
    Proceeds,

    /// <summary>
    /// The yield of a bond whose coupon payments are reinvested semi-annually.
    /// Encoded/decoded by serializers as &quot;SEMI&quot;.
    /// </summary>
    [EnumMember(Value = "SEMI")]
    [IsoId("_bXNt4dp-Ed-ak6NoX_4Aeg_-312799603")]
    [Description(@"The yield of a bond whose coupon payments are reinvested semi-annually.")]
    SemiAnnual,

    /// <summary>
    /// The yield assuming that all sinks (mandatory and voluntary) are taken at par. This results in a faster paydown of debt; the yield is then calculated to the shortest average life date.
    /// Encoded/decoded by serializers as &quot;SHLF&quot;.
    /// </summary>
    [EnumMember(Value = "SHLF")]
    [IsoId("_bXNt4tp-Ed-ak6NoX_4Aeg_-312799518")]
    [Description(
        @"The yield assuming that all sinks (mandatory and voluntary) are taken at par. This results in a faster paydown of debt; the yield is then calculated to the shortest average life date."
    )]
    ShortestAverageLife,

    /// <summary>
    /// The yield of a bond assuming no reinvestment of coupon payments. (Act/360 day count).
    /// Encoded/decoded by serializers as &quot;SPLL&quot;.
    /// </summary>
    [EnumMember(Value = "SPLL")]
    [IsoId("_bXNt49p-Ed-ak6NoX_4Aeg_-297097177")]
    [Description(
        @"The yield of a bond assuming no reinvestment of coupon payments. (Act/360 day count)."
    )]
    Simple,

    /// <summary>
    /// The after tax yield grossed up by the maximum federal tax rate of 39.6%. For comparison to taxable yields.
    /// Encoded/decoded by serializers as &quot;TXQV&quot;.
    /// </summary>
    [EnumMember(Value = "TXQV")]
    [IsoId("_bXNt5Np-Ed-ak6NoX_4Aeg_-296176791")]
    [Description(
        @"The after tax yield grossed up by the maximum federal tax rate of 39.6%. For comparison to taxable yields."
    )]
    TaxEquivalent,

    /// <summary>
    /// The yield on a Municipal bond to its mandatory tender date.
    /// Encoded/decoded by serializers as &quot;TTDT&quot;.
    /// </summary>
    [EnumMember(Value = "TTDT")]
    [IsoId("_bXNt5dp-Ed-ak6NoX_4Aeg_-296176619")]
    [Description(@"The yield on a Municipal bond to its mandatory tender date.")]
    ToTenderDate,

    /// <summary>
    /// The yield calculated with coupon dates moved from a weekend or holiday to the next valid settlement date.
    /// Encoded/decoded by serializers as &quot;TRYL&quot;.
    /// </summary>
    [EnumMember(Value = "TRYL")]
    [IsoId("_bXNt5tp-Ed-ak6NoX_4Aeg_-296176194")]
    [Description(
        @"The yield calculated with coupon dates moved from a weekend or holiday to the next valid settlement date."
    )]
    True,

    /// <summary>
    /// The lowest yield to all possible redemption date scenarios.
    /// Encoded/decoded by serializers as &quot;WRST&quot;.
    /// </summary>
    [EnumMember(Value = "WRST")]
    [IsoId("_bXNt59p-Ed-ak6NoX_4Aeg_-153029049")]
    [Description(@"The lowest yield to all possible redemption date scenarios.")]
    ToWorstConvention,
}
