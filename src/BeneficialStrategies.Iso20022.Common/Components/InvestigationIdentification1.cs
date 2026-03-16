// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Investigation Identification1.
/// </summary>
[IsoId("_aEvXIFeyEe6G45fhJISx6Q")]
[DisplayName("Investigation Identification1")]
public record InvestigationIdentification1
{
    /// <summary>
    /// EIR.
    /// </summary>
    [DisplayName("EIR")]
    [IsoXmlTag("EIR")]
    public IsoUUIDv4Identifier? EIR { get; init; }

    /// <summary>
    /// Requestor Investigation Identification.
    /// </summary>
    [DisplayName("Requestor Investigation Identification")]
    [IsoXmlTag("RqstrInvstgtnId")]
    public IsoMax35Text? RequestorInvestigationIdentification { get; init; }

    /// <summary>
    /// Responder Investigation Identification.
    /// </summary>
    [DisplayName("Responder Investigation Identification")]
    [IsoXmlTag("RspndrInvstgtnId")]
    public IsoMax35Text? ResponderInvestigationIdentification { get; init; }
}
