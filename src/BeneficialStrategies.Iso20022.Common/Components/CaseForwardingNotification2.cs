// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status of a case resulting from a case assignment.
/// </summary>
[IsoId("_T-P8Qtp-Ed-ak6NoX_4Aeg_2025360319")]
[DisplayName("Case Forwarding Notification")]
public partial record CaseForwardingNotification2
{
    #nullable enable
    
    /// <summary>
    /// Justification for the forward action.
    /// </summary>
    [IsoId("_T-P8Q9p-Ed-ak6NoX_4Aeg_2025360321")]
    [DisplayName("Justification")]
    [IsoXmlTag("Justfn")]
    public required CaseForwardingNotification2Code Justification { get; init; } 
    
    
    #nullable disable
    
}
