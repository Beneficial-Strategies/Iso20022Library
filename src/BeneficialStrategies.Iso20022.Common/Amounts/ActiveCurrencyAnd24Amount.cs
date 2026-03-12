// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Codesets;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Amounts;

/// <summary>
/// A number of monetary units specified in an active currency where the unit of currency is explicit and compliant with ISO 4217.  It allows up to 24 digits.
/// </summary>
public partial record ActiveCurrencyAnd24Amount
{
    #nullable enable
    
    /// <summary>
    /// The currency in which this amount is measured.
    /// </summary>
    [IsoId("_cuFukzTxEemwtJBLtapBmw_Currency")]
    [DisplayName("Active Currency And 24 Amount _ Currency")]
    [IsoXmlTag("Currency")]
    public required System.String Currency { get; init; } 
    
    /// <summary>
    /// Amount of the transaction.
    /// </summary>
    [IsoId("_cuFukzTxEemwtJBLtapBmw_Amount")]
    [DisplayName("Active Currency And 24 Amount _ Amount")]
    [IsoXmlTag("Amount")]
    public required System.Decimal Amount { get; init; } 
    
    
    #nullable disable
    
}
