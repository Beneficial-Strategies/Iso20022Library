// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Codesets;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Amounts;

/// <summary>
/// Number of monetary units specified in a currency, where the unit of currency is explicit and compliant with ISO 4217. The decimal separator is a dot.|Note: A zero amount is considered a positive amount.|.
/// </summary>
public partial record CurrencyAnd30Amount
{
    #nullable enable
    
    /// <summary>
    /// The currency in which this amount is measured.
    /// </summary>
    [IsoId("_L8ZcEp0gEeOo48XfssNw8w_Currency")]
    [DisplayName("Currency And 30 Amount _ Currency")]
    [IsoXmlTag("Currency")]
    public required System.String Currency { get; init; } 
    
    /// <summary>
    /// Amount of the transaction.
    /// </summary>
    [IsoId("_L8ZcEp0gEeOo48XfssNw8w_Amount")]
    [DisplayName("Currency And 30 Amount _ Amount")]
    [IsoXmlTag("Amount")]
    public required System.Decimal Amount { get; init; } 
    
    
    #nullable disable
    
}
