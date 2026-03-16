// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Income Statement2.
/// </summary>
[IsoId("_ATtogUQUEe-2k_vYsOPbHA")]
[DisplayName("Income Statement2")]
public partial record IncomeStatement2
{
    #nullable enable

    /// <summary>
    /// Clearing Member Fee.
    /// </summary>
    [DisplayName("Clearing Member Fee")]
    [IsoXmlTag("ClrMmbFee")]
    public ValueList<ClearingMemberFee1> ClearingMemberFee { get; init; } = [];

    /// <summary>
    /// Net Interest Income.
    /// </summary>
    [DisplayName("Net Interest Income")]
    [IsoXmlTag("NetIntrstIncm")]
    public required ActiveCurrencyAndAmount NetInterestIncome { get; init; } 

    /// <summary>
    /// Non Operating Expenses.
    /// </summary>
    [DisplayName("Non Operating Expenses")]
    [IsoXmlTag("NonOprgExpnss")]
    public required ActiveCurrencyAndAmount NonOperatingExpenses { get; init; } 

    /// <summary>
    /// Operating Expenses.
    /// </summary>
    [DisplayName("Operating Expenses")]
    [IsoXmlTag("OprgExpnss")]
    public required ActiveCurrencyAndAmount OperatingExpenses { get; init; } 

    /// <summary>
    /// Operating Profit Or Loss.
    /// </summary>
    [DisplayName("Operating Profit Or Loss")]
    [IsoXmlTag("OprgPrftOrLoss")]
    public required AmountAndDirection102 OperatingProfitOrLoss { get; init; } 

    /// <summary>
    /// Other Non Operating Revenue.
    /// </summary>
    [DisplayName("Other Non Operating Revenue")]
    [IsoXmlTag("OthrNonOprgRvn")]
    public required ActiveCurrencyAndAmount OtherNonOperatingRevenue { get; init; } 

    /// <summary>
    /// Other Operating Revenue.
    /// </summary>
    [DisplayName("Other Operating Revenue")]
    [IsoXmlTag("OthrOprgRvn")]
    public required ActiveCurrencyAndAmount OtherOperatingRevenue { get; init; } 

    /// <summary>
    /// Post Tax Profit Or Loss.
    /// </summary>
    [DisplayName("Post Tax Profit Or Loss")]
    [IsoXmlTag("PstTaxPrftOrLoss")]
    public required AmountAndDirection102 PostTaxProfitOrLoss { get; init; } 

    /// <summary>
    /// Pre Tax Profit Or Loss.
    /// </summary>
    [DisplayName("Pre Tax Profit Or Loss")]
    [IsoXmlTag("PreTaxPrftOrLoss")]
    public required AmountAndDirection102 PreTaxProfitOrLoss { get; init; } 

    
    #nullable disable
    
}
