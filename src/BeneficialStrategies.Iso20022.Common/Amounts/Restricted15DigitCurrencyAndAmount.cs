// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Codesets;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Amounts;

/// <summary>
/// Number of monetary units specified in a currency, where the unit of currency is explicit and compliant with ISO 4217. The maximum number of digits must not exceed 15, including a maximum of 5 fractional digits.
/// </summary>
public partial record Restricted15DigitCurrencyAndAmount
{
    #nullable enable
    
    /// <summary>
    /// The currency in which this amount is measured.
    /// </summary>
    [IsoId("_hldkIFmsEea0TrLY-ZieOg_Currency")]
    [DisplayName("Restricted 15 Digit Currency And Amount _ Currency")]
    [IsoXmlTag("Currency")]
    public required System.String Currency { get; init; } 
    
    /// <summary>
    /// Amount of the transaction.
    /// </summary>
    [IsoId("_hldkIFmsEea0TrLY-ZieOg_Amount")]
    [DisplayName("Restricted 15 Digit Currency And Amount _ Amount")]
    [IsoXmlTag("Amount")]
    public required System.Decimal Amount { get; init; } 
    
    
    #nullable disable
    
}
