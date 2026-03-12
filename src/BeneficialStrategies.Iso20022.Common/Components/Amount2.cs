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
[IsoId("_STHQJdp-Ed-ak6NoX_4Aeg_-1176417681")]
[DisplayName("Amount")]
public partial record Amount2
{
    #nullable enable
    
    /// <summary>
    /// Amount expressed in the original currency.
    /// </summary>
    [IsoId("_STHQJtp-Ed-ak6NoX_4Aeg_-1815431520")]
    [DisplayName("Original Currency Amount")]
    [IsoXmlTag("OrgnlCcyAmt")]
    public ActiveCurrencyAndAmount? OriginalCurrencyAmount { get; init; } 
    
    /// <summary>
    /// Amount expressed in the reporting currency.
    /// </summary>
    [IsoId("_STHQJ9p-Ed-ak6NoX_4Aeg_-1708296347")]
    [DisplayName("Reporting Amount")]
    [IsoXmlTag("RptgAmt")]
    public required ImpliedCurrencyAndAmount ReportingAmount { get; init; } 
    
    
    #nullable disable
    
}
