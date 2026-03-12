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



namespace BeneficialStrategies.Iso20022.pacs;

/// <summary>
/// This record is an implementation of the pacs.029.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The MultilateralSettlementRequest message is sent from an instructing agent to a market infrastructure to settle obligations between their participants using accounts held in a settlement service.
/// 
/// Usage: The MultilateralSettlementRequest message can contain one or more settlement instructions with multiple movements between accounts. By default, all movements present in an individual instruction shall be processed as a batch entry rather than a single entry per individual movement.
/// </summary>
[Description(@"The MultilateralSettlementRequest message is sent from an instructing agent to a market infrastructure to settle obligations between their participants using accounts held in a settlement service.||Usage: The MultilateralSettlementRequest message can contain one or more settlement instructions with multiple movements between accounts. By default, all movements present in an individual instruction shall be processed as a batch entry rather than a single entry per individual movement.")]
[IsoId("_vsvOgQcYEeyTDbUIoCmuCw")]
[DisplayName("Multilateral Settlement Request V")]
public partial record MultilateralSettlementRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pacs.029.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MulSttlmReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pacs.029.001.01";
    
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
    /// Set of characteristics shared by all individual instructions included in the message.
    /// </summary>
    [IsoId("_vsvOgwcYEeyTDbUIoCmuCw")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader104 GroupHeader { get; init; } 
    
    /// <summary>
    /// Set of elements providing information specific to the individual settlement request(s).
    /// </summary>
    [IsoId("_vsvOhQcYEeyTDbUIoCmuCw")]
    [DisplayName("Settlement Request")]
    [IsoXmlTag("SttlmReq")]
    public required MultilateralSettlementRequest2 SettlementRequest { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_vsvOhwcYEeyTDbUIoCmuCw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since MultilateralSettlementRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MultilateralSettlementRequestV01.

