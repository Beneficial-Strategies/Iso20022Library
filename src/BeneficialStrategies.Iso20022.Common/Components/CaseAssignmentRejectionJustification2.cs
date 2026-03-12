// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the reason for rejecting the case assignment.
/// </summary>
[IsoId("_T99BXdp-Ed-ak6NoX_4Aeg_-1913963588")]
[DisplayName("Case Assignment Rejection Justification")]
public partial record CaseAssignmentRejectionJustification2
{
    #nullable enable
    
    /// <summary>
    /// Reason for the rejection of a case assignment, in a coded form.
    /// </summary>
    [IsoId("_T99BXtp-Ed-ak6NoX_4Aeg_-1913962991")]
    [DisplayName("Rejection Reason")]
    [IsoXmlTag("RjctnRsn")]
    public required CaseAssignmentRejection2Code RejectionReason { get; init; } 
    
    
    #nullable disable
    
}
