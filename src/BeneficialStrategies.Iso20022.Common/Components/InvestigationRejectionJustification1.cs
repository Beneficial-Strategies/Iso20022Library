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
[IsoId("_T-ZtQNp-Ed-ak6NoX_4Aeg_947706668")]
[DisplayName("Investigation Rejection Justification")]
public partial record InvestigationRejectionJustification1
{
    #nullable enable
    
    /// <summary>
    /// Reason for the rejection of a case assignment, in a coded form.
    /// </summary>
    [IsoId("_T-ZtQdp-Ed-ak6NoX_4Aeg_947706699")]
    [DisplayName("Rejection Reason")]
    [IsoXmlTag("RjctnRsn")]
    public required InvestigationRejection1Code RejectionReason { get; init; } 
    
    
    #nullable disable
    
}
