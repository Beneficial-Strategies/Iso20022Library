// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the management plan.
/// </summary>
[IsoId("_KsEK1n1DEeCF8NjrBemJWQ_-2099895989")]
[DisplayName("Management Plan Content")]
public record ManagementPlanContent1
{
    /// <summary>
    /// Terminal management action to be performed by the point of interaction (POI).
    /// </summary>
    [IsoId("_KsN70H1DEeCF8NjrBemJWQ_2003915516")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public ValueList<TMSAction1> Action { get; init; } = [];
    // ID for the above is _KsN70H1DEeCF8NjrBemJWQ_2003915516
}
