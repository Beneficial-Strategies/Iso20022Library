// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for an active or historic currency and decimal amount.
/// </summary>
[IsoId("_Lm1CIE6nEeyEpI66tm807w")]
[DisplayName("Compare Active Or Historic Currency And Amount")]
public partial record CompareActiveOrHistoricCurrencyAndAmount4
{
    #nullable enable
    
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_XA4DkE6nEeyEpI66tm807w")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? Value1 { get; init; } 
    
    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_aU_fsE6nEeyEpI66tm807w")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? Value2 { get; init; } 
    
    
    #nullable disable
    
}
