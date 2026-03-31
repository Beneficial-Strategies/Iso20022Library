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
/// This record is an implementation of the seev.039.002.10 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CorporateActionCancellationAdvice message is sent by an account servicer to an account owner or its designated agent to cancel a previously announced corporate action event in case of error from the account servicer or in case of withdrawal by the issuer.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).
/// </summary>
[Description(
    @"Scope|The CorporateActionCancellationAdvice message is sent by an account servicer to an account owner or its designated agent to cancel a previously announced corporate action event in case of error from the account servicer or in case of withdrawal by the issuer.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH)."
)]
[IsoId("_A0QpcwVREeqjd8n6wD9JVw")]
[DisplayName("Corporate Action Cancellation Advice 002 V")]
public record CorporateActionCancellationAdvice002V10 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.039.002.10";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnCxlAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.039.002.10";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// General information about the event cancellation status and cancellation reason.
    /// </summary>
    [IsoId("_A0QpdwVREeqjd8n6wD9JVw")]
    [DisplayName("Cancellation Advice General Information")]
    [IsoXmlTag("CxlAdvcGnlInf")]
    public required CorporateActionCancellation4 CancellationAdviceGeneralInformation { get; init; }

    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_A0QpeQVREeqjd8n6wD9JVw")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionGeneralInformation143 CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// General information about the safekeeping account and the account owner.
    /// </summary>
    [IsoId("_A0QpewVREeqjd8n6wD9JVw")]
    [DisplayName("Accounts Details")]
    [IsoXmlTag("AcctsDtls")]
    public required AccountIdentification43Choice_ AccountsDetails { get; init; }

    /// <summary>
    /// Information about the corporate action event.
    /// </summary>
    [IsoId("_A0QpfQVREeqjd8n6wD9JVw")]
    [DisplayName("Corporate Action Details")]
    [IsoXmlTag("CorpActnDtls")]
    public CorporateAction46? CorporateActionDetails { get; init; }

    /// <summary>
    /// Provides additional information or specifies in more detail the content of a message. This field may only be used when the information to be transmitted, cannot be coded.
    /// </summary>
    [IsoId("_A0QpfwVREeqjd8n6wD9JVw")]
    [DisplayName("Additional Text")]
    [IsoXmlTag("AddtlTxt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINZMax8000Text)]
    [StringLength(maximumLength: 8000, MinimumLength = 1)]
    public IsoRestrictedFINZMax8000Text? AdditionalText { get; init; }

    /// <summary>
    /// Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.
    /// </summary>
    [IsoId("_A0QpgQVREeqjd8n6wD9JVw")]
    [DisplayName("Issuer Agent")]
    [IsoXmlTag("IssrAgt")]
    public PartyIdentification137Choice_? IssuerAgent { get; init; }

    /// <summary>
    /// Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_A0QpgwVREeqjd8n6wD9JVw")]
    [DisplayName("Paying Agent")]
    [IsoXmlTag("PngAgt")]
    public PartyIdentification137Choice_? PayingAgent { get; init; }

    /// <summary>
    /// Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_A0QphQVREeqjd8n6wD9JVw")]
    [DisplayName("Sub Paying Agent")]
    [IsoXmlTag("SubPngAgt")]
    public PartyIdentification137Choice_? SubPayingAgent { get; init; }

    /// <summary>
    /// Party/agent responsible for maintaining the register of a security.
    /// </summary>
    [IsoId("_A0QphwVREeqjd8n6wD9JVw")]
    [DisplayName("Registrar")]
    [IsoXmlTag("Regar")]
    public PartyIdentification137Choice_? Registrar { get; init; }

    /// <summary>
    /// A broker-dealer responsible for reselling to new investors securities (usually bonds) that have been tendered for purchase by their owner.
    /// </summary>
    [IsoId("_A0QpiQVREeqjd8n6wD9JVw")]
    [DisplayName("Reselling Agent")]
    [IsoXmlTag("RsellngAgt")]
    public PartyIdentification137Choice_? ResellingAgent { get; init; }

    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to accept presentations of instruments, usually bonds, for transfer and or exchange.
    /// </summary>
    [IsoId("_A0QpiwVREeqjd8n6wD9JVw")]
    [DisplayName("Physical Securities Agent")]
    [IsoXmlTag("PhysSctiesAgt")]
    public PartyIdentification137Choice_? PhysicalSecuritiesAgent { get; init; }

    /// <summary>
    /// A trust company, bank or similar financial institution that acts on behalf of an out-of-town agent or event agent where securities can be delivered in person.
    /// </summary>
    [IsoId("_A0QpjQVREeqjd8n6wD9JVw")]
    [DisplayName("Drop Agent")]
    [IsoXmlTag("DrpAgt")]
    public PartyIdentification137Choice_? DropAgent { get; init; }

    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to maintain records of investors and account balances and transactions for the consent of a material change.
    /// </summary>
    [IsoId("_A0QpjwVREeqjd8n6wD9JVw")]
    [DisplayName("Solicitation Agent")]
    [IsoXmlTag("SlctnAgt")]
    public PartyIdentification137Choice_? SolicitationAgent { get; init; }

    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an Issuer to provide information and copies of the offering documentation.
    /// </summary>
    [IsoId("_A0QpkQVREeqjd8n6wD9JVw")]
    [DisplayName("Information Agent")]
    [IsoXmlTag("InfAgt")]
    public PartyIdentification137Choice_? InformationAgent { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_A0QpkwVREeqjd8n6wD9JVw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since CorporateActionCancellationAdvice002V10Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CorporateActionCancellationAdvice002V10.
