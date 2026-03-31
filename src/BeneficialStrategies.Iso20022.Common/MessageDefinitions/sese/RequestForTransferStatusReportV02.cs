// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.009.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An instructing party, eg, an investment manager or its authorised representative, sends the RequestForTransferStatusReport to the executing party, eg, a transfer agent to request the status of a previously instructed transfer.
/// Usage
/// The RequestForTransferStatusReport is used to request either:
/// - the status of one or several transfer instructions or,
/// - the status of one or several transfer cancellation instructions.
/// </summary>
[Description(
    @"Scope|An instructing party, eg, an investment manager or its authorised representative, sends the RequestForTransferStatusReport to the executing party, eg, a transfer agent to request the status of a previously instructed transfer.|Usage|The RequestForTransferStatusReport is used to request either:|- the status of one or several transfer instructions or,|- the status of one or several transfer cancellation instructions."
)]
[IsoId("_oGN9ZdE5Ed-BzquC8wXy7w_2033838549")]
[DisplayName("Request For Transfer Status Report V")]
public record RequestForTransferStatusReportV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.009.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ReqForTrfStsRptV02";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.009.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_oGN9ZtE5Ed-BzquC8wXy7w_1731455646")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Information to identify the transfer for which the status is requested.|.
    /// </summary>
    [IsoId("_oGN9Z9E5Ed-BzquC8wXy7w_2033838559")]
    [DisplayName("Request Details")]
    [IsoXmlTag("ReqDtls")]
    public required MessageAndBusinessReference6 RequestDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_oGN9aNE5Ed-BzquC8wXy7w_240300067")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since RequestForTransferStatusReportV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RequestForTransferStatusReportV02.
