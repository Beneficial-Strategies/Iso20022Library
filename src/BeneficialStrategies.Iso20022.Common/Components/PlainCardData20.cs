// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Sensitive data associated with a payment card.
/// </summary>
[IsoId("_FimQl_iyEeiJaN6-Lf-c_w")]
[DisplayName("Plain Card Data")]
public partial record PlainCardData20
{
    #nullable enable
    
    /// <summary>
    /// Identification of the driver or vehicle.
    /// </summary>
    [IsoId("_FimQnPiyEeiJaN6-Lf-c_w")]
    [DisplayName("Driver Or Vehicle Identification")]
    [IsoXmlTag("DrvrOrVhclId")]
    [IsoSimpleType(IsoSimpleType.Max20Text)]
    [StringLength(maximumLength: 20 ,MinimumLength = 1)]
    public IsoMax20Text? DriverOrVehicleIdentification { get; init; } 
    
    /// <summary>
    /// Additional card specific data.
    /// </summary>
    [IsoId("_FimQmfiyEeiJaN6-Lf-c_w")]
    [DisplayName("Additional Card Data")]
    [IsoXmlTag("AddtlCardData")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AdditionalCardData { get; init; } 
    
    
    #nullable disable
    
}
