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
/// This record is an implementation of the sese.027.001.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends an SecuritiesTransactionCancellationRequestStatusAdvice to an account owner to advise the status of a securities transaction cancellation request previously sent by the account owner.
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
///
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Description(
    @"Scope|An account servicer sends an SecuritiesTransactionCancellationRequestStatusAdvice to an account owner to advise the status of a securities transaction cancellation request previously sent by the account owner.|The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or|- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header."
)]
[IsoId("_78fdgSgVEeym1_Zp1BTvEw")]
[DisplayName("Securities Transaction Cancellation Request Status Advice V")]
public record SecuritiesTransactionCancellationRequestStatusAdviceV07 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.027.001.07";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesTxCxlReqStsAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.027.001.07";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Reference to the unambiguous identification of the cancellation request as per the account owner.
    /// </summary>
    [IsoId("_78fdkSgVEeym1_Zp1BTvEw")]
    [DisplayName("Cancellation Request Reference")]
    [IsoXmlTag("CxlReqRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text CancellationRequestReference { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction as known by the account servicer.
    /// </summary>
    [IsoId("_78fdkygVEeym1_Zp1BTvEw")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public TransactionIdentifications48? TransactionIdentification { get; init; }

    /// <summary>
    /// Provides details on the processing status of the request.
    /// </summary>
    [IsoId("_78fdlSgVEeym1_Zp1BTvEw")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public required ProcessingStatus84Choice_ ProcessingStatus { get; init; }

    /// <summary>
    /// Identifies the details of the transaction.
    /// </summary>
    [IsoId("_78fdlygVEeym1_Zp1BTvEw")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public TransactionDetails152? TransactionDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_78fdmSgVEeym1_Zp1BTvEw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since SecuritiesTransactionCancellationRequestStatusAdviceV07Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesTransactionCancellationRequestStatusAdviceV07.
