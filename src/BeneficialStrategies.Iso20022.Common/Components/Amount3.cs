// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the amount in the reporting currency and optionally in the original currency.
/// </summary>
[IsoId("_9s6WsePHEea7_eMQH225xA")]
[DisplayName("Amount")]
public partial record Amount3
{
    #nullable enable
    
    /// <summary>
    /// Amount expressed in the original currency.
    /// </summary>
    [IsoId("_94OO0ePHEea7_eMQH225xA")]
    [DisplayName("Original Amount")]
    [IsoXmlTag("OrgnlAmt")]
    public ActiveCurrencyAndAmount? OriginalAmount { get; init; } 
    
    /// <summary>
    /// Amount expressed in the reporting currency.
    /// </summary>
    [IsoId("_EAsB4OPIEea7_eMQH225xA")]
    [DisplayName("Reporting Amount")]
    [IsoXmlTag("RptgAmt")]
    public required ActiveCurrencyAndAmount ReportingAmount { get; init; } 
    
    
    #nullable disable
    
}
