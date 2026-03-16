// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Valuation information of the portfolio.
/// </summary>
[IsoId("_m_CFkvNBEeCuA5Tr22BnwA_780606232")]
[DisplayName("Total Portfolio Valuation")]
public record TotalPortfolioValuation1
{
    /// <summary>
    /// Total value of the portfolio (sum of the assets, liabilities and unrealised gain/loss) calculated according to the accounting rules.
    /// </summary>
    [IsoId("_m_CFk_NBEeCuA5Tr22BnwA_-2081055548")]
    [DisplayName("Total Portfolio Value")]
    [IsoXmlTag("TtlPrtflVal")]
    public required AmountAndDirection30 TotalPortfolioValue { get; init; }

    /// <summary>
    /// Previous total value of the portfolio.
    /// </summary>
    [IsoId("_m_CFlPNBEeCuA5Tr22BnwA_-1809538819")]
    [DisplayName("Previous Total Portfolio Value")]
    [IsoXmlTag("PrvsTtlPrtflVal")]
    public AmountAndDirection30? PreviousTotalPortfolioValue { get; init; }

    /// <summary>
    /// Difference or change between the previous total portfolio value and the current total portfolio value.
    /// </summary>
    [IsoId("_m_CFlfNBEeCuA5Tr22BnwA_-1783681209")]
    [DisplayName("Total Portfolio Value Change")]
    [IsoXmlTag("TtlPrtflValChng")]
    public AmountAndRate2? TotalPortfolioValueChange { get; init; }

    /// <summary>
    /// Net asset on balance sheet - total portfolio value minus or plus the unrealised gain or loss.
    /// </summary>
    [IsoId("_m_L2kPNBEeCuA5Tr22BnwA_-1605443459")]
    [DisplayName("Total Book Value")]
    [IsoXmlTag("TtlBookVal")]
    public required AmountAndDirection30 TotalBookValue { get; init; }

    /// <summary>
    /// Previous net asset on balance sheet.
    /// </summary>
    [IsoId("_m_L2kfNBEeCuA5Tr22BnwA_-1581429193")]
    [DisplayName("Previous Total Book Value")]
    [IsoXmlTag("PrvsTtlBookVal")]
    public AmountAndDirection30? PreviousTotalBookValue { get; init; }

    /// <summary>
    /// Difference or change between the previous net asset on balance sheet and the current net asset on balance sheet.
    /// </summary>
    [IsoId("_m_L2kvNBEeCuA5Tr22BnwA_-1554647332")]
    [DisplayName("Total Book Value Change")]
    [IsoXmlTag("TtlBookValChng")]
    public AmountAndRate2? TotalBookValueChange { get; init; }

    /// <summary>
    /// Total receipts attributable to the portfolio.
    /// </summary>
    [IsoId("_m_L2k_NBEeCuA5Tr22BnwA_-1322844654")]
    [DisplayName("Total Receipts")]
    [IsoXmlTag("TtlRcts")]
    public AmountAndDirection30? TotalReceipts { get; init; }

    /// <summary>
    /// Total disbursements attributable to the portfolio.
    /// </summary>
    [IsoId("_m_L2lPNBEeCuA5Tr22BnwA_-1266509842")]
    [DisplayName("Total Disbursements")]
    [IsoXmlTag("TtlDsbrsmnts")]
    public AmountAndDirection30? TotalDisbursements { get; init; }

    /// <summary>
    /// Income attributable to the portfolio.
    /// </summary>
    [IsoId("_m_L2lfNBEeCuA5Tr22BnwA_-1232341560")]
    [DisplayName("Income Received")]
    [IsoXmlTag("IncmRcvd")]
    public AmountAndDirection30? IncomeReceived { get; init; }

    /// <summary>
    /// Expenses attributable to the portfolio.
    /// </summary>
    [IsoId("_m_L2lvNBEeCuA5Tr22BnwA_-1209251117")]
    [DisplayName("Expenses Paid")]
    [IsoXmlTag("ExpnssPd")]
    public AmountAndDirection30? ExpensesPaid { get; init; }

    /// <summary>
    /// Difference between the holding value and the book value of the portfolio.
    /// </summary>
    [IsoId("_m_VAgPNBEeCuA5Tr22BnwA_-1129086978")]
    [DisplayName("Unrealised Gain Or Loss")]
    [IsoXmlTag("UrlsdGnOrLoss")]
    public AmountAndDirection31? UnrealisedGainOrLoss { get; init; }

    /// <summary>
    /// Difference between the realised value caused by the actual trade/re-evaluation and the book value of the portfolio.
    /// </summary>
    [IsoId("_m_VAgfNBEeCuA5Tr22BnwA_-1917324279")]
    [DisplayName("Realised Gain Or Loss")]
    [IsoXmlTag("RealsdGnOrLoss")]
    public AmountAndDirection31? RealisedGainOrLoss { get; init; }

    /// <summary>
    /// Accrued income.
    /// </summary>
    [IsoId("_m_VAgvNBEeCuA5Tr22BnwA_-887865170")]
    [DisplayName("Accrued Income")]
    [IsoXmlTag("AcrdIncm")]
    public AmountAndDirection30? AccruedIncome { get; init; }

    /// <summary>
    /// Valuation information of the investment fund or investment fund share class.
    /// </summary>
    [IsoId("_m_VAg_NBEeCuA5Tr22BnwA_-867400971")]
    [DisplayName("Investment Fund Details")]
    [IsoXmlTag("InvstmtFndDtls")]
    public InvestmentFund1? InvestmentFundDetails { get; init; }
}
