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
/// Statement of the financial performance of a legal entity.
/// </summary>
[IsoId("_l_mSELIdEeaYqc4G3TTwhA")]
[DisplayName("Income Statement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IncomeStatement1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IncomeStatement1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IncomeStatement1( ActiveCurrencyAndAmount reqClearingFees,ActiveCurrencyAndAmount reqOtherOperatingRevenue,ActiveCurrencyAndAmount reqOperatingExpenses,AmountAndDirection102 reqOperatingProfitOrLoss,ActiveCurrencyAndAmount reqNetInterestIncome,ActiveCurrencyAndAmount reqOtherNonOperatingRevenue,ActiveCurrencyAndAmount reqNonOperatingExpenses,AmountAndDirection102 reqPreTaxProfitOrLoss,AmountAndDirection102 reqPostTaxProfitOrLoss )
    {
        ClearingFees = reqClearingFees;
        OtherOperatingRevenue = reqOtherOperatingRevenue;
        OperatingExpenses = reqOperatingExpenses;
        OperatingProfitOrLoss = reqOperatingProfitOrLoss;
        NetInterestIncome = reqNetInterestIncome;
        OtherNonOperatingRevenue = reqOtherNonOperatingRevenue;
        NonOperatingExpenses = reqNonOperatingExpenses;
        PreTaxProfitOrLoss = reqPreTaxProfitOrLoss;
        PostTaxProfitOrLoss = reqPostTaxProfitOrLoss;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the clearing fees recorded in month-end management reporting for the financial year-to-date.
    /// </summary>
    [IsoId("_tu0AgLIdEeaYqc4G3TTwhA")]
    [DisplayName("Clearing Fees")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrFees")]
    #endif
    [IsoXmlTag("ClrFees")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount ClearingFees { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount ClearingFees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount ClearingFees { get; init; } 
    #else
    public ActiveCurrencyAndAmount ClearingFees { get; set; } 
    #endif
    
    /// <summary>
    /// Other operating revenue recorded in month-end management reporting for the financial year-to-date.
    /// </summary>
    [IsoId("_ykHikLIdEeaYqc4G3TTwhA")]
    [DisplayName("Other Operating Revenue")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrOprgRvn")]
    #endif
    [IsoXmlTag("OthrOprgRvn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount OtherOperatingRevenue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount OtherOperatingRevenue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount OtherOperatingRevenue { get; init; } 
    #else
    public ActiveCurrencyAndAmount OtherOperatingRevenue { get; set; } 
    #endif
    
    /// <summary>
    /// Operating expenses recorded in month-end management reporting for the financial year-to-date.
    /// </summary>
    [IsoId("_1uvrgLIdEeaYqc4G3TTwhA")]
    [DisplayName("Operating Expenses")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OprgExpnss")]
    #endif
    [IsoXmlTag("OprgExpnss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount OperatingExpenses { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount OperatingExpenses { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount OperatingExpenses { get; init; } 
    #else
    public ActiveCurrencyAndAmount OperatingExpenses { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the operating profit (true) or loss (false) recorded in the month-end management reporting for the financial year-to-date.
    /// </summary>
    [IsoId("_-xeQQLIdEeaYqc4G3TTwhA")]
    [DisplayName("Operating Profit Or Loss")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OprgPrftOrLoss")]
    #endif
    [IsoXmlTag("OprgPrftOrLoss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection102 OperatingProfitOrLoss { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection102 OperatingProfitOrLoss { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection102 OperatingProfitOrLoss { get; init; } 
    #else
    public AmountAndDirection102 OperatingProfitOrLoss { get; set; } 
    #endif
    
    /// <summary>
    /// Net interest income recorded in month-end management reporting for the financial year-to-date.
    /// </summary>
    [IsoId("_stmlsLIeEeaYqc4G3TTwhA")]
    [DisplayName("Net Interest Income")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetIntrstIncm")]
    #endif
    [IsoXmlTag("NetIntrstIncm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount NetInterestIncome { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount NetInterestIncome { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount NetInterestIncome { get; init; } 
    #else
    public ActiveCurrencyAndAmount NetInterestIncome { get; set; } 
    #endif
    
    /// <summary>
    /// Other non-operating revenue recorded in month-end management reporting for the financial year-to-date.
    /// </summary>
    [IsoId("_491BMLIeEeaYqc4G3TTwhA")]
    [DisplayName("Other Non Operating Revenue")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrNonOprgRvn")]
    #endif
    [IsoXmlTag("OthrNonOprgRvn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount OtherNonOperatingRevenue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount OtherNonOperatingRevenue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount OtherNonOperatingRevenue { get; init; } 
    #else
    public ActiveCurrencyAndAmount OtherNonOperatingRevenue { get; set; } 
    #endif
    
    /// <summary>
    /// Non-operating expenses recorded in month-end management reporting for the financial year-to-date.
    /// </summary>
    [IsoId("_9nWxELIeEeaYqc4G3TTwhA")]
    [DisplayName("Non Operating Expenses")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonOprgExpnss")]
    #endif
    [IsoXmlTag("NonOprgExpnss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount NonOperatingExpenses { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount NonOperatingExpenses { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount NonOperatingExpenses { get; init; } 
    #else
    public ActiveCurrencyAndAmount NonOperatingExpenses { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the pre-tax profit (true) or loss (false) recorded in month-end management reporting for the financial year-to-date.
    /// </summary>
    [IsoId("_csW6MLIfEeaYqc4G3TTwhA")]
    [DisplayName("Pre Tax Profit Or Loss")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PreTaxPrftOrLoss")]
    #endif
    [IsoXmlTag("PreTaxPrftOrLoss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection102 PreTaxProfitOrLoss { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection102 PreTaxProfitOrLoss { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection102 PreTaxProfitOrLoss { get; init; } 
    #else
    public AmountAndDirection102 PreTaxProfitOrLoss { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the post-tax profit (true) or loss (false) recorded in month-end management reporting for the financial year-to-date.
    /// </summary>
    [IsoId("_gcNQELIfEeaYqc4G3TTwhA")]
    [DisplayName("Post Tax Profit Or Loss")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstTaxPrftOrLoss")]
    #endif
    [IsoXmlTag("PstTaxPrftOrLoss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection102 PostTaxProfitOrLoss { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection102 PostTaxProfitOrLoss { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection102 PostTaxProfitOrLoss { get; init; } 
    #else
    public AmountAndDirection102 PostTaxProfitOrLoss { get; set; } 
    #endif
    
    
    #nullable disable
    
}
