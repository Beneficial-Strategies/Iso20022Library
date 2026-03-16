// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Device Input Notification6.
/// </summary>
[IsoId("_24CPMZCQEe6zroekBXoFoQ")]
[DisplayName("Device Input Notification6")]
public partial record DeviceInputNotification6
{
    #nullable enable

    /// <summary>
    /// Exchange Identification.
    /// </summary>
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    public required IsoMax35Text ExchangeIdentification { get; init; } 

    /// <summary>
    /// Output Content.
    /// </summary>
    [DisplayName("Output Content")]
    [IsoXmlTag("OutptCntt")]
    public required ActionMessage11 OutputContent { get; init; } 

    
    #nullable disable
    
}
