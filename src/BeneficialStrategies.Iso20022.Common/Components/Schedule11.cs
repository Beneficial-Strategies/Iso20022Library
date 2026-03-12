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
[IsoId("_6XkwkT3XEe2uHKhHp3bXyA")]
[DisplayName("Schedule")]
public partial record Schedule11
{
    #nullable enable
    
    /// <summary>
    /// Indicates the unadjusted date at which obligations under the  derivative transaction come into effect, as included in the confirmation.
    /// </summary>
    [IsoId("_6YpHkT3XEe2uHKhHp3bXyA")]
    [DisplayName("Unadjusted Effective Date")]
    [IsoXmlTag("UadjstdFctvDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate UnadjustedEffectiveDate { get; init; } 
    
    /// <summary>
    /// Indicates the end date agreed in the derivative transaction without adjustment.
    /// </summary>
    [IsoId("_6YpHkz3XEe2uHKhHp3bXyA")]
    [DisplayName("Unadjusted End Date")]
    [IsoXmlTag("UadjstdEndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? UnadjustedEndDate { get; init; } 
    
    /// <summary>
    /// Indicates the price per derivative excluding, where applicable, commission and accrued interest.
    /// </summary>
    [IsoId("_6YpHlT3XEe2uHKhHp3bXyA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required AmountAndDirection106 Amount { get; init; } 
    
    
    #nullable disable
    
}
