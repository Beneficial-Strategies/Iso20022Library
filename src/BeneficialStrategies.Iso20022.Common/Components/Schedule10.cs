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
[IsoId("_2HVpgSJDEe2zWP9pqvmqdw")]
[DisplayName("Schedule")]
public partial record Schedule10
{
    #nullable enable
    
    /// <summary>
    /// Number of units of the financial instrument, that is, the nominal value.
    /// </summary>
    [IsoId("_-ZlMgSJDEe2zWP9pqvmqdw")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    [IsoSimpleType(IsoSimpleType.LongFraction19DecimalNumber)]
    public required IsoLongFraction19DecimalNumber Quantity { get; init; } 
    
    /// <summary>
    /// Indicates the unit of measure in which the total notional quantity and notional quantity schedules are expressed.
    /// </summary>
    [IsoId("_Cw9ccSJEEe2zWP9pqvmqdw")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public UnitOfMeasure8Choice_? UnitOfMeasure { get; init; } 
    
    /// <summary>
    /// Indicates the unadjusted date at which obligations under the  derivative transaction come into effect, as included in the confirmation.
    /// </summary>
    [IsoId("_2INzQSJDEe2zWP9pqvmqdw")]
    [DisplayName("Unadjusted Effective Date")]
    [IsoXmlTag("UadjstdFctvDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate UnadjustedEffectiveDate { get; init; } 
    
    /// <summary>
    /// Indicates the end date agreed in the derivative transaction without adjustment.
    /// </summary>
    [IsoId("_2INzQyJDEe2zWP9pqvmqdw")]
    [DisplayName("Unadjusted End Date")]
    [IsoXmlTag("UadjstdEndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? UnadjustedEndDate { get; init; } 
    
    
    #nullable disable
    
}
