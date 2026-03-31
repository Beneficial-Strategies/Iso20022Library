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
/// This record is an implementation of the tsin.009.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The message PartyRegistrationAndGuaranteeRequest is sent by a factoring client either to a financial service or a guarantee issuer. The message can also be sent from a financial service to a guarantee issuer. Furthermore, the message can be sent to an interested party for example a fiscal authority. When the message is sent to a guarantee issuer, the factoring client or financial service provider requests a guarantee for the factoring agreement concerning the indicated trade party. When the message is sent to a financial service, the financial client requests an agreement to execute assignments of financial items. The financial client may request the guarantee amount to be obtained in case of insolvency of the trade partner for a corresponding account receivable directly from the financial service. Alternatively and depending on the contractual and product definition, the financial client may be required to include a copy of a guarantee status received from a guarantee issuer.
/// The message can carry digital signatures if required by context.
/// </summary>
[Description(
    @"The message PartyRegistrationAndGuaranteeRequest is sent by a factoring client either to a financial service or a guarantee issuer. The message can also be sent from a financial service to a guarantee issuer. Furthermore, the message can be sent to an interested party for example a fiscal authority. When the message is sent to a guarantee issuer, the factoring client or financial service provider requests a guarantee for the factoring agreement concerning the indicated trade party. When the message is sent to a financial service, the financial client requests an agreement to execute assignments of financial items. The financial client may request the guarantee amount to be obtained in case of insolvency of the trade partner for a corresponding account receivable directly from the financial service. Alternatively and depending on the contractual and product definition, the financial client may be required to include a copy of a guarantee status received from a guarantee issuer.|The message can carry digital signatures if required by context."
)]
[IsoId("_OTgzNDYz-AOSNFX-8224506")]
[DisplayName("Party Registration And Guarantee Request V")]
public record PartyRegistrationAndGuaranteeRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsin.009.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PtyRegnAndGrntReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsin.009.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Set of characteristics that unambiguously identify the request, common parameters, documents and identifications.
    /// </summary>
    [IsoId("_OTgzNDY0-AOSNFX-8224506")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required BusinessLetter1 Header { get; init; }

    /// <summary>
    /// List of agreements.
    /// </summary>
    [IsoId("_OTgzNDY1-AOSNFX-8224506")]
    [DisplayName("Agreement List")]
    [IsoXmlTag("AgrmtList")]
    public required FinancingAgreementList1 AgreementList { get; init; }

    /// <summary>
    /// Number of agreement lists as control value.
    /// </summary>
    [IsoId("_OTgzNDY2-AOSNFX-8224506")]
    [DisplayName("Agreement Count")]
    [IsoXmlTag("AgrmtCnt")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? AgreementCount { get; init; }

    /// <summary>
    /// Total number of individual items in all lists.
    /// </summary>
    [IsoId("_OTgzNDY3-AOSNFX-8224506")]
    [DisplayName("Item Count")]
    [IsoXmlTag("ItmCnt")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? ItemCount { get; init; }

    /// <summary>
    /// Total of all individual amounts included in all lists, irrespective of currencies or direction.
    /// </summary>
    [IsoId("_OTgzNDY4-AOSNFX-8224506")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <summary>
    /// Referenced or related business message.
    /// </summary>
    [IsoId("_OTgzNDY5-AOSNFX-8224506")]
    [DisplayName("Attached Message")]
    [IsoXmlTag("AttchdMsg")]
    public EncapsulatedBusinessMessage1? AttachedMessage { get; init; }
}

// Since PartyRegistrationAndGuaranteeRequestV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PartyRegistrationAndGuaranteeRequestV01.
