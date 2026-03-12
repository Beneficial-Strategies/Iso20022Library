// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Display Response message.
/// </summary>
[IsoId("_qaFZAN7EEeiwsev40qZGEQ")]
[DisplayName("Device Display Response")]
public partial record DeviceDisplayResponse1
{
    #nullable enable
    
    /// <summary>
    /// Give result for display request.
    /// </summary>
    [IsoId("_2U-dsN7EEeiwsev40qZGEQ")]
    [DisplayName("Output Result")]
    [IsoXmlTag("OutptRslt")]
    public ValueList<OutputResult1> OutputResult { get; init; } = new ValueList<OutputResult1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _2U-dsN7EEeiwsev40qZGEQ
    
    
    #nullable disable
    
}
