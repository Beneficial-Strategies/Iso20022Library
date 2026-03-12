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
[IsoId("_BB-l4R0jEeK5OKMB21JFBg")]
[DisplayName("Action")]
public partial record Action2
{
    #nullable enable
    
    /// <summary>
    /// Type of action to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_BOCE4R0jEeK5OKMB21JFBg")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required ActionType2Code ActionType { get; init; } 
    
    /// <summary>
    /// Message to be displayed to the cardholder or the cashier.
    /// </summary>
    [IsoId("_BOCE5R0jEeK5OKMB21JFBg")]
    [DisplayName("Message To Present")]
    [IsoXmlTag("MsgToPres")]
    public ActionMessage1? MessageToPresent { get; init; } 
    
    
    #nullable disable
    
}
