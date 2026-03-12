// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains detailed information from the cancellation response (for example an MT 196 or an MT 199).
/// </summary>
[IsoId("_SYKDoCFfEeicwehH70nfgw")]
[DisplayName("Cancellation Response")]
public partial record CancellationResponse1
{
    #nullable enable
    
    /// <summary>
    /// Provides the status of the execution of an investigation.
    /// </summary>
    [IsoId("_hxLcECFfEeicwehH70nfgw")]
    [DisplayName("Investigation Execution Status")]
    [IsoXmlTag("InvstgtnExctnSts")]
    public required InvestigationExecutionConfirmation5Code InvestigationExecutionStatus { get; init; } 
    
    /// <summary>
    /// Provides the reason for a given status on the execution of an investigation.
    /// </summary>
    [IsoId("_LJOF0CFhEeicwehH70nfgw")]
    [DisplayName("Investigation Execution Status Reason")]
    [IsoXmlTag("InvstgtnExctnStsRsn")]
    public InvestigationExecutionStatusReason1? InvestigationExecutionStatusReason { get; init; } 
    
    
    #nullable disable
    
}
