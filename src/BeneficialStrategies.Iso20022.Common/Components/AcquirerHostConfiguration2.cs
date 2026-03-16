// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acquirer configuration parameters for a host.
/// </summary>
[IsoId("_LFhAYCmlEeKIjpr--01h3Q")]
[DisplayName("Acquirer Host Configuration")]
public record AcquirerHostConfiguration2
{
    /// <summary>
    /// Identification of a host.
    /// </summary>
    [IsoId("_LTDtISmlEeKIjpr--01h3Q")]
    [DisplayName("Host Identification")]
    [IsoXmlTag("HstId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text HostIdentification { get; init; }

    /// <summary>
    /// Types of message to sent to this host.
    /// </summary>
    [IsoId("_LTDtJSmlEeKIjpr--01h3Q")]
    [DisplayName("Message To Send")]
    [IsoXmlTag("MsgToSnd")]
    public MessageFunction3Code? MessageToSend { get; init; }
}
