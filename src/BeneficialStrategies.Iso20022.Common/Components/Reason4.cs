// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies whether the status is provided with a reason or not.
/// </summary>
[IsoId("_qKKNYeLtEeWOD7aAy2fAcA")]
[DisplayName("Reason")]
public partial record Reason4
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason of the Status.
    /// </summary>
    [IsoId("_qTYa0eLtEeWOD7aAy2fAcA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ProprietaryReason4? Reason { get; init; } 
    
    
    #nullable disable
    
}
