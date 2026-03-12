// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specification of the waiving type.
/// </summary>
[IsoId("_VRshKNp-Ed-ak6NoX_4Aeg_978065066")]
[DisplayName("Waiving Type")]
public partial record WaivingType1
{
    #nullable enable
    
    /// <summary>
    /// Structured format.
    /// </summary>
    [IsoId("_VRshKdp-Ed-ak6NoX_4Aeg_1036247835")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public required WaivingInstruction2Code Structured { get; init; } 
    
    /// <summary>
    /// Additional information about the type of waiving.
    /// </summary>
    [IsoId("_VRshKtp-Ed-ak6NoX_4Aeg_1036247853")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
