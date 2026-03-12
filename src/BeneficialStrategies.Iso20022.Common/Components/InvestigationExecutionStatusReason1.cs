// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the reason for a status on the execution of an investigation.
/// </summary>
[IsoId("_L5azsCFhEeicwehH70nfgw")]
[DisplayName("Investigation Execution Status Reason")]
public partial record InvestigationExecutionStatusReason1
{
    #nullable enable
    
    /// <summary>
    /// Provides the reason why the payment cancellation was rejected.
    /// </summary>
    [IsoId("_YeuHUCFhEeicwehH70nfgw")]
    [DisplayName("Rejected")]
    [IsoXmlTag("Rjctd")]
    public PaymentCancellationRejection3Code? Rejected { get; init; } 
    
    /// <summary>
    /// Provides the reason why the payment cancellation is pending.
    /// </summary>
    [IsoId("_l9vRMCFhEeicwehH70nfgw")]
    [DisplayName("Pending")]
    [IsoXmlTag("Pdg")]
    public PendingPaymentCancellationReason1Code? Pending { get; init; } 
    
    
    #nullable disable
    
}
