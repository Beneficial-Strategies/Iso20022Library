// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the parameters to calculate the local reporting time.
/// </summary>
[IsoId("_RKPjkNp-Ed-ak6NoX_4Aeg_-688976051")]
[DisplayName("UTC Offset")]
public partial record UTCOffset1
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the offset is before or after 00: 00 hour UTC.
    /// </summary>
    [IsoId("_RKPjkdp-Ed-ak6NoX_4Aeg_-597549067")]
    [DisplayName("Sign")]
    [IsoXmlTag("Sgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    public required IsoPlusOrMinusIndicator Sign { get; init; } 
    
    /// <summary>
    /// Offset of the reporting time, in hours, before or after 00: 00 hour UTC.
    /// </summary>
    [IsoId("_RKPjktp-Ed-ak6NoX_4Aeg_-316800485")]
    [DisplayName("Number Of Hours")]
    [IsoXmlTag("NbOfHrs")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public required IsoISOTime NumberOfHours { get; init; } 
    
    
    #nullable disable
    
}
