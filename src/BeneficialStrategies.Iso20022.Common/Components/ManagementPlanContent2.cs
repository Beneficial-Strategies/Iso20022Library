// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the management plan.
/// </summary>
[IsoId("_xXJXkR3ZEeKKrOIoqWglDw")]
[DisplayName("Management Plan Content")]
public partial record ManagementPlanContent2
{
    #nullable enable
    
    /// <summary>
    /// Terminal management action to be performed by the point of interaction (POI).
    /// </summary>
    [IsoId("_xjWnkR3ZEeKKrOIoqWglDw")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public ValueList<TMSAction2> Action { get; init; } = [];
    // ID for the above is _xjWnkR3ZEeKKrOIoqWglDw
    
    
    #nullable disable
    
}
