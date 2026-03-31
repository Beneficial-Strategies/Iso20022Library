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
/// This record is an implementation of the seev.037.002.15 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_U-vkw3SdEe6VWZz2tTgENw")]
[DisplayName("Corporate Action Movement Reversal Advice002V15")]
public record CorporateActionMovementReversalAdvice002V15 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.037.002.15";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnMvmntRvslAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.037.002.15";

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
    public required AccountAndBalance54 AccountDetails { get; init; }

    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative35? AdditionalInformation { get; init; }

    /// <summary>
    /// Corporate Action Confirmation Details.
    /// </summary>
    [DisplayName("Corporate Action Confirmation Details")]
    [IsoXmlTag("CorpActnConfDtls")]
    public required CorporateActionOption227 CorporateActionConfirmationDetails { get; init; }

    /// <summary>
    /// Corporate Action Details.
    /// </summary>
    [DisplayName("Corporate Action Details")]
    [IsoXmlTag("CorpActnDtls")]
    public CorporateAction78? CorporateActionDetails { get; init; }

    /// <summary>
    /// Corporate Action General Information.
    /// </summary>
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionGeneralInformation167 CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// Events Linkage.
    /// </summary>
    [DisplayName("Events Linkage")]
    [IsoXmlTag("EvtsLkg")]
    public ValueList<CorporateActionEventReference4> EventsLinkage { get; init; } = [];

    /// <summary>
    /// Issuer Agent.
    /// </summary>
    [DisplayName("Issuer Agent")]
    [IsoXmlTag("IssrAgt")]
    public ValueList<PartyIdentification137Choice_> IssuerAgent { get; init; } = [];

    /// <summary>
    /// Movement Confirmation Identification.
    /// </summary>
    [DisplayName("Movement Confirmation Identification")]
    [IsoXmlTag("MvmntConfId")]
    public required DocumentIdentification37 MovementConfirmationIdentification { get; init; }

    /// <summary>
    /// Other Document Identification.
    /// </summary>
    [DisplayName("Other Document Identification")]
    [IsoXmlTag("OthrDocId")]
    public ValueList<DocumentIdentification38> OtherDocumentIdentification { get; init; } = [];

    /// <summary>
    /// Paying Agent.
    /// </summary>
    [DisplayName("Paying Agent")]
    [IsoXmlTag("PngAgt")]
    public ValueList<PartyIdentification137Choice_> PayingAgent { get; init; } = [];

    /// <summary>
    /// Reversal Reason.
    /// </summary>
    [DisplayName("Reversal Reason")]
    [IsoXmlTag("RvslRsn")]
    public CorporateActionReversalReason7? ReversalReason { get; init; }

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
    /// Transaction Identification.
    /// </summary>
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public TransactionIdentification1? TransactionIdentification { get; init; }
}

// Since CorporateActionMovementReversalAdvice002V15Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CorporateActionMovementReversalAdvice002V15.
