// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Exemption2.
/// </summary>
[IsoId("_PMDhAZqHEe6bZt44gtg6XQ")]
[DisplayName("Exemption2")]
public partial record Exemption2
{
    #nullable enable

    /// <summary>
    /// Reason Not Honored.
    /// </summary>
    [DisplayName("Reason Not Honored")]
    [IsoXmlTag("RsnNotHnrd")]
    public ValueList<IsoMax4Text> ReasonNotHonored { get; init; } = [];

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required Exemption2Code Type { get; init; } 

    /// <summary>
    /// Value.
    /// </summary>
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required AttestationValue1Code Value { get; init; } 

    
    #nullable disable
    
}
