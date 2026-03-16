// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Device Input Response6.
/// </summary>
[IsoId("_5e1rkZFPEe6reqfAp4CunQ")]
[DisplayName("Device Input Response6")]
public partial record DeviceInputResponse6
{
    #nullable enable

    /// <summary>
    /// Input Result.
    /// </summary>
    [DisplayName("Input Result")]
    [IsoXmlTag("InptRslt")]
    public required InputResult6 InputResult { get; init; } 

    /// <summary>
    /// Output Result.
    /// </summary>
    [DisplayName("Output Result")]
    [IsoXmlTag("OutptRslt")]
    public OutputResult2? OutputResult { get; init; } 

    
    #nullable disable
    
}
