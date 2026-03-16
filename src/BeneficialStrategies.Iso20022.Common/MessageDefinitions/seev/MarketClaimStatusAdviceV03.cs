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
/// This record is an implementation of the seev.052.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_g4ztT3_5Ee-h086v0qPiyQ")]
[DisplayName("Market Claim Status Advice V03")]
public record MarketClaimStatusAdviceV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.052.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MktClmStsAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.052.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Account Details.
    /// </summary>
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public AccountIdentification70? AccountDetails { get; init; }

    /// <summary>
    /// Corporate Action General Information.
    /// </summary>
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionGeneralInformation181 CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// Market Claim Creation Identification.
    /// </summary>
    [DisplayName("Market Claim Creation Identification")]
    [IsoXmlTag("MktClmCreId")]
    public DocumentIdentification9? MarketClaimCreationIdentification { get; init; }

    /// <summary>
    /// Market Claim Details.
    /// </summary>
    [DisplayName("Market Claim Details")]
    [IsoXmlTag("MktClmDtls")]
    public CorporateActionOption234? MarketClaimDetails { get; init; }

    /// <summary>
    /// Market Claim Processing Status.
    /// </summary>
    [DisplayName("Market Claim Processing Status")]
    [IsoXmlTag("MktClmPrcgSts")]
    public required MarketClaimProcessingStatus1Choice_ MarketClaimProcessingStatus { get; init; }

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

// Since MarketClaimStatusAdviceV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MarketClaimStatusAdviceV03.
