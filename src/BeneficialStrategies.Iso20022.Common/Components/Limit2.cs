// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the minimum value of entries to be reported in the requested message.
/// </summary>
[IsoId("_SZgzG9p-Ed-ak6NoX_4Aeg_-701424478")]
[DisplayName("Limit")]
public partial record Limit2
{
    #nullable enable
    
    /// <summary>
    /// Minimum transaction amount to be reported in the requested message.
    /// </summary>
    [IsoId("_SZgzHNp-Ed-ak6NoX_4Aeg_-701424476")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Indicates whether the floor limit applies to credit, to debit or to both credit and debit entries.
    /// </summary>
    [IsoId("_SZqkENp-Ed-ak6NoX_4Aeg_-701424195")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required FloorLimitType1Code CreditDebitIndicator { get; init; } 
    
    
    #nullable disable
    
}
