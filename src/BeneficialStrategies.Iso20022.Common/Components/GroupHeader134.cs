// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics shared by all individual notifications included in the message.
/// </summary>
[IsoId("_BKts8WiTEfC7No_UZmyDXw")]
[DisplayName("Group Header134")]
public record GroupHeader134
{
    /// <summary>
    /// Point to point reference, as assigned by the sender, and sent to the receiver to unambiguously identify the message.
    /// Usage: The sender has to make sure that MessageIdentification is unique per receiver for a pre-agreed period.
    /// </summary>
    [IsoId("_BRmYEWiTEfC7No_UZmyDXw")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_BRmYE2iTEfC7No_UZmyDXw")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public required IsoISODateTime CreationDateTime { get; init; }
}
