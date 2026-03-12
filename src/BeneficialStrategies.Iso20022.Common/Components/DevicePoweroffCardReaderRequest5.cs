// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies what to do during shutdown.
/// </summary>
[IsoId("_MAEhwXGgEe2TbaNWBpRZpQ")]
[DisplayName("Device Poweroff Card Reader Request")]
public partial record DevicePoweroffCardReaderRequest5
{
    #nullable enable
    
    /// <summary>
    /// Maximum time to wait for the request processing in seconds.
    /// </summary>
    [IsoId("_MGTFkXGgEe2TbaNWBpRZpQ")]
    [DisplayName("Power Off Maximum Waiting Time")]
    [IsoXmlTag("PwrOffMaxWtgTm")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? PowerOffMaximumWaitingTime { get; init; } 
    
    /// <summary>
    /// Optional message before Power-Off.
    /// </summary>
    [IsoId("_MGTsoXGgEe2TbaNWBpRZpQ")]
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ActionMessage10? DisplayOutput { get; init; } 
    
    
    #nullable disable
    
}
