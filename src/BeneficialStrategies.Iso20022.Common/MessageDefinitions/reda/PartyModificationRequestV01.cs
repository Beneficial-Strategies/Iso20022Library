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
/// This record is an implementation of the reda.022.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope:|The PartyModificationRequest message is sent by the instructing party to the executing party to request for an update of the party reference data of a party defined in the executing system.||Usage:|It aims at instructing the update of an existing party by amending its existing details or by providing additional details.|Processing and confirmation of the party modification request message are provided via a party status advice.
/// </summary>
[Description(
    @"Scope:|The PartyModificationRequest message is sent by the instructing party to the executing party to request for an update of the party reference data of a party defined in the executing system.||Usage:|It aims at instructing the update of an existing party by amending its existing details or by providing additional details.|Processing and confirmation of the party modification request message are provided via a party status advice."
)]
[IsoId("_xJQSoZeREeen_cyMrluY4w")]
[DisplayName("Party Modification Request V")]
public record PartyModificationRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.022.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PtyModReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.022.001.01";

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
    [IsoId("_AvsDgVhGEeih3fUfzR38Ig")]
    [DisplayName("Message Header")]
    [IsoXmlTag("MsgHdr")]
    public MessageHeader1? MessageHeader { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the executing system, to unambiguously identify the party to be modified.
    /// </summary>
    [IsoId("_xJQSqZeREeen_cyMrluY4w")]
    [DisplayName("System Party Identification")]
    [IsoXmlTag("SysPtyId")]
    public required SystemPartyIdentification8 SystemPartyIdentification { get; init; }

    /// <summary>
    /// Identifies the list of requested modifications to be executed by the system.
    /// </summary>
    [IsoId("_xJQSq5eREeen_cyMrluY4w")]
    [DisplayName("Modification")]
    [IsoXmlTag("Mod")]
    public required SystemPartyModification2 Modification { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_xJQSrZeREeen_cyMrluY4w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since PartyModificationRequestV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PartyModificationRequestV01.
