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
/// This record is an implementation of the seev.035.001.16 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_4bkCTX_4Ee-h086v0qPiyQ")]
[DisplayName("Corporate Action Movement Preliminary Advice V16")]
public record CorporateActionMovementPreliminaryAdviceV16 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.035.001.16";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnMvmntPrlimryAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.035.001.16";

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
    public required AccountIdentification70Choice_ AccountDetails { get; init; }

    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative56? AdditionalInformation { get; init; }

    /// <summary>
    /// Corporate Action Details.
    /// </summary>
    [DisplayName("Corporate Action Details")]
    [IsoXmlTag("CorpActnDtls")]
    public CorporateAction69? CorporateActionDetails { get; init; }

    /// <summary>
    /// Corporate Action General Information.
    /// </summary>
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionGeneralInformation178 CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// Corporate Action Movement Details.
    /// </summary>
    [DisplayName("Corporate Action Movement Details")]
    [IsoXmlTag("CorpActnMvmntDtls")]
    public ValueList<CorporateActionOption232> CorporateActionMovementDetails { get; init; } = [];

    /// <summary>
    /// Drop Agent.
    /// </summary>
    [DisplayName("Drop Agent")]
    [IsoXmlTag("DrpAgt")]
    public PartyIdentification120Choice_? DropAgent { get; init; }

    /// <summary>
    /// Events Linkage.
    /// </summary>
    [DisplayName("Events Linkage")]
    [IsoXmlTag("EvtsLkg")]
    public ValueList<CorporateActionEventReference3> EventsLinkage { get; init; } = [];

    /// <summary>
    /// Information Agent.
    /// </summary>
    [DisplayName("Information Agent")]
    [IsoXmlTag("InfAgt")]
    public PartyIdentification120Choice_? InformationAgent { get; init; }

    /// <summary>
    /// Instruction Identification.
    /// </summary>
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    public DocumentIdentification9? InstructionIdentification { get; init; }

    /// <summary>
    /// Issuer.
    /// </summary>
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyIdentification129Choice_? Issuer { get; init; }

    /// <summary>
    /// Issuer Agent.
    /// </summary>
    [DisplayName("Issuer Agent")]
    [IsoXmlTag("IssrAgt")]
    public ValueList<PartyIdentification129Choice_> IssuerAgent { get; init; } = [];

    /// <summary>
    /// Movement Confirmation Identification.
    /// </summary>
    [DisplayName("Movement Confirmation Identification")]
    [IsoXmlTag("MvmntConfId")]
    public DocumentIdentification31? MovementConfirmationIdentification { get; init; }

    /// <summary>
    /// Movement Preliminary Advice General Information.
    /// </summary>
    [DisplayName("Movement Preliminary Advice General Information")]
    [IsoXmlTag("MvmntPrlimryAdvcGnlInf")]
    public required CorporateActionPreliminaryAdviceType4 MovementPreliminaryAdviceGeneralInformation { get; init; }

    /// <summary>
    /// Notification Identification.
    /// </summary>
    [DisplayName("Notification Identification")]
    [IsoXmlTag("NtfctnId")]
    public DocumentIdentification31? NotificationIdentification { get; init; }

    /// <summary>
    /// Offeror.
    /// </summary>
    [DisplayName("Offeror")]
    [IsoXmlTag("Offerr")]
    public ValueList<PartyIdentification129Choice_> Offeror { get; init; } = [];

    /// <summary>
    /// Other Document Identification.
    /// </summary>
    [DisplayName("Other Document Identification")]
    [IsoXmlTag("OthrDocId")]
    public ValueList<DocumentIdentification32> OtherDocumentIdentification { get; init; } = [];

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
    public ValueList<PartyIdentification120Choice_> PayingAgent { get; init; } = [];

    /// <summary>
    /// Physical Securities Agent.
    /// </summary>
    [DisplayName("Physical Securities Agent")]
    [IsoXmlTag("PhysSctiesAgt")]
    public PartyIdentification120Choice_? PhysicalSecuritiesAgent { get; init; }

    /// <summary>
    /// Previous Movement Preliminary Advice Identification.
    /// </summary>
    [DisplayName("Previous Movement Preliminary Advice Identification")]
    [IsoXmlTag("PrvsMvmntPrlimryAdvcId")]
    public DocumentIdentification31? PreviousMovementPreliminaryAdviceIdentification { get; init; }

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
    /// Reversal Reason.
    /// </summary>
    [DisplayName("Reversal Reason")]
    [IsoXmlTag("RvslRsn")]
    public CorporateActionReversalReason8? ReversalReason { get; init; }

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

    /// <summary>
    /// Transfer Agent.
    /// </summary>
    [DisplayName("Transfer Agent")]
    [IsoXmlTag("TrfAgt")]
    public PartyIdentification129Choice_? TransferAgent { get; init; }
}

// Since CorporateActionMovementPreliminaryAdviceV16Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CorporateActionMovementPreliminaryAdviceV16.
