// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the place of safekeeping expressed as a code and a narrative description.
/// </summary>
[IsoId("_Shax5dp-Ed-ak6NoX_4Aeg_-140824677")]
[DisplayName("Safekeeping Place Type And Text")]
public partial record SafekeepingPlaceTypeAndText1
{
    #nullable enable
    
    /// <summary>
    /// Place of safekeeping as a code.
    /// </summary>
    [IsoId("_Shax5tp-Ed-ak6NoX_4Aeg_-140824659")]
    [DisplayName("Safekeeping Place Type")]
    [IsoXmlTag("SfkpgPlcTp")]
    public required SafekeepingPlace3Code SafekeepingPlaceType { get; init; } 
    
    /// <summary>
    /// Place of safekeeping.
    /// </summary>
    [IsoId("_Shax59p-Ed-ak6NoX_4Aeg_-140824642")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; } 
    
    
    #nullable disable
    
}
