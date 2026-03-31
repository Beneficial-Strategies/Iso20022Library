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
[IsoId("_CShKUa2BEeWMg5rOByfExw")]
[DisplayName("Action")]
public record Action7
{
    /// <summary>
    /// Type of action to be performed by the card acceptor.
    /// </summary>
    [IsoId("_Cd_aga2BEeWMg5rOByfExw")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required ActionType6Code ActionType { get; init; }

    /// <summary>
    /// Information to display, print or log.
    /// </summary>
    [IsoId("_Cd_ag62BEeWMg5rOByfExw")]
    [DisplayName("Message To Present")]
    [IsoXmlTag("MsgToPres")]
    public ActionMessage4? MessageToPresent { get; init; }

    /// <summary>
    /// Message to send before the completion of the transaction.
    /// </summary>
    [IsoId("_Cd_aha2BEeWMg5rOByfExw")]
    [DisplayName("Request To Perform")]
    [IsoXmlTag("ReqToPrfrm")]
    public MessageFunction11Code? RequestToPerform { get; init; }
}
