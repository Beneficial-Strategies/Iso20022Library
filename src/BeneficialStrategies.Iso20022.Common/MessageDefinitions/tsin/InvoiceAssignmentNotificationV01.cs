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

namespace BeneficialStrategies.Iso20022.tsin;

/// <summary>
/// This record is an implementation of the tsin.008.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// This message is sent from a factoring service provider or a factoring client to a trade partner to inform about assignments of financing items and, optionally, to an interested party.
/// The information given to the trade party indicates that property of the payment obligation has been or is being transferred to the financial institution and that payments have to be done between the trade partner and the factoring service provider.
/// The message indicates whether the notified party is required to acknowledge the notified assignment and to which party an acknowledgement has to be sent.
/// This message can also be used outside a factoring context directly between a payer and a payee for example as a reminder about a payment obligation or to make an adjustment.
/// If applicable, the message may reference corresponding items of an InvoiceFinancingRequest or InvoiceFinancingStatus or other related messages and may contain referenced data.
/// The message can carry digital signatures if required by context.
/// </summary>
[Description(
    @"This message is sent from a factoring service provider or a factoring client to a trade partner to inform about assignments of financing items and, optionally, to an interested party.|The information given to the trade party indicates that property of the payment obligation has been or is being transferred to the financial institution and that payments have to be done between the trade partner and the factoring service provider.|The message indicates whether the notified party is required to acknowledge the notified assignment and to which party an acknowledgement has to be sent.|This message can also be used outside a factoring context directly between a payer and a payee for example as a reminder about a payment obligation or to make an adjustment.|If applicable, the message may reference corresponding items of an InvoiceFinancingRequest or InvoiceFinancingStatus or other related messages and may contain referenced data.|The message can carry digital signatures if required by context."
)]
[IsoId("_OTgzNDU2-AOSNFX-8224505")]
[DisplayName("Invoice Assignment Notification V")]
public record InvoiceAssignmentNotificationV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsin.008.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InvcAssgnmtNtfctn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsin.008.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Set of characteristics that unambiguously identify the assignment notification, common parameters, documents and identifications.
    /// </summary>
    [IsoId("_OTgzNDU3-AOSNFX-8224506")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required BusinessLetter1 Header { get; init; }

    /// <summary>
    /// List of assignment notifications.
    /// </summary>
    [IsoId("_OTgzNDU4-AOSNFX-8224506")]
    [DisplayName("Notification List")]
    [IsoXmlTag("NtfctnList")]
    public required FinancingItemList1 NotificationList { get; init; }

    /// <summary>
    /// Number of assignment notification lists.
    /// </summary>
    [IsoId("_OTgzNDU5-AOSNFX-8224506")]
    [DisplayName("Notification Count")]
    [IsoXmlTag("NtfctnCnt")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NotificationCount { get; init; }

    /// <summary>
    /// Total number of individual items in all lists.
    /// </summary>
    [IsoId("_OTgzNDYw-AOSNFX-8224506")]
    [DisplayName("Item Count")]
    [IsoXmlTag("ItmCnt")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? ItemCount { get; init; }

    /// <summary>
    /// Total of all individual amounts included in all lists, irrespective of currencies or direction.
    /// </summary>
    [IsoId("_OTgzNDYx-AOSNFX-8224506")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <summary>
    /// Referenced or related business message.
    /// </summary>
    [IsoId("_OTgzNDYy-AOSNFX-8224506")]
    [DisplayName("Attached Message")]
    [IsoXmlTag("AttchdMsg")]
    public EncapsulatedBusinessMessage1? AttachedMessage { get; init; }
}

// Since InvoiceAssignmentNotificationV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to InvoiceAssignmentNotificationV01.
