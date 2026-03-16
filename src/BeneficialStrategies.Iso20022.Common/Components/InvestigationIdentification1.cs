// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Investigation Identification1.
/// </summary>
[IsoId("_aEvXIFeyEe6G45fhJISx6Q")]
[DisplayName("Investigation Identification1")]
public partial record InvestigationIdentification1
{
    #nullable enable

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

    
    #nullable disable
    
}
