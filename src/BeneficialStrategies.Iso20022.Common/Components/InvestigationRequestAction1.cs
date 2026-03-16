// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Investigation Request Action1.
/// </summary>
[IsoId("_3JlTYSU-Ee6EvsLBQ6cYtA")]
[DisplayName("Investigation Request Action1")]
public partial record InvestigationRequestAction1
{
    #nullable enable

    /// <summary>
    /// Action.
    /// </summary>
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public required InvestigationRequestAction1Choice_ Action { get; init; } 

    /// <summary>
    /// Action Reason.
    /// </summary>
    [DisplayName("Action Reason")]
    [IsoXmlTag("ActnRsn")]
    public InvestigationActionReason1? ActionReason { get; init; } 

    
    #nullable disable
    
}
