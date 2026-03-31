// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acquirer Host Configuration10.
/// </summary>
[IsoId("_7TgNYZ9tEe-nbM0aSPcoiQ")]
[DisplayName("Acquirer Host Configuration10")]
public record AcquirerHostConfiguration10
{
    /// <summary>
    /// Externally Type Supported.
    /// </summary>
    [DisplayName("Externally Type Supported")]
    [IsoXmlTag("XtrnlyTpSpprtd")]
    public ValueList<IsoMax1025Text> ExternallyTypeSupported { get; init; } = [];

    /// <summary>
    /// Host Identification.
    /// </summary>
    [DisplayName("Host Identification")]
    [IsoXmlTag("HstId")]
    public required IsoMax35Text HostIdentification { get; init; }

    /// <summary>
    /// Message To Send.
    /// </summary>
    [DisplayName("Message To Send")]
    [IsoXmlTag("MsgToSnd")]
    public ValueList<MessageFunction47Code> MessageToSend { get; init; } = [];

    /// <summary>
    /// Protocol Version.
    /// </summary>
    [DisplayName("Protocol Version")]
    [IsoXmlTag("PrtcolVrsn")]
    public IsoMax8Text? ProtocolVersion { get; init; }
}
