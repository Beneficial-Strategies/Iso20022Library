// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Signed amount in a given numeric currency
/// </summary>
[IsoId("_X3LzYZJQEeuuktRxxQZoNQ")]
[DisplayName("Amount")]
public partial record Amount16
{
    #nullable enable
    
    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_X9M70ZJQEeuuktRxxQZoNQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Sign of the amount.
    /// </summary>
    [IsoId("_X9M705JQEeuuktRxxQZoNQ")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; } 
    
    
    #nullable disable
    
}
