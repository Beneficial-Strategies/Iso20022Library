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
/// This record is an implementation of the supl.005.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCANODerivativeSD1 message extends ISO corporate action notification (CANO) message with DTCC corporate action derivative notice elements not covered in the standard message.
/// </summary>
[Description(
    @"The DTCCCANODerivativeSD1 message extends ISO corporate action notification (CANO) message with DTCC corporate action derivative notice elements not covered in the standard message."
)]
[IsoId("_1OJ85DL3EeKU9IrkkToqcw_396610797")]
[DisplayName("DTCCCANO Derivative SD 1 V")]
public record DTCCCANODerivativeSD1V03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.005.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCANODerivSD1";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.005.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Extension block for the information to be extended as corporate action notification details.
    /// </summary>
    [IsoId("_1OJ85TL3EeKU9IrkkToqcw_778471175")]
    [DisplayName("Corporate Action Notification")]
    [IsoXmlTag("CorpActnNtfctn")]
    public CorporateActionNotificationSD2? CorporateActionNotification { get; init; }
}

// Since DTCCCANODerivativeSD1V03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DTCCCANODerivativeSD1V03.
