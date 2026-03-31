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
/// This record is an implementation of the seev.053.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_FG4DcVxPEe6fgZt44_IqFA")]
[DisplayName("Market Claim Cancellation Request Status Advice V02")]
public record MarketClaimCancellationRequestStatusAdviceV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.053.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MktClmCxlReqStsAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.053.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Corporate Action General Information.
    /// </summary>
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionGeneralInformation157 CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// Market Claim Cancellation Request Identification.
    /// </summary>
    [DisplayName("Market Claim Cancellation Request Identification")]
    [IsoXmlTag("MktClmCxlReqId")]
    public required DocumentIdentification9 MarketClaimCancellationRequestIdentification { get; init; }

    /// <summary>
    /// Market Claim Cancellation Request Status.
    /// </summary>
    [DisplayName("Market Claim Cancellation Request Status")]
    [IsoXmlTag("MktClmCxlReqSts")]
    public required MarketClaimCancellationRequestStatus1Choice_ MarketClaimCancellationRequestStatus { get; init; }

    /// <summary>
    /// Market Claim Details.
    /// </summary>
    [DisplayName("Market Claim Details")]
    [IsoXmlTag("MktClmDtls")]
    public CorporateActionOption217? MarketClaimDetails { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    /// <summary>
    /// Transaction Reference.
    /// </summary>
    [DisplayName("Transaction Reference")]
    [IsoXmlTag("TxRef")]
    public required References26 TransactionReference { get; init; }
}

// Since MarketClaimCancellationRequestStatusAdviceV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MarketClaimCancellationRequestStatusAdviceV02.
