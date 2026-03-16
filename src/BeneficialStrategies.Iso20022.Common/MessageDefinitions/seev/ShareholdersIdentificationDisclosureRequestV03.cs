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
/// This record is an implementation of the seev.045.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ShareholdersIdentificationDisclosureRequest message is sent by an issuer or by a third party nominated by the issuer (such as an issuer&apos;s agent) to the first intermediaries in a custody chain or is sent by any intermediaries in a custody chain to the next intermediary down the chain of intermediaries (towards the investor side of the chain) in order to request the disclosure of shareholders identity and provides information on the receiving party to whom responses must be sent, on the financial instrument concerned and on the deadline to respond.
/// </summary>
[Description(
    @"The ShareholdersIdentificationDisclosureRequest message is sent by an issuer or by a third party nominated by the issuer (such as an issuer's agent) to the first intermediaries in a custody chain or is sent by any intermediaries in a custody chain to the next intermediary down the chain of intermediaries (towards the investor side of the chain) in order to request the disclosure of shareholders identity and provides information on the receiving party to whom responses must be sent, on the financial instrument concerned and on the deadline to respond."
)]
[IsoId("_9U3hYfEkEeqRfth943bvEA")]
[DisplayName("Shareholders Identification Disclosure Request V")]
public record ShareholdersIdentificationDisclosureRequestV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.045.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ShrhldrsIdDsclsrReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.045.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Official and unique identification assigned to a shareholder identification disclosure request process by the issuer or third party nominated by it.
    /// </summary>
    [IsoId("_9U3hafEkEeqRfth943bvEA")]
    [DisplayName("Issuer Disclosure Request Identification")]
    [IsoXmlTag("IssrDsclsrReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text IssuerDisclosureRequestIdentification { get; init; }

    /// <summary>
    /// Specifies the type of disclosure request.
    /// </summary>
    [IsoId("_9U3ha_EkEeqRfth943bvEA")]
    [DisplayName("Disclosure Request Type")]
    [IsoXmlTag("DsclsrReqTp")]
    public required DisclosureRequestType1Code DisclosureRequestType { get; init; }

    /// <summary>
    /// Identification of a previously sent shareholder identification disclosure request message.
    /// </summary>
    [IsoId("__KBE8PNwEeqRfth943bvEA")]
    [DisplayName("Previous Disclosure Request Identification")]
    [IsoXmlTag("PrvsDsclsrReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PreviousDisclosureRequestIdentification { get; init; }

    /// <summary>
    /// Indicates whether the request is to be forwarded to and responded by the other intermediaries down the chain of intermediaries or not. If the request is not to be forwarded, the indicator may not be present.
    /// </summary>
    [IsoId("_9U3hbfEkEeqRfth943bvEA")]
    [DisplayName("Forward Request Indicator")]
    [IsoXmlTag("FwdReqInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ForwardRequestIndicator { get; init; }

    /// <summary>
    /// Indicates whether the shareholder identification disclosure response is to be sent back down the chain of intermediaries or directly to the identified response recipient.
    /// If &quot;true&quot; or &quot;1&quot;, the response must be sent back through the chain of intermediaries.
    /// If &quot;false&quot; or &quot;0&quot; or if the indicator is not present, the response must be sent directly to the identified response recipient.
    /// </summary>
    [IsoId("_9U3hb_EkEeqRfth943bvEA")]
    [DisplayName("Response Through Chain Indicator")]
    [IsoXmlTag("RspnThrghChainInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ResponseThroughChainIndicator { get; init; }

    /// <summary>
    /// Indicates whether the request was initiated by the first intermediary in the custody chain in accordance with SRD II.
    /// </summary>
    [IsoId("_9U3hcfEkEeqRfth943bvEA")]
    [DisplayName("Shareholder Rights Directive Indicator")]
    [IsoXmlTag("ShrhldrRghtsDrctvInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ShareholderRightsDirectiveIndicator { get; init; }

    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_9U3hc_EkEeqRfth943bvEA")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Date set by the issuer on which the shareholders identity is determined based on the settled positions struck in the books of the issuer CSD or any other first intermediary at the close of business day.
    /// </summary>
    [IsoId("_9U3hdfEkEeqRfth943bvEA")]
    [DisplayName("Shareholders Disclosure Record Date")]
    [IsoXmlTag("ShrhldrsDsclsrRcrdDt")]
    public required DateFormat46Choice_ ShareholdersDisclosureRecordDate { get; init; }

    /// <summary>
    /// Minimum number of shares held by a shareholder above which the identification must be disclosed.
    /// </summary>
    [IsoId("_9U3hd_EkEeqRfth943bvEA")]
    [DisplayName("Shares Quantity Threshold")]
    [IsoXmlTag("ShrsQtyThrshld")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? SharesQuantityThreshold { get; init; }

    /// <summary>
    /// Indicates whether the date from which the shares have been held must be communicated into the disclosure response and according to which method theses dates have to be communicated. The method can be provided either with a predefined code or via a textual description.
    /// </summary>
    [IsoId("_9U3hefEkEeqRfth943bvEA")]
    [DisplayName("Request Share Held Date")]
    [IsoXmlTag("ReqShrHeldDt")]
    public RequestShareHeldDate1Choice_? RequestShareHeldDate { get; init; }

    /// <summary>
    /// Issuer or third party nominated by the issuer to whom the disclosure response shall be transmitted by the intermediary.
    /// </summary>
    [IsoId("_9U3he_EkEeqRfth943bvEA")]
    [DisplayName("Disclosure Response Recipient")]
    [IsoXmlTag("DsclsrRspnRcpt")]
    public required PartyIdentification214 DisclosureResponseRecipient { get; init; }

    /// <summary>
    /// Latest date/time set by the issuer or  a third party appointed by the issuer at which a response to the request to disclose shareholder identity shall be provided by each intermediary to the recipient to whom the response must be sent.
    /// </summary>
    [IsoId("_9U3hffEkEeqRfth943bvEA")]
    [DisplayName("Issuer Disclosure Deadline")]
    [IsoXmlTag("IssrDsclsrDdln")]
    public required DateFormat46Choice_ IssuerDisclosureDeadline { get; init; }

    /// <summary>
    /// Latest date/time set by an intermediary at which a response to the request to disclose shareholder identity shall be provided when sending the response though the chain of intermediaries.
    /// </summary>
    [IsoId("_9U3hf_EkEeqRfth943bvEA")]
    [DisplayName("Disclosure Response Deadline")]
    [IsoXmlTag("DsclsrRspnDdln")]
    public DateFormat46Choice_? DisclosureResponseDeadline { get; init; }

    /// <summary>
    /// Issuer of the financial instrument.
    /// </summary>
    [IsoId("_9U3hgfEkEeqRfth943bvEA")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyIdentification129Choice_? Issuer { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_9U3hg_EkEeqRfth943bvEA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since ShareholdersIdentificationDisclosureRequestV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ShareholdersIdentificationDisclosureRequestV03.
