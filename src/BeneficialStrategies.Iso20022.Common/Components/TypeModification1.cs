// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of modification to account type.
/// </summary>
[IsoId("_LajR8A4qEeK3IMoVvcTkkg")]
[DisplayName("Type Modification")]
public partial record TypeModification1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of change.
    /// </summary>
    [IsoId("_USUj4A4qEeK3IMoVvcTkkg")]
    [DisplayName("Modification Code")]
    [IsoXmlTag("ModCd")]
    public Modification1Code? ModificationCode { get; init; } 
    
    /// <summary>
    /// Type of the account.
    /// </summary>
    [IsoId("_Z399wA4qEeK3IMoVvcTkkg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CashAccountType2Choice_ Type { get; init; } 
    
    
    #nullable disable
    
}
