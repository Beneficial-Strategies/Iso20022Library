// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of change to a restriction.
/// </summary>
[IsoId("_OmFkYA4rEeK3IMoVvcTkkg")]
[DisplayName("Restriction Modification")]
public partial record RestrictionModification1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of change.
    /// </summary>
    [IsoId("_XeS7MA4rEeK3IMoVvcTkkg")]
    [DisplayName("Modification Code")]
    [IsoXmlTag("ModCd")]
    public Modification1Code? ModificationCode { get; init; } 
    
    /// <summary>
    /// Restriction.
    /// </summary>
    [IsoId("_bCcXYA4rEeK3IMoVvcTkkg")]
    [DisplayName("Restriction")]
    [IsoXmlTag("Rstrctn")]
    public required Restriction1 Restriction { get; init; } 
    
    
    #nullable disable
    
}
