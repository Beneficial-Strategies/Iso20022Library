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
/// This record is an implementation of the seev.044.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends the CorporateActionMovementPreliminaryAdviceCancellationAdvice message to an account owner or its designated agent to cancel a previously announced CorporateActionMovementPreliminaryAdvice.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),
/// using the relevant elements in the business application header (BAH).|ISO 15022 - 20022 COEXISTENCE|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// </summary>
[Description(
    @"Scope|An account servicer sends the CorporateActionMovementPreliminaryAdviceCancellationAdvice message to an account owner or its designated agent to cancel a previously announced CorporateActionMovementPreliminaryAdvice.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),|using the relevant elements in the business application header (BAH).|ISO 15022 - 20022 COEXISTENCE|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”."
)]
[IsoId("_e0jdgfmOEeC_eLZALo-S0A")]
[DisplayName("Corporate Action Movement Preliminary Advice Cancellation Advice V")]
public record CorporateActionMovementPreliminaryAdviceCancellationAdviceV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.044.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnMvmntPrlimryAdvcCxlAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.044.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Specifies the status of the details of the event.
    /// </summary>
    [IsoId("_e0jdjfmOEeC_eLZALo-S0A")]
    [DisplayName("Cancellation Advice General Information")]
    [IsoXmlTag("CxlAdvcGnlInf")]
    public required CorporateActionProcessingStatus1Choice_ CancellationAdviceGeneralInformation { get; init; }

    /// <summary>
    /// Identification of a previously sent movement preliminary advice document.
    /// </summary>
    [IsoId("_e0jdkfmOEeC_eLZALo-S0A")]
    [DisplayName("Movement Preliminary Advice Identification")]
    [IsoXmlTag("MvmntPrlimryAdvcId")]
    public required DocumentIdentification15 MovementPreliminaryAdviceIdentification { get; init; }

    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_e0jdlfmOEeC_eLZALo-S0A")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionGeneralInformation35 CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// General information about the safekeeping account and the account owner.
    /// </summary>
    [IsoId("_e0jdmfmOEeC_eLZALo-S0A")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required AccountIdentification13Choice_ AccountDetails { get; init; }

    /// <summary>
    /// Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.
    /// </summary>
    [IsoId("_e0jdnfmOEeC_eLZALo-S0A")]
    [DisplayName("Issuer Agent")]
    [IsoXmlTag("IssrAgt")]
    public PartyIdentification46Choice_? IssuerAgent { get; init; }

    /// <summary>
    /// Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_e0jdofmOEeC_eLZALo-S0A")]
    [DisplayName("Paying Agent")]
    [IsoXmlTag("PngAgt")]
    public PartyIdentification46Choice_? PayingAgent { get; init; }

    /// <summary>
    /// Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_e0jdpfmOEeC_eLZALo-S0A")]
    [DisplayName("Sub Paying Agent")]
    [IsoXmlTag("SubPngAgt")]
    public PartyIdentification46Choice_? SubPayingAgent { get; init; }

    /// <summary>
    /// Party/agent responsible for maintaining the register of a security.
    /// </summary>
    [IsoId("_e0jdqfmOEeC_eLZALo-S0A")]
    [DisplayName("Registrar")]
    [IsoXmlTag("Regar")]
    public PartyIdentification46Choice_? Registrar { get; init; }

    /// <summary>
    /// A broker-dealer responsible for reselling to new investors securities (usually bonds) that have been tendered for purchase by their owner.
    /// </summary>
    [IsoId("_e0jdrfmOEeC_eLZALo-S0A")]
    [DisplayName("Reselling Agent")]
    [IsoXmlTag("RsellngAgt")]
    public PartyIdentification46Choice_? ResellingAgent { get; init; }

    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to accept presentations of instruments, usually bonds, for transfer and or exchange.
    /// </summary>
    [IsoId("_e0jdsfmOEeC_eLZALo-S0A")]
    [DisplayName("Physical Securities Agent")]
    [IsoXmlTag("PhysSctiesAgt")]
    public PartyIdentification46Choice_? PhysicalSecuritiesAgent { get; init; }

    /// <summary>
    /// A trust company, bank or similar financial institution who acts on behalf of an out of town agent or event agent where securities can be delivered in person.
    /// </summary>
    [IsoId("_e0jdtfmOEeC_eLZALo-S0A")]
    [DisplayName("Drop Agent")]
    [IsoXmlTag("DrpAgt")]
    public PartyIdentification46Choice_? DropAgent { get; init; }

    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to maintain records of investors and account balances and transactions for the consent of a material change.
    /// </summary>
    [IsoId("_e0jdufmOEeC_eLZALo-S0A")]
    [DisplayName("Solicitation Agent")]
    [IsoXmlTag("SlctnAgt")]
    public PartyIdentification46Choice_? SolicitationAgent { get; init; }

    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an Issuer to provide information and copies of the offering documentation.
    /// </summary>
    [IsoId("_e0jdvfmOEeC_eLZALo-S0A")]
    [DisplayName("Information Agent")]
    [IsoXmlTag("InfAgt")]
    public PartyIdentification46Choice_? InformationAgent { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_e0jdwfmOEeC_eLZALo-S0A")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since CorporateActionMovementPreliminaryAdviceCancellationAdviceV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CorporateActionMovementPreliminaryAdviceCancellationAdviceV03.
