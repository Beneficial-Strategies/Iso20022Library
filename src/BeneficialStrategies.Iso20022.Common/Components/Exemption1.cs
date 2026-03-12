// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Strong Customer Authentication exemption details.
/// </summary>
[IsoId("_7zGJkAMgEeujMs2LsB3mMw")]
[DisplayName("Exemption")]
public partial record Exemption1
{
    #nullable enable
    
    /// <summary>
    /// Type of the exemption.
    /// </summary>
    [IsoId("_RTwOoAMhEeujMs2LsB3mMw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required Exemption2Code Type { get; init; } 
    
    /// <summary>
    /// Status of the exemption.
    /// </summary>
    [IsoId("_XEEAYAMhEeujMs2LsB3mMw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required AttestationValue1Code Value { get; init; } 
    
    /// <summary>
    /// Reason why the exemption claimed was not honored.
    /// </summary>
    [IsoId("_fNKOcAMhEeujMs2LsB3mMw")]
    [DisplayName("Reason Not Honored")]
    [IsoXmlTag("RsnNotHnrd")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public IsoMax4Text? ReasonNotHonored { get; init; } 
    
    
    #nullable disable
    
}
