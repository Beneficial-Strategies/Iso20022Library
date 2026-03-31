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
/// This record is an implementation of the sese.039.002.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends a SecuritiesSettlementTransactionModificationRequestStatusAdvice to an account owner to advise the status of a SecuritiesSettlementTransactionModificationRequest message previously sent by the account owner.
/// The account servicer may be:
/// - a central securities depository or another settlement market infrastructure managing securities settlement transactions on behalf of their participants
/// - an custodian acting as an accounting and/or settlement agent.
///
/// Usage
/// The message may also be used to:
/// - re-send a message sent by the account owner to the account servicer,
/// - provide a third party with a copy of a message being sent by the account owner for information,
/// - re-send to a third party a copy of a message being sent by the account owner for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Description(
    @"Scope|An account servicer sends a SecuritiesSettlementTransactionModificationRequestStatusAdvice to an account owner to advise the status of a SecuritiesSettlementTransactionModificationRequest message previously sent by the account owner.|The account servicer may be:|- a central securities depository or another settlement market infrastructure managing securities settlement transactions on behalf of their participants|- an custodian acting as an accounting and/or settlement agent.||Usage|The message may also be used to:|- re-send a message sent by the account owner to the account servicer,|- provide a third party with a copy of a message being sent by the account owner for information,|- re-send to a third party a copy of a message being sent by the account owner for information|using the relevant elements in the Business Application Header."
)]
[IsoId("_Tf3IMyAdEeuyDZ-ukt4YRg")]
[DisplayName("Securities Settlement Transaction Modification Request Status Advice 002 V")]
public record SecuritiesSettlementTransactionModificationRequestStatusAdvice002V05 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.039.002.05";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmTxModReqStsAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.039.002.05";

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
    [IsoId("_Tf3INSAdEeuyDZ-ukt4YRg")]
    [DisplayName("Modification Request Reference")]
    [IsoXmlTag("ModReqRef")]
    public required Identification16 ModificationRequestReference { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_Tf3INyAdEeuyDZ-ukt4YRg")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification156? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_Tf3IOSAdEeuyDZ-ukt4YRg")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public required SecuritiesAccount30 SafekeepingAccount { get; init; }

    /// <summary>
    /// Provides unambiguous transaction identification information.
    /// </summary>
    [IsoId("_Tf3IOyAdEeuyDZ-ukt4YRg")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public TransactionIdentifications37? TransactionIdentification { get; init; }

    /// <summary>
    /// Provides details on the processing status of the request.
    /// </summary>
    [IsoId("_Tf3IPSAdEeuyDZ-ukt4YRg")]
    [DisplayName("Modification Processing Status")]
    [IsoXmlTag("ModPrcgSts")]
    public required ModificationProcessingStatus8Choice_ ModificationProcessingStatus { get; init; }

    /// <summary>
    /// Identifies the details of the transaction.
    /// </summary>
    [IsoId("_Tf3IPyAdEeuyDZ-ukt4YRg")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public TransactionDetails141? TransactionDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Tf3IQSAdEeuyDZ-ukt4YRg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since SecuritiesSettlementTransactionModificationRequestStatusAdvice002V05Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesSettlementTransactionModificationRequestStatusAdvice002V05.
