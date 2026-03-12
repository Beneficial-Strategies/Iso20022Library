// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the content of the input notification message.
/// </summary>
[IsoId("_-Ho84XGgEe2TbaNWBpRZpQ")]
[DisplayName("Device Input Notification")]
public partial record DeviceInputNotification5
{
    #nullable enable
    
    /// <summary>
    /// Message main identifier.
    /// </summary>
    [IsoId("_-Oa6UXGgEe2TbaNWBpRZpQ")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ExchangeIdentification { get; init; } 
    
    /// <summary>
    /// Updated content of the message to display before input.
    /// </summary>
    [IsoId("_-Oa6U3GgEe2TbaNWBpRZpQ")]
    [DisplayName("Output Content")]
    [IsoXmlTag("OutptCntt")]
    public required ActionMessage10 OutputContent { get; init; } 
    
    
    #nullable disable
    
}
