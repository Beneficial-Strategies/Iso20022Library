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
[IsoId("__O7QcTGeEeO118ZQJgaQSQ")]
[DisplayName("Action")]
public record Action3
{
    /// <summary>
    /// Type of action to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("__fbxoTGeEeO118ZQJgaQSQ")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required ActionType3Code ActionType { get; init; }

    /// <summary>
    /// Message to be displayed to the cardholder or the cashier.
    /// </summary>
    [IsoId("__fbxozGeEeO118ZQJgaQSQ")]
    [DisplayName("Message To Present")]
    [IsoXmlTag("MsgToPres")]
    public ActionMessage1? MessageToPresent { get; init; }
}
