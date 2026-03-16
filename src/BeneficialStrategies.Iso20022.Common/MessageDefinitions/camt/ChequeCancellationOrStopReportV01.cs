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

namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.109.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ChequeCancellationOrStopReport message is sent by the drawee agent (on which a cheque is drawn) to the drawer agent or the agent acting on behalf of the drawer agent to indicate what actions have been taken in attempting to cancel the presentment and/or stop the payment of the cheque referred to in the message.
/// </summary>
[Description(
    @"The ChequeCancellationOrStopReport message is sent by the drawee agent (on which a cheque is drawn) to the drawer agent or the agent acting on behalf of the drawer agent to indicate what actions have been taken in attempting to cancel the presentment and/or stop the payment of the cheque referred to in the message."
)]
[IsoId("_QUITMbSJEeq3lpO-mRtrig")]
[DisplayName("Cheque Cancellation Or Stop Report V")]
public record ChequeCancellationOrStopReportV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.109.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ChqCxlOrStopRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.109.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Set of characteristics shared by all individual cheques included in the message.
    /// </summary>
    [IsoId("_GewUESm6EeutWNGMV2XKIQ")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader103 GroupHeader { get; init; }

    /// <summary>
    /// Specifies the details of the cheque.
    /// </summary>
    [IsoId("_s-k9grtwEeq_cfXrH83Rcw")]
    [DisplayName("Cheque")]
    [IsoXmlTag("Chq")]
    public required Cheque14 Cheque { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Vgrws7tlEeq_cfXrH83Rcw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since ChequeCancellationOrStopReportV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ChequeCancellationOrStopReportV01.
