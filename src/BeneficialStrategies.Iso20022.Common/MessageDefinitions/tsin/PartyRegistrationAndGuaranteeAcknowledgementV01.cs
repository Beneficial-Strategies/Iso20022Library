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
/// This record is an implementation of the tsin.012.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The message PartyManagementPaymentAcknowledgement is sent from a trade partner to any partner requested through a PartyManagementPaymentAcknowledgemenNotification message to acknowledge the notified factoring service agreement. Depending on legal contexts, the acknowledgement may be required in order for the financial service agreement to become effective.
/// The message references related messages and may include referenced data.
/// The message can carry digital signatures if required by context.
/// </summary>
[Description(
    @"The message PartyManagementPaymentAcknowledgement is sent from a trade partner to any partner requested through a PartyManagementPaymentAcknowledgemenNotification message to acknowledge the notified factoring service agreement. Depending on legal contexts, the acknowledgement may be required in order for the financial service agreement to become effective.|The message references related messages and may include referenced data.|The message can carry digital signatures if required by context."
)]
[IsoId("_OTgzNDkx-AOSNFX-8224506")]
[DisplayName("Party Registration And Guarantee Acknowledgement V")]
public record PartyRegistrationAndGuaranteeAcknowledgementV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsin.012.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PtyRegnAndGrntAck";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsin.012.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Set of characteristics that unambiguously identify the acknowlegement, common parameters, documents and identifications.
    /// </summary>
    [IsoId("_OTgzNDky-AOSNFX-8224507")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required BusinessLetter1 Header { get; init; }

    /// <summary>
    /// List of party management acknowledgements.
    /// </summary>
    [IsoId("_OTgzNDkz-AOSNFX-8224507")]
    [DisplayName("Acknowledgement List")]
    [IsoXmlTag("AckList")]
    public required FinancingAgreementList1 AcknowledgementList { get; init; }

    /// <summary>
    /// Number of acknowledgement lists as control value.
    /// </summary>
    [IsoId("_OTgzNDk0-AOSNFX-8224507")]
    [DisplayName("Acknowledgement Count")]
    [IsoXmlTag("AckCnt")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText AcknowledgementCount { get; init; }

    /// <summary>
    /// Total number of individual items in all lists.
    /// </summary>
    [IsoId("_OTgzNDk1-AOSNFX-8224507")]
    [DisplayName("Item Count")]
    [IsoXmlTag("ItmCnt")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? ItemCount { get; init; }

    /// <summary>
    /// Total of all individual amounts included in all lists, irrespective of currencies or direction.
    /// </summary>
    [IsoId("_OTgzNDk2-AOSNFX-8224507")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <summary>
    /// Referenced or related business message.
    /// </summary>
    [IsoId("_OTgzNDk3-AOSNFX-8224507")]
    [DisplayName("Attached Message")]
    [IsoXmlTag("AttchdMsg")]
    public EncapsulatedBusinessMessage1? AttachedMessage { get; init; }
}

// Since PartyRegistrationAndGuaranteeAcknowledgementV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PartyRegistrationAndGuaranteeAcknowledgementV01.
