// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the level of response requested from the receiver of this message.
/// </summary>
[IsoId("_Q78B0dp-Ed-ak6NoX_4Aeg_248528742")]
[DisplayName("Response Level")]
public partial record ResponseLevel
{
    #nullable enable
    
    /// <summary>
    /// Specifies the level of response requested from the receiver of the message.
    /// </summary>
    [IsoXmlTag("RspnLvl")]
    public required ResponseLevel1Code Value { get; init; } 
    
    
    #nullable disable
    
}
