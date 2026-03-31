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

namespace BeneficialStrategies.Iso20022.supl;

/// <summary>
/// This record is an implementation of the supl.006.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCACNSD1 message extends ISO corporate action cancellation advise (CACN) message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Description(
    @"The DTCCCACNSD1 message extends ISO corporate action cancellation advise (CACN) message with DTCC corporate action elements not covered in the standard message."
)]
[IsoId("_b_Y1SeaHEei5aPS232E3Mw")]
[DisplayName("DTCCCACNSD 1 V")]
public record DTCCCACNSD1V08 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.006.001.08";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCACNSD1";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.006.001.08";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the multi-parts confirmation is to continue or that the message is the last page of the multi-parts confirmation.
    /// </summary>
    [IsoId("_nF_iwegfEei5aPS232E3Mw")]
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public Pagination1? Pagination { get; init; }

    /// <summary>
    /// Information to be extended as supplementary data to cancellation advice.
    /// </summary>
    [IsoId("_b_Y1S-aHEei5aPS232E3Mw")]
    [DisplayName("Notification")]
    [IsoXmlTag("Ntfctn")]
    public CorporateActionNotificationSD10? Notification { get; init; }

    /// <summary>
    /// Information to be extended as supplementary data to cancellation advice general information.
    /// </summary>
    [IsoId("_b_Y1TeaHEei5aPS232E3Mw")]
    [DisplayName("General Information")]
    [IsoXmlTag("GnlInf")]
    public CorporateActionGeneralInformationSD29? GeneralInformation { get; init; }

    /// <summary>
    /// Information to be extended as events linkage supplementary data to events to cancellation advice.
    /// </summary>
    [IsoId("_b_Y1T-aHEei5aPS232E3Mw")]
    [DisplayName("Events Linkage")]
    [IsoXmlTag("EvtsLkg")]
    public CorporateActionCancellationSD3? EventsLinkage { get; init; }

    /// <summary>
    /// Information to be extended as external comments to cancellation advice.
    /// </summary>
    [IsoId("_b_Y1UeaHEei5aPS232E3Mw")]
    [DisplayName("External Comments")]
    [IsoXmlTag("XtrnlCmnts")]
    public CorporateActionCancellationSD4? ExternalComments { get; init; }
}

// Since DTCCCACNSD1V08Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DTCCCACNSD1V08.
