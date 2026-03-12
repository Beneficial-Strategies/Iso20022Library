// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Input Request message.
/// </summary>
[IsoId("_A_2dEN6mEeiwsev40qZGEQ")]
[DisplayName("Device Input Request")]
public partial record DeviceInputRequest1
{
    #nullable enable
    
    /// <summary>
    /// Information to display before input.
    /// </summary>
    [IsoId("_HU_aMN6mEeiwsev40qZGEQ")]
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ActionMessage6? DisplayOutput { get; init; } 
    
    /// <summary>
    /// Information related to an Input request.
    /// </summary>
    [IsoId("_JwLDMN6mEeiwsev40qZGEQ")]
    [DisplayName("Input Data")]
    [IsoXmlTag("InptData")]
    public required InputData1 InputData { get; init; } 
    
    
    #nullable disable
    
}
