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
[IsoId("_gVgvgVFLEeyApZmLzm74zA")]
[DisplayName("Acquirer Host Configuration")]
public record AcquirerHostConfiguration9
{
    /// <summary>
    /// Identification of a host.
    /// </summary>
    [IsoId("_gcAZEVFLEeyApZmLzm74zA")]
    [DisplayName("Host Identification")]
    [IsoXmlTag("HstId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text HostIdentification { get; init; }

    /// <summary>
    /// Types of message to sent to this host.
    /// </summary>
    [IsoId("_gcAZE1FLEeyApZmLzm74zA")]
    [DisplayName("Message To Send")]
    [IsoXmlTag("MsgToSnd")]
    public SimpleValueList<MessageFunction43Code> MessageToSend { get; init; } = [];

    /// <summary>
    /// Protocol version to use when using these parameters.
    /// </summary>
    [IsoId("_gcAZFVFLEeyApZmLzm74zA")]
    [DisplayName("Protocol Version")]
    [IsoXmlTag("PrtcolVrsn")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8, MinimumLength = 1)]
    public IsoMax8Text? ProtocolVersion { get; init; }

    /// <summary>
    /// List of types that the receiver supports and that the sender could use as type of an ExternallyDefinedData message component.
    /// </summary>
    [IsoId("_5Pb2cFFLEeyApZmLzm74zA")]
    [DisplayName("Externally Type Supported")]
    [IsoXmlTag("XtrnlyTpSpprtd")]
    public SimpleValueList<IsoMax1025Text> ExternallyTypeSupported { get; init; } = [];
}
