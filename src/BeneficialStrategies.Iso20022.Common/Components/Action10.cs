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
[IsoId("_wfapMQu3Eeq4I6UJxZQ2Qw")]
[DisplayName("Action")]
public partial record Action10
{
    #nullable enable
    
    /// <summary>
    /// Type of action to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_wqiUEQu3Eeq4I6UJxZQ2Qw")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required ActionType9Code ActionType { get; init; } 
    
    /// <summary>
    /// Message to be displayed to the cardholder or the cashier.
    /// </summary>
    [IsoId("_wqiUEwu3Eeq4I6UJxZQ2Qw")]
    [DisplayName("Message To Present")]
    [IsoXmlTag("MsgToPres")]
    public ActionMessage7? MessageToPresent { get; init; } 
    
    
    #nullable disable
    
}
