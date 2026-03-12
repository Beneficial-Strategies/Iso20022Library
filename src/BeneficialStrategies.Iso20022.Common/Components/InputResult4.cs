// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the result the input.
/// </summary>
[IsoId("_PenIAVFEEeyApZmLzm74zA")]
[DisplayName("Input Result")]
public partial record InputResult4
{
    #nullable enable
    
    /// <summary>
    /// Type of Input device.
    /// </summary>
    [IsoId("_Pk258VFEEeyApZmLzm74zA")]
    [DisplayName("Device Type")]
    [IsoXmlTag("DvcTp")]
    public required SaleCapabilities2Code DeviceType { get; init; } 
    
    /// <summary>
    /// Qualifies the type of given information.
    /// </summary>
    [IsoId("_Pk2581FEEeyApZmLzm74zA")]
    [DisplayName("Information Qualifier")]
    [IsoXmlTag("InfQlfr")]
    public required InformationQualify1Code InformationQualifier { get; init; } 
    
    /// <summary>
    /// Data resulting of input after POI or Sale processing.
    /// </summary>
    [IsoId("_Pk259VFEEeyApZmLzm74zA")]
    [DisplayName("Input Result Data")]
    [IsoXmlTag("InptRsltData")]
    public required InputResultData4 InputResultData { get; init; } 
    
    
    #nullable disable
    
}
