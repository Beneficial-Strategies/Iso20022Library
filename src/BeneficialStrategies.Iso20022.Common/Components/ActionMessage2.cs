// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information to display, print or store.
/// </summary>
[IsoId("_xQalMXuYEeSVeNXcmBQ4hQ")]
[DisplayName("Action Message")]
public partial record ActionMessage2
{
    #nullable enable
    
    /// <summary>
    /// Destination of the message.
    /// </summary>
    [IsoId("_xdYDIXuYEeSVeNXcmBQ4hQ")]
    [DisplayName("Message Destination")]
    [IsoXmlTag("MsgDstn")]
    public required UserInterface4Code MessageDestination { get; init; } 
    
    /// <summary>
    /// Message format.
    /// </summary>
    [IsoId("_IC3pUHuZEeSVeNXcmBQ4hQ")]
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    public OutputFormat1Code? Format { get; init; } 
    
    /// <summary>
    /// Content or reference of the message.
    /// </summary>
    [IsoId("_xdYDI3uYEeSVeNXcmBQ4hQ")]
    [DisplayName("Message Content")]
    [IsoXmlTag("MsgCntt")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000 ,MinimumLength = 1)]
    public required IsoMax20000Text MessageContent { get; init; } 
    
    /// <summary>
    /// Digital signature of the message.
    /// </summary>
    [IsoId("_xdYDJXuYEeSVeNXcmBQ4hQ")]
    [DisplayName("Message Content Signature")]
    [IsoXmlTag("MsgCnttSgntr")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? MessageContentSignature { get; init; } 
    
    
    #nullable disable
    
}
