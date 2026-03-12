// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Date and time restricted format.
/// </summary>
[IsoId("_XaHw6fWfEemtd4wHZYvFUQ")]
[DisplayName("Date Time")]
public partial record DateTime1
{
    #nullable enable
    
    /// <summary>
    /// Specified date and time.
    /// </summary>
    [IsoId("_XaIX4fWfEemtd4wHZYvFUQ")]
    [DisplayName("Date Time")]
    [IsoXmlTag("DtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime DateTime { get; init; } 
    
    
    #nullable disable
    
}
