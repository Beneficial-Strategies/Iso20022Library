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
/// This record is an implementation of the seev.051.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope and Usage
/// The MarketClaimCancellationRequest message is sent by the account holder to the account servicer.
/// It is sent to request the cancellation of a market claim transaction.
/// This message definition is intended for use with the Business Application Header (BAH).
/// </summary>
[Description(
    @"Scope and Usage|The MarketClaimCancellationRequest message is sent by the account holder to the account servicer. |It is sent to request the cancellation of a market claim transaction.|This message definition is intended for use with the Business Application Header (BAH)."
)]
[IsoId("_mmNNYNsFEeqmdMJWobugpw")]
[DisplayName("Market Claim Cancellation Request V")]
public record MarketClaimCancellationRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.051.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MktClmCxlReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.051.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identification of the related market claim creation document for which the cancellation is requested.
    /// </summary>
    [IsoId("_AiUsoNxwEeqmdMJWobugpw")]
    [DisplayName("Market Claim Creation Identification")]
    [IsoXmlTag("MktClmCreId")]
    public required DocumentIdentification9 MarketClaimCreationIdentification { get; init; }

    /// <summary>
    /// References of the market claim for which cancellation is requested.
    /// </summary>
    [IsoId("_Iu5sgtxwEeqmdMJWobugpw")]
    [DisplayName("Transaction Reference")]
    [IsoXmlTag("TxRef")]
    public required References26 TransactionReference { get; init; }

    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_zo9YEtxwEeqmdMJWobugpw")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionGeneralInformation157 CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// General information about the safekeeping account, owner and account balance.
    /// </summary>
    [IsoId("_zo9YE9xwEeqmdMJWobugpw")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required AccountIdentification46 AccountDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_QtiwUSgaEeuYwc3diVMizA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since MarketClaimCancellationRequestV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MarketClaimCancellationRequestV01.
