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
/// This record is an implementation of the seev.037.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends the CorporateActionMovementReversalAdvice message to an account owner or its designated agent to reverse previously confirmed posting of securities or cash.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate).|ISO 15022 - 20022 COEXISTENCE|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// </summary>
[Description(
    @"Scope|An account servicer sends the CorporateActionMovementReversalAdvice message to an account owner or its designated agent to reverse previously confirmed posting of securities or cash.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate).|ISO 15022 - 20022 COEXISTENCE|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”."
)]
[IsoId("_Tfxz_tEwEd-BzquC8wXy7w_-2083816174")]
[DisplayName("Corporate Action Movement Reversal Advice V")]
public record CorporateActionMovementReversalAdviceV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.037.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnMvmntRvslAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.037.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Information that unambiguously identifies a CorporateActionMovementReversalAdvice message as know by the account servicer.
    /// </summary>
    [IsoId("_Tfxz_9EwEd-BzquC8wXy7w_-995876600")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DocumentIdentification11 Identification { get; init; }

    /// <summary>
    /// Identification of a previously sent movement confirmation document.
    /// </summary>
    [IsoId("_Tfx0ANEwEd-BzquC8wXy7w_-901677518")]
    [DisplayName("Movement Confirmation Identification")]
    [IsoXmlTag("MvmntConfId")]
    public required DocumentIdentification15 MovementConfirmationIdentification { get; init; }

    /// <summary>
    /// Identification of other documents as well as the document number.
    /// </summary>
    [IsoId("_Tf7k8NEwEd-BzquC8wXy7w_-442684873")]
    [DisplayName("Other Document Identification")]
    [IsoXmlTag("OthrDocId")]
    public DocumentIdentification13? OtherDocumentIdentification { get; init; }

    /// <summary>
    /// Identification of an other corporate action event that needs to be closely linked to the processing of the event notified in this document.
    /// </summary>
    [IsoId("_Tf7k8dEwEd-BzquC8wXy7w_100077356")]
    [DisplayName("Events Linkage")]
    [IsoXmlTag("EvtsLkg")]
    public CorporateActionEventReference1? EventsLinkage { get; init; }

    /// <summary>
    /// Reason for the reversal.
    /// </summary>
    [IsoId("_Tf7k8tEwEd-BzquC8wXy7w_-2117806404")]
    [DisplayName("Reversal Reason")]
    [IsoXmlTag("RvslRsn")]
    public CorporateActionReversalReason1? ReversalReason { get; init; }

    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_Tf7k89EwEd-BzquC8wXy7w_205358419")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionGeneralInformation4 CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// General information about the safekeeping account, owner and account balance.
    /// </summary>
    [IsoId("_Tf7k9NEwEd-BzquC8wXy7w_357742721")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required AccountAndBalance4 AccountDetails { get; init; }

    /// <summary>
    /// Information about the corporate action option.
    /// </summary>
    [IsoId("_Tf7k9dEwEd-BzquC8wXy7w_1547234386")]
    [DisplayName("Corporate Action Confirmation Details")]
    [IsoXmlTag("CorpActnConfDtls")]
    public required CorporateActionOption12 CorporateActionConfirmationDetails { get; init; }

    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_Tf7k9tEwEd-BzquC8wXy7w_1259424777")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative4? AdditionalInformation { get; init; }

    /// <summary>
    /// Party that originated the message, if other than the sender.
    /// </summary>
    [IsoId("_Tf7k99EwEd-BzquC8wXy7w_1376711953")]
    [DisplayName("Message Originator")]
    [IsoXmlTag("MsgOrgtr")]
    public PartyIdentification10Choice_? MessageOriginator { get; init; }

    /// <summary>
    /// Party that is the final destination of the message, if other than the receiver.
    /// </summary>
    [IsoId("_Tf7k-NEwEd-BzquC8wXy7w_1608518050")]
    [DisplayName("Message Recipient")]
    [IsoXmlTag("MsgRcpt")]
    public PartyIdentification10Choice_? MessageRecipient { get; init; }

    /// <summary>
    /// Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.
    /// </summary>
    [IsoId("_TgFV8NEwEd-BzquC8wXy7w_1693481006")]
    [DisplayName("Issuer Agent")]
    [IsoXmlTag("IssrAgt")]
    public PartyIdentification10Choice_? IssuerAgent { get; init; }

    /// <summary>
    /// Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_TgFV8dEwEd-BzquC8wXy7w_1759051368")]
    [DisplayName("Paying Agent")]
    [IsoXmlTag("PngAgt")]
    public PartyIdentification10Choice_? PayingAgent { get; init; }

    /// <summary>
    /// Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_TgFV8tEwEd-BzquC8wXy7w_2048111600")]
    [DisplayName("Sub Paying Agent")]
    [IsoXmlTag("SubPngAgt")]
    public PartyIdentification10Choice_? SubPayingAgent { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_TgFV89EwEd-BzquC8wXy7w_2122918303")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension2? Extension { get; init; }
}

// Since CorporateActionMovementReversalAdviceV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CorporateActionMovementReversalAdviceV01.
