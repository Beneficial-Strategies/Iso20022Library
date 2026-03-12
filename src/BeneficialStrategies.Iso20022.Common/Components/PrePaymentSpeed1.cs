// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type and rate of prepayment speed of the fixed income instrument.
/// </summary>
[IsoId("_S1PFy9p-Ed-ak6NoX_4Aeg_8504632")]
[DisplayName("Pre Payment Speed")]
public partial record PrePaymentSpeed1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of prepayment speed of the fixed income instrument in coded form.
    /// </summary>
    [IsoId("_S1PFzNp-Ed-ak6NoX_4Aeg_48215879")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required PrePaymentSpeed1Code Type { get; init; } 
    
    /// <summary>
    /// Rate of prepayment speed of the fixed income instrument.
    /// </summary>
    [IsoId("_S1PFzdp-Ed-ak6NoX_4Aeg_-1501448660")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate Rate { get; init; } 
    
    
    #nullable disable
    
}
