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
/// This record is an implementation of the camt.107.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ChequePresentmentNotification message is sent by a drawer bank, or a bank acting on behalf of the drawer bank to the bank on which a/several cheque(s) has been drawn (the drawee bank).
/// It is used to advise the drawee bank, or confirm to an enquiring bank, the details concerning the cheque(s) referred to in the message.
/// </summary>
[Description(
    @"The ChequePresentmentNotification message is sent by a drawer bank, or a bank acting on behalf of the drawer bank to the bank on which a/several cheque(s) has been drawn (the drawee bank).|It is used to advise the drawee bank, or confirm to an enquiring bank, the details concerning the cheque(s) referred to in the message."
)]
[IsoId("_QqKNkbSJEeq3lpO-mRtrig")]
[DisplayName("Cheque Presentment Notification V")]
public record ChequePresentmentNotificationV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.107.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ChqPresntmntNtfctn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.107.001.01";

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
    [IsoId("_GCVd0Sm6EeutWNGMV2XKIQ")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader103 GroupHeader { get; init; }

    /// <summary>
    /// Specifies the details of the cheque.
    /// </summary>
    [IsoId("_tGFUsbtlEeq_cfXrH83Rcw")]
    [DisplayName("Cheque")]
    [IsoXmlTag("Chq")]
    public required Cheque13 Cheque { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_V-H6o7tlEeq_cfXrH83Rcw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since ChequePresentmentNotificationV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ChequePresentmentNotificationV01.
