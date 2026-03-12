// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the message that is associated with the activity.
/// </summary>
[IsoId("_RI5fxdp-Ed-ak6NoX_4Aeg_156972015")]
[DisplayName("Activity")]
public partial record Activity1
{
    #nullable enable
    
    /// <summary>
    /// Name of the message associated with the activity.
    /// </summary>
    [IsoId("_RI5fxtp-Ed-ak6NoX_4Aeg_180986461")]
    [DisplayName("Message Name")]
    [IsoXmlTag("MsgNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public required IsoMax70Text MessageName { get; init; } 
    
    /// <summary>
    /// Further information on a message associated with the activity.
    /// </summary>
    [IsoId("_RI5fx9p-Ed-ak6NoX_4Aeg_495904420")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Description { get; init; } 
    
    
    #nullable disable
    
}
