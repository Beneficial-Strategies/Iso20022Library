// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the status of the tracker alert.
/// </summary>
[IsoId("_k0GOP_Y0Eemf4dJxCjghNw")]
[DisplayName("Tracker Alert Status")]
public partial record TrackerAlertStatus1
{
    #nullable enable
    
    /// <summary>
    /// Status of the tracker alert, as published in an external code set.
    /// </summary>
    [IsoId("_k0GOQ_Y0Eemf4dJxCjghNw")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required TrackerAlertStatus1Code Code { get; init; } 
    
    
    #nullable disable
    
}
