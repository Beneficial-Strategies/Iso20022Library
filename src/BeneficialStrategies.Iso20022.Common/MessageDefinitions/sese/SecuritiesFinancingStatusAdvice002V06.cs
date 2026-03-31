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

namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.034.002.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An securities financing transaction account servicer sends a SecuritiesFinancingStatusAdvice to an account owner to advise the status of a securities financing transaction previously instructed by the account owner.
/// The status advice may be sent as a response to the request of the account owner or not.
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure managing securities financing transactions on behalf of their participants
/// - an agent (sub-custodian) managing securities financing transactions on behalf of their global custodian customer, or
/// - a custodian managing securities financing transactions on behalf of an investment management institution or a broker/dealer.
///
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Description(
    @"Scope|An securities financing transaction account servicer sends a SecuritiesFinancingStatusAdvice to an account owner to advise the status of a securities financing transaction previously instructed by the account owner.|The status advice may be sent as a response to the request of the account owner or not.|The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure managing securities financing transactions on behalf of their participants|- an agent (sub-custodian) managing securities financing transactions on behalf of their global custodian customer, or|- a custodian managing securities financing transactions on behalf of an investment management institution or a broker/dealer.||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header."
)]
[IsoId("_6BE0I5NLEeWGlc8L7oPDIg")]
[DisplayName("Securities Financing Status Advice 002 V")]
public record SecuritiesFinancingStatusAdvice002V06 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.034.002.06";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesFincgStsAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.034.002.06";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Provides unambiguous transaction identification information.
    /// </summary>
    [IsoId("_6BE0J5NLEeWGlc8L7oPDIg")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifications35 TransactionIdentification { get; init; }

    /// <summary>
    /// Processing status of the transaction.
    /// </summary>
    [IsoId("_6BE0KZNLEeWGlc8L7oPDIg")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ProcessingStatus57Choice_? ProcessingStatus { get; init; }

    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("_6BE0K5NLEeWGlc8L7oPDIg")]
    [DisplayName("Matching Status")]
    [IsoXmlTag("MtchgSts")]
    public MatchingStatus29Choice_? MatchingStatus { get; init; }

    /// <summary>
    /// Provides the matching status of an instruction as per the account servicer based on an allegement. At this time no matching took place on the market (at the CSD/ICSD).
    /// </summary>
    [IsoId("_6BE0LZNLEeWGlc8L7oPDIg")]
    [DisplayName("Inferred Matching Status")]
    [IsoXmlTag("IfrrdMtchgSts")]
    public MatchingStatus29Choice_? InferredMatchingStatus { get; init; }

    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [IsoId("_6BE0L5NLEeWGlc8L7oPDIg")]
    [DisplayName("Settlement Status")]
    [IsoXmlTag("SttlmSts")]
    public SettlementStatus21Choice_? SettlementStatus { get; init; }

    /// <summary>
    /// Provides the status of the repurchase agreement call request.
    /// </summary>
    [IsoId("_6BE0MZNLEeWGlc8L7oPDIg")]
    [DisplayName("Repo Call Request Status")]
    [IsoXmlTag("RepoCallReqSts")]
    public RepoCallRequestStatus9Choice_? RepoCallRequestStatus { get; init; }

    /// <summary>
    /// Identifies the details of the transaction.
    /// </summary>
    [IsoId("_6BE0M5NLEeWGlc8L7oPDIg")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public SecuritiesFinancingTransactionDetails33? TransactionDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_6BE0NZNLEeWGlc8L7oPDIg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since SecuritiesFinancingStatusAdvice002V06Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesFinancingStatusAdvice002V06.
