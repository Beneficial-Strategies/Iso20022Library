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
/// This record is an implementation of the semt.020.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope|An account servicer sends a SecuritiesMessageCancellationAdvice to an account owner to inform of the cancellation of a securities message previously sent by an account servicer. |The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or |- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|The previously sent message may be:|- a securities settlement transaction confirmation|- a report (transactions, pending transactions, allegements, accounting and custody securities balance)|- a allegement notification (when sent by mistake or because the counterparty cancelled its instruction)|- a portfolio transfer notification |- an intra-position movement confirmation|- a transaction generation notification|The previously sent message cannot be a status advice message (any). If a status advice should not have been sent, a new status advice with the correct status should be sent, not a cancellation advice.|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header.||ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// </summary>
[Description(
    @"Scope|An account servicer sends a SecuritiesMessageCancellationAdvice to an account owner to inform of the cancellation of a securities message previously sent by an account servicer. |The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or |- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|The previously sent message may be:|- a securities settlement transaction confirmation|- a report (transactions, pending transactions, allegements, accounting and custody securities balance)|- a allegement notification (when sent by mistake or because the counterparty cancelled its instruction)|- a portfolio transfer notification |- an intra-position movement confirmation|- a transaction generation notification|The previously sent message cannot be a status advice message (any). If a status advice should not have been sent, a new status advice with the correct status should be sent, not a cancellation advice.|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header.||ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”."
)]
[IsoId("_HyRSsQx0EeKMmbvHOtE4SA")]
[DisplayName("Securities Message Cancellation Advice V")]
public record SecuritiesMessageCancellationAdviceV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.020.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesMsgCxlAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.020.001.04";

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
    [IsoId("_HyRSuwx0EeKMmbvHOtE4SA")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References37Choice_ Reference { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_HyRSvwx0EeKMmbvHOtE4SA")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification36Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_HyRSwwx0EeKMmbvHOtE4SA")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public required SecuritiesAccount13 SafekeepingAccount { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_HyRSxwx0EeKMmbvHOtE4SA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since SecuritiesMessageCancellationAdviceV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesMessageCancellationAdviceV04.
