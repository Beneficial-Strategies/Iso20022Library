// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;



namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// This record is an implementation of the reda.014.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope:|The PartyCreationRequest message is sent by an instructing party to the executing party to request for the creation of party reference data for a new party in the executing system.||Usage:|It aims at instructing the creation of a new party with corresponding details.|Processing and confirmation of the party creation request are provided via a party status advice.
/// </summary>
[Description(@"Scope:|The PartyCreationRequest message is sent by an instructing party to the executing party to request for the creation of party reference data for a new party in the executing system.||Usage:|It aims at instructing the creation of a new party with corresponding details.|Processing and confirmation of the party creation request are provided via a party status advice.")]
[IsoId("_lfqucZeTEeen_cyMrluY4w")]
[DisplayName("Party Creation Request V")]
public partial record PartyCreationRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.014.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PtyCreReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.014.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #nullable enable
    
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_c7obABivEeiGdqyppFhcBA")]
    [DisplayName("Message Header")]
    [IsoXmlTag("MsgHdr")]
    public MessageHeader1? MessageHeader { get; init; } 
    
    /// <summary>
    /// Specifies the details of the party to be created in the system.
    /// </summary>
    [IsoId("_H_lCYBiwEei5IMHVES5gUw")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public required SystemParty4 Party { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_lfque5eTEeen_cyMrluY4w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since PartyCreationRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PartyCreationRequestV01.

