// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the type of margin amounts.
/// </summary>
[IsoId("_-aesraMOEeCojJW5vEuTEQ_-272677709")]
[DisplayName("Margin")]
public partial record Margin4
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of margin that is calculated.
    /// </summary>
    [IsoId("_-aesrqMOEeCojJW5vEuTEQ_-348030546")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required MarginType1Choice_ Type { get; init; } 
    
    /// <summary>
    /// Provides the margin amount in the reporting currency and optionally in the original currency.
    /// </summary>
    [IsoId("_-an2kKMOEeCojJW5vEuTEQ_-1400894984")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required Amount2 Amount { get; init; } 
    
    /// <summary>
    /// Specifies whether the margin type position is short or long, that is, whether the balance is a negative or positive balance.
    /// </summary>
    [IsoId("_-an2kaMOEeCojJW5vEuTEQ_-675379499")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    
    
    #nullable disable
    
}
