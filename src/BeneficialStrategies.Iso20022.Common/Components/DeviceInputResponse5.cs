// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the input response message.
/// </summary>
[IsoId("_M-bRUXGpEe2TbaNWBpRZpQ")]
[DisplayName("Device Input Response")]
public partial record DeviceInputResponse5
{
    #nullable enable
    
    /// <summary>
    /// Result of display request.
    /// </summary>
    [IsoId("_NErDQXGpEe2TbaNWBpRZpQ")]
    [DisplayName("Output Result")]
    [IsoXmlTag("OutptRslt")]
    public OutputResult2? OutputResult { get; init; } 
    
    /// <summary>
    /// Result of input request.
    /// </summary>
    [IsoId("_NErDQ3GpEe2TbaNWBpRZpQ")]
    [DisplayName("Input Result")]
    [IsoXmlTag("InptRslt")]
    public required InputResult5 InputResult { get; init; } 
    
    
    #nullable disable
    
}
