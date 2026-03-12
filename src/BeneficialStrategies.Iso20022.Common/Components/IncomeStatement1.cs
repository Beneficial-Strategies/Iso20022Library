// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Statement of the financial performance of a legal entity.
/// </summary>
[IsoId("_l_mSELIdEeaYqc4G3TTwhA")]
[DisplayName("Income Statement")]
public partial record IncomeStatement1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the clearing fees recorded in month-end management reporting for the financial year-to-date.
    /// </summary>
    [IsoId("_tu0AgLIdEeaYqc4G3TTwhA")]
    [DisplayName("Clearing Fees")]
    [IsoXmlTag("ClrFees")]
    public required ActiveCurrencyAndAmount ClearingFees { get; init; } 
    
    /// <summary>
    /// Other operating revenue recorded in month-end management reporting for the financial year-to-date.
    /// </summary>
    [IsoId("_ykHikLIdEeaYqc4G3TTwhA")]
    [DisplayName("Other Operating Revenue")]
    [IsoXmlTag("OthrOprgRvn")]
    public required ActiveCurrencyAndAmount OtherOperatingRevenue { get; init; } 
    
    /// <summary>
    /// Operating expenses recorded in month-end management reporting for the financial year-to-date.
    /// </summary>
    [IsoId("_1uvrgLIdEeaYqc4G3TTwhA")]
    [DisplayName("Operating Expenses")]
    [IsoXmlTag("OprgExpnss")]
    public required ActiveCurrencyAndAmount OperatingExpenses { get; init; } 
    
    /// <summary>
    /// Indicates the operating profit (true) or loss (false) recorded in the month-end management reporting for the financial year-to-date.
    /// </summary>
    [IsoId("_-xeQQLIdEeaYqc4G3TTwhA")]
    [DisplayName("Operating Profit Or Loss")]
    [IsoXmlTag("OprgPrftOrLoss")]
    public required AmountAndDirection102 OperatingProfitOrLoss { get; init; } 
    
    /// <summary>
    /// Net interest income recorded in month-end management reporting for the financial year-to-date.
    /// </summary>
    [IsoId("_stmlsLIeEeaYqc4G3TTwhA")]
    [DisplayName("Net Interest Income")]
    [IsoXmlTag("NetIntrstIncm")]
    public required ActiveCurrencyAndAmount NetInterestIncome { get; init; } 
    
    /// <summary>
    /// Other non-operating revenue recorded in month-end management reporting for the financial year-to-date.
    /// </summary>
    [IsoId("_491BMLIeEeaYqc4G3TTwhA")]
    [DisplayName("Other Non Operating Revenue")]
    [IsoXmlTag("OthrNonOprgRvn")]
    public required ActiveCurrencyAndAmount OtherNonOperatingRevenue { get; init; } 
    
    /// <summary>
    /// Non-operating expenses recorded in month-end management reporting for the financial year-to-date.
    /// </summary>
    [IsoId("_9nWxELIeEeaYqc4G3TTwhA")]
    [DisplayName("Non Operating Expenses")]
    [IsoXmlTag("NonOprgExpnss")]
    public required ActiveCurrencyAndAmount NonOperatingExpenses { get; init; } 
    
    /// <summary>
    /// Indicates the pre-tax profit (true) or loss (false) recorded in month-end management reporting for the financial year-to-date.
    /// </summary>
    [IsoId("_csW6MLIfEeaYqc4G3TTwhA")]
    [DisplayName("Pre Tax Profit Or Loss")]
    [IsoXmlTag("PreTaxPrftOrLoss")]
    public required AmountAndDirection102 PreTaxProfitOrLoss { get; init; } 
    
    /// <summary>
    /// Indicates the post-tax profit (true) or loss (false) recorded in month-end management reporting for the financial year-to-date.
    /// </summary>
    [IsoId("_gcNQELIfEeaYqc4G3TTwhA")]
    [DisplayName("Post Tax Profit Or Loss")]
    [IsoXmlTag("PstTaxPrftOrLoss")]
    public required AmountAndDirection102 PostTaxProfitOrLoss { get; init; } 
    
    
    #nullable disable
    
}
