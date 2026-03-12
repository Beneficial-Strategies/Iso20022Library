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
[IsoId("_IC8OJA0zEeuJ1fOEB4bQXA")]
[DisplayName("Schedule")]
public partial record Schedule1
{
    #nullable enable
    
    /// <summary>
    /// Indicates the unadjusted date at which obligations under the  derivative transaction come into effect, as included in the confirmation.
    /// </summary>
    [IsoId("_IC8OJQ0zEeuJ1fOEB4bQXA")]
    [DisplayName("Unadjusted Effective Date")]
    [IsoXmlTag("UadjstdFctvDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate UnadjustedEffectiveDate { get; init; } 
    
    /// <summary>
    /// Indicates the end date agreed in the derivative transaction without adjustment.
    /// </summary>
    [IsoId("_IC8OJg0zEeuJ1fOEB4bQXA")]
    [DisplayName("Unadjusted End Date")]
    [IsoXmlTag("UadjstdEndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? UnadjustedEndDate { get; init; } 
    
    /// <summary>
    /// Indicates the price per derivative excluding, where applicable: fees, taxes or commissions.
    /// </summary>
    [IsoId("_IC8OJw0zEeuJ1fOEB4bQXA")]
    [DisplayName("Price")]
    [IsoXmlTag("Pric")]
    public required SecuritiesTransactionPrice17Choice_ Price { get; init; } 
    
    
    #nullable disable
    
}
