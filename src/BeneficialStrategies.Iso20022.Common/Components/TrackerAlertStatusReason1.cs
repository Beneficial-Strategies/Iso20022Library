// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the reason for the status of the tracker alert.
/// </summary>
[IsoId("_k0GOTfY0Eemf4dJxCjghNw")]
[DisplayName("Tracker Alert Status Reason")]
public partial record TrackerAlertStatusReason1
{
    #nullable enable
    
    /// <summary>
    /// Reason for the status, in a proprietary form.
    /// </summary>
    [IsoId("_k0GOU_Y0Eemf4dJxCjghNw")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public required IsoExact4AlphaNumericText Proprietary { get; init; } 
    
    
    #nullable disable
    
}
