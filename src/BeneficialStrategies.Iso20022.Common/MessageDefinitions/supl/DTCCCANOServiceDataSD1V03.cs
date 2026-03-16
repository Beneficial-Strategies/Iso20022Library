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
/// This record is an implementation of the supl.003.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCANOServiceDataSD1 message extends ISO corporate action notification (CANO) message with DTCC validation service specific data elements that are not covered by the standard message.
/// </summary>
[Description(
    @"The DTCCCANOServiceDataSD1 message extends ISO corporate action notification (CANO) message with DTCC validation service specific data elements that are not covered by the standard message."
)]
[IsoId("_1PgAsDL3EeKU9IrkkToqcw_-1681566292")]
[DisplayName("DTCCCANO Service Data SD 1 V")]
public record DTCCCANOServiceDataSD1V03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.003.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCANOSvcDataSD1";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.003.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Information to be extended as supplementary data to notification general information.
    /// </summary>
    [IsoId("_1PgAsTL3EeKU9IrkkToqcw_1324370913")]
    [DisplayName("Notification General Information")]
    [IsoXmlTag("NtfctnGnlInf")]
    public CorporateActionNotificationSD6? NotificationGeneralInformation { get; init; }

    /// <summary>
    /// Information to be extended as supplementary data to events linkage.
    /// </summary>
    [IsoId("_1PgAsjL3EeKU9IrkkToqcw_1207093876")]
    [DisplayName("Events Linkage")]
    [IsoXmlTag("EvtsLkg")]
    public CorporateActionEventReferenceSD2? EventsLinkage { get; init; }

    /// <summary>
    /// Information to be extended as supplementary data to corporate action notification.
    /// </summary>
    [IsoId("_1PgAszL3EeKU9IrkkToqcw_-847715476")]
    [DisplayName("Corporate Action Notification")]
    [IsoXmlTag("CorpActnNtfctn")]
    public CorporateActionNotificationSD1? CorporateActionNotification { get; init; }

    /// <summary>
    /// Information to be extended as supplementary data to underlying security.
    /// </summary>
    [IsoId("_1PgAtDL3EeKU9IrkkToqcw_-195598292")]
    [DisplayName("Underlying Security")]
    [IsoXmlTag("UndrlygScty")]
    public FinancialInstrumentAttributesSD7? UnderlyingSecurity { get; init; }

    /// <summary>
    /// Information to be extended as corporate action details supplementary data.
    /// </summary>
    [IsoId("_1PgAtTL3EeKU9IrkkToqcw_1221991011")]
    [DisplayName("Corporate Action Details")]
    [IsoXmlTag("CorpActnDtls")]
    public CorporateActionSD4? CorporateActionDetails { get; init; }

    /// <summary>
    /// Information to be extended as corporate action date details supplementary data.
    /// </summary>
    [IsoId("_1PgAtjL3EeKU9IrkkToqcw_-885992761")]
    [DisplayName("Corporate Action Date Details")]
    [IsoXmlTag("CorpActnDtDtls")]
    public CorporateActionDateSD4? CorporateActionDateDetails { get; init; }

    /// <summary>
    /// Information to be extended as supplementary data to option details.
    /// </summary>
    [IsoId("_1PpKoDL3EeKU9IrkkToqcw_531596542")]
    [DisplayName("Option Details")]
    [IsoXmlTag("OptnDtls")]
    public CorporateActionOptionSD5? OptionDetails { get; init; }

    /// <summary>
    /// Information to be extended as supplementary data to securities movement details.
    /// </summary>
    [IsoId("_1PpKoTL3EeKU9IrkkToqcw_-1504539626")]
    [DisplayName("Securities Movement Details")]
    [IsoXmlTag("SctiesMvmntDtls")]
    public SecuritiesOptionSD4? SecuritiesMovementDetails { get; init; }

    /// <summary>
    /// Information to be extended as supplementary data to securities movement security details.
    /// </summary>
    [IsoId("_1PpKojL3EeKU9IrkkToqcw_-86950323")]
    [DisplayName("Securities Movement Security Details")]
    [IsoXmlTag("SctiesMvmntSctyDtls")]
    public FinancialInstrumentAttributesSD5? SecuritiesMovementSecurityDetails { get; init; }

    /// <summary>
    /// Information to be extended as cash movement supplementary data.
    /// </summary>
    [IsoId("_1PpKozL3EeKU9IrkkToqcw_565166861")]
    [DisplayName("Cash Movement Details")]
    [IsoXmlTag("CshMvmntDtls")]
    public CashOptionSD5? CashMovementDetails { get; init; }
}

// Since DTCCCANOServiceDataSD1V03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DTCCCANOServiceDataSD1V03.
