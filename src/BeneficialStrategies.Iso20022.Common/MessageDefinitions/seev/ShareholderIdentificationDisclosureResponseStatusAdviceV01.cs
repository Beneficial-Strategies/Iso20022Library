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

namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// This record is an implementation of the seev.049.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ShareholdersIdentificationDisclosureResponseStatusAdvice message is sent by an issuer or by a third party nominated by the issuer (such as an issuer&apos;s agent) to the intermediary in a custody chain in response to a ShareholderIdentificationDisclosureResponse message or in response to a multipart response report (sent with pagination in multiple messages) in order to report about the acceptance status of the received ShareholderIdentificationDisclosureResponse message/report.
/// Usage: when the shareholder identification disclosure response is sent in a multipart response report (with several messages), a single response status advice only may be sent for the acceptance status of the whole report.
/// </summary>
[Description(
    @"The ShareholdersIdentificationDisclosureResponseStatusAdvice message is sent by an issuer or by a third party nominated by the issuer (such as an issuer's agent) to the intermediary in a custody chain in response to a ShareholderIdentificationDisclosureResponse message or in response to a multipart response report (sent with pagination in multiple messages) in order to report about the acceptance status of the received ShareholderIdentificationDisclosureResponse message/report.|Usage: when the shareholder identification disclosure response is sent in a multipart response report (with several messages), a single response status advice only may be sent for the acceptance status of the whole report."
)]
[IsoId("_NCNMYHC5EemNhNOCZKENuw")]
[DisplayName("Shareholder Identification Disclosure Response Status Advice V")]
public record ShareholderIdentificationDisclosureResponseStatusAdviceV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.049.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ShrhldrIdDsclsrRspnStsAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.049.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Unique identification of the disclosure response for which the status advice is sent.
    /// </summary>
    [IsoId("_9xsWBYd9EemJ1cSJJmVYRQ")]
    [DisplayName("Disclosure Response Identification")]
    [IsoXmlTag("DsclsrRspnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text DisclosureResponseIdentification { get; init; }

    /// <summary>
    /// Official and unique identification assigned to a shareholders identification disclosure request process by the issuer or third party nominated by it and for which a response is sent.
    /// </summary>
    [IsoId("_Eq5WgbRBEem2T48lBgJbww")]
    [DisplayName("Issuer Disclosure Request Reference")]
    [IsoXmlTag("IssrDsclsrReqRef")]
    public required DisclosureRequestIdentification1 IssuerDisclosureRequestReference { get; init; }

    /// <summary>
    /// Unique identification of the intermediary party responding to the shareholders identification disclosure request.
    /// </summary>
    [IsoId("_9xsWB4d9EemJ1cSJJmVYRQ")]
    [DisplayName("Responding Intermediary")]
    [IsoXmlTag("RspndgIntrmy")]
    public required PartyIdentification215 RespondingIntermediary { get; init; }

    /// <summary>
    /// Acceptance status of the shareholder disclosure Identification Response message/report.
    /// </summary>
    [IsoId("_lGAS0IeSEemJ1cSJJmVYRQ")]
    [DisplayName("Response Reception Status")]
    [IsoXmlTag("RspnRcptnSts")]
    public required ResponseProcessingStatus1Choice_ ResponseReceptionStatus { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_-bsZoYebEemJ1cSJJmVYRQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since ShareholderIdentificationDisclosureResponseStatusAdviceV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ShareholderIdentificationDisclosureResponseStatusAdviceV01.
