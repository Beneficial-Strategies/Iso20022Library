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
/// This record is an implementation of the seev.044.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends the CorporateActionMovementPreliminaryAdviceCancellationAdvice message to an account owner or its designated agent to cancel a previously announced CorporateActionMovementPreliminaryAdvice.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),
/// using the relevant elements in the business application header (BAH).
/// </summary>
[Description(
    @"Scope|An account servicer sends the CorporateActionMovementPreliminaryAdviceCancellationAdvice message to an account owner or its designated agent to cancel a previously announced CorporateActionMovementPreliminaryAdvice.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),|using the relevant elements in the business application header (BAH)."
)]
[IsoId("_65NzmZSbEeeh5JjedkaA_g")]
[DisplayName("Corporate Action Movement Preliminary Advice Cancellation Advice V")]
public record CorporateActionMovementPreliminaryAdviceCancellationAdviceV08 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.044.001.08";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnMvmntPrlimryAdvcCxlAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.044.001.08";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identification of a previously sent movement preliminary advice document.
    /// </summary>
    [IsoId("_65Nzm5SbEeeh5JjedkaA_g")]
    [DisplayName("Movement Preliminary Advice Identification")]
    [IsoXmlTag("MvmntPrlimryAdvcId")]
    public required DocumentIdentification31 MovementPreliminaryAdviceIdentification { get; init; }

    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_65NznZSbEeeh5JjedkaA_g")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionGeneralInformation127 CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// General information about the safekeeping account and the account owner.
    /// </summary>
    [IsoId("_65Nzn5SbEeeh5JjedkaA_g")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required AccountIdentification29Choice_ AccountDetails { get; init; }

    /// <summary>
    /// Information about the corporate action event.
    /// </summary>
    [IsoId("_65NzoZSbEeeh5JjedkaA_g")]
    [DisplayName("Corporate Action Details")]
    [IsoXmlTag("CorpActnDtls")]
    public CorporateAction45? CorporateActionDetails { get; init; }

    /// <summary>
    /// Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.
    /// </summary>
    [IsoId("_65Nzo5SbEeeh5JjedkaA_g")]
    [DisplayName("Issuer Agent")]
    [IsoXmlTag("IssrAgt")]
    public PartyIdentification71Choice_? IssuerAgent { get; init; }

    /// <summary>
    /// Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_65NzpZSbEeeh5JjedkaA_g")]
    [DisplayName("Paying Agent")]
    [IsoXmlTag("PngAgt")]
    public PartyIdentification71Choice_? PayingAgent { get; init; }

    /// <summary>
    /// Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_65Nzp5SbEeeh5JjedkaA_g")]
    [DisplayName("Sub Paying Agent")]
    [IsoXmlTag("SubPngAgt")]
    public PartyIdentification71Choice_? SubPayingAgent { get; init; }

    /// <summary>
    /// Party/agent responsible for maintaining the register of a security.
    /// </summary>
    [IsoId("_65NzqZSbEeeh5JjedkaA_g")]
    [DisplayName("Registrar")]
    [IsoXmlTag("Regar")]
    public PartyIdentification71Choice_? Registrar { get; init; }

    /// <summary>
    /// A broker-dealer responsible for reselling to new investors securities (usually bonds) that have been tendered for purchase by their owner.
    /// </summary>
    [IsoId("_65Nzq5SbEeeh5JjedkaA_g")]
    [DisplayName("Reselling Agent")]
    [IsoXmlTag("RsellngAgt")]
    public PartyIdentification71Choice_? ResellingAgent { get; init; }

    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to accept presentations of instruments, usually bonds, for transfer and or exchange.
    /// </summary>
    [IsoId("_65NzrZSbEeeh5JjedkaA_g")]
    [DisplayName("Physical Securities Agent")]
    [IsoXmlTag("PhysSctiesAgt")]
    public PartyIdentification71Choice_? PhysicalSecuritiesAgent { get; init; }

    /// <summary>
    /// A trust company, bank or similar financial institution that acts on behalf of an out-of-town agent or event agent where securities can be delivered in person.
    /// </summary>
    [IsoId("_65Nzr5SbEeeh5JjedkaA_g")]
    [DisplayName("Drop Agent")]
    [IsoXmlTag("DrpAgt")]
    public PartyIdentification71Choice_? DropAgent { get; init; }

    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to maintain records of investors and account balances and transactions for the consent of a material change.
    /// </summary>
    [IsoId("_65NzsZSbEeeh5JjedkaA_g")]
    [DisplayName("Solicitation Agent")]
    [IsoXmlTag("SlctnAgt")]
    public PartyIdentification71Choice_? SolicitationAgent { get; init; }

    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an Issuer to provide information and copies of the offering documentation.
    /// </summary>
    [IsoId("_65Nzs5SbEeeh5JjedkaA_g")]
    [DisplayName("Information Agent")]
    [IsoXmlTag("InfAgt")]
    public PartyIdentification71Choice_? InformationAgent { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_65NztZSbEeeh5JjedkaA_g")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since CorporateActionMovementPreliminaryAdviceCancellationAdviceV08Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CorporateActionMovementPreliminaryAdviceCancellationAdviceV08.
