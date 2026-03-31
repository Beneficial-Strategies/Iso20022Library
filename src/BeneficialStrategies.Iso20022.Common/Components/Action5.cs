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
[IsoId("_6jOVEYqFEeSRT5rEzcAHEw")]
[DisplayName("Action")]
public record Action5
{
    /// <summary>
    /// Type of action to be performed by the card acceptor.
    /// </summary>
    [IsoId("_6v44EYqFEeSRT5rEzcAHEw")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required ActionType6Code ActionType { get; init; }

    /// <summary>
    /// Information to display, print or log.
    /// </summary>
    [IsoId("_6v44E4qFEeSRT5rEzcAHEw")]
    [DisplayName("Message To Present")]
    [IsoXmlTag("MsgToPres")]
    public ActionMessage4? MessageToPresent { get; init; }

    /// <summary>
    /// Message to send before the completion of the transaction.
    /// </summary>
    [IsoId("_0HeSQIqIEeSRT5rEzcAHEw")]
    [DisplayName("Request To Perform")]
    [IsoXmlTag("ReqToPrfrm")]
    public MessageFunction7Code? RequestToPerform { get; init; }
}
