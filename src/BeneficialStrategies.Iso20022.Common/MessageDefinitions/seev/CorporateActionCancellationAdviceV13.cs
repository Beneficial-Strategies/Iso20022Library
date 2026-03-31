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
/// This record is an implementation of the seev.039.001.13 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_4bkDGX_4Ee-h086v0qPiyQ")]
[DisplayName("Corporate Action Cancellation Advice V13")]
public record CorporateActionCancellationAdviceV13 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.039.001.13";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnCxlAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.039.001.13";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Accounts Details.
    /// </summary>
    [DisplayName("Accounts Details")]
    [IsoXmlTag("AcctsDtls")]
    public required AccountIdentification73Choice_ AccountsDetails { get; init; }

    /// <summary>
    /// Additional Text.
    /// </summary>
    [DisplayName("Additional Text")]
    [IsoXmlTag("AddtlTxt")]
    public ValueList<IsoMax8000Text> AdditionalText { get; init; } = [];

    /// <summary>
    /// Cancellation Advice General Information.
    /// </summary>
    [DisplayName("Cancellation Advice General Information")]
    [IsoXmlTag("CxlAdvcGnlInf")]
    public required CorporateActionCancellation3 CancellationAdviceGeneralInformation { get; init; }

    /// <summary>
    /// Corporate Action Details.
    /// </summary>
    [DisplayName("Corporate Action Details")]
    [IsoXmlTag("CorpActnDtls")]
    public CorporateAction72? CorporateActionDetails { get; init; }

    /// <summary>
    /// Corporate Action General Information.
    /// </summary>
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionGeneralInformation174 CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// Drop Agent.
    /// </summary>
    [DisplayName("Drop Agent")]
    [IsoXmlTag("DrpAgt")]
    public PartyIdentification120Choice_? DropAgent { get; init; }

    /// <summary>
    /// Information Agent.
    /// </summary>
    [DisplayName("Information Agent")]
    [IsoXmlTag("InfAgt")]
    public PartyIdentification120Choice_? InformationAgent { get; init; }

    /// <summary>
    /// Issuer Agent.
    /// </summary>
    [DisplayName("Issuer Agent")]
    [IsoXmlTag("IssrAgt")]
    public ValueList<PartyIdentification120Choice_> IssuerAgent { get; init; } = [];

    /// <summary>
    /// Paying Agent.
    /// </summary>
    [DisplayName("Paying Agent")]
    [IsoXmlTag("PngAgt")]
    public ValueList<PartyIdentification120Choice_> PayingAgent { get; init; } = [];

    /// <summary>
    /// Physical Securities Agent.
    /// </summary>
    [DisplayName("Physical Securities Agent")]
    [IsoXmlTag("PhysSctiesAgt")]
    public PartyIdentification120Choice_? PhysicalSecuritiesAgent { get; init; }

    /// <summary>
    /// Registrar.
    /// </summary>
    [DisplayName("Registrar")]
    [IsoXmlTag("Regar")]
    public PartyIdentification120Choice_? Registrar { get; init; }

    /// <summary>
    /// Reselling Agent.
    /// </summary>
    [DisplayName("Reselling Agent")]
    [IsoXmlTag("RsellngAgt")]
    public ValueList<PartyIdentification120Choice_> ResellingAgent { get; init; } = [];

    /// <summary>
    /// Solicitation Agent.
    /// </summary>
    [DisplayName("Solicitation Agent")]
    [IsoXmlTag("SlctnAgt")]
    public ValueList<PartyIdentification120Choice_> SolicitationAgent { get; init; } = [];

    /// <summary>
    /// Sub Paying Agent.
    /// </summary>
    [DisplayName("Sub Paying Agent")]
    [IsoXmlTag("SubPngAgt")]
    public ValueList<PartyIdentification120Choice_> SubPayingAgent { get; init; } = [];

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}

// Since CorporateActionCancellationAdviceV13Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CorporateActionCancellationAdviceV13.
