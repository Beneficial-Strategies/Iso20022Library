// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Format to express a date and a date mode.
/// </summary>
[IsoId("__ZsXMFuSEeSmO6RkXg92Lg")]
[DisplayName("Date Format")]
public partial record DateFormat1
{
    #nullable enable
    
    /// <summary>
    /// Date at which the event occurs.
    /// </summary>
    [IsoId("_KZJuYFuTEeSmO6RkXg92Lg")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public required DateFormat3Choice_ Date { get; init; } 
    
    /// <summary>
    /// Specifies whether an event for which a date is provided occurs typically at the &quot;beginning of day&quot; or at the &quot;end of day&quot;.
    /// </summary>
    [IsoId("_NbPmYFuTEeSmO6RkXg92Lg")]
    [DisplayName("Date Mode")]
    [IsoXmlTag("DtMd")]
    public DateMode1Code? DateMode { get; init; } 
    
    
    #nullable disable
    
}
