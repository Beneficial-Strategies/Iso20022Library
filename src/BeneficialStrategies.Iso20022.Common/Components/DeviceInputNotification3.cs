// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Input notification message.
/// </summary>
[IsoId("_G2basS9AEeu125Ip9zFcsQ")]
[DisplayName("Device Input Notification")]
public partial record DeviceInputNotification3
{
    #nullable enable
    
    /// <summary>
    /// Message main identifier.
    /// </summary>
    [IsoId("_HC1fAS9AEeu125Ip9zFcsQ")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ExchangeIdentification { get; init; } 
    
    /// <summary>
    /// Updated content of the message to display before input.
    /// </summary>
    [IsoId("_HC1fAy9AEeu125Ip9zFcsQ")]
    [DisplayName("Output Content")]
    [IsoXmlTag("OutptCntt")]
    public required ActionMessage8 OutputContent { get; init; } 
    
    
    #nullable disable
    
}
