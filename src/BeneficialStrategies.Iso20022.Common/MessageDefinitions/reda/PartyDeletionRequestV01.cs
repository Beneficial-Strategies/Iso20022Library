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

namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// This record is an implementation of the reda.031.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope:
/// The PartyDeletionRequest message is sent by the instructing party to the executing party to request a deletion of a party defined in the executing system.
///
/// Usage:
/// It aims at instructing the deletion of an existing party by providing its identification.
/// Processing of the party deletion request message is provided via a party status advice.
/// </summary>
[Description(
    @"Scope:|The PartyDeletionRequest message is sent by the instructing party to the executing party to request a deletion of a party defined in the executing system.||Usage:|It aims at instructing the deletion of an existing party by providing its identification.|Processing of the party deletion request message is provided via a party status advice."
)]
[IsoId("_77TqgZeSEeen_cyMrluY4w")]
[DisplayName("Party Deletion Request V")]
public record PartyDeletionRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.031.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PtyDeltnReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.031.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_Wa5ywVhGEeih3fUfzR38Ig")]
    [DisplayName("Message Header")]
    [IsoXmlTag("MsgHdr")]
    public MessageHeader1? MessageHeader { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the executing system, to unambiguously identify the party to be deleted.
    /// </summary>
    [IsoId("_77TqhZeSEeen_cyMrluY4w")]
    [DisplayName("System Party Identification")]
    [IsoXmlTag("SysPtyId")]
    public required SystemPartyIdentification8 SystemPartyIdentification { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_77Tqh5eSEeen_cyMrluY4w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since PartyDeletionRequestV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PartyDeletionRequestV01.
