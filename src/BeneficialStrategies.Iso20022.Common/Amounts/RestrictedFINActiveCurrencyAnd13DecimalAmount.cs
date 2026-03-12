// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Codesets;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Amounts;

/// <summary>
/// A number of monetary units specified in an active currency where the unit of currency is explicit and compliant with ISO 4217. The number of fractional digits (or minor unit of currency) is not checked as per ISO 4217: It must be lesser than or equal to 13.|Note: The decimal separator is a dot.
/// </summary>
public partial record RestrictedFINActiveCurrencyAnd13DecimalAmount
{
    #nullable enable
    
    /// <summary>
    /// The currency in which this amount is measured.
    /// </summary>
    [IsoId("_WN5Dptp-Ed-ak6NoX_4Aeg_-154812387_Currency")]
    [DisplayName("Restricted FIN Active Currency And 13 Decimal Amount _ Currency")]
    [IsoXmlTag("Currency")]
    public required System.String Currency { get; init; } 
    
    /// <summary>
    /// Amount of the transaction.
    /// </summary>
    [IsoId("_WN5Dptp-Ed-ak6NoX_4Aeg_-154812387_Amount")]
    [DisplayName("Restricted FIN Active Currency And 13 Decimal Amount _ Amount")]
    [IsoXmlTag("Amount")]
    public required System.Decimal Amount { get; init; } 
    
    
    #nullable disable
    
}
