// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of actions to be performed by the POI (Point Of Interaction) system.
/// </summary>
[IsoId("_V7PM8U0BEeybj420QgWBkA")]
[DisplayName("Action")]
public partial record Action12
{
    #nullable enable
    
    /// <summary>
    /// Type of action to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_WE6tYU0BEeybj420QgWBkA")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required ActionType12Code ActionType { get; init; } 
    
    /// <summary>
    /// Message to be displayed to the cardholder or the cashier.
    /// </summary>
    [IsoId("_WE6tY00BEeybj420QgWBkA")]
    [DisplayName("Message To Present")]
    [IsoXmlTag("MsgToPres")]
    public ActionMessage9? MessageToPresent { get; init; } 
    
    
    #nullable disable
    
}
