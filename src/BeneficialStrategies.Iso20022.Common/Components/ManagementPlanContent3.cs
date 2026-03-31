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
[IsoId("_c6IB0TWAEeODSIIQsYYKhw")]
[DisplayName("Management Plan Content")]
public record ManagementPlanContent3
{
    /// <summary>
    /// Terminal management action to be performed by the point of interaction (POI).
    /// </summary>
    [IsoId("_dKVoETWAEeODSIIQsYYKhw")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public ValueList<TMSAction3> Action { get; init; } = [];
    // ID for the above is _dKVoETWAEeODSIIQsYYKhw
}
