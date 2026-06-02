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
[IsoId("_tw_AUbZ_EfCUZfsQO4rYeA")]
[DisplayName("Acquirer Host Configuration11")]
public record AcquirerHostConfiguration11
{
    /// <summary>
    /// Identification of a host.
    /// </summary>
    [IsoId("_tx4_RbZ_EfCUZfsQO4rYeA")]
    [DisplayName("Host Identification")]
    [IsoXmlTag("HstId")]
    public required IsoMax35Text HostIdentification { get; init; }

    /// <summary>
    /// Types of message to sent to this host.
    /// </summary>
    [IsoId("_tx4_S7Z_EfCUZfsQO4rYeA")]
    [DisplayName("Message To Send")]
    [IsoXmlTag("MsgToSnd")]
    public SimpleValueList<MessageFunction47Code> MessageToSend { get; init; } = [];

    /// <summary>
    /// Uniquely identifies the protocol name and version to use when using these parameters.
    /// </summary>
    [IsoId("_tx4_UbZ_EfCUZfsQO4rYeA")]
    [DisplayName("Protocol Version")]
    [IsoXmlTag("PrtcolVrsn")]
    public IsoMax8Text? ProtocolVersion { get; init; }

    /// <summary>
    /// List of types that the receiver supports and that the sender could use as type of an ExternallyDefinedData message component.
    /// </summary>
    [IsoId("_tx4_V7Z_EfCUZfsQO4rYeA")]
    [DisplayName("Externally Type Supported")]
    [IsoXmlTag("XtrnlyTpSpprtd")]
    public SimpleValueList<IsoMax1025Text> ExternallyTypeSupported { get; init; } = [];
}
