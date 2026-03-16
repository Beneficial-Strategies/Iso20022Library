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
/// This record is an implementation of the seev.031.002.14 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_U_bhQ3SdEe6VWZz2tTgENw")]
[DisplayName("Corporate Action Notification002V14")]
public record CorporateActionNotification002V14 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.031.002.14";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnNtfctn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.031.002.14";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Account Details.
    /// </summary>
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required AccountIdentification57Choice_ AccountDetails { get; init; }

    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative65? AdditionalInformation { get; init; }

    /// <summary>
    /// Corporate Action Details.
    /// </summary>
    [DisplayName("Corporate Action Details")]
    [IsoXmlTag("CorpActnDtls")]
    public CorporateAction81? CorporateActionDetails { get; init; }

    /// <summary>
    /// Corporate Action General Information.
    /// </summary>
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionGeneralInformation170 CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// Corporate Action Option Details.
    /// </summary>
    [DisplayName("Corporate Action Option Details")]
    [IsoXmlTag("CorpActnOptnDtls")]
    public ValueList<CorporateActionOption228> CorporateActionOptionDetails { get; init; } = [];

    /// <summary>
    /// Drop Agent.
    /// </summary>
    [DisplayName("Drop Agent")]
    [IsoXmlTag("DrpAgt")]
    public PartyIdentification137Choice_? DropAgent { get; init; }

    /// <summary>
    /// Events Linkage.
    /// </summary>
    [DisplayName("Events Linkage")]
    [IsoXmlTag("EvtsLkg")]
    public ValueList<CorporateActionEventReference4> EventsLinkage { get; init; } = [];

    /// <summary>
    /// Information Agent.
    /// </summary>
    [DisplayName("Information Agent")]
    [IsoXmlTag("InfAgt")]
    public PartyIdentification137Choice_? InformationAgent { get; init; }

    /// <summary>
    /// Instruction Identification.
    /// </summary>
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    public DocumentIdentification17? InstructionIdentification { get; init; }

    /// <summary>
    /// Intermediate Security.
    /// </summary>
    [DisplayName("Intermediate Security")]
    [IsoXmlTag("IntrmdtScty")]
    public FinancialInstrumentAttributes117? IntermediateSecurity { get; init; }

    /// <summary>
    /// Issuer.
    /// </summary>
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyIdentification151Choice_? Issuer { get; init; }

    /// <summary>
    /// Issuer Agent.
    /// </summary>
    [DisplayName("Issuer Agent")]
    [IsoXmlTag("IssrAgt")]
    public ValueList<PartyIdentification151Choice_> IssuerAgent { get; init; } = [];

    /// <summary>
    /// Notification General Information.
    /// </summary>
    [DisplayName("Notification General Information")]
    [IsoXmlTag("NtfctnGnlInf")]
    public required CorporateActionNotification11 NotificationGeneralInformation { get; init; }

    /// <summary>
    /// Offeror.
    /// </summary>
    [DisplayName("Offeror")]
    [IsoXmlTag("Offerr")]
    public ValueList<PartyIdentification151Choice_> Offeror { get; init; } = [];

    /// <summary>
    /// Other Document Identification.
    /// </summary>
    [DisplayName("Other Document Identification")]
    [IsoXmlTag("OthrDocId")]
    public ValueList<DocumentIdentification38> OtherDocumentIdentification { get; init; } = [];

    /// <summary>
    /// Pagination.
    /// </summary>
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public Pagination1? Pagination { get; init; }

    /// <summary>
    /// Paying Agent.
    /// </summary>
    [DisplayName("Paying Agent")]
    [IsoXmlTag("PngAgt")]
    public ValueList<PartyIdentification137Choice_> PayingAgent { get; init; } = [];

    /// <summary>
    /// Physical Securities Agent.
    /// </summary>
    [DisplayName("Physical Securities Agent")]
    [IsoXmlTag("PhysSctiesAgt")]
    public PartyIdentification137Choice_? PhysicalSecuritiesAgent { get; init; }

    /// <summary>
    /// Previous Notification Identification.
    /// </summary>
    [DisplayName("Previous Notification Identification")]
    [IsoXmlTag("PrvsNtfctnId")]
    public DocumentIdentification37? PreviousNotificationIdentification { get; init; }

    /// <summary>
    /// Registrar.
    /// </summary>
    [DisplayName("Registrar")]
    [IsoXmlTag("Regar")]
    public PartyIdentification137Choice_? Registrar { get; init; }

    /// <summary>
    /// Reselling Agent.
    /// </summary>
    [DisplayName("Reselling Agent")]
    [IsoXmlTag("RsellngAgt")]
    public ValueList<PartyIdentification137Choice_> ResellingAgent { get; init; } = [];

    /// <summary>
    /// Solicitation Agent.
    /// </summary>
    [DisplayName("Solicitation Agent")]
    [IsoXmlTag("SlctnAgt")]
    public ValueList<PartyIdentification137Choice_> SolicitationAgent { get; init; } = [];

    /// <summary>
    /// Sub Paying Agent.
    /// </summary>
    [DisplayName("Sub Paying Agent")]
    [IsoXmlTag("SubPngAgt")]
    public ValueList<PartyIdentification137Choice_> SubPayingAgent { get; init; } = [];

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    /// <summary>
    /// Transfer Agent.
    /// </summary>
    [DisplayName("Transfer Agent")]
    [IsoXmlTag("TrfAgt")]
    public PartyIdentification151Choice_? TransferAgent { get; init; }
}

// Since CorporateActionNotification002V14Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CorporateActionNotification002V14.
