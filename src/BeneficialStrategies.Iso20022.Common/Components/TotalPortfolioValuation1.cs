// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Valuation information of the portfolio.
/// </summary>
[IsoId("_m_CFkvNBEeCuA5Tr22BnwA_780606232")]
[DisplayName("Total Portfolio Valuation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TotalPortfolioValuation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TotalPortfolioValuation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TotalPortfolioValuation1( AmountAndDirection30 reqTotalPortfolioValue,AmountAndDirection30 reqTotalBookValue )
    {
        TotalPortfolioValue = reqTotalPortfolioValue;
        TotalBookValue = reqTotalBookValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total value of the portfolio (sum of the assets, liabilities and unrealised gain/loss) calculated according to the accounting rules.
    /// </summary>
    [IsoId("_m_CFk_NBEeCuA5Tr22BnwA_-2081055548")]
    [DisplayName("Total Portfolio Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlPrtflVal")]
    #endif
    [IsoXmlTag("TtlPrtflVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection30 TotalPortfolioValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection30 TotalPortfolioValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection30 TotalPortfolioValue { get; init; } 
    #else
    public AmountAndDirection30 TotalPortfolioValue { get; set; } 
    #endif
    
    /// <summary>
    /// Previous total value of the portfolio.
    /// </summary>
    [IsoId("_m_CFlPNBEeCuA5Tr22BnwA_-1809538819")]
    [DisplayName("Previous Total Portfolio Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsTtlPrtflVal")]
    #endif
    [IsoXmlTag("PrvsTtlPrtflVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection30? PreviousTotalPortfolioValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection30? PreviousTotalPortfolioValue { get; init; } 
    #else
    public AmountAndDirection30? PreviousTotalPortfolioValue { get; set; } 
    #endif
    
    /// <summary>
    /// Difference or change between the previous total portfolio value and the current total portfolio value.
    /// </summary>
    [IsoId("_m_CFlfNBEeCuA5Tr22BnwA_-1783681209")]
    [DisplayName("Total Portfolio Value Change")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlPrtflValChng")]
    #endif
    [IsoXmlTag("TtlPrtflValChng")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndRate2? TotalPortfolioValueChange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndRate2? TotalPortfolioValueChange { get; init; } 
    #else
    public AmountAndRate2? TotalPortfolioValueChange { get; set; } 
    #endif
    
    /// <summary>
    /// Net asset on balance sheet - total portfolio value minus or plus the unrealised gain or loss.
    /// </summary>
    [IsoId("_m_L2kPNBEeCuA5Tr22BnwA_-1605443459")]
    [DisplayName("Total Book Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlBookVal")]
    #endif
    [IsoXmlTag("TtlBookVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection30 TotalBookValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection30 TotalBookValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection30 TotalBookValue { get; init; } 
    #else
    public AmountAndDirection30 TotalBookValue { get; set; } 
    #endif
    
    /// <summary>
    /// Previous net asset on balance sheet.
    /// </summary>
    [IsoId("_m_L2kfNBEeCuA5Tr22BnwA_-1581429193")]
    [DisplayName("Previous Total Book Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsTtlBookVal")]
    #endif
    [IsoXmlTag("PrvsTtlBookVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection30? PreviousTotalBookValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection30? PreviousTotalBookValue { get; init; } 
    #else
    public AmountAndDirection30? PreviousTotalBookValue { get; set; } 
    #endif
    
    /// <summary>
    /// Difference or change between the previous net asset on balance sheet and the current net asset on balance sheet.
    /// </summary>
    [IsoId("_m_L2kvNBEeCuA5Tr22BnwA_-1554647332")]
    [DisplayName("Total Book Value Change")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlBookValChng")]
    #endif
    [IsoXmlTag("TtlBookValChng")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndRate2? TotalBookValueChange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndRate2? TotalBookValueChange { get; init; } 
    #else
    public AmountAndRate2? TotalBookValueChange { get; set; } 
    #endif
    
    /// <summary>
    /// Total receipts attributable to the portfolio.
    /// </summary>
    [IsoId("_m_L2k_NBEeCuA5Tr22BnwA_-1322844654")]
    [DisplayName("Total Receipts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlRcts")]
    #endif
    [IsoXmlTag("TtlRcts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection30? TotalReceipts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection30? TotalReceipts { get; init; } 
    #else
    public AmountAndDirection30? TotalReceipts { get; set; } 
    #endif
    
    /// <summary>
    /// Total disbursements attributable to the portfolio.
    /// </summary>
    [IsoId("_m_L2lPNBEeCuA5Tr22BnwA_-1266509842")]
    [DisplayName("Total Disbursements")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlDsbrsmnts")]
    #endif
    [IsoXmlTag("TtlDsbrsmnts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection30? TotalDisbursements { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection30? TotalDisbursements { get; init; } 
    #else
    public AmountAndDirection30? TotalDisbursements { get; set; } 
    #endif
    
    /// <summary>
    /// Income attributable to the portfolio.
    /// </summary>
    [IsoId("_m_L2lfNBEeCuA5Tr22BnwA_-1232341560")]
    [DisplayName("Income Received")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncmRcvd")]
    #endif
    [IsoXmlTag("IncmRcvd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection30? IncomeReceived { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection30? IncomeReceived { get; init; } 
    #else
    public AmountAndDirection30? IncomeReceived { get; set; } 
    #endif
    
    /// <summary>
    /// Expenses attributable to the portfolio.
    /// </summary>
    [IsoId("_m_L2lvNBEeCuA5Tr22BnwA_-1209251117")]
    [DisplayName("Expenses Paid")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExpnssPd")]
    #endif
    [IsoXmlTag("ExpnssPd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection30? ExpensesPaid { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection30? ExpensesPaid { get; init; } 
    #else
    public AmountAndDirection30? ExpensesPaid { get; set; } 
    #endif
    
    /// <summary>
    /// Difference between the holding value and the book value of the portfolio.
    /// </summary>
    [IsoId("_m_VAgPNBEeCuA5Tr22BnwA_-1129086978")]
    [DisplayName("Unrealised Gain Or Loss")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UrlsdGnOrLoss")]
    #endif
    [IsoXmlTag("UrlsdGnOrLoss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection31? UnrealisedGainOrLoss { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection31? UnrealisedGainOrLoss { get; init; } 
    #else
    public AmountAndDirection31? UnrealisedGainOrLoss { get; set; } 
    #endif
    
    /// <summary>
    /// Difference between the realised value caused by the actual trade/re-evaluation and the book value of the portfolio.
    /// </summary>
    [IsoId("_m_VAgfNBEeCuA5Tr22BnwA_-1917324279")]
    [DisplayName("Realised Gain Or Loss")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RealsdGnOrLoss")]
    #endif
    [IsoXmlTag("RealsdGnOrLoss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection31? RealisedGainOrLoss { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection31? RealisedGainOrLoss { get; init; } 
    #else
    public AmountAndDirection31? RealisedGainOrLoss { get; set; } 
    #endif
    
    /// <summary>
    /// Accrued income.
    /// </summary>
    [IsoId("_m_VAgvNBEeCuA5Tr22BnwA_-887865170")]
    [DisplayName("Accrued Income")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcrdIncm")]
    #endif
    [IsoXmlTag("AcrdIncm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection30? AccruedIncome { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection30? AccruedIncome { get; init; } 
    #else
    public AmountAndDirection30? AccruedIncome { get; set; } 
    #endif
    
    /// <summary>
    /// Valuation information of the investment fund or investment fund share class.
    /// </summary>
    [IsoId("_m_VAg_NBEeCuA5Tr22BnwA_-867400971")]
    [DisplayName("Investment Fund Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtFndDtls")]
    #endif
    [IsoXmlTag("InvstmtFndDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentFund1? InvestmentFundDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentFund1? InvestmentFundDetails { get; init; } 
    #else
    public InvestmentFund1? InvestmentFundDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
