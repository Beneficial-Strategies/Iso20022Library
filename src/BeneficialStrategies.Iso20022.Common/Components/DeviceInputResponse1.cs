// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Input Response message.
/// </summary>
[IsoId("_h0YSAN7FEeiwsev40qZGEQ")]
[DisplayName("Device Input Response")]
public partial record DeviceInputResponse1
{
    #nullable enable
    
    /// <summary>
    /// Result of display request.
    /// </summary>
    [IsoId("_obTisN7FEeiwsev40qZGEQ")]
    [DisplayName("Output Result")]
    [IsoXmlTag("OutptRslt")]
    public OutputResult1? OutputResult { get; init; } 
    
    /// <summary>
    /// Result of input request.
    /// </summary>
    [IsoId("_rXUA0N7FEeiwsev40qZGEQ")]
    [DisplayName("Input Result")]
    [IsoXmlTag("InptRslt")]
    public required InputResult1 InputResult { get; init; } 
    
    
    #nullable disable
    
}
