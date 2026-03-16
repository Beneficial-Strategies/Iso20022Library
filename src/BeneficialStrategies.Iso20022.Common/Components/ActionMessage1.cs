// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Message to be displayed to the cardholder or the cashier.
/// </summary>
[IsoId("_TEzSkAEcEeCQm6a_G2yO_w_1379249384")]
[DisplayName("Action Message")]
public record ActionMessage1
{
    /// <summary>
    /// Destination of the message to be displayed or printed.
    /// </summary>
    [IsoId("_TEzSkQEcEeCQm6a_G2yO_w_-1322905232")]
    [DisplayName("Message Destination")]
    [IsoXmlTag("MsgDstn")]
    public required UserInterface1Code MessageDestination { get; init; }

    /// <summary>
    /// Text or graphic data to be display or printed to the cardholder or the cashier.
    /// </summary>
    [IsoId("_TEzSkgEcEeCQm6a_G2yO_w_-1205034247")]
    [DisplayName("Message Content")]
    [IsoXmlTag("MsgCntt")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public required IsoMax256Text MessageContent { get; init; }

    /// <summary>
    /// Electronic signature of the message to display or print.
    /// </summary>
    [IsoId("_TEzSkwEcEeCQm6a_G2yO_w_795149401")]
    [DisplayName("Message Content Signature")]
    [IsoXmlTag("MsgCnttSgntr")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? MessageContentSignature { get; init; }
}
