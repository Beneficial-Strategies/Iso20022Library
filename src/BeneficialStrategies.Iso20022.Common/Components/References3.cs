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
[IsoId("_QoHt8tp-Ed-ak6NoX_4Aeg_1839218221")]
[DisplayName("References")]
public record References3
{
    /// <summary>
    /// Identifies a message by a unique identifier and the date and time when the message was created by the sender.
    /// </summary>
    [IsoId("_QoHt89p-Ed-ak6NoX_4Aeg_1444800102")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Identification of the request message that has to be completed.
    /// </summary>
    [IsoId("_QoHt9Np-Ed-ak6NoX_4Aeg_-671231503")]
    [DisplayName("Request To Be Completed Identification")]
    [IsoXmlTag("ReqToBeCmpltdId")]
    public required MessageIdentification1 RequestToBeCompletedIdentification { get; init; }

    /// <summary>
    /// Identifies a process by a unique identifier and the date and time when the first message belonging to the process was created by the sender. The process identification remains the same in all messages belonging to the same process, from the initial request message to the final account report closing the process.
    /// </summary>
    [IsoId("_QoHt9dp-Ed-ak6NoX_4Aeg_-575186583")]
    [DisplayName("Process Identification")]
    [IsoXmlTag("PrcId")]
    public required MessageIdentification1 ProcessIdentification { get; init; }

    /// <summary>
    /// Reason of the request.
    /// </summary>
    [IsoId("_QoHt9tp-Ed-ak6NoX_4Aeg_-1380111633")]
    [DisplayName("Request Reason")]
    [IsoXmlTag("ReqRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    public SimpleValueList<System.String> RequestReason { get; init; } = [];

    // ID for the above is _QoHt9tp-Ed-ak6NoX_4Aeg_-1380111633

    /// <summary>
    /// File name of a document logically related to the request.
    /// </summary>
    [IsoId("_QoHt99p-Ed-ak6NoX_4Aeg_-775464192")]
    [DisplayName("Attached Document Name")]
    [IsoXmlTag("AttchdDocNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AttachedDocumentName { get; init; }
}
