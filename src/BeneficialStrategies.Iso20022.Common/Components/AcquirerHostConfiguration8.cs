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
[IsoId("_GW_GkS_5EeugIJ3Gvoevmg")]
[DisplayName("Acquirer Host Configuration")]
public record AcquirerHostConfiguration8
{
    /// <summary>
    /// Identification of a host.
    /// </summary>
    [IsoId("_GkiaYS_5EeugIJ3Gvoevmg")]
    [DisplayName("Host Identification")]
    [IsoXmlTag("HstId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text HostIdentification { get; init; }

    /// <summary>
    /// Types of message to sent to this host.
    /// </summary>
    [IsoId("_GkiaYy_5EeugIJ3Gvoevmg")]
    [DisplayName("Message To Send")]
    [IsoXmlTag("MsgToSnd")]
    public MessageFunction43Code? MessageToSend { get; init; }

    /// <summary>
    /// Protocol version to use when using these parameters.
    /// </summary>
    [IsoId("_GkiaZS_5EeugIJ3Gvoevmg")]
    [DisplayName("Protocol Version")]
    [IsoXmlTag("PrtcolVrsn")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8, MinimumLength = 1)]
    public IsoMax8Text? ProtocolVersion { get; init; }
}
