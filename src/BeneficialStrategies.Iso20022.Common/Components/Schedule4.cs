// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the unadjusted effective and end date of the schedule.
/// </summary>
[IsoId("_HC008A0zEeuJ1fOEB4bQXA")]
[DisplayName("Schedule")]
public partial record Schedule4
{
    #nullable enable
    
    /// <summary>
    /// Indicates the unadjusted date at which obligations under the  derivative transaction come into effect, as included in the confirmation.
    /// </summary>
    [IsoId("_HC008w0zEeuJ1fOEB4bQXA")]
    [DisplayName("Unadjusted Effective Date")]
    [IsoXmlTag("UadjstdFctvDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate UnadjustedEffectiveDate { get; init; } 
    
    /// <summary>
    /// Indicates the end date agreed in the derivative transaction without adjustment.
    /// </summary>
    [IsoId("_HC008g0zEeuJ1fOEB4bQXA")]
    [DisplayName("Unadjusted End Date")]
    [IsoXmlTag("UadjstdEndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? UnadjustedEndDate { get; init; } 
    
    /// <summary>
    /// Specifies the predetermined price at which the owner of the option can buy or sell the underlying instrument.
    /// Usage: For foreign exchange options, specifies the exchange rate at which the option can be exercised as the rate of exchange from converting the unit currency into the quoted currency.
    /// For volatility and variance swaps, specify the volatility strike price.
    /// </summary>
    [IsoId("_HC008Q0zEeuJ1fOEB4bQXA")]
    [DisplayName("Price")]
    [IsoXmlTag("Pric")]
    public required SecuritiesTransactionPrice17Choice_ Price { get; init; } 
    
    
    #nullable disable
    
}
