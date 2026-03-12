// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Power-Off Card Reader Request message.
/// </summary>
[IsoId("_Kuev8VE7EeyApZmLzm74zA")]
[DisplayName("Device Poweroff Card Reader Request")]
public partial record DevicePoweroffCardReaderRequest4
{
    #nullable enable
    
    /// <summary>
    /// Maximum time to wait for the request processing in seconds.
    /// </summary>
    [IsoId("_K0vI8VE7EeyApZmLzm74zA")]
    [DisplayName("Power Off Maximum Waiting Time")]
    [IsoXmlTag("PwrOffMaxWtgTm")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? PowerOffMaximumWaitingTime { get; init; } 
    
    /// <summary>
    /// Optional message before Power-Off.
    /// </summary>
    [IsoId("_K0vI81E7EeyApZmLzm74zA")]
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ActionMessage9? DisplayOutput { get; init; } 
    
    
    #nullable disable
    
}
