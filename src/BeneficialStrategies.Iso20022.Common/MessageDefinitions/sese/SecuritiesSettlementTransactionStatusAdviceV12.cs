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
/// This record is an implementation of the sese.024.001.12 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends a SecuritiesSettlementTransactionStatusAdvice to an account owner to advise the status of a securities settlement transaction instruction previously sent by the account owner or the status of a settlement transaction existing in the books of the servicer for the account of the owner. The status may be a processing, pending processing, internal matching, matching and/or settlement status.
/// The status advice may be sent as a response to the request of the account owner or not.
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
///
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.
/// </summary>
[Description(
    @"Scope|An account servicer sends a SecuritiesSettlementTransactionStatusAdvice to an account owner to advise the status of a securities settlement transaction instruction previously sent by the account owner or the status of a settlement transaction existing in the books of the servicer for the account of the owner. The status may be a processing, pending processing, internal matching, matching and/or settlement status.|The status advice may be sent as a response to the request of the account owner or not.|The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or|- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header."
)]
[IsoId("_jqCc4SW9EeygjNFjAlVoPA")]
[DisplayName("Securities Settlement Transaction Status Advice V")]
public record SecuritiesSettlementTransactionStatusAdviceV12 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.024.001.12";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmTxStsAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.024.001.12";

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
    [IsoId("_jqCc-yW9EeygjNFjAlVoPA")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifications47 TransactionIdentification { get; init; }

    /// <summary>
    /// Link to another transaction - provided for information only.
    /// </summary>
    [IsoId("_jqCc_SW9EeygjNFjAlVoPA")]
    [DisplayName("Linkages")]
    [IsoXmlTag("Lnkgs")]
    public Linkages41? Linkages { get; init; }

    /// <summary>
    /// Provides details on the processing status of the transaction.
    /// </summary>
    [IsoId("_jqCc_yW9EeygjNFjAlVoPA")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ProcessingStatus88Choice_? ProcessingStatus { get; init; }

    /// <summary>
    /// Provides the matching status of an instruction as per the account servicer based on an allegement. At this time no matching took place on the market (at the CSD/ICSD).
    /// </summary>
    [IsoId("_jqCdASW9EeygjNFjAlVoPA")]
    [DisplayName("Inferred Matching Status")]
    [IsoXmlTag("IfrrdMtchgSts")]
    public MatchingStatus24Choice_? InferredMatchingStatus { get; init; }

    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("_jqCdAyW9EeygjNFjAlVoPA")]
    [DisplayName("Matching Status")]
    [IsoXmlTag("MtchgSts")]
    public MatchingStatus24Choice_? MatchingStatus { get; init; }

    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [IsoId("_jqCdBSW9EeygjNFjAlVoPA")]
    [DisplayName("Settlement Status")]
    [IsoXmlTag("SttlmSts")]
    public SettlementStatus30Choice_? SettlementStatus { get; init; }

    /// <summary>
    /// Identifies the details of the transaction.
    /// </summary>
    [IsoId("_jqCdByW9EeygjNFjAlVoPA")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public TransactionDetails148? TransactionDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jqCdCSW9EeygjNFjAlVoPA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since SecuritiesSettlementTransactionStatusAdviceV12Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesSettlementTransactionStatusAdviceV12.
