// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the return excess cash type and the collateral currency.
/// </summary>
[IsoId("_hAr8AALpEeutW5-TpeYJhA")]
[DisplayName("Return Excess Cash")]
public partial record ReturnExcessCash1
{
    #nullable enable
    
    /// <summary>
    /// Identifies the return excess cash type.
    /// </summary>
    [IsoId("_8whgIALpEeutW5-TpeYJhA")]
    [DisplayName("Return Excess Cash Type")]
    [IsoXmlTag("RtrXcssCshTp")]
    public required ReturnExcessCash1Choice_ ReturnExcessCashType { get; init; } 
    
    /// <summary>
    /// Currency of the cash collateral.
    /// </summary>
    [IsoId("_I7x8EALqEeutW5-TpeYJhA")]
    [DisplayName("Cash Collateral Currency")]
    [IsoXmlTag("CshCollCcy")]
    public required ActiveOrHistoricCurrencyCode CashCollateralCurrency { get; init; } 
    
    
    #nullable disable
    
}
