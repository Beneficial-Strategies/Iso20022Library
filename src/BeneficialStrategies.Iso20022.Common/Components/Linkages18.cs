// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a linked transaction.
/// </summary>
[IsoId("_Adb_Z9okEeC60axPepSq7g_1299396476")]
[DisplayName("Linkages")]
public partial record Linkages18
{
    #nullable enable
    
    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [IsoId("_AdlJUNokEeC60axPepSq7g_1185557410")]
    [DisplayName("Message Number")]
    [IsoXmlTag("MsgNb")]
    public DocumentNumber4Choice_? MessageNumber { get; init; } 
    
    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    [IsoId("_AdlJUdokEeC60axPepSq7g_188485057")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required IdentificationReference11Choice_ Reference { get; init; } 
    
    
    #nullable disable
    
}
