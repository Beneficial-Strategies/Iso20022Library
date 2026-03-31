// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of actions to be performed by the card acceptor.
/// </summary>
[IsoId("_66MYUXuXEeSVeNXcmBQ4hQ")]
[DisplayName("Action")]
public record Action4
{
    /// <summary>
    /// Type of action to be performed by the card acceptor.
    /// </summary>
    [IsoId("_7HAFQXuXEeSVeNXcmBQ4hQ")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required ActionType5Code ActionType { get; init; }

    /// <summary>
    /// Message to be displayed to the cardholder or the cashier.
    /// </summary>
    [IsoId("_7HAFQ3uXEeSVeNXcmBQ4hQ")]
    [DisplayName("Message To Present")]
    [IsoXmlTag("MsgToPres")]
    public ActionMessage2? MessageToPresent { get; init; }
}
