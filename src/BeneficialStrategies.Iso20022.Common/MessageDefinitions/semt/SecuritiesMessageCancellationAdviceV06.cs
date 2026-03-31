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

namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// This record is an implementation of the semt.020.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends a SecuritiesMessageCancellationAdvice to an account owner to inform of the cancellation of a securities message previously sent by an account servicer.
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
///
/// Usage
/// The previously sent message may be:
/// - a securities settlement transaction confirmation
/// - a report (transactions, pending transactions, allegements, accounting and custody securities balance)
/// - a allegement notification (when sent by mistake or because the counterparty cancelled its instruction)
/// - a portfolio transfer notification
/// - an intra-position movement confirmation
/// - a transaction generation notification
///
/// The previously sent message cannot be a status advice message (any). If a status advice should not have been sent, a new status advice with the correct status should be sent, not a cancellation advice.
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Description(
    @"Scope|An account servicer sends a SecuritiesMessageCancellationAdvice to an account owner to inform of the cancellation of a securities message previously sent by an account servicer. |The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or |- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|The previously sent message may be:|- a securities settlement transaction confirmation|- a report (transactions, pending transactions, allegements, accounting and custody securities balance)|- a allegement notification (when sent by mistake or because the counterparty cancelled its instruction)|- a portfolio transfer notification |- an intra-position movement confirmation|- a transaction generation notification||The previously sent message cannot be a status advice message (any). If a status advice should not have been sent, a new status advice with the correct status should be sent, not a cancellation advice.|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header."
)]
[IsoId("_d30QMQmEEeuQ1MenzX1l-g")]
[DisplayName("Securities Message Cancellation Advice V")]
public record SecuritiesMessageCancellationAdviceV06 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.020.001.06";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesMsgCxlAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.020.001.06";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Reference to the message advised to be cancelled by the account servicer.
    /// </summary>
    [IsoId("_d30QNwmEEeuQ1MenzX1l-g")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References69Choice_ Reference { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_d30QOQmEEeuQ1MenzX1l-g")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification144? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_d30QOwmEEeuQ1MenzX1l-g")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public required SecuritiesAccount19 SafekeepingAccount { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_d30QPQmEEeuQ1MenzX1l-g")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since SecuritiesMessageCancellationAdviceV06Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesMessageCancellationAdviceV06.
