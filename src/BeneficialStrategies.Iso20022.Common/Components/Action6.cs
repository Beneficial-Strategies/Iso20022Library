// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of actions to be performed by the POI (Point Of Interaction) system.
/// </summary>
[IsoId("_4bj8cY04EeW1W6lLicSC4w")]
[DisplayName("Action")]
public record Action6
{
    /// <summary>
    /// Type of action to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_4ne4kY04EeW1W6lLicSC4w")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required ActionType3Code ActionType { get; init; }

    /// <summary>
    /// Message to be displayed to the cardholder or the cashier.
    /// </summary>
    [IsoId("_4ne4k404EeW1W6lLicSC4w")]
    [DisplayName("Message To Present")]
    [IsoXmlTag("MsgToPres")]
    public ActionMessage2? MessageToPresent { get; init; }
}
