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
[IsoId("_QoQ34Np-Ed-ak6NoX_4Aeg_126946620")]
[DisplayName("References")]
public record References6
{
    /// <summary>
    /// Identify the type of rejected request.
    /// </summary>
    [IsoId("_QoQ34dp-Ed-ak6NoX_4Aeg_452951458")]
    [DisplayName("Rejected Request Type")]
    [IsoXmlTag("RjctdReqTp")]
    public required UseCases1Code RejectedRequestType { get; init; }

    /// <summary>
    /// Reason of the message rejection.
    /// </summary>
    [IsoId("_QoQ34tp-Ed-ak6NoX_4Aeg_1011680219")]
    [DisplayName("Rejection Reason")]
    [IsoXmlTag("RjctnRsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    public SimpleValueList<System.String> RejectionReason { get; init; } = [];

    // ID for the above is _QoQ34tp-Ed-ak6NoX_4Aeg_1011680219

    /// <summary>
    /// Identification of the rejected request message.
    /// </summary>
    [IsoId("_QoQ349p-Ed-ak6NoX_4Aeg_1990600533")]
    [DisplayName("Rejected Request Identification")]
    [IsoXmlTag("RjctdReqId")]
    public required MessageIdentification1 RejectedRequestIdentification { get; init; }

    /// <summary>
    /// Identifies a message by a unique identifier and the date and time when the message was created by the sender.
    /// </summary>
    [IsoId("_QoQ35Np-Ed-ak6NoX_4Aeg_2049703827")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Identifies a process by a unique identifier and the date and time when the first message belonging to the process was created by the sender. The process identification remains the same in all messages belonging to the same process, from the initial request message to the final account report closing the process.
    /// </summary>
    [IsoId("_QoQ35dp-Ed-ak6NoX_4Aeg_-1977439900")]
    [DisplayName("Process Identification")]
    [IsoXmlTag("PrcId")]
    public required MessageIdentification1 ProcessIdentification { get; init; }

    /// <summary>
    /// File name of a document logically related to the request.
    /// </summary>
    [IsoId("_QoQ35tp-Ed-ak6NoX_4Aeg_-564165494")]
    [DisplayName("Attached Document Name")]
    [IsoXmlTag("AttchdDocNm")]
    public SimpleValueList<IsoMax70Text> AttachedDocumentName { get; init; } = [];
}
