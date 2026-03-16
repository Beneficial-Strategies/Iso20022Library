// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements for the identification of the message and related references.
/// </summary>
[IsoId("_Qn9899p-Ed-ak6NoX_4Aeg_-250058534")]
[DisplayName("References")]
public record References4
{
    /// <summary>
    /// Identifies a message by a unique identifier and the date and time when the message was created by the sender.
    /// </summary>
    [IsoId("_Qn98-Np-Ed-ak6NoX_4Aeg_1903788067")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Identifies a process by a unique identifier and the date and time when the first message belonging to the process was created by the sender. The process identification remains the same in all messages belonging to the same process, from the initial request message to the final account report closing the process.
    /// </summary>
    [IsoId("_QoHt8Np-Ed-ak6NoX_4Aeg_1445785286")]
    [DisplayName("Process Identification")]
    [IsoXmlTag("PrcId")]
    public required MessageIdentification1 ProcessIdentification { get; init; }

    /// <summary>
    /// File name of a document logically related to the request.
    /// </summary>
    [IsoId("_QoHt8dp-Ed-ak6NoX_4Aeg_-938129435")]
    [DisplayName("Attached Document Name")]
    [IsoXmlTag("AttchdDocNm")]
    public SimpleValueList<IsoMax70Text> AttachedDocumentName { get; init; } = [];
}
